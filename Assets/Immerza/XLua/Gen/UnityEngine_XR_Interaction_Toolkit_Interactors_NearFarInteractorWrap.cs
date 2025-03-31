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
    public class UnityEngineXRInteractionToolkitInteractorsNearFarInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 16, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUIModel", _m_UpdateUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetUIModel", _m_TryGetUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurrentUIRaycastResult", _m_TryGetCurrentUIRaycastResult);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurveEndPoint", _m_TryGetCurveEndPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurveEndNormal", _m_TryGetCurveEndNormal);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionAttachController", _g_get_interactionAttachController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableNearCasting", _g_get_enableNearCasting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nearInteractionCaster", _g_get_nearInteractionCaster);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "nearCasterSortingStrategy", _g_get_nearCasterSortingStrategy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortNearTargetsAfterTargetFilter", _g_get_sortNearTargetsAfterTargetFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableFarCasting", _g_get_enableFarCasting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farInteractionCaster", _g_get_farInteractionCaster);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farAttachMode", _g_get_farAttachMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableUIInteraction", _g_get_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockUIOnInteractableSelection", _g_get_blockUIOnInteractableSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverEntered", _g_get_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverExited", _g_get_uiHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiPressInput", _g_get_uiPressInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiScrollInput", _g_get_uiScrollInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectionRegion", _g_get_selectionRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "curveOrigin", _g_get_curveOrigin);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionAttachController", _s_set_interactionAttachController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableNearCasting", _s_set_enableNearCasting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nearInteractionCaster", _s_set_nearInteractionCaster);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "nearCasterSortingStrategy", _s_set_nearCasterSortingStrategy);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortNearTargetsAfterTargetFilter", _s_set_sortNearTargetsAfterTargetFilter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableFarCasting", _s_set_enableFarCasting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farInteractionCaster", _s_set_farInteractionCaster);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farAttachMode", _s_set_farAttachMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableUIInteraction", _s_set_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockUIOnInteractableSelection", _s_set_blockUIOnInteractableSelection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverEntered", _s_set_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverExited", _s_set_uiHoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiPressInput", _s_set_uiPressInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiScrollInput", _s_set_uiScrollInput);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 2, out _updatePhase);
                    
                    gen_to_be_invoked.PreprocessInteractor( _updatePhase );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetValidTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_UpdateUIModel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceModel _model;translator.Get(L, 2, out _model);
                    
                    gen_to_be_invoked.UpdateUIModel( ref _model );
                    translator.Push(L, _model);
                        translator.Update(L, 2, _model);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetUIModel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceModel _model;
                    
                        var gen_ret = gen_to_be_invoked.TryGetUIModel( out _model );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _model);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurrentUIRaycastResult(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.RaycastResult _raycastResult;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentUIRaycastResult( out _raycastResult );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastResult);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurveEndPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 _endPoint;
                    bool _snapToSelectedAttachIfAvailable = LuaAPI.lua_toboolean(L, 2);
                    bool _snapToSnapVolumeIfAvailable = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurveEndPoint( out _endPoint, _snapToSelectedAttachIfAvailable, _snapToSnapVolumeIfAvailable );
                        translator.Push(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _endPoint);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector3 _endPoint;
                    bool _snapToSelectedAttachIfAvailable = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurveEndPoint( out _endPoint, _snapToSelectedAttachIfAvailable );
                        translator.Push(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _endPoint);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 1) 
                {
                    UnityEngine.Vector3 _endPoint;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurveEndPoint( out _endPoint );
                        translator.Push(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _endPoint);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor.TryGetCurveEndPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurveEndNormal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector3 _endNormal;
                    bool _snapToSelectedAttachIfAvailable = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurveEndNormal( out _endNormal, _snapToSelectedAttachIfAvailable );
                        translator.Push(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _endNormal);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 1) 
                {
                    UnityEngine.Vector3 _endNormal;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurveEndNormal( out _endNormal );
                        translator.Push(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _endNormal);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor.TryGetCurveEndNormal!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionAttachController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactionAttachController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableNearCasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableNearCasting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nearInteractionCaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.nearInteractionCaster);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nearCasterSortingStrategy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.nearCasterSortingStrategy);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortNearTargetsAfterTargetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.sortNearTargetsAfterTargetFilter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableFarCasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableFarCasting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_farInteractionCaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.farInteractionCaster);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_farAttachMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.farAttachMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableUIInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableUIInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockUIOnInteractableSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.blockUIOnInteractableSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiPressInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiPressInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiScrollInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiScrollInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectionRegion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectionRegion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curveOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.curveOrigin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionAttachController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionAttachController = (UnityEngine.XR.Interaction.Toolkit.Attachment.IInteractionAttachController)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Attachment.IInteractionAttachController));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableNearCasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableNearCasting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nearInteractionCaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.nearInteractionCaster = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.IInteractionCaster)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.IInteractionCaster));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_nearCasterSortingStrategy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor.NearCasterSortingStrategy gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.nearCasterSortingStrategy = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortNearTargetsAfterTargetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sortNearTargetsAfterTargetFilter = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableFarCasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableFarCasting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_farInteractionCaster(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.farInteractionCaster = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.ICurveInteractionCaster)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.ICurveInteractionCaster));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_farAttachMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractorFarAttachMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.farAttachMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableUIInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableUIInteraction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockUIOnInteractableSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.blockUIOnInteractableSelection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHoverEntered = (UnityEngine.XR.Interaction.Toolkit.UI.UIHoverEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.UI.UIHoverEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHoverExited = (UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiPressInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiPressInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiScrollInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiScrollInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
