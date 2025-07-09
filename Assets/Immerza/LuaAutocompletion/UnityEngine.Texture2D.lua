
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Texture2D
CS.UnityEngine.Texture2D = CS.UnityEngine.Texture2D or {}

  
  ---@param highQuality Boolean
  
  
function CS.UnityEngine.Texture2D:Compress(highQuality) end
  

  

  
  
  
  
function CS.UnityEngine.Texture2D:ClearRequestedMipmapLevel() end
  

  

  
  
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:IsRequestedMipmapLevelLoaded() end
  

  

  
  
  
  
function CS.UnityEngine.Texture2D:ClearMinimumMipmapLevel() end
  

  

  
  ---@param nativeTex IntPtr
  
  
function CS.UnityEngine.Texture2D:UpdateExternalTexture(nativeTex) end
  

  

  
  
  ---@return Byte[]
  
function CS.UnityEngine.Texture2D:GetRawTextureData() end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32---@param miplevel Int32
  ---@return Color[]
  
function CS.UnityEngine.Texture2D:GetPixels(x, y, blockWidth, blockHeight, miplevel) end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32
  ---@return Color[]
  
function CS.UnityEngine.Texture2D:GetPixels(x, y, blockWidth, blockHeight) end
  

  

  
  ---@param miplevel Int32
  ---@return Color32[]
  
function CS.UnityEngine.Texture2D:GetPixels32(miplevel) end
  

  

  
  
  ---@return Color32[]
  
function CS.UnityEngine.Texture2D:GetPixels32() end
  

  

  
  ---@param textures Texture2D[]---@param padding Int32---@param maximumAtlasSize Int32---@param makeNoLongerReadable Boolean
  ---@return Rect[]
  
function CS.UnityEngine.Texture2D:PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable) end
  

  

  
  ---@param textures Texture2D[]---@param padding Int32---@param maximumAtlasSize Int32
  ---@return Rect[]
  
function CS.UnityEngine.Texture2D:PackTextures(textures, padding, maximumAtlasSize) end
  

  

  
  ---@param textures Texture2D[]---@param padding Int32
  ---@return Rect[]
  
function CS.UnityEngine.Texture2D:PackTextures(textures, padding) end
  

  

  
  ---@param width Int32---@param height Int32---@param format TextureFormat---@param mipChain Boolean---@param linear Boolean---@param nativeTex IntPtr
  ---@return Texture2D
  
function CS.UnityEngine.Texture2D.CreateExternalTexture(width, height, format, mipChain, linear, nativeTex) end
  

  

  
  ---@param x Int32---@param y Int32---@param color Color
  
  
function CS.UnityEngine.Texture2D:SetPixel(x, y, color) end
  

  

  
  ---@param x Int32---@param y Int32---@param color Color---@param mipLevel Int32
  
  
function CS.UnityEngine.Texture2D:SetPixel(x, y, color, mipLevel) end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32---@param colors Color[]---@param miplevel Int32
  
  
function CS.UnityEngine.Texture2D:SetPixels(x, y, blockWidth, blockHeight, colors, miplevel) end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32---@param colors Color[]
  
  
function CS.UnityEngine.Texture2D:SetPixels(x, y, blockWidth, blockHeight, colors) end
  

  

  
  ---@param colors Color[]---@param miplevel Int32
  
  
function CS.UnityEngine.Texture2D:SetPixels(colors, miplevel) end
  

  

  
  ---@param colors Color[]
  
  
function CS.UnityEngine.Texture2D:SetPixels(colors) end
  

  

  
  ---@param x Int32---@param y Int32
  ---@return Color
  
function CS.UnityEngine.Texture2D:GetPixel(x, y) end
  

  

  
  ---@param x Int32---@param y Int32---@param mipLevel Int32
  ---@return Color
  
function CS.UnityEngine.Texture2D:GetPixel(x, y, mipLevel) end
  

  

  
  ---@param u Single---@param v Single
  ---@return Color
  
function CS.UnityEngine.Texture2D:GetPixelBilinear(u, v) end
  

  

  
  ---@param u Single---@param v Single---@param mipLevel Int32
  ---@return Color
  
function CS.UnityEngine.Texture2D:GetPixelBilinear(u, v, mipLevel) end
  

  

  
  ---@param data IntPtr---@param size Int32
  
  
function CS.UnityEngine.Texture2D:LoadRawTextureData(data, size) end
  

  

  
  ---@param data Byte[]
  
  
function CS.UnityEngine.Texture2D:LoadRawTextureData(data) end
  

  

  
  ---@param data NativeArray`1
  
  
function CS.UnityEngine.Texture2D:LoadRawTextureData(data) end
  

  

  
  ---@param data T[]---@param mipLevel Int32---@param sourceDataStartIndex Int32
  
  
function CS.UnityEngine.Texture2D:SetPixelData(data, mipLevel, sourceDataStartIndex) end
  

  

  
  ---@param data NativeArray`1---@param mipLevel Int32---@param sourceDataStartIndex Int32
  
  
