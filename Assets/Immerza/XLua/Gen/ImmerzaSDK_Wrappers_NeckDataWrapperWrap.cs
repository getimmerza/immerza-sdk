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
    public class ImmerzaSDKWrappersNeckDataWrapperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ImmerzaSDK.Wrappers.NeckDataWrapper);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStatus", _m_SetStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCode", _m_SetCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEffectiveDateTime", _m_SetEffectiveDateTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSubject", _m_SetSubject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDevice", _m_SetDevice);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", _m_AddComponent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "status", _g_get_status);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "code", _g_get_code);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectiveDateTime", _g_get_effectiveDateTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subject", _g_get_subject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "device", _g_get_device);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "components", _g_get_components);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "status", _s_set_status);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "code", _s_set_code);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "effectiveDateTime", _s_set_effectiveDateTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "subject", _s_set_subject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "device", _s_set_device);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "components", _s_set_components);
            
			
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
					
					var gen_ret = new ImmerzaSDK.Wrappers.NeckDataWrapper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.Wrappers.NeckDataWrapper constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _status = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetStatus( _status );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _code = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetCode( _code );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEffectiveDateTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.DateTime _datetime;translator.Get(L, 2, out _datetime);
                    
                    gen_to_be_invoked.SetEffectiveDateTime( _datetime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSubject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _id = LuaAPI.lua_tostring(L, 2);
                    string _type = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.SetSubject( _id, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDevice(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _id = LuaAPI.lua_tostring(L, 2);
                    string _type = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.SetDevice( _id, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _code = LuaAPI.lua_tostring(L, 2);
                    string _quantityType = LuaAPI.lua_tostring(L, 3);
                    string _value = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.AddComponent( _code, _quantityType, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_status(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.status);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_code(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.code);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectiveDateTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.effectiveDateTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_subject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.subject);
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
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.device);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_components(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.components);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_status(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.status = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_code(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.code = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_effectiveDateTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                System.DateTime gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.effectiveDateTime = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_subject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.subject = (ImmerzaSDK.Wrappers.Subject)translator.GetObject(L, 2, typeof(ImmerzaSDK.Wrappers.Subject));
            
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
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.device = (ImmerzaSDK.Wrappers.Device)translator.GetObject(L, 2, typeof(ImmerzaSDK.Wrappers.Device));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_components(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.Wrappers.NeckDataWrapper gen_to_be_invoked = (ImmerzaSDK.Wrappers.NeckDataWrapper)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.components = (System.Collections.Generic.List<ImmerzaSDK.Wrappers.Component>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<ImmerzaSDK.Wrappers.Component>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
