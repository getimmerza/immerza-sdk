using Newtonsoft.Json;
using System;

namespace ImmerzaSDK.Types
{
    public enum ValueType
    {
        SingleValue,
        SingleReference,
        ArrayValue,
        ArrayReference,
        AssetReference
    }

    public class ValueField
    {
        public string value;
        public Type type;
        [JsonProperty("serialization_type")]
        public ValueType serializationType;
    }
}
