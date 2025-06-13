local unity = CS.UnityEngine

function start()
	CS.ImmerzaSDK.Settings.LaunchOptions.OnLaunchOptionsReceived('+', function(options)
		unity.Debug.Log(options:get_Item("voiceGuideGender"))
		unity.Debug.Log(options:get_Item("duration"))
    end)

	CS.ImmerzaSDK.ImmerzaEvents.OnPauseRequested('+', function() end)
end

function dont_call_this()
	CS.ImmerzaSDK.ImmerzaEvents.EndScene()
end
