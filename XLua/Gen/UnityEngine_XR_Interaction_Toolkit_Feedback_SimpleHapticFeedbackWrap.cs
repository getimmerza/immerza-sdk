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
    public class UnityEngineXRInteractionToolkitFeedbackSimpleHapticFeedbackWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 14, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractorSource", _m_GetInteractorSource);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInteractorSource", _m_SetInteractorSource);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hapticImpulsePlayer", _g_get_hapticImpulsePlayer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectEntered", _g_get_playSelectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEnteredData", _g_get_selectEnteredData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectExited", _g_get_playSelectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExitedData", _g_get_selectExitedData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectCanceled", _g_get_playSelectCanceled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectCanceledData", _g_get_selectCanceledData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverEntered", _g_get_playHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEnteredData", _g_get_hoverEnteredData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverExited", _g_get_playHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExitedData", _g_get_hoverExitedData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverCanceled", _g_get_playHoverCanceled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverCanceledData", _g_get_hoverCanceledData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowHoverHapticsWhileSelecting", _g_get_allowHoverHapticsWhileSelecting);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "hapticImpulsePlayer", _s_set_hapticImpulsePlayer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectEntered", _s_set_playSelectEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectEnteredData", _s_set_selectEnteredData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectExited", _s_set_playSelectExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectExitedData", _s_set_selectExitedData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectCanceled", _s_set_playSelectCanceled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectCanceledData", _s_set_selectCanceledData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverEntered", _s_set_playHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverEnteredData", _s_set_hoverEnteredData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverExited", _s_set_playHoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverExitedData", _s_set_hoverExitedData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverCanceled", _s_set_playHoverCanceled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverCanceledData", _s_set_hoverCanceledData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowHoverHapticsWhileSelecting", _s_set_allowHoverHapticsWhileSelecting);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractorSource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetInteractorSource(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInteractorSource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                    gen_to_be_invoked.SetInteractorSource( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hapticImpulsePlayer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hapticImpulsePlayer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playSelectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectEnteredData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectEnteredData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playSelectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectExitedData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExitedData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playSelectCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectCanceled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectCanceledData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectCanceledData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverEnteredData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverEnteredData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverExitedData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExitedData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playHoverCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverCanceled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverCanceledData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverCanceledData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowHoverHapticsWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowHoverHapticsWhileSelecting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hapticImpulsePlayer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hapticImpulsePlayer = (UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulsePlayer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulsePlayer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playSelectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectEntered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectEnteredData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectEnteredData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playSelectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectExited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectExitedData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectExitedData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playSelectCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectCanceled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectCanceledData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectCanceledData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverEntered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverEnteredData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverEnteredData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverExited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverExitedData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverExitedData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playHoverCanceled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverCanceled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverCanceledData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverCanceledData = (UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.HapticImpulseData));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowHoverHapticsWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleHapticFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowHoverHapticsWhileSelecting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
