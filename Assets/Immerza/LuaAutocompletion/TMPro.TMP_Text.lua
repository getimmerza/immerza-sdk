
CS.TMPro = CS.TMPro or {}
---@class CS.TMPro.TMP_Text
CS.TMPro.TMP_Text = CS.TMPro.TMP_Text or {}

  
  ---@param ignoreActiveState Boolean---@param forceTextReparsing Boolean
  
  
function CS.TMPro.TMP_Text:ForceMeshUpdate(ignoreActiveState, forceTextReparsing) end
  

  

  
  ---@param mesh Mesh---@param index Int32
  
  
function CS.TMPro.TMP_Text:UpdateGeometry(mesh, index) end
  

  

  
  ---@param flags TMP_VertexDataUpdateFlags
  
  
function CS.TMPro.TMP_Text:UpdateVertexData(flags) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:UpdateVertexData() end
  

  

  
  ---@param vertices Vector3[]
  
  
function CS.TMPro.TMP_Text:SetVertices(vertices) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:UpdateMeshPadding() end
  

  

  
  ---@param targetColor Color---@param duration Single---@param ignoreTimeScale Boolean---@param useAlpha Boolean
  
  
function CS.TMPro.TMP_Text:CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha) end
  

  

  
  ---@param alpha Single---@param duration Single---@param ignoreTimeScale Boolean
  
  
function CS.TMPro.TMP_Text:CrossFadeAlpha(alpha, duration, ignoreTimeScale) end
  

  

  
  ---@param sourceText String
  
  
function CS.TMPro.TMP_Text:SetText(sourceText) end
  

  

  
  ---@param sourceText String---@param syncTextInputBox Boolean
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, syncTextInputBox) end
  

  

  
  ---@param sourceText String---@param arg0 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single---@param arg3 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2, arg3) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single---@param arg3 Single---@param arg4 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2, arg3, arg4) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single---@param arg3 Single---@param arg4 Single---@param arg5 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2, arg3, arg4, arg5) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single---@param arg3 Single---@param arg4 Single---@param arg5 Single---@param arg6 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2, arg3, arg4, arg5, arg6) end
  

  

  
  ---@param sourceText String---@param arg0 Single---@param arg1 Single---@param arg2 Single---@param arg3 Single---@param arg4 Single---@param arg5 Single---@param arg6 Single---@param arg7 Single
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7) end
  

  

  
  ---@param sourceText StringBuilder
  
  
function CS.TMPro.TMP_Text:SetText(sourceText) end
  

  

  
  ---@param sourceText Char[]
  
  
function CS.TMPro.TMP_Text:SetText(sourceText) end
  

  

  
  ---@param sourceText Char[]---@param start Int32---@param length Int32
  
  
function CS.TMPro.TMP_Text:SetText(sourceText, start, length) end
  

  

  
  ---@param sourceText Char[]
  
  
function CS.TMPro.TMP_Text:SetCharArray(sourceText) end
  

  

  
  ---@param sourceText Char[]---@param start Int32---@param length Int32
  
  
function CS.TMPro.TMP_Text:SetCharArray(sourceText, start, length) end
  

  

  
  
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetPreferredValues() end
  

  

  
  ---@param width Single---@param height Single
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetPreferredValues(width, height) end
  

  

  
  ---@param text String
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetPreferredValues(text) end
  

  

  
  ---@param text String---@param width Single---@param height Single
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetPreferredValues(text, width, height) end
  

  

  
  
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetRenderedValues() end
  

  

  
  ---@param onlyVisibleCharacters Boolean
  ---@return Vector2
  
function CS.TMPro.TMP_Text:GetRenderedValues(onlyVisibleCharacters) end
  

  

  
  ---@param text String
  ---@return TMP_TextInfo
  
function CS.TMPro.TMP_Text:GetTextInfo(text) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:ComputeMarginSize() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:ClearMesh() end
  

  

  
  ---@param uploadGeometry Boolean
  
  
function CS.TMPro.TMP_Text:ClearMesh(uploadGeometry) end
  

  

  
  
  ---@return String
  
function CS.TMPro.TMP_Text:GetParsedText() end
  

  

  
  ---@param baseMaterial Material
  ---@return Material
  
