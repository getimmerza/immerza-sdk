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
    public class UnityXRCoreUtilsXROriginWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Unity.XR.CoreUtils.XROrigin);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 10, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RotateAroundCameraUsingOriginUp", _m_RotateAroundCameraUsingOriginUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RotateAroundCameraPosition", _m_RotateAroundCameraPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MatchOriginUp", _m_MatchOriginUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MatchOriginUpCameraForward", _m_MatchOriginUpCameraForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MatchOriginUpOriginForward", _m_MatchOriginUpOriginForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveCameraToWorldLocation", _m_MoveCameraToWorldLocation);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TrackablesParentTransformChanged", _e_TrackablesParentTransformChanged);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Camera", _g_get_Camera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TrackablesParent", _g_get_TrackablesParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Origin", _g_get_Origin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraFloorOffsetObject", _g_get_CameraFloorOffsetObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RequestedTrackingOriginMode", _g_get_RequestedTrackingOriginMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraYOffset", _g_get_CameraYOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CurrentTrackingOriginMode", _g_get_CurrentTrackingOriginMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OriginInCameraSpacePos", _g_get_OriginInCameraSpacePos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraInOriginSpacePos", _g_get_CameraInOriginSpacePos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraInOriginSpaceHeight", _g_get_CameraInOriginSpaceHeight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Camera", _s_set_Camera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Origin", _s_set_Origin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CameraFloorOffsetObject", _s_set_CameraFloorOffsetObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RequestedTrackingOriginMode", _s_set_RequestedTrackingOriginMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CameraYOffset", _s_set_CameraYOffset);
            
			
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
					
					var gen_ret = new Unity.XR.CoreUtils.XROrigin();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Unity.XR.CoreUtils.XROrigin constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RotateAroundCameraUsingOriginUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _angleDegrees = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.RotateAroundCameraUsingOriginUp( _angleDegrees );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RotateAroundCameraPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _vector;translator.Get(L, 2, out _vector);
                    float _angleDegrees = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.RotateAroundCameraPosition( _vector, _angleDegrees );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MatchOriginUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _destinationUp;translator.Get(L, 2, out _destinationUp);
                    
                        var gen_ret = gen_to_be_invoked.MatchOriginUp( _destinationUp );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MatchOriginUpCameraForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _destinationUp;translator.Get(L, 2, out _destinationUp);
                    UnityEngine.Vector3 _destinationForward;translator.Get(L, 3, out _destinationForward);
                    
                        var gen_ret = gen_to_be_invoked.MatchOriginUpCameraForward( _destinationUp, _destinationForward );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MatchOriginUpOriginForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _destinationUp;translator.Get(L, 2, out _destinationUp);
                    UnityEngine.Vector3 _destinationForward;translator.Get(L, 3, out _destinationForward);
                    
                        var gen_ret = gen_to_be_invoked.MatchOriginUpOriginForward( _destinationUp, _destinationForward );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveCameraToWorldLocation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _desiredWorldLocation;translator.Get(L, 2, out _desiredWorldLocation);
                    
                        var gen_ret = gen_to_be_invoked.MoveCameraToWorldLocation( _desiredWorldLocation );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Camera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Camera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TrackablesParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TrackablesParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Origin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Origin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraFloorOffsetObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CameraFloorOffsetObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RequestedTrackingOriginMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.RequestedTrackingOriginMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraYOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.CameraYOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CurrentTrackingOriginMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CurrentTrackingOriginMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OriginInCameraSpacePos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.OriginInCameraSpacePos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraInOriginSpacePos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.CameraInOriginSpacePos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraInOriginSpaceHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.CameraInOriginSpaceHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Camera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Camera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Origin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Origin = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CameraFloorOffsetObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CameraFloorOffsetObject = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RequestedTrackingOriginMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                Unity.XR.CoreUtils.XROrigin.TrackingOriginMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.RequestedTrackingOriginMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CameraYOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CameraYOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TrackablesParentTransformChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Unity.XR.CoreUtils.XROrigin gen_to_be_invoked = (Unity.XR.CoreUtils.XROrigin)translator.FastGetCSObj(L, 1);
                System.Action<Unity.XR.CoreUtils.ARTrackablesParentTransformChangedEventArgs> gen_delegate = translator.GetDelegate<System.Action<Unity.XR.CoreUtils.ARTrackablesParentTransformChangedEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<Unity.XR.CoreUtils.ARTrackablesParentTransformChangedEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TrackablesParentTransformChanged += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TrackablesParentTransformChanged -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Unity.XR.CoreUtils.XROrigin.TrackablesParentTransformChanged!");
            return 0;
        }
        
		
		
    }
}
