using System.Collections.Generic;
using GCommon;

namespace COW;

public class RegionLangManager
{
	private static readonly string RegionLanguagePath;

	public static List<int> s_langList;

	public static int s_langFlag;

	public static LocLang s_defaultLang;

	public static LocLang CheckLanguage(LocLang locLang)
	{
		return LocLang.None;
	}

	public static void Init(string region, string IPRegion, bool beforeHotUpdate)
	{
	}
}
