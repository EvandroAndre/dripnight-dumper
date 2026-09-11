using System;
using UnityEngine;

namespace UMA;

[Serializable]
public struct UMABoneWeight
{
	public int boneIndex0;

	public int boneIndex1;

	public int boneIndex2;

	public int boneIndex3;

	public float weight0;

	public float weight1;

	public float weight2;

	public float weight3;

	public static UMABoneWeight UpdateBoneIndex(ref UMABoneWeight source, int[] indexMapping)
	{
		return default(UMABoneWeight);
	}

	public static implicit operator UMABoneWeight(BoneWeight sourceWeight)
	{
		return default(UMABoneWeight);
	}

	public static implicit operator BoneWeight(UMABoneWeight sourceWeight)
	{
		return default(BoneWeight);
	}

	public static implicit operator BoneWeight2(UMABoneWeight sourceWeight)
	{
		return default(BoneWeight2);
	}

	public void TranslateBoneWeight2(ref BoneWeight2 dest, int[] boneMapping)
	{
	}

	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	public static UMABoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	public static BoneWeight[] Convert(UMABoneWeight[] boneWeights)
	{
		return null;
	}

	public static BoneWeight2[] ConvertBoneWeight2(UMABoneWeight[] boneWeights)
	{
		return null;
	}
}
