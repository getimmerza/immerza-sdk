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
    public class UnityEngineXRInteractionToolkitInteractablesVisualsXRTintInteractableVisualWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "tintColor", _g_get_tintColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tintOnHover", _g_get_tintOnHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tintOnSelection", _g_get_tintOnSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tintRenderers", _g_get_tintRenderers);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "tintColor", _s_set_tintColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tintOnHover", _s_set_tintOnHover);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tintOnSelection", _s_set_tintOnSelection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tintRenderers", _s_set_tintRenderers);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tintColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.tintColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tintOnHover(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.tintOnHover);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tintOnSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.tintOnSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tintRenderers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.tintRenderers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tintColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.tintColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tintOnHover(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tintOnHover = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tintOnSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tintOnSelection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tintRenderers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tintRenderers = (System.Collections.Generic.List<UnityEngine.Renderer>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Renderer>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
