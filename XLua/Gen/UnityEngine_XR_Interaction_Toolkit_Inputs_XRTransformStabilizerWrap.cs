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
    public class UnityEngineXRInteractionToolkitInputsXRTransformStabilizerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 5, 5);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetTransform", _g_get_targetTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aimTarget", _g_get_aimTarget);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useLocalSpace", _g_get_useLocalSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angleStabilization", _g_get_angleStabilization);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "positionStabilization", _g_get_positionStabilization);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetTransform", _s_set_targetTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aimTarget", _s_set_aimTarget);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useLocalSpace", _s_set_useLocalSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angleStabilization", _s_set_angleStabilization);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "positionStabilization", _s_set_positionStabilization);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ApplyStabilization", _m_ApplyStabilization_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyStabilization_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 3);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 5);
                    bool _useLocalSpace = LuaAPI.lua_toboolean(L, 6);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _positionStabilization, _angleStabilization, _deltaTime, _useLocalSpace );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 3);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _positionStabilization, _angleStabilization, _deltaTime );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<Unity.Mathematics.float3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    Unity.Mathematics.float3 _targetEndpoint;translator.Get(L, 3, out _targetEndpoint);
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 5);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
                    bool _useLocalSpace = LuaAPI.lua_toboolean(L, 7);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _targetEndpoint, _positionStabilization, _angleStabilization, _deltaTime, _useLocalSpace );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    translator.Push(L, _targetEndpoint);
                        translator.Update(L, 3, _targetEndpoint);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<Unity.Mathematics.float3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    Unity.Mathematics.float3 _targetEndpoint;translator.Get(L, 3, out _targetEndpoint);
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 5);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _targetEndpoint, _positionStabilization, _angleStabilization, _deltaTime );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    translator.Push(L, _targetEndpoint);
                        translator.Update(L, 3, _targetEndpoint);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider _aimTarget = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider));
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 5);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
                    bool _useLocalSpace = LuaAPI.lua_toboolean(L, 7);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _aimTarget, _positionStabilization, _angleStabilization, _deltaTime, _useLocalSpace );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    translator.PushAny(L, _aimTarget);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 1)&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Transform _toStabilize = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform _target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider _aimTarget = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider));
                    float _positionStabilization = (float)LuaAPI.lua_tonumber(L, 4);
                    float _angleStabilization = (float)LuaAPI.lua_tonumber(L, 5);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization( ref _toStabilize, _target, _aimTarget, _positionStabilization, _angleStabilization, _deltaTime );
                    translator.Push(L, _toStabilize);
                        
                    translator.Push(L, _target);
                        
                    translator.PushAny(L, _aimTarget);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aimTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.aimTarget);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useLocalSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useLocalSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angleStabilization(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angleStabilization);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_positionStabilization(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.positionStabilization);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aimTarget(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aimTarget = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRRayProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useLocalSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useLocalSpace = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angleStabilization(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angleStabilization = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_positionStabilization(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.positionStabilization = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
