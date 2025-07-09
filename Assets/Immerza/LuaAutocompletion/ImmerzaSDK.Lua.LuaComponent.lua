
CS.ImmerzaSDK = CS.ImmerzaSDK or {}CS.ImmerzaSDK.Lua = CS.ImmerzaSDK.Lua or {}
---@class CS.ImmerzaSDK.Lua.LuaComponent
CS.ImmerzaSDK.Lua.LuaComponent = CS.ImmerzaSDK.Lua.LuaComponent or {}

  
  ---@param eventName String---@param callback Action`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent.RegisterEvent(eventName, callback) end
  

  

  
  ---@param eventName String---@param eventData LuaTable
  
  
function CS.ImmerzaSDK.Lua.LuaComponent.TriggerEvent(eventName, eventData) end
  

  

  
  
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:IsInvoking() end
  

  

  
  
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.ImmerzaSDK.Lua.LuaComponent:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.ImmerzaSDK.Lua.LuaComponent:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Lua.LuaComponent:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.Lua.LuaComponent:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.Lua.LuaComponent:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.ImmerzaSDK.Lua.LuaComponent:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.Lua.LuaComponent:ToString() end
  

  

  
  
  ---@return Type
  
function CS.ImmerzaSDK.Lua.LuaComponent:GetType() end
  

  
