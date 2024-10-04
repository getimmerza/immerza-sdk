using Newtonsoft.Json;
using System.Collections.Generic;

namespace ImmerzaSDK.Types
{
    public class AssetMetadata
    {
        [JsonProperty("asset_table")]
        public Dictionary<string, List<string>> assetTable = new Dictionary<string, List<string>>();
        [JsonProperty("component_table")]
        public Dictionary<string, ComponentData> componentTable = new Dictionary<string, ComponentData>();

        public void AddAsset(string label, string assetPath)
        {
            if (!assetTable.ContainsKey(label))
            {
                assetTable[label] = new List<string>();
            }
            assetTable[label].Add(assetPath);
        }

        public void AddComponent(string path, string className, Dictionary<string, ValueField> values)
        {
            ComponentData data = new ComponentData()
            {
                className = className,
                fields = values
            };
            componentTable.Add(path, data);
        }
    }
}
