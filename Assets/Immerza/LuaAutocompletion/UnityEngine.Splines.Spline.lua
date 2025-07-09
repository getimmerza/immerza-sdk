
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.Splines = CS.UnityEngine.Splines or {}
---@class CS.UnityEngine.Splines.Spline
CS.UnityEngine.Splines.Spline = CS.UnityEngine.Splines.Spline or {}

  
  ---@param key String---@param data SplineData`1&
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:TryGetFloatData(key, data) end
  

  

  
  ---@param key String---@param data SplineData`1&
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:TryGetFloat4Data(key, data) end
  

  

  
  ---@param key String---@param data SplineData`1&
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:TryGetIntData(key, data) end
  

  

  
  ---@param key String---@param data SplineData`1&
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:TryGetObjectData(key, data) end
  

  

  
  ---@param key String
  ---@return SplineData`1
  
function CS.UnityEngine.Splines.Spline:GetOrCreateFloatData(key) end
  

  

  
  ---@param key String
  ---@return SplineData`1
  
function CS.UnityEngine.Splines.Spline:GetOrCreateFloat4Data(key) end
  

  

  
  ---@param key String
  ---@return SplineData`1
  
function CS.UnityEngine.Splines.Spline:GetOrCreateIntData(key) end
  

  

  
  ---@param key String
  ---@return SplineData`1
  
function CS.UnityEngine.Splines.Spline:GetOrCreateObjectData(key) end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:RemoveFloatData(key) end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:RemoveFloat4Data(key) end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:RemoveIntData(key) end
  

  

  
  ---@param key String
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:RemoveObjectData(key) end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetFloatDataKeys() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetFloat4DataKeys() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetIntDataKeys() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetObjectDataKeys() end
  

  

  
  ---@param type EmbeddedSplineDataType
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetSplineDataKeys(type) end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetFloatDataValues() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetFloat4DataValues() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetIntDataValues() end
  

  

  
  
  ---@return IEnumerable`1
  
function CS.UnityEngine.Splines.Spline:GetObjectDataValues() end
  

  

  
  ---@param key String---@param value SplineData`1
  
  
function CS.UnityEngine.Splines.Spline:SetFloatData(key, value) end
  

  

  
  ---@param key String---@param value SplineData`1
  
  
function CS.UnityEngine.Splines.Spline:SetFloat4Data(key, value) end
  

  

  
  ---@param key String---@param value SplineData`1
  
  
