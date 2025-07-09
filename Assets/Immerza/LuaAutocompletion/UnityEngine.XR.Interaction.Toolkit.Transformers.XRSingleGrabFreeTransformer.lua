
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Transformers = CS.UnityEngine.XR.Interaction.Toolkit.Transformers or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer
CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer = CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer or {}

  
  ---@param grabInteractable XRGrabInteractable---@param updatePhase UpdatePhase---@param targetPose Pose&---@param localScale Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:Process(grabInteractable, updatePhase, targetPose, localScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:OnLink(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:OnGrab(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable---@param targetPose Pose---@param localScale Vector3
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:OnGrabCountChanged(grabInteractable, targetPose, localScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:OnUnlink(grabInteractable) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer:GetType() end
  

  
