
CS.UnityEngine = CS.UnityEngine or {}
---@class CS.UnityEngine.Mesh
CS.UnityEngine.Mesh = CS.UnityEngine.Mesh or {}

  
  ---@param indexCount Int32---@param format IndexFormat
  
  
function CS.UnityEngine.Mesh:SetIndexBufferParams(indexCount, format) end
  

  

  
  ---@param index Int32
  ---@return VertexAttributeDescriptor
  
function CS.UnityEngine.Mesh:GetVertexAttribute(index) end
  

  

  
  ---@param attr VertexAttribute
  ---@return Boolean
  
function CS.UnityEngine.Mesh:HasVertexAttribute(attr) end
  

  

  
  ---@param attr VertexAttribute
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexAttributeDimension(attr) end
  

  

  
  ---@param attr VertexAttribute
  ---@return VertexAttributeFormat
  
function CS.UnityEngine.Mesh:GetVertexAttributeFormat(attr) end
  

  

  
  ---@param attr VertexAttribute
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexAttributeStream(attr) end
  

  

  
  ---@param attr VertexAttribute
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexAttributeOffset(attr) end
  

  

  
  ---@param stream Int32
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexBufferStride(stream) end
  

  

  
  ---@param index Int32
  ---@return IntPtr
  
function CS.UnityEngine.Mesh:GetNativeVertexBufferPtr(index) end
  

  

  
  
  ---@return IntPtr
  
function CS.UnityEngine.Mesh:GetNativeIndexBufferPtr() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:ClearBlendShapes() end
  

  

  
  ---@param shapeIndex Int32
  ---@return String
  
function CS.UnityEngine.Mesh:GetBlendShapeName(shapeIndex) end
  

  

  
  ---@param blendShapeName String
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetBlendShapeIndex(blendShapeName) end
  

  

  
  ---@param shapeIndex Int32
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetBlendShapeFrameCount(shapeIndex) end
  

  

  
  ---@param shapeIndex Int32---@param frameIndex Int32
  ---@return Single
  
function CS.UnityEngine.Mesh:GetBlendShapeFrameWeight(shapeIndex, frameIndex) end
  

  

  
  ---@param shapeIndex Int32---@param frameIndex Int32---@param deltaVertices Vector3[]---@param deltaNormals Vector3[]---@param deltaTangents Vector3[]
  
  
function CS.UnityEngine.Mesh:GetBlendShapeFrameVertices(shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents) end
  

  

  
  ---@param shapeName String---@param frameWeight Single---@param deltaVertices Vector3[]---@param deltaNormals Vector3[]---@param deltaTangents Vector3[]
  
  
function CS.UnityEngine.Mesh:AddBlendShapeFrame(shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents) end
  

  

  
  ---@param bonesPerVertex NativeArray`1---@param weights NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetBoneWeights(bonesPerVertex, weights) end
  

  

  
  
  ---@return NativeArray`1
  
function CS.UnityEngine.Mesh:GetAllBoneWeights() end
  

  

  
  
  ---@return NativeArray`1
  
function CS.UnityEngine.Mesh:GetBonesPerVertex() end
  

  

  
  
  ---@return NativeArray`1
  
function CS.UnityEngine.Mesh:GetBindposes() end
  

  

  
  ---@param poses NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetBindposes(poses) end
  

  

  
  ---@param index Int32---@param desc SubMeshDescriptor---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMesh(index, desc, flags) end
  

  

  
  ---@param index Int32
  ---@return SubMeshDescriptor
  
function CS.UnityEngine.Mesh:GetSubMesh(index) end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:MarkModified() end
  

  

  
  ---@param uvSetIndex Int32
  ---@return Single
  
