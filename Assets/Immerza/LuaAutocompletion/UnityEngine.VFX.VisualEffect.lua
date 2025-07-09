
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.VFX = CS.UnityEngine.VFX or {}
---@class CS.UnityEngine.VFX.VisualEffect
CS.UnityEngine.VFX.VisualEffect = CS.UnityEngine.VFX.VisualEffect or {}

  
  
  ---@return VFXEventAttribute
  
function CS.UnityEngine.VFX.VisualEffect:CreateVFXEventAttribute() end
  

  

  
  ---@param eventNameID Int32---@param eventAttribute VFXEventAttribute
  
  
function CS.UnityEngine.VFX.VisualEffect:SendEvent(eventNameID, eventAttribute) end
  

  

  
  ---@param eventName String---@param eventAttribute VFXEventAttribute
  
  
function CS.UnityEngine.VFX.VisualEffect:SendEvent(eventName, eventAttribute) end
  

  

  
  ---@param eventNameID Int32
  
  
function CS.UnityEngine.VFX.VisualEffect:SendEvent(eventNameID) end
  

  

  
  ---@param eventName String
  
  
function CS.UnityEngine.VFX.VisualEffect:SendEvent(eventName) end
  

  

  
  ---@param eventAttribute VFXEventAttribute
  
  
function CS.UnityEngine.VFX.VisualEffect:Play(eventAttribute) end
  

  

  
  
  
  
function CS.UnityEngine.VFX.VisualEffect:Play() end
  

  

  
  ---@param eventAttribute VFXEventAttribute
  
  
function CS.UnityEngine.VFX.VisualEffect:Stop(eventAttribute) end
  

  

  
  
  
  
function CS.UnityEngine.VFX.VisualEffect:Stop() end
  

  

  
  
  
  
function CS.UnityEngine.VFX.VisualEffect:Reinit() end
  

  

  
  
  
  
function CS.UnityEngine.VFX.VisualEffect:AdvanceOneFrame() end
  

  

  
  ---@param nameID Int32
  
  
