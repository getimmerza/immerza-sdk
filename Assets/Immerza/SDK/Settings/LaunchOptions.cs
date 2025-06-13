using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace ImmerzaSDK.Settings
{
    [LuaCallCSharp]
    public class LaunchOptions : MonoBehaviour
    {
        public static LaunchOptions Instance { get; private set; }
        public static event Action<Dictionary<string, object>> OnLaunchOptionsReceived;

        public Dictionary<string, object> Options = new();

        public void Init(Dictionary<string, object> options)
        {
            Options = options;
            OnLaunchOptionsReceived?.Invoke(Options);
        }

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