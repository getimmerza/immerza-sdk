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
    public class UnityEngineXRInteractionToolkitInteractorsVisualsXRInteractorReticleVisualWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 10, 10);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxRaycastDistance", _g_get_maxRaycastDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reticlePrefab", _g_get_reticlePrefab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "prefabScalingFactor", _g_get_prefabScalingFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "undoDistanceScaling", _g_get_undoDistanceScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignPrefabWithSurfaceNormal", _g_get_alignPrefabWithSurfaceNormal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endpointSmoothingTime", _g_get_endpointSmoothingTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawWhileSelecting", _g_get_drawWhileSelecting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawOnNoHit", _g_get_drawOnNoHit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastMask", _g_get_raycastMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reticleActive", _g_get_reticleActive);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxRaycastDistance", _s_set_maxRaycastDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reticlePrefab", _s_set_reticlePrefab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "prefabScalingFactor", _s_set_prefabScalingFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "undoDistanceScaling", _s_set_undoDistanceScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignPrefabWithSurfaceNormal", _s_set_alignPrefabWithSurfaceNormal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endpointSmoothingTime", _s_set_endpointSmoothingTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawWhileSelecting", _s_set_drawWhileSelecting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawOnNoHit", _s_set_drawOnNoHit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastMask", _s_set_raycastMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reticleActive", _s_set_reticleActive);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxRaycastDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxRaycastDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reticlePrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.reticlePrefab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_prefabScalingFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.prefabScalingFactor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_undoDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.undoDistanceScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alignPrefabWithSurfaceNormal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.alignPrefabWithSurfaceNormal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endpointSmoothingTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endpointSmoothingTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.drawWhileSelecting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawOnNoHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.drawOnNoHit);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reticleActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.reticleActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxRaycastDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxRaycastDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reticlePrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reticlePrefab = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_prefabScalingFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.prefabScalingFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_undoDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.undoDistanceScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alignPrefabWithSurfaceNormal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.alignPrefabWithSurfaceNormal = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endpointSmoothingTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endpointSmoothingTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drawWhileSelecting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawOnNoHit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drawOnNoHit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reticleActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorReticleVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reticleActive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
