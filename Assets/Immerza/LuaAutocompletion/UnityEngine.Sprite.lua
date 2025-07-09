
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Sprite
CS.UnityEngine.Sprite = CS.UnityEngine.Sprite or {}

  
  
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetSecondaryTextureCount() end
  

  

  
  ---@param secondaryTexture SecondarySpriteTexture[]
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetSecondaryTextures(secondaryTexture) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetPhysicsShapeCount() end
  

  

  
  
  ---@return UInt32
  
function CS.UnityEngine.Sprite:GetScriptableObjectsCount() end
  

  

  
  ---@param scriptableObjects ScriptableObject[]
  ---@return UInt32
  
function CS.UnityEngine.Sprite:GetScriptableObjects(scriptableObjects) end
  

  

  
  ---@param obj ScriptableObject
  ---@return Boolean
  
function CS.UnityEngine.Sprite:AddScriptableObject(obj) end
  

  

  
  ---@param i UInt32
  ---@return Boolean
  
function CS.UnityEngine.Sprite:RemoveScriptableObjectAt(i) end
  

  

  
  ---@param obj ScriptableObject---@param i UInt32
  ---@return Boolean
  
function CS.UnityEngine.Sprite:SetScriptableObjectAt(obj, i) end
  

  

  
  ---@param shapeIdx Int32
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetPhysicsShapePointCount(shapeIdx) end
  

  

  
  ---@param shapeIdx Int32---@param physicsShape List`1
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetPhysicsShape(shapeIdx, physicsShape) end
  

  

  
  ---@param physicsShapes IList`1
  
  
function CS.UnityEngine.Sprite:OverridePhysicsShape(physicsShapes) end
  

  

  
  ---@param vertices Vector2[]---@param triangles UInt16[]
  
  
function CS.UnityEngine.Sprite:OverrideGeometry(vertices, triangles) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single---@param extrude UInt32---@param meshType SpriteMeshType---@param border Vector4---@param generateFallbackPhysicsShape Boolean
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border, generateFallbackPhysicsShape) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single---@param extrude UInt32---@param meshType SpriteMeshType---@param border Vector4---@param generateFallbackPhysicsShape Boolean---@param secondaryTextures SecondarySpriteTexture[]
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border, generateFallbackPhysicsShape, secondaryTextures) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single---@param extrude UInt32---@param meshType SpriteMeshType---@param border Vector4
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single---@param extrude UInt32---@param meshType SpriteMeshType
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single---@param extrude UInt32
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2---@param pixelsPerUnit Single
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit) end
  

  

  
  ---@param texture Texture2D---@param rect Rect---@param pivot Vector2
  ---@return Sprite
  
function CS.UnityEngine.Sprite.Create(texture, rect, pivot) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Sprite:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Sprite:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Sprite:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Sprite:GetType() end
  

  
