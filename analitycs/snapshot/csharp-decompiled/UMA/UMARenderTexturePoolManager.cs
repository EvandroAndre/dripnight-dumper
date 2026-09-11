using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public class UMARenderTexturePoolManager
{
	private static UMARenderTexturePoolManager _instance;

	public static int MAX_CACHE;

	public static int freeCount;

	private Dictionary<int, UMARenderTexturePool> mPools;

	public static UMARenderTexturePoolManager instance => null;

	private UMARenderTexturePoolManager()
	{
	}

	public RenderTexture GetRenderTexture(int width, int height, RenderTextureFormat textFormat, bool enableMipmap)
	{
		return null;
	}

	public void RecycleRenderTexture(RenderTexture rt)
	{
	}

	public void Clear()
	{
	}

	private UMARenderTexturePool GetPool(RenderTextureFormat textFormat)
	{
		return null;
	}

	public bool UseRenderTextureGetTemporary()
	{
		return false;
	}
}
