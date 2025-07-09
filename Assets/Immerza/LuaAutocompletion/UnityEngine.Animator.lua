
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Animator
CS.UnityEngine.Animator = CS.UnityEngine.Animator or {}

  
  ---@param layerIndex Int32
  ---@return AnimationInfo[]
  
function CS.UnityEngine.Animator:GetCurrentAnimationClipState(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimationInfo[]
  
function CS.UnityEngine.Animator:GetNextAnimationClipState(layerIndex) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:Stop() end
  

  

  
  ---@param name String
  ---@return Single
  
function CS.UnityEngine.Animator:GetFloat(name) end
  

  

  
  ---@param id Int32
  ---@return Single
  
function CS.UnityEngine.Animator:GetFloat(id) end
  

  

  
  ---@param name String---@param value Single
  
  
function CS.UnityEngine.Animator:SetFloat(name, value) end
  

  

  
  ---@param name String---@param value Single---@param dampTime Single---@param deltaTime Single
  
  
function CS.UnityEngine.Animator:SetFloat(name, value, dampTime, deltaTime) end
  

  

  
  ---@param id Int32---@param value Single
  
  
function CS.UnityEngine.Animator:SetFloat(id, value) end
  

  

  
  ---@param id Int32---@param value Single---@param dampTime Single---@param deltaTime Single
  
  
function CS.UnityEngine.Animator:SetFloat(id, value, dampTime, deltaTime) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Animator:GetBool(name) end
  

  

  
  ---@param id Int32
  ---@return Boolean
  
function CS.UnityEngine.Animator:GetBool(id) end
  

  

  
  ---@param name String---@param value Boolean
  
  
function CS.UnityEngine.Animator:SetBool(name, value) end
  

  

  
  ---@param id Int32---@param value Boolean
  
  
function CS.UnityEngine.Animator:SetBool(id, value) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.Animator:GetInteger(name) end
  

  

  
  ---@param id Int32
  ---@return Int32
  
function CS.UnityEngine.Animator:GetInteger(id) end
  

  

  
  ---@param name String---@param value Int32
  
  
function CS.UnityEngine.Animator:SetInteger(name, value) end
  

  

  
  ---@param id Int32---@param value Int32
  
  
function CS.UnityEngine.Animator:SetInteger(id, value) end
  

  

  
  ---@param name String
  
  
function CS.UnityEngine.Animator:SetTrigger(name) end
  

  

  
  ---@param id Int32
  
  
function CS.UnityEngine.Animator:SetTrigger(id) end
  

  

  
  ---@param name String
  
  
function CS.UnityEngine.Animator:ResetTrigger(name) end
  

  

  
  ---@param id Int32
  
  
function CS.UnityEngine.Animator:ResetTrigger(id) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Animator:IsParameterControlledByCurve(name) end
  

  

  
  ---@param id Int32
  ---@return Boolean
  
function CS.UnityEngine.Animator:IsParameterControlledByCurve(id) end
  

  

  
  ---@param goal AvatarIKGoal
  ---@return Vector3
  
function CS.UnityEngine.Animator:GetIKPosition(goal) end
  

  

  
  ---@param goal AvatarIKGoal---@param goalPosition Vector3
  
  
function CS.UnityEngine.Animator:SetIKPosition(goal, goalPosition) end
  

  

  
  ---@param goal AvatarIKGoal
  ---@return Quaternion
  
function CS.UnityEngine.Animator:GetIKRotation(goal) end
  

  

  
  ---@param goal AvatarIKGoal---@param goalRotation Quaternion
  
  
function CS.UnityEngine.Animator:SetIKRotation(goal, goalRotation) end
  

  

  
  ---@param goal AvatarIKGoal
  ---@return Single
  
function CS.UnityEngine.Animator:GetIKPositionWeight(goal) end
  

  

  
  ---@param goal AvatarIKGoal---@param value Single
  
  
function CS.UnityEngine.Animator:SetIKPositionWeight(goal, value) end
  

  

  
  ---@param goal AvatarIKGoal
  ---@return Single
  
function CS.UnityEngine.Animator:GetIKRotationWeight(goal) end
  

  

  
  ---@param goal AvatarIKGoal---@param value Single
  
  
function CS.UnityEngine.Animator:SetIKRotationWeight(goal, value) end
  

  

  
  ---@param hint AvatarIKHint
  ---@return Vector3
  
function CS.UnityEngine.Animator:GetIKHintPosition(hint) end
  

  

  
  ---@param hint AvatarIKHint---@param hintPosition Vector3
  
  
function CS.UnityEngine.Animator:SetIKHintPosition(hint, hintPosition) end
  

  

  
  ---@param hint AvatarIKHint
  ---@return Single
  
function CS.UnityEngine.Animator:GetIKHintPositionWeight(hint) end
  

  

  
  ---@param hint AvatarIKHint---@param value Single
  
  
function CS.UnityEngine.Animator:SetIKHintPositionWeight(hint, value) end
  

  

  
  ---@param lookAtPosition Vector3
  
  
function CS.UnityEngine.Animator:SetLookAtPosition(lookAtPosition) end
  

  

  
  ---@param weight Single
  
  
function CS.UnityEngine.Animator:SetLookAtWeight(weight) end
  

  

  
  ---@param weight Single---@param bodyWeight Single
  
  
function CS.UnityEngine.Animator:SetLookAtWeight(weight, bodyWeight) end
  

  

  
  ---@param weight Single---@param bodyWeight Single---@param headWeight Single
  
  
function CS.UnityEngine.Animator:SetLookAtWeight(weight, bodyWeight, headWeight) end
  

  

  
  ---@param weight Single---@param bodyWeight Single---@param headWeight Single---@param eyesWeight Single
  
  
function CS.UnityEngine.Animator:SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight) end
  

  

  
  ---@param weight Single---@param bodyWeight Single---@param headWeight Single---@param eyesWeight Single---@param clampWeight Single
  
  
