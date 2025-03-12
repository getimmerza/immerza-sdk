local unity = CS.UnityEngine

function update()
	local x = unity.Mathf.Cos(unity.Time.time)
	local y = unity.Mathf.Sin(unity.Time.time)

	local new_pos = unity.Vector3(cube_location.transform.position.x, cube_location.transform.position.y, cube_location.transform.position.z)

    local new_rot = unity.Quaternion.Euler(x * 360.0, 0.0, y * 360.0)

    cube_to_spin.transform:SetPositionAndRotation(new_pos, new_rot)
end