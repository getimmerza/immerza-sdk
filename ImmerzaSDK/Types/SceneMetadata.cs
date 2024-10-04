using Newtonsoft.Json;
using System.IO;

namespace ImmerzaSDK.Types
{
    public class SceneMetadata
    {
        [JsonProperty("scene_name")]
        public string sceneName;
        [JsonProperty("scene_version")]
        public string sceneVersion;

        [JsonProperty("asset_metadata")]
        public AssetMetadata assetMetaData;

        public void SaveMetaData(string fielPath)
        {
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(fielPath, jsonContent);
        }
    }
}
