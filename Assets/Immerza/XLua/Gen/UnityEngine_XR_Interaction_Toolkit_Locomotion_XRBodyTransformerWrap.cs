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
    public class UnityEngineXRInteractionToolkitLocomotionXRBodyTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueTransformation", _m_QueueTransformation);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "beforeApplyTransformations", _e_beforeApplyTransformations);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "xrOrigin", _g_get_xrOrigin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bodyPositionEvaluator", _g_get_bodyPositionEvaluator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constrainedBodyManipulator", _g_get_constrainedBodyManipulator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useCharacterControllerIfExists", _g_get_useCharacterControllerIfExists);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "xrOrigin", _s_set_xrOrigin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bodyPositionEvaluator", _s_set_bodyPositionEvaluator);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constrainedBodyManipulator", _s_set_constrainedBodyManipulator);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useCharacterControllerIfExists", _s_set_useCharacterControllerIfExists);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueTransformation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation _transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation));
                    int _priority = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.QueueTransformation( _transformation, _priority );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation>(L, 2)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation _transformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyTransformation));
                    
                    gen_to_be_invoked.QueueTransformation( _transformation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer.QueueTransformation!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xrOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xrOrigin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bodyPositionEvaluator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.bodyPositionEvaluator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constrainedBodyManipulator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.constrainedBodyManipulator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useCharacterControllerIfExists(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useCharacterControllerIfExists);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xrOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.xrOrigin = (Unity.XR.CoreUtils.XROrigin)translator.GetObject(L, 2, typeof(Unity.XR.CoreUtils.XROrigin));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bodyPositionEvaluator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bodyPositionEvaluator = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_constrainedBodyManipulator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.constrainedBodyManipulator = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IConstrainedXRBodyManipulator)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IConstrainedXRBodyManipulator));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useCharacterControllerIfExists(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useCharacterControllerIfExists = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_beforeApplyTransformations(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.beforeApplyTransformations += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.beforeApplyTransformations -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer.beforeApplyTransformations!");
            return 0;
        }
        
		
		
    }
}
