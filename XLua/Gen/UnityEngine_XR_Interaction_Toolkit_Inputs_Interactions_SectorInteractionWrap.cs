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
    public class UnityEngineXRInteractionToolkitInputsInteractionsSectorInteractionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "directions", _g_get_directions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sweepBehavior", _g_get_sweepBehavior);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressPoint", _g_get_pressPoint);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "directions", _s_set_directions);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sweepBehavior", _s_set_sweepBehavior);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressPoint", _s_set_pressPoint);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultPressPoint", _g_get_defaultPressPoint);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultPressPoint", _s_set_defaultPressPoint);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputInteractionContext _context;translator.Get(L, 2, out _context);
                    
                    gen_to_be_invoked.Process( ref _context );
                    translator.Push(L, _context);
                        translator.Update(L, 2, _context);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultPressPoint(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction.defaultPressPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sweepBehavior(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sweepBehavior);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pressPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultPressPoint(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction.defaultPressPoint = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction.Directions gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directions = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sweepBehavior(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction.SweepBehavior gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sweepBehavior = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pressPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions.SectorInteraction)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pressPoint = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
