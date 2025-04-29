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
    public class UnityEngineXRInteractionToolkitLocomotionClimbingClimbTeleportInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 5, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetActivateTargets", _m_GetActivateTargets);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbProvider", _g_get_climbProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "destinationEvaluationSettings", _g_get_destinationEvaluationSettings);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldActivate", _g_get_shouldActivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldDeactivate", _g_get_shouldDeactivate);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbProvider", _s_set_climbProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "destinationEvaluationSettings", _s_set_destinationEvaluationSettings);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetValidTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> _targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>));
                    
                    gen_to_be_invoked.GetValidTargets( _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActivateTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable> _targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable>));
                    
                    gen_to_be_invoked.GetActivateTargets( _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbProvider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_destinationEvaluationSettings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.destinationEvaluationSettings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSelectActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.shouldActivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldDeactivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.shouldDeactivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_climbProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbProvider = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_destinationEvaluationSettings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.destinationEvaluationSettings = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportVolumeDestinationSettingsDatumProperty)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportVolumeDestinationSettingsDatumProperty));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
