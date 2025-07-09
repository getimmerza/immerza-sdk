
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor or {}

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:PreprocessInteractor(updatePhase) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:ProcessInteractor(updatePhase) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetValidTargets(targets) end
  

  

  
  ---@param model TrackedDeviceModel&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:UpdateUIModel(model) end
  

  

  
  ---@param model TrackedDeviceModel&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:TryGetUIModel(model) end
  

  

  
  
  ---@return Vector3
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetAttachPointVelocity() end
  

  

  
  
  ---@return Vector3
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetAttachPointAngularVelocity() end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetAttachTransform(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetLocalAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:IsHovering(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:IsSelecting(interactable) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetInteractionStrength(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartManualInteraction(interactable) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:EndManualInteraction() end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetHoverTargets(targets) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetValidTargets(targets) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartManualInteraction(interactable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor:GetType() end
  

  
