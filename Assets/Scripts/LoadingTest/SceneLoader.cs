using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using SharpCompress.Readers;
using System.Linq;
using ImmerzaSDK.Types;
using dotnow.Reflection;
using Newtonsoft.Json;
using System.Reflection;
using dotnow;
using Mono.Cecil;

public class SceneLoader : MonoBehaviour
{
    private dotnow.AppDomain domain = null;

    private IEnumerable<Type> types = null;

    private AssetBundle sceneBundle = null;
    private AssetBundle dataBundle = null;

    SceneMetadata sceneData = null;
    Dictionary<string, List<string>> assetTable = null;

    private void Start()
    {
        domain = new dotnow.AppDomain();
    }

    public void LoadSceneAndCompileScripts()
    {
        DownloadScene();
    }

    void DownloadScene()
    {
        byte[] bundle = File.ReadAllBytes("C:\\Users\\traut\\Desktop\\immerza-sdk\\ImmerzaBundles\\immerza_data.bundle");
        string metadata = File.ReadAllText("C:\\Users\\traut\\Desktop\\immerza-sdk\\ImmerzaBundles\\immerza_metadata.json");

        ProcessBundleInMemory(bundle);

        OnBundleLoaded(metadata);
    }


    private void ProcessBundleInMemory(byte[] bundleData)
    {
        try
        {
            using MemoryStream bundleStream = new(bundleData);
            using var reader = ReaderFactory.Open(bundleStream);
            while (reader.MoveToNextEntry())
            {
                if (!reader.Entry.IsDirectory)
                {
                    using MemoryStream assetBundleStream = new();
                    reader.WriteEntryTo(assetBundleStream);

                    if (reader.Entry.Key == "immerza_scene.bundle")
                    {
                        sceneBundle = AssetBundle.LoadFromStream(assetBundleStream);
                    }
                    else
                    {
                        dataBundle = AssetBundle.LoadFromStream(assetBundleStream);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Decompression failed: " + e.Message);
        }
    }

    private void OnBundleLoaded(string jsonMetadata)
    {
        sceneData = JsonConvert.DeserializeObject<SceneMetadata>(jsonMetadata);
        assetTable = sceneData.assetMetaData.assetTable;

        if (sceneData == null)
        {
            return;
        }

        SceneManager.LoadSceneAsync(assetTable["ImmerzaScene"][0], LoadSceneMode.Single).completed += SceneLoaded;
    }

    private void SceneLoaded(UnityEngine.AsyncOperation obj)
    {
        obj.allowSceneActivation = true;
        SceneLoadedTest();
    }

    private void SceneLoadedTest()
    {
        TextAsset playerAssembly = dataBundle.LoadAsset<TextAsset>(assetTable["ImmerzaAssembly"][0]);

        if (playerAssembly == null)
        {
            Debug.LogError("No Assembly found!");
        }

        AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(new MemoryStream(playerAssembly.bytes));
        var referencedNamespaces = assembly.MainModule.GetTypeReferences()
                                             .Select(typeRef => typeRef.Namespace)
                                             .Where(ns => !string.IsNullOrEmpty(ns))
                                             .Distinct()
                                             .OrderBy(ns => ns);

        foreach (var ns in referencedNamespaces)
        {
            Debug.Log(ns);
        }

        foreach (var reference in assembly.MainModule.AssemblyReferences)
        {
            Debug.Log(reference.FullName);
        }

        foreach (var attribute in assembly.CustomAttributes)
        {
            Debug.Log($"Attribute: {attribute.AttributeType.FullName}");
        }

        CLRModule module = domain.LoadModuleStream(new MemoryStream(playerAssembly.bytes), false);

        foreach (var attribute in module.GetTypes())
        {
            Debug.LogWarning(attribute.Name);
        }


        Dictionary<string, List<ComponentData>> componentData = sceneData.assetMetaData.componentTable;

        List<CLRInstance> proxyList = new();
        List<GameObject> proxyGoList = new();

        /*
        foreach (KeyValuePair<string, ComponentData> data in componentData)
        {
            string goPath = data.Key;
            ComponentData compData = data.Value;

            GameObject curGameObject = GameObject.Find(goPath);

            if (curGameObject == null)
            {
                Debug.LogError("GameObject with path '" + goPath + "' not found");
                return;
            }

            Type type = module.GetTypes()
                .Where(t => t.Name == compData.className)
                .FirstOrDefault();
            
            CLRInstance instance = (CLRInstance)OverrideBindings.AddComponentOverride(domain, null, curGameObject, new object[] { type });
            proxyList.Add(instance);
            proxyGoList.Add(curGameObject);
        }
        */

        for (int i = 0; i < proxyList.Count; i++)
        {
            CLRInstance prox = proxyList[i];
            string pathToGameObject = GetGameObjectPath(proxyGoList[i]);

            Dictionary<string, ValueField> fields = componentData[pathToGameObject][0].fields;
            List<CLRField> clrFieldList = prox.GetCLRInterpretedType().GetInstanceFields(); // this is bad, need to ask developer, how to directly access fields
            clrFieldList.Reverse();
            int clrFieldIndex = 0;

            /*
            foreach (KeyValuePair<string, ValueField> field in fields)
            {
                Debug.Log(clrFieldList[clrFieldIndex].Name);
                if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.SingleReference)
                {
                    if (field.Value.type == typeof(GameObject))
                    {
                        prox.SetFieldValue(clrFieldList[clrFieldIndex], GameObject.Find(field.Value.value));
                    }
                    else
                    {
                        prox.SetFieldValue(clrFieldList[clrFieldIndex], GameObject.Find(field.Value.value).GetComponent(field.Value.type));
                    }
                }
                else if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.SingleValue)
                {
                    prox.SetFieldValue(clrFieldList[clrFieldIndex], Convert.ChangeType(field.Value.value, field.Value.type));

                }
                else if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.ArrayValue)
                {
                    Debug.Log("MULTIPLE VALUES");
                }
                else if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.ArrayReference)
                {

                    Debug.Log(dataBundle.LoadAsset("Assets/Materials/ControllerGrey_Mat.mat", typeof(Material)));
                    //prox.SetFieldValue(clrFieldList[clrFieldIndex], );
                }

                clrFieldIndex++;
            }
            */
        }
            
    }

    private static string GetGameObjectPath(GameObject obj)
    {
        string path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        return path;
    }
}

public class ScriptInfo
{
    public List<string> GameObjectPaths { get; set; }
}
