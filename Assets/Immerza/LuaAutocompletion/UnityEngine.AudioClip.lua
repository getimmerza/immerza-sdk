
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.AudioClip
CS.UnityEngine.AudioClip = CS.UnityEngine.AudioClip or {}

  
  
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:LoadAudioData() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:UnloadAudioData() end
  

  

  
  ---@param data Span`1---@param offsetSamples Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:GetData(data, offsetSamples) end
  

  

  
  ---@param data Single[]---@param offsetSamples Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:GetData(data, offsetSamples) end
  

  

  
  ---@param data Single[]---@param offsetSamples Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:SetData(data, offsetSamples) end
  

  

  
  ---@param data ReadOnlySpan`1---@param offsetSamples Int32
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:SetData(data, offsetSamples) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param _3D Boolean---@param stream Boolean
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, _3D, stream) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param _3D Boolean---@param stream Boolean---@param pcmreadercallback PCMReaderCallback
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, _3D, stream, pcmreadercallback) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param _3D Boolean---@param stream Boolean---@param pcmreadercallback PCMReaderCallback---@param pcmsetpositioncallback PCMSetPositionCallback
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, _3D, stream, pcmreadercallback, pcmsetpositioncallback) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param stream Boolean
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, stream) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param stream Boolean---@param pcmreadercallback PCMReaderCallback
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback) end
  

  

  
  ---@param name String---@param lengthSamples Int32---@param channels Int32---@param frequency Int32---@param stream Boolean---@param pcmreadercallback PCMReaderCallback---@param pcmsetpositioncallback PCMSetPositionCallback
  ---@return AudioClip
  
function CS.UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AudioClip:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.AudioClip:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.AudioClip:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.AudioClip:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.AudioClip:GetType() end
  

  
