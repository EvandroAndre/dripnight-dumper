using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class DiffuseColorUGC : IShaderConverter
{
	private static readonly int k_BrightnessID;

	private static readonly int k_ColorID;

	private static readonly int k_LightingOnLowID;

	private static readonly int k_MainTex_STID;

	internal override void Initialize()
	{
	}

	internal override void ExcratProperties(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, Transform transform, ref Dictionary<int, Vector4> output)
	{
	}
}
