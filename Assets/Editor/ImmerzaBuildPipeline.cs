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
    [SerializeField] private VisualTreeAsset treeAsset = null;

    private TextField path = null;
    private TextField versionField = null;
    private Button exportBtn = null;
    private Label successLabel = null;

#if UNITY_EDITOR_OSX
    private string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime", "dotnet");
    private string cscPath = Path.Combine("..", "DotNetSdkRoslyn", "csc");
#endif
#if UNITY_EDITOR_WIN
    private string dotnetPath = Path.Combine(EditorApplication.applicationContentsPath, "NetCoreRuntime", "dotnet.exe");
    private string cscPath = Path.Combine("..", "DotNetSdkRoslyn", "csc.exe");
#endif

    [MenuItem("Immerza/Immerza SDK Builder")]
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

        path = root.Q<TextField>("ExportPath");
        versionField = root.Q<TextField>("Version");
        exportBtn = root.Q<Button>("ExportButton");
        successLabel = root.Q<Label>("SuccessLabel");
        successLabel.visible = false;

        exportBtn.clicked += ExportSDK;
    }

    private void ExportSDK()
    {
        string assemblyPath = Path.Combine();
        UnityEngine.Debug.Log(CompileAssembly());
    }

    private bool CompileAssembly()
    {
        string args = cscPath;


        System.Diagnostics.ProcessStartInfo processInfo = new()
        {
            CreateNoWindow = false,
            UseShellExecute = true,
            FileName = dotnetPath,
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,

            Arguments = args
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

    /*
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
    }*/

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
