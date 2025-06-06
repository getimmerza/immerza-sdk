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
    public class UnityEngineInputSystemInputActionAssetWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.InputSystem.InputActionAsset);
			Utils.BeginObjectRegister(type, L, translator, 0, 13, 6, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToJson", _m_ToJson);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadFromJson", _m_LoadFromJson);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindAction", _m_FindAction);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindBinding", _m_FindBinding);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindActionMap", _m_FindActionMap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindControlSchemeIndex", _m_FindControlSchemeIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindControlScheme", _m_FindControlScheme);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsUsableWithDevice", _m_IsUsableWithDevice);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Enable", _m_Enable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Disable", _m_Disable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", _m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "actionMaps", _g_get_actionMaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controlSchemes", _g_get_controlSchemes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bindings", _g_get_bindings);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bindingMask", _g_get_bindingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "devices", _g_get_devices);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bindingMask", _s_set_bindingMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "devices", _s_set_devices);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FromJson", _m_FromJson_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Extension", UnityEngine.InputSystem.InputActionAsset.Extension);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.InputSystem.InputActionAsset();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.InputSystem.InputActionAsset constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.Push(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToJson(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ToJson(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromJson(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _json = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.LoadFromJson( _json );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromJson_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _json = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.InputSystem.InputActionAsset.FromJson( _json );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindAction(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    System.Guid _guid;translator.Get(L, 2, out _guid);
                    
                        var gen_ret = gen_to_be_invoked.FindAction( _guid );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _actionNameOrId = LuaAPI.lua_tostring(L, 2);
                    bool _throwIfNotFound = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.FindAction( _actionNameOrId, _throwIfNotFound );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _actionNameOrId = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindAction( _actionNameOrId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.InputSystem.InputActionAsset.FindAction!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindBinding(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputBinding _mask;translator.Get(L, 2, out _mask);
                    UnityEngine.InputSystem.InputAction _action;
                    
                        var gen_ret = gen_to_be_invoked.FindBinding( _mask, out _action );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _action);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindActionMap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    System.Guid _id;translator.Get(L, 2, out _id);
                    
                        var gen_ret = gen_to_be_invoked.FindActionMap( _id );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _nameOrId = LuaAPI.lua_tostring(L, 2);
                    bool _throwIfNotFound = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.FindActionMap( _nameOrId, _throwIfNotFound );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _nameOrId = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindActionMap( _nameOrId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.InputSystem.InputActionAsset.FindActionMap!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindControlSchemeIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindControlSchemeIndex( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindControlScheme(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindControlScheme( _name );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsUsableWithDevice(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputDevice _device = (UnityEngine.InputSystem.InputDevice)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputDevice));
                    
                        var gen_ret = gen_to_be_invoked.IsUsableWithDevice( _device );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Enable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Enable(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Disable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Disable(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Contains(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputAction _action = (UnityEngine.InputSystem.InputAction)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputAction));
                    
                        var gen_ret = gen_to_be_invoked.Contains( _action );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_actionMaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.actionMaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlSchemes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.controlSchemes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bindings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.bindings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bindingMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.bindingMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_devices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.devices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bindingMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                System.Nullable<UnityEngine.InputSystem.InputBinding> gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.bindingMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_devices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.InputSystem.InputActionAsset gen_to_be_invoked = (UnityEngine.InputSystem.InputActionAsset)translator.FastGetCSObj(L, 1);
                System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.devices = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
