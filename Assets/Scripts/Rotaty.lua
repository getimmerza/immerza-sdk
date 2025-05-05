local unity = CS.UnityEngine

function start()
	CS.ImmerzaSDK.BreathingDetection.ExhaleStarted('+', get_data)
end

function get_data(isOn)
	-- do somethiong
end


function fixed_update()
	gameObject.transform:Rotate(unity.Vector3(1.0, 1.0, 0.0))
end