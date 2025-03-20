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
    public class UnityEngineXRInteractionToolkitInteractionGroupRegisteredEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 2);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionGroupObject", _g_get_interactionGroupObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "containingGroupObject", _g_get_containingGroupObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionGroupObject", _s_set_interactionGroupObject);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "containingGroupObject", _s_set_containingGroupObject);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionGroupObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactionGroupObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_containingGroupObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.containingGroupObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionGroupObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionGroupObject = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_containingGroupObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.containingGroupObject = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
