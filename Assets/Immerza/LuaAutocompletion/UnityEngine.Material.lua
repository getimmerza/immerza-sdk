
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Material
CS.UnityEngine.Material = CS.UnityEngine.Material or {}

  
  ---@param scriptContents String
  ---@return Material
  
function CS.UnityEngine.Material.Create(scriptContents) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasProperty(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasProperty(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasFloat(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasFloat(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasInt(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasInt(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasInteger(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasInteger(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasTexture(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasTexture(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasMatrix(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasMatrix(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasVector(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasVector(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasColor(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasColor(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasBuffer(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasBuffer(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:HasConstantBuffer(name) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:HasConstantBuffer(nameID) end
  

  

  
  ---@param keyword String
  
  
function CS.UnityEngine.Material:EnableKeyword(keyword) end
  

  

  
  ---@param keyword String
  
  
function CS.UnityEngine.Material:DisableKeyword(keyword) end
  

  

  
  ---@param keyword String
  ---@return Boolean
  
function CS.UnityEngine.Material:IsKeywordEnabled(keyword) end
  

  

  
  ---@param keyword LocalKeyword&
  
  
function CS.UnityEngine.Material:EnableKeyword(keyword) end
  

  

  
  ---@param keyword LocalKeyword&
  
  
function CS.UnityEngine.Material:DisableKeyword(keyword) end
  

  

  
  ---@param keyword LocalKeyword&---@param value Boolean
  
  
function CS.UnityEngine.Material:SetKeyword(keyword, value) end
  

  

  
  ---@param keyword LocalKeyword&
  ---@return Boolean
  
function CS.UnityEngine.Material:IsKeywordEnabled(keyword) end
  

  

  
  ---@param passName String---@param enabled Boolean
  
  
function CS.UnityEngine.Material:SetShaderPassEnabled(passName, enabled) end
  

  

  
  ---@param passName String
  ---@return Boolean
  
function CS.UnityEngine.Material:GetShaderPassEnabled(passName) end
  

  

  
  ---@param pass Int32
  ---@return String
  
function CS.UnityEngine.Material:GetPassName(pass) end
  

  

  
  ---@param passName String
  ---@return Int32
  
function CS.UnityEngine.Material:FindPass(passName) end
  

  

  
  ---@param tag String---@param val String
  
  
function CS.UnityEngine.Material:SetOverrideTag(tag, val) end
  

  

  
  ---@param tag String---@param searchFallbacks Boolean---@param defaultValue String
  ---@return String
  
function CS.UnityEngine.Material:GetTag(tag, searchFallbacks, defaultValue) end
  

  

  
  ---@param tag String---@param searchFallbacks Boolean
  ---@return String
  
function CS.UnityEngine.Material:GetTag(tag, searchFallbacks) end
  

  

  
  ---@param start Material---@param end Material---@param t Single
  
  
function CS.UnityEngine.Material:Lerp(start, end, t) end
  

  

  
  ---@param pass Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:SetPass(pass) end
  

  

  
  ---@param mat Material
  
  
function CS.UnityEngine.Material:CopyPropertiesFromMaterial(mat) end
  

  

  
  ---@param mat Material
  
  
function CS.UnityEngine.Material:CopyMatchingPropertiesFromMaterial(mat) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Material:ComputeCRC() end
  

  

  
  
  ---@return String[]
  
function CS.UnityEngine.Material:GetTexturePropertyNames() end
  

  

  
  
  ---@return Int32[]
  
function CS.UnityEngine.Material:GetTexturePropertyNameIDs() end
  

  

  
  ---@param outNames List`1
  
  
function CS.UnityEngine.Material:GetTexturePropertyNames(outNames) end
  

  

  
  ---@param outNames List`1
  
  
function CS.UnityEngine.Material:GetTexturePropertyNameIDs(outNames) end
  

  

  
  ---@param ancestor Material
  ---@return Boolean
  
function CS.UnityEngine.Material:IsChildOf(ancestor) end
  

  

  
  
  
  
function CS.UnityEngine.Material:RevertAllPropertyOverrides() end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyOverriden(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyLocked(nameID) end
  

  

  
  ---@param nameID Int32
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyLockedByAncestor(nameID) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyOverriden(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyLocked(name) end
  

  

  
  ---@param name String
  ---@return Boolean
  
function CS.UnityEngine.Material:IsPropertyLockedByAncestor(name) end
  

  

  
  ---@param nameID Int32---@param value Boolean
  
  
function CS.UnityEngine.Material:SetPropertyLock(nameID, value) end
  

  

  
  ---@param destination Material---@param nameID Int32---@param recordUndo Boolean
  
  
function CS.UnityEngine.Material:ApplyPropertyOverride(destination, nameID, recordUndo) end
  

  

  
  ---@param nameID Int32
  
  
function CS.UnityEngine.Material:RevertPropertyOverride(nameID) end
  

  

  
  ---@param name String---@param value Boolean
  
  
function CS.UnityEngine.Material:SetPropertyLock(name, value) end
  

  

  
  ---@param destination Material---@param name String---@param recordUndo Boolean
  
  
function CS.UnityEngine.Material:ApplyPropertyOverride(destination, name, recordUndo) end
  

  

  
  ---@param name String
  
  
function CS.UnityEngine.Material:RevertPropertyOverride(name) end
  

  

  
  ---@param name String---@param value Int32
  
  
function CS.UnityEngine.Material:SetInt(name, value) end
  

  

  
  ---@param nameID Int32---@param value Int32
  
  
function CS.UnityEngine.Material:SetInt(nameID, value) end
  

  

  
  ---@param name String---@param value Single
  
  
function CS.UnityEngine.Material:SetFloat(name, value) end
  

  

  
  ---@param nameID Int32---@param value Single
  
  
function CS.UnityEngine.Material:SetFloat(nameID, value) end
  

  

  
  ---@param name String---@param value Int32
  
  
function CS.UnityEngine.Material:SetInteger(name, value) end
  

  

  
  ---@param nameID Int32---@param value Int32
  
  
function CS.UnityEngine.Material:SetInteger(nameID, value) end
  

  

  
  ---@param name String---@param value Color
  
  
function CS.UnityEngine.Material:SetColor(name, value) end
  

  

  
  ---@param nameID Int32---@param value Color
  
  
function CS.UnityEngine.Material:SetColor(nameID, value) end
  

  

  
  ---@param name String---@param value Vector4
  
  
function CS.UnityEngine.Material:SetVector(name, value) end
  

  

  
  ---@param nameID Int32---@param value Vector4
  
  
function CS.UnityEngine.Material:SetVector(nameID, value) end
  

  

  
  ---@param name String---@param value Matrix4x4
  
  
function CS.UnityEngine.Material:SetMatrix(name, value) end
  

  

  
  ---@param nameID Int32---@param value Matrix4x4
  
  
function CS.UnityEngine.Material:SetMatrix(nameID, value) end
  

  

  
  ---@param name String---@param value Texture
  
  
function CS.UnityEngine.Material:SetTexture(name, value) end
  

  

  
  ---@param nameID Int32---@param value Texture
  
  
function CS.UnityEngine.Material:SetTexture(nameID, value) end
  

  

  
  ---@param name String---@param value RenderTexture---@param element RenderTextureSubElement
  
  
function CS.UnityEngine.Material:SetTexture(name, value, element) end
  

  

  
  ---@param nameID Int32---@param value RenderTexture---@param element RenderTextureSubElement
  
  
function CS.UnityEngine.Material:SetTexture(nameID, value, element) end
  

  

  
  ---@param name String---@param value ComputeBuffer
  
  
function CS.UnityEngine.Material:SetBuffer(name, value) end
  

  

  
  ---@param nameID Int32---@param value ComputeBuffer
  
  
function CS.UnityEngine.Material:SetBuffer(nameID, value) end
  

  

  
  ---@param name String---@param value GraphicsBuffer
  
  
function CS.UnityEngine.Material:SetBuffer(name, value) end
  

  

  
  ---@param nameID Int32---@param value GraphicsBuffer
  
  
function CS.UnityEngine.Material:SetBuffer(nameID, value) end
  

  

  
  ---@param name String---@param value ComputeBuffer---@param offset Int32---@param size Int32
  
  
function CS.UnityEngine.Material:SetConstantBuffer(name, value, offset, size) end
  

  

  
  ---@param nameID Int32---@param value ComputeBuffer---@param offset Int32---@param size Int32
  
  
function CS.UnityEngine.Material:SetConstantBuffer(nameID, value, offset, size) end
  

  

  
  ---@param name String---@param value GraphicsBuffer---@param offset Int32---@param size Int32
  
  
function CS.UnityEngine.Material:SetConstantBuffer(name, value, offset, size) end
  

  

  
  ---@param nameID Int32---@param value GraphicsBuffer---@param offset Int32---@param size Int32
  
  
function CS.UnityEngine.Material:SetConstantBuffer(nameID, value, offset, size) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:SetFloatArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:SetFloatArray(nameID, values) end
  

  

  
  ---@param name String---@param values Single[]
  
  
function CS.UnityEngine.Material:SetFloatArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values Single[]
  
  
function CS.UnityEngine.Material:SetFloatArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:SetColorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:SetColorArray(nameID, values) end
  

  

  
  ---@param name String---@param values Color[]
  
  
function CS.UnityEngine.Material:SetColorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values Color[]
  
  
function CS.UnityEngine.Material:SetColorArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:SetVectorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:SetVectorArray(nameID, values) end
  

  

  
  ---@param name String---@param values Vector4[]
  
  
function CS.UnityEngine.Material:SetVectorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values Vector4[]
  
  
function CS.UnityEngine.Material:SetVectorArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:SetMatrixArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:SetMatrixArray(nameID, values) end
  

  

  
  ---@param name String---@param values Matrix4x4[]
  
  
function CS.UnityEngine.Material:SetMatrixArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values Matrix4x4[]
  
  
function CS.UnityEngine.Material:SetMatrixArray(nameID, values) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.Material:GetInt(name) end
  

  

  
  ---@param nameID Int32
  ---@return Int32
  
function CS.UnityEngine.Material:GetInt(nameID) end
  

  

  
  ---@param name String
  ---@return Single
  
function CS.UnityEngine.Material:GetFloat(name) end
  

  

  
  ---@param nameID Int32
  ---@return Single
  
function CS.UnityEngine.Material:GetFloat(nameID) end
  

  

  
  ---@param name String
  ---@return Int32
  
function CS.UnityEngine.Material:GetInteger(name) end
  

  

  
  ---@param nameID Int32
  ---@return Int32
  
function CS.UnityEngine.Material:GetInteger(nameID) end
  

  

  
  ---@param name String
  ---@return Color
  
function CS.UnityEngine.Material:GetColor(name) end
  

  

  
  ---@param nameID Int32
  ---@return Color
  
function CS.UnityEngine.Material:GetColor(nameID) end
  

  

  
  ---@param name String
  ---@return Vector4
  
function CS.UnityEngine.Material:GetVector(name) end
  

  

  
  ---@param nameID Int32
  ---@return Vector4
  
function CS.UnityEngine.Material:GetVector(nameID) end
  

  

  
  ---@param name String
  ---@return Matrix4x4
  
function CS.UnityEngine.Material:GetMatrix(name) end
  

  

  
  ---@param nameID Int32
  ---@return Matrix4x4
  
function CS.UnityEngine.Material:GetMatrix(nameID) end
  

  

  
  ---@param name String
  ---@return Texture
  
function CS.UnityEngine.Material:GetTexture(name) end
  

  

  
  ---@param nameID Int32
  ---@return Texture
  
function CS.UnityEngine.Material:GetTexture(nameID) end
  

  

  
  ---@param name String
  ---@return GraphicsBufferHandle
  
function CS.UnityEngine.Material:GetBuffer(name) end
  

  

  
  ---@param name String
  ---@return GraphicsBufferHandle
  
function CS.UnityEngine.Material:GetConstantBuffer(name) end
  

  

  
  ---@param name String
  ---@return Single[]
  
function CS.UnityEngine.Material:GetFloatArray(name) end
  

  

  
  ---@param nameID Int32
  ---@return Single[]
  
function CS.UnityEngine.Material:GetFloatArray(nameID) end
  

  

  
  ---@param name String
  ---@return Color[]
  
function CS.UnityEngine.Material:GetColorArray(name) end
  

  

  
  ---@param nameID Int32
  ---@return Color[]
  
function CS.UnityEngine.Material:GetColorArray(nameID) end
  

  

  
  ---@param name String
  ---@return Vector4[]
  
function CS.UnityEngine.Material:GetVectorArray(name) end
  

  

  
  ---@param nameID Int32
  ---@return Vector4[]
  
function CS.UnityEngine.Material:GetVectorArray(nameID) end
  

  

  
  ---@param name String
  ---@return Matrix4x4[]
  
function CS.UnityEngine.Material:GetMatrixArray(name) end
  

  

  
  ---@param nameID Int32
  ---@return Matrix4x4[]
  
function CS.UnityEngine.Material:GetMatrixArray(nameID) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:GetFloatArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:GetFloatArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:GetColorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:GetColorArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:GetVectorArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:GetVectorArray(nameID, values) end
  

  

  
  ---@param name String---@param values List`1
  
  
function CS.UnityEngine.Material:GetMatrixArray(name, values) end
  

  

  
  ---@param nameID Int32---@param values List`1
  
  
function CS.UnityEngine.Material:GetMatrixArray(nameID, values) end
  

  

  
  ---@param name String---@param value Vector2
  
  
function CS.UnityEngine.Material:SetTextureOffset(name, value) end
  

  

  
  ---@param nameID Int32---@param value Vector2
  
  
function CS.UnityEngine.Material:SetTextureOffset(nameID, value) end
  

  

  
  ---@param name String---@param value Vector2
  
  
function CS.UnityEngine.Material:SetTextureScale(name, value) end
  

  

  
  ---@param nameID Int32---@param value Vector2
  
  
function CS.UnityEngine.Material:SetTextureScale(nameID, value) end
  

  

  
  ---@param name String
  ---@return Vector2
  
function CS.UnityEngine.Material:GetTextureOffset(name) end
  

  

  
  ---@param nameID Int32
  ---@return Vector2
  
function CS.UnityEngine.Material:GetTextureOffset(nameID) end
  

  

  
  ---@param name String
  ---@return Vector2
  
function CS.UnityEngine.Material:GetTextureScale(name) end
  

  

  
  ---@param nameID Int32
  ---@return Vector2
  
function CS.UnityEngine.Material:GetTextureScale(nameID) end
  

  

  
  ---@param type MaterialPropertyType
  ---@return String[]
  
function CS.UnityEngine.Material:GetPropertyNames(type) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Material:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Material:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Material:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Material:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Material:GetType() end
  

  
