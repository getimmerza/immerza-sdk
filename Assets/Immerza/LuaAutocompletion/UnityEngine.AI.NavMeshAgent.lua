
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.AI = CS.UnityEngine.AI or {}
---@class CS.UnityEngine.AI.NavMeshAgent
CS.UnityEngine.AI.NavMeshAgent = CS.UnityEngine.AI.NavMeshAgent or {}

  
  ---@param target Vector3
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:SetDestination(target) end
  

  

  
  ---@param activated Boolean
  
  
function CS.UnityEngine.AI.NavMeshAgent:ActivateCurrentOffMeshLink(activated) end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMeshAgent:CompleteOffMeshLink() end
  

  

  
  ---@param newPosition Vector3
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:Warp(newPosition) end
  

  

  
  ---@param offset Vector3
  
  
function CS.UnityEngine.AI.NavMeshAgent:Move(offset) end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMeshAgent:Stop() end
  

  

  
  ---@param stopUpdates Boolean
  
  
function CS.UnityEngine.AI.NavMeshAgent:Stop(stopUpdates) end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMeshAgent:Resume() end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMeshAgent:ResetPath() end
  

  

  
  ---@param path NavMeshPath
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:SetPath(path) end
  

  

  
  ---@param hit NavMeshHit&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:FindClosestEdge(hit) end
  

  

  
  ---@param targetPosition Vector3---@param hit NavMeshHit&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:Raycast(targetPosition, hit) end
  

  

  
  ---@param targetPosition Vector3---@param path NavMeshPath
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:CalculatePath(targetPosition, path) end
  

  

  
  ---@param areaMask Int32---@param maxDistance Single---@param hit NavMeshHit&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:SamplePathPosition(areaMask, maxDistance, hit) end
  

  

  
  ---@param layer Int32---@param cost Single
  
  
function CS.UnityEngine.AI.NavMeshAgent:SetLayerCost(layer, cost) end
  

  

  
  ---@param layer Int32
  ---@return Single
  
function CS.UnityEngine.AI.NavMeshAgent:GetLayerCost(layer) end
  

  

  
  ---@param areaIndex Int32---@param areaCost Single
  
  
function CS.UnityEngine.AI.NavMeshAgent:SetAreaCost(areaIndex, areaCost) end
  

  

  
  ---@param areaIndex Int32
  ---@return Single
  
function CS.UnityEngine.AI.NavMeshAgent:GetAreaCost(areaIndex) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshAgent:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.AI.NavMeshAgent:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AI.NavMeshAgent:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AI.NavMeshAgent:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshAgent:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMeshAgent:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMeshAgent:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AI.NavMeshAgent:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AI.NavMeshAgent:GetType() end
  

  
