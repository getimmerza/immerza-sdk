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
using System.Reflection;
using Newtonsoft.Json;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using SharpCompress.Archives;

public enum ComponentValueType
{
    SingleValue,
    ArrayValue,
    SingleReference,
    ArrayReference,
    AssetReference
}

public class ImmerzaSceneBundler : EditorWindow
{
    private VisualTreeAsset treeAsset = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private TextField scriptsPath = null;
    private EnumField buildTarget = null;
    private Button setupBtn = null;
    private Button exportBtn = null;
    private Label successLabel = null;

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        EditorWindow window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");

        rootVisualElement.Add(new Label());
        Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;
        immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Editor/Immerza/Assets/ImmerzaLogo.png");
        rootVisualElement.Add(immerzaLogo);

        treeAsset.CloneTree(rootVisualElement);

        scenesView = rootVisualElement.Q<ListView>("SceneList");
        path = rootVisualElement.Q<TextField>("ExportPath");
        scriptsPath = rootVisualElement.Q<TextField>("ScriptsPath");
        buildTarget = rootVisualElement.Q<EnumField>("PlatformEnum");
        buildTarget.Init(BuildTarget.Android);
        setupBtn = rootVisualElement.Q<Button>("SetupButton");
        setupBtn.SetEnabled(false);
        setupBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        setupBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        exportBtn = rootVisualElement.Q<Button>("ExportButton");
        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        successLabel = rootVisualElement.Q<Label>("SuccessLabel");
        successLabel.visible = false;

        string[] allSceneGuids = AssetDatabase.FindAssets("t:SceneAsset", new[] { "Assets" });
        List<SceneAsset> allScenes = new List<SceneAsset>();

        foreach (string guid in allSceneGuids)
        {
            allScenes.Add(AssetDatabase.LoadAssetAtPath<SceneAsset>(AssetDatabase.GUIDToAssetPath(guid)));
        }

        scenesView.makeItem = () => new Label();
        scenesView.bindItem = (item, index) => { (item as Label).text = allScenes[index].name; };
        scenesView.itemsSource = allScenes;

