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
    public class UnityEngineXRInteractionToolkitLocomotionComfortTunnelingVignetteControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 3, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginTunnelingVignette", _m_BeginTunnelingVignette);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndTunnelingVignette", _m_EndTunnelingVignette);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultParameters", _g_get_defaultParameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentParameters", _g_get_currentParameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "locomotionVignetteProviders", _g_get_locomotionVignetteProviders);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultParameters", _s_set_defaultParameters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "locomotionVignetteProviders", _s_set_locomotionVignetteProviders);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginTunnelingVignette(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider _provider = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider));
                    
                    gen_to_be_invoked.BeginTunnelingVignette( _provider );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndTunnelingVignette(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider _provider = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.ITunnelingVignetteProvider));
                    
                    gen_to_be_invoked.EndTunnelingVignette( _provider );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.currentParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_locomotionVignetteProviders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.locomotionVignetteProviders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultParameters = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.VignetteParameters)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.VignetteParameters));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_locomotionVignetteProviders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.locomotionVignetteProviders = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.LocomotionVignetteProvider>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
