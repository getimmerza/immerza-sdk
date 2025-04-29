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
    public class UnityEngineXRInteractionToolkitFilteringXRPokeFilterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 5, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeInteractable", _g_get_pokeInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeCollider", _g_get_pokeCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeConfiguration", _g_get_pokeConfiguration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeStateData", _g_get_pokeStateData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canProcess", _g_get_canProcess);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeInteractable", _s_set_pokeInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeCollider", _s_set_pokeCollider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeConfiguration", _s_set_pokeConfiguration);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor>(L, 2)&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable>(L, 3)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.Process( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>(L, 2)&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    float _interactionStrength = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Process( _interactor, _interactable, _interactionStrength );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter.Process!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pokeInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pokeCollider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeConfiguration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pokeConfiguration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeStateData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.pokeStateData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canProcess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canProcess);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeConfiguration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRPokeFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeConfiguration = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
