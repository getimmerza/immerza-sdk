using UnityEngine;
using UnityEditor.AssetImporters;
using System.IO;
using ImmerzaSDK.Lua;
using UnityEditor;
using ImmerzaSDK.Util;
using System.Linq;
using System.Collections.Generic;

[ScriptedImporter(1, "lua", AllowCaching = true)]
public class LuaImporter : ScriptedImporter
{
    static Texture2D Thumbnail = null;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        if (Thumbnail == null)
        {
            Thumbnail = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Immerza/SDK/Editor/Assets/LuaIcon.png");
        }

        LuaAsset newAsset = ScriptableObject.CreateInstance<LuaAsset>();
        newAsset.content = File.ReadAllText(ctx.assetPath);

        string newAssetName = Path.GetFileName(ctx.assetPath);
        ctx.AddObjectToAsset(newAssetName, newAsset, Thumbnail);
        ctx.SetMainObject(newAsset);

        TryIncludeLuaExtension();
    }

    private static void TryIncludeLuaExtension()
    {
        if (!EditorSettings.projectGenerationUserExtensions.Contains("lua")) {
            EditorSettings.projectGenerationUserExtensions = EditorSettings.projectGenerationUserExtensions.Concat(new[] { "lua" }).ToArray();
        }
    }
}
