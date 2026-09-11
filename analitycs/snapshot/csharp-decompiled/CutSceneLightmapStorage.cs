using System;
using UnityEngine;

public class CutSceneLightmapStorage : MonoBehaviour
{
	[Serializable]
	public class RendererInfo
	{
		public Renderer renderer;

		public int lightmapIndex;

		public Vector4 lightmapOffsetScale;
	}

	[Serializable]
	public class LightInfo
	{
		public Light light;

		public int lightmapBaketype;

		public int mixedLightingMode;
	}

	public RendererInfo[] m_RendererInfo;

	public Texture2D[] m_Lightmaps;

	public Texture2D[] m_ShadowMasks;

	public LightInfo[] m_LightInfo;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	private void ApplyRendererInfo(RendererInfo[] infos, int[] lightmapOffsetIndex, LightInfo[] lightsInfo)
	{
	}

	private void SetAllLightBaked(LightInfo[] lightsInfo)
	{
	}
}
