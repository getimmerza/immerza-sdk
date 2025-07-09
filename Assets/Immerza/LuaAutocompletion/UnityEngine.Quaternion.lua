
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Quaternion
CS.UnityEngine.Quaternion = CS.UnityEngine.Quaternion or {}

  
  ---@param fromDirection Vector3---@param toDirection Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.FromToRotation(fromDirection, toDirection) end
  

  

  
  ---@param rotation Quaternion
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Inverse(rotation) end
  

  

  
  ---@param a Quaternion---@param b Quaternion---@param t Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Slerp(a, b, t) end
  

  

  
  ---@param a Quaternion---@param b Quaternion---@param t Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.SlerpUnclamped(a, b, t) end
  

  

  
  ---@param a Quaternion---@param b Quaternion---@param t Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Lerp(a, b, t) end
  

  

  
  ---@param a Quaternion---@param b Quaternion---@param t Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.LerpUnclamped(a, b, t) end
  

  

  
  ---@param angle Single---@param axis Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.AngleAxis(angle, axis) end
  

  

  
  ---@param forward Vector3---@param upwards Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.LookRotation(forward, upwards) end
  

  

  
  ---@param forward Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.LookRotation(forward) end
  

  

  
  ---@param newX Single---@param newY Single---@param newZ Single---@param newW Single
  
  
function CS.UnityEngine.Quaternion:Set(newX, newY, newZ, newW) end
  

  

  
  ---@param a Quaternion---@param b Quaternion
  ---@return Single
  
function CS.UnityEngine.Quaternion.Dot(a, b) end
  

  

  
  ---@param view Vector3
  
  
function CS.UnityEngine.Quaternion:SetLookRotation(view) end
  

  

  
  ---@param view Vector3---@param up Vector3
  
  
function CS.UnityEngine.Quaternion:SetLookRotation(view, up) end
  

  

  
  ---@param a Quaternion---@param b Quaternion
  ---@return Single
  
function CS.UnityEngine.Quaternion.Angle(a, b) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Euler(x, y, z) end
  

  

  
  ---@param euler Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Euler(euler) end
  

  

  
  ---@param angle Single&---@param axis Vector3&
  
  
function CS.UnityEngine.Quaternion:ToAngleAxis(angle, axis) end
  

  

  
  ---@param fromDirection Vector3---@param toDirection Vector3
  
  
function CS.UnityEngine.Quaternion:SetFromToRotation(fromDirection, toDirection) end
  

  

  
  ---@param from Quaternion---@param to Quaternion---@param maxDegreesDelta Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.RotateTowards(from, to, maxDegreesDelta) end
  

  

  
  ---@param q Quaternion
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.Normalize(q) end
  

  

  
  
  
  
function CS.UnityEngine.Quaternion:Normalize() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Quaternion:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Quaternion:Equals(other) end
  

  

  
  ---@param other Quaternion
  ---@return Boolean
  
function CS.UnityEngine.Quaternion:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Quaternion:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Quaternion:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Quaternion:ToString(format, formatProvider) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.EulerRotation(x, y, z) end
  

  

  
  ---@param euler Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.EulerRotation(euler) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  
  
function CS.UnityEngine.Quaternion:SetEulerRotation(x, y, z) end
  

  

  
  ---@param euler Vector3
  
  
function CS.UnityEngine.Quaternion:SetEulerRotation(euler) end
  

  

  
  
  ---@return Vector3
  
function CS.UnityEngine.Quaternion:ToEuler() end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.EulerAngles(x, y, z) end
  

  

  
  ---@param euler Vector3
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.EulerAngles(euler) end
  

  

  
  ---@param axis Vector3&---@param angle Single&
  
  
function CS.UnityEngine.Quaternion:ToAxisAngle(axis, angle) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  
  
function CS.UnityEngine.Quaternion:SetEulerAngles(x, y, z) end
  

  

  
  ---@param euler Vector3
  
  
function CS.UnityEngine.Quaternion:SetEulerAngles(euler) end
  

  

  
  ---@param rotation Quaternion
  ---@return Vector3
  
function CS.UnityEngine.Quaternion.ToEulerAngles(rotation) end
  

  

  
  
  ---@return Vector3
  
function CS.UnityEngine.Quaternion:ToEulerAngles() end
  

  

  
  ---@param axis Vector3---@param angle Single
  
  
function CS.UnityEngine.Quaternion:SetAxisAngle(axis, angle) end
  

  

  
  ---@param axis Vector3---@param angle Single
  ---@return Quaternion
  
function CS.UnityEngine.Quaternion.AxisAngle(axis, angle) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Quaternion:GetType() end
  

  
