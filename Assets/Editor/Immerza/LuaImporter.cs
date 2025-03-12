using UnityEngine;
using UnityEditor.AssetImporters;
using System.IO;
using ImmerzaSDK.Lua;
using UnityEditor;
using ImmerzaSDK.Util;

[ScriptedImporter(1, "lua")]
public class LuaImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        string newAssetName = Path.GetFileName(ctx.assetPath);
        LuaAsset newAsset = ScriptableObject.CreateInstance<LuaAsset>();
        newAsset.content = File.ReadAllText(ctx.assetPath);

        string iconPath = ImmerzaUtil.IsRunningInPackage() ? "Packages/com.actimi.immerzasdk/Editor/Immerza/Assets/LuaIcon.png" : "Assets/Editor/Immerza/Assets/LuaIcon.png";
        Texture2D icon = AssetDatabase.LoadAssetAtPath<Texture2D>(iconPath);
        EditorGUIUtility.SetIconForObject(newAsset, icon);

        ctx.AddObjectToAsset(newAssetName, newAsset);
        ctx.SetMainObject(newAsset);
    }
}
