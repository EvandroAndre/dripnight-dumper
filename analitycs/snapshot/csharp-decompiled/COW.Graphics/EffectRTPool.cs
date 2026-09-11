using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Graphics;

public class EffectRTPool : SingletonModule<EffectRTPool>
{
	private class RTStat
	{
		public bool used;

		public int depth;

		public RTStat(bool u, int d)
		{
		}
	}

	private Dictionary<RenderTexture, RTStat> m_totalRT;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public RenderTexture GetTemporary(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.Default)
	{
		return null;
	}

	public void ReleaseTemporary(RenderTexture tex)
	{
	}

	private bool CheckRenderTexture(RenderTexture tex, RTStat rtStat, int width, int height, int depthBuffer, RenderTextureFormat format)
	{
		return false;
	}
}
