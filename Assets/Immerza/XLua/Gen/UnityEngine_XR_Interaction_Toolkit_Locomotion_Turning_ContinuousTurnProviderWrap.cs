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
    public class UnityEngineXRInteractionToolkitLocomotionTurningContinuousTurnProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "turnSpeed", _g_get_turnSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftHandTurnInput", _g_get_leftHandTurnInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightHandTurnInput", _g_get_rightHandTurnInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transformation", _g_get_transformation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "turnSpeed", _s_set_turnSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftHandTurnInput", _s_set_leftHandTurnInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightHandTurnInput", _s_set_rightHandTurnInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transformation", _s_set_transformation);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_turnSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.turnSpeed);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightHandTurnInput);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_turnSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.turnSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightHandTurnInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning.ContinuousTurnProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyYawRotation)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyYawRotation));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
