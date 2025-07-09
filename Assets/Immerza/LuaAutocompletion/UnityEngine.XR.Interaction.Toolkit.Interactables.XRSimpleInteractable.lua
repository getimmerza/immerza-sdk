
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactables = CS.UnityEngine.XR.Interaction.Toolkit.Interactables or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable
CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable = CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable or {}

  
  ---@param interactor IXRInteractor
  ---@return Transform
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetAttachTransform(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Pose
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetLocalAttachPoseOnSelect(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param position Vector3
  ---@return DistanceInfo
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetDistance(position) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetInteractionStrength(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsSelectableBy(interactor) end
  

  

  
  ---@param interactor IXRHoverInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsHovered(interactor) end
  

  

  
  ---@param interactor IXRSelectInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsSelected(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  ---@return GameObject
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor IXRInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:RemoveCustomReticle(interactor) end
  

  

  
  ---@param updatePhase UpdatePhase
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:ProcessInteractable(updatePhase) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetDistanceSqrToInteractor(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:AttachCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:RemoveCustomReticle(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsHoverableBy(interactor) end
  

  

  
  ---@param interactor XRBaseInteractor
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsSelectableBy(interactor) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable:GetType() end
  

  