function CS.UnityEngine.Mesh:GetUVDistributionMetric(uvSetIndex) end
  

  

  
  ---@param vertices List`1
  
  
function CS.UnityEngine.Mesh:GetVertices(vertices) end
  

  

  
  ---@param inVertices List`1
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices) end
  

  

  
  ---@param inVertices List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length) end
  

  

  
  ---@param inVertices List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length, flags) end
  

  

  
  ---@param inVertices Vector3[]
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices) end
  

  

  
  ---@param inVertices Vector3[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length) end
  

  

  
  ---@param inVertices Vector3[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length, flags) end
  

  

  
  ---@param inVertices NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices) end
  

  

  
  ---@param inVertices NativeArray`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length) end
  

  

  
  ---@param inVertices NativeArray`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertices(inVertices, start, length, flags) end
  

  

  
  ---@param normals List`1
  
  
function CS.UnityEngine.Mesh:GetNormals(normals) end
  

  

  
  ---@param inNormals List`1
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals) end
  

  

  
  ---@param inNormals List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length) end
  

  

  
  ---@param inNormals List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length, flags) end
  

  

  
  ---@param inNormals Vector3[]
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals) end
  

  

  
  ---@param inNormals Vector3[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length) end
  

  

  
  ---@param inNormals Vector3[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length, flags) end
  

  

  
  ---@param inNormals NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals) end
  

  

  
  ---@param inNormals NativeArray`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length) end
  

  

  
  ---@param inNormals NativeArray`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetNormals(inNormals, start, length, flags) end
  

  

  
  ---@param tangents List`1
  
  
function CS.UnityEngine.Mesh:GetTangents(tangents) end
  

  

  
  ---@param inTangents List`1
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents) end
  

  

  
  ---@param inTangents List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length) end
  

  

  
  ---@param inTangents List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length, flags) end
  

  

  
  ---@param inTangents Vector4[]
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents) end
  

  

  
  ---@param inTangents Vector4[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length) end
  

  

  
  ---@param inTangents Vector4[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length, flags) end
  

  

  
  ---@param inTangents NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents) end
  

  

  
  ---@param inTangents NativeArray`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length) end
  

  

  
  ---@param inTangents NativeArray`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetTangents(inTangents, start, length, flags) end
  

  

  
  ---@param colors List`1
  
  
function CS.UnityEngine.Mesh:GetColors(colors) end
  

  

  
  ---@param inColors List`1
  
  
function CS.UnityEngine.Mesh:SetColors(inColors) end
  

  

  
  ---@param inColors List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length) end
  

  

  
  ---@param inColors List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length, flags) end
  

  

  
  ---@param inColors Color[]
  
  
function CS.UnityEngine.Mesh:SetColors(inColors) end
  

  

  
  ---@param inColors Color[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length) end
  

  

  
  ---@param inColors Color[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length, flags) end
  

  

  
  ---@param colors List`1
  
  
function CS.UnityEngine.Mesh:GetColors(colors) end
  

  

  
  ---@param inColors List`1
  
  
function CS.UnityEngine.Mesh:SetColors(inColors) end
  

  

  
  ---@param inColors List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length) end
  

  

  
  ---@param inColors List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length, flags) end
  

  

  
  ---@param inColors Color32[]
  
  
function CS.UnityEngine.Mesh:SetColors(inColors) end
  

  

  
  ---@param inColors Color32[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length) end
  

  

  
  ---@param inColors Color32[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length, flags) end
  

  

  
  ---@param inColors NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetColors(inColors) end
  

  

  
  ---@param inColors NativeArray`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length) end
  

  

  
  ---@param inColors NativeArray`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetColors(inColors, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs List`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs Vector2[]
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs Vector3[]
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs Vector4[]
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs Vector2[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs Vector2[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs Vector3[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs Vector3[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs Vector4[]---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs Vector4[]---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs NativeArray`1---@param start Int32---@param length Int32
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length) end
  

  

  
  ---@param channel Int32---@param uvs NativeArray`1---@param start Int32---@param length Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetUVs(channel, uvs, start, length, flags) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:GetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:GetUVs(channel, uvs) end
  

  

  
  ---@param channel Int32---@param uvs List`1
  
  
function CS.UnityEngine.Mesh:GetUVs(channel, uvs) end
  

  

  
  
  ---@return VertexAttributeDescriptor[]
  
function CS.UnityEngine.Mesh:GetVertexAttributes() end
  

  

  
  ---@param attributes VertexAttributeDescriptor[]
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexAttributes(attributes) end
  

  

  
  ---@param attributes List`1
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetVertexAttributes(attributes) end
  

  

  
  ---@param vertexCount Int32---@param attributes VertexAttributeDescriptor[]
  
  
function CS.UnityEngine.Mesh:SetVertexBufferParams(vertexCount, attributes) end
  

  

  
  ---@param vertexCount Int32---@param attributes NativeArray`1
  
  
function CS.UnityEngine.Mesh:SetVertexBufferParams(vertexCount, attributes) end
  

  

  
  ---@param data NativeArray`1---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param stream Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertexBufferData(data, dataStart, meshBufferStart, count, stream, flags) end
  

  

  
  ---@param data T[]---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param stream Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertexBufferData(data, dataStart, meshBufferStart, count, stream, flags) end
  

  

  
  ---@param data List`1---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param stream Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetVertexBufferData(data, dataStart, meshBufferStart, count, stream, flags) end
  

  

  
  ---@param mesh Mesh
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AcquireReadOnlyMeshData(mesh) end
  

  

  
  ---@param meshes Mesh[]
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AcquireReadOnlyMeshData(meshes) end
  

  

  
  ---@param meshes List`1
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AcquireReadOnlyMeshData(meshes) end
  

  

  
  ---@param meshCount Int32
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AllocateWritableMeshData(meshCount) end
  

  

  
  ---@param mesh Mesh
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AllocateWritableMeshData(mesh) end
  

  

  
  ---@param meshes Mesh[]
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AllocateWritableMeshData(meshes) end
  

  

  
  ---@param meshes List`1
  ---@return MeshDataArray
  
