
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.InputSystem = CS.UnityEngine.InputSystem or {}
---@class CS.UnityEngine.InputSystem.InputActionAsset
CS.UnityEngine.InputSystem.InputActionAsset = CS.UnityEngine.InputSystem.InputActionAsset or {}

  
  
  ---@return String
  
function CS.UnityEngine.InputSystem.InputActionAsset:ToJson() end
  

  

  
  ---@param json String
  
  
function CS.UnityEngine.InputSystem.InputActionAsset:LoadFromJson(json) end
  

  

  
  ---@param json String
  ---@return InputActionAsset
  
function CS.UnityEngine.InputSystem.InputActionAsset.FromJson(json) end
  

  

  
  ---@param actionNameOrId String---@param throwIfNotFound Boolean
  ---@return InputAction
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindAction(actionNameOrId, throwIfNotFound) end
  

  

  
  ---@param mask InputBinding---@param action InputAction&
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindBinding(mask, action) end
  

  

  
  ---@param nameOrId String---@param throwIfNotFound Boolean
  ---@return InputActionMap
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindActionMap(nameOrId, throwIfNotFound) end
  

  

  
  ---@param id Guid
  ---@return InputActionMap
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindActionMap(id) end
  

  

  
  ---@param guid Guid
  ---@return InputAction
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindAction(guid) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindControlSchemeIndex(name) end
  

  

  
  ---@param name String
  ---@return Nullable`1
  
function CS.UnityEngine.InputSystem.InputActionAsset:FindControlScheme(name) end
  

  

  
  ---@param device InputDevice
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputActionAsset:IsUsableWithDevice(device) end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputActionAsset:Enable() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputActionAsset:Disable() end
  

  

  
  ---@param action InputAction
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputActionAsset:Contains(action) end
  

  

  
  
  ---@return IEnumerator`1
  
function CS.UnityEngine.InputSystem.InputActionAsset:GetEnumerator() end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputActionAsset:SetDirty() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionAsset:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputActionAsset:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputActionAsset:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.InputSystem.InputActionAsset:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.InputSystem.InputActionAsset:GetType() end
  

  
