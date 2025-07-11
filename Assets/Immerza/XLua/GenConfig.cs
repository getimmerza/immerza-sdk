﻿/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System.Collections.Generic;
using System;
using UnityEngine;
using XLua;
using System.Linq;
using System.Reflection;
using UnityEngine.Video;
using UnityEngine.VFX;
using UnityEngine.Splines;
using UnityEngine.InputSystem;
using ImmerzaSDK.Lua;
using TMPro;
using UnityEngine.UI;
using UnityEngine.AI;
using ImmerzaSDK.Shared;

public static class GenConfig
{
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
                typeof(System.Object),
                typeof(UnityEngine.Object),
                typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Quaternion),
                typeof(Color),
                typeof(Ray),
                typeof(Bounds),
                typeof(Ray2D),
                typeof(Time),
                typeof(UnityEngine.Random),
                typeof(GameObject),
                typeof(Component),
                typeof(Behaviour),
                typeof(Transform),
                typeof(Resources),
                typeof(TextAsset),
                typeof(Keyframe),
                typeof(AnimationCurve),
                typeof(Animator),
                typeof(AnimationClip),
                typeof(MonoBehaviour),
                typeof(ParticleSystem),
                typeof(SkinnedMeshRenderer),
                typeof(Mesh),
                typeof(VisualEffect),
                typeof(Collider),
                typeof(MeshCollider),
                typeof(Physics),
                typeof(LayerMask),
                typeof(ConfigurableJoint),
                typeof(Material),
                typeof(VideoPlayer),
                typeof(AudioClip),
                typeof(AudioSource),
                typeof(Renderer),
                typeof(Light),
                typeof(Spline),
                typeof(SplineContainer),
                typeof(SplineAnimate),
                typeof(SplineComponent),
                typeof(InputActionAsset),
                typeof(InputAction),
                typeof(InputActionReference),
                typeof(InputDevice),
                typeof(InputActionType),
                typeof(InputActionChange),
                typeof(TMP_Text),
                typeof(TMP_Dropdown),
                typeof(Button),
                typeof(Slider),
                typeof(Texture2D),
                typeof(Sprite),
                typeof(Mathf),
                typeof(System.Collections.Generic.List<int>),
                typeof(Action<string>),
                typeof(Action),
                typeof(UnityEngine.Debug),
                typeof(LuaAsset),
                typeof(NeckDataWrapper),

                // Navigation

                typeof(NavMesh),
                typeof(NavMeshAgent),
                typeof(NavMeshObstacle),
                typeof(NavMeshPath),
                typeof(NavMeshHit),
                typeof(NavMeshData),
                typeof(NavMeshDataInstance),
                typeof(NavMeshLinkData),
                typeof(NavMeshLinkInstance),
                typeof(NavMeshBuildSettings),
                typeof(NavMeshBuildSource),
                typeof(NavMeshBuildMarkup),
                typeof(Dictionary<string, object>)
            };

    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
                typeof(Action),
                typeof(Func<double, double, double>),
                typeof(Action<string>),
                typeof(Action<double>),
                typeof(Action<bool>),
                typeof(UnityEngine.Events.UnityAction),
                typeof(System.Collections.IEnumerator)
            };

    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
                new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.Light", "SetLightDirty"},
                new List<string>(){"UnityEngine.Light", "shadowRadius"},
                new List<string>(){"UnityEngine.Light", "shadowAngle"},
                new List<string>(){"UnityEngine.AudioSource", "PlayOnGamepad", "System.Int32"},
                new List<string>(){"UnityEngine.AudioSource", "DisableGamepadOutput"},
                new List<string>(){"UnityEngine.AudioSource", "SetGamepadSpeakerMixLevel", "System.Int32", "System.Int32"},
                new List<string>(){"UnityEngine.AudioSource", "SetGamepadSpeakerMixLevelDefault", "System.Int32"},
                new List<string>(){"UnityEngine.AudioSource", "SetGamepadSpeakerRestrictedAudio", "System.Int32", "System.Boolean"},
                new List<string>(){"UnityEngine.AudioSource", "GamepadSpeakerOutputType"},
                new List<string>(){"UnityEngine.AudioSource", "GamepadSpeakerSupportsOutputType", "UnityEngine.GamepadSpeakerOutputType"},
                new List<string>(){"UnityEngine.AudioSource", "gamepadSpeakerOutputType"},
                new List<string>(){"UnityEngine.Material", "parent"},
                new List<string>(){"UnityEngine.Material", "isVariant"},
                new List<string>(){"UnityEngine.Material", "IsChildOf", "UnityEngine.Material"},
                new List<string>(){"UnityEngine.Material", "RevertAllPropertyOverrides"},
                new List<string>(){"UnityEngine.Material", "IsPropertyOverriden", "System.Int32"},
                new List<string>(){"UnityEngine.Material", "IsPropertyOverriden", "System.String"},
                new List<string>(){"UnityEngine.Material", "IsPropertyLocked", "System.Int32"},
                new List<string>(){"UnityEngine.Material", "IsPropertyLocked", "System.String"},
                new List<string>(){"UnityEngine.Material", "IsPropertyLockedByAncestor", "System.Int32"},
                new List<string>(){"UnityEngine.Material", "IsPropertyLockedByAncestor", "System.String"},
                new List<string>(){"UnityEngine.Material", "SetPropertyLock", "System.Int32", "System.Boolean" },
                new List<string>(){"UnityEngine.Material", "SetPropertyLock", "System.String", "System.Boolean" },
                new List<string>(){"UnityEngine.Material", "ApplyPropertyOverride", "UnityEngine.Material", "System.Int32", "System.Boolean" },
                new List<string>(){"UnityEngine.Material", "ApplyPropertyOverride", "UnityEngine.Material", "System.Int32" },
                new List<string>(){"UnityEngine.Material", "ApplyPropertyOverride", "UnityEngine.Material", "System.String", "System.Boolean" },
                new List<string>(){"UnityEngine.Material", "ApplyPropertyOverride", "UnityEngine.Material", "System.String" },
                new List<string>(){"UnityEngine.Material", "RevertPropertyOverride", "System.String" },
                new List<string>(){"UnityEngine.Material", "RevertPropertyOverride", "System.Int32"},
    #if UNITY_ANDROID
                new List<string>(){"UnityEngine.Light", "SetLightDirty"},
                new List<string>(){"UnityEngine.Light", "shadowRadius"},
                new List<string>(){"UnityEngine.Light", "shadowAngle"},
    #endif
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
            };
    
    public static List<Type> BlackGenericTypeList = new List<Type>()
    {
        typeof(Span<>),
        typeof(ReadOnlySpan<>),
    };

    private static bool IsBlacklistedGenericType(Type type)
    {
        if (!type.IsGenericType) return false;
        return BlackGenericTypeList.Contains(type.GetGenericTypeDefinition());
    }

    [BlackList] public static Func<MemberInfo, bool> GenericTypeFilter = (memberInfo) =>
    {
        switch (memberInfo)
        {
            case PropertyInfo propertyInfo:
                return IsBlacklistedGenericType(propertyInfo.PropertyType);

            case ConstructorInfo constructorInfo:
                return constructorInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            case MethodInfo methodInfo:
                return methodInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            default:
                return false;
        }
    };
}
