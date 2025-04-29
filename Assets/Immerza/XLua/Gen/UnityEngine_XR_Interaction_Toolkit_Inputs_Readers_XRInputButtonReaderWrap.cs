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
    public class UnityEngineXRInteractionToolkitInputsReadersXRInputButtonReaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 10, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableDirectActionIfModeUsed", _m_EnableDirectActionIfModeUsed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableDirectActionIfModeUsed", _m_DisableDirectActionIfModeUsed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectReference", _m_GetObjectReference);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetObjectReference", _m_SetObjectReference);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueManualState", _m_QueueManualState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadIsPerformed", _m_ReadIsPerformed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadWasPerformedThisFrame", _m_ReadWasPerformedThisFrame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadWasCompletedThisFrame", _m_ReadWasCompletedThisFrame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadValue", _m_ReadValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryReadValue", _m_TryReadValue);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputSourceMode", _g_get_inputSourceMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionPerformed", _g_get_inputActionPerformed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionValue", _g_get_inputActionValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionReferencePerformed", _g_get_inputActionReferencePerformed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionReferenceValue", _g_get_inputActionReferenceValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualPerformed", _g_get_manualPerformed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualValue", _g_get_manualValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualFramePerformed", _g_get_manualFramePerformed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manualFrameCompleted", _g_get_manualFrameCompleted);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bypass", _g_get_bypass);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputSourceMode", _s_set_inputSourceMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionPerformed", _s_set_inputActionPerformed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionValue", _s_set_inputActionValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionReferencePerformed", _s_set_inputActionReferencePerformed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionReferenceValue", _s_set_inputActionReferenceValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualPerformed", _s_set_manualPerformed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualValue", _s_set_manualValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualFramePerformed", _s_set_manualFramePerformed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manualFrameCompleted", _s_set_manualFrameCompleted);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bypass", _s_set_bypass);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader.InputSourceMode>(L, 5))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					string _valueName = LuaAPI.lua_tostring(L, 3);
					bool _wantsInitialStateCheck = LuaAPI.lua_toboolean(L, 4);
					UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader.InputSourceMode _inputSourceMode;translator.Get(L, 5, out _inputSourceMode);
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader(_name, _valueName, _wantsInitialStateCheck, _inputSourceMode);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					string _valueName = LuaAPI.lua_tostring(L, 3);
					bool _wantsInitialStateCheck = LuaAPI.lua_toboolean(L, 4);
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader(_name, _valueName, _wantsInitialStateCheck);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					string _valueName = LuaAPI.lua_tostring(L, 3);
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader(_name, _valueName);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader(_name);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableDirectActionIfModeUsed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DisableDirectActionIfModeUsed(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectReference(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetObjectReference(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetObjectReference(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.IXRInputButtonReader _value = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.IXRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.IXRInputButtonReader));
                    
                    gen_to_be_invoked.SetObjectReference( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueManualState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    bool _performed = LuaAPI.lua_toboolean(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.QueueManualState( _performed, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    bool _performed = LuaAPI.lua_toboolean(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    bool _performedThisFrame = LuaAPI.lua_toboolean(L, 4);
                    bool _completedThisFrame = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.QueueManualState( _performed, _value, _performedThisFrame, _completedThisFrame );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader.QueueManualState!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadIsPerformed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ReadIsPerformed(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadWasPerformedThisFrame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ReadWasPerformedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadWasCompletedThisFrame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ReadWasCompletedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ReadValue(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryReadValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _value;
                    
                        var gen_ret = gen_to_be_invoked.TryReadValue( out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _value);
                        
                    
                    
                    
                    return 2;
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
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputSourceMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionPerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputActionPerformed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputActionValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionReferencePerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputActionReferencePerformed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionReferenceValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.inputActionReferenceValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualPerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manualPerformed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.manualValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualFramePerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.manualFramePerformed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manualFrameCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.manualFrameCompleted);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bypass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.bypass);
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
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader.InputSourceMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inputSourceMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionPerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputActionPerformed = (UnityEngine.InputSystem.InputAction)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputAction));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputActionValue = (UnityEngine.InputSystem.InputAction)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputAction));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionReferencePerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputActionReferencePerformed = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionReferenceValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inputActionReferenceValue = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualPerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manualPerformed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manualValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualFramePerformed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manualFramePerformed = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manualFrameCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manualFrameCompleted = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bypass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bypass = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.IXRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.IXRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
