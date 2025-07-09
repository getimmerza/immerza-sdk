
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.UI = CS.UnityEngine.UI or {}
---@class CS.UnityEngine.UI.Button
CS.UnityEngine.UI.Button = CS.UnityEngine.UI.Button or {}

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Button:OnPointerClick(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.UnityEngine.UI.Button:OnSubmit(eventData) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:IsInteractable() end
  

  

  
  ---@param dir Vector3
  ---@return Selectable
  
function CS.UnityEngine.UI.Button:FindSelectable(dir) end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Button:FindSelectableOnLeft() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Button:FindSelectableOnRight() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Button:FindSelectableOnUp() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Button:FindSelectableOnDown() end
  

  

  
  ---@param eventData AxisEventData
  
  
function CS.UnityEngine.UI.Button:OnMove(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Button:OnPointerDown(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Button:OnPointerUp(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Button:OnPointerEnter(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Button:OnPointerExit(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.UnityEngine.UI.Button:OnSelect(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.UnityEngine.UI.Button:OnDeselect(eventData) end
  

  

  
  
  
  
function CS.UnityEngine.UI.Button:Select() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:IsActive() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:IsDestroyed() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.UI.Button:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.UI.Button:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.UI.Button:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Button:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.UI.Button:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.UI.Button:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.UI.Button:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.UI.Button:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.UI.Button:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.UI.Button:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Button:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.UI.Button:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Button:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.UI.Button:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Button:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.UI.Button:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.UI.Button:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.UI.Button:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Button:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.UI.Button:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Button:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.UI.Button:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.UI.Button:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Button:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Button:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.UI.Button:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.UI.Button:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Button:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Button:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.UI.Button:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Button:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.UI.Button:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Button:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.UI.Button:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Button:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Button:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Button:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Button:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.UI.Button:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.UI.Button:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.UI.Button:GetType() end
  

  
