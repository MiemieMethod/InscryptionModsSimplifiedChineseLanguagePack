#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
从 SimplifiedChineseLanguagePack.cs 的模组类结构 + 现有批次文件的文言译文，
生成以模组命名的 .cs 类文件，并更新 ClassicChineseLanguagePack.cs。
"""

import re
import os
import sys
from collections import OrderedDict

SOURCE_FILE = r"E:\InscryptionModsSimplifiedChineseLanguagePack\.knowledge\SimplifiedChineseLanguagePack.cs"
BATCH_DIR   = r"E:\InscryptionModsSimplifiedChineseLanguagePack"
OUTPUT_DIR  = r"E:\InscryptionModsSimplifiedChineseLanguagePack"
MAIN_CS     = r"E:\InscryptionModsSimplifiedChineseLanguagePack\ClassicChineseLanguagePack.cs"
VANILLA_CS  = r"E:\InscryptionModsSimplifiedChineseLanguagePack\InscryptionVanilla.cs"

# ---------- helpers ----------

def _unescape_cs(s):
    """Reverse C# string escape sequences for dict lookup."""
    return s.replace('\\"', '"').replace('\\\\', '\\').replace('\\n', '\n').replace('\\r', '\r').replace('\\t', '\t')

def _escape_cs(s):
    """Escape a Python string for embedding in a C# verbatim double-quoted string."""
    return s.replace('\\', '\\\\').replace('"', '\\"').replace('\n', '\\n').replace('\r', '\\r').replace('\t', '\\t')

# ---------- step 1: parse source to get ordered (english, simplified) per mod ----------

def parse_source(filepath):
    """Returns:
      mod_order: list[str] of mod class names (in source order, excl. main plugin)
      mods:      dict[str -> list[(english, simplified)]]
    """
    with open(filepath, 'r', encoding='utf-8-sig') as f:
        content = f.read()

    # join physical lines so we can handle multi-line Translate() calls
    # We'll process line-by-line for class tracking, but use a single-pass regex on the whole file

    # Find class start lines
    class_re = re.compile(r'^    public class (\w+)', re.MULTILINE)
    class_positions = [(m.start(), m.group(1)) for m in class_re.finditer(content)]

    # Build mod -> (start_char, end_char) map
    mod_order = []
    mod_spans = {}
    for i, (pos, name) in enumerate(class_positions):
        if name == 'SimplifiedChineseLanguagePackPlugin':
            continue
        end = class_positions[i + 1][0] if i + 1 < len(class_positions) else len(content)
        mod_order.append(name)
        mod_spans[name] = (pos, end)

    # Translate call pattern (literal string arguments only)
    # Translate(GUID, null, "ENGLISH", "SIMPLIFIED", Language.xxx)
    trans_re = re.compile(
        r'Translate\s*\(\s*\w+(?:\.\w+)*\s*,\s*(?:null|\w+)\s*,\s*'
        r'"((?:[^"\\]|\\.)*?)"'   # english
        r'\s*,\s*'
        r'"((?:[^"\\]|\\.)*?)"',  # simplified
        re.DOTALL
    )

    mods = OrderedDict()
    for name in mod_order:
        start, end = mod_spans[name]
        chunk = content[start:end]
        entries = []
        for m in trans_re.finditer(chunk):
            eng = _unescape_cs(m.group(1))
            sim = _unescape_cs(m.group(2))
            entries.append((eng, sim))
        mods[name] = entries

    return mod_order, mods

# ---------- step 2: parse batch files for classical translations ----------

def parse_batches(batch_dir):
    """Returns dict: english -> classical  (both unescaped)"""
    classical_map = {}

    add_re = re.compile(
        r'AddTranslation\s*\(\s*'
        r'"((?:[^"\\]|\\.)*?)"'   # english
        r'\s*,\s*'
        r'"((?:[^"\\]|\\.)*?)"',  # classical
        re.DOTALL
    )

    for i in range(1, 131):
        fp = os.path.join(batch_dir, f"InscryptionModsBatch{i}.cs")
        if not os.path.exists(fp):
            continue
        with open(fp, 'r', encoding='utf-8-sig') as f:
            text = f.read()
        for m in add_re.finditer(text):
            eng = _unescape_cs(m.group(1))
            cls = _unescape_cs(m.group(2))
            classical_map[eng] = cls

    return classical_map

