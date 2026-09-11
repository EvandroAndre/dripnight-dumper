using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class BlendShapeDataLoadControl : MonoBehaviour
{
	public SkinnedMeshRenderer[] BlendShapeRenderers;

	public List<BlendShapeDataCompressed> BlendShapeDatasCompressed;

	private bool m_IsBlendshapeDataApplied;

	public void OnEnable()
	{
	}

	public void OnDestroy()
	{
	}

	public bool ApplyBlendShapesCompressed()
	{
		return false;
	}

	private void TryApplyToMeshCompressed(Mesh mesh, SkinnedMeshRenderer smr, Dictionary<string, BlendShapeDataCompressed> table)
	{
	}
}
