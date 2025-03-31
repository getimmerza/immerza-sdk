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
    public class UnityEngineXRInteractionToolkitLocomotionCharacterControllerBodyManipulatorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLinkedToBody", _m_OnLinkedToBody);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUnlinkedFromBody", _m_OnUnlinkedFromBody);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveBody", _m_MoveBody);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastCollisionFlags", _g_get_lastCollisionFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isGrounded", _g_get_isGrounded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "characterController", _g_get_characterController);
            
			
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLinkedToBody(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody _body = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody));
                    
                    gen_to_be_invoked.OnLinkedToBody( _body );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUnlinkedFromBody(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnUnlinkedFromBody(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveBody(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _motion;translator.Get(L, 2, out _motion);
                    
                        var gen_ret = gen_to_be_invoked.MoveBody( _motion );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastCollisionFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastCollisionFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isGrounded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isGrounded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_characterController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.characterController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
