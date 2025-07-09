
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion or {}CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable
CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable = CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable or {}

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsSelectableBy(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetAttachTransform(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetLocalAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param position Vector3
  ---@return DistanceInfo
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetDistance(position) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetInteractionStrength(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsHovered(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsSelected(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return GameObject
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:RemoveCustomReticle(interactor) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:ProcessInteractable(updatePhase) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsSelectableBy(interactor) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable:GetType() end
  

  
