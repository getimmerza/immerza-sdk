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
using System.Reflection;
using Newtonsoft.Json;
using ImmerzaSDK;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System.Collections;
using Newtonsoft.Json.Linq;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class ImmerzaSceneBundler : EditorWindow
{
    private VisualTreeAsset treeAsset = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private TextField scriptsPath = null;
    private Button exportBtn = null;
    private Button refreshBtn = null;
    private Label successLabel = null;
    private Toggle openExportFolderTgl = null;

    //string unityAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "Managed");
    //string generalAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "UnityReferenceAssemblies", "unity-4.8-api");

    private string sceneCachePath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "ImmerzaSceneCache");

    private enum CompilationState
    {
        FAILED,
        NO_FILES,
        SUCCESS
    };

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        ImmerzaSceneBundler window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        if (IsRunningInPackage())
		{
			treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/com.actimi.immerzasdk/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");
		}
		else
		{
			treeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Immerza/ImmerzaSceneBundlerUI.uxml");
		}
		root.Add(new Label());
		Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;
		if (IsRunningInPackage())
		{
            immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Packages/com.actimi.immerzasdk/Editor/Immerza/Assets/ImmerzaLogo.png");
		}
		else
		{
            immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Editor/Immerza/Assets/ImmerzaLogo.png");
		}

        immerzaLogo.style.marginTop = 20.0f;
        immerzaLogo.style.marginLeft = 10.0f;
        immerzaLogo.style.marginRight = 10.0f;
        immerzaLogo.style.marginBottom = 5.0f;
        root.Add(immerzaLogo);

        treeAsset.CloneTree(root);

        scenesView = root.Q<ListView>("SceneList");
        path = root.Q<TextField>("ExportPath");
        scriptsPath = root.Q<TextField>("ScriptsPath");
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
        List<SceneAsset> allScenes = new List<SceneAsset>();

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
        CompilationState compilationState = CompileAssembly();

        if (compilationState == CompilationState.FAILED)
        {
            return;
        }

        ImmerzaUtil.InitCrcTable();

        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(sceneToExport));

        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), path.text);

        SceneMetadata sceneMetadata = new SceneMetadata();
        AssetMetadata assetMetadata = new AssetMetadata();

        List<string> assetPaths = new();

        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string originalScenePath = SceneManager.GetActiveScene().path;
        string newScenePath = originalScenePath.Replace(".unity", "_Export.unity");

        AssetDatabase.CopyAsset(originalScenePath, newScenePath);
        AssetDatabase.Refresh();

        Scene activeScene = EditorSceneManager.OpenScene(newScenePath);

        if (compilationState != CompilationState.NO_FILES)
        {
            GatherAndSerialize(assetPaths, assetMetadata, newScenePath, originalScenePath);
        }

        EditorSceneManager.SaveScene(activeScene);

        string scenePath = activeScene.path;
        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        string assemblyAssetPath = scriptsPath.text + "/" + sceneToExport.name + ".dll.txt";

        if (compilationState != CompilationState.NO_FILES)
        {
            string assemblyPath = Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".dll");
            File.Copy(assemblyPath, assemblyAssetPath);
            AssetDatabase.ImportAsset(assemblyAssetPath);
            AssetDatabase.Refresh();
            assetPaths.Add(assemblyAssetPath);
            assetMetadata.AddAsset("ImmerzaAssembly", assemblyAssetPath);
        }
        else
        {
            if (IsRunningInPackage())
            {
                assetPaths.Add("Packages/com.actimi.immerzasdk/Editor/Immerza/Assets/DummyFile.txt");
                assetMetadata.AddAsset("Gen", "NONE");
            }
            else
            {
                assetPaths.Add("Assets/Editor/Immerza/Assets/DummyFile.txt");
                assetMetadata.AddAsset("Gen", "NONE");
            }
        }

#if BUILD_BUNDLE
        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];

        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };

        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.None, BuildTarget.Android);
#endif
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

#if BUILD_BUNDLE
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
#else
            uint crc = 0xdeadbeef;
#endif
            sceneMetadata.hash = crc;
            sceneMetadata.sceneID = "0";
            sceneMetadata.sdkVersion = IsRunningInPackage() ? GetPackageVersion() : "dev";
            sceneMetadata.isUsingBgMusic = FindAnyObjectByType<BackgroundAudio>(FindObjectsInactive.Include) != null;
            sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

