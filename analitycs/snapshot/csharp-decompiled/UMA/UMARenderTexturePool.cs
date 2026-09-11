using System.Collections.Generic;
using UnityEngine;

namespace UMA;

internal class UMARenderTexturePool
{
	private Dictionary<int, List<RenderTexture>> mTexturePool;

	private RenderTextureDescriptor mTextureDescriptor;

	private RenderTextureFormat mTextureFormat;

	public UMARenderTexturePool(RenderTextureFormat textureFMT)
	{
	}

	public void RecylceRenderTexture(RenderTexture rt)
	{
	}

	public RenderTexture GetRenderTexture(int width, int height, bool enableMipmap)
	{
		return null;
	}

	public void Clean()
	{
	}

	private int GetHashKey(int width, int height, bool enableMipmap)
	{
		return 0;
	}

	public static void RelaseSingle(RenderTexture rt)
	{
	}

	public static bool UseRenderTextureGetTemporary()
	{
		return false;
	}
}
