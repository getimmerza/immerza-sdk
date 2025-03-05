using System;

namespace ImmerzaSDK
{
    public static class ImmerzaEvents
    {
        public static event Action<bool> OnPauseRequested; // true for pause, false for unpause
        public static event Action OnSceneStart;

        public static event Action OnSceneEnd;

        public static void RequestPause(bool shouldPause)
        {
            OnPauseRequested?.Invoke(shouldPause);
        }
        public static void StartScene()
        {
            OnSceneStart?.Invoke();
        }

        public static void EndScene()
        {
            OnSceneEnd?.Invoke();
        }
    }
}
