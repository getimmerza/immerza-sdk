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
    public class UnityEngineXRInteractionToolkitInputsHapticsHapticImpulseSingleChannelGroupWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChannel", _m_GetChannel);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "channelCount", _g_get_channelCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "impulseChannel", _g_get_impulseChannel);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.IXRHapticImpulseChannel>(L, 2))
				{
					UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.IXRHapticImpulseChannel _channel = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.IXRHapticImpulseChannel)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.IXRHapticImpulseChannel));
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup(_channel);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _channel = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetChannel( _channel );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.GetChannel(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup.GetChannel!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_channelCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.channelCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_impulseChannel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulseSingleChannelGroup)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.impulseChannel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
