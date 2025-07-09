
CS.Unity = CS.Unity or {}CS.Unity.XR = CS.Unity.XR or {}CS.Unity.XR.CoreUtils = CS.Unity.XR.CoreUtils or {}
---@class CS.Unity.XR.CoreUtils.XROrigin
CS.Unity.XR.CoreUtils.XROrigin = CS.Unity.XR.CoreUtils.XROrigin or {}

  
  ---@param angleDegrees Single
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:RotateAroundCameraUsingOriginUp(angleDegrees) end
  

  

  
  ---@param vector Vector3---@param angleDegrees Single
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:RotateAroundCameraPosition(vector, angleDegrees) end
  

  

  
  ---@param destinationUp Vector3
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:MatchOriginUp(destinationUp) end
  

  

  
  ---@param destinationUp Vector3---@param destinationForward Vector3
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:MatchOriginUpCameraForward(destinationUp, destinationForward) end
  

  

  
  ---@param destinationUp Vector3---@param destinationForward Vector3
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:MatchOriginUpOriginForward(destinationUp, destinationForward) end
  

  

  
  ---@param desiredWorldLocation Vector3
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:MoveCameraToWorldLocation(desiredWorldLocation) end
  

  

  
  
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:IsInvoking() end
  

  

  
  
  
  
function CS.Unity.XR.CoreUtils.XROrigin:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.Unity.XR.CoreUtils.XROrigin:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.Unity.XR.CoreUtils.XROrigin:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.Unity.XR.CoreUtils.XROrigin:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.Unity.XR.CoreUtils.XROrigin:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.Unity.XR.CoreUtils.XROrigin:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.Unity.XR.CoreUtils.XROrigin:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.Unity.XR.CoreUtils.XROrigin:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.Unity.XR.CoreUtils.XROrigin:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.Unity.XR.CoreUtils.XROrigin:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.Unity.XR.CoreUtils.XROrigin:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.Unity.XR.CoreUtils.XROrigin:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.Unity.XR.CoreUtils.XROrigin:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.Unity.XR.CoreUtils.XROrigin:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.Unity.XR.CoreUtils.XROrigin:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.Unity.XR.CoreUtils.XROrigin:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.Unity.XR.CoreUtils.XROrigin:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.Unity.XR.CoreUtils.XROrigin:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.Unity.XR.CoreUtils.XROrigin:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.Unity.XR.CoreUtils.XROrigin:ToString() end
  

  

  
  
  ---@return Type
  
function CS.Unity.XR.CoreUtils.XROrigin:GetType() end
  

  
