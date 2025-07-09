
CS.ImmerzaSDK = CS.ImmerzaSDK or {}
---@class CS.ImmerzaSDK.MultipathContainer
CS.ImmerzaSDK.MultipathContainer = CS.ImmerzaSDK.MultipathContainer or {}

  
  
  ---@return SplineContainer
  
function CS.ImmerzaSDK.MultipathContainer:GetRandomPath() end
  

  

  
  
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:IsInvoking() end
  

  

  
  
  
  
function CS.ImmerzaSDK.MultipathContainer:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.ImmerzaSDK.MultipathContainer:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.ImmerzaSDK.MultipathContainer:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.MultipathContainer:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.ImmerzaSDK.MultipathContainer:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.ImmerzaSDK.MultipathContainer:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.MultipathContainer:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.MultipathContainer:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.ImmerzaSDK.MultipathContainer:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.ImmerzaSDK.MultipathContainer:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.MultipathContainer:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.ImmerzaSDK.MultipathContainer:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.MultipathContainer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.ImmerzaSDK.MultipathContainer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.MultipathContainer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.MultipathContainer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.MultipathContainer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.ImmerzaSDK.MultipathContainer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.MultipathContainer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.MultipathContainer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.MultipathContainer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.MultipathContainer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.ImmerzaSDK.MultipathContainer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.MultipathContainer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.ImmerzaSDK.MultipathContainer:GetType() end
  

  
