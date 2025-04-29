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
    public class UnityEngineXRInteractionToolkitGazeXRGazeAssistanceWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 8, 8);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssistedVelocity", _m_GetAssistedVelocity);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeInteractor", _g_get_gazeInteractor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fallbackDivergence", _g_get_fallbackDivergence);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideCursorWithNoActiveRays", _g_get_hideCursorWithNoActiveRays);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rayInteractors", _g_get_rayInteractors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aimAssistRequiredAngle", _g_get_aimAssistRequiredAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aimAssistRequiredSpeed", _g_get_aimAssistRequiredSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aimAssistPercent", _g_get_aimAssistPercent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aimAssistMaxSpeedPercent", _g_get_aimAssistMaxSpeedPercent);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeInteractor", _s_set_gazeInteractor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fallbackDivergence", _s_set_fallbackDivergence);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideCursorWithNoActiveRays", _s_set_hideCursorWithNoActiveRays);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rayInteractors", _s_set_rayInteractors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aimAssistRequiredAngle", _s_set_aimAssistRequiredAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aimAssistRequiredSpeed", _s_set_aimAssistRequiredSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aimAssistPercent", _s_set_aimAssistPercent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aimAssistMaxSpeedPercent", _s_set_aimAssistMaxSpeedPercent);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssistedVelocity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 _source;translator.Get(L, 2, out _source);
                    UnityEngine.Vector3 _velocity;translator.Get(L, 3, out _velocity);
                    float _gravity = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.GetAssistedVelocity( _source, _velocity, _gravity );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _source);
                        translator.UpdateUnityEngineVector3(L, 2, _source);
                        
                    translator.PushUnityEngineVector3(L, _velocity);
                        translator.UpdateUnityEngineVector3(L, 3, _velocity);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 _source;translator.Get(L, 2, out _source);
                    UnityEngine.Vector3 _velocity;translator.Get(L, 3, out _velocity);
                    float _gravity = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxAngle = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.GetAssistedVelocity( _source, _velocity, _gravity, _maxAngle );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _source);
                        translator.UpdateUnityEngineVector3(L, 2, _source);
                        
                    translator.PushUnityEngineVector3(L, _velocity);
                        translator.UpdateUnityEngineVector3(L, 3, _velocity);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance.GetAssistedVelocity!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gazeInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fallbackDivergence(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fallbackDivergence);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideCursorWithNoActiveRays(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hideCursorWithNoActiveRays);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rayInteractors(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rayInteractors);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aimAssistRequiredAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aimAssistRequiredAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aimAssistRequiredSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aimAssistRequiredSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aimAssistPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aimAssistPercent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aimAssistMaxSpeedPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aimAssistMaxSpeedPercent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeInteractor = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fallbackDivergence(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fallbackDivergence = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hideCursorWithNoActiveRays(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hideCursorWithNoActiveRays = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rayInteractors(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rayInteractors = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance.InteractorData>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance.InteractorData>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aimAssistRequiredAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aimAssistRequiredAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aimAssistRequiredSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aimAssistRequiredSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aimAssistPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aimAssistPercent = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aimAssistMaxSpeedPercent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aimAssistMaxSpeedPercent = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
