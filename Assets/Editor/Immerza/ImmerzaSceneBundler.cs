using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class ImmerzaSceneBundler : EditorWindow
{
    [SerializeField] private VisualTreeAsset treeAsset = null;
    private SceneAsset sceneToExport = null;

    private ListView scenesView = null;
    private TextField path = null;
    private EnumField buildTarget = null;
    private Button exportBtn = null;

    [MenuItem("Immerza/Scene Bundler")]
    public static void ShowSceneBundler()
    {
        EditorWindow window = GetWindow<ImmerzaSceneBundler>();
        window.titleContent = new GUIContent("Immerza Scene Bundler");
    }

    public void CreateGUI()
    {
        rootVisualElement.Add(new Label());
        Image immerzaLogo = new Image();
        immerzaLogo.scaleMode = ScaleMode.ScaleToFit;
        immerzaLogo.sprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Editor/Immerza/ImmerzaNewLogo.png");
        rootVisualElement.Add(immerzaLogo);

        treeAsset.CloneTree(rootVisualElement);

        scenesView = rootVisualElement.Q<ListView>("SceneList");
        path = rootVisualElement.Q<TextField>("ExportPath");
        buildTarget = rootVisualElement.Q<EnumField>("PlatformEnum");
        buildTarget.Init(BuildTarget.Android);
        exportBtn = rootVisualElement.Q<Button>("ExportButton");
        exportBtn.SetEnabled(false);
        exportBtn.style.backgroundColor = new Color(0.2f, 0.2f, 0.2f);
        exportBtn.style.color = new Color(0.3f, 0.3f, 0.3f);
        
        string[] allSceneGuids = AssetDatabase.FindAssets("t:SceneAsset");
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
        exportBtn.style.backgroundColor = new Color(0.4f, 0.4f, 0.4f);
        exportBtn.style.color = new Color(1.0f, 1.0f, 1.0f);
    }

    private void ExportScene()
    {
        if (!Directory.Exists(path.text))
        {
            Directory.CreateDirectory(path.text);
        }

        AssetBundleBuild[] exportMap = new AssetBundleBuild[1];

        exportMap[0].assetBundleName = "immerza_scene";

        string[] sceneAssetPath = new string[1];
        sceneAssetPath[0] = AssetDatabase.GetAssetOrScenePath(sceneToExport);
        exportMap[0].assetNames = sceneAssetPath;

        BuildPipeline.BuildAssetBundles(path.text, exportMap, BuildAssetBundleOptions.None, (BuildTarget)buildTarget.value);
    }
}
