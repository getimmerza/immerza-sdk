using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace ImmerzaSDK.Lua
{
    [Serializable]
    public class Reference
    {
        public string variableName;
        public UnityEngine.Object value;
    }

    [LuaCallCSharp]
    public class LuaComponent : MonoBehaviour
    {
        [SerializeField] private LuaAsset mainLuaScript;
        [SerializeField, Tooltip("These scripts can be loaded with 'require'.")] 
        private List<LuaAsset> additionalLuaScripts;
        [SerializeField] private List<Reference> references;

        [HideInInspector] public LuaTable scriptEnv;

        private static Dictionary<string, Action<LuaTable>> eventListeners = new();

        // Standard engine functions to forward
        private Action luaAwake;
        private Action luaStart;
        private Action luaOnEnable;
        private Action luaOnDisable;
        private Action luaOnDestroy;
        private Action luaUpdate;
        private Action luaFixedUpdate;

        // Physics
        private Action<Collision> luaOnCollisionEnter;
        private Action<Collision> luaOnCollisionStay;
        private Action<Collision> luaOnCollisionExit;

        private Action<Collider> luaOnTriggerEnter;
        private Action<Collider> luaOnTriggerStay;
        private Action<Collider> luaOnTriggerExit;

        private void Awake()
        {
            LuaEnv crtGlobalEnv = ImmerzaLuaManager.Instance.GlobalEnv;

            scriptEnv = crtGlobalEnv.NewTable();

            using (LuaTable meta = crtGlobalEnv.NewTable())
            {
                meta.Set("__index", crtGlobalEnv.Global);
                scriptEnv.SetMetaTable(meta);
            }

            scriptEnv.Set("self", this);
            scriptEnv.Set("gameObject", gameObject);
            scriptEnv.Set("transform", transform);

            foreach (Reference refin in references)
            {
                scriptEnv.Set(refin.variableName, refin.value);
            }


            if (!crtGlobalEnv.customLoaders.Contains(ComponentCustomLoader))
            {
                crtGlobalEnv.AddLoader(ComponentCustomLoader);
            }

            try
            {
                crtGlobalEnv.DoString(mainLuaScript.content, mainLuaScript.name, scriptEnv);
            }
            catch (Exception ex)
            {
                Debug.LogError("Lua execution error: " + ex.Message);
            }

            scriptEnv.Get("awake", out luaAwake);
            scriptEnv.Get("start", out luaStart);
            scriptEnv.Get("on_enable", out luaOnEnable);
            scriptEnv.Get("on_disable", out luaOnDisable);
            scriptEnv.Get("on_destroy", out luaOnDestroy);
            scriptEnv.Get("update", out luaUpdate);
            scriptEnv.Get("fixed_update", out luaFixedUpdate);

            scriptEnv.Get("on_collision_enter", out luaOnCollisionEnter);
            scriptEnv.Get("on_collision_stay", out luaOnCollisionStay);
            scriptEnv.Get("on_collision_exit", out luaOnCollisionExit);

            scriptEnv.Get("on_trigger_enter", out luaOnTriggerEnter);
            scriptEnv.Get("on_trigger_stay", out luaOnTriggerStay);
            scriptEnv.Get("on_trigger_exit", out luaOnTriggerExit);

            luaAwake?.Invoke();
        }

        private byte[] ComponentCustomLoader(ref string filename)
        {
            LuaAsset foundAsset = null;
            foreach (LuaAsset asset in additionalLuaScripts)
            {
                if (asset.name.Equals(filename))
                {
                    foundAsset = asset;
                }
            }

            if (additionalLuaScripts.Count == 0 || foundAsset == null) { return null; }

            return System.Text.Encoding.UTF8.GetBytes(foundAsset.content);
        }

        private void Start()
        {
            luaStart?.Invoke();
        }

        private void OnEnable()
        {
            luaOnEnable?.Invoke();
        }

        private void OnDisable()
        {
            luaOnDisable?.Invoke();
        }

        private void OnDestroy()
        {
            luaOnDestroy?.Invoke();
            luaUpdate = null;
            luaFixedUpdate = null;
        }

        private void Update()
        {
            luaUpdate?.Invoke();
        }

        private void FixedUpdate()
        {
            luaFixedUpdate?.Invoke();
        }

        private void OnCollisionEnter(Collision collision)
        {
            luaOnCollisionEnter?.Invoke(collision);
        }

        private void OnCollisionStay(Collision collision)
        {
            luaOnCollisionStay?.Invoke(collision);
        }

        private void OnCollisionExit(Collision collision)
        {
            luaOnCollisionExit?.Invoke(collision);
        }

        private void OnTriggerEnter(Collider other)
        {
            luaOnTriggerEnter?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            luaOnTriggerStay?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            luaOnTriggerExit?.Invoke(other);
        }

        public static void RegisterEvent(string eventName, Action<LuaTable> callback)
        {
            if (!eventListeners.ContainsKey(eventName))
            {
                eventListeners[eventName] = callback;
            }
        }

        public static void TriggerEvent(string eventName, LuaTable eventData)
        {
            if (eventListeners.TryGetValue(eventName, out Action<LuaTable> callback))
            {
                callback(eventData);
            }
        }
    }

    public static class LuaComponentConfig
    {
        [LuaCallCSharp]
        public static List<Type> LuaCallCSharp
        {
            get
            {
                return new List<Type>()
                {
                    typeof(WaitForSeconds)
                };
            }
        }
    }
}