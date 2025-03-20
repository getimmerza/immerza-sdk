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
    public class UnityEngineXRInteractionToolkitLocomotionTurningSnapTurnProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 9, 8);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "turnAmount", _g_get_turnAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "debounceTime", _g_get_debounceTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableTurnLeftRight", _g_get_enableTurnLeftRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableTurnAround", _g_get_enableTurnAround);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "delayTime", _g_get_delayTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canStartMoving", _g_get_canStartMoving);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transformation", _g_get_transformation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftHandTurnInput", _g_get_leftHandTurnInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightHandTurnInput", _g_get_rightHandTurnInput);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "turnAmount", _s_set_turnAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "debounceTime", _s_set_debounceTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableTurnLeftRight", _s_set_enableTurnLeftRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableTurnAround", _s_set_enableTurnAround);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "delayTime", _s_set_delayTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transformation", _s_set_transformation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftHandTurnInput", _s_set_leftHandTurnInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightHandTurnInput", _s_set_rightHandTurnInput);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_turnAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.turnAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_debounceTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.debounceTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableTurnLeftRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableTurnLeftRight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableTurnAround(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableTurnAround);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_delayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.delayTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canStartMoving(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canStartMoving);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftHandTurnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftHandTurnInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightHandTurnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightHandTurnInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_turnAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.turnAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_debounceTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.debounceTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableTurnLeftRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableTurnLeftRight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableTurnAround(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableTurnAround = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_delayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.delayTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyYawRotation)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyYawRotation));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftHandTurnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftHandTurnInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightHandTurnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.SnapTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightHandTurnInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