        scenesView.selectionChanged += SceneSelected;
        setupBtn.clicked += SetupScene;
        exportBtn.clicked += ExportScene;
    }

    private void SceneSelected(IEnumerable<object> scenes)
    {
        SceneAsset scene = scenes.First() as SceneAsset;
        if (scene == null)
        {
            return;
        }

        sceneToExport = scene;

        if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.dataPath), scriptsPath.text, scene.name + ".asmdef")))
        {
            exportBtn.SetEnabled(true);
            exportBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
            exportBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);

            setupBtn.SetEnabled(false);
            setupBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
            setupBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        }
        else
        {
            exportBtn.SetEnabled(false);
            exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
            exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);

            setupBtn.SetEnabled(true);
            setupBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
            setupBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
        }
    }

    private void SetupScene()
    {
        CreateAssemblyDefinition(sceneToExport.name, Path.Combine(Path.GetDirectoryName(Application.dataPath), scriptsPath.text, sceneToExport.name + ".asmdef"), Path.Combine(scriptsPath.text, sceneToExport.name + ".asmdef"));

        setupBtn.SetEnabled(false);
        setupBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        setupBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);

        exportBtn.SetEnabled(true);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
        exportBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
    }

    private void ExportScene()
    {
        ImmerzaUtil.InitCrcTable();

        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(sceneToExport));

        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), path.text);

        SceneMetadata sceneMetadata = new SceneMetadata();

        AssetMetadata assetMetadata = new AssetMetadata();

        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string originalScenePath = SceneManager.GetActiveScene().path;
        string newScenePath = originalScenePath.Replace(".unity", "_Temp.unity");

        AssetDatabase.CopyAsset(originalScenePath, newScenePath);
        AssetDatabase.Refresh();

        Scene activeScene = EditorSceneManager.OpenScene(newScenePath);

        string[] scriptGUIDs = AssetDatabase.FindAssets("t:MonoScript", new[] { scriptsPath.text });
        HashSet<string> validClassNames = new HashSet<string>();

        foreach (string scriptGUID in scriptGUIDs)
        {
            string scriptPath = AssetDatabase.GUIDToAssetPath(scriptGUID);

            MonoScript monoScript = AssetDatabase.LoadAssetAtPath<MonoScript>(scriptPath);
            if (monoScript != null)
            {
                Type type = monoScript.GetClass();
                if (type != null)
                {
                    if (type.IsSubclassOf(typeof(MonoBehaviour)))
                    {
                        validClassNames.Add(type.Name);
                    }
                }
            }
        }

        try
        {
            foreach (GameObject obj in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                MonoBehaviour[] scripts = obj.GetComponentsInChildren<MonoBehaviour>(true);

                foreach (MonoBehaviour script in scripts)
                {
                    Type classType = script.GetType();

                    if (validClassNames.Contains(classType.Name))
                    {
                        FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        Dictionary<string, ValueField> values = new Dictionary<string, ValueField>();

                        foreach (FieldInfo field in fields)
                        {
                            bool isPublic = field.IsPublic;
                            bool isSerializedPrivate = field.GetCustomAttribute(typeof(SerializeField)) != null;

                            if (isPublic || isSerializedPrivate)
                            {
                                if (field.FieldType.IsClass && field.FieldType != typeof(string))
                                {
                                    UnityEngine.Object fieldData = (UnityEngine.Object)field.GetValue(script);

                                    GameObject fieldGameObject = null;

                                    if (fieldData is GameObject @object)
                                    {
                                        fieldGameObject = @object;
                                    }
                                    else if (fieldData is UnityEngine.Component component)
                                    {
                                        fieldGameObject = component.gameObject;
                                    }

                                    ValueField fieldValue = new ValueField()
                                    {
                                        value = ImmerzaUtil.GetHierarchyPath(fieldGameObject),
                                        type = field.FieldType,
                                        serializationType = ImmerzaSDK.Types.ValueType.SingleReference
                                    };

                                    values.Add(field.Name, fieldValue);
                                }
                                else if (field.FieldType.IsPrimitive)
                                {
                                    ValueField fieldValue = new ValueField()
                                    {
                                        value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Error }),
                                        type = field.FieldType,
                                        serializationType = ImmerzaSDK.Types.ValueType.SingleValue
                                    };

                                    values.Add(field.Name, fieldValue);
                                }
                            }
                        }

                        assetMetadata.AddComponent(ImmerzaUtil.GetHierarchyPath(script.gameObject), classType.Name, values);
                        DestroyImmediate(script);
                    }
                }
            }
        }
        catch (Exception exc)
        {
            Debug.LogException(exc);
            EditorSceneManager.OpenScene(originalScenePath);
            AssetDatabase.DeleteAsset(newScenePath);
            AssetDatabase.Refresh();
            SetSuccessMsg(false);
            return;
        }

        EditorSceneManager.SaveScene(activeScene);

        List<string> assetPaths = new List<string>();

        string scenePath = activeScene.path;
        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        string assemblyAssetPath = Path.Combine(scriptsPath.text, sceneToExport.name + ".txt");
        string assemblyPath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "Library", "ScriptAssemblies", sceneToExport.name + ".dll");
        File.Copy(assemblyPath, assemblyAssetPath);
        AssetDatabase.ImportAsset(assemblyAssetPath);
        AssetDatabase.Refresh();
        assetPaths.Add(assemblyAssetPath);
        assetMetadata.AddAsset("ImmerzaAssembly", assemblyAssetPath);

        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];

        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };

        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.None, (BuildTarget)buildTarget.value);

        sceneMetadata.assetMetaData = assetMetadata;

        try
        {
            EditorSceneManager.OpenScene(originalScenePath);

            File.Delete(Path.Combine(bundleDir, path.text));
            File.Delete(Path.Combine(bundleDir, path.text + ".manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_scene.manifest"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets.manifest"));

            string archivePath = Path.Combine(bundleDir, "immerza_data.bundle");

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
            byte[] dataAssets= File.ReadAllBytes(Path.Combine(bundleDir, "immerza_assets"));

            byte[] combined = new byte[dataScene.Length + dataAssets.Length];
            Buffer.BlockCopy(dataScene, 0, combined, 0, dataScene.Length);
            Buffer.BlockCopy(dataAssets, 0, combined, dataScene.Length, dataAssets.Length);

            uint crc = 0xffffffff;
            crc = ImmerzaUtil.ComputeChecksum(combined);

            sceneMetadata.hash = crc;
            sceneMetadata.sceneID = "0";
            sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

            File.Delete(Path.Combine(bundleDir, "immerza_scene"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets"));
        }
        catch (Exception exc)
        {
            Debug.LogException(exc);
            EditorSceneManager.OpenScene(originalScenePath);
            AssetDatabase.DeleteAsset(newScenePath);
            AssetDatabase.DeleteAsset(assemblyAssetPath);
            SetSuccessMsg(false);
            return;
        }

        AssetDatabase.DeleteAsset(newScenePath);
        AssetDatabase.DeleteAsset(assemblyAssetPath);
        SetSuccessMsg(true);
    }

    private static void CreateAssemblyDefinition(string name, string path, string assetPath)
    {
        string asmdefContent = $@"
        {{
            ""name"": ""{name}"",
            ""references"": [],
            ""includePlatforms"": [],
            ""excludePlatforms"": [],
            ""allowUnsafeCode"": false,
            ""overrideReferences"": false,
            ""precompiledReferences"": [],
            ""autoReferenced"": true,
            ""defineConstraints"": [],
            ""versionDefines"": [],
            ""noEngineReferences"": false
        }}";


        File.WriteAllText(path, asmdefContent);
        AssetDatabase.ImportAsset(assetPath);
        AssetDatabase.Refresh();
    }

    private void SetSuccessMsg(bool success)
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
            successLabel.text = "Scene export failed.";
        }
    }
}
