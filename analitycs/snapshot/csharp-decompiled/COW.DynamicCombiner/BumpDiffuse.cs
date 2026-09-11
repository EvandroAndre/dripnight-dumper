using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class BumpDiffuse : IShaderConverter
{
	private static readonly int k_MainTex_STID;

	private static readonly int k_BumpMap_STID;

	internal override void Initialize()
	{
	}

	internal override void ExcratProperties(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, Transform transform, ref Dictionary<int, Vector4> output)
	{
	}
}
