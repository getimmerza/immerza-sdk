
CS.UnityEngine = CS.UnityEngine or {}CS.UnityEngine.XR = CS.UnityEngine.XR or {}CS.UnityEngine.XR.Interaction = CS.UnityEngine.XR.Interaction or {}CS.UnityEngine.XR.Interaction.Toolkit = CS.UnityEngine.XR.Interaction.Toolkit or {}CS.UnityEngine.XR.Interaction.Toolkit.Transformers = CS.UnityEngine.XR.Interaction.Toolkit.Transformers or {}
---@class CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer
CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer = CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer or {}

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:OnLink(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:OnGrab(grabInteractable) end
  

  

  
  ---@param grabInteractable XRGrabInteractable---@param targetPose Pose---@param localScale Vector3
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:OnGrabCountChanged(grabInteractable, targetPose, localScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable---@param updatePhase UpdatePhase---@param targetPose Pose&---@param localScale Vector3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:Process(grabInteractable, updatePhase, targetPose, localScale) end
  

  

  
  ---@param grabInteractable XRGrabInteractable
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:OnUnlink(grabInteractable) end
  

  

  
  ---@param initialScale float3&---@param targetScale float3&---@param initialBoundsSize float3&---@param innerRadius Single
  ---@return Single
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.FastCalculateRadiusOffset$BurstManaged(initialScale, targetScale, initialBoundsSize, innerRadius) end
  

  

  
  ---@param interactorAttachPos float3&---@param interactorAttachRot quaternion&---@param positionOffset float3&---@param interactableRot quaternion&---@param interactableAttachRot quaternion&---@param targetPos float3&---@param targetRot quaternion&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.FastComputeNewTrackedPose$BurstManaged(interactorAttachPos, interactorAttachRot, positionOffset, interactableRot, interactableAttachRot, targetPos, targetRot) end
  

  

  
  ---@param a float3&---@param b float3&---@param radius Single
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.IsWithinRadius$BurstManaged(a, b, radius) end
  

  

  
  ---@param boundsSize float3&---@param fixedSize float3&---@param initialScale float3&---@param epsilon Single---@param newScale float3&
  
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer.CalculateScaleToFit$BurstManaged(boundsSize, fixedSize, initialScale, epsilon, newScale) end
  

  

  
  ---@param obj Object
  ---@return Boolean
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:Equals(obj) end
  

  

  
  
  ---@return Int32
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:GetHashCode() end
  

  

  
  
  ---@return Type
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:GetType() end
  

  

  
  
  ---@return String
  
function CS.UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer:ToString() end
  

  
