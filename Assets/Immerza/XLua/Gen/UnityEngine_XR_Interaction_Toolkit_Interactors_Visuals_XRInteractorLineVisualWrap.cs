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
    public class UnityEngineXRInteractionToolkitInteractorsVisualsXRInteractorLineVisualWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 26, 26);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachCustomReticle", _m_AttachCustomReticle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCustomReticle", _m_RemoveCustomReticle);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineWidth", _g_get_lineWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideInteractorLineLength", _g_get_overrideInteractorLineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineLength", _g_get_lineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoAdjustLineLength", _g_get_autoAdjustLineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minLineLength", _g_get_minLineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDistanceToHitAsMaxLineLength", _g_get_useDistanceToHitAsMaxLineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineRetractionDelay", _g_get_lineRetractionDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineLengthChangeSpeed", _g_get_lineLengthChangeSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "widthCurve", _g_get_widthCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "setLineColorGradient", _g_get_setLineColorGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "validColorGradient", _g_get_validColorGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "invalidColorGradient", _g_get_invalidColorGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockedColorGradient", _g_get_blockedColorGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "treatSelectionAsValidState", _g_get_treatSelectionAsValidState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothMovement", _g_get_smoothMovement);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "followTightness", _g_get_followTightness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapThresholdDistance", _g_get_snapThresholdDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reticle", _g_get_reticle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockedReticle", _g_get_blockedReticle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stopLineAtFirstRaycastHit", _g_get_stopLineAtFirstRaycastHit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stopLineAtSelection", _g_get_stopLineAtSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapEndpointIfAvailable", _g_get_snapEndpointIfAvailable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineBendRatio", _g_get_lineBendRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideInteractorLineOrigin", _g_get_overrideInteractorLineOrigin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineOriginTransform", _g_get_lineOriginTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineOriginOffset", _g_get_lineOriginOffset);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineWidth", _s_set_lineWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideInteractorLineLength", _s_set_overrideInteractorLineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineLength", _s_set_lineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoAdjustLineLength", _s_set_autoAdjustLineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minLineLength", _s_set_minLineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDistanceToHitAsMaxLineLength", _s_set_useDistanceToHitAsMaxLineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineRetractionDelay", _s_set_lineRetractionDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineLengthChangeSpeed", _s_set_lineLengthChangeSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "widthCurve", _s_set_widthCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "setLineColorGradient", _s_set_setLineColorGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "validColorGradient", _s_set_validColorGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "invalidColorGradient", _s_set_invalidColorGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockedColorGradient", _s_set_blockedColorGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "treatSelectionAsValidState", _s_set_treatSelectionAsValidState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothMovement", _s_set_smoothMovement);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "followTightness", _s_set_followTightness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapThresholdDistance", _s_set_snapThresholdDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reticle", _s_set_reticle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockedReticle", _s_set_blockedReticle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stopLineAtFirstRaycastHit", _s_set_stopLineAtFirstRaycastHit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stopLineAtSelection", _s_set_stopLineAtSelection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapEndpointIfAvailable", _s_set_snapEndpointIfAvailable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineBendRatio", _s_set_lineBendRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideInteractorLineOrigin", _s_set_overrideInteractorLineOrigin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineOriginTransform", _s_set_lineOriginTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineOriginOffset", _s_set_lineOriginOffset);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachCustomReticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _reticleInstance = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                        var gen_ret = gen_to_be_invoked.AttachCustomReticle( _reticleInstance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCustomReticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.RemoveCustomReticle(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideInteractorLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideInteractorLineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoAdjustLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoAdjustLineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minLineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useDistanceToHitAsMaxLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useDistanceToHitAsMaxLineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineRetractionDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineRetractionDelay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineLengthChangeSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineLengthChangeSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_widthCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.widthCurve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_setLineColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.setLineColorGradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_validColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.validColorGradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_invalidColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.invalidColorGradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockedColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.blockedColorGradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_treatSelectionAsValidState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.treatSelectionAsValidState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothMovement(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothMovement);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_followTightness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.followTightness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapThresholdDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.snapThresholdDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.reticle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockedReticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.blockedReticle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stopLineAtFirstRaycastHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.stopLineAtFirstRaycastHit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stopLineAtSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.stopLineAtSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapEndpointIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.snapEndpointIfAvailable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineBendRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineBendRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideInteractorLineOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideInteractorLineOrigin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineOriginTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lineOriginTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineOriginOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineOriginOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideInteractorLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideInteractorLineLength = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineLength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoAdjustLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoAdjustLineLength = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minLineLength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useDistanceToHitAsMaxLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useDistanceToHitAsMaxLineLength = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineRetractionDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineRetractionDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineLengthChangeSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineLengthChangeSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_widthCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.widthCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_setLineColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.setLineColorGradient = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_validColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.validColorGradient = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_invalidColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.invalidColorGradient = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockedColorGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.blockedColorGradient = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_treatSelectionAsValidState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.treatSelectionAsValidState = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothMovement(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothMovement = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_followTightness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.followTightness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapThresholdDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapThresholdDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reticle = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockedReticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.blockedReticle = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stopLineAtFirstRaycastHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stopLineAtFirstRaycastHit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stopLineAtSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stopLineAtSelection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapEndpointIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapEndpointIfAvailable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineBendRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineBendRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideInteractorLineOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideInteractorLineOrigin = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineOriginTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineOriginTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineOriginOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineOriginOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
