using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using SharpCompress.Readers;
using ImmerzaSDK.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;
using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine.XR.OpenXR;

public class SceneLoader : MonoBehaviour
{
    private AssetBundle sceneBundle = null;
    private AssetBundle dataBundle = null;

    SceneMetadata sceneData = null;
    Dictionary<string, List<string>> assetTable = null;

    public void LoadSceneAndCompileScriptsAsync()
    {
        _ = DownloadSceneAsync();
    }

    private async Awaitable DownloadSceneAsync()
    {
        Debug.Log("Started");

        WWWForm formData = new();
        formData.AddField("email", "defaultaccount@gmail.com");
        formData.AddField("password", "defaultaccount123");
        formData.AddField("clientId", "fc86ca24-e854-4c7f-bde1-fd5bb04d9a6d");

        using UnityWebRequest req = UnityWebRequest.Post("https://api.ovok.com" + "/auth/login", formData);
        await req.SendWebRequest();

        if (req.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Login was not successful! Error: " + req.result);
            return;
        }

        JObject resObj = JObject.Parse(req.downloadHandler.text);

        string accessToken = "Bearer " + (string)resObj["access_token"];

        using UnityWebRequest metadataReq = UnityWebRequest.Get("https://api.ovok.com" + "/binary/" + "5cb50da5-ec97-41be-bdfc-7817ee44c851");
        metadataReq.SetRequestHeader("Authorization", accessToken);
        await metadataReq.SendWebRequest();
        Debug.Log(metadataReq.downloadHandler.text);

        if (metadataReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Scene file not found: " + metadataReq.downloadHandler.text);
            return;
        }

        if (JObject.Parse(metadataReq.downloadHandler.text)["scene_id"] == null)
        {
            return;
        }

        using UnityWebRequest bundleReq = UnityWebRequest.Get("https://api.ovok.com" + "/binary/" + (string)JObject.Parse(metadataReq.downloadHandler.text)["scene_id"]);
        bundleReq.SetRequestHeader("Authorization", accessToken);
        await bundleReq.SendWebRequest();

        if (bundleReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Scene file not found: " + (string)JObject.Parse(metadataReq.downloadHandler.text)["scene_id"]);
            return;
        }

        StartCoroutine(ProcessBundleInMemory(bundleReq.downloadHandler.data));
        OnBundleLoaded(metadataReq.downloadHandler.text);
    }


    private IEnumerator ProcessBundleInMemory(byte[] bundleData)
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

        yield return new WaitForSeconds(1.0f);
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
