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
    public class UnityEngineXRInteractionToolkitInputsXRInputModalityManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 8, 8);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftHand", _g_get_leftHand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightHand", _g_get_rightHand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftController", _g_get_leftController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightController", _g_get_rightController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackedHandModeStarted", _g_get_trackedHandModeStarted);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackedHandModeEnded", _g_get_trackedHandModeEnded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motionControllerModeStarted", _g_get_motionControllerModeStarted);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motionControllerModeEnded", _g_get_motionControllerModeEnded);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftHand", _s_set_leftHand);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightHand", _s_set_rightHand);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftController", _s_set_leftController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightController", _s_set_rightController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackedHandModeStarted", _s_set_trackedHandModeStarted);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackedHandModeEnded", _s_set_trackedHandModeEnded);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motionControllerModeStarted", _s_set_motionControllerModeStarted);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motionControllerModeEnded", _s_set_motionControllerModeEnded);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentInputMode", _g_get_currentInputMode);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftHand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightHand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackedHandModeStarted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.trackedHandModeStarted);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackedHandModeEnded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.trackedHandModeEnded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motionControllerModeStarted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.motionControllerModeStarted);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motionControllerModeEnded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.motionControllerModeEnded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentInputMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager.currentInputMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftHand = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightHand = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftController = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightController = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackedHandModeStarted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trackedHandModeStarted = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackedHandModeEnded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trackedHandModeEnded = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motionControllerModeStarted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.motionControllerModeStarted = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motionControllerModeEnded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.motionControllerModeEnded = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
