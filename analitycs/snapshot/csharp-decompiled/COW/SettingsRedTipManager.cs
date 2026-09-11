using System;
using System.Collections.Generic;

namespace COW;

public static class SettingsRedTipManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SettingHint, uint> _003C_003E9__4_0;

		internal uint _003CInit_003Eb__4_0(SettingHint value)
		{
			return 0u;
		}
	}

	private static bool m_isInitialized;

	private static Dictionary<uint, SettingHint> m_settingHintData;

	private static Dictionary<uint, int> m_idToBitIndexCache;

	public static Dictionary<uint, uint> SettingPageTypeToETipsType;

	private const uint ID_PREFIX = 10000000u;

	private const uint MAIN_TYPE_PREFIX = 19900000u;

	public static void Init()
	{
	}

	private static void InitializeRedTips()
	{
	}

	private static void ParseSettingId(uint id, out SettingPageType pageType, out SettingMainType mainType, out uint itemId)
	{
		pageType = default(SettingPageType);
		mainType = default(SettingMainType);
		itemId = default(uint);
	}

	public static ETipsType GetSettingMainTypeETips(SettingMainType mainType)
	{
		return ETipsType.None;
	}

	private static void InsertTipsHierarchy(SettingHint data, SettingPageType pageType, SettingMainType mainType, uint itemId)
	{
	}

	public static bool ShouldShowEntranceRedTip()
	{
		return false;
	}

	private static void BuildIdToBitIndexCache()
	{
	}

	private static int GetBitIndex(uint id)
	{
		return 0;
	}

	private static string GenerateLeafKey(string version)
	{
		return null;
	}

	public static void RecordHasLeafRedTipShown(uint id, bool isShown)
	{
	}

	public static bool GetHasLeafRedTipShown(uint id)
	{
		return false;
	}

	public static bool IsRedTipAbleToShow(uint id)
	{
		return false;
	}

	public static void RegisterRedTip(uint id, ERedTipLevel level, UITipsNormalController tipsCtrl)
	{
	}
}
