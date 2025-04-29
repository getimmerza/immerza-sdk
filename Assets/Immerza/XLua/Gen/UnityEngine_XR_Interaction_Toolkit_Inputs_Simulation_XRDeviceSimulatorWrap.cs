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
    public class UnityEngineXRInteractionToolkitInputsSimulationXRDeviceSimulatorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 81, 71);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "deviceSimulatorActionAsset", _g_get_deviceSimulatorActionAsset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controllerActionAsset", _g_get_controllerActionAsset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardXTranslateAction", _g_get_keyboardXTranslateAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardYTranslateAction", _g_get_keyboardYTranslateAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardZTranslateAction", _g_get_keyboardZTranslateAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulateLeftAction", _g_get_manipulateLeftAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulateRightAction", _g_get_manipulateRightAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleManipulateLeftAction", _g_get_toggleManipulateLeftAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleManipulateRightAction", _g_get_toggleManipulateRightAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleManipulateBodyAction", _g_get_toggleManipulateBodyAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulateHeadAction", _g_get_manipulateHeadAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handControllerModeAction", _g_get_handControllerModeAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cycleDevicesAction", _g_get_cycleDevicesAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stopManipulationAction", _g_get_stopManipulationAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseDeltaAction", _g_get_mouseDeltaAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseScrollAction", _g_get_mouseScrollAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateModeOverrideAction", _g_get_rotateModeOverrideAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleMouseTransformationModeAction", _g_get_toggleMouseTransformationModeAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "negateModeAction", _g_get_negateModeAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xConstraintAction", _g_get_xConstraintAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yConstraintAction", _g_get_yConstraintAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "zConstraintAction", _g_get_zConstraintAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resetAction", _g_get_resetAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleCursorLockAction", _g_get_toggleCursorLockAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleDevicePositionTargetAction", _g_get_toggleDevicePositionTargetAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "togglePrimary2DAxisTargetAction", _g_get_togglePrimary2DAxisTargetAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggleSecondary2DAxisTargetAction", _g_get_toggleSecondary2DAxisTargetAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axis2DAction", _g_get_axis2DAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restingHandAxis2DAction", _g_get_restingHandAxis2DAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gripAction", _g_get_gripAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "triggerAction", _g_get_triggerAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "primaryButtonAction", _g_get_primaryButtonAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondaryButtonAction", _g_get_secondaryButtonAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "menuAction", _g_get_menuAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "primary2DAxisClickAction", _g_get_primary2DAxisClickAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondary2DAxisClickAction", _g_get_secondary2DAxisClickAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "primary2DAxisTouchAction", _g_get_primary2DAxisTouchAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondary2DAxisTouchAction", _g_get_secondary2DAxisTouchAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "primaryTouchAction", _g_get_primaryTouchAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondaryTouchAction", _g_get_secondaryTouchAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handActionAsset", _g_get_handActionAsset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "simulatedHandExpressions", _g_get_simulatedHandExpressions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraTransform", _g_get_cameraTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardTranslateSpace", _g_get_keyboardTranslateSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseTranslateSpace", _g_get_mouseTranslateSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardXTranslateSpeed", _g_get_keyboardXTranslateSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardYTranslateSpeed", _g_get_keyboardYTranslateSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardZTranslateSpeed", _g_get_keyboardZTranslateSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardBodyTranslateMultiplier", _g_get_keyboardBodyTranslateMultiplier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseXTranslateSensitivity", _g_get_mouseXTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseYTranslateSensitivity", _g_get_mouseYTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseScrollTranslateSensitivity", _g_get_mouseScrollTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseXRotateSensitivity", _g_get_mouseXRotateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseYRotateSensitivity", _g_get_mouseYRotateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseScrollRotateSensitivity", _g_get_mouseScrollRotateSensitivity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseYRotateInvert", _g_get_mouseYRotateInvert);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "desiredCursorLockMode", _g_get_desiredCursorLockMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "removeOtherHMDDevices", _g_get_removeOtherHMDDevices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handTrackingCapability", _g_get_handTrackingCapability);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deviceSimulatorUI", _g_get_deviceSimulatorUI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gripAmount", _g_get_gripAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "triggerAmount", _g_get_triggerAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hmdIsTracked", _g_get_hmdIsTracked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hmdTrackingState", _g_get_hmdTrackingState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftControllerIsTracked", _g_get_leftControllerIsTracked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftControllerTrackingState", _g_get_leftControllerTrackingState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightControllerIsTracked", _g_get_rightControllerIsTracked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightControllerTrackingState", _g_get_rightControllerTrackingState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "leftHandIsTracked", _g_get_leftHandIsTracked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rightHandIsTracked", _g_get_rightHandIsTracked);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mouseTransformationMode", _g_get_mouseTransformationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "negateMode", _g_get_negateMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axis2DTargets", _g_get_axis2DTargets);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingLeftDevice", _g_get_manipulatingLeftDevice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingRightDevice", _g_get_manipulatingRightDevice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingLeftController", _g_get_manipulatingLeftController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingRightController", _g_get_manipulatingRightController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingLeftHand", _g_get_manipulatingLeftHand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingRightHand", _g_get_manipulatingRightHand);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulatingFPS", _g_get_manipulatingFPS);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deviceMode", _g_get_deviceMode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "deviceSimulatorActionAsset", _s_set_deviceSimulatorActionAsset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "controllerActionAsset", _s_set_controllerActionAsset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardXTranslateAction", _s_set_keyboardXTranslateAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardYTranslateAction", _s_set_keyboardYTranslateAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardZTranslateAction", _s_set_keyboardZTranslateAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manipulateLeftAction", _s_set_manipulateLeftAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manipulateRightAction", _s_set_manipulateRightAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleManipulateLeftAction", _s_set_toggleManipulateLeftAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleManipulateRightAction", _s_set_toggleManipulateRightAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleManipulateBodyAction", _s_set_toggleManipulateBodyAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manipulateHeadAction", _s_set_manipulateHeadAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "handControllerModeAction", _s_set_handControllerModeAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cycleDevicesAction", _s_set_cycleDevicesAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stopManipulationAction", _s_set_stopManipulationAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseDeltaAction", _s_set_mouseDeltaAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseScrollAction", _s_set_mouseScrollAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateModeOverrideAction", _s_set_rotateModeOverrideAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleMouseTransformationModeAction", _s_set_toggleMouseTransformationModeAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "negateModeAction", _s_set_negateModeAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xConstraintAction", _s_set_xConstraintAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yConstraintAction", _s_set_yConstraintAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "zConstraintAction", _s_set_zConstraintAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resetAction", _s_set_resetAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleCursorLockAction", _s_set_toggleCursorLockAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleDevicePositionTargetAction", _s_set_toggleDevicePositionTargetAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "togglePrimary2DAxisTargetAction", _s_set_togglePrimary2DAxisTargetAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggleSecondary2DAxisTargetAction", _s_set_toggleSecondary2DAxisTargetAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axis2DAction", _s_set_axis2DAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restingHandAxis2DAction", _s_set_restingHandAxis2DAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gripAction", _s_set_gripAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "triggerAction", _s_set_triggerAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "primaryButtonAction", _s_set_primaryButtonAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondaryButtonAction", _s_set_secondaryButtonAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "menuAction", _s_set_menuAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "primary2DAxisClickAction", _s_set_primary2DAxisClickAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondary2DAxisClickAction", _s_set_secondary2DAxisClickAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "primary2DAxisTouchAction", _s_set_primary2DAxisTouchAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondary2DAxisTouchAction", _s_set_secondary2DAxisTouchAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "primaryTouchAction", _s_set_primaryTouchAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondaryTouchAction", _s_set_secondaryTouchAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "handActionAsset", _s_set_handActionAsset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraTransform", _s_set_cameraTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardTranslateSpace", _s_set_keyboardTranslateSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseTranslateSpace", _s_set_mouseTranslateSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardXTranslateSpeed", _s_set_keyboardXTranslateSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardYTranslateSpeed", _s_set_keyboardYTranslateSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardZTranslateSpeed", _s_set_keyboardZTranslateSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardBodyTranslateMultiplier", _s_set_keyboardBodyTranslateMultiplier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseXTranslateSensitivity", _s_set_mouseXTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseYTranslateSensitivity", _s_set_mouseYTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseScrollTranslateSensitivity", _s_set_mouseScrollTranslateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseXRotateSensitivity", _s_set_mouseXRotateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseYRotateSensitivity", _s_set_mouseYRotateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseScrollRotateSensitivity", _s_set_mouseScrollRotateSensitivity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseYRotateInvert", _s_set_mouseYRotateInvert);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "desiredCursorLockMode", _s_set_desiredCursorLockMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "removeOtherHMDDevices", _s_set_removeOtherHMDDevices);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "handTrackingCapability", _s_set_handTrackingCapability);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deviceSimulatorUI", _s_set_deviceSimulatorUI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gripAmount", _s_set_gripAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "triggerAmount", _s_set_triggerAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hmdIsTracked", _s_set_hmdIsTracked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hmdTrackingState", _s_set_hmdTrackingState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftControllerIsTracked", _s_set_leftControllerIsTracked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftControllerTrackingState", _s_set_leftControllerTrackingState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightControllerIsTracked", _s_set_rightControllerIsTracked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightControllerTrackingState", _s_set_rightControllerTrackingState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "leftHandIsTracked", _s_set_leftHandIsTracked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rightHandIsTracked", _s_set_rightHandIsTracked);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mouseTransformationMode", _s_set_mouseTransformationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axis2DTargets", _s_set_axis2DTargets);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Negate", _m_Negate_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Negate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.TransformationMode _mode;translator.Get(L, 1, out _mode);
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.Negate( _mode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceSimulatorActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.deviceSimulatorActionAsset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controllerActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.controllerActionAsset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardXTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.keyboardXTranslateAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardYTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.keyboardYTranslateAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardZTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.keyboardZTranslateAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulateLeftAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.manipulateLeftAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulateRightAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.manipulateRightAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleManipulateLeftAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleManipulateLeftAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleManipulateRightAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleManipulateRightAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleManipulateBodyAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleManipulateBodyAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulateHeadAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.manipulateHeadAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handControllerModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.handControllerModeAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cycleDevicesAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.cycleDevicesAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stopManipulationAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.stopManipulationAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseDeltaAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mouseDeltaAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseScrollAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mouseScrollAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateModeOverrideAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotateModeOverrideAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleMouseTransformationModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleMouseTransformationModeAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_negateModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.negateModeAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xConstraintAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_yConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.yConstraintAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_zConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.zConstraintAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.resetAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleCursorLockAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleCursorLockAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleDevicePositionTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleDevicePositionTargetAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_togglePrimary2DAxisTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.togglePrimary2DAxisTargetAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggleSecondary2DAxisTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.toggleSecondary2DAxisTargetAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axis2DAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axis2DAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_restingHandAxis2DAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.restingHandAxis2DAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gripAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gripAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_triggerAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.triggerAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_primaryButtonAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.primaryButtonAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondaryButtonAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.secondaryButtonAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_menuAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.menuAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_primary2DAxisClickAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.primary2DAxisClickAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondary2DAxisClickAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.secondary2DAxisClickAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_primary2DAxisTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.primary2DAxisTouchAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondary2DAxisTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.secondary2DAxisTouchAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_primaryTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.primaryTouchAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondaryTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.secondaryTouchAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.handActionAsset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_simulatedHandExpressions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.simulatedHandExpressions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cameraTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.cameraTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardTranslateSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.keyboardTranslateSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseTranslateSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mouseTranslateSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardXTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.keyboardXTranslateSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardYTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.keyboardYTranslateSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardZTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.keyboardZTranslateSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardBodyTranslateMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.keyboardBodyTranslateMultiplier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseXTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseXTranslateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseYTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseYTranslateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseScrollTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseScrollTranslateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseXRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseXRotateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseYRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseYRotateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseScrollRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mouseScrollRotateSensitivity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseYRotateInvert(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.mouseYRotateInvert);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_desiredCursorLockMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.desiredCursorLockMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_removeOtherHMDDevices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.removeOtherHMDDevices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handTrackingCapability(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.handTrackingCapability);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceSimulatorUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.deviceSimulatorUI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gripAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gripAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_triggerAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.triggerAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hmdIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hmdIsTracked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hmdTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hmdTrackingState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftControllerIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.leftControllerIsTracked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftControllerTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.leftControllerTrackingState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightControllerIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.rightControllerIsTracked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightControllerTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rightControllerTrackingState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_leftHandIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.leftHandIsTracked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rightHandIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.rightHandIsTracked);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mouseTransformationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mouseTransformationMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_negateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.negateMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axis2DTargets(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axis2DTargets);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingLeftDevice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingLeftDevice);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingRightDevice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingRightDevice);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingLeftController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingLeftController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingRightController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingRightController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingLeftHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingLeftHand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingRightHand(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingRightHand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulatingFPS(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulatingFPS);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.deviceMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deviceSimulatorActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.deviceSimulatorActionAsset = (UnityEngine.InputSystem.InputActionAsset)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionAsset));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controllerActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.controllerActionAsset = (UnityEngine.InputSystem.InputActionAsset)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionAsset));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardXTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardXTranslateAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardYTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardYTranslateAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardZTranslateAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardZTranslateAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manipulateLeftAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manipulateLeftAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manipulateRightAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manipulateRightAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleManipulateLeftAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleManipulateLeftAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleManipulateRightAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleManipulateRightAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleManipulateBodyAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleManipulateBodyAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manipulateHeadAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manipulateHeadAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handControllerModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.handControllerModeAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cycleDevicesAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cycleDevicesAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stopManipulationAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stopManipulationAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseDeltaAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseDeltaAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseScrollAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseScrollAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateModeOverrideAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotateModeOverrideAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleMouseTransformationModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleMouseTransformationModeAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_negateModeAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.negateModeAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.xConstraintAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_yConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.yConstraintAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_zConstraintAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.zConstraintAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.resetAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleCursorLockAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleCursorLockAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleDevicePositionTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleDevicePositionTargetAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_togglePrimary2DAxisTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.togglePrimary2DAxisTargetAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggleSecondary2DAxisTargetAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.toggleSecondary2DAxisTargetAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axis2DAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axis2DAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_restingHandAxis2DAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.restingHandAxis2DAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gripAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gripAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_triggerAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.triggerAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_primaryButtonAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.primaryButtonAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondaryButtonAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.secondaryButtonAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_menuAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.menuAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_primary2DAxisClickAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.primary2DAxisClickAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondary2DAxisClickAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.secondary2DAxisClickAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_primary2DAxisTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.primary2DAxisTouchAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondary2DAxisTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.secondary2DAxisTouchAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_primaryTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.primaryTouchAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondaryTouchAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.secondaryTouchAction = (UnityEngine.InputSystem.InputActionReference)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionReference));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handActionAsset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.handActionAsset = (UnityEngine.InputSystem.InputActionAsset)translator.GetObject(L, 2, typeof(UnityEngine.InputSystem.InputActionAsset));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cameraTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cameraTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardTranslateSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.Space gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.keyboardTranslateSpace = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseTranslateSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.Space gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.mouseTranslateSpace = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardXTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardXTranslateSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardYTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardYTranslateSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardZTranslateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardZTranslateSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardBodyTranslateMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardBodyTranslateMultiplier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseXTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseXTranslateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseYTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseYTranslateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseScrollTranslateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseScrollTranslateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseXRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseXRotateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseYRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseYRotateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseScrollRotateSensitivity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseScrollRotateSensitivity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseYRotateInvert(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mouseYRotateInvert = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_desiredCursorLockMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.CursorLockMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.desiredCursorLockMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_removeOtherHMDDevices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.removeOtherHMDDevices = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handTrackingCapability(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.handTrackingCapability = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deviceSimulatorUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.deviceSimulatorUI = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gripAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gripAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_triggerAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.triggerAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hmdIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hmdIsTracked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hmdTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.InputTrackingState gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.hmdTrackingState = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftControllerIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftControllerIsTracked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftControllerTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.InputTrackingState gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.leftControllerTrackingState = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightControllerIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightControllerIsTracked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightControllerTrackingState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.InputTrackingState gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rightControllerTrackingState = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_leftHandIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.leftHandIsTracked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rightHandIsTracked(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rightHandIsTracked = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mouseTransformationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.TransformationMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.mouseTransformationMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axis2DTargets(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.Axis2DTargets gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.axis2DTargets = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
