
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.InputSystem = CS.UnityEngine.InputSystem or {}
---@class CS.UnityEngine.InputSystem.InputActionReference
CS.UnityEngine.InputSystem.InputActionReference = CS.UnityEngine.InputSystem.InputActionReference or {}

  
  ---@param action InputAction
  
  
function CS.UnityEngine.InputSystem.InputActionReference:Set(action) end
  

  

  
  ---@param asset InputActionAsset---@param mapName String---@param actionName String
  
  
function CS.UnityEngine.InputSystem.InputActionReference:Set(asset, mapName, actionName) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.InputSystem.InputActionReference:ToString() end
  

  

  
  ---@param action InputAction
  ---@return InputActionReference
  
function CS.UnityEngine.InputSystem.InputActionReference.Create(action) end
  

  

  
  
  ---@return InputAction
  
function CS.UnityEngine.InputSystem.InputActionReference:ToInputAction() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputActionReference:SetDirty() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionReference:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionReference:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputActionReference:Equals(other) end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.InputSystem.InputActionReference:GetType() end
  

  
