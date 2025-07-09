
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Vector4
CS.UnityEngine.Vector4 = CS.UnityEngine.Vector4 or {}

  
  ---@param newX Single---@param newY Single---@param newZ Single---@param newW Single
  
  
function CS.UnityEngine.Vector4:Set(newX, newY, newZ, newW) end
  

  

  
  ---@param a Vector4---@param b Vector4---@param t Single
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Lerp(a, b, t) end
  

  

  
  ---@param a Vector4---@param b Vector4---@param t Single
  ---@return Vector4
  
function CS.UnityEngine.Vector4.LerpUnclamped(a, b, t) end
  

  

  
  ---@param current Vector4---@param target Vector4---@param maxDistanceDelta Single
  ---@return Vector4
  
function CS.UnityEngine.Vector4.MoveTowards(current, target, maxDistanceDelta) end
  

  

  
  ---@param a Vector4---@param b Vector4
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Scale(a, b) end
  

  

  
  ---@param scale Vector4
  
  
function CS.UnityEngine.Vector4:Scale(scale) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Vector4:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Vector4:Equals(other) end
  

  

  
  ---@param other Vector4
  ---@return Boolean
  
function CS.UnityEngine.Vector4:Equals(other) end
  

  

  
  ---@param a Vector4
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Normalize(a) end
  

  

  
  
  
  
function CS.UnityEngine.Vector4:Normalize() end
  

  

  
  ---@param a Vector4---@param b Vector4
  ---@return Single
  
function CS.UnityEngine.Vector4.Dot(a, b) end
  

  

  
  ---@param a Vector4---@param b Vector4
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Project(a, b) end
  

  

  
  ---@param a Vector4---@param b Vector4
  ---@return Single
  
function CS.UnityEngine.Vector4.Distance(a, b) end
  

  

  
  ---@param a Vector4
  ---@return Single
  
function CS.UnityEngine.Vector4.Magnitude(a) end
  

  

  
  ---@param lhs Vector4---@param rhs Vector4
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Min(lhs, rhs) end
  

  

  
  ---@param lhs Vector4---@param rhs Vector4
  ---@return Vector4
  
function CS.UnityEngine.Vector4.Max(lhs, rhs) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Vector4:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Vector4:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Vector4:ToString(format, formatProvider) end
  

  

  
  ---@param a Vector4
  ---@return Single
  
function CS.UnityEngine.Vector4.SqrMagnitude(a) end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.Vector4:SqrMagnitude() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Vector4:GetType() end
  

  
