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
    public class UnityEngineXRInteractionToolkitFeedbackSimpleAudioFeedbackWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 14, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractorSource", _m_GetInteractorSource);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInteractorSource", _m_SetInteractorSource);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "audioSource", _g_get_audioSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectEntered", _g_get_playSelectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEnteredClip", _g_get_selectEnteredClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectExited", _g_get_playSelectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExitedClip", _g_get_selectExitedClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playSelectCanceled", _g_get_playSelectCanceled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectCanceledClip", _g_get_selectCanceledClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverEntered", _g_get_playHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEnteredClip", _g_get_hoverEnteredClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverExited", _g_get_playHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExitedClip", _g_get_hoverExitedClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playHoverCanceled", _g_get_playHoverCanceled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverCanceledClip", _g_get_hoverCanceledClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowHoverAudioWhileSelecting", _g_get_allowHoverAudioWhileSelecting);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "audioSource", _s_set_audioSource);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectEntered", _s_set_playSelectEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectEnteredClip", _s_set_selectEnteredClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectExited", _s_set_playSelectExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectExitedClip", _s_set_selectExitedClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playSelectCanceled", _s_set_playSelectCanceled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectCanceledClip", _s_set_selectCanceledClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverEntered", _s_set_playHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverEnteredClip", _s_set_hoverEnteredClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverExited", _s_set_playHoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverExitedClip", _s_set_hoverExitedClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playHoverCanceled", _s_set_playHoverCanceled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverCanceledClip", _s_set_hoverCanceledClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowHoverAudioWhileSelecting", _s_set_allowHoverAudioWhileSelecting);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractorSource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_audioSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.audioSource);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectEnteredClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectEnteredClip);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectExitedClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExitedClip);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playSelectCanceled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectCanceledClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectCanceledClip);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverEnteredClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverEnteredClip);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverExitedClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExitedClip);
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playHoverCanceled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverCanceledClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverCanceledClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowHoverAudioWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowHoverAudioWhileSelecting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_audioSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.audioSource = (UnityEngine.AudioSource)translator.GetObject(L, 2, typeof(UnityEngine.AudioSource));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectEntered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectEnteredClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectEnteredClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectExited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectExitedClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectExitedClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playSelectCanceled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectCanceledClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectCanceledClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverEntered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverEnteredClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverEnteredClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverExited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverExitedClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverExitedClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playHoverCanceled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverCanceledClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverCanceledClip = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowHoverAudioWhileSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Feedback.SimpleAudioFeedback)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowHoverAudioWhileSelecting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
