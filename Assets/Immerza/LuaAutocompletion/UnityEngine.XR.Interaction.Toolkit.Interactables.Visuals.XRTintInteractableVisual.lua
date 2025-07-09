
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactables = CS.UnityEngine.XR.Interaction.Toolkit.Interactables or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals = CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual
CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual = CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual or {}

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals.XRTintInteractableVisual:GetType() end
  

  
