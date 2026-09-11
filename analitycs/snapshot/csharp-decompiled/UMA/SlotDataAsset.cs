using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class SlotDataAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	public string slotName;

	[NonSerialized]
	public int nameHash;

	public UMAMaterial material;

	public float overlayScale;

	public string[] animatedBoneNames;

	public int[] animatedBoneHashes;

	public UMAMeshAsset meshAsset;

	public int subMeshIndex;

	public string slotGroup;

	public string[] dynamicBoneRoots;

	public UMADynamicBoneProperties[] dynamicBones;

	public UMADynamicBoneColliderProperties[] dynamicBoneColliders;

	public List<HangStringProperty> fluxAssets;

	public OverlayDataAsset overlayAsset;

	public string GetAssetName()
	{
		return null;
	}

	public int GetNameHash()
	{
		return 0;
	}

	public virtual AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}

	public bool ValidateDynamicBones()
	{
		return false;
	}

	public UMAMeshData GetMeshData()
	{
		return null;
	}

	public int GetTextureChannelCount(UMAGeneratorBase generator)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public void UpdateMeshAsset(UMAMeshAsset mas)
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
