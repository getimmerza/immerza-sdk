
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.AnimationCurve
CS.UnityEngine.AnimationCurve = CS.UnityEngine.AnimationCurve or {}

  
  ---@param time Single
  ---@return Single
  
function CS.UnityEngine.AnimationCurve:Evaluate(time) end
  

  

  
  ---@param time Single---@param value Single
  ---@return Int32
  
function CS.UnityEngine.AnimationCurve:AddKey(time, value) end
  

  

  
  ---@param key Keyframe
  ---@return Int32
  
function CS.UnityEngine.AnimationCurve:AddKey(key) end
  

  

  
  ---@param index Int32---@param key Keyframe
  ---@return Int32
  
function CS.UnityEngine.AnimationCurve:MoveKey(index, key) end
  

  

  
  
  
  
function CS.UnityEngine.AnimationCurve:ClearKeys() end
  

  

  
  ---@param index Int32
  
  
function CS.UnityEngine.AnimationCurve:RemoveKey(index) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AnimationCurve:GetHashCode() end
  

  

  
  ---@param index Int32---@param weight Single
  
  
function CS.UnityEngine.AnimationCurve:SmoothTangents(index, weight) end
  

  

  
  ---@param timeStart Single---@param timeEnd Single---@param value Single
  ---@return AnimationCurve
  
function CS.UnityEngine.AnimationCurve.Constant(timeStart, timeEnd, value) end
  

  

  
  ---@param timeStart Single---@param valueStart Single---@param timeEnd Single---@param valueEnd Single
  ---@return AnimationCurve
  
function CS.UnityEngine.AnimationCurve.Linear(timeStart, valueStart, timeEnd, valueEnd) end
  

  

  
  ---@param timeStart Single---@param valueStart Single---@param timeEnd Single---@param valueEnd Single
  ---@return AnimationCurve
  
function CS.UnityEngine.AnimationCurve.EaseInOut(timeStart, valueStart, timeEnd, valueEnd) end
  

  

  
  ---@param o Object
  ---@return Boolean
  
function CS.UnityEngine.AnimationCurve:Equals(o) end
  

  

  
  ---@param other AnimationCurve
  ---@return Boolean
  
function CS.UnityEngine.AnimationCurve:Equals(other) end
  

  

  
  ---@param other AnimationCurve
  
  
function CS.UnityEngine.AnimationCurve:CopyFrom(other) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AnimationCurve:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AnimationCurve:ToString() end
  

  