function CS.UnityEngine.Texture2D:SetPixelData(data, mipLevel, sourceDataStartIndex) end
  

  

  
  ---@param mipLevel Int32
  ---@return NativeArray`1
  
function CS.UnityEngine.Texture2D:GetPixelData(mipLevel) end
  

  

  
  
  ---@return NativeArray`1
  
function CS.UnityEngine.Texture2D:GetRawTextureData() end
  

  

  
  ---@param updateMipmaps Boolean---@param makeNoLongerReadable Boolean
  
  
function CS.UnityEngine.Texture2D:Apply(updateMipmaps, makeNoLongerReadable) end
  

  

  
  ---@param updateMipmaps Boolean
  
  
function CS.UnityEngine.Texture2D:Apply(updateMipmaps) end
  

  

  
  
  
  
function CS.UnityEngine.Texture2D:Apply() end
  

  

  
  ---@param width Int32---@param height Int32
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Reinitialize(width, height) end
  

  

  
  ---@param width Int32---@param height Int32---@param format TextureFormat---@param hasMipMap Boolean
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Reinitialize(width, height, format, hasMipMap) end
  

  

  
  ---@param width Int32---@param height Int32---@param format GraphicsFormat---@param hasMipMap Boolean
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Reinitialize(width, height, format, hasMipMap) end
  

  

  
  ---@param width Int32---@param height Int32
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Resize(width, height) end
  

  

  
  ---@param width Int32---@param height Int32---@param format TextureFormat---@param hasMipMap Boolean
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Resize(width, height, format, hasMipMap) end
  

  

  
  ---@param width Int32---@param height Int32---@param format GraphicsFormat---@param hasMipMap Boolean
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Resize(width, height, format, hasMipMap) end
  

  

  
  ---@param source Rect---@param destX Int32---@param destY Int32---@param recalculateMipMaps Boolean
  
  
function CS.UnityEngine.Texture2D:ReadPixels(source, destX, destY, recalculateMipMaps) end
  

  

  
  ---@param source Rect---@param destX Int32---@param destY Int32
  
  
function CS.UnityEngine.Texture2D:ReadPixels(source, destX, destY) end
  

  

  
  ---@param sizes Vector2[]---@param padding Int32---@param atlasSize Int32---@param results List`1
  ---@return Boolean
  
function CS.UnityEngine.Texture2D.GenerateAtlas(sizes, padding, atlasSize, results) end
  

  

  
  ---@param colors Color32[]---@param miplevel Int32
  
  
function CS.UnityEngine.Texture2D:SetPixels32(colors, miplevel) end
  

  

  
  ---@param colors Color32[]
  
  
function CS.UnityEngine.Texture2D:SetPixels32(colors) end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32---@param colors Color32[]---@param miplevel Int32
  
  
function CS.UnityEngine.Texture2D:SetPixels32(x, y, blockWidth, blockHeight, colors, miplevel) end
  

  

  
  ---@param x Int32---@param y Int32---@param blockWidth Int32---@param blockHeight Int32---@param colors Color32[]
  
  
function CS.UnityEngine.Texture2D:SetPixels32(x, y, blockWidth, blockHeight, colors) end
  

  

  
  ---@param miplevel Int32
  ---@return Color[]
  
function CS.UnityEngine.Texture2D:GetPixels(miplevel) end
  

  

  
  
  ---@return Color[]
  
function CS.UnityEngine.Texture2D:GetPixels() end
  

  

  
  ---@param src Texture
  
  
function CS.UnityEngine.Texture2D:CopyPixels(src) end
  

  

  
  ---@param src Texture---@param srcElement Int32---@param srcMip Int32---@param dstMip Int32
  
  
function CS.UnityEngine.Texture2D:CopyPixels(src, srcElement, srcMip, dstMip) end
  

  

  
  ---@param src Texture---@param srcElement Int32---@param srcMip Int32---@param srcX Int32---@param srcY Int32---@param srcWidth Int32---@param srcHeight Int32---@param dstMip Int32---@param dstX Int32---@param dstY Int32
  
  
function CS.UnityEngine.Texture2D:CopyPixels(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstMip, dstX, dstY) end
  

  

  
  
  ---@return IntPtr
  
function CS.UnityEngine.Texture2D:GetNativeTexturePtr() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Texture2D:GetNativeTextureID() end
  

  

  
  
  
  
function CS.UnityEngine.Texture2D:IncrementUpdateCount() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Texture2D:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Texture2D:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Texture2D:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Texture2D:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Texture2D:GetType() end
  

  
