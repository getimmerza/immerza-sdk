
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.AI = CS.UnityEngine.AI or {}
---@class CS.UnityEngine.AI.NavMesh
CS.UnityEngine.AI.NavMesh = CS.UnityEngine.AI.NavMesh or {}

  
  ---@param sourcePosition Vector3---@param targetPosition Vector3---@param hit NavMeshHit&---@param areaMask Int32
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.Raycast(sourcePosition, targetPosition, hit, areaMask) end
  

  

  
  ---@param sourcePosition Vector3---@param targetPosition Vector3---@param areaMask Int32---@param path NavMeshPath
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.CalculatePath(sourcePosition, targetPosition, areaMask, path) end
  

  

  
  ---@param sourcePosition Vector3---@param hit NavMeshHit&---@param areaMask Int32
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.FindClosestEdge(sourcePosition, hit, areaMask) end
  

  

  
  ---@param sourcePosition Vector3---@param hit NavMeshHit&---@param maxDistance Single---@param areaMask Int32
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.SamplePosition(sourcePosition, hit, maxDistance, areaMask) end
  

  

  
  ---@param layer Int32---@param cost Single
  
  
function CS.UnityEngine.AI.NavMesh.SetLayerCost(layer, cost) end
  

  

  
  ---@param layer Int32
  ---@return Single
  
function CS.UnityEngine.AI.NavMesh.GetLayerCost(layer) end
  

  

  
  ---@param layerName String
  ---@return Int32
  
function CS.UnityEngine.AI.NavMesh.GetNavMeshLayerFromName(layerName) end
  

  

  
  ---@param areaIndex Int32---@param cost Single
  
  
function CS.UnityEngine.AI.NavMesh.SetAreaCost(areaIndex, cost) end
  

  

  
  ---@param areaIndex Int32
  ---@return Single
  
function CS.UnityEngine.AI.NavMesh.GetAreaCost(areaIndex) end
  

  

  
  ---@param areaName String
  ---@return Int32
  
function CS.UnityEngine.AI.NavMesh.GetAreaFromName(areaName) end
  

  

  
  
  ---@return String[]
  
function CS.UnityEngine.AI.NavMesh.GetAreaNames() end
  

  

  
  
  ---@return NavMeshTriangulation
  
function CS.UnityEngine.AI.NavMesh.CalculateTriangulation() end
  

  

  
  ---@param vertices Vector3[]&---@param indices Int32[]&
  
  
function CS.UnityEngine.AI.NavMesh.Triangulate(vertices, indices) end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMesh.AddOffMeshLinks() end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMesh.RestoreNavMesh() end
  

  

  
  ---@param navMeshData NavMeshData
  ---@return NavMeshDataInstance
  
function CS.UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData) end
  

  

  
  ---@param navMeshData NavMeshData---@param position Vector3---@param rotation Quaternion
  ---@return NavMeshDataInstance
  
function CS.UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData, position, rotation) end
  

  

  
  ---@param handle NavMeshDataInstance
  
  
function CS.UnityEngine.AI.NavMesh.RemoveNavMeshData(handle) end
  

  

  
  ---@param link NavMeshLinkData
  ---@return NavMeshLinkInstance
  
function CS.UnityEngine.AI.NavMesh.AddLink(link) end
  

  

  
  ---@param link NavMeshLinkData---@param position Vector3---@param rotation Quaternion
  ---@return NavMeshLinkInstance
  
function CS.UnityEngine.AI.NavMesh.AddLink(link, position, rotation) end
  

  

  
  ---@param handle NavMeshLinkInstance
  
  
function CS.UnityEngine.AI.NavMesh.RemoveLink(handle) end
  

  

  
  ---@param handle NavMeshLinkInstance
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.IsLinkActive(handle) end
  

  

  
  ---@param handle NavMeshLinkInstance---@param value Boolean
  
  
function CS.UnityEngine.AI.NavMesh.SetLinkActive(handle, value) end
  

  

  
  ---@param handle NavMeshLinkInstance
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.IsLinkOccupied(handle) end
  

  

  
  ---@param handle NavMeshLinkInstance
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.IsLinkValid(handle) end
  

  

  
  ---@param handle NavMeshLinkInstance
  ---@return Object
  
function CS.UnityEngine.AI.NavMesh.GetLinkOwner(handle) end
  

  

  
  ---@param handle NavMeshLinkInstance---@param owner Object
  
  
function CS.UnityEngine.AI.NavMesh.SetLinkOwner(handle, owner) end
  

  

  
  ---@param sourcePosition Vector3---@param hit NavMeshHit&---@param maxDistance Single---@param filter NavMeshQueryFilter
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.SamplePosition(sourcePosition, hit, maxDistance, filter) end
  

  

  
  ---@param sourcePosition Vector3---@param hit NavMeshHit&---@param filter NavMeshQueryFilter
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.FindClosestEdge(sourcePosition, hit, filter) end
  

  

  
  ---@param sourcePosition Vector3---@param targetPosition Vector3---@param hit NavMeshHit&---@param filter NavMeshQueryFilter
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.Raycast(sourcePosition, targetPosition, hit, filter) end
  

  

  
  ---@param sourcePosition Vector3---@param targetPosition Vector3---@param filter NavMeshQueryFilter---@param path NavMeshPath
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh.CalculatePath(sourcePosition, targetPosition, filter, path) end
  

  

  
  
  ---@return NavMeshBuildSettings
  
function CS.UnityEngine.AI.NavMesh.CreateSettings() end
  

  

  
  ---@param agentTypeID Int32
  
  
function CS.UnityEngine.AI.NavMesh.RemoveSettings(agentTypeID) end
  

  

  
  ---@param agentTypeID Int32
  ---@return NavMeshBuildSettings
  
function CS.UnityEngine.AI.NavMesh.GetSettingsByID(agentTypeID) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMesh.GetSettingsCount() end
  

  

  
  ---@param index Int32
  ---@return NavMeshBuildSettings
  
function CS.UnityEngine.AI.NavMesh.GetSettingsByIndex(index) end
  

  

  
  ---@param agentTypeID Int32
  ---@return String
  
function CS.UnityEngine.AI.NavMesh.GetSettingsNameFromID(agentTypeID) end
  

  

  
  
  
  
function CS.UnityEngine.AI.NavMesh.RemoveAllNavMeshData() end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.AI.NavMesh:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AI.NavMesh:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AI.NavMesh:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AI.NavMesh:ToString() end
  

  
