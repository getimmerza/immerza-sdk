
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Vector3
CS.UnityEngine.Vector3 = CS.UnityEngine.Vector3 or {}

  
  ---@param a Vector3---@param b Vector3---@param t Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Slerp(a, b, t) end
  

  

  
  ---@param a Vector3---@param b Vector3---@param t Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.SlerpUnclamped(a, b, t) end
  

  

  
  ---@param normal Vector3&---@param tangent Vector3&
  
  
function CS.UnityEngine.Vector3.OrthoNormalize(normal, tangent) end
  

  

  
  ---@param normal Vector3&---@param tangent Vector3&---@param binormal Vector3&
  
  
function CS.UnityEngine.Vector3.OrthoNormalize(normal, tangent, binormal) end
  

  

  
  ---@param current Vector3---@param target Vector3---@param maxRadiansDelta Single---@param maxMagnitudeDelta Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta) end
  

  

  
  ---@param a Vector3---@param b Vector3---@param t Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Lerp(a, b, t) end
  

  

  
  ---@param a Vector3---@param b Vector3---@param t Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.LerpUnclamped(a, b, t) end
  

  

  
  ---@param current Vector3---@param target Vector3---@param maxDistanceDelta Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.MoveTowards(current, target, maxDistanceDelta) end
  

  

  
  ---@param current Vector3---@param target Vector3---@param currentVelocity Vector3&---@param smoothTime Single---@param maxSpeed Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed) end
  

  

  
  ---@param current Vector3---@param target Vector3---@param currentVelocity Vector3&---@param smoothTime Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.SmoothDamp(current, target, currentVelocity, smoothTime) end
  

  

  
  ---@param current Vector3---@param target Vector3---@param currentVelocity Vector3&---@param smoothTime Single---@param maxSpeed Single---@param deltaTime Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed, deltaTime) end
  

  

  
  ---@param newX Single---@param newY Single---@param newZ Single
  
  
function CS.UnityEngine.Vector3:Set(newX, newY, newZ) end
  

  

  
  ---@param a Vector3---@param b Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Scale(a, b) end
  

  

  
  ---@param scale Vector3
  
  
function CS.UnityEngine.Vector3:Scale(scale) end
  

  

  
  ---@param lhs Vector3---@param rhs Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Cross(lhs, rhs) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Vector3:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Vector3:Equals(other) end
  

  

  
  ---@param other Vector3
  ---@return Boolean
  
function CS.UnityEngine.Vector3:Equals(other) end
  

  

  
  ---@param inDirection Vector3---@param inNormal Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Reflect(inDirection, inNormal) end
  

  

  
  ---@param value Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Normalize(value) end
  

  

  
  
  
  
function CS.UnityEngine.Vector3:Normalize() end
  

  

  
  ---@param lhs Vector3---@param rhs Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.Dot(lhs, rhs) end
  

  

  
  ---@param vector Vector3---@param onNormal Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Project(vector, onNormal) end
  

  

  
  ---@param vector Vector3---@param planeNormal Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.ProjectOnPlane(vector, planeNormal) end
  

  

  
  ---@param from Vector3---@param to Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.Angle(from, to) end
  

  

  
  ---@param from Vector3---@param to Vector3---@param axis Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.SignedAngle(from, to, axis) end
  

  

  
  ---@param a Vector3---@param b Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.Distance(a, b) end
  

  

  
  ---@param vector Vector3---@param maxLength Single
  ---@return Vector3
  
function CS.UnityEngine.Vector3.ClampMagnitude(vector, maxLength) end
  

  

  
  ---@param vector Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.Magnitude(vector) end
  

  

  
  ---@param vector Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.SqrMagnitude(vector) end
  

  

  
  ---@param lhs Vector3---@param rhs Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Min(lhs, rhs) end
  

  

  
  ---@param lhs Vector3---@param rhs Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Max(lhs, rhs) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Vector3:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Vector3:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Vector3:ToString(format, formatProvider) end
  

  

  
  ---@param from Vector3---@param to Vector3
  ---@return Single
  
function CS.UnityEngine.Vector3.AngleBetween(from, to) end
  

  

  
  ---@param excludeThis Vector3---@param fromThat Vector3
  ---@return Vector3
  
function CS.UnityEngine.Vector3.Exclude(excludeThis, fromThat) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Vector3:GetType() end
  

  
