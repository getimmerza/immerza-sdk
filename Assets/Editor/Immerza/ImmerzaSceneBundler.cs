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
using System.Diagnostics;
using static UnityEngine.GraphicsBuffer;
using Debug = UnityEngine.Debug;

public class ImmerzaSceneBundler : EditorWindow
{
    private VisualTreeAsset treeAsset = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private TextField scriptsPath = null;
    private EnumField buildTarget = null;
    private Button exportBtn = null;
    private Label successLabel = null;

    string unityAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "Managed");
    string generalAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "UnityReferenceAssemblies", "unity-4.8-api");
    //string packageAssembliesPath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "Library", "ScriptAssemblies");

    private string sceneCachePath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "ImmerzaSceneCache");

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        ImmerzaSceneBundler window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");

        root.Add(new Label());
        Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;
        immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Editor/Immerza/Assets/ImmerzaLogo.png");
        immerzaLogo.style.marginTop = 20.0f;
        root.Add(immerzaLogo);

        treeAsset.CloneTree(root);

        scenesView = root.Q<ListView>("SceneList");
        path = root.Q<TextField>("ExportPath");
        scriptsPath = root.Q<TextField>("ScriptsPath");
        buildTarget = root.Q<EnumField>("PlatformEnum");
        buildTarget.Init(BuildTarget.Android);
        exportBtn = root.Q<Button>("ExportButton");
        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new UnityEngine.Color(0.3f, 0.3f, 0.3f);
        successLabel = root.Q<Label>("SuccessLabel");
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

        exportBtn.SetEnabled(true);
        exportBtn.style.backgroundColor = new UnityEngine.Color(0.4f, 0.4f, 0.4f);
        exportBtn.style.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f);
    }

    private void ExportScene()
    {
        if (!CompileAssembly())
        {
            return;
        }
        SetSuccessMsg(true);

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
                                if (ImmerzaUtil.IsFieldAPrimitiveList(field.FieldType) || ImmerzaUtil.IsFieldAPrimitiveArray(field.FieldType))
                                {
                                    ValueField fieldValue = new ValueField()
                                    {
                                        value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Error }),
                                        type = field.FieldType,
                                        serializationType = ImmerzaSDK.Types.ValueType.ArrayValue
                                    };

                                    values.Add(field.Name, fieldValue);
                                }
                                else if (ImmerzaUtil.IsFieldAReferenceList(field.FieldType))
                                {
                                    Debug.Log("List: " + field.FieldType.Name);
                                }
                                else if (ImmerzaUtil.IsFieldAReferenceArray(field.FieldType))
                                {
                                    Debug.Log("Array: " + field.FieldType.Name);
                                }
                                else if (field.FieldType.IsClass && field.FieldType != typeof(string) && field.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
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
                                else if (field.FieldType.IsPrimitive || field.FieldType == typeof(string))
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
            UnityEngine.Debug.LogException(exc);
            EditorSceneManager.OpenScene(originalScenePath);
            AssetDatabase.DeleteAsset(newScenePath);
            AssetDatabase.Refresh();
            SetSuccessMsg(false);
            return;
        }

        EditorSceneManager.SaveScene(activeScene);

        List<string> assetPaths = new();

        string scenePath = activeScene.path;
        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        string assemblyAssetPath = scriptsPath.text + "/" + sceneToExport.name + ".dll.txt";
        string assemblyPath = Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".dll");
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
            UnityEngine.Debug.LogException(exc);
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

    private bool CompileAssembly()
    {
        if (!Directory.Exists(Path.Combine(sceneCachePath, sceneToExport.name)))
        {
            Directory.CreateDirectory(Path.Combine(sceneCachePath, sceneToExport.name));
        }

        ImmerzaUtil.CopyDirectory(
            Path.Combine(Path.GetDirectoryName(Application.dataPath), scriptsPath.text), 
            Path.Combine(sceneCachePath, sceneToExport.name)
        );

#if UNITY_EDITOR_OSX
        string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime", "dotnet");
        string cscPath = Path.Combine("..", "DotNetSdkRoslyn", "csc ");
#endif
#if UNITY_EDITOR_WIN
        string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime", "dotnet.exe");
        string cscPath = Path.Combine("..", "DotNetSdkRoslyn", "csc.dll ");
#endif

        string args = cscPath;

        args += "/target:library ";

        args += $"/reference:{Path.Combine(new string[] { "..", "NetStandard", "ref", "2.1.0", "netstandard.dll" })} ";
        args += $"/reference:{Path.Combine(new string[] { "..", "Managed", "UnityEngine.dll" })} ";

        args += @$"/out:""{Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".dll")}"" ";
        args += @$"""{Path.Combine(sceneCachePath, sceneToExport.name, "*.cs")}"" ";

        UnityEngine.Debug.Log(args);

        System.Diagnostics.ProcessStartInfo processInfo = new()
        {
            CreateNoWindow = false,
            UseShellExecute = false,
            FileName = dotnetPath,
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
            RedirectStandardError = true,
            WorkingDirectory = dotnetPath.Split("dotnet")[0],

            Arguments = args
        };

        Process compilerProcess = new();
        compilerProcess.StartInfo = processInfo;
        compilerProcess.ErrorDataReceived += (sender, args) => Debug.Log($"Error: {args.Data}");
        if (!compilerProcess.Start())
        {
            SetSuccessMsg(false, "Compiler has not been found!");
            UnityEngine.Debug.LogError("Check if the path is correct: " + dotnetPath);
            return false;
        }

        compilerProcess.BeginErrorReadLine();
        compilerProcess.WaitForExit();
        return true;
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
