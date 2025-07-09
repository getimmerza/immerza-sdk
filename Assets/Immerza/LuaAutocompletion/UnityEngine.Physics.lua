
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Physics
CS.UnityEngine.Physics = CS.UnityEngine.Physics or {}

  
  ---@param collider1 Collider---@param collider2 Collider---@param ignore Boolean
  
  
function CS.UnityEngine.Physics.IgnoreCollision(collider1, collider2, ignore) end
  

  

  
  ---@param collider1 Collider---@param collider2 Collider
  
  
function CS.UnityEngine.Physics.IgnoreCollision(collider1, collider2) end
  

  

  
  ---@param layer1 Int32---@param layer2 Int32---@param ignore Boolean
  
  
function CS.UnityEngine.Physics.IgnoreLayerCollision(layer1, layer2, ignore) end
  

  

  
  ---@param layer1 Int32---@param layer2 Int32
  
  
function CS.UnityEngine.Physics.IgnoreLayerCollision(layer1, layer2) end
  

  

  
  ---@param layer1 Int32---@param layer2 Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.GetIgnoreLayerCollision(layer1, layer2) end
  

  

  
  ---@param collider1 Collider---@param collider2 Collider
  ---@return Boolean
  
function CS.UnityEngine.Physics.GetIgnoreCollision(collider1, collider2) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, maxDistance) end
  

  

  
  ---@param origin Vector3---@param direction Vector3
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, hitInfo, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, hitInfo, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, hitInfo, maxDistance) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(origin, direction, hitInfo) end
  

  

  
  ---@param ray Ray---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, maxDistance) end
  

  

  
  ---@param ray Ray
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray) end
  

  

  
  ---@param ray Ray---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, hitInfo, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, hitInfo, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param hitInfo RaycastHit&---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, hitInfo, maxDistance) end
  

  

  
  ---@param ray Ray---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.Raycast(ray, hitInfo) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end, layerMask) end
  

  

  
  ---@param start Vector3---@param end Vector3
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param hitInfo RaycastHit&---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end, hitInfo, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param hitInfo RaycastHit&---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end, hitInfo, layerMask) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.Linecast(start, end, hitInfo) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, maxDistance) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, hitInfo, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, hitInfo, maxDistance, layerMask) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, hitInfo, maxDistance) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction, hitInfo) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(origin, radius, direction, hitInfo, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(origin, radius, direction, hitInfo, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(origin, radius, direction, hitInfo, maxDistance) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(origin, radius, direction, hitInfo) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, maxDistance) end
  

  

  
  ---@param ray Ray---@param radius Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius) end
  

  

  
  ---@param ray Ray---@param radius Single---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, hitInfo, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param radius Single---@param hitInfo RaycastHit&---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, hitInfo, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param radius Single---@param hitInfo RaycastHit&---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, hitInfo, maxDistance) end
  

  

  
  ---@param ray Ray---@param radius Single---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.SphereCast(ray, radius, hitInfo) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, hitInfo, orientation, maxDistance, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param orientation Quaternion---@param maxDistance Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, hitInfo, orientation, maxDistance) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param hitInfo RaycastHit&---@param orientation Quaternion
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, hitInfo, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param hitInfo RaycastHit&
  ---@return Boolean
  
