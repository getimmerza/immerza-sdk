
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Transform
CS.UnityEngine.Transform = CS.UnityEngine.Transform or {}

  
  ---@param p Transform
  
  
function CS.UnityEngine.Transform:SetParent(p) end
  

  

  
  ---@param parent Transform---@param worldPositionStays Boolean
  
  
function CS.UnityEngine.Transform:SetParent(parent, worldPositionStays) end
  

  

  
  ---@param position Vector3---@param rotation Quaternion
  
  
function CS.UnityEngine.Transform:SetPositionAndRotation(position, rotation) end
  

  

  
  ---@param localPosition Vector3---@param localRotation Quaternion
  
  
function CS.UnityEngine.Transform:SetLocalPositionAndRotation(localPosition, localRotation) end
  

  

  
  ---@param position Vector3&---@param rotation Quaternion&
  
  
function CS.UnityEngine.Transform:GetPositionAndRotation(position, rotation) end
  

  

  
  ---@param localPosition Vector3&---@param localRotation Quaternion&
  
  
function CS.UnityEngine.Transform:GetLocalPositionAndRotation(localPosition, localRotation) end
  

  

  
  ---@param translation Vector3---@param relativeTo Space
  
  
function CS.UnityEngine.Transform:Translate(translation, relativeTo) end
  

  

  
  ---@param translation Vector3
  
  
function CS.UnityEngine.Transform:Translate(translation) end
  

  

  
  ---@param x Single---@param y Single---@param z Single---@param relativeTo Space
  
  
function CS.UnityEngine.Transform:Translate(x, y, z, relativeTo) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  
  
function CS.UnityEngine.Transform:Translate(x, y, z) end
  

  

  
  ---@param translation Vector3---@param relativeTo Transform
  
  
function CS.UnityEngine.Transform:Translate(translation, relativeTo) end
  

  

  
  ---@param x Single---@param y Single---@param z Single---@param relativeTo Transform
  
  
function CS.UnityEngine.Transform:Translate(x, y, z, relativeTo) end
  

  

  
  ---@param eulers Vector3---@param relativeTo Space
  
  
function CS.UnityEngine.Transform:Rotate(eulers, relativeTo) end
  

  

  
  ---@param eulers Vector3
  
  
function CS.UnityEngine.Transform:Rotate(eulers) end
  

  

  
  ---@param xAngle Single---@param yAngle Single---@param zAngle Single---@param relativeTo Space
  
  
function CS.UnityEngine.Transform:Rotate(xAngle, yAngle, zAngle, relativeTo) end
  

  

  
  ---@param xAngle Single---@param yAngle Single---@param zAngle Single
  
  
function CS.UnityEngine.Transform:Rotate(xAngle, yAngle, zAngle) end
  

  

  
  ---@param axis Vector3---@param angle Single---@param relativeTo Space
  
  
function CS.UnityEngine.Transform:Rotate(axis, angle, relativeTo) end
  

  

  
  ---@param axis Vector3---@param angle Single
  
  
function CS.UnityEngine.Transform:Rotate(axis, angle) end
  

  

  
  ---@param point Vector3---@param axis Vector3---@param angle Single
  
  
function CS.UnityEngine.Transform:RotateAround(point, axis, angle) end
  

  

  
  ---@param target Transform---@param worldUp Vector3
  
  
function CS.UnityEngine.Transform:LookAt(target, worldUp) end
  

  

  
  ---@param target Transform
  
  
function CS.UnityEngine.Transform:LookAt(target) end
  

  

  
  ---@param worldPosition Vector3---@param worldUp Vector3
  
  
function CS.UnityEngine.Transform:LookAt(worldPosition, worldUp) end
  

  

  
  ---@param worldPosition Vector3
  
  
function CS.UnityEngine.Transform:LookAt(worldPosition) end
  

  

  
  ---@param direction Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformDirection(direction) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformDirection(x, y, z) end
  

  

  
  ---@param directions ReadOnlySpan`1---@param transformedDirections Span`1
  
  
