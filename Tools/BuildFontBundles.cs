#if UNITY_EDITOR
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;

// Drop this file into Assets/Editor/ of a Unity 2021.3.2f1 project that contains
// the repository's Assets/TextMesh Pro/Fonts folder (with .meta files) and the
// TextMeshPro essential resources (Window > TextMeshPro > Import TMP Essential Resources).
public static class BuildFontBundles
{
    private const string FontsDir = "Assets/TextMesh Pro/Fonts";

    [MenuItem("Tools/Font Bundles/1. Extract Expanded Fonts From Old Bundle")]
    public static void ExtractFromOldBundle()
    {
        string path = EditorUtility.OpenFilePanel("Select the old multilingual_fonts bundle", "", "");
        if (string.IsNullOrEmpty(path)) return;
        Extract(path);
    }

    // Batchmode entry: OLD_BUNDLE_PATH=<old windows bundle> Unity -batchmode -quit
    // -nographics -projectPath <proj> -executeMethod BuildFontBundles.BatchExtractAndBuild
    public static void BatchExtractAndBuild()
    {
        string old = System.Environment.GetEnvironmentVariable("OLD_BUNDLE_PATH");
        if (!string.IsNullOrEmpty(old) && File.Exists(old))
        {
            Extract(old);
        }
        else
        {
            Debug.LogWarning("OLD_BUNDLE_PATH not set or missing; skipping extraction.");
        }
        Build();
    }

    private static void Extract(string path)
    {
        var bundle = AssetBundle.LoadFromFile(path);
        if (bundle == null)
        {
            Debug.LogError("Bundle load failed: " + path);
            return;
        }
        Directory.CreateDirectory(FontsDir);
        var map = new System.Collections.Generic.Dictionary<TMP_FontAsset, TMP_FontAsset>();
        foreach (var font in bundle.LoadAllAssets<TMP_FontAsset>())
        {
            string assetPath = FontsDir + "/" + font.name + ".asset";
            if (File.Exists(assetPath))
            {
                Debug.Log("Skip existing: " + assetPath);
                continue;
            }
            // Bundle-loaded objects are already persistent assets;
            // CreateAsset only accepts non-persistent clones.
            var clone = UnityEngine.Object.Instantiate(font);
            clone.name = font.name;
            var atlases = new System.Collections.Generic.List<Texture2D>();
            for (int i = 0; i < font.atlasTextures.Length; i++)
            {
                var atlas = font.atlasTextures[i];
                if (atlas == null) { atlases.Add(null); continue; }
                var ac = UnityEngine.Object.Instantiate(atlas);
                ac.name = font.name + " Atlas " + i;
                AssetDatabase.CreateAsset(ac, FontsDir + "/" + ac.name + ".asset");
                atlases.Add(ac);
            }
            clone.atlasTextures = atlases.ToArray();
            if (font.material != null)
            {
                var mc = UnityEngine.Object.Instantiate(font.material);
                mc.name = font.name + " Material";
                RepairShader(mc);
                AssetDatabase.CreateAsset(mc, FontsDir + "/" + mc.name + ".mat");
                clone.material = mc;
            }
            AssetDatabase.CreateAsset(clone, assetPath);
            map[font] = clone;
            Debug.Log("Extracted: " + assetPath);
        }
        foreach (var pair in map)
        {
            var table = pair.Key.fallbackFontAssetTable;
            if (table == null) continue;
            var remapped = new System.Collections.Generic.List<TMP_FontAsset>();
            foreach (var f in table)
                if (f != null && map.TryGetValue(f, out var c)) remapped.Add(c);
            pair.Value.fallbackFontAssetTable = remapped;
            EditorUtility.SetDirty(pair.Value);
        }
        bundle.Unload(false);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/Font Bundles/2. Build OSX + Windows Bundles")]
    public static void Build()
    {
        FixExtractedScripts();
        foreach (var guid in AssetDatabase.FindAssets("t:TMP_FontAsset", new[] { FontsDir }))
        {
            string p = AssetDatabase.GUIDToAssetPath(guid);
            var importer = AssetImporter.GetAtPath(p);
            if (importer == null) continue;
            importer.assetBundleName = p.EndsWith("Expanded.asset") ? "multilingual_fonts" : "chinese_font";
        }
        string outRoot = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "FontBundles");
        foreach (var target in new[] { BuildTarget.StandaloneOSX, BuildTarget.StandaloneWindows64 })
        {
            string sub = Path.Combine(outRoot, target.ToString());
            Directory.CreateDirectory(sub);
            BuildPipeline.BuildAssetBundles(sub, BuildAssetBundleOptions.ChunkBasedCompression, target);
            foreach (var file in Directory.GetFiles(sub, "*", SearchOption.TopDirectoryOnly))
            {
                if (file.EndsWith(".manifest")) continue;
                using (var fs = File.OpenRead(file))
                {
                    var header = new byte[12];
                    if (fs.Read(header, 0, 12) == 12)
                    {
                        int format = (header[8] << 24) | (header[9] << 16) | (header[10] << 8) | header[11];
                        if (format > 7)
                        {
                            Debug.LogError($"{Path.GetFileName(file)}: UnityFS format {format} > 7. The game (Unity 2021.3.2) cannot read it. Rebuild with Unity 2021.3.2f1 or 2019.4.24f1.");
                        }
                    }
                }
            }
            Debug.Log("Built " + target + " -> " + sub);
        }
        AssetDatabase.Refresh();
    }

    // Cloned bundle fonts lose their m_Script reference on save (the bundle's
    // MonoScript cannot map into the project). Relink to the project TMP script
    // or the assets are not recognized as TMP_FontAsset and skip the build.
    private static void FixExtractedScripts()
    {
        var script = AssetDatabase.LoadAssetAtPath<MonoScript>(AssetDatabase.GUIDToAssetPath("71c1514a6bd24e1e882cebbe1904ce04"));
        if (script == null)
        {
            Debug.LogError("TMP_FontAsset MonoScript not found; import TextMeshPro essential resources.");
            return;
        }
        foreach (var file in Directory.GetFiles(FontsDir, "* Expanded.asset"))
        {
            string p = file.Replace('\\', '/');
            var obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(p);
            if (obj == null) continue;
            var so = new SerializedObject(obj);
            var sp = so.FindProperty("m_Script");
            if (sp != null && sp.objectReferenceValue == null)
            {
                sp.objectReferenceValue = script;
                so.ApplyModifiedPropertiesWithoutUndo();
                Debug.Log("Relinked script: " + p);
            }
        }
    }

    private static void RepairShader(Material material)
    {
        string name = material.shader != null ? material.shader.name : string.Empty;
        string wanted = name.Contains("Bitmap") ? "TextMeshPro/Bitmap"
            : name.Contains("Surface") ? "TextMeshPro/Distance Field (Surface)"
            : "TextMeshPro/Distance Field";
        var shader = Shader.Find(wanted) ?? Shader.Find("TextMeshPro/Distance Field");
        if (shader != null) material.shader = shader;
    }
}
#endif