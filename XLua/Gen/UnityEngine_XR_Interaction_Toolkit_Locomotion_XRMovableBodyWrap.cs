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
    public class UnityEngineXRInteractionToolkitLocomotionXRMovableBodyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBodyGroundLocalPosition", _m_GetBodyGroundLocalPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBodyGroundWorldPosition", _m_GetBodyGroundWorldPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LinkConstrainedManipulator", _m_LinkConstrainedManipulator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnlinkConstrainedManipulator", _m_UnlinkConstrainedManipulator);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "xrOrigin", _g_get_xrOrigin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "originTransform", _g_get_originTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bodyPositionEvaluator", _g_get_bodyPositionEvaluator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constrainedManipulator", _g_get_constrainedManipulator);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<Unity.XR.CoreUtils.XROrigin>(L, 2) && translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator>(L, 3))
				{
					Unity.XR.CoreUtils.XROrigin _xrOrigin = (Unity.XR.CoreUtils.XROrigin)translator.GetObject(L, 2, typeof(Unity.XR.CoreUtils.XROrigin));
					UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator _bodyPositionEvaluator = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IXRBodyPositionEvaluator));
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody(_xrOrigin, _bodyPositionEvaluator);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBodyGroundLocalPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetBodyGroundLocalPosition(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBodyGroundWorldPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetBodyGroundWorldPosition(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LinkConstrainedManipulator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.IConstrainedXRBodyManipulator _manipulator = (UnityEngine.XR.Interaction.Toolkit.Locomotion.IConstrainedXRBodyManipulator)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.IConstrainedXRBodyManipulator));
                    
                    gen_to_be_invoked.LinkConstrainedManipulator( _manipulator );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnlinkConstrainedManipulator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UnlinkConstrainedManipulator(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xrOrigin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xrOrigin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_originTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.originTransform);
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
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.bodyPositionEvaluator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constrainedManipulator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.constrainedManipulator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