function CS.UnityEngine.Splines.Spline:SetIntData(key, value) end
  

  

  
  ---@param key String---@param value SplineData`1
  
  
function CS.UnityEngine.Splines.Spline:SetObjectData(key, value) end
  

  

  
  ---@param index Int32
  
  
function CS.UnityEngine.Splines.Spline:EnforceTangentModeNoNotify(index) end
  

  

  
  ---@param range SplineRange
  
  
function CS.UnityEngine.Splines.Spline:EnforceTangentModeNoNotify(range) end
  

  

  
  ---@param index Int32
  ---@return TangentMode
  
function CS.UnityEngine.Splines.Spline:GetTangentMode(index) end
  

  

  
  ---@param mode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:SetTangentMode(mode) end
  

  

  
  ---@param index Int32---@param mode TangentMode---@param main BezierTangent
  
  
function CS.UnityEngine.Splines.Spline:SetTangentMode(index, mode, main) end
  

  

  
  ---@param range SplineRange---@param mode TangentMode---@param main BezierTangent
  
  
function CS.UnityEngine.Splines.Spline:SetTangentMode(range, mode, main) end
  

  

  
  ---@param index Int32---@param mode TangentMode---@param main BezierTangent
  
  
function CS.UnityEngine.Splines.Spline:SetTangentModeNoNotify(index, mode, main) end
  

  

  
  ---@param index Int32
  ---@return Single
  
function CS.UnityEngine.Splines.Spline:GetAutoSmoothTension(index) end
  

  

  
  ---@param index Int32---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:SetAutoSmoothTension(index, tension) end
  

  

  
  ---@param range SplineRange---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:SetAutoSmoothTension(range, tension) end
  

  

  
  ---@param index Int32---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:SetAutoSmoothTensionNoNotify(index, tension) end
  

  

  
  ---@param range SplineRange---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:SetAutoSmoothTensionNoNotify(range, tension) end
  

  

  
  ---@param item BezierKnot
  ---@return Int32
  
function CS.UnityEngine.Splines.Spline:IndexOf(item) end
  

  

  
  ---@param index Int32---@param knot BezierKnot
  
  
function CS.UnityEngine.Splines.Spline:Insert(index, knot) end
  

  

  
  ---@param index Int32---@param knot BezierKnot---@param mode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:Insert(index, knot, mode) end
  

  

  
  ---@param index Int32---@param knot BezierKnot---@param mode TangentMode---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:Insert(index, knot, mode, tension) end
  

  

  
  ---@param index Int32
  
  
function CS.UnityEngine.Splines.Spline:RemoveAt(index) end
  

  

  
  ---@param index Int32---@param value BezierKnot---@param main BezierTangent
  
  
function CS.UnityEngine.Splines.Spline:SetKnot(index, value, main) end
  

  

  
  ---@param index Int32---@param value BezierKnot---@param main BezierTangent
  
  
function CS.UnityEngine.Splines.Spline:SetKnotNoNotify(index, value, main) end
  

  

  
  ---@param index Int32
  ---@return BezierCurve
  
function CS.UnityEngine.Splines.Spline:GetCurve(index) end
  

  

  
  ---@param index Int32
  ---@return Single
  
function CS.UnityEngine.Splines.Spline:GetCurveLength(index) end
  

  

  
  
  ---@return Single
  
function CS.UnityEngine.Splines.Spline:GetLength() end
  

  

  
  ---@param curveIndex Int32---@param curveDistance Single
  ---@return Single
  
function CS.UnityEngine.Splines.Spline:GetCurveInterpolation(curveIndex, curveDistance) end
  

  

  
  ---@param index Int32---@param t Single
  ---@return float3
  
function CS.UnityEngine.Splines.Spline:GetCurveUpVector(index, t) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.Spline:Warmup() end
  

  

  
  ---@param newSize Int32
  
  
function CS.UnityEngine.Splines.Spline:Resize(newSize) end
  

  

  
  
  ---@return BezierKnot[]
  
function CS.UnityEngine.Splines.Spline:ToArray() end
  

  

  
  ---@param copyFrom Spline
  
  
function CS.UnityEngine.Splines.Spline:Copy(copyFrom) end
  

  

  
  
  ---@return IEnumerator`1
  
function CS.UnityEngine.Splines.Spline:GetEnumerator() end
  

  

  
  ---@param item BezierKnot
  
  
function CS.UnityEngine.Splines.Spline:Add(item) end
  

  

  
  ---@param knotPosition float3---@param tangentMode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:Add(knotPosition, tangentMode) end
  

  

  
  ---@param knotPositions IEnumerable`1---@param tangentMode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:AddRange(knotPositions, tangentMode) end
  

  

  
  ---@param index Int32---@param knotPosition float3---@param tangentMode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:Insert(index, knotPosition, tangentMode) end
  

  

  
  ---@param index Int32---@param knotPositions IEnumerable`1---@param tangentMode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:InsertRange(index, knotPositions, tangentMode) end
  

  

  
  ---@param item BezierKnot---@param mode TangentMode
  
  
function CS.UnityEngine.Splines.Spline:Add(item, mode) end
  

  

  
  ---@param item BezierKnot---@param mode TangentMode---@param tension Single
  
  
function CS.UnityEngine.Splines.Spline:Add(item, mode, tension) end
  

  

  
  ---@param spline Spline
  
  
function CS.UnityEngine.Splines.Spline:Add(spline) end
  

  

  
  
  
  
function CS.UnityEngine.Splines.Spline:Clear() end
  

  

  
  ---@param item BezierKnot
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:Contains(item) end
  

  

  
  ---@param array BezierKnot[]---@param arrayIndex Int32
  
  
function CS.UnityEngine.Splines.Spline:CopyTo(array, arrayIndex) end
  

  

  
  ---@param item BezierKnot
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:Remove(item) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Splines.Spline:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Splines.Spline:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Splines.Spline:GetType() end
  

  

  
---@param op string
---@param callback function
function CS.UnityEngine.Splines.Spline.Changed(op, callback) end

  
