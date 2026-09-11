using System;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMAMeshAsset : ScriptableObject, ISerializationCallbackReceiver, INameProvider
{
	public string meshName;

	[NonSerialized]
	public int nameHash;

	public string[] animatedBoneNames;

	public int[] animatedBoneHashes;

	public UMAMeshData meshData;

	public string slotGroup;

	public string GetAssetName()
	{
		return null;
	}

	public int GetNameHash()
	{
		return 0;
	}

	public void Release()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static bool GetMaleInfoByName(string assetName, ref bool isMale)
	{
		return false;
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void Assign(UMAMeshAsset source)
	{
	}
}
