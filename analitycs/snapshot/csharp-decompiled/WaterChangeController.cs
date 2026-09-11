using System.Collections.Generic;
using UnityEngine;

public class WaterChangeController : MonoBehaviour
{
	public List<Material> WaterMaterials;

	public Color StartColor;

	public Color EndColor;

	public Color StartFogColor;

	public Color EndFogColor;

	private static readonly int m_ColorID;

	private static readonly int m_FogColorID;

	private float m_Blend1;

	private float m_Blend2;

	private bool m_Dirty;

	public void SetBlend1(float rate)
	{
	}

	public void SetBlend2(float rate)
	{
	}

	private void Update()
	{
	}

	private void UpdateBlend()
	{
	}
}
