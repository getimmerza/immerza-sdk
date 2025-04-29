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
    public class UnityEngineXRInteractionToolkitLocomotionTeleportationTeleportationProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "QueueTeleportRequest", _m_QueueTeleportRequest);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "delayTime", _g_get_delayTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canStartMoving", _g_get_canStartMoving);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "upTransformation", _g_get_upTransformation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forwardTransformation", _g_get_forwardTransformation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "positionTransformation", _g_get_positionTransformation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "delayTime", _s_set_delayTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "upTransformation", _s_set_upTransformation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forwardTransformation", _s_set_forwardTransformation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "positionTransformation", _s_set_positionTransformation);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QueueTeleportRequest(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportRequest _teleportRequest;translator.Get(L, 2, out _teleportRequest);
                    
                        var gen_ret = gen_to_be_invoked.QueueTeleportRequest( _teleportRequest );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_delayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.delayTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canStartMoving(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canStartMoving);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_upTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.upTransformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forwardTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.forwardTransformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_positionTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.positionTransformation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_delayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.delayTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_upTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.upTransformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginUpAlignment)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XROriginUpAlignment));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forwardTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.forwardTransformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRCameraForwardXZAlignment)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRCameraForwardXZAlignment));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_positionTransformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.positionTransformation = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyGroundPosition)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyGroundPosition));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
