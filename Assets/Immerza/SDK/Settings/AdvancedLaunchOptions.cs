using ImmerzaSDK.Lua;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace ImmerzaSDK.Settings
{
    [LuaCallCSharp]
    public class AdvancedLaunchOptions : MonoBehaviour
    {
        public static AdvancedLaunchOptions Instance { get; private set; }

        public static List<AdvancedLaunchOption> options = new()
        {
            new AdvancedLaunchOption()
            {
                id = "default",
                name = "Default",
                variables = new List<AdvancedLaunchOptionValue>()
                {
                    new() { name = "duration", type = LaunchOptionValueType.Float, floatValue = 0.0f }
                },
                description = "Default preset if none is created.",
            }
        };

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }
    }
}