function CS.TMPro.TMP_Text:GetModifiedMaterial(baseMaterial) end
  

  

  
  ---@param clipRect Rect---@param validRect Boolean
  
  
function CS.TMPro.TMP_Text:Cull(clipRect, validRect) end
  

  

  
  ---@param clipRect Rect---@param validRect Boolean
  
  
function CS.TMPro.TMP_Text:SetClipRect(clipRect, validRect) end
  

  

  
  ---@param clipSoftness Vector2
  
  
function CS.TMPro.TMP_Text:SetClipSoftness(clipSoftness) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:ParentMaskStateChanged() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:RecalculateClipping() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:RecalculateMasking() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetAllDirty() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetLayoutDirty() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetVerticesDirty() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetMaterialDirty() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetRaycastDirty() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:OnCullingChanged() end
  

  

  
  ---@param update CanvasUpdate
  
  
function CS.TMPro.TMP_Text:Rebuild(update) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:LayoutComplete() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:GraphicUpdateComplete() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:OnRebuildRequested() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:SetNativeSize() end
  

  

  
  ---@param sp Vector2---@param eventCamera Camera
  ---@return Boolean
  
function CS.TMPro.TMP_Text:Raycast(sp, eventCamera) end
  

  

  
  ---@param point Vector2
  ---@return Vector2
  
function CS.TMPro.TMP_Text:PixelAdjustPoint(point) end
  

  

  
  
  ---@return Rect
  
function CS.TMPro.TMP_Text:GetPixelAdjustedRect() end
  

  

  
  ---@param targetColor Color---@param duration Single---@param ignoreTimeScale Boolean---@param useAlpha Boolean---@param useRGB Boolean
  
  
function CS.TMPro.TMP_Text:CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:RegisterDirtyLayoutCallback(action) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:UnregisterDirtyLayoutCallback(action) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:RegisterDirtyVerticesCallback(action) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:UnregisterDirtyVerticesCallback(action) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:RegisterDirtyMaterialCallback(action) end
  

  

  
  ---@param action UnityAction
  
  
function CS.TMPro.TMP_Text:UnregisterDirtyMaterialCallback(action) end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Text:IsActive() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Text:IsDestroyed() end
  

  

  
  
  ---@return Boolean
  
function CS.TMPro.TMP_Text:IsInvoking() end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:CancelInvoke() end
  

  

  
  ---@param methodName String---@param time Single
  
  
function CS.TMPro.TMP_Text:Invoke(methodName, time) end
  

  

  
  ---@param methodName String---@param time Single---@param repeatRate Single
  
  
function CS.TMPro.TMP_Text:InvokeRepeating(methodName, time, repeatRate) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Text:CancelInvoke(methodName) end
  

  

  
  ---@param methodName String
  ---@return Boolean
  
function CS.TMPro.TMP_Text:IsInvoking(methodName) end
  

  

  
  ---@param methodName String
  ---@return Coroutine
  
function CS.TMPro.TMP_Text:StartCoroutine(methodName) end
  

  

  
  ---@param methodName String---@param value Object
  ---@return Coroutine
  
function CS.TMPro.TMP_Text:StartCoroutine(methodName, value) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.TMPro.TMP_Text:StartCoroutine(routine) end
  

  

  
  ---@param routine IEnumerator
  ---@return Coroutine
  
function CS.TMPro.TMP_Text:StartCoroutine_Auto(routine) end
  

  

  
  ---@param routine IEnumerator
  
  
function CS.TMPro.TMP_Text:StopCoroutine(routine) end
  

  

  
  ---@param routine Coroutine
  
  
function CS.TMPro.TMP_Text:StopCoroutine(routine) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Text:StopCoroutine(methodName) end
  

  

  
  
  
  
function CS.TMPro.TMP_Text:StopAllCoroutines() end
  

  

  
  ---@param type Type
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponent(type) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Text:GetComponent() end
  

  

  
  ---@param type Type---@param component Component&
  ---@return Boolean
  
function CS.TMPro.TMP_Text:TryGetComponent(type, component) end
  

  

  
  ---@param component T&
  ---@return Boolean
  
