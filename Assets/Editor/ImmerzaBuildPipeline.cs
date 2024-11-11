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

public class ImmerzaBuildPipeline : EditorWindow
{
    private VisualTreeAsset treeAsset = null;
    [SerializeField] private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private TextField scriptsPath = null;
    private EnumField buildTarget = null;
    private Button exportBtn = null;
    private Label successLabel = null;

#if UNITY_EDITOR_OSX
    private string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime/dotnet");
#endif
#if UNITY_EDITOR_WIN
    private string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime/dotnet.exe");
#endif

    [MenuItem("Immerza/Build SDK Package")]
    public static void ShowSceneBundler()
    {
        ImmerzaBuildPipeline window = GetWindow<ImmerzaBuildPipeline>();
        window.titleContent = new GUIContent("Immerza SDK Builder");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;

        root.Add(new Label());

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

    private bool CompileAssembly()
    {
        if (!Directory.Exists(Path.Combine(sceneCachePath, sceneToExport.name)))
        {
            Directory.CreateDirectory(Path.Combine(sceneCachePath, sceneToExport.name));
        }

        CreateProjectFile(Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".csproj"));

        ImmerzaUtil.CopyDirectory(
            Path.Combine(Path.GetDirectoryName(Application.dataPath), scriptsPath.text), 
            Path.Combine(sceneCachePath, sceneToExport.name)
        );

        System.Diagnostics.ProcessStartInfo processInfo = new()
        {
            CreateNoWindow = false,
            UseShellExecute = false,
            FileName = dotnetPath,
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,

            Arguments = $"build {Path.Combine(sceneCachePath, sceneToExport.name, sceneToExport.name + ".csproj")}"
        };

        Process compilerProcess = new();
        compilerProcess.StartInfo = processInfo;
        if (!compilerProcess.Start())
        {
            SetSuccessMsg(false, "Compiler has not been found!");
            UnityEngine.Debug.LogError("Check if the path is correct: " + dotnetPath);
            return false;
        }
        compilerProcess.WaitForExit();
        return true;
    }

    private static void CreateProjectFile(string path)
    {
        string unityAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "Managed", "*.dll");
        string generalAssembliesPath = Path.Combine(EditorApplication.applicationContentsPath, "UnityReferenceAssemblies", "unity-4.8-api", "*.dll");
        string packageAssembliesPath = Path.Combine(Path.GetDirectoryName(Application.dataPath), "Library", "ScriptAssemblies", "*.dll");

        string msbuildProj = // Unity uses C# 9, so there is no raw string interpolation (C# 11). That makes is very unpleasing to retain string structure.
$@"<Project Sdk='Microsoft.NET.Sdk'>
    <PropertyGroup>
        <OutputType>Library</OutputType>
        <TargetFramework>netstandard2.1</TargetFramework>
        <Configuration>Release</Configuration>
        <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
        <AppendRuntimeIdentifierToOutputPath>false</AppendRuntimeIdentifierToOutputPath>
        <OutputPath>./</OutputPath>
    </PropertyGroup>
    <ItemGroup>
        <Reference Include=""{unityAssembliesPath}""><Private>false</Private></Reference>
        <Reference Include=""{generalAssembliesPath}""><Private>false</Private></Reference>
        <Reference Include=""{packageAssembliesPath}""><Private>false</Private></Reference>
    </ItemGroup>
</Project>
        ";

        File.WriteAllText(path, msbuildProj);
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
