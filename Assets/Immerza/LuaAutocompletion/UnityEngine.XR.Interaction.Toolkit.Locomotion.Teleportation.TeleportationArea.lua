
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea
CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea or {}

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsSelectableBy(interactor) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:ProcessInteractable(updatePhase) end
  

  

  
  ---@param interactor IXRInteractor---@param hitNormal Vector3---@param reticleUp Vector3&---@param optionalReticleForward Nullable`1&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetReticleDirection(interactor, hitNormal, reticleUp, optionalReticleForward) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetAttachTransform(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetLocalAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param position Vector3
  ---@return DistanceInfo
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetDistance(position) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetInteractionStrength(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsHovered(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsSelected(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return GameObject
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsSelectableBy(interactor) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea:GetType() end
  

  
