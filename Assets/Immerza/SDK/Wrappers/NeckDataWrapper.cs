using ImmerzaSDK.Shared;
using XLua;

namespace ImmerzaSDK.Wrappers
{
    [LuaCallCSharp]
    public static class NeckDataService
    {
#if !IMMERZA_INTERNAL
#pragma warning disable CS1998
#endif
#if IMMERZA_INTERNAL
        public static NeckDataEventChannel InternalEventChannel;
#endif
        public static async void SendNeckData(NeckDataWrapper data)
        {
#if IMMERZA_INTERNAL
            InternalEventChannel?.Raise(data);    
#endif
        }
    }
}