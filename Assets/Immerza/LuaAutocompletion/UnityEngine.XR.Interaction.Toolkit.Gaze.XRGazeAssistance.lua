
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Gaze = CS.UnityEngine.XR.Interaction.Toolkit.Gaze or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance
CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance = CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance or {}

  
  ---@param source Vector3&---@param velocity Vector3&---@param gravity Single
  ---@return Vector3
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetAssistedVelocity(source, velocity, gravity) end
  

  

  
  ---@param source Vector3&---@param velocity Vector3&---@param gravity Single---@param maxAngle Single
  ---@return Vector3
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetAssistedVelocity(source, velocity, gravity, maxAngle) end
  

  

  
  ---@param source Vector3&---@param target Vector3&---@param velocity Vector3&---@param gravity Single---@param maxAngle Single---@param requiredSpeed Single---@param maxSpeedPercent Single---@param assistPercent Single---@param epsilon Single---@param adjustedVelocity Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance.GetAssistedVelocityInternal$BurstManaged(source, target, velocity, gravity, maxAngle, requiredSpeed, maxSpeedPercent, assistPercent, epsilon, adjustedVelocity) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Gaze.XRGazeAssistance:GetType() end
  

  
