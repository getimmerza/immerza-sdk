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
    public class UnityEngineXRInteractionToolkitInputsHapticsOpenXROpenXRHapticImpulseChannelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendHapticImpulse", _m_SendHapticImpulse);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hapticAction", _g_get_hapticAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "device", _g_get_device);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "hapticAction", _s_set_hapticAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "device", _s_set_device);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendHapticImpulse(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _amplitude = (float)LuaAPI.lua_tonumber(L, 2);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 3);
                    float _frequency = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.SendHapticImpulse( _amplitude, _duration, _frequency );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hapticAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hapticAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_device(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.device);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hapticAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hapticAction = (UnityEngine.InputSystem.InputAction)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputAction));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_device(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR.OpenXRHapticImpulseChannel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.device = (UnityEngine.InputSystem.InputDevice)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputDevice));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
