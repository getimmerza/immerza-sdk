
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Object
CS.UnityEngine.Object = CS.UnityEngine.Object or {}

  
  
  ---@return Int32
  
function CS.UnityEngine.Object:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Object:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Object:Equals(other) end
  

  

  
  ---@param original T
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original) end
  

  

  
  ---@param original T---@param parent Transform
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, parent) end
  

  

  
  ---@param original T---@param position Vector3---@param rotation Quaternion
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, position, rotation) end
  

  

  
  ---@param original T---@param parent Transform---@param position Vector3---@param rotation Quaternion
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, parent, position, rotation) end
  

  

  
  ---@param original T---@param count Int32
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count) end
  

  

  
  ---@param original T---@param count Int32---@param parent Transform
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parent) end
  

  

  
  ---@param original T---@param count Int32---@param position Vector3---@param rotation Quaternion
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, position, rotation) end
  

  

  
  ---@param original T---@param count Int32---@param positions ReadOnlySpan`1---@param rotations ReadOnlySpan`1
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, positions, rotations) end
  

  

  
  ---@param original T---@param count Int32---@param parent Transform---@param position Vector3---@param rotation Quaternion
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parent, position, rotation) end
  

  

  
  ---@param original T---@param count Int32---@param parent Transform---@param position Vector3---@param rotation Quaternion---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parent, position, rotation, cancellationToken) end
  

  

  
  ---@param original T---@param count Int32---@param parent Transform---@param positions ReadOnlySpan`1---@param rotations ReadOnlySpan`1
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parent, positions, rotations) end
  

  

  
  ---@param original T---@param count Int32---@param parent Transform---@param positions ReadOnlySpan`1---@param rotations ReadOnlySpan`1---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parent, positions, rotations, cancellationToken) end
  

  

  
  ---@param original T---@param parameters InstantiateParameters---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, parameters, cancellationToken) end
  

  

  
  ---@param original T---@param count Int32---@param parameters InstantiateParameters---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, parameters, cancellationToken) end
  

  

  
  ---@param original T---@param position Vector3---@param rotation Quaternion---@param parameters InstantiateParameters---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, position, rotation, parameters, cancellationToken) end
  

  

  
  ---@param original T---@param count Int32---@param position Vector3---@param rotation Quaternion---@param parameters InstantiateParameters---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, position, rotation, parameters, cancellationToken) end
  

  

  
  ---@param original T---@param count Int32---@param positions ReadOnlySpan`1---@param rotations ReadOnlySpan`1---@param parameters InstantiateParameters---@param cancellationToken CancellationToken
  ---@return AsyncInstantiateOperation`1
  
function CS.UnityEngine.Object.InstantiateAsync(original, count, positions, rotations, parameters, cancellationToken) end
  

  

  
  ---@param original Object---@param position Vector3---@param rotation Quaternion
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original, position, rotation) end
  

  

  
  ---@param original Object---@param position Vector3---@param rotation Quaternion---@param parent Transform
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original, position, rotation, parent) end
  

  

  
  ---@param original Object
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original) end
  

  

  
  ---@param original Object---@param scene Scene
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original, scene) end
  

  

  
  ---@param original T---@param parameters InstantiateParameters
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, parameters) end
  

  

  
  ---@param original T---@param position Vector3---@param rotation Quaternion---@param parameters InstantiateParameters
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, position, rotation, parameters) end
  

  

  
  ---@param original Object---@param parent Transform
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original, parent) end
  

  

  
  ---@param original Object---@param parent Transform---@param instantiateInWorldSpace Boolean
  ---@return Object
  
function CS.UnityEngine.Object.Instantiate(original, parent, instantiateInWorldSpace) end
  

  

  
  ---@param original T
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original) end
  

  

  
  ---@param original T---@param position Vector3---@param rotation Quaternion
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, position, rotation) end
  

  

  
  ---@param original T---@param position Vector3---@param rotation Quaternion---@param parent Transform
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, position, rotation, parent) end
  

  

  
  ---@param original T---@param parent Transform
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, parent) end
  

  

  
  ---@param original T---@param parent Transform---@param worldPositionStays Boolean
  ---@return T
  
function CS.UnityEngine.Object.Instantiate(original, parent, worldPositionStays) end
  

  

  
  ---@param obj Object---@param t Single
  
  
function CS.UnityEngine.Object.Destroy(obj, t) end
  

  

  
  ---@param obj Object
  
  
function CS.UnityEngine.Object.Destroy(obj) end
  

  

  
  ---@param obj Object---@param allowDestroyingAssets Boolean
  
  
function CS.UnityEngine.Object.DestroyImmediate(obj, allowDestroyingAssets) end
  

  

  
  ---@param obj Object
  
  
function CS.UnityEngine.Object.DestroyImmediate(obj) end
  

  

  
  ---@param type Type
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsOfType(type) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsOfType(type, includeInactive) end
  

  

  
  ---@param type Type---@param sortMode FindObjectsSortMode
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsByType(type, sortMode) end
  

  

  
  ---@param type Type---@param findObjectsInactive FindObjectsInactive---@param sortMode FindObjectsSortMode
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsByType(type, findObjectsInactive, sortMode) end
  

  

  
  ---@param target Object
  
  
function CS.UnityEngine.Object.DontDestroyOnLoad(target) end
  

  

  
  ---@param obj Object---@param t Single
  
  
function CS.UnityEngine.Object.DestroyObject(obj, t) end
  

  

  
  ---@param obj Object
  
  
function CS.UnityEngine.Object.DestroyObject(obj) end
  

  

  
  ---@param type Type
  ---@return Object[]
  
function CS.UnityEngine.Object.FindSceneObjectsOfType(type) end
  

  

  
  ---@param type Type
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsOfTypeIncludingAssets(type) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Object.FindObjectsOfType() end
  

  

  
  ---@param sortMode FindObjectsSortMode
  ---@return T[]
  
function CS.UnityEngine.Object.FindObjectsByType(sortMode) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Object.FindObjectsOfType(includeInactive) end
  

  

  
  ---@param findObjectsInactive FindObjectsInactive---@param sortMode FindObjectsSortMode
  ---@return T[]
  
function CS.UnityEngine.Object.FindObjectsByType(findObjectsInactive, sortMode) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Object.FindObjectOfType() end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Object.FindObjectOfType(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Object.FindFirstObjectByType() end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Object.FindAnyObjectByType() end
  

  

  
  ---@param findObjectsInactive FindObjectsInactive
  ---@return T
  
function CS.UnityEngine.Object.FindFirstObjectByType(findObjectsInactive) end
  

  

  
  ---@param findObjectsInactive FindObjectsInactive
  ---@return T
  
function CS.UnityEngine.Object.FindAnyObjectByType(findObjectsInactive) end
  

  

  
  ---@param type Type
  ---@return Object[]
  
function CS.UnityEngine.Object.FindObjectsOfTypeAll(type) end
  

  

  
  ---@param type Type
  ---@return Object
  
function CS.UnityEngine.Object.FindObjectOfType(type) end
  

  

  
  ---@param type Type
  ---@return Object
  
function CS.UnityEngine.Object.FindFirstObjectByType(type) end
  

  

  
  ---@param type Type
  ---@return Object
  
function CS.UnityEngine.Object.FindAnyObjectByType(type) end
  

  

  
  ---@param type Type---@param includeInactive Boolean
  ---@return Object
  
function CS.UnityEngine.Object.FindObjectOfType(type, includeInactive) end
  

  

  
  ---@param type Type---@param findObjectsInactive FindObjectsInactive
  ---@return Object
  
function CS.UnityEngine.Object.FindFirstObjectByType(type, findObjectsInactive) end
  

  

  
  ---@param type Type---@param findObjectsInactive FindObjectsInactive
  ---@return Object
  
function CS.UnityEngine.Object.FindAnyObjectByType(type, findObjectsInactive) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Object:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Object:GetType() end
  

  
