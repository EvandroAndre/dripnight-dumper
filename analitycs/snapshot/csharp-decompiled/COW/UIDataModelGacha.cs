using System.Collections.Generic;
using proto;

namespace COW;

public class UIDataModelGacha
{
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public ClientChestType chestType;

		internal bool _003CProcessGachaFreeDraw_003Eb__0(GachaFreeDrawInfo item)
		{
			return false;
		}
	}

	private static readonly string RULE_CHEST_RULE_TILTE;

	private static readonly string RULE_CHEST_RULE_INFO2;

	private static readonly string RULE_CHEST_WHEEL_HELP_TAB;

	private static readonly string RULE_CHEST_WHEEL_HELP_DESC;

	private static readonly string RULE_CHEST_LEGEND_HELP_TAB;

	private static readonly string RULE_CHEST_LEGEND_HELP_DESC;

	private static readonly string RULE_CHEST_FADED_HELP_TAB;

	private static readonly string RULE_CHEST_FADED_HELP_DESC;

	private static readonly string RULE_CHEST_HACKER_STORE_HELP_TAB;

	private static readonly string RULE_CHEST_HACKER_STORE_HELP_DESC;

	private static readonly string RULE_CHEST_NEW_UNLIMITED_TAB;

	private static readonly string RULE_CHEST_NEW_UNLIMITED_DESC;

	private static readonly string RULE_CHEST_DOUBLEWHEEL_TAB;

	private static readonly string RULE_CHEST_DOUBLEWHEEL_DESC;

	private const string GachaFreeDraw_Prefs = "GachaFreeDraw";

	public GachaCDNAdData GachaCDNInfo;

	public Dictionary<uint, GachaInfoDataBase> GachaAllInfoDic;

	public Dictionary<uint, GachaPackageInfoData> GachaPackageInfoDic;

	public Dictionary<uint, GachaSpDescData> GachaSpDescDic;

	public Dictionary<uint, GachaSpDescData> GachaExchangeDic;

	public Dictionary<uint, GachaResultInfo> GachaResultInfoDic;

	public Dictionary<ELottery.Type, string> GachaTutorialWndTitleKeyDic;

	public Dictionary<ELottery.Type, string> GachaRuleTitleKeyDic;

	public Dictionary<ELottery.Type, string> GachaRuleDescKeyDic;

	public List<ChestLuckyRemindConfigDesc> GachaLuckyConfigDesc;

	private uint m_Month_Max_Reward_Count;

	private long _003CMonth_Max_Reward_TS_003Ek__BackingField;

	private bool _003CMonthMaxRewardCountHasPlused_003Ek__BackingField;

	public uint Month_Max_Reward_Count
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public long Month_Max_Reward_TS
	{
		get
		{
			return _003CMonth_Max_Reward_TS_003Ek__BackingField;
		}
		set
		{
			_003CMonth_Max_Reward_TS_003Ek__BackingField = value;
		}
	}

	public bool MonthMaxRewardCountHasPlused
	{
		get
		{
			return _003CMonthMaxRewardCountHasPlused_003Ek__BackingField;
		}
		set
		{
			_003CMonthMaxRewardCountHasPlused_003Ek__BackingField = value;
		}
	}

	private void CheckMonthMaxRewardTimeStamp()
	{
	}

	public void ClearInfoData()
	{
	}

	public void ProcessSpecialDesc(ChestSpecialExchangeDesc desc)
	{
	}

	public virtual void OnProcessSpecialDesc()
	{
	}

	public void UpdateMonthMaxRewardCount(uint chestID, CSLotteryRes gachaResult)
	{
	}

	public void CacheGachaResult(uint chestID, UIModelGacha.GachaDrawType drawType, CSLotteryRes gachaResult)
	{
	}

	public string GetDefaultChestName(uint chestID, ELottery.Type type)
	{
		return null;
	}

	public string GetDefaultChestRule(uint chestID, ELottery.Type type)
	{
		return null;
	}

	public ELottery.Type GetGachaTypeByID(uint gachaID)
	{
		return ELottery.Type.Type_NORMAL;
	}

	public void ProcessGachaDescInfo(GachaDesc descInfo)
	{
	}

	public GachaInfoDataBase GetGachaInfoByID(uint gachaID)
	{
		return null;
	}

	public GachaInfoDataBase GetGachaInfoByForgeID(uint forgeID)
	{
		return null;
	}

	public ClientChestType GetClientChestTypeByID(uint gachaID)
	{
		return null;
	}

	public void ProcessGachaFreeDraw()
	{
	}

	public void CacheGachaFreeDraw()
	{
	}
}
