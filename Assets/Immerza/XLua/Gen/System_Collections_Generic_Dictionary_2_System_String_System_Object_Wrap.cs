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
    public class SystemCollectionsGenericDictionary_2_SystemStringSystemObject_Wrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Collections.Generic.Dictionary<string, object>);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "set_Item", _m_set_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsKey", _m_ContainsKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsValue", _m_ContainsValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectData", _m_GetObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeserialization", _m_OnDeserialization);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetValue", _m_TryGetValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryAdd", _m_TryAdd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureCapacity", _m_EnsureCapacity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TrimExcess", _m_TrimExcess);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Comparer", _g_get_Comparer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Keys", _g_get_Keys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Values", _g_get_Values);
            
			
			
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
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _capacity = LuaAPI.xlua_tointeger(L, 2);
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_capacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEqualityComparer<string>>(L, 2))
				{
					System.Collections.Generic.IEqualityComparer<string> _comparer = (System.Collections.Generic.IEqualityComparer<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEqualityComparer<string>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<string>>(L, 3))
				{
					int _capacity = LuaAPI.xlua_tointeger(L, 2);
					System.Collections.Generic.IEqualityComparer<string> _comparer = (System.Collections.Generic.IEqualityComparer<string>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<string>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_capacity, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IDictionary<string, object>>(L, 2))
				{
					System.Collections.Generic.IDictionary<string, object> _dictionary = (System.Collections.Generic.IDictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IDictionary<string, object>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_dictionary);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IDictionary<string, object>>(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<string>>(L, 3))
				{
					System.Collections.Generic.IDictionary<string, object> _dictionary = (System.Collections.Generic.IDictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IDictionary<string, object>));
					System.Collections.Generic.IEqualityComparer<string> _comparer = (System.Collections.Generic.IEqualityComparer<string>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<string>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_dictionary, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> _collection = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_collection);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>>(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<string>>(L, 3))
				{
					System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> _collection = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>));
					System.Collections.Generic.IEqualityComparer<string> _comparer = (System.Collections.Generic.IEqualityComparer<string>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<string>));
					
					var gen_ret = new System.Collections.Generic.Dictionary<string, object>(_collection, _comparer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<string, object> constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.PushAny(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_set_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					object gen_value = translator.GetObject(L, 3, typeof(object));
                    gen_to_be_invoked[key] = gen_value;
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Add( _key, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.ContainsKey( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        var gen_ret = gen_to_be_invoked.ContainsValue( _value );
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
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Runtime.Serialization.SerializationInfo _info = (System.Runtime.Serialization.SerializationInfo)translator.GetObject(L, 2, typeof(System.Runtime.Serialization.SerializationInfo));
                    System.Runtime.Serialization.StreamingContext _context;translator.Get(L, 3, out _context);
                    
                    gen_to_be_invoked.GetObjectData( _info, _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDeserialization(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _sender = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.OnDeserialization( _sender );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.Remove( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object _value;
                    
                        var gen_ret = gen_to_be_invoked.Remove( _key, out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<string, object>.Remove!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object _value;
                    
                        var gen_ret = gen_to_be_invoked.TryGetValue( _key, out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryAdd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                        var gen_ret = gen_to_be_invoked.TryAdd( _key, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureCapacity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _capacity = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EnsureCapacity( _capacity );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TrimExcess(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.TrimExcess(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _capacity = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.TrimExcess( _capacity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<string, object>.TrimExcess!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Comparer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Comparer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keys(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Keys);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Values(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Collections.Generic.Dictionary<string, object> gen_to_be_invoked = (System.Collections.Generic.Dictionary<string, object>)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Values);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
