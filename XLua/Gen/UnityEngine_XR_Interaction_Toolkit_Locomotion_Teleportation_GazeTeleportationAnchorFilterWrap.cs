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
    public class UnityEngineXRInteractionToolkitLocomotionTeleportationGazeTeleportationAnchorFilterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDestinationAnchorIndex", _m_GetDestinationAnchorIndex);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxGazeAngle", _g_get_maxGazeAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAngleScoreCurve", _g_get_gazeAngleScoreCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableDistanceWeighting", _g_get_enableDistanceWeighting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "distanceWeightCurve", _g_get_distanceWeightCurve);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxGazeAngle", _s_set_maxGazeAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAngleScoreCurve", _s_set_gazeAngleScoreCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableDistanceWeighting", _s_set_enableDistanceWeighting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "distanceWeightCurve", _s_set_distanceWeightCurve);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDestinationAnchorIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume _teleportationVolume = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume));
                    
                        var gen_ret = gen_to_be_invoked.GetDestinationAnchorIndex( _teleportationVolume );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxGazeAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxGazeAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAngleScoreCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gazeAngleScoreCurve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableDistanceWeighting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableDistanceWeighting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_distanceWeightCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.distanceWeightCurve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxGazeAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxGazeAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAngleScoreCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAngleScoreCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableDistanceWeighting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableDistanceWeighting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_distanceWeightCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.GazeTeleportationAnchorFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.distanceWeightCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
