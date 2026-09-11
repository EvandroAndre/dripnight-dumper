using System;
using UnityEngine;

namespace UMA;

[Serializable]
public struct OptimizedBoneWeightV2
{
	public uint boneIndex;

	public uint weight;

	private static int FloatToByte(float x)
	{
		return 0;
	}

	private static float ByteToFloat(uint x)
	{
		return 0f;
	}

	public static uint ConvertToUInt(float x, float y, float z, float w)
	{
		return 0u;
	}

	public static implicit operator OptimizedBoneWeightV2(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	public static implicit operator OptimizedBoneWeightV2(OptimizedBoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	public static implicit operator BoneWeight(OptimizedBoneWeightV2 sourceWeight)
	{
		return default(BoneWeight);
	}

	public static BoneWeight[] Convert(OptimizedBoneWeightV2[] boneWeights)
	{
		return null;
	}

	public static implicit operator BoneWeight2(OptimizedBoneWeightV2 sourceWeight)
	{
		return default(BoneWeight2);
	}

	public static BoneWeight2[] ConvertBoneWeight2(OptimizedBoneWeightV2[] boneWeights)
	{
		return null;
	}

	public static OptimizedBoneWeightV2[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	public void TranslateBoneWeight2(ref BoneWeight2 dest, int[] boneMapping)
	{
	}

	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	public void ExplicitTranslateBoneWeight2(ref BoneWeight2 dest, int[] boneMapping)
	{
	}

	public void ExplicitTranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	public static OptimizedBoneWeightV2 UpdateBoneIndex(ref OptimizedBoneWeightV2 source, int[] indexMapping)
	{
		return default(OptimizedBoneWeightV2);
	}
}
