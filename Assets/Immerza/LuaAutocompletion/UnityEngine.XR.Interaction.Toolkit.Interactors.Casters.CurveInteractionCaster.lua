
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster or {}

  
  ---@param interactionManager XRInteractionManager---@param targets List`1
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:TryGetColliderTargets(interactionManager, targets) end
  

  

  
  ---@param interactionManager XRInteractionManager---@param targets List`1---@param raycastHits List`1
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:TryGetColliderTargets(interactionManager, targets, raycastHits) end
  

  

  
  ---@param uiModel TrackedDeviceModel&---@param isSelectActive Boolean---@param scrollDelta Vector2&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:UpdateUIModel(uiModel, isSelectActive, scrollDelta) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.Casters.CurveInteractionCaster:GetType() end
  

  
