
CS.System = CS.System or {}CS.System.Collections = CS.System.Collections or {}CS.System.Collections.Generic = CS.System.Collections.Generic or {}
---@class CS.System.Collections.Generic.Dictionary`2
CS.System.Collections.Generic.Dictionary`2 = CS.System.Collections.Generic.Dictionary`2 or {}

  
  ---@param key String---@param value Object
  
  
function CS.System.Collections.Generic.Dictionary`2:Add(key, value) end
  

  

  
  
  
  
function CS.System.Collections.Generic.Dictionary`2:Clear() end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:ContainsKey(key) end
  

  

  
  ---@param value Object
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:ContainsValue(value) end
  

  

  
  
  ---@return Enumerator
  
function CS.System.Collections.Generic.Dictionary`2:GetEnumerator() end
  

  

  
  ---@param info SerializationInfo---@param context StreamingContext
  
  
function CS.System.Collections.Generic.Dictionary`2:GetObjectData(info, context) end
  

  

  
  ---@param sender Object
  
  
function CS.System.Collections.Generic.Dictionary`2:OnDeserialization(sender) end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:Remove(key) end
  

  

  
  ---@param key String---@param value Object&
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:Remove(key, value) end
  

  

  
  ---@param key String---@param value Object&
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:TryGetValue(key, value) end
  

  

  
  ---@param key String---@param value Object
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:TryAdd(key, value) end
  

  

  
  ---@param capacity Int32
  ---@return Int32
  
function CS.System.Collections.Generic.Dictionary`2:EnsureCapacity(capacity) end
  

  

  
  
  
  
function CS.System.Collections.Generic.Dictionary`2:TrimExcess() end
  

  

  
  ---@param capacity Int32
  
  
function CS.System.Collections.Generic.Dictionary`2:TrimExcess(capacity) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.System.Collections.Generic.Dictionary`2:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.System.Collections.Generic.Dictionary`2:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.System.Collections.Generic.Dictionary`2:GetType() end
  

  

  
  
  ---@return String
  
function CS.System.Collections.Generic.Dictionary`2:ToString() end
  

  
