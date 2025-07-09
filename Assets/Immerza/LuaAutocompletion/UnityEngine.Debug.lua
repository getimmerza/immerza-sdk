
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Debug
CS.UnityEngine.Debug = CS.UnityEngine.Debug or {}

  
  ---@param start Vector3---@param end Vector3---@param color Color---@param duration Single
  
  
function CS.UnityEngine.Debug.DrawLine(start, end, color, duration) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param color Color
  
  
function CS.UnityEngine.Debug.DrawLine(start, end, color) end
  

  

  
  ---@param start Vector3---@param end Vector3
  
  
function CS.UnityEngine.Debug.DrawLine(start, end) end
  

  

  
  ---@param start Vector3---@param end Vector3---@param color Color---@param duration Single---@param depthTest Boolean
  
  
function CS.UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest) end
  

  

  
  ---@param start Vector3---@param dir Vector3---@param color Color---@param duration Single
  
  
function CS.UnityEngine.Debug.DrawRay(start, dir, color, duration) end
  

  

  
  ---@param start Vector3---@param dir Vector3---@param color Color
  
  
function CS.UnityEngine.Debug.DrawRay(start, dir, color) end
  

  

  
  ---@param start Vector3---@param dir Vector3
  
  
function CS.UnityEngine.Debug.DrawRay(start, dir) end
  

  

  
  ---@param start Vector3---@param dir Vector3---@param color Color---@param duration Single---@param depthTest Boolean
  
  
function CS.UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest) end
  

  

  
  
  
  
function CS.UnityEngine.Debug.Break() end
  

  

  
  
  
  
function CS.UnityEngine.Debug.DebugBreak() end
  

  

  
  ---@param buffer Byte*---@param bufferMax Int32---@param projectFolder String
  ---@return Int32
  
function CS.UnityEngine.Debug.ExtractStackTraceNoAlloc(buffer, bufferMax, projectFolder) end
  

  

  
  ---@param message Object
  
  
function CS.UnityEngine.Debug.Log(message) end
  

  

  
  ---@param message Object---@param context Object
  
  
function CS.UnityEngine.Debug.Log(message, context) end
  

  

  
  ---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogFormat(format, args) end
  

  

  
  ---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogFormat(context, format, args) end
  

  

  
  ---@param logType LogType---@param logOptions LogOption---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogFormat(logType, logOptions, context, format, args) end
  

  

  
  ---@param message Object
  
  
function CS.UnityEngine.Debug.LogError(message) end
  

  

  
  ---@param message Object---@param context Object
  
  
function CS.UnityEngine.Debug.LogError(message, context) end
  

  

  
  ---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogErrorFormat(format, args) end
  

  

  
  ---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogErrorFormat(context, format, args) end
  

  

  
  
  
  
function CS.UnityEngine.Debug.ClearDeveloperConsole() end
  

  

  
  ---@param exception Exception
  
  
function CS.UnityEngine.Debug.LogException(exception) end
  

  

  
  ---@param exception Exception---@param context Object
  
  
function CS.UnityEngine.Debug.LogException(exception, context) end
  

  

  
  ---@param message Object
  
  
function CS.UnityEngine.Debug.LogWarning(message) end
  

  

  
  ---@param message Object---@param context Object
  
  
function CS.UnityEngine.Debug.LogWarning(message, context) end
  

  

  
  ---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogWarningFormat(format, args) end
  

  

  
  ---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogWarningFormat(context, format, args) end
  

  

  
  ---@param condition Boolean
  
  
function CS.UnityEngine.Debug.Assert(condition) end
  

  

  
  ---@param condition Boolean---@param context Object
  
  
function CS.UnityEngine.Debug.Assert(condition, context) end
  

  

  
  ---@param condition Boolean---@param message Object
  
  
function CS.UnityEngine.Debug.Assert(condition, message) end
  

  

  
  ---@param condition Boolean---@param message String
  
  
function CS.UnityEngine.Debug.Assert(condition, message) end
  

  

  
  ---@param condition Boolean---@param message Object---@param context Object
  
  
function CS.UnityEngine.Debug.Assert(condition, message, context) end
  

  

  
  ---@param condition Boolean---@param message String---@param context Object
  
  
function CS.UnityEngine.Debug.Assert(condition, message, context) end
  

  

  
  ---@param condition Boolean---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.AssertFormat(condition, format, args) end
  

  

  
  ---@param condition Boolean---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.AssertFormat(condition, context, format, args) end
  

  

  
  ---@param message Object
  
  
function CS.UnityEngine.Debug.LogAssertion(message) end
  

  

  
  ---@param message Object---@param context Object
  
  
function CS.UnityEngine.Debug.LogAssertion(message, context) end
  

  

  
  ---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogAssertionFormat(format, args) end
  

  

  
  ---@param context Object---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.LogAssertionFormat(context, format, args) end
  

  

  
  
  ---@return StartupLog[]
  
function CS.UnityEngine.Debug.RetrieveStartupLogs() end
  

  

  
  ---@param level IntegrityCheckLevel
  ---@return String
  
function CS.UnityEngine.Debug.CheckIntegrity(level) end
  

  

  
  ---@param level ValidationLevel
  ---@return Boolean
  
function CS.UnityEngine.Debug.IsValidationLevelEnabled(level) end
  

  

  
  ---@param condition Boolean---@param format String---@param args Object[]
  
  
function CS.UnityEngine.Debug.Assert(condition, format, args) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.Debug:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Debug:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Debug:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Debug:ToString() end
  

  
