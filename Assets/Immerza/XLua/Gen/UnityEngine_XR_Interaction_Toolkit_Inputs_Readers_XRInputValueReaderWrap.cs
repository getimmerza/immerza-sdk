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
    public class UnityEngineXRInteractionToolkitInputsReadersXRInputValueReaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableDirectActionIfModeUsed", _m_EnableDirectActionIfModeUsed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableDirectActionIfModeUsed", _m_DisableDirectActionIfModeUsed);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputSourceMode", _g_get_inputSourceMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputAction", _g_get_inputAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionReference", _g_get_inputActionReference);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputSourceMode", _s_set_inputSourceMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputAction", _s_set_inputAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionReference", _s_set_inputActionReference);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableDirectActionIfModeUsed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EnableDirectActionIfModeUsed(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableDirectActionIfModeUsed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DisableDirectActionIfModeUsed(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputSourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputSourceMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputActionReference);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputSourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader.InputSourceMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inputSourceMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputAction = (UnityEngine.InputSystem.InputAction)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputAction));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputActionReference = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
