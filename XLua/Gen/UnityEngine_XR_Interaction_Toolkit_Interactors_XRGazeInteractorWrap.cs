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
    public class UnityEngineXRInteractionToolkitInteractorsXRGazeInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceCalculation", _g_get_gazeAssistanceCalculation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceColliderFixedSize", _g_get_gazeAssistanceColliderFixedSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceColliderScale", _g_get_gazeAssistanceColliderScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceSnapVolume", _g_get_gazeAssistanceSnapVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceDistanceScaling", _g_get_gazeAssistanceDistanceScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clampGazeAssistanceDistanceScaling", _g_get_clampGazeAssistanceDistanceScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeAssistanceDistanceScalingClampValue", _g_get_gazeAssistanceDistanceScalingClampValue);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceCalculation", _s_set_gazeAssistanceCalculation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceColliderFixedSize", _s_set_gazeAssistanceColliderFixedSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceColliderScale", _s_set_gazeAssistanceColliderScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceSnapVolume", _s_set_gazeAssistanceSnapVolume);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceDistanceScaling", _s_set_gazeAssistanceDistanceScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clampGazeAssistanceDistanceScaling", _s_set_clampGazeAssistanceDistanceScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeAssistanceDistanceScalingClampValue", _s_set_gazeAssistanceDistanceScalingClampValue);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_gazeAssistanceCalculation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gazeAssistanceCalculation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAssistanceColliderFixedSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gazeAssistanceColliderFixedSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAssistanceColliderScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gazeAssistanceColliderScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAssistanceSnapVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gazeAssistanceSnapVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAssistanceDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.gazeAssistanceDistanceScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clampGazeAssistanceDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.clampGazeAssistanceDistanceScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeAssistanceDistanceScalingClampValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gazeAssistanceDistanceScalingClampValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceCalculation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor.GazeAssistanceCalculation gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.gazeAssistanceCalculation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceColliderFixedSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAssistanceColliderFixedSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceColliderScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAssistanceColliderScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceSnapVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAssistanceSnapVolume = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAssistanceDistanceScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clampGazeAssistanceDistanceScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.clampGazeAssistanceDistanceScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeAssistanceDistanceScalingClampValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeAssistanceDistanceScalingClampValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
