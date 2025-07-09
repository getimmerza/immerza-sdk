
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.ParticleSystem
CS.UnityEngine.ParticleSystem = CS.UnityEngine.ParticleSystem or {}

  
  ---@param position Vector3---@param velocity Vector3---@param size Single---@param lifetime Single---@param color Color32
  
  
function CS.UnityEngine.ParticleSystem:Emit(position, velocity, size, lifetime, color) end
  

  

  
  ---@param particle Particle
  
  
function CS.UnityEngine.ParticleSystem:Emit(particle) end
  

  

  
  ---@param particles Particle[]---@param size Int32---@param offset Int32
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles, size, offset) end
  

  

  
  ---@param particles Particle[]---@param size Int32
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles, size) end
  

  

  
  ---@param particles Particle[]
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles) end
  

  

  
  ---@param particles NativeArray`1---@param size Int32---@param offset Int32
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles, size, offset) end
  

  

  
  ---@param particles NativeArray`1---@param size Int32
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles, size) end
  

  

  
  ---@param particles NativeArray`1
  
  
function CS.UnityEngine.ParticleSystem:SetParticles(particles) end
  

  

  
  ---@param particles Particle[]---@param size Int32---@param offset Int32
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles, size, offset) end
  

  

  
  ---@param particles Particle[]---@param size Int32
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles, size) end
  

  

  
  ---@param particles Particle[]
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles) end
  

  

  
  ---@param particles NativeArray`1---@param size Int32---@param offset Int32
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles, size, offset) end
  

  

  
  ---@param particles NativeArray`1---@param size Int32
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles, size) end
  

  

  
  ---@param particles NativeArray`1
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetParticles(particles) end
  

  

  
  ---@param customData List`1---@param streamIndex ParticleSystemCustomData
  
  
function CS.UnityEngine.ParticleSystem:SetCustomParticleData(customData, streamIndex) end
  

  

  
  ---@param customData List`1---@param streamIndex ParticleSystemCustomData
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetCustomParticleData(customData, streamIndex) end
  

  

  
  
  ---@return PlaybackState
  
function CS.UnityEngine.ParticleSystem:GetPlaybackState() end
  

  

  
  ---@param playbackState PlaybackState
  
  
function CS.UnityEngine.ParticleSystem:SetPlaybackState(playbackState) end
  

  

  
  
  ---@return Trails
  
function CS.UnityEngine.ParticleSystem:GetTrails() end
  

  

  
  ---@param trailData Trails&
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetTrails(trailData) end
  

  

  
  ---@param trailData Trails
  
  
function CS.UnityEngine.ParticleSystem:SetTrails(trailData) end
  

  

  
  ---@param t Single---@param withChildren Boolean---@param restart Boolean---@param fixedTimeStep Boolean
  
  
function CS.UnityEngine.ParticleSystem:Simulate(t, withChildren, restart, fixedTimeStep) end
  

  

  
  ---@param t Single---@param withChildren Boolean---@param restart Boolean
  
  
function CS.UnityEngine.ParticleSystem:Simulate(t, withChildren, restart) end
  

  

  
  ---@param t Single---@param withChildren Boolean
  
  
function CS.UnityEngine.ParticleSystem:Simulate(t, withChildren) end
  

  

  
  ---@param t Single
  
  
function CS.UnityEngine.ParticleSystem:Simulate(t) end
  

  

  
  ---@param withChildren Boolean
  
  
function CS.UnityEngine.ParticleSystem:Play(withChildren) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:Play() end
  

  

  
  ---@param withChildren Boolean
  
  
function CS.UnityEngine.ParticleSystem:Pause(withChildren) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:Pause() end
  

  

  
  ---@param withChildren Boolean---@param stopBehavior ParticleSystemStopBehavior
  
  
function CS.UnityEngine.ParticleSystem:Stop(withChildren, stopBehavior) end
  

  

  
  ---@param withChildren Boolean
  
  
function CS.UnityEngine.ParticleSystem:Stop(withChildren) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:Stop() end
  

  

  
  ---@param withChildren Boolean
  
  
function CS.UnityEngine.ParticleSystem:Clear(withChildren) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:Clear() end
  

  

  
  ---@param withChildren Boolean
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:IsAlive(withChildren) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:IsAlive() end
  

  

  
  ---@param count Int32
  
  
function CS.UnityEngine.ParticleSystem:Emit(count) end
  

  

  
  ---@param emitParams EmitParams---@param count Int32
  
  
function CS.UnityEngine.ParticleSystem:Emit(emitParams, count) end
  

  

  
  ---@param subEmitterIndex Int32
  
  
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex) end
  

  

  
  ---@param subEmitterIndex Int32---@param particle Particle&
  
  
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex, particle) end
  

  

  
  ---@param subEmitterIndex Int32---@param particles List`1
  
  
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex, particles) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem.ResetPreMappedBufferMemory() end
  

  

  
  ---@param vertexBuffersCount Int32---@param indexBuffersCount Int32
  
  
function CS.UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts(vertexBuffersCount, indexBuffersCount) end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:AllocateAxisOfRotationAttribute() end
  

  

  
  
  
  
function CS.UnityEngine.ParticleSystem:AllocateMeshIndexAttribute() end
  

  

  
  ---@param stream ParticleSystemCustomData
  
  
function CS.UnityEngine.ParticleSystem:AllocateCustomDataAttribute(stream) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.ParticleSystem:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.ParticleSystem:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.ParticleSystem:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.ParticleSystem:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.ParticleSystem:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.ParticleSystem:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.ParticleSystem:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.ParticleSystem:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.ParticleSystem:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.ParticleSystem:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.ParticleSystem:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.ParticleSystem:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.ParticleSystem:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.ParticleSystem:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.ParticleSystem:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.ParticleSystem:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.ParticleSystem:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.ParticleSystem:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.ParticleSystem:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.ParticleSystem:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.ParticleSystem:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.ParticleSystem:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.ParticleSystem:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.ParticleSystem:GetType() end
  

  
