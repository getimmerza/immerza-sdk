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
    public class UnityEngineXRInteractionToolkitFilteringPokeThresholdDatumPropertyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData>(L, 2))
				{
					UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData _value = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdData));
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty(_value);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatum>(L, 2))
				{
					UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatum _datum = (UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatum)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatum));
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty(_datum);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Filtering.PokeThresholdDatumProperty constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
