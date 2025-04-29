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
    public class UnityEngineXRInteractionToolkitLocomotionDelegateXRBodyTransformationWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "transformation", _e_transformation);
			
			
			
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody>>(L, 2))
				{
					System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody> _transformation = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody>>(L, 2);
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation(_transformation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody _body = (UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody));
                    
                    gen_to_be_invoked.Apply( _body );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_transformation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.Locomotion.XRMovableBody>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.transformation += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.transformation -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Locomotion.DelegateXRBodyTransformation.transformation!");
            return 0;
        }
        
		
		
    }
}
