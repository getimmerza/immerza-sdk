
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.Splines = CS.UnityEngine.Splines or {}
---@class CS.UnityEngine.Splines.SplineContainer
CS.UnityEngine.Splines.SplineContainer = CS.UnityEngine.Splines.SplineContainer or {}

  
  
  
  
function CS.UnityEngine.Splines.SplineContainer:Warmup() end
  

  

  
  ---@param t Single---@param position float3&---@param tangent float3&---@param upVector float3&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:Evaluate(t, position, tangent, upVector) end
  

  

  
  ---@param splineIndex Int32---@param t Single---@param position float3&---@param tangent float3&---@param upVector float3&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:Evaluate(splineIndex, t, position, tangent, upVector) end
  

  

  
  ---@param spline T---@param t Single---@param position float3&---@param tangent float3&---@param upVector float3&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:Evaluate(spline, t, position, tangent, upVector) end
  

  

  
  ---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluatePosition(t) end
  

  

  
  ---@param splineIndex Int32---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluatePosition(splineIndex, t) end
  

  

  
  ---@param spline T---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluatePosition(spline, t) end
  

  

  
  ---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateTangent(t) end
  

  

  
  ---@param splineIndex Int32---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateTangent(splineIndex, t) end
  

  

  
  ---@param spline T---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateTangent(spline, t) end
  

  

  
  ---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateUpVector(t) end
  

  

  
  ---@param splineIndex Int32---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateUpVector(splineIndex, t) end
  

  

  
  ---@param spline T---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateUpVector(spline, t) end
  

  

  
  ---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateAcceleration(t) end
  

  

  
  ---@param splineIndex Int32---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateAcceleration(splineIndex, t) end
  

  

  
  ---@param spline T---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.SplineContainer:EvaluateAcceleration(spline, t) end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.Splines.SplineContainer:CalculateLength() end
  

  

  
  ---@param splineIndex Int32
  ---@return Single
  
function CS.UnityEngine.Splines.SplineContainer:CalculateLength(splineIndex) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineContainer:OnBeforeSerialize() end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineContainer:OnAfterDeserialize() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineContainer:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.Splines.SplineContainer:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.Splines.SplineContainer:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineContainer:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineContainer:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineContainer:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineContainer:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.Splines.SplineContainer:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.Splines.SplineContainer:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.Splines.SplineContainer:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineContainer:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.SplineContainer:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineContainer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineContainer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Splines.SplineContainer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Splines.SplineContainer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineContainer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Splines.SplineContainer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Splines.SplineContainer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Splines.SplineContainer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineContainer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.SplineContainer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Splines.SplineContainer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Splines.SplineContainer:ToString() end
  

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Splines.SplineContainer.SplineAdded(op, callback) end

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Splines.SplineContainer.SplineRemoved(op, callback) end

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Splines.SplineContainer.SplineReordered(op, callback) end

  
