
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor
CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor or {}

  
  ---@param interactor IXRInteractor
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetAttachTransform(interactor) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:RequestTeleport() end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:ProcessInteractable(updatePhase) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsSelectableBy(interactor) end
  

  

  
  ---@param interactor IXRInteractor---@param hitNormal Vector3---@param reticleUp Vector3&---@param optionalReticleForward Nullable`1&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetReticleDirection(interactor, hitNormal, reticleUp, optionalReticleForward) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetLocalAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param position Vector3
  ---@return DistanceInfo
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetDistance(position) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetInteractionStrength(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsHovered(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsSelected(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return GameObject
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsSelectableBy(interactor) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationAnchor:GetType() end
  

  
