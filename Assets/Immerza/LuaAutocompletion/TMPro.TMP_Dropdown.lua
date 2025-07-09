
CS.TMPro = CS.TMPro or {}
---@class CS.TMPro.TMP_Dropdown
CS.TMPro.TMP_Dropdown = CS.TMPro.TMP_Dropdown or {}

  
  ---@param input Int32
  
  
function CS.TMPro.TMP_Dropdown:SetValueWithoutNotify(input) end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:RefreshShownValue() end
  

  

  
  ---@param options List`1
  
  
function CS.TMPro.TMP_Dropdown:AddOptions(options) end
  

  

  
  ---@param options List`1
  
  
function CS.TMPro.TMP_Dropdown:AddOptions(options) end
  

  

  
  ---@param options List`1
  
  
function CS.TMPro.TMP_Dropdown:AddOptions(options) end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:ClearOptions() end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.TMPro.TMP_Dropdown:OnPointerClick(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.TMPro.TMP_Dropdown:OnSubmit(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.TMPro.TMP_Dropdown:OnCancel(eventData) end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:Show() end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:Hide() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:IsInteractable() end
  

  

  
  ---@param dir Vector3
  ---@return Selectable
  
function CS.TMPro.TMP_Dropdown:FindSelectable(dir) end
  

  

  
  
  ---@return Selectable
  
function CS.TMPro.TMP_Dropdown:FindSelectableOnLeft() end
  

  

  
  
  ---@return Selectable
  
function CS.TMPro.TMP_Dropdown:FindSelectableOnRight() end
  

  

  
  
  ---@return Selectable
  
function CS.TMPro.TMP_Dropdown:FindSelectableOnUp() end
  

  

  
  
  ---@return Selectable
  
function CS.TMPro.TMP_Dropdown:FindSelectableOnDown() end
  

  

  
  ---@param eventData AxisEventData
  
  
function CS.TMPro.TMP_Dropdown:OnMove(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.TMPro.TMP_Dropdown:OnPointerDown(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.TMPro.TMP_Dropdown:OnPointerUp(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.TMPro.TMP_Dropdown:OnPointerEnter(eventData) end
  

  

  
  ---@param eventData PointerEventData
  
  
function CS.TMPro.TMP_Dropdown:OnPointerExit(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.TMPro.TMP_Dropdown:OnSelect(eventData) end
  

  

  
  ---@param eventData BaseEventData
  
  
function CS.TMPro.TMP_Dropdown:OnDeselect(eventData) end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:Select() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:IsActive() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:IsDestroyed() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:IsInvoking() end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.TMPro.TMP_Dropdown:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.TMPro.TMP_Dropdown:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Dropdown:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.TMPro.TMP_Dropdown:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.TMPro.TMP_Dropdown:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.TMPro.TMP_Dropdown:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.TMPro.TMP_Dropdown:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.TMPro.TMP_Dropdown:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.TMPro.TMP_Dropdown:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Dropdown:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.TMPro.TMP_Dropdown:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Dropdown:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.TMPro.TMP_Dropdown:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Dropdown:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.TMPro.TMP_Dropdown:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.TMPro.TMP_Dropdown:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.TMPro.TMP_Dropdown:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Dropdown:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.TMPro.TMP_Dropdown:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Dropdown:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.TMPro.TMP_Dropdown:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.TMPro.TMP_Dropdown:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.TMPro.TMP_Dropdown:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Dropdown:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Dropdown:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.TMPro.TMP_Dropdown:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Dropdown:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.TMPro.TMP_Dropdown:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Dropdown:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.TMPro.TMP_Dropdown:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Dropdown:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Dropdown:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Dropdown:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Dropdown:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.TMPro.TMP_Dropdown:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.TMPro.TMP_Dropdown:ToString() end
  

  

  
  
  ---@return Type
  
function CS.TMPro.TMP_Dropdown:GetType() end
  

  
