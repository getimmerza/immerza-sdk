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
    public class UnityEngineXRInteractionToolkitAttachmentInteractionAttachControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 15, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetOffset", _m_ResetOffset);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "attachUpdated", _e_attachUpdated);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "transformToFollow", _g_get_transformToFollow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motionStabilizationMode", _g_get_motionStabilizationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "positionStabilization", _g_get_positionStabilization);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angleStabilization", _g_get_angleStabilization);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothOffset", _g_get_smoothOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothingSpeed", _g_get_smoothingSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDistanceBasedVelocityScaling", _g_get_useDistanceBasedVelocityScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useMomentum", _g_get_useMomentum);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "momentumDecayScale", _g_get_momentumDecayScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "zVelocityRampThreshold", _g_get_zVelocityRampThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pullVelocityBias", _g_get_pullVelocityBias);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pushVelocityBias", _g_get_pushVelocityBias);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minAdditionalVelocityScalar", _g_get_minAdditionalVelocityScalar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxAdditionalVelocityScalar", _g_get_maxAdditionalVelocityScalar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasOffset", _g_get_hasOffset);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "transformToFollow", _s_set_transformToFollow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motionStabilizationMode", _s_set_motionStabilizationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "positionStabilization", _s_set_positionStabilization);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angleStabilization", _s_set_angleStabilization);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothOffset", _s_set_smoothOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothingSpeed", _s_set_smoothingSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDistanceBasedVelocityScaling", _s_set_useDistanceBasedVelocityScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useMomentum", _s_set_useMomentum);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "momentumDecayScale", _s_set_momentumDecayScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "zVelocityRampThreshold", _s_set_zVelocityRampThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pullVelocityBias", _s_set_pullVelocityBias);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pushVelocityBias", _s_set_pushVelocityBias);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minAdditionalVelocityScalar", _s_set_minAdditionalVelocityScalar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxAdditionalVelocityScalar", _s_set_maxAdditionalVelocityScalar);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetOffset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetOffset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transformToFollow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transformToFollow);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motionStabilizationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.motionStabilizationMode);
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
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.positionStabilization);
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
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angleStabilization);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothingSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothingSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useDistanceBasedVelocityScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useDistanceBasedVelocityScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useMomentum(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useMomentum);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_momentumDecayScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.momentumDecayScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_zVelocityRampThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.zVelocityRampThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pullVelocityBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pullVelocityBias);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pushVelocityBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pushVelocityBias);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minAdditionalVelocityScalar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minAdditionalVelocityScalar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxAdditionalVelocityScalar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxAdditionalVelocityScalar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transformToFollow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transformToFollow = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motionStabilizationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Attachment.MotionStabilizationMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.motionStabilizationMode = gen_value;
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.positionStabilization = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angleStabilization = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothOffset = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothingSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothingSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useDistanceBasedVelocityScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useDistanceBasedVelocityScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useMomentum(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useMomentum = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_momentumDecayScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.momentumDecayScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_zVelocityRampThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.zVelocityRampThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pullVelocityBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pullVelocityBias = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pushVelocityBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pushVelocityBias = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minAdditionalVelocityScalar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minAdditionalVelocityScalar = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxAdditionalVelocityScalar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxAdditionalVelocityScalar = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_attachUpdated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController)translator.FastGetCSObj(L, 1);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.attachUpdated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.attachUpdated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Attachment.InteractionAttachController.attachUpdated!");
            return 0;
        }
        
		
		
    }
}
