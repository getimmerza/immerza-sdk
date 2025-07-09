
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Color
CS.UnityEngine.Color = CS.UnityEngine.Color or {}

  
  
  ---@return String
  
function CS.UnityEngine.Color:ToString() end
  

  

  
  ---@param format String
  ---@return String
  
function CS.UnityEngine.Color:ToString(format) end
  

  

  
  ---@param format String---@param formatProvider IFormatProvider
  ---@return String
  
function CS.UnityEngine.Color:ToString(format, formatProvider) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Color:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Color:Equals(other) end
  

  

  
  ---@param other Color
  ---@return Boolean
  
function CS.UnityEngine.Color:Equals(other) end
  

  

  
  ---@param a Color---@param b Color---@param t Single
  ---@return Color
  
function CS.UnityEngine.Color.Lerp(a, b, t) end
  

  

  
  ---@param a Color---@param b Color---@param t Single
  ---@return Color
  
function CS.UnityEngine.Color.LerpUnclamped(a, b, t) end
  

  

  
  ---@param rgbColor Color---@param H Single&---@param S Single&---@param V Single&
  
  
function CS.UnityEngine.Color.RGBToHSV(rgbColor, H, S, V) end
  

  

  
  ---@param H Single---@param S Single---@param V Single
  ---@return Color
  
function CS.UnityEngine.Color.HSVToRGB(H, S, V) end
  

  

  
  ---@param H Single---@param S Single---@param V Single---@param hdr Boolean
  ---@return Color
  
function CS.UnityEngine.Color.HSVToRGB(H, S, V, hdr) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Color:GetType() end
  

  
