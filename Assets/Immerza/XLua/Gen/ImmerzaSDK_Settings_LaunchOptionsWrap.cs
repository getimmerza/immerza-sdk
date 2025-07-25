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
    public class ImmerzaSDKSettingsLaunchOptionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ImmerzaSDK.Settings.LaunchOptions);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Options", _g_get_Options);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Options", _s_set_Options);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 1, 0);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "OnLaunchOptionsReceived", _e_OnLaunchOptionsReceived);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new ImmerzaSDK.Settings.LaunchOptions();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.Settings.LaunchOptions constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Settings.LaunchOptions gen_to_be_invoked = (ImmerzaSDK.Settings.LaunchOptions)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.Dictionary<string, object> _options = (System.Collections.Generic.Dictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, object>));
                    
                    gen_to_be_invoked.Init( _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ImmerzaSDK.Settings.LaunchOptions.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Settings.LaunchOptions gen_to_be_invoked = (ImmerzaSDK.Settings.LaunchOptions)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Options);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Options(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Settings.LaunchOptions gen_to_be_invoked = (ImmerzaSDK.Settings.LaunchOptions)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Options = (System.Collections.Generic.Dictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnLaunchOptionsReceived(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<System.Collections.Generic.Dictionary<string, object>> gen_delegate = translator.GetDelegate<System.Action<System.Collections.Generic.Dictionary<string, object>>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<System.Collections.Generic.Dictionary<string, object>>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					ImmerzaSDK.Settings.LaunchOptions.OnLaunchOptionsReceived += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					ImmerzaSDK.Settings.LaunchOptions.OnLaunchOptionsReceived -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.Settings.LaunchOptions.OnLaunchOptionsReceived!");
        }
        
    }
}
