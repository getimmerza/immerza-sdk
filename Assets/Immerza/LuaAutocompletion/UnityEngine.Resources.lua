
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Resources
CS.UnityEngine.Resources = CS.UnityEngine.Resources or {}

  
  ---@param type Type
  ---@return Object[]
  
function CS.UnityEngine.Resources.FindObjectsOfTypeAll(type) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Resources.FindObjectsOfTypeAll() end
  

  

  
  ---@param path String
  ---@return Object
  
function CS.UnityEngine.Resources.Load(path) end
  

  

  
  ---@param path String
  ---@return T
  
function CS.UnityEngine.Resources.Load(path) end
  

  

  
  ---@param path String---@param systemTypeInstance Type
  ---@return Object
  
function CS.UnityEngine.Resources.Load(path, systemTypeInstance) end
  

  

  
  ---@param path String
  ---@return ResourceRequest
  
function CS.UnityEngine.Resources.LoadAsync(path) end
  

  

  
  ---@param path String
  ---@return ResourceRequest
  
function CS.UnityEngine.Resources.LoadAsync(path) end
  

  

  
  ---@param path String---@param type Type
  ---@return ResourceRequest
  
function CS.UnityEngine.Resources.LoadAsync(path, type) end
  

  

  
  ---@param path String---@param systemTypeInstance Type
  ---@return Object[]
  
function CS.UnityEngine.Resources.LoadAll(path, systemTypeInstance) end
  

  

  
  ---@param path String
  ---@return Object[]
  
function CS.UnityEngine.Resources.LoadAll(path) end
  

  

  
  ---@param path String
  ---@return T[]
  
function CS.UnityEngine.Resources.LoadAll(path) end
  

  

  
  ---@param type Type---@param path String
  ---@return Object
  
function CS.UnityEngine.Resources.GetBuiltinResource(type, path) end
  

  

  
  ---@param path String
  ---@return T
  
function CS.UnityEngine.Resources.GetBuiltinResource(path) end
  

  

  
  ---@param assetToUnload Object
  
  
function CS.UnityEngine.Resources.UnloadAsset(assetToUnload) end
  

  

  
  
  ---@return AsyncOperation
  
function CS.UnityEngine.Resources.UnloadUnusedAssets() end
  

  

  
  ---@param instanceID Int32
  ---@return Object
  
function CS.UnityEngine.Resources.InstanceIDToObject(instanceID) end
  

  

  
  ---@param instanceIDs NativeArray`1---@param objects List`1
  
  
function CS.UnityEngine.Resources.InstanceIDToObjectList(instanceIDs, objects) end
  

  

  
  ---@param instanceId Int32
  ---@return Boolean
  
function CS.UnityEngine.Resources.InstanceIDIsValid(instanceId) end
  

  

  
  ---@param instanceIDs NativeArray`1---@param validArray NativeArray`1
  
  
function CS.UnityEngine.Resources.InstanceIDsToValidArray(instanceIDs, validArray) end
  

  

  
  ---@param instanceIDs ReadOnlySpan`1---@param validArray Span`1
  
  
function CS.UnityEngine.Resources.InstanceIDsToValidArray(instanceIDs, validArray) end
  

  

  
  ---@param assetPath String---@param type Type
  ---@return Object
  
function CS.UnityEngine.Resources.LoadAssetAtPath(assetPath, type) end
  

  

  
  ---@param assetPath String
  ---@return T
  
function CS.UnityEngine.Resources.LoadAssetAtPath(assetPath) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Resources:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Resources:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Resources:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Resources:ToString() end
  

  
