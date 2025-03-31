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
    public class UnityEngineXRInteractionToolkitFilteringTouchscreenHoverFilterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "screenTouchCountInput", _g_get_screenTouchCountInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canProcess", _g_get_canProcess);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "screenTouchCountInput", _s_set_screenTouchCountInput);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = gen_to_be_invoked.Process( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_screenTouchCountInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.screenTouchCountInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canProcess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canProcess);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_screenTouchCountInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Filtering.TouchscreenHoverFilter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.screenTouchCountInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<int>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<int>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
