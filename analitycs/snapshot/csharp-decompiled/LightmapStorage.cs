using System;
using System.Collections.Generic;
using UnityEngine;

public class LightmapStorage : MonoBehaviour
{
	[Serializable]
	private struct RendererInfo
	{
		public Renderer renderer;

		public int lightmapIndex;

		public Vector4 lightmapOffsetScale;
	}

	private List<Texture2D> m_Lightmaps;

	private List<RendererInfo> m_RendererInfos;

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SaveLightmapInfo()
	{
	}
}
