
CS.ImmerzaSDK = CS.ImmerzaSDK or {}CS.ImmerzaSDK.Settings = CS.ImmerzaSDK.Settings or {}
---@class CS.ImmerzaSDK.Settings.AdvancedLaunchOptions
CS.ImmerzaSDK.Settings.AdvancedLaunchOptions = CS.ImmerzaSDK.Settings.AdvancedLaunchOptions or {}

  
  
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:IsInvoking() end
  

  

  
  
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:ToString() end
  

  

  
  
  ---@return Type
  
function CS.ImmerzaSDK.Settings.AdvancedLaunchOptions:GetType() end
  

  
