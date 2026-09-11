using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class RoomCreateRuleDataManager : SingletonModule<RoomCreateRuleDataManager>
{
	private enum EConfigType
	{
		EConfigType_HP,
		EConfigType_EP,
		EConfigType_Speed,
		EConfigType_JumpHeight,
		EConfigType_RoundNum,
		EConfigType_InitCoin,
		EConfigType_FightClubRoundNum,
		EConfigType_Revive,
		EConfigType_SpecialCSEnv,
		EConfigType_AirDropType
	}

	private class MapConfigInfo
	{
		public uint[] members;

		public uint[] spectators;

		public uint[] levelLimits;

		public uint minMemberCnt;

		public bool enableVoiceChat;

		public bool afkPunish;

		public bool enableIngameVoice;

		public bool enableScoreBoard;

		public uint showWin;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<DropListConfigInfo> _003C_003E9__50_0;

		public static Comparison<DropListConfigInfo> _003C_003E9__50_1;

		public static Comparison<DropListConfigInfo> _003C_003E9__50_2;

		public static Predicate<RoomCreateCSShopData> _003C_003E9__90_0;

		internal int _003CUpdateRoomCreateRuleDrop_003Eb__50_0(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal int _003CUpdateRoomCreateRuleDrop_003Eb__50_1(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal int _003CUpdateRoomCreateRuleDrop_003Eb__50_2(DropListConfigInfo a, DropListConfigInfo b)
		{
			return 0;
		}

		internal bool _003CExcludeOnlyShow_003Eb__90_0(RoomCreateCSShopData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public uint key;

		internal bool _003CGetHPTxtByKey_003Eb__0(HPConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public uint key;

		internal bool _003CGetEPTxtByKey_003Eb__0(EPConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public uint key;

		internal bool _003CGetSpeedTxtByKey_003Eb__0(SpeedConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public uint key;

		internal bool _003CGetJumpHeightTxtByKey_003Eb__0(JumpHeightConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public uint key;

		internal bool _003CGetFightClubRoundNumTxtByKey_003Eb__0(RoundNumConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public uint key;

		internal bool _003CGetRoundNumTxtByKey_003Eb__0(RoundNumConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public uint key;

		internal bool _003CGetInitCoinTxtByKey_003Eb__0(InitCoinConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public uint id;

		internal bool _003CGetDropListTxtById_003Eb__0(DropListConfigInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public uint id;

		internal bool _003CGetDropListConfigInfo_003Eb__0(DropListConfigInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public uint key;

		internal bool _003CGetReviveSwitchTxtByKey_003Eb__0(ReviveConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public uint key;

		internal bool _003CGetMatchStartBuffTxtByKey_003Eb__0(MatchStartBuffConfig a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public uint key;

		internal bool _003CGetAirDropTypeTxtByKey_003Eb__0(RoomCreateRuleHPEPData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public string roundNum;

		internal bool _003CGetRoundNumConfigByText_003Eb__0(RoundNumConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public string initCoin;

		internal bool _003CGetInitCoinConfigByText_003Eb__0(InitCoinConfigInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public string locKey;

		internal bool _003CGetAirDropTypeConfigByLoc_003Eb__0(RoomCreateRuleHPEPData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public RoomCreateRuleDataManager _003C_003E4__this;

		public MapModeData mapModeData;

		internal bool _003CTryGetPresetRoomCreateRule_003Eb__0(PresetRoomCreateRuleInfo e)
		{
			return false;
		}
	}

	public static uint INVALIAD_MAPCONFIGID;

	public static uint CSSHOP_WEAPON_TYPETAB;

	public static uint CSSHOP_ITEM_TYPETAB;

	private bool m_IsRoomCreateRuleDropInited;

	private bool m_IsRoomCreateRulesInited;

	private Dictionary<string, MapConfigInfo> m_MapConfigGroupDic;

	private List<HPConfigInfo> m_HPConfigList;

	private List<EPConfigInfo> m_EPConfigList;

	private List<SpeedConfigInfo> m_SpeedConfigList;

	private List<JumpHeightConfigInfo> m_JumpHeightConfigList;

	private List<DropListConfigInfo> m_DropListConfigList;

	private List<DropListConfigInfo> m_DropListConfigListCS;

	private Dictionary<uint, List<ADCSMapData>> m_RoomCSZoneConfigDic;

	private List<DropListConfigInfo> m_DropListConfigListBomb;

	private List<RoundNumConfigInfo> m_RoundNumConfigList;

	private List<InitCoinConfigInfo> m_InitCoinConfigList;

	private List<RoundNumConfigInfo> m_FightClubRoundNumConfigList;

	private List<ReviveConfigInfo> m_ReviveConfigList;

	private List<MatchStartBuffConfig> m_MatchStartBuffList;

	private List<RoomCreateRuleHPEPData> m_AirDropTypeList;

	private Dictionary<uint, List<RoomCreateCSShopData>> m_CreateRoomCSShopWeaponDic;

	private List<RoomCreateCSShopData> m_CreateRoomCSShopWeaponList;

	private List<RoomCreateCSShopData> m_CreateRoomCSShopItemList;

	private List<uint> m_CSShopTypeTabList;

	private List<RoomCreateCSEcoData> m_CreateRoomCSEcoList;

	private Dictionary<uint, RoomCrateSettingData> m_RoomCrateSettingDict;

	private Dictionary<uint, List<uint>> m_MapConfigIdDic;

	private Dictionary<uint, Dictionary<uint, List<uint>>> m_ModeMapIdDic;

	private Dictionary<uint, List<PresetRoomCreateRuleInfo>> m_PresetRoomCreateRuleDic;

	private List<uint> m_GameModeIdList;

	private List<uint> m_CreateRoomModeSort;

	private HashSet<uint> m_OnlyShowShopItemSet;

	public List<uint> GameModeIdList => null;

	public List<uint> CreateRoomModeSort => null;

	protected override void OnInit()
	{
	}

	private void LoadRoomCreateRuleHPEPData()
	{
	}

	private void LoadRoomCreateCSShop()
	{
	}

	private void LoadRoomCreateCSEco()
	{
	}

	private void LoadRoomCrateSetting()
	{
	}

	public List<RoomCreateCSShopData> GetCSShopWeaponList(uint type, bool excludeOnlyShow)
	{
		return null;
	}

	public List<RoomCreateCSEcoData> GetCSEcoList()
	{
		return null;
	}

	public List<uint> GetCSShopTypeTabList()
	{
		return null;
	}

	public RoomCrateSettingData GetRoomCrateSettingData(uint gameMode)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public void ClearServerDataState()
	{
	}

	public bool IsRoomCreateRuleDropInited()
	{
		return false;
	}

	public void UpdateRoomCreateRuleDrop(List<RoomCreateRuleDropDesc> list)
	{
	}

	public List<uint> GetModeIDListByRoomType(uint roomType)
	{
		return null;
	}

	public List<uint> GetMapIDListByGameModeAndRoomType(uint roomType, uint gameMode)
	{
		return null;
	}

	public uint[] GetMembers(string key)
	{
		return null;
	}

	public uint[] GetSpectators(string key)
	{
		return null;
	}

	public uint[] GetLevelLimits(string key)
	{
		return null;
	}

	public bool GetAFKPunish(string key)
	{
		return false;
	}

	public bool GetScoreBoardPrivilege(string key)
	{
		return false;
	}

	public bool GetRoomVoiceChannelPrivilege(string key)
	{
		return false;
	}

	public uint GetShowWinState(string key)
	{
		return 0u;
	}

	public uint GetMinMembersCount(string key)
	{
		return 0u;
	}

	public bool EnableRoomVoiceChat(string key)
	{
		return false;
	}

	public bool IsKeyValid(string key)
	{
		return false;
	}

	public string PrintDic()
	{
		return null;
	}

	public uint GetFirstMapConfig(uint roomType)
	{
		return 0u;
	}

	public List<HPConfigInfo> GetHPConfigList()
	{
		return null;
	}

	public string GetHPTxtByKey(uint key)
	{
		return null;
	}

	public List<EPConfigInfo> GetEPConfigList()
	{
		return null;
	}

	public string GetEPTxtByKey(uint key)
	{
		return null;
	}

	public List<SpeedConfigInfo> GetSpeedConfigList()
	{
		return null;
	}

	public string GetSpeedTxtByKey(uint key)
	{
		return null;
	}

	public List<JumpHeightConfigInfo> GetJumpHeightConfigList()
	{
		return null;
	}

	public string GetJumpHeightTxtByKey(uint key)
	{
		return null;
	}

	public List<RoundNumConfigInfo> GetFightClubRoundNumConfigList()
	{
		return null;
	}

	public string GetFightClubRoundNumTxtByKey(uint key)
	{
		return null;
	}

	public List<RoundNumConfigInfo> GetRoundNumConfigList()
	{
		return null;
	}

	public string GetRoundNumTxtByKey(uint key)
	{
		return null;
	}

	public List<InitCoinConfigInfo> GetInitCoinConfigList()
	{
		return null;
	}

	public string GetInitCoinTxtByKey(uint key)
	{
		return null;
	}

	public List<DropListConfigInfo> GetDropListConfigList(uint configID)
	{
		return null;
	}

	private List<DropListConfigInfo> GetDropListByGameMode(List<DropListConfigInfo> targetList, uint gamemode)
	{
		return null;
	}

	public string GetDropListTxtById(uint id, uint configID)
	{
		return null;
	}

	public DropListConfigInfo GetDropListConfigInfo(uint id, uint configID)
	{
		return null;
	}

	public List<ReviveConfigInfo> GetReviveConfigList()
	{
		return null;
	}

	public string GetReviveSwitchTxtByKey(uint key)
	{
		return null;
	}

	public List<MatchStartBuffConfig> GetMatchStartBuffList()
	{
		return null;
	}

	public string GetMatchStartBuffTxtByKey(uint key)
	{
		return null;
	}

	public List<RoomCreateRuleHPEPData> GetAirDropTypeList()
	{
		return null;
	}

	public string GetAirDropTypeTxtByKey(uint key)
	{
		return null;
	}

	public bool IsOnlyShowShopItem(uint index)
	{
		return false;
	}

	private List<RoomCreateCSShopData> ExcludeOnlyShow(List<RoomCreateCSShopData> list)
	{
		return null;
	}

	public RoundNumConfigInfo GetRoundNumConfigByText(string roundNum)
	{
		return null;
	}

	public InitCoinConfigInfo GetInitCoinConfigByText(string initCoin)
	{
		return null;
	}

	public RoomCreateRuleHPEPData GetAirDropTypeConfigByLoc(string locKey)
	{
		return null;
	}

	public bool IsRoomCreateRulesInited()
	{
		return false;
	}

	public void UpdateRoomCreateRules(List<RoomCreateRuleDesc> list)
	{
	}

	private bool IsPresetRoomCreateRuleMatch(PresetRoomCreateRuleInfo info, MapModeData mapModeData)
	{
		return false;
	}

	public bool TryGetPresetRoomCreateRule(uint roomRuleID, MapModeData mapModeData, out PresetRoomCreateRuleInfo info)
	{
		info = null;
		return false;
	}

	public bool TryGetPresetRoomModeData(MapModeData mapModeData, out PresetRoomCreateRuleInfo ruleInfo, out DropListConfigInfo dropInfo)
	{
		ruleInfo = null;
		dropInfo = null;
		return false;
	}

	public void UpdateRoomCSZoneConfig(List<RoomCSZoneConfigDesc> list)
	{
	}

	public List<ADCSMapData> GetRoomCSZoneConfigList(uint mapId)
	{
		return null;
	}

	private int _003CGetModeIDListByRoomType_003Eb__51_0(uint a, uint b)
	{
		return 0;
	}
}
