using ImmerzaSDK.Lua;
using System.IO;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

public static class LuaAssetCreator
{
    static readonly string DefaultScript = @"local unity = CS.UnityEngine

function start()
-- implement component start
end

function update()
-- implement component update
end";

    [MenuItem("Assets/Create/Immerza/Create Lua Script")]
    public static void CreateLuaScript()
    {
        string assetPathBase = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (string.IsNullOrEmpty(assetPathBase))
        {
            assetPathBase = "Assets";
        }

        if (Path.HasExtension(assetPathBase))
        {
            assetPathBase = assetPathBase.Replace(Path.GetFileName(assetPathBase), string.Empty);
        }

        assetPathBase = Path.Combine(assetPathBase, "New Lua Script");

        string assetPath = assetPathBase + ".lua";
        for (int i = 1; ; ++i)
        {
            if (!File.Exists(assetPath))
            {
                File.WriteAllText(assetPath, DefaultScript);
                break;
            }
            assetPath = $"{assetPathBase} {i}.lua";
        }

        AssetDatabase.ImportAsset(assetPath, ImportAssetOptions.Default);
    }
}