function CS.TMPro.TMP_Text:TryGetComponent(component) end
  

  

  
  ---@param type String
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponent(type) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponentInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponentInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.TMPro.TMP_Text:GetComponentInChildren(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Text:GetComponentInChildren() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.TMPro.TMP_Text:GetComponentsInChildren(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.TMPro.TMP_Text:GetComponentsInChildren(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.TMPro.TMP_Text:GetComponentsInChildren(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param result List`1
  
  
function CS.TMPro.TMP_Text:GetComponentsInChildren(includeInactive, result) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Text:GetComponentsInChildren() end
  

  

  
  ---@param results List`1
  
  
function CS.TMPro.TMP_Text:GetComponentsInChildren(results) end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponentInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component
  
function CS.TMPro.TMP_Text:GetComponentInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T
  
function CS.TMPro.TMP_Text:GetComponentInParent(includeInactive) end
  

  

  
  
  ---@return T
  
function CS.TMPro.TMP_Text:GetComponentInParent() end
  

  

  
  ---@param t Type---@param includeInactive Boolean
  ---@return Component[]
  
function CS.TMPro.TMP_Text:GetComponentsInParent(t, includeInactive) end
  

  

  
  ---@param t Type
  ---@return Component[]
  
function CS.TMPro.TMP_Text:GetComponentsInParent(t) end
  

  

  
  ---@param includeInactive Boolean
  ---@return T[]
  
function CS.TMPro.TMP_Text:GetComponentsInParent(includeInactive) end
  

  

  
  ---@param includeInactive Boolean---@param results List`1
  
  
function CS.TMPro.TMP_Text:GetComponentsInParent(includeInactive, results) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Text:GetComponentsInParent() end
  

  

  
  ---@param type Type
  ---@return Component[]
  
function CS.TMPro.TMP_Text:GetComponents(type) end
  

  

  
  ---@param type Type---@param results List`1
  
  
function CS.TMPro.TMP_Text:GetComponents(type, results) end
  

  

  
  ---@param results List`1
  
  
function CS.TMPro.TMP_Text:GetComponents(results) end
  

  

  
  
  ---@return T[]
  
function CS.TMPro.TMP_Text:GetComponents() end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Text:GetComponentIndex() end
  

  

  
  ---@param tag String
  ---@return Boolean
  
function CS.TMPro.TMP_Text:CompareTag(tag) end
  

  

  
  ---@param tag TagHandle
  ---@return Boolean
  
function CS.TMPro.TMP_Text:CompareTag(tag) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:SendMessageUpwards(methodName, value, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.TMPro.TMP_Text:SendMessageUpwards(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Text:SendMessageUpwards(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:SendMessageUpwards(methodName, options) end
  

  

  
  ---@param methodName String---@param value Object
  
  
function CS.TMPro.TMP_Text:SendMessage(methodName, value) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Text:SendMessage(methodName) end
  

  

  
  ---@param methodName String---@param value Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:SendMessage(methodName, value, options) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:SendMessage(methodName, options) end
  

  

  
  ---@param methodName String---@param parameter Object---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:BroadcastMessage(methodName, parameter, options) end
  

  

  
  ---@param methodName String---@param parameter Object
  
  
function CS.TMPro.TMP_Text:BroadcastMessage(methodName, parameter) end
  

  

  
  ---@param methodName String
  
  
function CS.TMPro.TMP_Text:BroadcastMessage(methodName) end
  

  

  
  ---@param methodName String---@param options SendMessageOptions
  
  
function CS.TMPro.TMP_Text:BroadcastMessage(methodName, options) end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Text:GetInstanceID() end
  

  

  
  
  ---@return Int32
  
function CS.TMPro.TMP_Text:GetHashCode() end
  

  

  
  ---@param other Object
  ---@return Boolean
  
function CS.TMPro.TMP_Text:Equals(other) end
  

  

  
  
  ---@return String
  
function CS.TMPro.TMP_Text:ToString() end
  

  

  
---@param op string
---@param callback function
function CS.TMPro.TMP_Text.OnFontAssetRequest(op, callback) end

  

  
---@param op string
---@param callback function
function CS.TMPro.TMP_Text.OnSpriteAssetRequest(op, callback) end

  

  
---@param op string
---@param callback function
function CS.TMPro.TMP_Text.OnMissingCharacter(op, callback) end

  
