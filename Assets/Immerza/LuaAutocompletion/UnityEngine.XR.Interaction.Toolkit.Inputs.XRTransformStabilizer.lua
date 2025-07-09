
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Inputs = CS.UnityEngine.XR.Interaction.Toolkit.Inputs or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer
CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer = CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer or {}

  
  ---@param toStabilize Transform&---@param target Transform&---@param positionStabilization Single---@param angleStabilization Single---@param deltaTime Single---@param useLocalSpace Boolean
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization(toStabilize, target, positionStabilization, angleStabilization, deltaTime, useLocalSpace) end
  

  

  
  ---@param toStabilize Transform&---@param target Transform&---@param targetEndpoint float3&---@param positionStabilization Single---@param angleStabilization Single---@param deltaTime Single---@param useLocalSpace Boolean
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization(toStabilize, target, targetEndpoint, positionStabilization, angleStabilization, deltaTime, useLocalSpace) end
  

  

  
  ---@param toStabilize Transform&---@param target Transform&---@param aimTarget IXRRayProvider&---@param positionStabilization Single---@param angleStabilization Single---@param deltaTime Single---@param useLocalSpace Boolean
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.ApplyStabilization(toStabilize, target, aimTarget, positionStabilization, angleStabilization, deltaTime, useLocalSpace) end
  

  

  
  ---@param startPos float3&---@param startRot quaternion&---@param targetPos float3&---@param targetRot quaternion&---@param deltaTime Single---@param positionStabilization Single---@param angleStabilization Single---@param resultPos float3&---@param resultRot quaternion&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.StabilizeTransform$BurstManaged(startPos, startRot, targetPos, targetRot, deltaTime, positionStabilization, angleStabilization, resultPos, resultRot) end
  

  

  
  ---@param startPos float3&---@param targetPos float3&---@param deltaTime Single---@param positionStabilization Single---@param resultPos float3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.StabilizePosition$BurstManaged(startPos, targetPos, deltaTime, positionStabilization, resultPos) end
  

  

  
  ---@param startRot quaternion&---@param targetRot quaternion&---@param alternateStartRot quaternion&---@param deltaTime Single---@param angleStabilization Single---@param alternateStabilization Single---@param scaleFactor Single---@param resultRot quaternion&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.StabilizeOptimalRotation$BurstManaged(startRot, targetRot, alternateStartRot, deltaTime, angleStabilization, alternateStabilization, scaleFactor, resultRot) end
  

  

  
  ---@param distance Single---@param timeSlice Single
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.CalculateStabilizedLerp$BurstManaged(distance, timeSlice) end
  

  

  
  ---@param currentPosition float3&---@param resultPosition float3&---@param forward float3&---@param up float3&---@param rayEnd float3&---@param invScale Single---@param angleStabilization Single---@param antiRotation quaternion&---@param scaleFactor Single&---@param targetAngleScale Single&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer.CalculateRotationParams$BurstManaged(currentPosition, resultPosition, forward, up, rayEnd, invScale, angleStabilization, antiRotation, scaleFactor, targetAngleScale) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:IsInvoking() end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Inputs.XRTransformStabilizer:GetType() end
  

  
