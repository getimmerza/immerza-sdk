
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.InputSystem = CS.UnityEngine.InputSystem or {}
---@class CS.UnityEngine.InputSystem.InputAction
CS.UnityEngine.InputSystem.InputAction = CS.UnityEngine.InputSystem.InputAction or {}

  
  
  
  
function CS.UnityEngine.InputSystem.InputAction:Dispose() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.InputSystem.InputAction:ToString() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputAction:Enable() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputAction:Disable() end
  

  

  
  
  ---@return InputAction
  
function CS.UnityEngine.InputSystem.InputAction:Clone() end
  

  

  
  
  ---@return TValue
  
function CS.UnityEngine.InputSystem.InputAction:ReadValue() end
  

  

  
  
  ---@return Object
  
function CS.UnityEngine.InputSystem.InputAction:ReadValueAsObject() end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.InputSystem.InputAction:GetControlMagnitude() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputAction:Reset() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:IsPressed() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:IsInProgress() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:WasPressedThisFrame() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:WasReleasedThisFrame() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:WasPerformedThisFrame() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:WasCompletedThisFrame() end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.InputSystem.InputAction:GetTimeoutCompletionPercentage() end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputAction:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputAction:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.InputSystem.InputAction:GetType() end
  

  
