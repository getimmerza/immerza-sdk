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
    public class UnityEngineXRInteractionToolkitLocomotionClimbingClimbProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 4, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartClimbGrab", _m_StartClimbGrab);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FinishClimbGrab", _m_FinishClimbGrab);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "climbAnchorUpdated", _e_climbAnchorUpdated);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbSettings", _g_get_climbSettings);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbAnchorInteractable", _g_get_climbAnchorInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "climbAnchorInteractor", _g_get_climbAnchorInteractor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transformation", _g_get_transformation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "climbSettings", _s_set_climbSettings);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transformation", _s_set_transformation);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartClimbGrab(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable _climbInteractable = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                    gen_to_be_invoked.StartClimbGrab( _climbInteractable, _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FinishClimbGrab(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                    gen_to_be_invoked.FinishClimbGrab( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbSettings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbSettings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbAnchorInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.climbAnchorInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_climbAnchorInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.climbAnchorInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_climbSettings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.climbSettings = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatumProperty)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbSettingsDatumProperty));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginMovement)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginMovement));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_climbAnchorUpdated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.climbAnchorUpdated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.climbAnchorUpdated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider.climbAnchorUpdated!");
            return 0;
        }
        
		
		
    }
}
