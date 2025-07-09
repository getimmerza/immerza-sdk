
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.AudioSource
CS.UnityEngine.AudioSource = CS.UnityEngine.AudioSource or {}

  
  ---@param slot Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:PlayOnGamepad(slot) end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:DisableGamepadOutput() end
  

  

  
  ---@param slot Int32---@param mixLevel Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:SetGamepadSpeakerMixLevel(slot, mixLevel) end
  

  

  
  ---@param slot Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:SetGamepadSpeakerMixLevelDefault(slot) end
  

  

  
  ---@param slot Int32---@param restricted Boolean
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:SetGamepadSpeakerRestrictedAudio(slot, restricted) end
  

  

  
  ---@param outputType GamepadSpeakerOutputType
  ---@return Boolean
  
function CS.UnityEngine.AudioSource.GamepadSpeakerSupportsOutputType(outputType) end
  

  

  
  
  
  
function CS.UnityEngine.AudioSource:Play() end
  

  

  
  ---@param delay UInt64
  
  
function CS.UnityEngine.AudioSource:Play(delay) end
  

  

  
  ---@param delay Single
  
  
function CS.UnityEngine.AudioSource:PlayDelayed(delay) end
  

  

  
  ---@param time Double
  
  
function CS.UnityEngine.AudioSource:PlayScheduled(time) end
  

  

  
  ---@param clip AudioClip
  
  
function CS.UnityEngine.AudioSource:PlayOneShot(clip) end
  

  

  
  ---@param clip AudioClip---@param volumeScale Single
  
  
function CS.UnityEngine.AudioSource:PlayOneShot(clip, volumeScale) end
  

  

  
  ---@param time Double
  
  
function CS.UnityEngine.AudioSource:SetScheduledStartTime(time) end
  

  

  
  ---@param time Double
  
  
function CS.UnityEngine.AudioSource:SetScheduledEndTime(time) end
  

  

  
  
  
  
function CS.UnityEngine.AudioSource:Stop() end
  

  

  
  
  
  
function CS.UnityEngine.AudioSource:Pause() end
  

  

  
  
  
  
function CS.UnityEngine.AudioSource:UnPause() end
  

  

  
  ---@param clip AudioClip---@param position Vector3
  
  
function CS.UnityEngine.AudioSource.PlayClipAtPoint(clip, position) end
  

  

  
  ---@param clip AudioClip---@param position Vector3---@param volume Single
  
  
function CS.UnityEngine.AudioSource.PlayClipAtPoint(clip, position, volume) end
  

  

  
  ---@param type AudioSourceCurveType---@param curve AnimationCurve
  
  
function CS.UnityEngine.AudioSource:SetCustomCurve(type, curve) end
  

  

  
  ---@param type AudioSourceCurveType
  ---@return AnimationCurve
  
function CS.UnityEngine.AudioSource:GetCustomCurve(type) end
  

  

  
  ---@param numSamples Int32---@param channel Int32
  ---@return Single[]
  
function CS.UnityEngine.AudioSource:GetOutputData(numSamples, channel) end
  

  

  
  ---@param samples Single[]---@param channel Int32
  
  
function CS.UnityEngine.AudioSource:GetOutputData(samples, channel) end
  

  

  
  ---@param numSamples Int32---@param channel Int32---@param window FFTWindow
  ---@return Single[]
  
function CS.UnityEngine.AudioSource:GetSpectrumData(numSamples, channel, window) end
  

  

  
  ---@param samples Single[]---@param channel Int32---@param window FFTWindow
  
  
function CS.UnityEngine.AudioSource:GetSpectrumData(samples, channel, window) end
  

  

  
  ---@param index Int32---@param value Single
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:SetSpatializerFloat(index, value) end
  

  

  
  ---@param index Int32---@param value Single&
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:GetSpatializerFloat(index, value) end
  

  

  
  ---@param index Int32---@param value Single&
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:GetAmbisonicDecoderFloat(index, value) end
  

  

  
  ---@param index Int32---@param value Single
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:SetAmbisonicDecoderFloat(index, value) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AudioSource:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AudioSource:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AudioSource:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AudioSource:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.AudioSource:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.AudioSource:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.AudioSource:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.AudioSource:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.AudioSource:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.AudioSource:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.AudioSource:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AudioSource:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.AudioSource:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.AudioSource:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.AudioSource:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.AudioSource:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AudioSource:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AudioSource:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AudioSource:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.AudioSource:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AudioSource:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.AudioSource:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.AudioSource:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.AudioSource:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AudioSource:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AudioSource:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.AudioSource:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AudioSource:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AudioSource:GetType() end
  

  
