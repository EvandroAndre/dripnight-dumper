using System;
using UnityEngine;

namespace COW;

public class UMAImpl : IUMAInterface
{
	public GameObject GetAssetIndexResource()
	{
		return null;
	}

	public static int Get1pTextureScale(int scale)
	{
		return 0;
	}

	public static int Get3pTextureScale(bool useHighQualityAvatar, bool isTeammate)
	{
		return 0;
	}

	public static float GetNormalSpecTexScale(bool forEp = false)
	{
		return 0f;
	}

	public static bool GetUsingRGB565(bool for1P, bool foringame)
	{
		return false;
	}

	public static float GetAtlasResolutionScale()
	{
		return 0f;
	}

	public static int GetIngameShowModelTextureScale()
	{
		return 0;
	}

	public Type GetDynamicAssetLoaderType()
	{
		return null;
	}
}
