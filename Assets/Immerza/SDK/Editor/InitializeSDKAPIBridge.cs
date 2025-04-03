using ImmerzaSDK.Manager.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

[InitializeOnLoad]
internal static class InitializeSDKAPIBridge
{
    static InitializeSDKAPIBridge()
    {
        SDKAPIBridge.RegisterSceneBuilder(new SceneBuilder());
    }
}
