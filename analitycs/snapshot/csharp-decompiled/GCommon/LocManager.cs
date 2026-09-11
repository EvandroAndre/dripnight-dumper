using System.Collections.Generic;
using System.IO;
using GCommon.Loc;
using TsiU;
using UnityEngine;

namespace GCommon;

public class LocManager : TSingleton<LocManager>
{
	public enum LocUseCase : byte
	{
		Both,
		LobbyOnly,
		IngameOnly,
		HotFix
	}

	public enum ImageLocalizeType
	{
		Sprite,
		Atlas
	}

	public class LocOptions
	{
		public bool NoArabic;
	}

	private bool m_Inited;

	private const int CapacityLocTextName = 1000;

	private LocGlobalComponent m_LocGlobal;

	private LocLang m_CurrentLang;

	private string m_CurrentLangAbbr;

	private LocLang m_FontLang;

	private Dictionary<int, LocGlobalComponent.Language> m_Fonts;

	public const uint LocTextIdxMask = 16777215u;

	public const uint INVALID_TRANS_INDEX = 16777215u;

	public const uint LocTextFlagCleared = 2147483648u;

	public const int LocTextFlagsShift = 24;

	public const uint LocTextFlagsMask = 4278190080u;

	private Dictionary<int, uint> m_LocTextHash;

	private Dictionary<string, uint> m_LocTextName;

	private List<string> m_LocTextTranslations;

	public bool FlagFixArabicNameInOtherLanguage;

	public bool HasLobbyOnlyStrings;

	public bool HasInitUILabelRLTFixer;

	public const uint InvalidKeyIndex = 1u;

	public const uint EmptyKeyIndex = 2u;

	public const int PredefinedKeyCnt = 3;

	private string[] m_xmlStrings;

	public readonly LocOptions NoArabicSupport;

	private LocDataTransLazyLoader m_LazyLoader;

	private int m_MultiThreadGet;

	private static int s_Nothing;

	public static int CapacityLocTextHash => 0;

	public LocLang CurrentLanguage => LocLang.None;

	public LocLang FontLanguage => LocLang.None;

	public string Fix(string text, bool all = false)
	{
		return null;
	}

	public void Clear()
	{
	}

	private void EnsureCollectionsInitialized()
	{
	}

	private void AddDefaultKeys()
	{
	}

	public string FixInUILabel(string text)
	{
		return null;
	}

	public string FixArabicInOthersLang(string text, bool needReverse = true)
	{
		return null;
	}

	public string FixArabicCustomInput(string text, bool noRegion)
	{
		return null;
	}

	public static string FixArabicWhenIsArabic(string text, bool needReverse)
	{
		return null;
	}

	private static string FixArabic(string text, bool needReverse = false)
	{
		return null;
	}

	private static string GetUnfixedLocText(UIInput input)
	{
		return null;
	}

	public void Init(LocLang currentLang)
	{
	}

	public void RefreshCurrLang(LocLang currentLang)
	{
	}

	public void SetFontLanguage(LocLang fontLang)
	{
	}

	public void RefreshFont(LocLang currentLang)
	{
	}

	public void ResetSpecifiedFont(LocLang currentLang)
	{
	}

	public void AddTranslation(string translation, bool use_new = true, bool is_hotfix = false)
	{
	}

	public void AddCurrentTranslation(string idStr, string transStr, bool needOverWrite = true)
	{
	}

	private void AfterAddCurrentTranslation()
	{
	}

	public void AfterTranslationsAdded()
	{
	}

	private bool TryGetTranslationFlagIndex(string stringID, out uint flagIdx)
	{
		flagIdx = default(uint);
		return false;
	}

	public bool GetRawTranslation(string stringID, out string trans)
	{
		trans = null;
		return false;
	}

	private bool GetRawTranslation(int stringHash, out string trans)
	{
		trans = null;
		return false;
	}

	private string GetTranslationByFlagIndex(uint flagIdx)
	{
		return null;
	}

	private string GetTranslationByIndex(uint idx)
	{
		return null;
	}

	public void DoLoc(UILabel label, string stringID, object[] param)
	{
	}

	public void DoLocWithOptions(UILabel label, string stringID, LocOptions locOptions, object[] param)
	{
	}

	public void DoLocWithOptions(UILabel label, string stringID, bool noArabic, object[] param)
	{
	}

	private string _DoLoc(string stringID, out bool needFix, object[] param)
	{
		needFix = default(bool);
		return null;
	}

	public uint GetLocId(string stringID, bool mutableStr = false)
	{
		return 0u;
	}

	public string DoLoc(string stringID, object[] param)
	{
		return null;
	}

	public string DoLoc(string stringID)
	{
		return null;
	}

	public string DoLoc(uint locId, object[] param)
	{
		return null;
	}

	public string DoLoc(uint locId)
	{
		return null;
	}

	public string LocOrFix(string stringID, object[] param)
	{
		return null;
	}

	private string DoLocWithOptions(string stringID, LocOptions options, object[] param)
	{
		return null;
	}

	public string DoLocOriginal(string stringID, object[] param)
	{
		return null;
	}

	private void ParseTranslation(string translation, bool use_new, bool is_hotfix = false)
	{
	}

	private void ParseTranslation(string idStr, string transStr, bool needOverWrite = true)
	{
	}

	private void AddTranslation(string id, string trans, LocUseCase useCase, bool needOverWrite, bool nameHashCollided)
	{
	}

	private void AddTranslation(int hashKey, string trans, LocUseCase useCase, bool needOverWrite)
	{
	}

	private void AddTranslation(string id, string trans, LocUseCase useCase, bool needOverWrite)
	{
	}

	private void AddTranslationImpl(string id, string trans, LocUseCase useCase)
	{
	}

	public void UnloadUselessData()
	{
	}

	public bool IsRTLLanguage()
	{
		return false;
	}

	public bool IsLigatureLanguage()
	{
		return false;
	}

	public Font GetFont(FontWeight fontWeight = FontWeight.Normal)
	{
		return null;
	}

	private Font GetFontByLanguage(int langID, FontWeight fontWeight)
	{
		return null;
	}

	public int GetFontLabelTopMargin()
	{
		return 0;
	}

	public void AddCurrentTranslation(TextAsset idText, TextAsset transText, bool needOverWrite = true)
	{
	}

	private void ParseTranslation(TextAsset idText, TextAsset transText, bool transAsBytes, bool needOverWrite = true)
	{
	}

	public void SetMultiThreadGet(int bit, bool v, bool fromMainThread)
	{
	}

	public void TouchMultiThreadGet()
	{
	}

	public bool AddCurrentTranslationLazy(TextAsset idText, FileStream transStream, bool needOverWrite = true)
	{
		return false;
	}

	public static void LogStats(string label = "", bool saveIdx = false)
	{
	}
}
