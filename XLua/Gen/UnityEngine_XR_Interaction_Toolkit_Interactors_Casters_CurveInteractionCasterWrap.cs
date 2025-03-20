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
    public class UnityEngineXRInteractionToolkitInteractorsCastersCurveInteractionCasterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 10, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetColliderTargets", _m_TryGetColliderTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUIModel", _m_UpdateUIModel);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "samplePoints", _g_get_samplePoints);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastSamplePoint", _g_get_lastSamplePoint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastMask", _g_get_raycastMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastTriggerInteraction", _g_get_raycastTriggerInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastSnapVolumeInteraction", _g_get_raycastSnapVolumeInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetNumCurveSegments", _g_get_targetNumCurveSegments);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hitDetectionType", _g_get_hitDetectionType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "castDistance", _g_get_castDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sphereCastRadius", _g_get_sphereCastRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "coneCastAngle", _g_get_coneCastAngle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastMask", _s_set_raycastMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastTriggerInteraction", _s_set_raycastTriggerInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastSnapVolumeInteraction", _s_set_raycastSnapVolumeInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetNumCurveSegments", _s_set_targetNumCurveSegments);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hitDetectionType", _s_set_hitDetectionType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "castDistance", _s_set_castDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sphereCastRadius", _s_set_sphereCastRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "coneCastAngle", _s_set_coneCastAngle);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetColliderTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.XRInteractionManager>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider>>(L, 3)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionManager _interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
                    System.Collections.Generic.List<UnityEngine.Collider> _targets = (System.Collections.Generic.List<UnityEngine.Collider>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider>));
                    
                        var gen_ret = gen_to_be_invoked.TryGetColliderTargets( _interactionManager, _targets );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.XRInteractionManager>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit>>(L, 4)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionManager _interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
                    System.Collections.Generic.List<UnityEngine.Collider> _targets = (System.Collections.Generic.List<UnityEngine.Collider>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider>));
                    System.Collections.Generic.List<UnityEngine.RaycastHit> _raycastHits = (System.Collections.Generic.List<UnityEngine.RaycastHit>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit>));
                    
                        var gen_ret = gen_to_be_invoked.TryGetColliderTargets( _interactionManager, _targets, _raycastHits );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster.TryGetColliderTargets!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUIModel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceModel _uiModel;translator.Get(L, 2, out _uiModel);
                    bool _isSelectActive = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.Vector2 _scrollDelta;translator.Get(L, 4, out _scrollDelta);
                    
                        var gen_ret = gen_to_be_invoked.UpdateUIModel( ref _uiModel, _isSelectActive, _scrollDelta );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _uiModel);
                        translator.Update(L, 2, _uiModel);
                        
                    translator.PushUnityEngineVector2(L, _scrollDelta);
                        translator.UpdateUnityEngineVector2(L, 4, _scrollDelta);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_samplePoints(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.samplePoints);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastSamplePoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.lastSamplePoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastTriggerInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastSnapVolumeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastSnapVolumeInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetNumCurveSegments(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.targetNumCurveSegments);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hitDetectionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hitDetectionType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_castDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.castDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sphereCastRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sphereCastRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_coneCastAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.coneCastAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.QueryTriggerInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastTriggerInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastSnapVolumeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster.QuerySnapVolumeInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastSnapVolumeInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetNumCurveSegments(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetNumCurveSegments = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hitDetectionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster.HitDetectionType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.hitDetectionType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_castDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.castDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sphereCastRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sphereCastRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_coneCastAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.coneCastAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
