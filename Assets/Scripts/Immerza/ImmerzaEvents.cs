using System;

namespace ImmerzaSDK
{
    public static class ImmerzaEvents
    {
        public static event Action<bool> OnPauseRequested; // true for pause, false for unpause
        public static event Action OnSceneStart;

        public static event Action OnSceneEnd;
    }
}
