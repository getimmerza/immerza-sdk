
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor or {}

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:PreprocessInteractor(updatePhase) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:IsOverUIGameObject() end
  

  

  
  ---@param linePoints NativeArray`1&---@param numPoints Int32&---@param rayOriginOverride Nullable`1
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetLinePoints(linePoints, numPoints, rayOriginOverride) end
  

  

  
  ---@param linePoints Vector3[]&---@param numPoints Int32&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetLinePoints(linePoints, numPoints) end
  

  

  
  ---@param origin Vector3&---@param direction Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetLineOriginAndDirection(origin, direction) end
  

  

  
  ---@param position Vector3&---@param normal Vector3&---@param positionInLine Int32&---@param isValidTarget Boolean&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetHitInfo(position, normal, positionInLine, isValidTarget) end
  

  

  
  ---@param model TrackedDeviceModel&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:UpdateUIModel(model) end
  

  

  
  ---@param model TrackedDeviceModel&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetUIModel(model) end
  

  

  
  ---@param raycastHit RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrent3DRaycastHit(raycastHit) end
  

  

  
  ---@param raycastHit RaycastHit&---@param raycastEndpointIndex Int32&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrent3DRaycastHit(raycastHit, raycastEndpointIndex) end
  

  

  
  ---@param raycastResult RaycastResult&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentUIRaycastResult(raycastResult) end
  

  

  
  ---@param raycastResult RaycastResult&---@param raycastEndpointIndex Int32&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentUIRaycastResult(raycastResult, raycastEndpointIndex) end
  

  

  
  ---@param raycastHit ARRaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentARRaycastHit(raycastHit) end
  

  

  
  ---@param raycastHit ARRaycastHit&---@param raycastEndpointIndex Int32&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentARRaycastHit(raycastHit, raycastEndpointIndex) end
  

  

  
  ---@param raycastHit Nullable`1&---@param raycastHitIndex Int32&---@param uiRaycastHit Nullable`1&---@param uiRaycastHitIndex Int32&---@param isUIHitClosest Boolean&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentRaycast(raycastHit, raycastHitIndex, uiRaycastHit, uiRaycastHitIndex, isUIHitClosest) end
  

  

  
  ---@param raycastHit Nullable`1&---@param raycastHitIndex Int32&---@param uiRaycastHit Nullable`1&---@param uiRaycastHitIndex Int32&---@param isUIHitClosest Boolean&---@param arRaycastHit Nullable`1&---@param arRaycastHitIndex Int32&---@param isARHitClosest Boolean&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetCurrentRaycast(raycastHit, raycastHitIndex, uiRaycastHit, uiRaycastHitIndex, isUIHitClosest, arRaycastHit, arRaycastHitIndex, isARHitClosest) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:ProcessInteractor(updatePhase) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetValidTargets(targets) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CanSelect(interactable) end
  

  

  
  ---@param linePoints Vector3[]&---@param numPoints Int32&---@param _ Int32
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetLinePoints(linePoints, numPoints, _) end
  

  

  
  ---@param position Vector3&---@param normal Vector3&---@param positionInLine Int32&---@param isValidTarget Boolean&---@param _ Int32
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetHitInfo(position, normal, positionInLine, isValidTarget, _) end
  

  

  
  ---@param raycastHit RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetCurrentRaycastHit(raycastHit) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetActivateTargets(targets) end
  

  

  
  ---@param amplitude Single---@param duration Single
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendHapticImpulse(amplitude, duration) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetAttachTransform(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetLocalAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:IsHovering(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:IsSelecting(interactable) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetInteractionStrength(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartManualInteraction(interactable) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:EndManualInteraction() end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetHoverTargets(targets) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetValidTargets(targets) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartManualInteraction(interactable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor:GetType() end
  

  
