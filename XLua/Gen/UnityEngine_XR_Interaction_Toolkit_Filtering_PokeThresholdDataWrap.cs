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
    public class UnityEngineXRInteractionToolkitFilteringPokeThresholdDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSelectEntranceVectorDotThreshold", _m_GetSelectEntranceVectorDotThreshold);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeDirection", _g_get_pokeDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionDepthOffset", _g_get_interactionDepthOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enablePokeAngleThreshold", _g_get_enablePokeAngleThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeAngleThreshold", _g_get_pokeAngleThreshold);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeDirection", _s_set_pokeDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionDepthOffset", _s_set_interactionDepthOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enablePokeAngleThreshold", _s_set_enablePokeAngleThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeAngleThreshold", _s_set_pokeAngleThreshold);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSelectEntranceVectorDotThreshold(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetSelectEntranceVectorDotThreshold(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pokeDirection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionDepthOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.interactionDepthOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enablePokeAngleThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enablePokeAngleThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeAngleThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeAngleThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeAxis gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.pokeDirection = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionDepthOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionDepthOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enablePokeAngleThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enablePokeAngleThreshold = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeAngleThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeAngleThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
