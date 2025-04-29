local unity = CS.UnityEngine

function start()
-- implement component start
end

function fixed_update()
	gameObject.transform:Rotate(unity.Vector3(1.0, 1.0, 0.0))
end