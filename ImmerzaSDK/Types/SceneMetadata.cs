﻿using Newtonsoft.Json;
using System;
using System.IO;

namespace ImmerzaSDK.Types
{
    public class SceneMetadata
    {
        [JsonProperty("scene_id")]
        public string sceneID;
        [JsonProperty("hash")]
        public uint hash;

        [JsonProperty("asset_metadata")]
        public AssetMetadata assetMetaData;

        public void SaveMetaData(string fielPath)
        {
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(fielPath, jsonContent);
        }
    }
}
