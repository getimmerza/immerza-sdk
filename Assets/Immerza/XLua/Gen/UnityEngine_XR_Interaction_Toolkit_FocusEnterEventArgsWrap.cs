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
    public class UnityEngineXRInteractionToolkitFocusEnterEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionGroup", _g_get_interactionGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableObject", _g_get_interactableObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manager", _g_get_manager);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionGroup", _s_set_interactionGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableObject", _s_set_interactableObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manager", _s_set_manager);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactionGroup);
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
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.manager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionGroup = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableObject = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
