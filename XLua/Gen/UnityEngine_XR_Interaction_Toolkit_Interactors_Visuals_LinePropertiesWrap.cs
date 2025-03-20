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
    public class UnityEngineXRInteractionToolkitInteractorsVisualsLinePropertiesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 10, 10);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothlyCurveLine", _g_get_smoothlyCurveLine);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineBendRatio", _g_get_lineBendRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "adjustWidth", _g_get_adjustWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "starWidth", _g_get_starWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endWidth", _g_get_endWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endWidthScaleDistanceFactor", _g_get_endWidthScaleDistanceFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "adjustGradient", _g_get_adjustGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gradient", _g_get_gradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customizeExpandLineDrawPercent", _g_get_customizeExpandLineDrawPercent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "expandModeLineDrawPercent", _g_get_expandModeLineDrawPercent);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothlyCurveLine", _s_set_smoothlyCurveLine);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineBendRatio", _s_set_lineBendRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "adjustWidth", _s_set_adjustWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "starWidth", _s_set_starWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endWidth", _s_set_endWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endWidthScaleDistanceFactor", _s_set_endWidthScaleDistanceFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "adjustGradient", _s_set_adjustGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gradient", _s_set_gradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customizeExpandLineDrawPercent", _s_set_customizeExpandLineDrawPercent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "expandModeLineDrawPercent", _s_set_expandModeLineDrawPercent);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothlyCurveLine(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothlyCurveLine);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lineBendRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_adjustWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.adjustWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_starWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.starWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endWidthScaleDistanceFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endWidthScaleDistanceFactor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_adjustGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.adjustGradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gradient);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customizeExpandLineDrawPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.customizeExpandLineDrawPercent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_expandModeLineDrawPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.expandModeLineDrawPercent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothlyCurveLine(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothlyCurveLine = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lineBendRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_adjustWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.adjustWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_starWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.starWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endWidthScaleDistanceFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endWidthScaleDistanceFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_adjustGradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.adjustGradient = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradient(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gradient = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customizeExpandLineDrawPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.customizeExpandLineDrawPercent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_expandModeLineDrawPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.LineProperties)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.expandModeLineDrawPercent = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