function CS.UnityEngine.Animator:SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight) end
  

  

  
  ---@param humanBoneId HumanBodyBones---@param rotation Quaternion
  
  
function CS.UnityEngine.Animator:SetBoneLocalRotation(humanBoneId, rotation) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Animator:GetBehaviour() end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Animator:GetBehaviours() end
  

  

  
  ---@param fullPathHash Int32---@param layerIndex Int32
  ---@return StateMachineBehaviour[]
  
function CS.UnityEngine.Animator:GetBehaviours(fullPathHash, layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return String
  
function CS.UnityEngine.Animator:GetLayerName(layerIndex) end
  

  

  
  ---@param layerName String
  ---@return Int32
  
function CS.UnityEngine.Animator:GetLayerIndex(layerName) end
  

  

  
  ---@param layerIndex Int32
  ---@return Single
  
function CS.UnityEngine.Animator:GetLayerWeight(layerIndex) end
  

  

  
  ---@param layerIndex Int32---@param weight Single
  
  
function CS.UnityEngine.Animator:SetLayerWeight(layerIndex, weight) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimatorStateInfo
  
function CS.UnityEngine.Animator:GetCurrentAnimatorStateInfo(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimatorStateInfo
  
function CS.UnityEngine.Animator:GetNextAnimatorStateInfo(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimatorTransitionInfo
  
function CS.UnityEngine.Animator:GetAnimatorTransitionInfo(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return Int32
  
function CS.UnityEngine.Animator:GetCurrentAnimatorClipInfoCount(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return Int32
  
function CS.UnityEngine.Animator:GetNextAnimatorClipInfoCount(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimatorClipInfo[]
  
function CS.UnityEngine.Animator:GetCurrentAnimatorClipInfo(layerIndex) end
  

  

  
  ---@param layerIndex Int32
  ---@return AnimatorClipInfo[]
  
function CS.UnityEngine.Animator:GetNextAnimatorClipInfo(layerIndex) end
  

  

  
  ---@param layerIndex Int32---@param clips List`1
  
  
function CS.UnityEngine.Animator:GetCurrentAnimatorClipInfo(layerIndex, clips) end
  

  

  
  ---@param layerIndex Int32---@param clips List`1
  
  
function CS.UnityEngine.Animator:GetNextAnimatorClipInfo(layerIndex, clips) end
  

  

  
  ---@param layerIndex Int32
  ---@return Boolean
  
function CS.UnityEngine.Animator:IsInTransition(layerIndex) end
  

  

  
  ---@param index Int32
  ---@return AnimatorControllerParameter
  
function CS.UnityEngine.Animator:GetParameter(index) end
  

  

  
  ---@param matchPosition Vector3---@param matchRotation Quaternion---@param targetBodyPart AvatarTarget---@param weightMask MatchTargetWeightMask---@param startNormalizedTime Single
  
  
function CS.UnityEngine.Animator:MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime) end
  

  

  
  ---@param matchPosition Vector3---@param matchRotation Quaternion---@param targetBodyPart AvatarTarget---@param weightMask MatchTargetWeightMask---@param startNormalizedTime Single---@param targetNormalizedTime Single
  
  
function CS.UnityEngine.Animator:MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime) end
  

  

  
  ---@param matchPosition Vector3---@param matchRotation Quaternion---@param targetBodyPart AvatarTarget---@param weightMask MatchTargetWeightMask---@param startNormalizedTime Single---@param targetNormalizedTime Single---@param completeMatch Boolean
  
  
function CS.UnityEngine.Animator:MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime, completeMatch) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:InterruptMatchTarget() end
  

  

  
  ---@param completeMatch Boolean
  
  
function CS.UnityEngine.Animator:InterruptMatchTarget(completeMatch) end
  

  

  
  ---@param normalizedTime Single
  
  
function CS.UnityEngine.Animator:ForceStateNormalizedTime(normalizedTime) end
  

  

  
  ---@param stateName String---@param fixedTransitionDuration Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateName, fixedTransitionDuration) end
  

  

  
  ---@param stateName String---@param fixedTransitionDuration Single---@param layer Int32
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer) end
  

  

  
  ---@param stateName String---@param fixedTransitionDuration Single---@param layer Int32---@param fixedTimeOffset Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset) end
  

  

  
  ---@param stateName String---@param fixedTransitionDuration Single---@param layer Int32---@param fixedTimeOffset Single---@param normalizedTransitionTime Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime) end
  

  

  
  ---@param stateHashName Int32---@param fixedTransitionDuration Single---@param layer Int32---@param fixedTimeOffset Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset) end
  

  

  
  ---@param stateHashName Int32---@param fixedTransitionDuration Single---@param layer Int32
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer) end
  

  

  
  ---@param stateHashName Int32---@param fixedTransitionDuration Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateHashName, fixedTransitionDuration) end
  

  

  
  ---@param stateHashName Int32---@param fixedTransitionDuration Single---@param layer Int32---@param fixedTimeOffset Single---@param normalizedTransitionTime Single
  
  
