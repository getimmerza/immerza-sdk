
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Vector2
CS.UnityEngine.Vector2 = CS.UnityEngine.Vector2 or {}

  
  ---@param newX Single---@param newY Single
  
  
function CS.UnityEngine.Vector2:Set(newX, newY) end
  

  

  
  ---@param a Vector2---@param b Vector2---@param t Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Lerp(a, b, t) end
  

  

  
  ---@param a Vector2---@param b Vector2---@param t Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.LerpUnclamped(a, b, t) end
  

  

  
  ---@param current Vector2---@param target Vector2---@param maxDistanceDelta Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.MoveTowards(current, target, maxDistanceDelta) end
  

  

  
  ---@param a Vector2---@param b Vector2
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Scale(a, b) end
  

  

  
  ---@param scale Vector2
  
  
function CS.UnityEngine.Vector2:Scale(scale) end
  

  

  
  
  
  
function CS.UnityEngine.Vector2:Normalize() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Vector2:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Vector2:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Vector2:ToString(format, formatProvider) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Vector2:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Vector2:Equals(other) end
  

  

  
  ---@param other Vector2
  ---@return Boolean
  
function CS.UnityEngine.Vector2:Equals(other) end
  

  

  
  ---@param inDirection Vector2---@param inNormal Vector2
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Reflect(inDirection, inNormal) end
  

  

  
  ---@param inDirection Vector2
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Perpendicular(inDirection) end
  

  

  
  ---@param lhs Vector2---@param rhs Vector2
  ---@return Single
  
function CS.UnityEngine.Vector2.Dot(lhs, rhs) end
  

  

  
  ---@param from Vector2---@param to Vector2
  ---@return Single
  
function CS.UnityEngine.Vector2.Angle(from, to) end
  

  

  
  ---@param from Vector2---@param to Vector2
  ---@return Single
  
function CS.UnityEngine.Vector2.SignedAngle(from, to) end
  

  

  
  ---@param a Vector2---@param b Vector2
  ---@return Single
  
function CS.UnityEngine.Vector2.Distance(a, b) end
  

  

  
  ---@param vector Vector2---@param maxLength Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.ClampMagnitude(vector, maxLength) end
  

  

  
  ---@param a Vector2
  ---@return Single
  
function CS.UnityEngine.Vector2.SqrMagnitude(a) end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.Vector2:SqrMagnitude() end
  

  

  
  ---@param lhs Vector2---@param rhs Vector2
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Min(lhs, rhs) end
  

  

  
  ---@param lhs Vector2---@param rhs Vector2
  ---@return Vector2
  
function CS.UnityEngine.Vector2.Max(lhs, rhs) end
  

  

  
  ---@param current Vector2---@param target Vector2---@param currentVelocity Vector2&---@param smoothTime Single---@param maxSpeed Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed) end
  

  

  
  ---@param current Vector2---@param target Vector2---@param currentVelocity Vector2&---@param smoothTime Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.SmoothDamp(current, target, currentVelocity, smoothTime) end
  

  

  
  ---@param current Vector2---@param target Vector2---@param currentVelocity Vector2&---@param smoothTime Single---@param maxSpeed Single---@param deltaTime Single
  ---@return Vector2
  
function CS.UnityEngine.Vector2.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed, deltaTime) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Vector2:GetType() end
  

  
