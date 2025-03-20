/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System.Collections.Generic;
using System;
using XLua;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort;
using UnityEngine.XR.Interaction.Toolkit.Feedback;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Composites;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.OpenXR;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Gaze;
using UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Casters;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using Unity.XR.CoreUtils;

public static class XRGenConfig
{
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>()
    {
        // Feedback Start
        typeof(SimpleAudioFeedback),
        typeof(SimpleHapticFeedback),
        // Feedback End

        // Inputs Start
        typeof(ButtonFallbackComposite),
        typeof(HapticControlActionManager),
        typeof(HapticImpulseCommandChannel),
        typeof(HapticImpulseCommandChannelGroup),
        typeof(HapticImpulsePlayer),
        typeof(HapticImpulseSingleChannelGroup),
        typeof(InputActionManager),
        typeof(IntegerFallbackComposite),
        typeof(OpenXRHapticImpulseChannel),
        typeof(QuaternionFallbackComposite),
        typeof(SectorInteraction),
        typeof(Vector3FallbackComposite),
        typeof(XRDeviceSimulator),
        typeof(XRHandSkeletonPokeDisplacer),
        typeof(XRInputButtonReader),
        typeof(XRInputDeviceBoolValueReader),
        typeof(XRInputDeviceFloatValueReader),
        typeof(XRInputDeviceHapticImpulseChannel),
        typeof(XRInputDeviceHapticImpulseChannelGroup),
        typeof(XRInputDeviceHapticImpulseProvider),
        typeof(XRInputDeviceInputTrackingStateValueReader),
        typeof(XRInputDeviceQuaternionValueReader),
        typeof(XRInputDeviceVector2ValueReader),
        typeof(XRInputDeviceVector3ValueReader),
        typeof(XRInputHapticImpulseProvider),
        typeof(XRInputModalityManager),
        typeof(XRInputValueReader),
        typeof(XRTransformStabilizer),
        // Inputs Stop

        // Interaction Start
        typeof(ActivateEventArgs),
        typeof(ARTransformer),
        typeof(AttachPointVelocityTracker),
        typeof(CurveInteractionCaster),
        typeof(CurveVisualController),
        typeof(DeactivateEventArgs),
        typeof(FocusEnterEventArgs),
        typeof(FocusExitEventArgs),
        typeof(HoverEnterEventArgs),
        typeof(HoverExitEventArgs),
        typeof(InteractionAttachController),
        typeof(InteractionGroupRegisteredEventArgs),
        typeof(InteractionGroupUnregisteredEventArgs),
        typeof(LineProperties),
        typeof(NearFarInteractor),
        typeof(PokeThresholdData),
        typeof(PokeThresholdDatum),
        typeof(PokeThresholdDatumProperty),
        typeof(SelectEnterEventArgs),
        typeof(SelectExitEventArgs),
        typeof(SphereInteractionCaster),
        typeof(TouchscreenHoverFilter),
        typeof(XRAngleGazeEvaluator),
        typeof(XRDirectInteractor),
        typeof(XRDistanceEvaluator),
        typeof(XRDualGrabFreeTransformer),
        typeof(XRGazeAssistance),
        typeof(XRGazeInteractor),
        typeof(XRGeneralGrabTransformer),
        typeof(XRInteractableSnapVolume),
        typeof(XRInteractionGroup),
        typeof(XRInteractorLineVisual),
        typeof(XRInteractorReticleVisual),
        typeof(XRLastSelectedEvaluator),
        typeof(XRPokeFilter),
        typeof(XRPokeInteractor),
        typeof(XRSimpleInteractable),
        typeof(XRSingleGrabFreeTransformer),
        typeof(XRSocketGrabTransformer),
        typeof(XRSocketInteractor),
        typeof(XRTintInteractableVisual),
        // Interaction Stop

        // Locomotion Start
        typeof(CharacterControllerBodyManipulator),
        typeof(ClimbInteractable),
        typeof(ClimbProvider),
        typeof(ClimbSettings),
        typeof(ClimbSettingsDatum),
        typeof(ClimbSettingsDatumProperty),
        typeof(ClimbTeleportInteractor),
        typeof(ContinuousMoveProvider),
        typeof(ContinuousTurnProvider),
        typeof(DelegateXRBodyTransformation),
        typeof(FurthestTeleportationAnchorFilter),
        typeof(GazeTeleportationAnchorFilter),
        typeof(LocomotionMediator),
        typeof(LocomotionVignetteProvider),
        typeof(SnapTurnProvider),
        typeof(TeleportationAnchor),
        typeof(TeleportationArea),
        typeof(TeleportationMultiAnchorVolume),
        typeof(TeleportationProvider),
        typeof(TeleportingEventArgs),
        typeof(TeleportVolumeDestinationSettings),
        typeof(TeleportVolumeDestinationSettingsDatum),
        typeof(TeleportVolumeDestinationSettingsDatumProperty),
        typeof(TunnelingVignetteController),
        typeof(TwoHandedGrabMoveProvider),
        typeof(UnderCameraBodyPositionEvaluator),
        typeof(XRBodyGroundPosition),
        typeof(XRBodyScale),
        typeof(XRBodyTransformer),
        typeof(XRBodyYawRotation),
        typeof(XRCameraForwardXZAlignment),
        typeof(XRMovableBody),
        typeof(XROriginMovement),
        typeof(XROriginUpAlignment),
        // Locomotion End

        // Utilities Start
        typeof(GradientUtility),
        // Utilities End

        // General Start
        typeof(XROrigin)
        // General Stop
    };

    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>()
    {

    };

    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()
    {

    };
}
