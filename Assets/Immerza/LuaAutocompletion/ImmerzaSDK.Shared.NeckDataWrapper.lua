
CS.ImmerzaSDK = CS.ImmerzaSDK or {}CS.ImmerzaSDK.Shared = CS.ImmerzaSDK.Shared or {}
---@class CS.ImmerzaSDK.Shared.NeckDataWrapper
CS.ImmerzaSDK.Shared.NeckDataWrapper = CS.ImmerzaSDK.Shared.NeckDataWrapper or {}

  
  ---@param status String
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:SetStatus(status) end
  

  

  
  ---@param code String
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:SetCode(code) end
  

  

  
  ---@param datetime DateTime
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:SetEffectiveDateTime(datetime) end
  

  

  
  ---@param id String---@param type String
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:SetSubject(id, type) end
  

  

  
  ---@param id String---@param type String
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:SetDevice(id, type) end
  

  

  
  ---@param code String---@param quantityType String---@param value String
  
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:AddComponent(code, quantityType, value) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:GetType() end
  

  

  
  
  ---@return String
  
function CS.ImmerzaSDK.Shared.NeckDataWrapper:ToString() end
  

  
