
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Light
CS.UnityEngine.Light = CS.UnityEngine.Light or {}

  
  
  
  
function CS.UnityEngine.Light:Reset() end
  

  

  
  
  
  
function CS.UnityEngine.Light:SetLightDirty() end
  

  

  
  ---@param evt LightEvent---@param buffer CommandBuffer
  
  
function CS.UnityEngine.Light:AddCommandBuffer(evt, buffer) end
  

  

  
  ---@param evt LightEvent---@param buffer CommandBuffer---@param shadowPassMask ShadowMapPass
  
  
function CS.UnityEngine.Light:AddCommandBuffer(evt, buffer, shadowPassMask) end
  

  

  
  ---@param evt LightEvent---@param buffer CommandBuffer---@param queueType ComputeQueueType
  
  
function CS.UnityEngine.Light:AddCommandBufferAsync(evt, buffer, queueType) end
  

  

  
  ---@param evt LightEvent---@param buffer CommandBuffer---@param shadowPassMask ShadowMapPass---@param queueType ComputeQueueType
  
  
function CS.UnityEngine.Light:AddCommandBufferAsync(evt, buffer, shadowPassMask, queueType) end
  

  

  
  ---@param evt LightEvent---@param buffer CommandBuffer
  
  
function CS.UnityEngine.Light:RemoveCommandBuffer(evt, buffer) end
  

  

  
  ---@param evt LightEvent
  
  
function CS.UnityEngine.Light:RemoveCommandBuffers(evt) end
  

  

  
  
  
  
function CS.UnityEngine.Light:RemoveAllCommandBuffers() end
  

  

  
  ---@param evt LightEvent
  ---@return CommandBuffer[]
  
function CS.UnityEngine.Light:GetCommandBuffers(evt) end
  

  

  
  ---@param type LightType---@param layer Int32
  ---@return Light[]
  
function CS.UnityEngine.Light.GetLights(type, layer) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Light:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Light:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Light:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Light:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Light:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Light:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Light:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Light:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Light:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Light:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Light:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Light:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Light:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Light:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Light:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Light:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Light:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Light:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Light:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Light:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Light:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Light:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Light:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Light:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Light:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Light:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Light:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Light:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Light:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Light:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Light:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Light:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Light:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Light:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Light:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Light:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Light:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Light:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Light:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Light:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Light:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Light:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Light:GetType() end
  

  
