using ImmerzaSDK;
using ImmerzaSDK.Manager.Editor;
using ImmerzaSDK.Types;
using ImmerzaSDK.Util;
using SharpCompress.Common;
using SharpCompress.Writers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class SceneBuilder : ScriptableObject, ISceneBuilder
{
    [SerializeField]
    private TextAsset _dummyFile = null;

    public bool ExportScene(ExportSettings exportSettings)
    {
        ImmerzaUtil.InitCrcTable();

        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(exportSettings.SceneToExport));

        string bundleDir = Path.Combine(Path.GetDirectoryName(Application.dataPath), exportSettings.ExportFolder);

        SceneMetadata sceneMetadata = new();
        AssetMetadata assetMetadata = new();

        List<string> assetPaths = new();

        if (!Directory.Exists(bundleDir))
        {
            Directory.CreateDirectory(bundleDir);
        }

        string scenePath = SceneManager.GetActiveScene().path;

        assetMetadata.AddAsset("ImmerzaScene", scenePath);

        ImmerzaUtil.AddAssetPath(assetPaths, AssetDatabase.GetAssetPath(_dummyFile));
        assetMetadata.AddAsset("Gen", "NONE");

        AssetBundleBuild[] exportMap = new AssetBundleBuild[2];

        exportMap[0].assetBundleName = "immerza_scene";
        exportMap[0].assetNames = new[] { scenePath };

        exportMap[1].assetBundleName = "immerza_assets";
        exportMap[1].assetNames = assetPaths.ToArray();

        sceneMetadata.sdkVersion = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Immerza/Version.txt").ToString();

        bool bundlesCreated = true;
        bundlesCreated  = ExportBundles(exportSettings, bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.Android);
        bundlesCreated &= ExportBundles(exportSettings, bundleDir, exportMap, sceneMetadata, assetMetadata, BuildTarget.StandaloneWindows64);
        sceneMetadata.SaveMetaData(Path.Combine(bundleDir, "immerza_metadata.json"));

        return bundlesCreated;
    }

    private bool ExportBundles(ExportSettings exportSettings, string bundleDir, AssetBundleBuild[] exportMap, SceneMetadata sceneMetadata, AssetMetadata assetMetadata, BuildTarget platform)
    {
        BuildPipeline.BuildAssetBundles(bundleDir, exportMap, BuildAssetBundleOptions.ForceRebuildAssetBundle, platform);
        sceneMetadata.assetMetaData = assetMetadata;

        string platformId = platform == BuildTarget.Android ? "android" : "win";

        sceneMetadata.isUsingBgMusic = UnityEngine.Object.FindAnyObjectByType<BackgroundAudio>(FindObjectsInactive.Include) != null;

        try
        {
            File.Delete(Path.Combine(bundleDir, exportSettings.ExportFolder));
            File.Delete(Path.Combine(bundleDir, exportSettings.ExportFolder + ".manifest"));
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

            return false;
        }

        return true;
    }
}
