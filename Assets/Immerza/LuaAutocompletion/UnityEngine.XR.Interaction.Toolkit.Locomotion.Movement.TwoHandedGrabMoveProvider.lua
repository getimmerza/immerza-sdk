
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider
CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider or {}

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider:GetType() end
  

  
