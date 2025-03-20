﻿#if USE_UNI_LUA
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
    public class UnityEngineXRInteractionToolkitHoverExitEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactorObject", _g_get_interactorObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableObject", _g_get_interactableObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manager", _g_get_manager);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isCanceled", _g_get_isCanceled);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactorObject", _s_set_interactorObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableObject", _s_set_interactableObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manager", _s_set_manager);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isCanceled", _s_set_isCanceled);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactorObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactorObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactableObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactableObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.manager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isCanceled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactorObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactorObject = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactableObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableObject = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isCanceled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