function CS.UnityEngine.Mesh.AllocateWritableMeshData(meshes) end
  

  

  
  ---@param data MeshDataArray---@param mesh Mesh---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, mesh, flags) end
  

  

  
  ---@param data MeshDataArray---@param meshes Mesh[]---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, meshes, flags) end
  

  

  
  ---@param data MeshDataArray---@param meshes List`1---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, meshes, flags) end
  

  

  
  ---@param index Int32
  ---@return GraphicsBuffer
  
function CS.UnityEngine.Mesh:GetVertexBuffer(index) end
  

  

  
  
  ---@return GraphicsBuffer
  
function CS.UnityEngine.Mesh:GetIndexBuffer() end
  

  

  
  ---@param layout SkinWeights
  ---@return GraphicsBuffer
  
function CS.UnityEngine.Mesh:GetBoneWeightBuffer(layout) end
  

  

  
  ---@param layout BlendShapeBufferLayout
  ---@return GraphicsBuffer
  
function CS.UnityEngine.Mesh:GetBlendShapeBuffer(layout) end
  

  

  
  
  ---@return GraphicsBuffer
  
function CS.UnityEngine.Mesh:GetBlendShapeBuffer() end
  

  

  
  ---@param blendShapeIndex Int32
  ---@return BlendShapeBufferRange
  
function CS.UnityEngine.Mesh:GetBlendShapeBufferRange(blendShapeIndex) end
  

  

  
  ---@param submesh Int32
  ---@return Int32[]
  
function CS.UnityEngine.Mesh:GetTriangles(submesh) end
  

  

  
  ---@param submesh Int32---@param applyBaseVertex Boolean
  ---@return Int32[]
  
function CS.UnityEngine.Mesh:GetTriangles(submesh, applyBaseVertex) end
  

  

  
  ---@param triangles List`1---@param submesh Int32
  
  
function CS.UnityEngine.Mesh:GetTriangles(triangles, submesh) end
  

  

  
  ---@param triangles List`1---@param submesh Int32---@param applyBaseVertex Boolean
  
  
function CS.UnityEngine.Mesh:GetTriangles(triangles, submesh, applyBaseVertex) end
  

  

  
  ---@param triangles List`1---@param submesh Int32---@param applyBaseVertex Boolean
  
  
function CS.UnityEngine.Mesh:GetTriangles(triangles, submesh, applyBaseVertex) end
  

  

  
  ---@param submesh Int32
  ---@return Int32[]
  
function CS.UnityEngine.Mesh:GetIndices(submesh) end
  

  

  
  ---@param submesh Int32---@param applyBaseVertex Boolean
  ---@return Int32[]
  
function CS.UnityEngine.Mesh:GetIndices(submesh, applyBaseVertex) end
  

  

  
  ---@param indices List`1---@param submesh Int32
  
  
function CS.UnityEngine.Mesh:GetIndices(indices, submesh) end
  

  

  
  ---@param indices List`1---@param submesh Int32---@param applyBaseVertex Boolean
  
  
