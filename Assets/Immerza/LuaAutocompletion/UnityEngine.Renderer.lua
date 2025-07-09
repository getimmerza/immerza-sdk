
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Renderer
CS.UnityEngine.Renderer = CS.UnityEngine.Renderer or {}

  
  
  
  
function CS.UnityEngine.Renderer:ResetBounds() end
  

  

  
  
  
  
function CS.UnityEngine.Renderer:ResetLocalBounds() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.Renderer:HasPropertyBlock() end
  

  

  
  ---@param properties MaterialPropertyBlock
  
  
function CS.UnityEngine.Renderer:SetPropertyBlock(properties) end
  

  

  
  ---@param properties MaterialPropertyBlock---@param materialIndex Int32
  
  
function CS.UnityEngine.Renderer:SetPropertyBlock(properties, materialIndex) end
  

  

  
  ---@param properties MaterialPropertyBlock
  
  
function CS.UnityEngine.Renderer:GetPropertyBlock(properties) end
  

  

  
  ---@param properties MaterialPropertyBlock---@param materialIndex Int32
  
  
function CS.UnityEngine.Renderer:GetPropertyBlock(properties, materialIndex) end
  

  

  
  ---@param m List`1
  
  
function CS.UnityEngine.Renderer:GetMaterials(m) end
  

  

  
  ---@param materials List`1
  
  
function CS.UnityEngine.Renderer:SetSharedMaterials(materials) end
  

  

  
  ---@param materials List`1
  
  
function CS.UnityEngine.Renderer:SetMaterials(materials) end
  

  

  
  ---@param m List`1
  
  
function CS.UnityEngine.Renderer:GetSharedMaterials(m) end
  

  

  
  ---@param result List`1
  
  
function CS.UnityEngine.Renderer:GetClosestReflectionProbes(result) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Renderer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Renderer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Renderer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Renderer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Renderer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Renderer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Renderer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Renderer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Renderer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Renderer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Renderer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Renderer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Renderer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Renderer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Renderer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Renderer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Renderer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Renderer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Renderer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Renderer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Renderer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Renderer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Renderer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Renderer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Renderer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Renderer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Renderer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Renderer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Renderer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Renderer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Renderer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Renderer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Renderer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Renderer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Renderer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Renderer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Renderer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Renderer:GetType() end
  

  
