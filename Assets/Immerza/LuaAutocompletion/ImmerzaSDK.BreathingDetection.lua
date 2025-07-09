
CS.ImmerzaSDK = CS.ImmerzaSDK or {}
---@class CS.ImmerzaSDK.BreathingDetection
CS.ImmerzaSDK.BreathingDetection = CS.ImmerzaSDK.BreathingDetection or {}

  
  
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:IsInvoking() end
  

  

  
  
  
  
function CS.ImmerzaSDK.BreathingDetection:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.ImmerzaSDK.BreathingDetection:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.ImmerzaSDK.BreathingDetection:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.BreathingDetection:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.ImmerzaSDK.BreathingDetection:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.ImmerzaSDK.BreathingDetection:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.BreathingDetection:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.ImmerzaSDK.BreathingDetection:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.ImmerzaSDK.BreathingDetection:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.ImmerzaSDK.BreathingDetection:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.BreathingDetection:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.ImmerzaSDK.BreathingDetection:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.BreathingDetection:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.ImmerzaSDK.BreathingDetection:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.ImmerzaSDK.BreathingDetection:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.ImmerzaSDK.BreathingDetection:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.BreathingDetection:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.ImmerzaSDK.BreathingDetection:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.ImmerzaSDK.BreathingDetection:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.ImmerzaSDK.BreathingDetection:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.BreathingDetection:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.BreathingDetection:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.ImmerzaSDK.BreathingDetection:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.BreathingDetection:ToString() end
  

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.BreathingDetection.ExhaleStarted(op, callback) end

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.BreathingDetection.ExhaleFinished(op, callback) end

  

  
---@param op string
---@param callback function
function CS.ImmerzaSDK.BreathingDetection.RespiratoryRatePost(op, callback) end

  