function CS.UnityEngine.Mesh:GetIndices(indices, submesh, applyBaseVertex) end
  

  

  
  ---@param indices List`1---@param submesh Int32---@param applyBaseVertex Boolean
  
  
function CS.UnityEngine.Mesh:GetIndices(indices, submesh, applyBaseVertex) end
  

  

  
  ---@param data NativeArray`1---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetIndexBufferData(data, dataStart, meshBufferStart, count, flags) end
  

  

  
  ---@param data T[]---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetIndexBufferData(data, dataStart, meshBufferStart, count, flags) end
  

  

  
  ---@param data List`1---@param dataStart Int32---@param meshBufferStart Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetIndexBufferData(data, dataStart, meshBufferStart, count, flags) end
  

  

  
  ---@param submesh Int32
  ---@return UInt32
  
function CS.UnityEngine.Mesh:GetIndexStart(submesh) end
  

  

  
  ---@param submesh Int32
  ---@return UInt32
  
function CS.UnityEngine.Mesh:GetIndexCount(submesh) end
  

  

  
  ---@param submesh Int32
  ---@return UInt32
  
function CS.UnityEngine.Mesh:GetBaseVertex(submesh) end
  

  

  
  ---@param triangles Int32[]---@param submesh Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh) end
  

  

  
  ---@param triangles Int32[]---@param submesh Int32---@param calculateBounds Boolean
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds) end
  

  

  
  ---@param triangles Int32[]---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles Int32[]---@param trianglesStart Int32---@param trianglesLength Int32---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles UInt16[]---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles UInt16[]---@param trianglesStart Int32---@param trianglesLength Int32---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles List`1---@param submesh Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh) end
  

  

  
  ---@param triangles List`1---@param submesh Int32---@param calculateBounds Boolean
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds) end
  

  

  
  ---@param triangles List`1---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles List`1---@param trianglesStart Int32---@param trianglesLength Int32---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles List`1---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param triangles List`1---@param trianglesStart Int32---@param trianglesLength Int32---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices Int32[]---@param topology MeshTopology---@param submesh Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh) end
  

  

  
  ---@param indices Int32[]---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds) end
  

  

  
  ---@param indices Int32[]---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices Int32[]---@param indicesStart Int32---@param indicesLength Int32---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices UInt16[]---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices UInt16[]---@param indicesStart Int32---@param indicesLength Int32---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices NativeArray`1---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices NativeArray`1---@param indicesStart Int32---@param indicesLength Int32---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices List`1---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices List`1---@param indicesStart Int32---@param indicesLength Int32---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices List`1---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param indices List`1---@param indicesStart Int32---@param indicesLength Int32---@param topology MeshTopology---@param submesh Int32---@param calculateBounds Boolean---@param baseVertex Int32
  
  
function CS.UnityEngine.Mesh:SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex) end
  

  

  
  ---@param desc SubMeshDescriptor[]---@param start Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, start, count, flags) end
  

  

  
  ---@param desc SubMeshDescriptor[]---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, flags) end
  

  

  
  ---@param desc List`1---@param start Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, start, count, flags) end
  

  

  
  ---@param desc List`1---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, flags) end
  

  

  
  ---@param desc NativeArray`1---@param start Int32---@param count Int32---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, start, count, flags) end
  

  

  
  ---@param desc NativeArray`1---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:SetSubMeshes(desc, flags) end
  

  

  
  ---@param bindposes List`1
  
  
function CS.UnityEngine.Mesh:GetBindposes(bindposes) end
  

  

  
  ---@param boneWeights List`1
  
  
function CS.UnityEngine.Mesh:GetBoneWeights(boneWeights) end
  

  

  
  ---@param keepVertexLayout Boolean
  
  
function CS.UnityEngine.Mesh:Clear(keepVertexLayout) end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:Clear() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:RecalculateBounds() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:RecalculateNormals() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:RecalculateTangents() end
  

  

  
  ---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:RecalculateBounds(flags) end
  

  

  
  ---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:RecalculateNormals(flags) end
  

  

  
  ---@param flags MeshUpdateFlags
  
  
function CS.UnityEngine.Mesh:RecalculateTangents(flags) end
  

  

  
  ---@param uvSetIndex Int32---@param uvAreaThreshold Single
  
  
function CS.UnityEngine.Mesh:RecalculateUVDistributionMetric(uvSetIndex, uvAreaThreshold) end
  

  

  
  ---@param uvAreaThreshold Single
  
  
function CS.UnityEngine.Mesh:RecalculateUVDistributionMetrics(uvAreaThreshold) end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:MarkDynamic() end
  

  

  
  ---@param markNoLongerReadable Boolean
  
  
function CS.UnityEngine.Mesh:UploadMeshData(markNoLongerReadable) end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:Optimize() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:OptimizeIndexBuffers() end
  

  

  
  
  
  
function CS.UnityEngine.Mesh:OptimizeReorderVertexBuffer() end
  

  

  
  ---@param submesh Int32
  ---@return MeshTopology
  
function CS.UnityEngine.Mesh:GetTopology(submesh) end
  

  

  
  ---@param combine CombineInstance[]---@param mergeSubMeshes Boolean---@param useMatrices Boolean---@param hasLightmapData Boolean
  
  
function CS.UnityEngine.Mesh:CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData) end
  

  

  
  ---@param combine CombineInstance[]---@param mergeSubMeshes Boolean---@param useMatrices Boolean
  
  
function CS.UnityEngine.Mesh:CombineMeshes(combine, mergeSubMeshes, useMatrices) end
  

  

  
  ---@param combine CombineInstance[]---@param mergeSubMeshes Boolean
  
  
function CS.UnityEngine.Mesh:CombineMeshes(combine, mergeSubMeshes) end
  

  

  
  ---@param combine CombineInstance[]
  
  
function CS.UnityEngine.Mesh:CombineMeshes(combine) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.Mesh:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.UnityEngine.Mesh:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.Mesh:ToString() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.Mesh:GetType() end
  

  
