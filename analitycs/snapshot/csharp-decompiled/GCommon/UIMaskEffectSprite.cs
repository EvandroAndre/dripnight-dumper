using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIMaskEffectSprite : UIEffectSprite
{
	private Shader mShader;

	private new Material mMaterial;

	private static Dictionary<int, Dictionary<int, Material>> mCachedAtlasMaterials;

	public override Material material => null;
}
