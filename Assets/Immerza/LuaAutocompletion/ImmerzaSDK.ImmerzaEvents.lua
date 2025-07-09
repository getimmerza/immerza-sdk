
CS.ImmerzaSDK = CS.ImmerzaSDK or {}
---@class CS.ImmerzaSDK.ImmerzaEvents
CS.ImmerzaSDK.ImmerzaEvents = CS.ImmerzaSDK.ImmerzaEvents or {}

  
  ---@param shouldPause Boolean
  
  
function CS.ImmerzaSDK.ImmerzaEvents.RequestPause(shouldPause) end
  

  

  
  
  
  
function CS.ImmerzaSDK.ImmerzaEvents.EndScene() end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.ImmerzaSDK.ImmerzaEvents:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.ImmerzaEvents:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.ImmerzaSDK.ImmerzaEvents:GetType() end
  

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.ImmerzaEvents.OnPauseRequested(op, callback) end

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.ImmerzaEvents.OnSceneEnd(op, callback) end

  
