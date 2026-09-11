using System.Collections.Generic;
using proto;

namespace COW;

public static class PhotoFilterSettingFakeData
{
	public static bool IsFakeFx(int id)
	{
		return false;
	}

	public static string TryGetFakeFxResource(int id)
	{
		return null;
	}

	public static void InjectFakeFxData(Dictionary<int, PhotoFilterSettingDesc> dic)
	{
	}
}
