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
        DontDestroyOnLoad(this);

        domain = new dotnow.AppDomain();
    }

    public void LoadSceneAndCompileScripts()
    {
        StartCoroutine(DownloadScene());
    }

    public void LoadAssemblies()
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            AssemblyName name = assembly.GetName();
            if (name.Name == "mscorlib" || name.Name == "UnityEngine")
            {
                domain.LoadModule(assembly.Location, false);
            }
        }
    }

    IEnumerator DownloadScene()
    {
        UnityWebRequest metadataReq = UnityWebRequest.Get("https://trauty.net/immerza/immerza_metadata.json");
        yield return metadataReq.SendWebRequest();

        if (metadataReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Scene file not found!");
            yield break;
        }

        UnityWebRequest bundleReq = UnityWebRequest.Get("https://trauty.net/immerza/immerza_data.bundle");
        yield return bundleReq.SendWebRequest();

        if (bundleReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Scene file not found!");
            yield break;
        }

        ProcessBundleInMemory(bundleReq.downloadHandler.data);

        OnBundleLoaded(metadataReq.downloadHandler.text);
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


        CLRModule module = domain.LoadModuleStream(new MemoryStream(playerAssembly.bytes), false);
        
        Dictionary<string, ComponentData> componentData = sceneData.assetMetaData.componentTable;

        List<object> proxyList = new();
        List<GameObject> proxyGoList = new();

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

            Debug.Log(type.Name);

            object instance = OverrideBindings.AddComponentOverride(domain, null, curGameObject, new object[] { type });
            proxyList.Add(instance);
            proxyGoList.Add(curGameObject);
        }

        for (int i = 0; i < proxyList.Count; i++)
        {
            object prox = proxyList[i];
            string pathToGameObject = GetGameObjectPath(proxyGoList[i]);

            Dictionary<string, ValueField> fields = componentData[pathToGameObject].fields;

            foreach (KeyValuePair<string, ValueField> field in fields)
            {
                if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.SingleReference)
                {
                    if (field.Value.type == typeof(GameObject))
                    {
                        prox.GetType().GetField(field.Key).SetValue(prox, GameObject.Find(field.Value.value));
                        //prox.Fields[field.Key] = GameObject.Find(field.Value.value);
                    }
                    else
                    {
                        prox.GetType().GetField(field.Key).SetValue(prox, GameObject.Find(field.Value.value).GetComponent(field.Value.type));
                        //prox.Fields[field.Key] = GameObject.Find(field.Value.value).GetComponent(field.Value.type);
                    }
                }
                else if (field.Value.serializationType == ImmerzaSDK.Types.ValueType.SingleValue)
                {
                    prox.GetType().GetField(field.Key).SetValue(prox, Convert.ChangeType(field.Value.value, field.Value.type));

                    //prox.Fields[field.Key] = Convert.ChangeType(field.Value.value, field.Value.type);
                }
            }
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
