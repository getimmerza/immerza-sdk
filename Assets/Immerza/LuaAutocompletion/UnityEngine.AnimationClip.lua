
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.AnimationClip
CS.UnityEngine.AnimationClip = CS.UnityEngine.AnimationClip or {}

  
  ---@param go GameObject---@param time Single
  
  
function CS.UnityEngine.AnimationClip:SampleAnimation(go, time) end
  

  

  
  ---@param relativePath String---@param type Type---@param propertyName String---@param curve AnimationCurve
  
  
function CS.UnityEngine.AnimationClip:SetCurve(relativePath, type, propertyName, curve) end
  

  

  
  
  
  
function CS.UnityEngine.AnimationClip:EnsureQuaternionContinuity() end
  

  

  
  
  
  
function CS.UnityEngine.AnimationClip:ClearCurves() end
  

  

  
  ---@param evt AnimationEvent
  
  
function CS.UnityEngine.AnimationClip:AddEvent(evt) end
  

  

  
  ---@param val Boolean
  ---@return Boolean
  
function CS.UnityEngine.AnimationClip:ValidateIfRetargetable(val) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AnimationClip:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AnimationClip:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.AnimationClip:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AnimationClip:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AnimationClip:GetType() end
  

  
