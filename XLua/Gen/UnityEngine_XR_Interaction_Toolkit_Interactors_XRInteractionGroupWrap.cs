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
    public class UnityEngineXRInteractionToolkitInteractorsXRInteractionGroupWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 7, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddStartingInteractionOverride", _m_AddStartingInteractionOverride);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveStartingInteractionOverride", _m_RemoveStartingInteractionOverride);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddGroupMember", _m_AddGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveGroupMemberTo", _m_MoveGroupMemberTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveGroupMember", _m_RemoveGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearGroupMembers", _m_ClearGroupMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsGroupMember", _m_ContainsGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGroupMembers", _m_GetGroupMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasDependencyOnGroup", _m_HasDependencyOnGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddInteractionOverrideForGroupMember", _m_AddInteractionOverrideForGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GroupMemberIsPartOfOverrideChain", _m_GroupMemberIsPartOfOverrideChain);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveInteractionOverrideForGroupMember", _m_RemoveInteractionOverrideForGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearInteractionOverridesForGroupMember", _m_ClearInteractionOverridesForGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractionOverridesForGroupMember", _m_GetInteractionOverridesForGroupMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusEntering", _m_OnFocusEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusExiting", _m_OnFocusExiting);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "registered", _e_registered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "unregistered", _e_unregistered);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "groupName", _g_get_groupName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionManager", _g_get_interactionManager);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "containingGroup", _g_get_containingGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingGroupMembers", _g_get_startingGroupMembers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeInteractor", _g_get_activeInteractor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusInteractor", _g_get_focusInteractor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusInteractable", _g_get_focusInteractable);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionManager", _s_set_interactionManager);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingGroupMembers", _s_set_startingGroupMembers);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddStartingInteractionOverride(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Object _sourceGroupMember = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    UnityEngine.Object _overrideGroupMember = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.AddStartingInteractionOverride( _sourceGroupMember, _overrideGroupMember );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveStartingInteractionOverride(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Object _sourceGroupMember = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    UnityEngine.Object _overrideGroupMember = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                        var gen_ret = gen_to_be_invoked.RemoveStartingInteractionOverride( _sourceGroupMember, _overrideGroupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _groupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                    gen_to_be_invoked.AddGroupMember( _groupMember );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveGroupMemberTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _groupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    int _newIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.MoveGroupMemberTo( _groupMember, _newIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _groupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                        var gen_ret = gen_to_be_invoked.RemoveGroupMember( _groupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearGroupMembers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearGroupMembers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _groupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                        var gen_ret = gen_to_be_invoked.ContainsGroupMember( _groupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGroupMembers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember>));
                    
                    gen_to_be_invoked.GetGroupMembers( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasDependencyOnGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _group = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    
                        var gen_ret = gen_to_be_invoked.HasDependencyOnGroup( _group );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddInteractionOverrideForGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _sourceGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _overrideGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                    gen_to_be_invoked.AddInteractionOverrideForGroupMember( _sourceGroupMember, _overrideGroupMember );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GroupMemberIsPartOfOverrideChain(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _sourceGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _potentialOverrideGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                        var gen_ret = gen_to_be_invoked.GroupMemberIsPartOfOverrideChain( _sourceGroupMember, _potentialOverrideGroupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveInteractionOverrideForGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _sourceGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _overrideGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                        var gen_ret = gen_to_be_invoked.RemoveInteractionOverrideForGroupMember( _sourceGroupMember, _overrideGroupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearInteractionOverridesForGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _sourceGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    
                        var gen_ret = gen_to_be_invoked.ClearInteractionOverridesForGroupMember( _sourceGroupMember );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractionOverridesForGroupMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember _sourceGroupMember = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember));
                    System.Collections.Generic.HashSet<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember> _results = (System.Collections.Generic.HashSet<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember>)translator.GetObject(L, 3, typeof(System.Collections.Generic.HashSet<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRGroupMember>));
                    
                    gen_to_be_invoked.GetInteractionOverridesForGroupMember( _sourceGroupMember, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusEntering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs));
                    
                    gen_to_be_invoked.OnFocusEntering( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusExiting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs));
                    
                    gen_to_be_invoked.OnFocusExiting( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groupName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.groupName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionManager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_containingGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.containingGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingGroupMembers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingGroupMembers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.activeInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.focusInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.focusInteractable);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingGroupMembers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingGroupMembers = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_registered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.registered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.registered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup.registered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_unregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.unregistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.unregistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup.unregistered!");
            return 0;
        }
        
		
		
    }
}