function CS.UnityEngine.Animator:CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:WriteDefaultValues() end
  

  

  
  ---@param stateName String---@param normalizedTransitionDuration Single---@param layer Int32---@param normalizedTimeOffset Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset) end
  

  

  
  ---@param stateName String---@param normalizedTransitionDuration Single---@param layer Int32
  
  
function CS.UnityEngine.Animator:CrossFade(stateName, normalizedTransitionDuration, layer) end
  

  

  
  ---@param stateName String---@param normalizedTransitionDuration Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateName, normalizedTransitionDuration) end
  

  

  
  ---@param stateName String---@param normalizedTransitionDuration Single---@param layer Int32---@param normalizedTimeOffset Single---@param normalizedTransitionTime Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime) end
  

  

  
  ---@param stateHashName Int32---@param normalizedTransitionDuration Single---@param layer Int32---@param normalizedTimeOffset Single---@param normalizedTransitionTime Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime) end
  

  

  
  ---@param stateHashName Int32---@param normalizedTransitionDuration Single---@param layer Int32---@param normalizedTimeOffset Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset) end
  

  

  
  ---@param stateHashName Int32---@param normalizedTransitionDuration Single---@param layer Int32
  
  
function CS.UnityEngine.Animator:CrossFade(stateHashName, normalizedTransitionDuration, layer) end
  

  

  
  ---@param stateHashName Int32---@param normalizedTransitionDuration Single
  
  
function CS.UnityEngine.Animator:CrossFade(stateHashName, normalizedTransitionDuration) end
  

  

  
  ---@param stateName String---@param layer Int32
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateName, layer) end
  

  

  
  ---@param stateName String
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateName) end
  

  

  
  ---@param stateName String---@param layer Int32---@param fixedTime Single
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateName, layer, fixedTime) end
  

  

  
  ---@param stateNameHash Int32---@param layer Int32---@param fixedTime Single
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateNameHash, layer, fixedTime) end
  

  

  
  ---@param stateNameHash Int32---@param layer Int32
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateNameHash, layer) end
  

  

  
  ---@param stateNameHash Int32
  
  
