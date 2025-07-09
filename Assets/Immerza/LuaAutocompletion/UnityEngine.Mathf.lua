
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Mathf
CS.UnityEngine.Mathf = CS.UnityEngine.Mathf or {}

  
  ---@param value Single
  ---@return Single
  
function CS.UnityEngine.Mathf.GammaToLinearSpace(value) end
  

  

  
  ---@param value Single
  ---@return Single
  
function CS.UnityEngine.Mathf.LinearToGammaSpace(value) end
  

  

  
  ---@param kelvin Single
  ---@return Color
  
function CS.UnityEngine.Mathf.CorrelatedColorTemperatureToRGB(kelvin) end
  

  

  
  ---@param val Single
  ---@return UInt16
  
function CS.UnityEngine.Mathf.FloatToHalf(val) end
  

  

  
  ---@param val UInt16
  ---@return Single
  
function CS.UnityEngine.Mathf.HalfToFloat(val) end
  

  

  
  ---@param x Single---@param y Single
  ---@return Single
  
function CS.UnityEngine.Mathf.PerlinNoise(x, y) end
  

  

  
  ---@param x Single
  ---@return Single
  
function CS.UnityEngine.Mathf.PerlinNoise1D(x) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Sin(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Cos(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Tan(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Asin(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Acos(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Atan(f) end
  

  

  
  ---@param y Single---@param x Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Atan2(y, x) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Sqrt(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Abs(f) end
  

  

  
  ---@param value Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.Abs(value) end
  

  

  
  ---@param a Single---@param b Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Min(a, b) end
  

  

  
  ---@param values Single[]
  ---@return Single
  
function CS.UnityEngine.Mathf.Min(values) end
  

  

  
  ---@param a Int32---@param b Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.Min(a, b) end
  

  

  
  ---@param values Int32[]
  ---@return Int32
  
function CS.UnityEngine.Mathf.Min(values) end
  

  

  
  ---@param a Single---@param b Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Max(a, b) end
  

  

  
  ---@param values Single[]
  ---@return Single
  
function CS.UnityEngine.Mathf.Max(values) end
  

  

  
  ---@param a Int32---@param b Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.Max(a, b) end
  

  

  
  ---@param values Int32[]
  ---@return Int32
  
function CS.UnityEngine.Mathf.Max(values) end
  

  

  
  ---@param f Single---@param p Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Pow(f, p) end
  

  

  
  ---@param power Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Exp(power) end
  

  

  
  ---@param f Single---@param p Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Log(f, p) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Log(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Log10(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Ceil(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Floor(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Round(f) end
  

  

  
  ---@param f Single
  ---@return Int32
  
function CS.UnityEngine.Mathf.CeilToInt(f) end
  

  

  
  ---@param f Single
  ---@return Int32
  
function CS.UnityEngine.Mathf.FloorToInt(f) end
  

  

  
  ---@param f Single
  ---@return Int32
  
function CS.UnityEngine.Mathf.RoundToInt(f) end
  

  

  
  ---@param f Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Sign(f) end
  

  

  
  ---@param value Single---@param min Single---@param max Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Clamp(value, min, max) end
  

  

  
  ---@param value Int32---@param min Int32---@param max Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.Clamp(value, min, max) end
  

  

  
  ---@param value Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Clamp01(value) end
  

  

  
  ---@param a Single---@param b Single---@param t Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Lerp(a, b, t) end
  

  

  
  ---@param a Single---@param b Single---@param t Single
  ---@return Single
  
function CS.UnityEngine.Mathf.LerpUnclamped(a, b, t) end
  

  

  
  ---@param a Single---@param b Single---@param t Single
  ---@return Single
  
function CS.UnityEngine.Mathf.LerpAngle(a, b, t) end
  

  

  
  ---@param current Single---@param target Single---@param maxDelta Single
  ---@return Single
  
function CS.UnityEngine.Mathf.MoveTowards(current, target, maxDelta) end
  

  

  
  ---@param current Single---@param target Single---@param maxDelta Single
  ---@return Single
  
function CS.UnityEngine.Mathf.MoveTowardsAngle(current, target, maxDelta) end
  

  

  
  ---@param from Single---@param to Single---@param t Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothStep(from, to, t) end
  

  

  
  ---@param value Single---@param absmax Single---@param gamma Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Gamma(value, absmax, gamma) end
  

  

  
  ---@param a Single---@param b Single
  ---@return Boolean
  
function CS.UnityEngine.Mathf.Approximately(a, b) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single---@param maxSpeed Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDamp(current, target, currentVelocity, smoothTime) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single---@param maxSpeed Single---@param deltaTime Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDamp(current, target, currentVelocity, smoothTime, maxSpeed, deltaTime) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single---@param maxSpeed Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDampAngle(current, target, currentVelocity, smoothTime, maxSpeed) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDampAngle(current, target, currentVelocity, smoothTime) end
  

  

  
  ---@param current Single---@param target Single---@param currentVelocity Single&---@param smoothTime Single---@param maxSpeed Single---@param deltaTime Single
  ---@return Single
  
function CS.UnityEngine.Mathf.SmoothDampAngle(current, target, currentVelocity, smoothTime, maxSpeed, deltaTime) end
  

  

  
  ---@param t Single---@param length Single
  ---@return Single
  
function CS.UnityEngine.Mathf.Repeat(t, length) end
  

  

  
  ---@param t Single---@param length Single
  ---@return Single
  
function CS.UnityEngine.Mathf.PingPong(t, length) end
  

  

  
  ---@param a Single---@param b Single---@param value Single
  ---@return Single
  
function CS.UnityEngine.Mathf.InverseLerp(a, b, value) end
  

  

  
  ---@param current Single---@param target Single
  ---@return Single
  
function CS.UnityEngine.Mathf.DeltaAngle(current, target) end
  

  

  
  ---@param value Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.NextPowerOfTwo(value) end
  

  

  
  ---@param value Int32
  ---@return Int32
  
function CS.UnityEngine.Mathf.ClosestPowerOfTwo(value) end
  

  

  
  ---@param value Int32
  ---@return Boolean
  
function CS.UnityEngine.Mathf.IsPowerOfTwo(value) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Mathf:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Mathf:GetHashCode() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Mathf:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Mathf:GetType() end
  

  
