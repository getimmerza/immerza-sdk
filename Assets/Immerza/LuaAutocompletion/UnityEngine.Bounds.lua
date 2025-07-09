
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Bounds
CS.UnityEngine.Bounds = CS.UnityEngine.Bounds or {}

  
  
  ---@return Int32
  
function CS.UnityEngine.Bounds:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Bounds:Equals(other) end
  

  

  
  ---@param other Bounds
  ---@return Boolean
  
function CS.UnityEngine.Bounds:Equals(other) end
  

  

  
  ---@param min Vector3---@param max Vector3
  
  
function CS.UnityEngine.Bounds:SetMinMax(min, max) end
  

  

  
  ---@param point Vector3
  
  
function CS.UnityEngine.Bounds:Encapsulate(point) end
  

  

  
  ---@param bounds Bounds
  
  
function CS.UnityEngine.Bounds:Encapsulate(bounds) end
  

  

  
  ---@param amount Single
  
  
function CS.UnityEngine.Bounds:Expand(amount) end
  

  

  
  ---@param amount Vector3
  
  
function CS.UnityEngine.Bounds:Expand(amount) end
  

  

  
  ---@param bounds Bounds
  ---@return Boolean
  
function CS.UnityEngine.Bounds:Intersects(bounds) end
  

  

  
  ---@param ray Ray
  ---@return Boolean
  
function CS.UnityEngine.Bounds:IntersectRay(ray) end
  

  

  
  ---@param ray Ray---@param distance Single&
  ---@return Boolean
  
function CS.UnityEngine.Bounds:IntersectRay(ray, distance) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Bounds:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Bounds:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Bounds:ToString(format, formatProvider) end
  

  

  
  ---@param point Vector3
  ---@return Boolean
  
function CS.UnityEngine.Bounds:Contains(point) end
  

  

  
  ---@param point Vector3
  ---@return Single
  
function CS.UnityEngine.Bounds:SqrDistance(point) end
  

  

  
  ---@param point Vector3
  ---@return Vector3
  
function CS.UnityEngine.Bounds:ClosestPoint(point) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Bounds:GetType() end
  

  
