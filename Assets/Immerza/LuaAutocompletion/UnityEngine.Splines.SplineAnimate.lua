
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.Splines = CS.UnityEngine.Splines or {}
---@class CS.UnityEngine.Splines.SplineAnimate
CS.UnityEngine.Splines.SplineAnimate = CS.UnityEngine.Splines.SplineAnimate or {}

  
  
  
  
function CS.UnityEngine.Splines.SplineAnimate:Play() end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineAnimate:Pause() end
  

  

  
  ---@param autoplay Boolean
  
  
function CS.UnityEngine.Splines.SplineAnimate:Restart(autoplay) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineAnimate:Update() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineAnimate:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.Splines.SplineAnimate:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.Splines.SplineAnimate:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineAnimate:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineAnimate:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineAnimate:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineAnimate:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineAnimate:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.Splines.SplineAnimate:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.Splines.SplineAnimate:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineAnimate:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineAnimate:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineAnimate:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Splines.SplineAnimate:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineAnimate:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineAnimate:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineAnimate:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineAnimate:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineAnimate:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Splines.SplineAnimate:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Splines.SplineAnimate:GetType() end
  

  
