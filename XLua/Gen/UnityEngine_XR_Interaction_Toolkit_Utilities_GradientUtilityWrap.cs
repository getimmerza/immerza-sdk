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
    public class UnityEngineXRInteractionToolkitUtilitiesGradientUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", _m_Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyGradient", _m_CopyGradient_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lerp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    bool _lerpColors = LuaAPI.lua_toboolean(L, 4);
                    bool _lerpAlphas = LuaAPI.lua_toboolean(L, 5);
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _t, _lerpColors, _lerpAlphas );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    bool _lerpColors = LuaAPI.lua_toboolean(L, 4);
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _t, _lerpColors );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& translator.Assignable<UnityEngine.Gradient>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _output = (UnityEngine.Gradient)translator.GetObject(L, 3, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 4);
                    bool _lerpColors = LuaAPI.lua_toboolean(L, 5);
                    bool _lerpAlphas = LuaAPI.lua_toboolean(L, 6);
                    
                    UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _output, _t, _lerpColors, _lerpAlphas );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& translator.Assignable<UnityEngine.Gradient>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _output = (UnityEngine.Gradient)translator.GetObject(L, 3, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 4);
                    bool _lerpColors = LuaAPI.lua_toboolean(L, 5);
                    
                    UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _output, _t, _lerpColors );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Gradient>(L, 1)&& translator.Assignable<UnityEngine.Gradient>(L, 2)&& translator.Assignable<UnityEngine.Gradient>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Gradient _a = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _b = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _output = (UnityEngine.Gradient)translator.GetObject(L, 3, typeof(UnityEngine.Gradient));
                    float _t = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp( _a, _b, _output, _t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.Lerp!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyGradient_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Gradient _source = (UnityEngine.Gradient)translator.GetObject(L, 1, typeof(UnityEngine.Gradient));
                    UnityEngine.Gradient _destination = (UnityEngine.Gradient)translator.GetObject(L, 2, typeof(UnityEngine.Gradient));
                    
                    UnityEngine.XR.Interaction.Toolkit.Utilities.GradientUtility.CopyGradient( _source, _destination );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