function CS.UnityEngine.Physics.BoxCast(center, halfExtents, direction, hitInfo) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(origin, direction, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(origin, direction, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(origin, direction, maxDistance) end
  

  

  
  ---@param origin Vector3---@param direction Vector3
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(origin, direction) end
  

  

  
  ---@param ray Ray---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(ray, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(ray, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(ray, maxDistance) end
  

  

  
  ---@param ray Ray
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.RaycastAll(ray) end
  

  

  
  ---@param ray Ray---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param results RaycastHit[]---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(ray, results, maxDistance) end
  

  

  
  ---@param ray Ray---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(ray, results) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(origin, direction, results, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(origin, direction, results, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(origin, direction, results, maxDistance) end
  

  

  
  ---@param origin Vector3---@param direction Vector3---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.RaycastNonAlloc(origin, direction, results) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.CapsuleCastAll(point1, point2, radius, direction) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(origin, radius, direction, maxDistance) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(origin, radius, direction) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(ray, radius, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(ray, radius, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param radius Single---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(ray, radius, maxDistance) end
  

  

  
  ---@param ray Ray---@param radius Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.SphereCastAll(ray, radius) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapCapsule(point0, point1, radius, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single---@param layerMask Int32
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapCapsule(point0, point1, radius, layerMask) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapCapsule(point0, point1, radius) end
  

  

  
  ---@param position Vector3---@param radius Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapSphere(position, radius, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param position Vector3---@param radius Single---@param layerMask Int32
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapSphere(position, radius, layerMask) end
  

  

  
  ---@param position Vector3---@param radius Single
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapSphere(position, radius) end
  

  

  
  ---@param step Single
  
  
function CS.UnityEngine.Physics.Simulate(step) end
  

  

  
  
  
  
function CS.UnityEngine.Physics.SyncTransforms() end
  

  

  
  ---@param colliderA Collider---@param positionA Vector3---@param rotationA Quaternion---@param colliderB Collider---@param positionB Vector3---@param rotationB Quaternion---@param direction Vector3&---@param distance Single&
  ---@return Boolean
  
function CS.UnityEngine.Physics.ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, direction, distance) end
  

  

  
  ---@param point Vector3---@param collider Collider---@param position Vector3---@param rotation Quaternion
  ---@return Vector3
  
function CS.UnityEngine.Physics.ClosestPoint(point, collider, position, rotation) end
  

  

  
  ---@param position Vector3---@param radius Single---@param results Collider[]---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapSphereNonAlloc(position, radius, results, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param position Vector3---@param radius Single---@param results Collider[]---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapSphereNonAlloc(position, radius, results, layerMask) end
  

  

  
  ---@param position Vector3---@param radius Single---@param results Collider[]
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapSphereNonAlloc(position, radius, results) end
  

  

  
  ---@param position Vector3---@param radius Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckSphere(position, radius, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param position Vector3---@param radius Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckSphere(position, radius, layerMask) end
  

  

  
  ---@param position Vector3---@param radius Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckSphere(position, radius) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance) end
  

  

  
  ---@param point1 Vector3---@param point2 Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance) end
  

  

  
  ---@param origin Vector3---@param radius Single---@param direction Vector3---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(origin, radius, direction, results) end
  

  

  
  ---@param ray Ray---@param radius Single---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param ray Ray---@param radius Single---@param results RaycastHit[]---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask) end
  

  

  
  ---@param ray Ray---@param radius Single---@param results RaycastHit[]---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(ray, radius, results, maxDistance) end
  

  

  
  ---@param ray Ray---@param radius Single---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.SphereCastNonAlloc(ray, radius, results) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param radius Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckCapsule(start, end, radius, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param radius Single---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckCapsule(start, end, radius, layerMask) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param radius Single
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckCapsule(start, end, radius) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion---@param layermask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckBox(center, halfExtents, orientation, layermask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion---@param layerMask Int32
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckBox(center, halfExtents, orientation, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckBox(center, halfExtents, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3
  ---@return Boolean
  
function CS.UnityEngine.Physics.CheckBox(center, halfExtents) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapBox(center, halfExtents, orientation, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion---@param layerMask Int32
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapBox(center, halfExtents, orientation, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param orientation Quaternion
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapBox(center, halfExtents, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3
  ---@return Collider[]
  
function CS.UnityEngine.Physics.OverlapBox(center, halfExtents) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param results Collider[]---@param orientation Quaternion---@param mask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param results Collider[]---@param orientation Quaternion---@param mask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param results Collider[]---@param orientation Quaternion
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param results Collider[]
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapBoxNonAlloc(center, halfExtents, results) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param results RaycastHit[]---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param results RaycastHit[]---@param orientation Quaternion
  ---@return Int32
  
function CS.UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param results RaycastHit[]---@param orientation Quaternion---@param maxDistance Single
  ---@return Int32
  
function CS.UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param results RaycastHit[]---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param results RaycastHit[]
  ---@return Int32
  
function CS.UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single---@param layerMask Int32
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion---@param maxDistance Single
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3---@param orientation Quaternion
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.BoxCastAll(center, halfExtents, direction, orientation) end
  

  

  
  ---@param center Vector3---@param halfExtents Vector3---@param direction Vector3
  ---@return RaycastHit[]
  
function CS.UnityEngine.Physics.BoxCastAll(center, halfExtents, direction) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single---@param results Collider[]---@param layerMask Int32---@param queryTriggerInteraction QueryTriggerInteraction
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, queryTriggerInteraction) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single---@param results Collider[]---@param layerMask Int32
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask) end
  

  

  
  ---@param point0 Vector3---@param point1 Vector3---@param radius Single---@param results Collider[]
  ---@return Int32
  
function CS.UnityEngine.Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results) end
  

  

  
  ---@param meshID Int32---@param convex Boolean---@param cookingOptions MeshColliderCookingOptions
  
  
function CS.UnityEngine.Physics.BakeMesh(meshID, convex, cookingOptions) end
  

  

  
  ---@param meshID Int32---@param convex Boolean
  
  
function CS.UnityEngine.Physics.BakeMesh(meshID, convex) end
  

  

  
  ---@param worldBounds Bounds---@param subdivisions Int32
  
  
function CS.UnityEngine.Physics.RebuildBroadphaseRegions(worldBounds, subdivisions) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Physics:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Physics:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Physics:GetType() end
  

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Physics.ContactModifyEvent(op, callback) end

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Physics.ContactModifyEventCCD(op, callback) end

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Physics.ContactEvent(op, callback) end

  
