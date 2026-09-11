using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCOutlineEffect : MonoBehaviour
{
	private List<Renderer> m_MeshRenders;

	private Material m_OutlineMat;

	private bool m_HasInited;

	private static readonly int _OutlineWidthID;

	private static readonly int _OutlineColorID;

	private static readonly int _OutlineAlphaID;

	private static readonly int _ZWriteID;

	private static readonly int _ZTestID;

	private static string _staticShaderName;

	public void SetOutlineEffect(float width, int colorValue, float alpha, bool noBlock)
	{
	}

	private void SetOutlineEffectInternal(float width, Color color, float alpha, bool noBlock)
	{
	}

	private Shader GetOutlineShader()
	{
		return null;
	}

	private void InitOutlineMat()
	{
	}

	private void InitMeshInfo()
	{
	}

	private void EnsureOutlineIsLast(Renderer renderer)
	{
	}

	private void RemoveOutline(Renderer renderer)
	{
	}

	public void OnDestroy()
	{
	}
}
