#define BUILD_BUNDLE
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using SharpCompress.Writers;
using SharpCompress.Common;
using System;
using ImmerzaSDK;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Newtonsoft.Json.Linq;
using System.Collections;
using Unity.EditorCoroutines.Editor;

public class ImmerzaSceneBundler : EditorWindow
{
    public VisualTreeAsset treeAsset = null;
    public Sprite logoSprite = null;
    public TextAsset dummyFile = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private Button exportBtn = null;
    private Button refreshBtn = null;
    private Label successLabel = null;
    private Toggle openExportFolderTgl = null;

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        ImmerzaSceneBundler window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
		root.Add(new Label());
		Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;

        immerzaLogo.sprite = logoSprite;

        immerzaLogo.style.marginTop = 20.0f;
        immerzaLogo.style.marginLeft = 10.0f;
        immerzaLogo.style.marginRight = 10.0f;
        immerzaLogo.style.marginBottom = 5.0f;
        root.Add(immerzaLogo);

        treeAsset.CloneTree(root);

        scenesView = root.Q<ListView>("SceneList");
        path = root.Q<TextField>("ExportPath");
        exportBtn = root.Q<Button>("ExportButton");
        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        refreshBtn = root.Q<Button>("RefreshButton");
        successLabel = root.Q<Label>("SuccessLabel");
        successLabel.visible = false;

        openExportFolderTgl = root.Q<Toggle>("OpenExportFolder");

        UpdateSceneList();

        scenesView.selectionChanged += SceneSelected;
        exportBtn.clicked += ExportScene;
        refreshBtn.clicked += UpdateSceneList;
    }

    private void UpdateSceneList()
    {
        scenesView.ClearSelection();
        scenesView.itemsSource = null;

        string[] allSceneGuids = AssetDatabase.FindAssets("t:SceneAsset", new[] { "Assets" });
        List<SceneAsset> allScenes = new();

        foreach (string guid in allSceneGuids)
        {
            allScenes.Add(AssetDatabase.LoadAssetAtPath<SceneAsset>(AssetDatabase.GUIDToAssetPath(guid)));
        }

        scenesView.makeItem = () => new Label();
        scenesView.bindItem = (item, index) => { (item as Label).text = allScenes[index].name; };
        scenesView.itemsSource = allScenes;

        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
    }

    private void SceneSelected(IEnumerable<object> scenes)
    {
        if (!scenes.Any()) { return; }

        SceneAsset scene = scenes.First() as SceneAsset;
        if (scene == null)
        {
            return;
        }

        sceneToExport = scene;

        exportBtn.SetEnabled(true);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
        exportBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
    }

    private void ExportScene()
    {
        ImmerzaUtil.InitCrcTable();

        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(sceneToExport));

        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), path.text);

        SceneMetadata sceneMetadata = new();
        AssetMetadata assetMetadata = new();

        List<string> assetPaths = new();

        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string scenePath = SceneManager.GetActiveScene().path;

        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        ImmerzaUtil.AddAssetPath(assetPaths, AssetDatabase.GetAssetPath(dummyFile));
        assetMetadata.AddAsset("Gen", "NONE");

        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];

        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };

        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        sceneMetadata.sdkVersion = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Immerza/Version.txt").ToString();

        ExportBundles(bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.Android);
        ExportBundles(bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.StandaloneWindows64);
        sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

        SetSuccessMsg(true);

        if (openExportFolderTgl.value)
        {
            Process.Start("explorer.exe", bundleDir);
        }
    }

    private void ExportBundles(string bundleDir, AssetBundleBuild[] exportMap, SceneMetadata sceneMetadata, AssetMetadata assetMetadata, BuildTarget platform)
    {
        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.ForceRebuildAssetBundle, platform);
        sceneMetadata.assetMetaData = assetMetadata;

        string platformId = platform == BuildTarget.Android ? "android" : "win";

        sceneMetadata.isUsingBgMusic = FindAnyObjectByType<BackgroundAudio>(FindObjectsInactive.Include) != null;

        try
        {
            File.Delete(Path.Combine(bundleDir, path.text));
            File.Delete(Path.Combine(bundleDir, path.text + ".manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_scene.manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets.manifest"));

            string archivePath = Path.Combine(bundleDir, "immerza_scene_" + platformId + ".bundle");

            if (File.Exists(archivePath))
            {
                File.Delete(archivePath);
            }

            using (Stream stream = File.OpenWrite(archivePath))
            using (IWriter writer = WriterFactory.Open(stream, ArchiveType.Tar, SharpCompress.Common.CompressionType.GZip))
            {
                writer.Write("immerza_scene.bundle", Path.Combine(bundleDir, "immerza_scene"));
                writer.Write("immerza_assets.bundle", Path.Combine(bundleDir, "immerza_assets"));
            }

            byte[] dataScene = File.ReadAllBytes(Path.Combine(bundleDir, "immerza_scene"));
            byte[] dataAssets = File.ReadAllBytes(Path.Combine(bundleDir, "immerza_assets"));

            byte[] combined = new byte[dataScene.Length + dataAssets.Length];
            Buffer.BlockCopy(dataScene, 0, combined, 0, dataScene.Length);
            Buffer.BlockCopy(dataAssets, 0, combined, dataScene.Length, dataAssets.Length);

            uint crc = 0xffffffff;
            crc = ImmerzaUtil.ComputeChecksum(combined);

            sceneMetadata.platforms.Add(new PlatformInfo(platformId, crc));

#if BUILD_BUNDLE
            File.Delete(Path.Combine(bundleDir, "immerza_scene"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets"));
#endif
        }
        catch (Exception exc)
        {
            System.IO.DirectoryInfo di = new(bundleDir);

            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }

            UnityEngine.Debug.LogException(exc);
            SetSuccessMsg(false);
        }
    }

    private void SetSuccessMsg(bool success, string message)
    {
        successLabel.visible = true;
        if (success)
        {
            successLabel.style.color = new Color(0.36f, 1.0f, 0.36f);
            successLabel.text = "Scene successfully exported.";
        }
        else
        {
            successLabel.style.color = new Color(1.0f, 0.36f, 0.36f);
            successLabel.text = message == null ? message : "Scene export failed.";
        }
    }

    private void SetSuccessMsg(bool success)
    {
        SetSuccessMsg(success, null);
    }
}