function CS.UnityEngine.VFX.VisualEffect:ResetOverride(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return TextureDimension
  
function CS.UnityEngine.VFX.VisualEffect:GetTextureDimension(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasBool(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasInt(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasUInt(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasFloat(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector2(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector3(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector4(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasMatrix4x4(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasTexture(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasAnimationCurve(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasGradient(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasMesh(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasSkinnedMeshRenderer(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasGraphicsBuffer(nameID) end
  

  

  
  ---@param nameID Int32---@param b Boolean
  
  
function CS.UnityEngine.VFX.VisualEffect:SetBool(nameID, b) end
  

  

  
  ---@param nameID Int32---@param i Int32
  
  
function CS.UnityEngine.VFX.VisualEffect:SetInt(nameID, i) end
  

  

  
  ---@param nameID Int32---@param i UInt32
  
  
function CS.UnityEngine.VFX.VisualEffect:SetUInt(nameID, i) end
  

  

  
  ---@param nameID Int32---@param f Single
  
  
function CS.UnityEngine.VFX.VisualEffect:SetFloat(nameID, f) end
  

  

  
  ---@param nameID Int32---@param v Vector2
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector2(nameID, v) end
  

  

  
  ---@param nameID Int32---@param v Vector3
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector3(nameID, v) end
  

  

  
  ---@param nameID Int32---@param v Vector4
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector4(nameID, v) end
  

  

  
  ---@param nameID Int32---@param v Matrix4x4
  
  
function CS.UnityEngine.VFX.VisualEffect:SetMatrix4x4(nameID, v) end
  

  

  
  ---@param nameID Int32---@param t Texture
  
  
function CS.UnityEngine.VFX.VisualEffect:SetTexture(nameID, t) end
  

  

  
  ---@param nameID Int32---@param c AnimationCurve
  
  
function CS.UnityEngine.VFX.VisualEffect:SetAnimationCurve(nameID, c) end
  

  

  
  ---@param nameID Int32---@param g Gradient
  
  
function CS.UnityEngine.VFX.VisualEffect:SetGradient(nameID, g) end
  

  

  
  ---@param nameID Int32---@param m Mesh
  
  
function CS.UnityEngine.VFX.VisualEffect:SetMesh(nameID, m) end
  

  

  
  ---@param nameID Int32---@param m SkinnedMeshRenderer
  
  
function CS.UnityEngine.VFX.VisualEffect:SetSkinnedMeshRenderer(nameID, m) end
  

  

  
  ---@param nameID Int32---@param g GraphicsBuffer
  
  
function CS.UnityEngine.VFX.VisualEffect:SetGraphicsBuffer(nameID, g) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:GetBool(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Int32
  
function CS.UnityEngine.VFX.VisualEffect:GetInt(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return UInt32
  
function CS.UnityEngine.VFX.VisualEffect:GetUInt(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Single
  
function CS.UnityEngine.VFX.VisualEffect:GetFloat(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Vector2
  
function CS.UnityEngine.VFX.VisualEffect:GetVector2(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Vector3
  
function CS.UnityEngine.VFX.VisualEffect:GetVector3(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Vector4
  
function CS.UnityEngine.VFX.VisualEffect:GetVector4(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Matrix4x4
  
function CS.UnityEngine.VFX.VisualEffect:GetMatrix4x4(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Texture
  
function CS.UnityEngine.VFX.VisualEffect:GetTexture(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Mesh
  
function CS.UnityEngine.VFX.VisualEffect:GetMesh(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return SkinnedMeshRenderer
  
function CS.UnityEngine.VFX.VisualEffect:GetSkinnedMeshRenderer(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Gradient
  
function CS.UnityEngine.VFX.VisualEffect:GetGradient(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return AnimationCurve
  
function CS.UnityEngine.VFX.VisualEffect:GetAnimationCurve(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return VFXParticleSystemInfo
  
function CS.UnityEngine.VFX.VisualEffect:GetParticleSystemInfo(nameID) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasAnySystemAwake() end
  

  

  
  ---@param nameID Int32---@param spawnState VFXSpawnerState
  
  
function CS.UnityEngine.VFX.VisualEffect:GetSpawnSystemInfo(nameID, spawnState) end
  

  

  
  ---@param nameID Int32
  ---@return VFXSpawnerState
  
function CS.UnityEngine.VFX.VisualEffect:GetSpawnSystemInfo(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasSystem(nameID) end
  

  

  
  ---@param names List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetSystemNames(names) end
  

  

  
  ---@param names List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetParticleSystemNames(names) end
  

  

  
  ---@param names List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetOutputEventNames(names) end
  

  

  
  ---@param names List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetSpawnSystemNames(names) end
  

  

  
  ---@param name String
  
  
function CS.UnityEngine.VFX.VisualEffect:ResetOverride(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasInt(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasUInt(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasFloat(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector2(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector3(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasVector4(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasMatrix4x4(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasTexture(name) end
  

  

  
  ---@param name String
  ---@return TextureDimension
  
function CS.UnityEngine.VFX.VisualEffect:GetTextureDimension(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasAnimationCurve(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasGradient(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasMesh(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasSkinnedMeshRenderer(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasGraphicsBuffer(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasBool(name) end
  

  

  
  ---@param name String---@param i Int32
  
  
function CS.UnityEngine.VFX.VisualEffect:SetInt(name, i) end
  

  

  
  ---@param name String---@param i UInt32
  
  
function CS.UnityEngine.VFX.VisualEffect:SetUInt(name, i) end
  

  

  
  ---@param name String---@param f Single
  
  
function CS.UnityEngine.VFX.VisualEffect:SetFloat(name, f) end
  

  

  
  ---@param name String---@param v Vector2
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector2(name, v) end
  

  

  
  ---@param name String---@param v Vector3
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector3(name, v) end
  

  

  
  ---@param name String---@param v Vector4
  
  
function CS.UnityEngine.VFX.VisualEffect:SetVector4(name, v) end
  

  

  
  ---@param name String---@param v Matrix4x4
  
  
function CS.UnityEngine.VFX.VisualEffect:SetMatrix4x4(name, v) end
  

  

  
  ---@param name String---@param t Texture
  
  
function CS.UnityEngine.VFX.VisualEffect:SetTexture(name, t) end
  

  

  
  ---@param name String---@param c AnimationCurve
  
  
function CS.UnityEngine.VFX.VisualEffect:SetAnimationCurve(name, c) end
  

  

  
  ---@param name String---@param g Gradient
  
  
function CS.UnityEngine.VFX.VisualEffect:SetGradient(name, g) end
  

  

  
  ---@param name String---@param m Mesh
  
  
function CS.UnityEngine.VFX.VisualEffect:SetMesh(name, m) end
  

  

  
  ---@param name String---@param m SkinnedMeshRenderer
  
  
function CS.UnityEngine.VFX.VisualEffect:SetSkinnedMeshRenderer(name, m) end
  

  

  
  ---@param name String---@param g GraphicsBuffer
  
  
function CS.UnityEngine.VFX.VisualEffect:SetGraphicsBuffer(name, g) end
  

  

  
  ---@param name String---@param b Boolean
  
  
function CS.UnityEngine.VFX.VisualEffect:SetBool(name, b) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.VFX.VisualEffect:GetInt(name) end
  

  

  
  ---@param name String
  ---@return UInt32
  
function CS.UnityEngine.VFX.VisualEffect:GetUInt(name) end
  

  

  
  ---@param name String
  ---@return Single
  
function CS.UnityEngine.VFX.VisualEffect:GetFloat(name) end
  

  

  
  ---@param name String
  ---@return Vector2
  
function CS.UnityEngine.VFX.VisualEffect:GetVector2(name) end
  

  

  
  ---@param name String
  ---@return Vector3
  
function CS.UnityEngine.VFX.VisualEffect:GetVector3(name) end
  

  

  
  ---@param name String
  ---@return Vector4
  
function CS.UnityEngine.VFX.VisualEffect:GetVector4(name) end
  

  

  
  ---@param name String
  ---@return Matrix4x4
  
function CS.UnityEngine.VFX.VisualEffect:GetMatrix4x4(name) end
  

  

  
  ---@param name String
  ---@return Texture
  
function CS.UnityEngine.VFX.VisualEffect:GetTexture(name) end
  

  

  
  ---@param name String
  ---@return Mesh
  
function CS.UnityEngine.VFX.VisualEffect:GetMesh(name) end
  

  

  
  ---@param name String
  ---@return SkinnedMeshRenderer
  
function CS.UnityEngine.VFX.VisualEffect:GetSkinnedMeshRenderer(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:GetBool(name) end
  

  

  
  ---@param name String
  ---@return AnimationCurve
  
function CS.UnityEngine.VFX.VisualEffect:GetAnimationCurve(name) end
  

  

  
  ---@param name String
  ---@return Gradient
  
function CS.UnityEngine.VFX.VisualEffect:GetGradient(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:HasSystem(name) end
  

  

  
  ---@param name String
  ---@return VFXParticleSystemInfo
  
function CS.UnityEngine.VFX.VisualEffect:GetParticleSystemInfo(name) end
  

  

  
  ---@param name String
  ---@return VFXSpawnerState
  
function CS.UnityEngine.VFX.VisualEffect:GetSpawnSystemInfo(name) end
  

  

  
  ---@param stepDeltaTime Single---@param stepCount UInt32
  
  
function CS.UnityEngine.VFX.VisualEffect:Simulate(stepDeltaTime, stepCount) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.VFX.VisualEffect:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.VFX.VisualEffect:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.VFX.VisualEffect:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.VFX.VisualEffect:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.VFX.VisualEffect:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.VFX.VisualEffect:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.VFX.VisualEffect:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.VFX.VisualEffect:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.VFX.VisualEffect:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.VFX.VisualEffect:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.VFX.VisualEffect:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.VFX.VisualEffect:GetType() end
  

  
