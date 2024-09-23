using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ImmerzaAddScriptFolder
{
    [MenuItem("Assets/Immerza/Add script folder to Addressables")]
    public static void AddScriptFolderToAddressables()
    {
        AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;

        string path = "Assets/Scripts";

        if (!AssetDatabase.IsValidFolder(path))
        {
            Debug.LogError("Script path folder invalid!");
            return;
        }

        string[] assetGUIDs = AssetDatabase.FindAssets("t:TextAsset", new[] { path });

        foreach (string guid in assetGUIDs)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            AddressableAssetEntry entry = settings.CreateOrMoveEntry(guid, settings.DefaultGroup);
            entry.address = assetPath;
            entry.SetLabel("ImmerzaScripts", true, true);
            settings.SetDirty(AddressableAssetSettings.ModificationEvent.EntryCreated, entry, true);
        }

        AssetDatabase.SaveAssets();

        Debug.Log("Script folder added!");
    }
}
