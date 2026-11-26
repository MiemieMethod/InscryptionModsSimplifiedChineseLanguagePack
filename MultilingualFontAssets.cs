using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using TMPro;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{
    internal static class MultilingualFontAssets
    {
        private static readonly Dictionary<string, WeakReference<TMP_FontAsset>> Fonts = new(StringComparer.OrdinalIgnoreCase);
        private static readonly HashSet<string> MissingFonts = new(StringComparer.OrdinalIgnoreCase);
        private static AssetBundle bundle;
        private static bool searched;
        private static WeakReference<Font> legacyFont;

        internal static TMP_FontAsset GetForOriginal(TMP_FontAsset original)
        {
            if (original == null)
            {
                return null;
            }
            string name = original.name;
            if (!TryGetOfficialPath(name, out string path))
            {
                return null;
            }
            // A mod's custom font may reuse an official name. Its glyph layout
            // and material are not interchangeable with the official asset.
            return Resources.Load<TMP_FontAsset>(path) == original ? Get(name) : null;
        }

        private static bool TryGetOfficialPath(string name, out string path)
        {
            switch (name)
            {
                case "DAGGERSQUARE": case "GARBAGESCHRIFT": case "HEAVYWEIGHT": case "VICIOUSHUNGER":
                    path = "fonts/3d scene fonts/" + name;
                    return true;
                case "NotoSans_JP": case "NotoSans_KR": case "NotoSans_TC":
                case "NotoSerif_TC": case "ShipporiMincho_JP": case "Stylish_KR":
                    path = "fonts/3d scene fonts/altlanguage/" + name;
                    return true;
                case "LiberationSans SDF":
                    path = "fonts & materials/" + name;
                    return true;
                case "MINECRAFT":
                    path = "fonts/pixel art fonts/" + name;
                    return true;
                default:
                    path = null;
                    return false;
            }
        }

        // AssetBundle shaders carry bytecode only for the bundle's build
        // platform. On other platforms the shader still reports isSupported
        // (its subshader matches the GPU) but the local compiler platform is
        // missing from the blob, so every glyph draws as a solid magenta quad.
        // Never trust the bundled shader: always use the game-built one.
        internal static void RepairMaterialShader(TMP_FontAsset font, TMP_FontAsset reference, string preferredShaderName = null)
        {
            if (font == null)
            {
                return;
            }
            Material material = font.material;
            if (material == null)
            {
                return;
            }
            Shader current = material.shader;
            Shader shader = null;
            if (preferredShaderName != null)
            {
                shader = Shader.Find(preferredShaderName);
            }
            if (shader == null && reference != null && reference.material != null)
            {
                shader = reference.material.shader;
            }
            if (shader == null || !shader.isSupported || shader.name == "Hidden/InternalErrorShader")
            {
                // Keep the shader family of the bundled material: bitmap faces
                // need a bitmap shader, lit 3D faces the surface variant.
                string currentName = current != null ? current.name : string.Empty;
                string fallbackName = currentName.Contains("Bitmap") ? "TextMeshPro/Bitmap"
                    : currentName.Contains("Surface") ? "TextMeshPro/Distance Field (Surface)"
                    : "TextMeshPro/Distance Field";
                shader = Shader.Find(fallbackName) ?? Shader.Find("TextMeshPro/Distance Field");
            }
            if (shader == null || !shader.isSupported || shader == current)
            {
                return;
            }
            material.shader = shader;
            if (material.GetTexture("_MainTex") == null && font.atlasTextures.Length > 0 && font.atlasTextures[0] != null)
            {
                material.mainTexture = font.atlasTextures[0];
            }
            var atlas = material.GetTexture("_MainTex") as Texture2D;
            Debug.Log($"[FontShader] {font.name}: {current?.name ?? "null"} -> {shader.name}; atlas={(atlas != null ? atlas.format.ToString() : "null")}");
        }

        internal static TMP_FontAsset Get(string originalName)
        {
            if (string.IsNullOrEmpty(originalName) || MissingFonts.Contains(originalName))
            {
                return null;
            }
            TMP_FontAsset font = null;
            if (Fonts.TryGetValue(originalName, out var cached) && cached.TryGetTarget(out font) && font != null)
            {
                return font;
            }
            EnsureBundle();
            if (bundle != null)
            {
                string path = "assets/textmesh pro/fonts/" + originalName.ToLowerInvariant() + " expanded.asset";
                font = bundle.LoadAsset<TMP_FontAsset>(path);
            }
            if (font == null)
            {
                MissingFonts.Add(originalName);
                return null;
            }
            font.ReadFontAssetDefinition();
            TryGetOfficialPath(originalName, out string officialPath);
            RepairMaterialShader(font, officialPath == null ? null : Resources.Load<TMP_FontAsset>(officialPath));
            ReleaseStaticAtlasCopies(font);
            Fonts[originalName] = new WeakReference<TMP_FontAsset>(font);
            return font;
        }

        internal static void ReleaseStaticAtlasCopies(TMP_FontAsset font)
        {
            if (font == null || font.atlasPopulationMode != AtlasPopulationMode.Static) return;
            // A static atlas is rendered by the GPU. Retaining its CPU pixels
            // doubles the cost of large CJK pages without adding any characters.
            foreach (Texture2D atlas in font.atlasTextures)
            {
                if (atlas != null && atlas.isReadable) atlas.Apply(false, true);
            }
        }

        internal static Font GetLegacy()
        {
            if (legacyFont != null && legacyFont.TryGetTarget(out Font cached) && cached != null) return cached;
            EnsureBundle();
            if (bundle != null)
            {
                Font font = bundle.LoadAsset<Font>("assets/textmesh pro/fonts/pixellocale multilingual legacy.fontsettings");
                if (font != null) legacyFont = new WeakReference<Font>(font);
                return font;
            }
            return null;
        }

        private static void EnsureBundle()
        {
            if (!searched)
            {
                searched = true;
                foreach (string name in BundleSearchNames("multilingual_fonts"))
                {
                    foreach (string path in Directory.GetFiles(Paths.PluginPath, name, SearchOption.AllDirectories))
                    {
                        bundle = AssetBundle.LoadFromFile(path);
                        if (bundle != null)
                        {
                            Debug.Log("Loaded font bundle: " + path);
                            break;
                        }
                        Debug.LogWarning("Could not load expanded font assets: " + path);
                    }
                    if (bundle != null)
                    {
                        break;
                    }
                }
            }
        }

        // Platform-specific bundles ship beside the Windows ones with an _osx
        // suffix; fall back to the plain name when the native one is absent.
        internal static IEnumerable<string> BundleSearchNames(string baseName)
        {
            if (Application.platform == RuntimePlatform.OSXPlayer)
            {
                yield return baseName + "_osx";
            }
            yield return baseName;
        }
    }
}
