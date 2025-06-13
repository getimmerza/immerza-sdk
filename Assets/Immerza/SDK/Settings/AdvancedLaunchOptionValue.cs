using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace ImmerzaSDK.Settings
{
    [LuaCallCSharp]
    public enum LaunchOptionValueType { Int, Float, String, Bool }

    [Serializable, LuaCallCSharp]
    public class AdvancedLaunchOption
    {
        public string id;
        public string name;
        public List<AdvancedLaunchOptionValue> variables;
        [Multiline] public string description;
    }

    [Serializable, LuaCallCSharp]
    public class AdvancedLaunchOptionValue
    {
        public string name;
        public LaunchOptionValueType type;

        [SerializeField] public int intValue;
        [SerializeField] public float floatValue;
        [SerializeField] public string stringValue;
        [SerializeField] public bool boolValue;
    }
}
