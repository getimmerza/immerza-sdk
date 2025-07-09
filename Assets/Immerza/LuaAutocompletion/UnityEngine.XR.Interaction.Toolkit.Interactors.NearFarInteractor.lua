
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor or {}

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:PreprocessInteractor(updatePhase) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetValidTargets(targets) end
  

  

  
  ---@param model TrackedDeviceModel&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:UpdateUIModel(model) end
  

  

  
  ---@param model TrackedDeviceModel&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetUIModel(model) end
  

  

  
  ---@param raycastResult RaycastResult&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetCurrentUIRaycastResult(raycastResult) end
  

  

  
  ---@param endPoint Vector3&---@param snapToSelectedAttachIfAvailable Boolean---@param snapToSnapVolumeIfAvailable Boolean
  ---@return EndPointType
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetCurveEndPoint(endPoint, snapToSelectedAttachIfAvailable, snapToSnapVolumeIfAvailable) end
  

  

  
  ---@param endNormal Vector3&---@param snapToSelectedAttachIfAvailable Boolean
  ---@return EndPointType
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetCurveEndNormal(endNormal, snapToSelectedAttachIfAvailable) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:ProcessInteractor(updatePhase) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetActivateTargets(targets) end
  

  

  
  ---@param amplitude Single---@param duration Single
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendHapticImpulse(amplitude, duration) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetAttachTransform(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetLocalAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:IsHovering(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:IsSelecting(interactable) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetInteractionStrength(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartManualInteraction(interactable) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:EndManualInteraction() end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetHoverTargets(targets) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetValidTargets(targets) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartManualInteraction(interactable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor:GetType() end
  

  
