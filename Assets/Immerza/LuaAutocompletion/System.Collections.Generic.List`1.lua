
CS.System = CS.System or {}CS.System.Collections = CS.System.Collections or {}CS.System.Collections.Generic = CS.System.Collections.Generic or {}
---@class CS.System.Collections.Generic.List`1
CS.System.Collections.Generic.List`1 = CS.System.Collections.Generic.List`1 or {}

  
  ---@param item Int32
  
  
function CS.System.Collections.Generic.List`1:Add(item) end
  

  

  
  ---@param collection IEnumerable`1
  
  
function CS.System.Collections.Generic.List`1:AddRange(collection) end
  

  

  
  
  ---@return ReadOnlyCollection`1
  
function CS.System.Collections.Generic.List`1:AsReadOnly() end
  

  

  
  ---@param index Int32---@param count Int32---@param item Int32---@param comparer IComparer`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:BinarySearch(index, count, item, comparer) end
  

  

  
  ---@param item Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:BinarySearch(item) end
  

  

  
  ---@param item Int32---@param comparer IComparer`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:BinarySearch(item, comparer) end
  

  

  
  
  
  
function CS.System.Collections.Generic.List`1:Clear() end
  

  

  
  ---@param item Int32
  ---@return Boolean
  
function CS.System.Collections.Generic.List`1:Contains(item) end
  

  

  
  ---@param converter Converter`2
  ---@return List`1
  
function CS.System.Collections.Generic.List`1:ConvertAll(converter) end
  

  

  
  ---@param array Int32[]
  
  
function CS.System.Collections.Generic.List`1:CopyTo(array) end
  

  

  
  ---@param index Int32---@param array Int32[]---@param arrayIndex Int32---@param count Int32
  
  
function CS.System.Collections.Generic.List`1:CopyTo(index, array, arrayIndex, count) end
  

  

  
  ---@param array Int32[]---@param arrayIndex Int32
  
  
function CS.System.Collections.Generic.List`1:CopyTo(array, arrayIndex) end
  

  

  
  ---@param match Predicate`1
  ---@return Boolean
  
function CS.System.Collections.Generic.List`1:Exists(match) end
  

  

  
  ---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:Find(match) end
  

  

  
  ---@param match Predicate`1
  ---@return List`1
  
function CS.System.Collections.Generic.List`1:FindAll(match) end
  

  

  
  ---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindIndex(match) end
  

  

  
  ---@param startIndex Int32---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindIndex(startIndex, match) end
  

  

  
  ---@param startIndex Int32---@param count Int32---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindIndex(startIndex, count, match) end
  

  

  
  ---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindLast(match) end
  

  

  
  ---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindLastIndex(match) end
  

  

  
  ---@param startIndex Int32---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindLastIndex(startIndex, match) end
  

  

  
  ---@param startIndex Int32---@param count Int32---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:FindLastIndex(startIndex, count, match) end
  

  

  
  ---@param action Action`1
  
  
function CS.System.Collections.Generic.List`1:ForEach(action) end
  

  

  
  
  ---@return Enumerator
  
function CS.System.Collections.Generic.List`1:GetEnumerator() end
  

  

  
  ---@param index Int32---@param count Int32
  ---@return List`1
  
function CS.System.Collections.Generic.List`1:GetRange(index, count) end
  

  

  
  ---@param item Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:IndexOf(item) end
  

  

  
  ---@param item Int32---@param index Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:IndexOf(item, index) end
  

  

  
  ---@param item Int32---@param index Int32---@param count Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:IndexOf(item, index, count) end
  

  

  
  ---@param index Int32---@param item Int32
  
  
function CS.System.Collections.Generic.List`1:Insert(index, item) end
  

  

  
  ---@param index Int32---@param collection IEnumerable`1
  
  
function CS.System.Collections.Generic.List`1:InsertRange(index, collection) end
  

  

  
  ---@param item Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:LastIndexOf(item) end
  

  

  
  ---@param item Int32---@param index Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:LastIndexOf(item, index) end
  

  

  
  ---@param item Int32---@param index Int32---@param count Int32
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:LastIndexOf(item, index, count) end
  

  

  
  ---@param item Int32
  ---@return Boolean
  
function CS.System.Collections.Generic.List`1:Remove(item) end
  

  

  
  ---@param match Predicate`1
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:RemoveAll(match) end
  

  

  
  ---@param index Int32
  
  
function CS.System.Collections.Generic.List`1:RemoveAt(index) end
  

  

  
  ---@param index Int32---@param count Int32
  
  
function CS.System.Collections.Generic.List`1:RemoveRange(index, count) end
  

  

  
  
  
  
function CS.System.Collections.Generic.List`1:Reverse() end
  

  

  
  ---@param index Int32---@param count Int32
  
  
function CS.System.Collections.Generic.List`1:Reverse(index, count) end
  

  

  
  
  
  
function CS.System.Collections.Generic.List`1:Sort() end
  

  

  
  ---@param comparer IComparer`1
  
  
function CS.System.Collections.Generic.List`1:Sort(comparer) end
  

  

  
  ---@param index Int32---@param count Int32---@param comparer IComparer`1
  
  
function CS.System.Collections.Generic.List`1:Sort(index, count, comparer) end
  

  

  
  ---@param comparison Comparison`1
  
  
function CS.System.Collections.Generic.List`1:Sort(comparison) end
  

  

  
  
  ---@return Int32[]
  
function CS.System.Collections.Generic.List`1:ToArray() end
  

  

  
  
  
  
function CS.System.Collections.Generic.List`1:TrimExcess() end
  

  

  
  ---@param match Predicate`1
  ---@return Boolean
  
function CS.System.Collections.Generic.List`1:TrueForAll(match) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.System.Collections.Generic.List`1:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.System.Collections.Generic.List`1:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.System.Collections.Generic.List`1:GetType() end
  

  

  
  
  ---@return String
  
function CS.System.Collections.Generic.List`1:ToString() end
  

  
