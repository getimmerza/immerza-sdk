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
    public class UnityEngineXRInteractionToolkitInteractorsVisualsCurveVisualControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 29, 29);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineRenderer", _g_get_lineRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "curveInteractionDataProvider", _g_get_curveInteractionDataProvider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideLineOrigin", _g_get_overrideLineOrigin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineOriginTransform", _g_get_lineOriginTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "visualPointCount", _g_get_visualPointCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxVisualCurveDistance", _g_get_maxVisualCurveDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restingVisualLineLength", _g_get_restingVisualLineLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineDynamicsMode", _g_get_lineDynamicsMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "retractDelay", _g_get_retractDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "retractDuration", _g_get_retractDuration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "extendLineToEmptyHit", _g_get_extendLineToEmptyHit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "extensionRate", _g_get_extensionRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endPointExpansionRate", _g_get_endPointExpansionRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "computeMidPointWithComplexCurves", _g_get_computeMidPointWithComplexCurves);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapToSelectedAttachIfAvailable", _g_get_snapToSelectedAttachIfAvailable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapToSnapVolumeIfAvailable", _g_get_snapToSnapVolumeIfAvailable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "curveStartOffset", _g_get_curveStartOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "curveEndOffset", _g_get_curveEndOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customizeLinePropertiesForState", _g_get_customizeLinePropertiesForState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linePropertyAnimationSpeed", _g_get_linePropertyAnimationSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "noValidHitProperties", _g_get_noValidHitProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHitProperties", _g_get_uiHitProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiPressHitProperties", _g_get_uiPressHitProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectHitProperties", _g_get_selectHitProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverHitProperties", _g_get_hoverHitProperties);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderLineInWorldSpace", _g_get_renderLineInWorldSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swapMaterials", _g_get_swapMaterials);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "baseLineMaterial", _g_get_baseLineMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "emptyHitMaterial", _g_get_emptyHitMaterial);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineRenderer", _s_set_lineRenderer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "curveInteractionDataProvider", _s_set_curveInteractionDataProvider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideLineOrigin", _s_set_overrideLineOrigin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineOriginTransform", _s_set_lineOriginTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "visualPointCount", _s_set_visualPointCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxVisualCurveDistance", _s_set_maxVisualCurveDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restingVisualLineLength", _s_set_restingVisualLineLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineDynamicsMode", _s_set_lineDynamicsMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "retractDelay", _s_set_retractDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "retractDuration", _s_set_retractDuration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "extendLineToEmptyHit", _s_set_extendLineToEmptyHit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "extensionRate", _s_set_extensionRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endPointExpansionRate", _s_set_endPointExpansionRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "computeMidPointWithComplexCurves", _s_set_computeMidPointWithComplexCurves);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapToSelectedAttachIfAvailable", _s_set_snapToSelectedAttachIfAvailable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapToSnapVolumeIfAvailable", _s_set_snapToSnapVolumeIfAvailable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "curveStartOffset", _s_set_curveStartOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "curveEndOffset", _s_set_curveEndOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customizeLinePropertiesForState", _s_set_customizeLinePropertiesForState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linePropertyAnimationSpeed", _s_set_linePropertyAnimationSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "noValidHitProperties", _s_set_noValidHitProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHitProperties", _s_set_uiHitProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiPressHitProperties", _s_set_uiPressHitProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectHitProperties", _s_set_selectHitProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverHitProperties", _s_set_hoverHitProperties);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderLineInWorldSpace", _s_set_renderLineInWorldSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swapMaterials", _s_set_swapMaterials);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "baseLineMaterial", _s_set_baseLineMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "emptyHitMaterial", _s_set_emptyHitMaterial);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lineRenderer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curveInteractionDataProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.curveInteractionDataProvider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideLineOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideLineOrigin);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lineOriginTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_visualPointCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.visualPointCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxVisualCurveDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxVisualCurveDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_restingVisualLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.restingVisualLineLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineDynamicsMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lineDynamicsMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_retractDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.retractDelay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_retractDuration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.retractDuration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_extendLineToEmptyHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.extendLineToEmptyHit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_extensionRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.extensionRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endPointExpansionRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endPointExpansionRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_computeMidPointWithComplexCurves(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.computeMidPointWithComplexCurves);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapToSelectedAttachIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.snapToSelectedAttachIfAvailable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapToSnapVolumeIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.snapToSnapVolumeIfAvailable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curveStartOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.curveStartOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curveEndOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.curveEndOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customizeLinePropertiesForState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.customizeLinePropertiesForState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linePropertyAnimationSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.linePropertyAnimationSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_noValidHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.noValidHitProperties);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHitProperties);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiPressHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiPressHitProperties);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectHitProperties);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverHitProperties);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderLineInWorldSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.renderLineInWorldSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swapMaterials(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.swapMaterials);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baseLineMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.baseLineMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_emptyHitMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.emptyHitMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineRenderer = (UnityEngine.LineRenderer)translator.GetObject(L, 2, typeof(UnityEngine.LineRenderer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_curveInteractionDataProvider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.curveInteractionDataProvider = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.ICurveInteractionDataProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.ICurveInteractionDataProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideLineOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideLineOrigin = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineOriginTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_visualPointCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.visualPointCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxVisualCurveDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxVisualCurveDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_restingVisualLineLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.restingVisualLineLength = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineDynamicsMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineDynamicsMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lineDynamicsMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_retractDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.retractDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_retractDuration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.retractDuration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_extendLineToEmptyHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.extendLineToEmptyHit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_extensionRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.extensionRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endPointExpansionRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endPointExpansionRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_computeMidPointWithComplexCurves(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.computeMidPointWithComplexCurves = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapToSelectedAttachIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapToSelectedAttachIfAvailable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapToSnapVolumeIfAvailable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapToSnapVolumeIfAvailable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_curveStartOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.curveStartOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_curveEndOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.curveEndOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customizeLinePropertiesForState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.customizeLinePropertiesForState = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linePropertyAnimationSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.linePropertyAnimationSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_noValidHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.noValidHitProperties = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHitProperties = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiPressHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiPressHitProperties = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectHitProperties = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverHitProperties(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverHitProperties = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderLineInWorldSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.renderLineInWorldSpace = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swapMaterials(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.swapMaterials = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baseLineMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.baseLineMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_emptyHitMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.CurveVisualController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.emptyHitMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