function CS.UnityEngine.Transform:TransformDirections(directions, transformedDirections) end
  

  

  
  ---@param directions Span`1
  
  
function CS.UnityEngine.Transform:TransformDirections(directions) end
  

  

  
  ---@param direction Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformDirection(direction) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformDirection(x, y, z) end
  

  

  
  ---@param directions ReadOnlySpan`1---@param transformedDirections Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformDirections(directions, transformedDirections) end
  

  

  
  ---@param directions Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformDirections(directions) end
  

  

  
  ---@param vector Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformVector(vector) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformVector(x, y, z) end
  

  

  
  ---@param vectors ReadOnlySpan`1---@param transformedVectors Span`1
  
  
function CS.UnityEngine.Transform:TransformVectors(vectors, transformedVectors) end
  

  

  
  ---@param vectors Span`1
  
  
function CS.UnityEngine.Transform:TransformVectors(vectors) end
  

  

  
  ---@param vector Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformVector(vector) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformVector(x, y, z) end
  

  

  
  ---@param vectors ReadOnlySpan`1---@param transformedVectors Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformVectors(vectors, transformedVectors) end
  

  

  
  ---@param vectors Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformVectors(vectors) end
  

  

  
  ---@param position Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformPoint(position) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:TransformPoint(x, y, z) end
  

  

  
  ---@param positions ReadOnlySpan`1---@param transformedPositions Span`1
  
  
function CS.UnityEngine.Transform:TransformPoints(positions, transformedPositions) end
  

  

  
  ---@param positions Span`1
  
  
function CS.UnityEngine.Transform:TransformPoints(positions) end
  

  

  
  ---@param position Vector3
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformPoint(position) end
  

  

  
  ---@param x Single---@param y Single---@param z Single
  ---@return Vector3
  
function CS.UnityEngine.Transform:InverseTransformPoint(x, y, z) end
  

  

  
  ---@param positions ReadOnlySpan`1---@param transformedPositions Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformPoints(positions, transformedPositions) end
  

  

  
  ---@param positions Span`1
  
  
function CS.UnityEngine.Transform:InverseTransformPoints(positions) end
  

  

  
  
  
  
function CS.UnityEngine.Transform:DetachChildren() end
  

  

  
  
  
  
function CS.UnityEngine.Transform:SetAsFirstSibling() end
  

  

  
  
  
  
function CS.UnityEngine.Transform:SetAsLastSibling() end
  

  

  
  ---@param index Int32
  
  
function CS.UnityEngine.Transform:SetSiblingIndex(index) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Transform:GetSiblingIndex() end
  

  

  
  ---@param n String
  ---@return Transform
  
function CS.UnityEngine.Transform:Find(n) end
  

  

  
  ---@param parent Transform
  ---@return Boolean
  
function CS.UnityEngine.Transform:IsChildOf(parent) end
  

  

  
  ---@param n String
  ---@return Transform
  
function CS.UnityEngine.Transform:FindChild(n) end
  

  

  
  
  ---@return IEnumerator
  
function CS.UnityEngine.Transform:GetEnumerator() end
  

  

  
  ---@param axis Vector3---@param angle Single
  
  
function CS.UnityEngine.Transform:RotateAround(axis, angle) end
  

  

  
  ---@param axis Vector3---@param angle Single
  
  
function CS.UnityEngine.Transform:RotateAroundLocal(axis, angle) end
  

  

  
  ---@param index Int32
  ---@return Transform
  
function CS.UnityEngine.Transform:GetChild(index) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Transform:GetChildCount() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Transform:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Transform:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Transform:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Transform:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Transform:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Transform:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Transform:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Transform:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Transform:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Transform:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Transform:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Transform:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Transform:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Transform:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Transform:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Transform:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Transform:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Transform:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Transform:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Transform:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Transform:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Transform:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Transform:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Transform:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Transform:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Transform:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Transform:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Transform:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Transform:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Transform:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Transform:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Transform:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Transform:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Transform:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Transform:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Transform:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Transform:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Transform:GetType() end
  

  
