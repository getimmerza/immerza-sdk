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
    public class UnityEngineXRInteractionToolkitLocomotionMovementContinuousMoveProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 8, 8);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "moveSpeed", _g_get_moveSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableStrafe", _g_get_enableStrafe);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableFly", _g_get_enableFly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGravity", _g_get_useGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forwardSource", _g_get_forwardSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transformation", _g_get_transformation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftHandMoveInput", _g_get_leftHandMoveInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightHandMoveInput", _g_get_rightHandMoveInput);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "moveSpeed", _s_set_moveSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableStrafe", _s_set_enableStrafe);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableFly", _s_set_enableFly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGravity", _s_set_useGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forwardSource", _s_set_forwardSource);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transformation", _s_set_transformation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftHandMoveInput", _s_set_leftHandMoveInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightHandMoveInput", _s_set_rightHandMoveInput);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_moveSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.moveSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableStrafe(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableStrafe);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableFly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableFly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useGravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forwardSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.forwardSource);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftHandMoveInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftHandMoveInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightHandMoveInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightHandMoveInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_moveSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.moveSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableStrafe(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableStrafe = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableFly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableFly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useGravity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forwardSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.forwardSource = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginMovement)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginMovement));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftHandMoveInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftHandMoveInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightHandMoveInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.ContinuousMoveProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightHandMoveInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
