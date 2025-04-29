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
    public class UnityEngineXRInteractionToolkitInputsCompositesButtonFallbackCompositeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadValue", _m_ReadValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EvaluateMagnitude", _m_EvaluateMagnitude);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "first", _g_get_first);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "second", _g_get_second);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "third", _g_get_third);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "first", _s_set_first);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "second", _s_set_second);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "third", _s_set_third);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputBindingCompositeContext _context;translator.Get(L, 2, out _context);
                    
                        var gen_ret = gen_to_be_invoked.ReadValue( ref _context );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    translator.Push(L, _context);
                        translator.Update(L, 2, _context);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EvaluateMagnitude(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.InputSystem.InputBindingCompositeContext _context;translator.Get(L, 2, out _context);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateMagnitude( ref _context );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    translator.Push(L, _context);
                        translator.Update(L, 2, _context);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_first(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.first);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_second(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.second);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_third(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.third);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_first(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.first = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_second(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.second = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_third(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Composites.ButtonFallbackComposite)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.third = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
