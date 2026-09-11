using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class BumpSpecularUGC : IShaderConverter
{
	private static readonly int k_DiffuseIntensityID;

	private static readonly int k_SpecularIntensityID;

	private static readonly int k_SpecularColorID;

	private static readonly int k_ShininessID;

	private static readonly int k_MainTex_STID;

	private static readonly int k_BumpMap_STID;

	internal override void Initialize()
	{
	}

	internal override void ExcratProperties(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, Transform transform, ref Dictionary<int, Vector4> output)
	{
	}
}
