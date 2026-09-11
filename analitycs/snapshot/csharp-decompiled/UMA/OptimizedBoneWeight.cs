using System;
using UnityEngine;

namespace UMA;

[Serializable]
public struct OptimizedBoneWeight
{
	public uint boneIndex;

	public uint weight01;

	public uint weight23;

	private static ushort FloatToUShort(float weight)
	{
		return 0;
	}

	private static float ShortToFloat(ushort weight)
	{
		return 0f;
	}

	public static implicit operator OptimizedBoneWeight(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	public static implicit operator OptimizedBoneWeight(UMABoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	public static implicit operator BoneWeight(OptimizedBoneWeight sourceWeight)
	{
		return default(BoneWeight);
	}

	public static implicit operator BoneWeight2(OptimizedBoneWeight sourceWeight)
	{
		return default(BoneWeight2);
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

	public static OptimizedBoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	public static BoneWeight2[] ConvertBoneWeight2(OptimizedBoneWeight[] boneWeights)
	{
		return null;
	}

	public static BoneWeight[] Convert(OptimizedBoneWeight[] boneWeights)
	{
		return null;
	}

	public static OptimizedBoneWeight UpdateBoneIndex(ref OptimizedBoneWeight source, int[] indexMapping)
	{
		return default(OptimizedBoneWeight);
	}
}
