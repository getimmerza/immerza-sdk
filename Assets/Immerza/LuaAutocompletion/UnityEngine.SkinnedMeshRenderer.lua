
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.SkinnedMeshRenderer
CS.UnityEngine.SkinnedMeshRenderer = CS.UnityEngine.SkinnedMeshRenderer or {}

  
  ---@param index Int32
  ---@return Single
  
function CS.UnityEngine.SkinnedMeshRenderer:GetBlendShapeWeight(index) end
  

  

  
  ---@param index Int32---@param value Single
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SetBlendShapeWeight(index, value) end
  

  

  
  ---@param mesh Mesh
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BakeMesh(mesh) end
  

  

  
  ---@param mesh Mesh---@param useScale Boolean
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BakeMesh(mesh, useScale) end
  

  

  
  
  ---@return GraphicsBuffer
  
function CS.UnityEngine.SkinnedMeshRenderer:GetVertexBuffer() end
  

  

  
  
  ---@return GraphicsBuffer
  
function CS.UnityEngine.SkinnedMeshRenderer:GetPreviousVertexBuffer() end
  

  

  
  
  
  
function CS.UnityEngine.SkinnedMeshRenderer:ResetBounds() end
  

  

  
  
  
  
function CS.UnityEngine.SkinnedMeshRenderer:ResetLocalBounds() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:HasPropertyBlock() end
  

  

  
  ---@param properties MaterialPropertyBlock
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SetPropertyBlock(properties) end
  

  

  
  ---@param properties MaterialPropertyBlock---@param materialIndex Int32
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SetPropertyBlock(properties, materialIndex) end
  

  

  
  ---@param properties MaterialPropertyBlock
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetPropertyBlock(properties) end
  

  

  
  ---@param properties MaterialPropertyBlock---@param materialIndex Int32
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetPropertyBlock(properties, materialIndex) end
  

  

  
  ---@param m List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetMaterials(m) end
  

  

  
  ---@param materials List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SetSharedMaterials(materials) end
  

  

  
  ---@param materials List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SetMaterials(materials) end
  

  

  
  ---@param m List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetSharedMaterials(m) end
  

  

  
  ---@param result List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetClosestReflectionProbes(result) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.SkinnedMeshRenderer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.SkinnedMeshRenderer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.SkinnedMeshRenderer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.SkinnedMeshRenderer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.SkinnedMeshRenderer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.SkinnedMeshRenderer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.SkinnedMeshRenderer:GetType() end
  

  
