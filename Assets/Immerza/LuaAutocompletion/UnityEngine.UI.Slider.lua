
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.UI = CS.UnityEngine.UI or {}
---@class CS.UnityEngine.UI.Slider
CS.UnityEngine.UI.Slider = CS.UnityEngine.UI.Slider or {}

  
  ---@param input Single
  
  
function CS.UnityEngine.UI.Slider:SetValueWithoutNotify(input) end
  

  

  
  ---@param executing CanvasUpdate
  
  
function CS.UnityEngine.UI.Slider:Rebuild(executing) end
  

  

  
  
  
  
function CS.UnityEngine.UI.Slider:LayoutComplete() end
  

  

  
  
  
  
function CS.UnityEngine.UI.Slider:GraphicUpdateComplete() end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnPointerDown(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnDrag(eventData) end
  

  

  
  ---@param eventData AxisEventData
  
  
function CS.UnityEngine.UI.Slider:OnMove(eventData) end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Slider:FindSelectableOnLeft() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Slider:FindSelectableOnRight() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Slider:FindSelectableOnUp() end
  

  

  
  
  ---@return Selectable
  
function CS.UnityEngine.UI.Slider:FindSelectableOnDown() end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnInitializePotentialDrag(eventData) end
  

  

  
  ---@param direction Direction---@param includeRectLayouts Boolean
  
  
function CS.UnityEngine.UI.Slider:SetDirection(direction, includeRectLayouts) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:IsInteractable() end
  

  

  
  ---@param dir Vector3
  ---@return Selectable
  
function CS.UnityEngine.UI.Slider:FindSelectable(dir) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnPointerUp(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnPointerEnter(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.UnityEngine.UI.Slider:OnPointerExit(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.UnityEngine.UI.Slider:OnSelect(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.UnityEngine.UI.Slider:OnDeselect(eventData) end
  

  

  
  
  
  
function CS.UnityEngine.UI.Slider:Select() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:IsActive() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:IsDestroyed() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.UI.Slider:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.UI.Slider:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.UI.Slider:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Slider:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.UI.Slider:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.UI.Slider:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.UI.Slider:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.UI.Slider:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.UI.Slider:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.UI.Slider:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Slider:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.UI.Slider:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Slider:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.UI.Slider:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Slider:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.UI.Slider:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.UI.Slider:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.UI.Slider:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.UI.Slider:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.UI.Slider:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Slider:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.UI.Slider:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.UI.Slider:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.UI.Slider:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.UI.Slider:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Slider:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.UI.Slider:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Slider:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.UI.Slider:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Slider:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.UI.Slider:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.UI.Slider:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.UI.Slider:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Slider:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.UI.Slider:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.UI.Slider:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.UI.Slider:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.UI.Slider:GetType() end
  

  
