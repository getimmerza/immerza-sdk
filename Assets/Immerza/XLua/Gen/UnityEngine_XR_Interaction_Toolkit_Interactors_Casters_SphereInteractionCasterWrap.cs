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
    public class UnityEngineXRInteractionToolkitInteractorsCastersSphereInteractionCasterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetColliderTargets", _m_TryGetColliderTargets);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicsLayerMask", _g_get_physicsLayerMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicsTriggerInteraction", _g_get_physicsTriggerInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "castRadius", _g_get_castRadius);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicsLayerMask", _s_set_physicsLayerMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicsTriggerInteraction", _s_set_physicsTriggerInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "castRadius", _s_set_castRadius);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetColliderTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionManager _interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
                    System.Collections.Generic.List<UnityEngine.Collider> _targets = (System.Collections.Generic.List<UnityEngine.Collider>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider>));
                    
                        var gen_ret = gen_to_be_invoked.TryGetColliderTargets( _interactionManager, _targets );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_physicsLayerMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.physicsLayerMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_physicsTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.physicsTriggerInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_castRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.castRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_physicsLayerMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.physicsLayerMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_physicsTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.QueryTriggerInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.physicsTriggerInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_castRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.SphereInteractionCaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.castRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
