using ImmerzaSDK.Lua;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace ImmerzaSDK.Settings
{
    [LuaCallCSharp]
    public class LaunchOptions : MonoBehaviour
    {
        public static LaunchOptions Instance { get; private set; }

        public static List<LaunchOption> options = new()
        {
            new LaunchOption()
            {
                id = "default",
                name = "Default",
                variables = new List<LaunchOptionValue>()
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