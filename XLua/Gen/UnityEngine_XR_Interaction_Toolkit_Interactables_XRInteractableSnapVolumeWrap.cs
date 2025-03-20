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
    public class UnityEngineXRInteractionToolkitInteractablesXRInteractableSnapVolumeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestPoint", _m_GetClosestPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestPointOfAttachTransform", _m_GetClosestPointOfAttachTransform);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionManager", _g_get_interactionManager);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableObject", _g_get_interactableObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapCollider", _g_get_snapCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableSnapColliderWhenSelected", _g_get_disableSnapColliderWhenSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapToCollider", _g_get_snapToCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactable", _g_get_interactable);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionManager", _s_set_interactionManager);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableObject", _s_set_interactableObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapCollider", _s_set_snapCollider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableSnapColliderWhenSelected", _s_set_disableSnapColliderWhenSelected);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapToCollider", _s_set_snapToCollider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactable", _s_set_interactable);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClosestPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.GetClosestPoint( _point );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClosestPointOfAttachTransform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetClosestPointOfAttachTransform( _interactor );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionManager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactableObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactableObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.snapCollider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disableSnapColliderWhenSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disableSnapColliderWhenSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapToCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.snapToCollider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactableObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableObject = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disableSnapColliderWhenSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.disableSnapColliderWhenSelected = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapToCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapToCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
