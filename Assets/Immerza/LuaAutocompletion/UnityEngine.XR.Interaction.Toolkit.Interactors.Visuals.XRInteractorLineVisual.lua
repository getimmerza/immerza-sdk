
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual or {}

  
  ---@param reticleInstance GameObject
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:AttachCustomReticle(reticleInstance) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:RemoveCustomReticle() end
  

  

  
  ---@param numTargetPoints Int32---@param curveRatio Single---@param lineOrigin Vector3&---@param lineDirection Vector3&---@param endPoint Vector3&---@param targetPoints NativeArray`1&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual.CalculateLineCurveRenderPoints$BurstManaged(numTargetPoints, curveRatio, lineOrigin, lineDirection, endPoint, targetPoints) end
  

  

  
  ---@param numRenderPoints Int32---@param numTargetPoints Int32---@param targetLineLength Single---@param shouldSmoothPoints Boolean---@param shouldOverwritePoints Boolean---@param pointSmoothIncrement Single---@param targetPoints NativeArray`1&---@param previousRenderPoints NativeArray`1&---@param renderPoints NativeArray`1&
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual.ComputeNewRenderPoints$BurstManaged(numRenderPoints, numTargetPoints, targetLineLength, shouldSmoothPoints, shouldOverwritePoints, pointSmoothIncrement, targetPoints, previousRenderPoints, renderPoints) end
  

  

  
  ---@param targetLineLength Single---@param shouldSmoothPoint Boolean---@param unsmoothedTargetPoint float3&---@param lastRenderPoint float3&---@param newRenderPoint float3&---@param lineLength Single&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual.EvaluateLineEndPoint$BurstManaged(targetLineLength, shouldSmoothPoint, unsmoothedTargetPoint, lastRenderPoint, newRenderPoint, lineLength) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals.XRInteractorLineVisual:GetType() end
  

  
