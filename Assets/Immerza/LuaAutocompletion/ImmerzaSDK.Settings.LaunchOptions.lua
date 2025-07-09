
CS.ImmerzaSDK = CS.ImmerzaSDK or {}CS.ImmerzaSDK.Settings = CS.ImmerzaSDK.Settings or {}
---@class CS.ImmerzaSDK.Settings.LaunchOptions
CS.ImmerzaSDK.Settings.LaunchOptions = CS.ImmerzaSDK.Settings.LaunchOptions or {}

  
  ---@param options Dictionary`2
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:Init(options) end
  

  

  
  
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:IsInvoking() end
  

  

  
  
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Settings.LaunchOptions:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Settings.LaunchOptions:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.ImmerzaSDK.Settings.LaunchOptions:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.Settings.LaunchOptions:ToString() end
  

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.Settings.LaunchOptions.OnLaunchOptionsReceived(op, callback) end

  