# ---------- step 3: write mod class files ----------

CS_HEADER = """\
using DiskCardGame;

namespace ClassicChineseLanguagePack
{{
    public class {mod_name}
    {{
        public static void RegisterTranslations()
        {{
{body}
        }}

        private static void AddTranslation(string english, string classical)
        {{
            ClassicChineseLanguagePackPlugin.Translate(
                ClassicChineseLanguagePackPlugin.GUID,
                null,
                english,
                classical,
                Language.ChineseSimplified);
        }}
    }}
}}
"""

def write_mod_file(mod_name, entries, classical_map, output_dir):
    missing = 0
    lines = []
    for eng, sim in entries:
        cls = classical_map.get(eng)
        if cls is None:
            cls = sim   # fallback: use simplified Chinese
            missing += 1
        sim_comment = sim.replace('\n', ' / ').replace('\r', '')
        lines.append(f'            // {sim_comment}')
        lines.append(f'            AddTranslation("{_escape_cs(eng)}", "{_escape_cs(cls)}");')

    body = '\n'.join(lines)
    code = CS_HEADER.format(mod_name=mod_name, body=body)

    out_path = os.path.join(output_dir, f"{mod_name}.cs")
    with open(out_path, 'w', encoding='utf-8') as f:
        f.write(code)

    return missing, out_path

# ---------- step 4: update ClassicChineseLanguagePack.cs ----------

def update_main_cs(main_cs_path, mod_order):
    with open(main_cs_path, 'r', encoding='utf-8-sig') as f:
        content = f.read()

    # Build new registration block
    reg_lines = ['            InscryptionVanilla.RegisterTranslations();']
    for mod in mod_order:
        reg_lines.append(f'            {mod}.RegisterTranslations();')
    reg_block = '\n'.join(reg_lines)

    # Replace everything between "var stopwatch ... StartNew();\n" and "stopwatch.Stop();"
    new_content = re.sub(
        r'(var stopwatch\s*=\s*System\.Diagnostics\.Stopwatch\.StartNew\(\);)\s*'
        r'(?:.*?)'
        r'(\s*stopwatch\.Stop\(\);)',
        lambda m: m.group(1) + '\n' + reg_block + '\n' + m.group(2),
        content,
        flags=re.DOTALL
    )

    with open(main_cs_path, 'w', encoding='utf-8') as f:
        f.write(new_content)

# ---------- main ----------

if __name__ == '__main__':
    print("=== Step 1: parsing SimplifiedChineseLanguagePack.cs ===")
    mod_order, mods = parse_source(SOURCE_FILE)
    total_entries = sum(len(v) for v in mods.values())
    print(f"  Found {len(mod_order)} mod classes, {total_entries} total translations")

    print("=== Step 2: parsing batch files ===")
    classical_map = parse_batches(BATCH_DIR)
    print(f"  Found {len(classical_map)} classical translations in batch files")

    print("=== Step 3: writing mod class files ===")
    total_missing = 0
    for mod_name in mod_order:
        entries = mods[mod_name]
        if not entries:
            print(f"  SKIP {mod_name} (no literal-string translations)")
            continue
        missing, path = write_mod_file(mod_name, entries, classical_map, OUTPUT_DIR)
        total_missing += missing
        status = f"  {mod_name}.cs : {len(entries)} entries, {missing} fallback to simplified"
        print(status)

    print(f"\n  Total fallback (no classical found): {total_missing}")

    print("=== Step 4: updating ClassicChineseLanguagePack.cs ===")
    # Only include mods that have entries
    active_mods = [m for m in mod_order if mods[m]]
    update_main_cs(MAIN_CS, active_mods)
    print("  Done.")

    print("\n=== All done. Next: dotnet build to verify. ===")
