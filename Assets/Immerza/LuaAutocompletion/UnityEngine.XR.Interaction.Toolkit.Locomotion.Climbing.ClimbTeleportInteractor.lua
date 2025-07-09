
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor
CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor or {}

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetValidTargets(targets) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetActivateTargets(targets) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetAttachTransform(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetLocalAttachPoseOnSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable IXRHoverInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:IsHovering(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:IsSelecting(interactable) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:PreprocessInteractor(updatePhase) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:ProcessInteractor(updatePhase) end
  

  

  
  ---@param interactable IXRInteractable
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetInteractionStrength(interactable) end
  

  

  
  ---@param interactable IXRSelectInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartManualInteraction(interactable) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:EndManualInteraction() end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetHoverTargets(targets) end
  

  

  
  ---@param targets List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetValidTargets(targets) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CanHover(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CanSelect(interactable) end
  

  

  
  ---@param interactable XRBaseInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartManualInteraction(interactable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor:GetType() end
  

  
