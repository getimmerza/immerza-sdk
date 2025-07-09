
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.Video = CS.UnityEngine.Video or {}
---@class CS.UnityEngine.Video.VideoPlayer
CS.UnityEngine.Video.VideoPlayer = CS.UnityEngine.Video.VideoPlayer or {}

  
  
  
  
function CS.UnityEngine.Video.VideoPlayer:Prepare() end
  

  

  
  
  
  
function CS.UnityEngine.Video.VideoPlayer:Play() end
  

  

  
  
  
  
function CS.UnityEngine.Video.VideoPlayer:Pause() end
  

  

  
  
  
  
function CS.UnityEngine.Video.VideoPlayer:Stop() end
  

  

  
  
  
  
function CS.UnityEngine.Video.VideoPlayer:StepForward() end
  

  

  
  ---@param trackIndex UInt16
  ---@return String
  
function CS.UnityEngine.Video.VideoPlayer:GetAudioLanguageCode(trackIndex) end
  

  

  
  ---@param trackIndex UInt16
  ---@return UInt16
  
function CS.UnityEngine.Video.VideoPlayer:GetAudioChannelCount(trackIndex) end
  

  

  
  ---@param trackIndex UInt16
  ---@return UInt32
  
function CS.UnityEngine.Video.VideoPlayer:GetAudioSampleRate(trackIndex) end
  

  

  
  ---@param trackIndex UInt16---@param enabled Boolean
  
  
function CS.UnityEngine.Video.VideoPlayer:EnableAudioTrack(trackIndex, enabled) end
  

  

  
  ---@param trackIndex UInt16
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:IsAudioTrackEnabled(trackIndex) end
  

  

  
  ---@param trackIndex UInt16
  ---@return Single
  
function CS.UnityEngine.Video.VideoPlayer:GetDirectAudioVolume(trackIndex) end
  

  

  
  ---@param trackIndex UInt16---@param volume Single
  
  
function CS.UnityEngine.Video.VideoPlayer:SetDirectAudioVolume(trackIndex, volume) end
  

  

  
  ---@param trackIndex UInt16
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:GetDirectAudioMute(trackIndex) end
  

  

  
  ---@param trackIndex UInt16---@param mute Boolean
  
  
function CS.UnityEngine.Video.VideoPlayer:SetDirectAudioMute(trackIndex, mute) end
  

  

  
  ---@param trackIndex UInt16
  ---@return AudioSource
  
function CS.UnityEngine.Video.VideoPlayer:GetTargetAudioSource(trackIndex) end
  

  

  
  ---@param trackIndex UInt16---@param source AudioSource
  
  
function CS.UnityEngine.Video.VideoPlayer:SetTargetAudioSource(trackIndex, source) end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Video.VideoPlayer:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.UnityEngine.Video.VideoPlayer:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.UnityEngine.Video.VideoPlayer:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.UnityEngine.Video.VideoPlayer:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Video.VideoPlayer:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.UnityEngine.Video.VideoPlayer:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.UnityEngine.Video.VideoPlayer:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.UnityEngine.Video.VideoPlayer:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Video.VideoPlayer:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Video.VideoPlayer:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Video.VideoPlayer:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Video.VideoPlayer:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Video.VideoPlayer:GetType() end
  

  
