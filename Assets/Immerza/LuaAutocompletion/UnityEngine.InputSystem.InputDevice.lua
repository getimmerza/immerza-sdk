
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.InputSystem = CS.UnityEngine.InputSystem or {}
---@class CS.UnityEngine.InputSystem.InputDevice
CS.UnityEngine.InputSystem.InputDevice = CS.UnityEngine.InputSystem.InputDevice or {}

  
  ---@param buffer Void*---@param bufferSize Int32
  ---@return Object
  
function CS.UnityEngine.InputSystem.InputDevice:ReadValueFromBufferAsObject(buffer, bufferSize) end
  

  

  
  ---@param statePtr Void*
  ---@return Object
  
function CS.UnityEngine.InputSystem.InputDevice:ReadValueFromStateAsObject(statePtr) end
  

  

  
  ---@param statePtr Void*---@param bufferPtr Void*---@param bufferSize Int32
  
  
function CS.UnityEngine.InputSystem.InputDevice:ReadValueFromStateIntoBuffer(statePtr, bufferPtr, bufferSize) end
  

  

  
  ---@param firstStatePtr Void*---@param secondStatePtr Void*
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputDevice:CompareValue(firstStatePtr, secondStatePtr) end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputDevice:MakeCurrent() end
  

  

  
  ---@param command TCommand&
  ---@return Int64
  
function CS.UnityEngine.InputSystem.InputDevice:ExecuteCommand(command) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.InputSystem.InputDevice:ToString() end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.InputSystem.InputDevice:EvaluateMagnitude() end
  

  

  
  ---@param statePtr Void*
  ---@return Single
  
function CS.UnityEngine.InputSystem.InputDevice:EvaluateMagnitude(statePtr) end
  

  

  
  ---@param bufferPtr Void*---@param bufferSize Int32---@param statePtr Void*
  
  
function CS.UnityEngine.InputSystem.InputDevice:WriteValueFromBufferIntoState(bufferPtr, bufferSize, statePtr) end
  

  

  
  ---@param value Object---@param statePtr Void*
  
  
function CS.UnityEngine.InputSystem.InputDevice:WriteValueFromObjectIntoState(value, statePtr) end
  

  

  
  ---@param path String
  ---@return InputControl
  
function CS.UnityEngine.InputSystem.InputDevice:TryGetChildControl(path) end
  

  

  
  ---@param path String
  ---@return TControl
  
function CS.UnityEngine.InputSystem.InputDevice:TryGetChildControl(path) end
  

  

  
  ---@param path String
  ---@return InputControl
  
function CS.UnityEngine.InputSystem.InputDevice:GetChildControl(path) end
  

  

  
  ---@param path String
  ---@return TControl
  
function CS.UnityEngine.InputSystem.InputDevice:GetChildControl(path) end
  

  

  
  
  
  
function CS.UnityEngine.InputSystem.InputDevice:ApplyParameterChanges() end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.InputSystem.InputDevice:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.InputSystem.InputDevice:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.InputSystem.InputDevice:GetType() end
  

  
