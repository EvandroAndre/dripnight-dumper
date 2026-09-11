using System.Collections.Generic;
using UnityEngine;
using proto;

namespace GCommon;

public static class LocLangConvert
{
	private static Dictionary<string, int> langsDic;

	public static string GetAbbr(LocLang lang, bool defaultNull = false, bool forceExceptBn = false)
	{
		return null;
	}

	public static string GetBCP47Abbr(LocLang lang, bool defaultNull = false)
	{
		return null;
	}

	public static string GetAbbrForIOSAIChat(LocLang lang, bool defaultNull = false)
	{
		return null;
	}

	public static string GetAbbrForVoice(LocLang lang)
	{
		return null;
	}

	public static string GetASRAbbr(LocLang lang)
	{
		return null;
	}

	public static LocLang GetLocLang(string abbr)
	{
		return LocLang.None;
	}

	public static LocLang GetLocLang(SystemLanguage systemLan)
	{
		return LocLang.None;
	}

	public static LocLang GetAdvanceLang()
	{
		return LocLang.None;
	}

	public static LocLang GetLang(ESocial.Language loc)
	{
		return LocLang.None;
	}

	public static string GetLocLangName(LocLang loc)
	{
		return null;
	}

	public static string GetLocLangName(ESocial.Language loc)
	{
		return null;
	}

	public static string GetLocLangNamePic(LocLang loc)
	{
		return null;
	}

	public static string GetLocLangNamePic(ESocial.Language loc)
	{
		return null;
	}

	public static List<int> GetSettingLanguageList()
	{
		return null;
	}

	public static List<int> GetLanguageList()
	{
		return null;
	}

	public static List<uint> GetServerLanguageList()
	{
		return null;
	}
}
