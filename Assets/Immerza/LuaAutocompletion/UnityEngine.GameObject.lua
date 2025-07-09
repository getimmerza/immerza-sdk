
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.GameObject
CS.UnityEngine.GameObject = CS.UnityEngine.GameObject or {}

  
  ---@param type PrimitiveType
  ---@return GameObject
  
function CS.UnityEngine.GameObject.CreatePrimitive(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponent() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponent(type) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponent(type) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponentInChildren(type, includeInactive) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponentInChildren(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponentInChildren() end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponentInChildren(includeInactive) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponentInParent(type, includeInactive) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponentInParent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponentInParent() end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponentInParent(includeInactive) end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.GameObject:GetComponents(type) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.GameObject:GetComponents() end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.GameObject:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.GameObject:GetComponents(results) end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.GameObject:GetComponentsInChildren(type) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.GameObject:GetComponentsInChildren(type, includeInactive) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.GameObject:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.GameObject:GetComponentsInChildren(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.GameObject:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.GameObject:GetComponentsInChildren(results) end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.GameObject:GetComponentsInParent(type) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.GameObject:GetComponentsInParent(type, includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.GameObject:GetComponentsInParent(includeInactive, results) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.GameObject:GetComponentsInParent(includeInactive) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.GameObject:GetComponentsInParent() end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.GameObject:TryGetComponent(component) end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.GameObject:TryGetComponent(type, component) end
  

  

  
  ---@param tag String
  ---@return GameObject
  
function CS.UnityEngine.GameObject.FindWithTag(tag) end
  

  

  
  ---@param tag String---@param results List`1
  
  
function CS.UnityEngine.GameObject.FindGameObjectsWithTag(tag, results) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:BroadcastMessage(methodName, options) end
  

  

  
  ---@param componentType Type
  ---@return Component
  
function CS.UnityEngine.GameObject:AddComponent(componentType) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.GameObject:AddComponent() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.GameObject:GetComponentCount() end
  

  

  
  ---@param index Int32
  ---@return Component
  
function CS.UnityEngine.GameObject:GetComponentAtIndex(index) end
  

  

  
  ---@param index Int32
  ---@return T
  
function CS.UnityEngine.GameObject:GetComponentAtIndex(index) end
  

  

  
  ---@param component Component
  ---@return Int32
  
function CS.UnityEngine.GameObject:GetComponentIndex(component) end
  

  

  
  ---@param value Boolean
  
  
function CS.UnityEngine.GameObject:SetActive(value) end
  

  

  
  ---@param state Boolean
  
  
function CS.UnityEngine.GameObject:SetActiveRecursively(state) end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.GameObject:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.GameObject:CompareTag(tag) end
  

  

  
  ---@param tag String
  ---@return GameObject
  
function CS.UnityEngine.GameObject.FindGameObjectWithTag(tag) end
  

  

  
  ---@param tag String
  ---@return GameObject[]
  
function CS.UnityEngine.GameObject.FindGameObjectsWithTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.GameObject:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.GameObject:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.GameObject:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.GameObject:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.GameObject:BroadcastMessage(methodName) end
  

  

  
  ---@param name String
  ---@return GameObject
  
function CS.UnityEngine.GameObject.Find(name) end
  

  

  
  ---@param instanceIDs NativeArray`1---@param active Boolean
  
  
function CS.UnityEngine.GameObject.SetGameObjectsActive(instanceIDs, active) end
  

  

  
  ---@param instanceIDs ReadOnlySpan`1---@param active Boolean
  
  
function CS.UnityEngine.GameObject.SetGameObjectsActive(instanceIDs, active) end
  

  

  
  ---@param sourceInstanceID Int32---@param count Int32---@param newInstanceIDs NativeArray`1---@param newTransformInstanceIDs NativeArray`1---@param destinationScene Scene
  
  
function CS.UnityEngine.GameObject.InstantiateGameObjects(sourceInstanceID, count, newInstanceIDs, newTransformInstanceIDs, destinationScene) end
  

  

  
  ---@param instanceID Int32
  ---@return Scene
  
function CS.UnityEngine.GameObject.GetScene(instanceID) end
  

  

  
  ---@param clip Object---@param time Single
  
  
function CS.UnityEngine.GameObject:SampleAnimation(clip, time) end
  

  

  
  ---@param className String
  ---@return Component
  
function CS.UnityEngine.GameObject:AddComponent(className) end
  

  

  
  ---@param animation Object
  
  
function CS.UnityEngine.GameObject:PlayAnimation(animation) end
  

  

  
  
  
  
function CS.UnityEngine.GameObject:StopAnimation() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.GameObject:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.GameObject:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.GameObject:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.GameObject:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.GameObject:GetType() end
  

  
