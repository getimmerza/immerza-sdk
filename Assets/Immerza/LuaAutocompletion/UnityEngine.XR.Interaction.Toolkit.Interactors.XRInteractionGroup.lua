
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Interactors = CS.UnityEngine.XR.Interaction.Toolkit.Interactors or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup
CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup = CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup or {}

  
  ---@param sourceGroupMember Object---@param overrideGroupMember Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:AddStartingInteractionOverride(sourceGroupMember, overrideGroupMember) end
  

  

  
  ---@param sourceGroupMember Object---@param overrideGroupMember Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:RemoveStartingInteractionOverride(sourceGroupMember, overrideGroupMember) end
  

  

  
  ---@param groupMember IXRGroupMember
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:AddGroupMember(groupMember) end
  

  

  
  ---@param groupMember IXRGroupMember---@param newIndex Int32
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:MoveGroupMemberTo(groupMember, newIndex) end
  

  

  
  ---@param groupMember IXRGroupMember
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:RemoveGroupMember(groupMember) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:ClearGroupMembers() end
  

  

  
  ---@param groupMember IXRGroupMember
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:ContainsGroupMember(groupMember) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetGroupMembers(results) end
  

  

  
  ---@param group IXRInteractionGroup
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:HasDependencyOnGroup(group) end
  

  

  
  ---@param sourceGroupMember IXRGroupMember---@param overrideGroupMember IXRGroupMember
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:AddInteractionOverrideForGroupMember(sourceGroupMember, overrideGroupMember) end
  

  

  
  ---@param sourceGroupMember IXRGroupMember---@param potentialOverrideGroupMember IXRGroupMember
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GroupMemberIsPartOfOverrideChain(sourceGroupMember, potentialOverrideGroupMember) end
  

  

  
  ---@param sourceGroupMember IXRGroupMember---@param overrideGroupMember IXRGroupMember
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:RemoveInteractionOverrideForGroupMember(sourceGroupMember, overrideGroupMember) end
  

  

  
  ---@param sourceGroupMember IXRGroupMember
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:ClearInteractionOverridesForGroupMember(sourceGroupMember) end
  

  

  
  ---@param sourceGroupMember IXRGroupMember---@param results HashSet`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetInteractionOverridesForGroupMember(sourceGroupMember, results) end
  

  

  
  ---@param args FocusEnterEventArgs
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:OnFocusEntering(args) end
  

  

  
  ---@param args FocusExitEventArgs
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:OnFocusExiting(args) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractionGroup:GetType() end
  

  
