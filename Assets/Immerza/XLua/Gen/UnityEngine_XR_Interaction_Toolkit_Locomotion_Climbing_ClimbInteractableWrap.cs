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
    public class UnityEngineXRInteractionToolkitLocomotionClimbingClimbInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHoverableBy", _m_IsHoverableBy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelectableBy", _m_IsSelectableBy);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbProvider", _g_get_climbProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbTransform", _g_get_climbTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterInteractionByDistance", _g_get_filterInteractionByDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxInteractionDistance", _g_get_maxInteractionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbAssistanceTeleportVolume", _g_get_climbAssistanceTeleportVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbSettingsOverride", _g_get_climbSettingsOverride);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbProvider", _s_set_climbProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbTransform", _s_set_climbTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterInteractionByDistance", _s_set_filterInteractionByDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxInteractionDistance", _s_set_maxInteractionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbAssistanceTeleportVolume", _s_set_climbAssistanceTeleportVolume);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbSettingsOverride", _s_set_climbSettingsOverride);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoverableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsHoverableBy( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSelectableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsSelectableBy( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbProvider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterInteractionByDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.filterInteractionByDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxInteractionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxInteractionDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbAssistanceTeleportVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbAssistanceTeleportVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbSettingsOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbSettingsOverride);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbProvider = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_climbTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterInteractionByDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filterInteractionByDistance = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxInteractionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxInteractionDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_climbAssistanceTeleportVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbAssistanceTeleportVolume = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_climbSettingsOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbSettingsOverride = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatumProperty)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatumProperty));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
