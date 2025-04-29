#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineXRInteractionToolkitLocomotionComfortLocomotionVignetteProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 5, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "locomotionProvider", _g_get_locomotionProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideDefaultParameters", _g_get_overrideDefaultParameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideParameters", _g_get_overrideParameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vignetteParameters", _g_get_vignetteParameters);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "locomotionProvider", _s_set_locomotionProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideDefaultParameters", _s_set_overrideDefaultParameters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideParameters", _s_set_overrideParameters);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_locomotionProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.locomotionProvider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideDefaultParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideDefaultParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.overrideParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vignetteParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vignetteParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_locomotionProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.locomotionProvider = (UnityEngine.XR.Interaction.Toolkit.Locomotion.LocomotionProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.LocomotionProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideDefaultParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideDefaultParameters = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideParameters = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.VignetteParameters)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.VignetteParameters));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
