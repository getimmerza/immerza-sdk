
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Transformers = CS.UnityEngine.XR.Interaction.Toolkit.Transformers or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer
CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer = CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer or {}

  
  ---@param grabInteractable XRGrabInteractable---@param updatePhase UpdatePhase---@param targetPose Pose&---@param localScale Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:Process(grabInteractable, updatePhase, targetPose, localScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:OnGrab(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable---@param targetPose Pose---@param localScale Vector3
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:OnGrabCountChanged(grabInteractable, targetPose, localScale) end
  

  

  
  ---@param interactorPosition float3&---@param interactorRotation quaternion&---@param objectRotation quaternion&---@param objectScale float3&---@param trackRotation Boolean---@param offsetPosition float3&---@param objectLocalGrabPoint float3&---@param interactorLocalGrabPoint float3&---@param newPosition Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.ComputeNewObjectPosition$BurstManaged(interactorPosition, interactorRotation, objectRotation, objectScale, trackRotation, offsetPosition, objectLocalGrabPoint, interactorLocalGrabPoint, newPosition) end
  

  

  
  ---@param targetPosition Vector3&---@param originalObjectPose Pose&---@param axisDisplacementMode ConstrainedAxisDisplacementMode---@param hasX Boolean---@param hasY Boolean---@param hasZ Boolean---@param adjustedTargetPosition Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.AdjustPositionForPermittedAxesBurst$BurstManaged(targetPosition, originalObjectPose, axisDisplacementMode, hasX, hasY, hasZ, adjustedTargetPosition) end
  

  

  
  ---@param currentScale Vector3&---@param initialScaleProportions Vector3&---@param clampScale Boolean---@param minScale Vector3&---@param maxScale Vector3&---@param scaleInput Single---@param deltaTime Single---@param scaleSpeed Single---@param newScale Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.ComputeNewOneHandedScale$BurstManaged(currentScale, initialScaleProportions, clampScale, minScale, maxScale, scaleInput, deltaTime, scaleSpeed, newScale) end
  

  

  
  ---@param startScale Vector3&---@param currentScale Vector3&---@param startHandleBar Vector3&---@param newHandleBar Vector3&---@param clampScale Boolean---@param scaleMultiplier Single---@param thresholdMoveRatioForScale Single---@param minScale Vector3&---@param maxScale Vector3&---@param newScale Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.ComputeNewTwoHandedScale$BurstManaged(startScale, currentScale, startHandleBar, newHandleBar, clampScale, scaleMultiplier, thresholdMoveRatioForScale, minScale, maxScale, newScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:OnLink(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:OnUnlink(grabInteractable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer:GetType() end
  

  
