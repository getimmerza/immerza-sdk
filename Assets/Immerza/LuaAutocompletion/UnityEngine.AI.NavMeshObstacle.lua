
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.AI = CS.UnityEngine.AI or {}
---@class CS.UnityEngine.AI.NavMeshObstacle
CS.UnityEngine.AI.NavMeshObstacle = CS.UnityEngine.AI.NavMeshObstacle or {}

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshObstacle:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshObstacle:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshObstacle:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshObstacle:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshObstacle:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.AI.NavMeshObstacle:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshObstacle:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshObstacle:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshObstacle:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshObstacle:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshObstacle:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AI.NavMeshObstacle:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AI.NavMeshObstacle:GetType() end
  

  
