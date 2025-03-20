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
    public class UnityEngineXRInteractionToolkitTransformersARTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 12, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrab", _m_OnGrab);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrabCountChanged", _m_OnGrabCountChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrop", _m_OnDrop);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "objectPlaneTranslationMode", _g_get_objectPlaneTranslationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enablePlaneClassificationFilter", _g_get_enablePlaneClassificationFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "planeClassificationsList", _g_get_planeClassificationsList);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "planeClassifications", _g_get_planeClassifications);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useInteractorOrientation", _g_get_useInteractorOrientation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minScale", _g_get_minScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxScale", _g_get_maxScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleSensitivity", _g_get_scaleSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "elasticity", _g_get_elasticity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableElasticBreakLimit", _g_get_enableElasticBreakLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "elasticBreakLimit", _g_get_elasticBreakLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canProcessOnDrop", _g_get_canProcessOnDrop);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "objectPlaneTranslationMode", _s_set_objectPlaneTranslationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enablePlaneClassificationFilter", _s_set_enablePlaneClassificationFilter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "planeClassificationsList", _s_set_planeClassificationsList);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "planeClassifications", _s_set_planeClassifications);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useInteractorOrientation", _s_set_useInteractorOrientation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minScale", _s_set_minScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxScale", _s_set_maxScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleSensitivity", _s_set_scaleSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "elasticity", _s_set_elasticity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableElasticBreakLimit", _s_set_enableElasticBreakLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "elasticBreakLimit", _s_set_elasticBreakLimit);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 3, out _updatePhase);
                    UnityEngine.Pose _targetPose;translator.Get(L, 4, out _targetPose);
                    UnityEngine.Vector3 _localScale;translator.Get(L, 5, out _localScale);
                    
                    gen_to_be_invoked.Process( _grabInteractable, _updatePhase, ref _targetPose, ref _localScale );
                    translator.Push(L, _targetPose);
                        translator.Update(L, 4, _targetPose);
                        
                    translator.PushUnityEngineVector3(L, _localScale);
                        translator.UpdateUnityEngineVector3(L, 5, _localScale);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnGrab(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    
                    gen_to_be_invoked.OnGrab( _grabInteractable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnGrabCountChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    UnityEngine.Pose _targetPose;translator.Get(L, 3, out _targetPose);
                    UnityEngine.Vector3 _localScale;translator.Get(L, 4, out _localScale);
                    
                    gen_to_be_invoked.OnGrabCountChanged( _grabInteractable, _targetPose, _localScale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDrop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    UnityEngine.XR.Interaction.Toolkit.Transformers.DropEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.Transformers.DropEventArgs)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.DropEventArgs));
                    
                    gen_to_be_invoked.OnDrop( _grabInteractable, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_objectPlaneTranslationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.objectPlaneTranslationMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enablePlaneClassificationFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enablePlaneClassificationFilter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_planeClassificationsList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.planeClassificationsList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_planeClassifications(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.planeClassifications);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useInteractorOrientation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useInteractorOrientation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_elasticity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.elasticity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableElasticBreakLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableElasticBreakLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_elasticBreakLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.elasticBreakLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canProcessOnDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canProcessOnDrop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_objectPlaneTranslationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer.PlaneTranslationMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.objectPlaneTranslationMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enablePlaneClassificationFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enablePlaneClassificationFilter = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_planeClassificationsList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.planeClassificationsList = (System.Collections.Generic.List<UnityEngine.XR.ARSubsystems.PlaneClassification>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.ARSubsystems.PlaneClassification>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_planeClassifications(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.ARSubsystems.PlaneClassifications gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.planeClassifications = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useInteractorOrientation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useInteractorOrientation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_elasticity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.elasticity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableElasticBreakLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableElasticBreakLimit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_elasticBreakLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.ARTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.elasticBreakLimit = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
