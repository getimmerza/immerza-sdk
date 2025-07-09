
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Random
CS.UnityEngine.Random = CS.UnityEngine.Random or {}

  
  ---@param seed Int32
  
  
function CS.UnityEngine.Random.InitState(seed) end
  

  

  
  ---@param minInclusive Single---@param maxInclusive Single
  ---@return Single
  
function CS.UnityEngine.Random.Range(minInclusive, maxInclusive) end
  

  

  
  ---@param minInclusive Int32---@param maxExclusive Int32
  ---@return Int32
  
function CS.UnityEngine.Random.Range(minInclusive, maxExclusive) end
  

  

  
  ---@param min Single---@param max Single
  ---@return Single
  
function CS.UnityEngine.Random.RandomRange(min, max) end
  

  

  
  ---@param min Int32---@param max Int32
  ---@return Int32
  
function CS.UnityEngine.Random.RandomRange(min, max) end
  

  

  
  
  ---@return Color
  
function CS.UnityEngine.Random.ColorHSV() end
  

  

  
  ---@param hueMin Single---@param hueMax Single
  ---@return Color
  
function CS.UnityEngine.Random.ColorHSV(hueMin, hueMax) end
  

  

  
  ---@param hueMin Single---@param hueMax Single---@param saturationMin Single---@param saturationMax Single
  ---@return Color
  
function CS.UnityEngine.Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax) end
  

  

  
  ---@param hueMin Single---@param hueMax Single---@param saturationMin Single---@param saturationMax Single---@param valueMin Single---@param valueMax Single
  ---@return Color
  
function CS.UnityEngine.Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax) end
  

  

  
  ---@param hueMin Single---@param hueMax Single---@param saturationMin Single---@param saturationMax Single---@param valueMin Single---@param valueMax Single---@param alphaMin Single---@param alphaMax Single
  ---@return Color
  
function CS.UnityEngine.Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, alphaMin, alphaMax) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Random:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Random:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Random:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Random:ToString() end
  

  
