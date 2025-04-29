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
    public class UnityEngineXRInteractionToolkitInputsXRHandSkeletonPokeDisplacerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeInteractor", _g_get_pokeInteractor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeStrengthSnapThreshold", _g_get_pokeStrengthSnapThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothingAmount", _g_get_smoothingAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedOffset", _g_get_fixedOffset);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeInteractor", _s_set_pokeInteractor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeStrengthSnapThreshold", _s_set_pokeStrengthSnapThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothingAmount", _s_set_smoothingAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedOffset", _s_set_fixedOffset);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.pokeInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeStrengthSnapThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeStrengthSnapThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothingAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothingAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fixedOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeInteractor = (UnityEngine.XR.Interaction.Toolkit.Filtering.IPokeStateDataProvider)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.IPokeStateDataProvider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeStrengthSnapThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeStrengthSnapThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothingAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothingAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fixedOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