function CS.UnityEngine.Animator:PlayInFixedTime(stateNameHash) end
  

  

  
  ---@param stateName String---@param layer Int32
  
  
function CS.UnityEngine.Animator:Play(stateName, layer) end
  

  

  
  ---@param stateName String
  
  
function CS.UnityEngine.Animator:Play(stateName) end
  

  

  
  ---@param stateName String---@param layer Int32---@param normalizedTime Single
  
  
function CS.UnityEngine.Animator:Play(stateName, layer, normalizedTime) end
  

  

  
  ---@param stateNameHash Int32---@param layer Int32---@param normalizedTime Single
  
  
function CS.UnityEngine.Animator:Play(stateNameHash, layer, normalizedTime) end
  

  

  
  ---@param stateNameHash Int32---@param layer Int32
  
  
function CS.UnityEngine.Animator:Play(stateNameHash, layer) end
  

  

  
  ---@param stateNameHash Int32
  
  
function CS.UnityEngine.Animator:Play(stateNameHash) end
  

  

  
  ---@param targetIndex AvatarTarget---@param targetNormalizedTime Single
  
  
function CS.UnityEngine.Animator:SetTarget(targetIndex, targetNormalizedTime) end
  

  

  
  ---@param transform Transform
  ---@return Boolean
  
function CS.UnityEngine.Animator:IsControlled(transform) end
  

  

  
  ---@param humanBoneId HumanBodyBones
  ---@return Transform
  
function CS.UnityEngine.Animator:GetBoneTransform(humanBoneId) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:StartPlayback() end
  

  

  
  
  
  
function CS.UnityEngine.Animator:StopPlayback() end
  

  

  
  ---@param frameCount Int32
  
  
function CS.UnityEngine.Animator:StartRecording(frameCount) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:StopRecording() end
  

  

  
  ---@param layerIndex Int32---@param stateID Int32
  ---@return Boolean
  
function CS.UnityEngine.Animator:HasState(layerIndex, stateID) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.Animator.StringToHash(name) end
  

  

  
  ---@param deltaTime Single
  
  
function CS.UnityEngine.Animator:Update(deltaTime) end
  

  

  
  
  
  
function CS.UnityEngine.Animator:Rebind() end
  

  

  
  
  
  
function CS.UnityEngine.Animator:ApplyBuiltinRootMotion() end
  

  

  
  ---@param name String
  ---@return Vector3
  
function CS.UnityEngine.Animator:GetVector(name) end
  

  

  
  ---@param id Int32
  ---@return Vector3
  
function CS.UnityEngine.Animator:GetVector(id) end
  

  

  
  ---@param name String---@param value Vector3
  
  
function CS.UnityEngine.Animator:SetVector(name, value) end
  

  

  
  ---@param id Int32---@param value Vector3
  
  
function CS.UnityEngine.Animator:SetVector(id, value) end
  

  

  
  ---@param name String
  ---@return Quaternion
  
function CS.UnityEngine.Animator:GetQuaternion(name) end
  

  

  
  ---@param id Int32
  ---@return Quaternion
  
function CS.UnityEngine.Animator:GetQuaternion(id) end
  

  

  
  ---@param name String---@param value Quaternion
  
  
function CS.UnityEngine.Animator:SetQuaternion(name, value) end
  

  

  
  ---@param id Int32---@param value Quaternion
  
  
function CS.UnityEngine.Animator:SetQuaternion(id, value) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Animator:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Animator:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Animator:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Animator:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Animator:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Animator:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Animator:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Animator:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Animator:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Animator:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Animator:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Animator:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Animator:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Animator:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Animator:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Animator:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Animator:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Animator:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Animator:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Animator:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Animator:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Animator:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Animator:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Animator:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Animator:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Animator:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Animator:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Animator:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Animator:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Animator:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Animator:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Animator:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Animator:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Animator:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Animator:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Animator:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Animator:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Animator:GetType() end
  

  