#if BUILD_BUNDLE
            File.Delete(Path.Combine(bundleDir, "immerza_scene"));
            File.Delete(Path.Combine(bundleDir, "immerza_assets"));
#endif
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

        if (openExportFolderTgl.value)
        {
            Process.Start("explorer.exe", bundleDir);
        }
    }

    private static bool IsRunningInPackage()
    {
        return AssetDatabase.IsValidFolder("Packages/com.actimi.immerzasdk");
    }

    private void GatherAndSerialize(List<string> assetPaths, AssetMetadata assetMetadata, string newScenePath, string originalScenePath)
    {
        string[] scriptGUIDs = AssetDatabase.FindAssets("t:MonoScript", new[] { scriptsPath.text });
        HashSet<string> validClassNames = new();
        foreach (string scriptGUID in scriptGUIDs)
        {
            string scriptPath = AssetDatabase.GUIDToAssetPath(scriptGUID);
            MonoScript monoScript = AssetDatabase.LoadAssetAtPath<MonoScript>(scriptPath);
            if (monoScript != null)
            {
                Type type = monoScript.GetClass();
                if (type != null && type.IsSubclassOf(typeof(MonoBehaviour)))
                {
                    validClassNames.Add(type.Name);
                }
            }
        }

        Assembly compiledAssembly = LoadCompiledAssembly(Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".dll"));

        try
        {
            List<MonoBehaviour> customScripts = new();

            foreach (GameObject obj in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                foreach (MonoBehaviour script in obj.GetComponentsInChildren<MonoBehaviour>(true))
                {
                    Type classType = script.GetType();

                    // we skip all attached scripts that are not 'custom' for the exported scene
                    if (!validClassNames.Contains(classType.Name))
                    {
                        continue;
                    }

                    customScripts.Add(script);

                    Debug.Log($"{classType.Name} {obj.name}");

                    Dictionary<string, ValueField> values = new Dictionary<string, ValueField>();
                    FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    foreach (FieldInfo field in fields)
                    {
                        bool hasSerializeFieldAttribute = field.GetCustomAttribute(typeof(SerializeField)) != null;

                        // same reasoning as Unity inspector exposed fields
                        if (field.IsPublic || hasSerializeFieldAttribute)
                        {
                            ValueField valueField = null;

                            if (ImmerzaUtil.IsFieldAPrimitiveList(field.FieldType) || ImmerzaUtil.IsFieldAPrimitiveArray(field.FieldType))
                            {
                                valueField = SerializeFieldPrimitiveList(script, field);
                            }
                            else if (ImmerzaUtil.IsFieldAReferenceList(field.FieldType) || ImmerzaUtil.IsFieldAReferenceArray(field.FieldType))
                            {
                                valueField = SerializeFieldReferenceList(script, field, assetPaths, compiledAssembly, customScripts);
                            }
                            else if (field.FieldType.IsClass && field.FieldType != typeof(string) && field.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
                            {
                                valueField = SerializeFieldReference(script, field, assetPaths, compiledAssembly, customScripts);
                            }
                            else if (field.FieldType.IsPrimitive || field.FieldType == typeof(string))
                            {
                                valueField = SerializeFieldPrimitive(script, field);
                            }
                            else if(field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(XRInputValueReader<>))
                            {
                                valueField = SerializeFieldGeneric(script, field);
                            }
                            else
                            {
                                valueField = SerializeFieldStruct();
                            }

                            if (valueField != null && valueField.serializationType != ImmerzaSDK.Types.ValueType.None)
                            {
                                values.Add(field.Name, valueField);
                            }
                            else
                            {
                                Debug.LogError($"Found field that should be serialized but is not supported yet: {field.Name}, {field.FieldType}");
                            }
                        }
                    }

                    assetMetadata.AddComponent(ImmerzaUtil.GetHierarchyPath(script.gameObject), classType.Name, values);
                }
            }

            foreach (MonoBehaviour script in customScripts)
            {
                DestroyImmediate(script);
            }
        }
        catch (Exception exc)
        {
            UnityEngine.Debug.LogException(exc);
            EditorSceneManager.OpenScene(originalScenePath);
            AssetDatabase.DeleteAsset(newScenePath);
            AssetDatabase.Refresh();
            SetSuccessMsg(false);
        }
    }

    private static Assembly LoadCompiledAssembly(string pathToAsembly)
    {
        ResolveEventHandler resolveEventHandler = (sender, args) =>
        {
            Console.WriteLine($"Skipping unresolved reference: {args.Name}");
            return null;
        };

        Assembly compiledAssembly = null;

        try
        {
            AppDomain.CurrentDomain.AssemblyResolve += resolveEventHandler;

            if (File.Exists(pathToAsembly))
            {
                compiledAssembly = Assembly.LoadFrom(pathToAsembly);
            }
        }
        finally
        {
            AppDomain.CurrentDomain.AssemblyResolve -= resolveEventHandler;
        }

        if (compiledAssembly == null)
        {
            Debug.LogWarning("Failed to load compiled assembly...");
        }

        return compiledAssembly;
    }
    
    private static ValueField SerializeFieldGeneric(MonoBehaviour script, FieldInfo field)
    {
        XRInputValueReader valReader = (XRInputValueReader)field.GetValue(script);

        ValueField valueField = new ValueField()
        {
            value = AssetDatabase.GetAssetPath(valReader.inputActionReference.asset),
            type = typeof(string),
            serializationType = ImmerzaSDK.Types.ValueType.SingleAssetReference
        };

        return valueField;
    }

    private static ValueField SerializeFieldPrimitive(MonoBehaviour script, FieldInfo field)
    {
        ValueField valueField = new ValueField
        {
            value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, new JsonSerializerSettings 
            { 
                ReferenceLoopHandling = ReferenceLoopHandling.Error 
            }),
            type = field.FieldType,
            serializationType = ImmerzaSDK.Types.ValueType.SingleValue
        };

        return valueField;
    }

    private static ValueField SerializeObjectReference(UnityEngine.Object referencedObject, List<string> assetPaths, Assembly compiledAssembly, List<MonoBehaviour> customScripts)
    {
        ValueField valueField = new ValueField
        {
            type = referencedObject.GetType(),
        };

        // the reference is a prefab asset from the database not a reference of a scene instantiated object
        if (AssetDatabase.Contains(referencedObject))
        {
            if (referencedObject.GetType().IsSubclassOf(typeof(ScriptableObject)))
            {
                valueField.type = compiledAssembly.GetType(valueField.type.FullName);
            }

            valueField.value = AssetDatabase.GetAssetPath(referencedObject);
            valueField.serializationType = ImmerzaSDK.Types.ValueType.SingleAssetReference;

            // if we reference a prefab, it needs to be considered for bundle export
            assetPaths.Add(valueField.value);
        }
        else
        {
            GameObject fieldGameObject = null;

            if (referencedObject is GameObject @object)
            {
                fieldGameObject = @object;
            }
            else if (referencedObject is UnityEngine.Component component)
            {
                fieldGameObject = component.gameObject;

                if (customScripts.FirstOrDefault(script => script.GetType() == valueField.type) != null)
                {
                    valueField.type = compiledAssembly.GetType(valueField.type.FullName);
                }
            }

            valueField.value = ImmerzaUtil.GetHierarchyPath(fieldGameObject);
            valueField.serializationType = ImmerzaSDK.Types.ValueType.SingleReference;
        }

        return valueField;
    }

    private static ValueField SerializeFieldReference(MonoBehaviour script, FieldInfo field, List<string> assetPaths, Assembly compiledAssembly, List<MonoBehaviour> customScripts)
    {
        return SerializeObjectReference((UnityEngine.Object)field.GetValue(script), assetPaths, compiledAssembly, customScripts);
    }

    private static ValueField SerializeFieldReferenceList(MonoBehaviour script, FieldInfo field, List<string> assetPaths, Assembly compiledAssembly, List<MonoBehaviour> customScripts)
    {
        IEnumerable referenceContainer = (IEnumerable)field.GetValue(script);
        if (!referenceContainer.GetEnumerator().MoveNext()) {
            return null;
        }

        ImmerzaSDK.Types.ValueType serializationType = ImmerzaSDK.Types.ValueType.None;
        List<string> storedReferences = new();
        foreach (object referenceContainerItem in referenceContainer)
        {
            if (referenceContainerItem is GameObject gameObject && String.IsNullOrEmpty(gameObject.scene.name))
            {
                /*string assetPath = AssetDatabase.GetAssetPath(fieldData);

                GameObject newPrefab = PrefabUtility.SaveAsPrefabAsset((GameObject)fieldData, assetPath.Replace(".prefab", "_Export.prefab"));
                GameObject newPrefabInstance = (GameObject)PrefabUtility.InstantiatePrefab(newPrefab);

                (AssetMetadata, List<MonoBehaviour>) serializedPrefab = PrefabSerialize(newPrefab, validClassNames, assetPaths, compiledAssembly);

                //GameObject test = (GameObject)fieldData;



                foreach (MonoBehaviour prefabScript in serializedPrefab.Item2)
                {
                    Debug.Log(newPrefabInstance.name + " : " + prefabScript.GetType().Name);
                    PrefabUtility.ApplyRemovedComponent(newPrefabInstance, prefabScript, InteractionMode.AutomatedAction);
                }


                assetPaths.Add(assetPath);
                storedReferences.Add(JsonConvert.SerializeObject(serializedPrefab.Item1));
                fieldValue.serializationType = ImmerzaSDK.Types.ValueType.ArrayAssetReference;

                DestroyImmediate(newPrefabInstance);*/
            }
            else
            {
                ValueField referenceValueField = SerializeObjectReference((UnityEngine.Object)referenceContainerItem, assetPaths, compiledAssembly, customScripts);
                if (referenceValueField != null)
                {
                    if (serializationType == ImmerzaSDK.Types.ValueType.None)
                    {
                        serializationType = referenceValueField.serializationType;
                    }

                    if (serializationType == referenceValueField.serializationType)
                    {
                        storedReferences.Add(referenceValueField.value);
                    }
                    else
                    {
                        Debug.LogWarning("Reference array contains types of different serialization types which is not supported right now");
                    }
                }
            }
        }

        ValueField valueField = new ValueField
        {
            value = JsonConvert.SerializeObject(storedReferences, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }),
            type = typeof(List<string>),
            serializationType = serializationType switch
            {
                ImmerzaSDK.Types.ValueType.SingleReference => ImmerzaSDK.Types.ValueType.ArrayReference,
                ImmerzaSDK.Types.ValueType.SingleAssetReference => ImmerzaSDK.Types.ValueType.ArrayAssetReference,
                _ => ImmerzaSDK.Types.ValueType.None
            }

        };

        return valueField;
    }

    private static ValueField SerializeFieldPrimitiveList(MonoBehaviour script, FieldInfo field)
    {
        ValueField valueField = new ValueField
        {
            value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, new JsonSerializerSettings 
            { 
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore 
            }),
            type = field.FieldType,
            serializationType = ImmerzaSDK.Types.ValueType.ArrayValue
        };

        return valueField;
    }

    private static ValueField SerializeFieldStruct()
    {
        return new ValueField();
        /* STRUCTS
        ValueField fieldValue = new ValueField()
        {
            value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, settings),
            type = field.FieldType,
            serializationType = ImmerzaSDK.Types.ValueType.SingleValue
        };

        Type customType = compiledAssembly.GetType(field.FieldType.FullName);

        if (customType != null)
        {
            fieldValue.type = customType;
        }

        values.Add(field.Name, fieldValue);
        */
    }

    private CompilationState CompileAssembly()
    {
        if (!Directory.Exists(Path.Combine(sceneCachePath, sceneToExport.name)))
        {
            Directory.CreateDirectory(Path.Combine(sceneCachePath, sceneToExport.name));
        }

        string scriptFolderPath = Path.Combine(Path.GetDirectoryName(Application.dataPath), scriptsPath.text);

        if (!Directory.EnumerateFileSystemEntries(scriptFolderPath).Any())
        {
            Debug.Log("Script folder " + scriptsPath.text + " is empty!");
            return CompilationState.NO_FILES;
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

        string basePath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "Library", "ScriptAssemblies");

        IEnumerable<string> paths = Directory.EnumerateFiles(basePath, "*.dll", SearchOption.AllDirectories)
                        .Where(file =>
                        {
                            return file.Contains("Unity") && 
                            !file.Contains("Editor") && 
                            !file.Contains("VisualScripting") &&
                            !file.Contains("RenderPipelines") &&
                            !file.Contains("RenderPipeline") &&
                            !file.Contains("Burst");
                        });

        foreach (string path in paths)
        {
            args += $"/reference:{path} ";
        }

        if (IsRunningInPackage())
        {
            args += $"/reference:{Path.GetFullPath("Packages/com.actimi.immerzasdk/Runtime/ImmerzaSDK.dll")} ";
        }
        else
        {
            args += $"/reference:{Path.Combine(basePath, "ImmerzaSDK.dll")} ";
        }

        string unityAssemblyPath = Path.Combine("..", "Managed", "UnityEngine");

        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.CoreModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.AIModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.AnimationModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.ARModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.AudioModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.HierarchyCoreModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.ImageConversionModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.InputForUIModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.InputModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.ParticleSystemModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.PhysicsModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.SpriteMaskModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.SpriteShapeModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.UIModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.VFXModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.VideoModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.VRModule.dll")} ";
        args += $"/reference:{Path.Combine(unityAssemblyPath, "UnityEngine.XRModule.dll")} ";

        args += @$"/out:""{Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".dll")}"" ";
        args += @$"""{Path.Combine(sceneCachePath, sceneToExport.name, "*.cs")}"" ";

        System.Diagnostics.ProcessStartInfo processInfo = new()
        {
            CreateNoWindow = false,
            UseShellExecute = false,
            FileName = dotnetPath,
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            WorkingDirectory = dotnetPath.Split("dotnet")[0],

            Arguments = args
        };

        Debug.Log("Compiler output started!");

        Process compilerProcess = new();
        compilerProcess.StartInfo = processInfo;
        compilerProcess.ErrorDataReceived += (sender, args) => 
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                Debug.LogError($"Compiler error: {args.Data}");
            }
        };

        compilerProcess.OutputDataReceived += (sender, args) =>
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                if (args.Data.Contains("warning"))
                {
                    Debug.LogWarning(args.Data);
                }
                else if (args.Data.Contains("error"))
                {
                    Debug.LogError(args.Data);
                }
                else
                {
                    Debug.Log(args.Data);
                }
            }
        };

        if (!compilerProcess.Start())
        {
            SetSuccessMsg(false, "Compiler has not been found!");
            Debug.LogError("Check if the path is correct: " + dotnetPath);
            return CompilationState.FAILED;
        }

        compilerProcess.BeginErrorReadLine();
        compilerProcess.BeginOutputReadLine();
        compilerProcess.WaitForExit();

        Debug.Log("Compiler output stopped!");

        return CompilationState.SUCCESS;
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

    private string GetPackageVersion()
    {
        TextAsset packageAsset = (TextAsset)AssetDatabase.LoadAssetAtPath("Packages/com.actimi.immerzasdk/package.json", typeof(TextAsset));
        JObject jsonPackage = JObject.Parse(packageAsset.text);

        return jsonPackage["version"]?.ToString();
    }

    private void SetSuccessMsg(bool success)
    {
        SetSuccessMsg(success, null);
    }

    private (AssetMetadata, List<MonoBehaviour>) PrefabSerialize(GameObject root, HashSet<string> validClassNames, List<string> assetPaths, Assembly compiledAssembly)
    {
        AssetMetadata assetMetadata = new();
        List<MonoBehaviour> customScripts = new();
        MonoBehaviour[] scripts = root.GetComponentsInChildren<MonoBehaviour>(true);

        Debug.LogError(root.name);

        foreach (MonoBehaviour script in scripts)
        {
            Type classType = script.GetType();

            if (validClassNames.Contains(classType.Name))
            {
                customScripts.Add(script);
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
                                value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }),
                                type = field.FieldType,
                                serializationType = ImmerzaSDK.Types.ValueType.ArrayValue
                            };

                            values.Add(field.Name, fieldValue);
                        }
                        else if (ImmerzaUtil.IsFieldAReferenceList(field.FieldType) || ImmerzaUtil.IsFieldAReferenceArray(field.FieldType))
                        {
                            List<string> storedReferences = new();
                            IEnumerable crtReferences = (IEnumerable)field.GetValue(script);

                            ValueField fieldValue = new();

                            if (!crtReferences.GetEnumerator().MoveNext())
                            {
                                continue;
                            }

                            foreach (object reference in crtReferences)
                            {
                                UnityEngine.Object fieldData = (UnityEngine.Object)reference;

                                GameObject fieldGameObject = null;

                                if (fieldData is GameObject @object)
                                {
                                    if (@object.scene.name == null)
                                    {
                                        string assetPath = AssetDatabase.GetAssetPath(fieldData);
                                        assetPaths.Add(assetPath);
                                        storedReferences.Add(assetPath);
                                        fieldValue.serializationType = ImmerzaSDK.Types.ValueType.ArrayAssetReference;
                                    }
                                    else
                                    {
                                        fieldGameObject = @object;
                                        storedReferences.Add(ImmerzaUtil.GetHierarchyPath(fieldGameObject));
                                        fieldValue.serializationType = ImmerzaSDK.Types.ValueType.ArrayReference;
                                    }
                                }
                                else if (fieldData is UnityEngine.Component component)
                                {
                                    fieldGameObject = component.gameObject;
                                    storedReferences.Add(ImmerzaUtil.GetHierarchyPath(fieldGameObject));
                                    fieldValue.serializationType = ImmerzaSDK.Types.ValueType.ArrayReference;
                                    Debug.LogError(field.FieldType.Name);
                                }
                                else
                                {
                                    string assetPath = AssetDatabase.GetAssetPath(fieldData);
                                    assetPaths.Add(assetPath);
                                    storedReferences.Add(assetPath);
                                    fieldValue.serializationType = ImmerzaSDK.Types.ValueType.ArrayAssetReference;
                                }
                            }

                            fieldValue.value = JsonConvert.SerializeObject(storedReferences, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                            fieldValue.type = typeof(List<string>);

                            values.Add(field.Name, fieldValue);
                        }
                        else if (field.FieldType.IsClass && field.FieldType != typeof(string) && field.FieldType.IsSubclassOf(typeof(UnityEngine.Object)))
                        {
                            ValueField fieldValue = new ValueField()
                            {
                                value = "",
                                type = field.FieldType,
                                serializationType = ImmerzaSDK.Types.ValueType.SingleReference
                            };

                            UnityEngine.Object fieldObj = (UnityEngine.Object)field.GetValue(script);

                            if (AssetDatabase.Contains(fieldObj)) // Single Assets
                            {
                                if (fieldObj.GetType().IsSubclassOf(typeof(ScriptableObject)))
                                {
                                    fieldValue.type = compiledAssembly.GetType(field.FieldType.FullName);
                                }

                                string assetPath = AssetDatabase.GetAssetPath(fieldObj);
                                fieldValue.value = assetPath;
                                fieldValue.serializationType = ImmerzaSDK.Types.ValueType.SingleAssetReference;
                                values.Add(field.Name, fieldValue);
                                assetPaths.Add(assetPath);
                                continue;
                            }

                            UnityEngine.Object fieldData = (UnityEngine.Object)field.GetValue(script);

                            GameObject fieldGameObject = null;

                            if (fieldData is GameObject @object)
                            {
                                fieldGameObject = @object;
                            }
                            else if (fieldData is UnityEngine.Component component)
                            {
                                fieldGameObject = component.gameObject;

                                if (customScripts.FirstOrDefault(val => val.GetType() == field.FieldType) != null)
                                {
                                    fieldValue.type = compiledAssembly.GetType(field.FieldType.FullName);
                                }
                            }

                            fieldValue.value = ImmerzaUtil.GetHierarchyPath(fieldGameObject);

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
                        else if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(XRInputValueReader<>))
                        {
                            XRInputValueReader valReader = (XRInputValueReader)field.GetValue(script);

                            ValueField fieldValue = new ValueField()
                            {
                                value = AssetDatabase.GetAssetPath(valReader.inputActionReference.asset),
                                type = typeof(string),
                                serializationType = ImmerzaSDK.Types.ValueType.SingleAssetReference
                            };

                            values.Add(field.Name, fieldValue);
                        }
                        else
                        {
                            /* STRUCTS
                            ValueField fieldValue = new ValueField()
                            {
                                value = JsonConvert.SerializeObject(field.GetValue(script), Formatting.Indented, settings),
                                type = field.FieldType,
                                serializationType = ImmerzaSDK.Types.ValueType.SingleValue
                            };

                            Type customType = compiledAssembly.GetType(field.FieldType.FullName);

                            if (customType != null)
                            {
                                fieldValue.type = customType;
                            }

                            values.Add(field.Name, fieldValue);
                            */
                        }
                    }
                }

                assetMetadata.AddComponent(ImmerzaUtil.GetHierarchyPath(script.gameObject), classType.Name, values);
            }
        }

        return (assetMetadata, customScripts);
    }
}
