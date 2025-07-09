
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Inputs = CS.UnityEngine.XR.Interaction.Toolkit.Inputs or {}CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers = CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader
CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader = CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader or {}

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:EnableDirectActionIfModeUsed() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:DisableDirectActionIfModeUsed() end
  

  

  
  
  ---@return IXRInputButtonReader
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:GetObjectReference() end
  

  

  
  ---@param value IXRInputButtonReader
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:SetObjectReference(value) end
  

  

  
  ---@param performed Boolean---@param value Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:QueueManualState(performed, value) end
  

  

  
  ---@param performed Boolean---@param value Single---@param performedThisFrame Boolean---@param completedThisFrame Boolean
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:QueueManualState(performed, value, performedThisFrame, completedThisFrame) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:ReadIsPerformed() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:ReadWasPerformedThisFrame() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:ReadWasCompletedThisFrame() end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:ReadValue() end
  

  

  
  ---@param value Single&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:TryReadValue(value) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader:ToString() end
  

  
