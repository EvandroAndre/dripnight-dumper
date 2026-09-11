using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelWeaponPower : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AccountLeaderboardItem, LeaderBoardInfo> _003C_003E9__93_0;

		public static Comparison<WeaponPowerInfo> _003C_003E9__132_0;

		public static Comparison<WeaponPowerUpdateInfo> _003C_003E9__144_0;

		public static Comparison<WeaponPowerUpdateInfo> _003C_003E9__144_1;

		internal LeaderBoardInfo _003CSetWPLeaderBoardInfoData_003Eb__93_0(AccountLeaderboardItem item)
		{
			return null;
		}

		internal int _003CGetWeaponPowerValueListTopNumArray_003Eb__132_0(WeaponPowerInfo x, WeaponPowerInfo y)
		{
			return 0;
		}

		internal int _003CSetWeaponPowerAfterMatch_003Eb__144_0(WeaponPowerUpdateInfo x, WeaponPowerUpdateInfo y)
		{
			return 0;
		}

		internal int _003CSetWeaponPowerAfterMatch_003Eb__144_1(WeaponPowerUpdateInfo x, WeaponPowerUpdateInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public ELeaderboard.LeaderboardMainType leaderBoardType;

		internal bool _003CGetWeaponPowerLeaderBoardId_003Eb__0(WeaponPowerLeaderboardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public uint titleConfigID;

		internal bool _003CGetRegionByTitleConfigID_003Eb__0(WeaponPowerLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		internal void _003CRequestWeaponPowerDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		internal void _003CRequestWeaponPowerInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass152_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		internal void _003CRequestReceiveWeaponPowerTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass153_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		internal void _003CRequestAccountWeaponPowerValueInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		public Vector2Int WPLeaderBoardType;

		public uint notifyPropID;

		public int mainType;

		internal void _003CRequestWeaponPowerLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass155_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		public uint matchMode;

		internal void _003CRequestInheritSeasonWeaponPower_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public UIModelWeaponPower _003C_003E4__this;

		public string cmd;

		public bool isHide;

		internal void _003CRequestSetHidePlayerInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public WeaponPowerPlayerTitleInfo titleInfo;

		internal bool _003CProcessTitlesDic_003Eb__0(WeaponPowerLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public WeaponPowerPlayerTitleInfo playerTitleInfo;

		internal bool _003CTryRefreshTitleSelectedState_003Eb__0(proto.WeaponPowerTitleInfo x)
		{
			return false;
		}
	}

	public const uint PropID_WeaponPowerReady = 1u;

	public const uint PropID_GetWeaponPowerDesc = 2u;

	public const uint PropID_GetWeaponPowerInfo = 4u;

	public const uint PropID_ReceiveWeaponPowerTitle = 8u;

	public const uint PropID_GetWeaponPowerValueInfo = 16u;

	public const uint PropID_GetWeaponPowerLeaderBoardInfo = 32u;

	public const uint PropID_GetInheritSeasonWeaponPower = 64u;

	public const uint PropID_GetNextTargetLeaderBoardInfo = 128u;

	public const uint PropID_WeaponPowerTitleInfoUpdate = 256u;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private CSWeaponPowerLeaderboardDescRes m_WeaponPowerDesc;

	private CSWeaponPowerLeaderboardInfoRes m_WeaponPowerInfo;

	private readonly List<WeaponPowerUpdateInfo> m_BRWPUpdateInfoList;

	private readonly List<WeaponPowerUpdateInfo> m_CSWPUpdateInfoList;

	private readonly Dictionary<uint, WeaponPowerInfo> m_DicBRWeaponPowerValue;

	private readonly Dictionary<uint, WeaponPowerInfo> m_DicCSWeaponPowerValue;

	private readonly Dictionary<uint, WeaponPowerPlayerTitleInfo> m_DicIdToWeaponPowerTitles;

	private readonly Dictionary<Vector4, List<uint>> m_DictWeaponTypeToWeaponID;

	private readonly Dictionary<uint, List<uint>> m_DictMatchModeToWeaponTypeID;

	private readonly List<uint> m_WeaponPowerNewTitleIDList;

	private readonly Dictionary<uint, WeaponPowerPlayerTitleInfo> m_DicWeaponIDToWeaponPowerTitles;

	private readonly Dictionary<Vector2Int, AreaLeaderboardCacheInfo> m_DicWPLeaderBoardTypeToInfo;

	private Dictionary<string, Dictionary<uint, WeaponPowerLeaderboardDesc>> m_DicRegionToDicWPLeaderboardDesc;

	private WeaponPowerLeaderboardSettingsDesc m_LocalPlayerSettingDesc;

	private uint m_ReadyFlag;

	private bool m_IsWeaponPowerValueListGet;

	private bool m_NeedAutoSelect;

	private static string COUNTRY_TITLE_REWARDTIME;

	private static string PROVINCE_TITLE_REWARDTIME;

	private static string CITY_TITLE_REWARDTIME;

	public const uint BRCS_RANK_LEADERBOARD_SELF_MAX_RANK = 299u;

	private StringBuilder m_WeaponPowerRuleStringBuilder;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private const uint ALL_STEP_READY = 22u;

	private static string INGAME_SHOW_LEADERBOARD_TITLE_FIRST_CLICK;

	private CNHEEMNHGCN m_LeaderboardTitleShowReq;

	private bool? m_IngameShowLeaderboardTitleFirstClickChatBtn;

	private string IngameShowLeaderboardTitleFirstClickKey;

	private float m_IngameLastShowLeaderboardTitleTime;

	private bool m_HasRefreshedWeaponPowerLeaderBoardInfo;

	private Dictionary<Vector3, uint> m_DicTitleDataToIconTypeList;

	private List<Vector3> m_ListTitleData;

	public bool IngameShowLeaderboardTitleFirstClickChatBtn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float IngameLastShowLeaderboardTitleTime => 0f;

	private uint ReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsBrSwitchOpen => false;

	public bool IsCsSwitchOpen => false;

	public bool NeedAutoSelect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint WeaponNumLimit => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void ProcessLeaderboardDesc(List<CSWeaponPowerLeaderboardDescRes.RegionDesc> regionDescs)
	{
	}

	private void ProcessNewTitleIDsList(List<WeaponPowerPlayerTitleInfo> weaponPowerPlayerTitleInfoList)
	{
	}

	private void ProcessTitlesDic(List<WeaponPowerPlayerTitleInfo> weaponPowerPlayerTitleInfoList)
	{
	}

	private void ProcessTitlesRewardList()
	{
	}

	private void ProcessWeaponPowerValueData(List<WeaponPowerInfo> brList, List<WeaponPowerInfo> csList)
	{
	}

	private void ProcessIconTypeToTitleDataDic()
	{
	}

	private void ProcessWeaponTypeToWeaponIDDic(List<WeaponPowerSwitchDesc> weaponPowerSwitchList)
	{
	}

	private void ProcessMatchModeToWeaponTypeDic(uint matchMode, AGACNOCEEFP weaponData)
	{
	}

	private void ProcessWeaponTypeToWeaponIDDicByModeType(Vector4 typeKey, uint weaponID)
	{
	}

	public bool IsWeaponInWeaponTypeToWeaponIDDic(Vector4 typeKey, uint weaponID)
	{
		return false;
	}

	private void RefreshWeaponPowerValueList(List<WeaponPowerInfo> wpValueList, bool isBR)
	{
	}

	private void RefreshTitlesDicByNew(List<WeaponPowerPlayerTitleInfo> newTitleList)
	{
	}

	public bool TryRefreshTitleSelectedState()
	{
		return false;
	}

	public ELeaderBoardTitleRegionType GetWeaponPowerLeaderBoardRegionTypeByID(ulong id, string region)
	{
		return ELeaderBoardTitleRegionType.None;
	}

	public int SortWeaponPowerPlayerTitleList(WeaponPowerPlayerTitleInfo x, WeaponPowerPlayerTitleInfo y)
	{
		return 0;
	}

	private int SortWeaponPowerTitleList(proto.WeaponPowerTitleInfo x, proto.WeaponPowerTitleInfo y)
	{
		return 0;
	}

	private void SortWeaponTypeList()
	{
	}

	private int SortTcpWeaponPowerTitleList(tcp.WeaponPowerTitleInfo x, tcp.WeaponPowerTitleInfo y)
	{
		return 0;
	}

	private bool IsCountryInTcpWeaponPowerTitle(tcp.WeaponPowerTitleInfo x)
	{
		return false;
	}

	private bool IsBRInTcpWeaponPowerTitle(tcp.WeaponPowerTitleInfo x)
	{
		return false;
	}

	private bool IsBRInProtoWeaponPowerTitle(proto.WeaponPowerTitleInfo x)
	{
		return false;
	}

	private bool IsInRequestCD(Vector2Int leaderBoardType)
	{
		return false;
	}

	public WeaponPowerPlayerTitleInfo GetTopNewBRTitle()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetSelectedTopBRTitle()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetTopNewCSTitle()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetSelectedTopCSTitle()
	{
		return null;
	}

	private WeaponPowerInfo GetMaxWeaponPowerInfoByWPValuesDic(Dictionary<uint, WeaponPowerInfo> WPValuesDic)
	{
		return null;
	}

	private bool GetIsBrByTitleIDInConfig(uint titleCfgId)
	{
		return false;
	}

	public void SetRedDotInProfile()
	{
	}

	private void SetWeaponProficiency()
	{
	}

	private void SetWPLeaderBoardInfoData(Vector2Int leaderBoardType, AccountLeaderboardRes leaderboardRes)
	{
	}

	private void ResetWPLeaderBoardRequestCD(bool isBR, uint weaponID)
	{
	}

	public bool IsReady()
	{
		return false;
	}

	public bool IsWeaponPowerDescReady()
	{
		return false;
	}

	public bool IsWeaponLeaderBoardGet()
	{
		return false;
	}

	public CSWeaponPowerLeaderboardInfoRes GetWeaponPowerInfo()
	{
		return null;
	}

	public bool NeedShowSeasonRefreshBtn(uint weaponID, bool isBR)
	{
		return false;
	}

	public bool CheckCanRefreshLeaderBoard()
	{
		return false;
	}

	public bool CheckHasNewTitles()
	{
		return false;
	}

	public bool CheckCanShowTitleCtrl(uint iconType, ulong expireTime)
	{
		return false;
	}

	public ulong GetWeaponPowerLeaderBoardId(ELeaderboard.LeaderboardMainType leaderBoardType, ELeaderBoardTitleRegionType regionType)
	{
		return 0uL;
	}

	public uint GetWeaponPowerLeaderBoardSizeByBoardID(ulong subkey)
	{
		return 0u;
	}

	public WeaponPowerPlayerTitleInfo GetWeaponPowerPlayerTitleInfoByID(uint titleID)
	{
		return null;
	}

	public proto.WeaponPowerTitleInfo GetWeaponPowerTitleInfoByID(uint titleID)
	{
		return null;
	}

	public string GetLeaderBoardNameByLeaderBoardID(ulong leaderBoardID, string gameRegion)
	{
		return null;
	}

	public bool GetIsBrByTitleCfgID(uint titleCfgID)
	{
		return false;
	}

	public List<WeaponPowerPlayerTitleInfo> GetBRSortedWeaponTitleInfoList()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetBRSelectedWeaponTitleInfo()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetCSSelectedWeaponTitleInfo()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetCSSortedWeaponTitleInfoList()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetNewTitlesInfoList()
	{
		return null;
	}

	public WeaponPowerPlayerTitleInfo GetWeaponPowerInfoInDicWeaponIDToWeaponPowerTitles(uint weaponID)
	{
		return null;
	}

	public void SendEventLogByTitleID(uint titleID, bool is_equip = true)
	{
	}

	public ELeaderBoardTitleIconType GetWPIconType(int isBR, int areaType, uint rank)
	{
		return ELeaderBoardTitleIconType.NONE;
	}

	public List<uint> GetFilterWeaponIdsList(DLBMPCCFKKM matchMode, uint weaponTypeID)
	{
		return null;
	}

	public List<uint> GetWeaponPowerNewTitleList()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetWeaponPowerNewTitleShowList()
	{
		return null;
	}

	public uint GetWeaponPowerStartingScore(ulong subkey)
	{
		return 0u;
	}

	public List<proto.WeaponPowerTitleInfo> GetSelectedWeaponTitleInfoList()
	{
		return null;
	}

	public List<WeaponPowerPlayerTitleInfo> GetSelectedWeaponPowerPlayerTitleInfoList()
	{
		return null;
	}

	public List<tcp.WeaponPowerTitleInfo> GetTcpSelectedWeaponTitleinfoList()
	{
		return null;
	}

	public uint GetWeaponPowerValueById(uint weaponID, bool isBR)
	{
		return 0u;
	}

	public List<LeaderBoardInfo> GetWpLeaderBoardInfoList(Vector2Int WPLeaderBoardType)
	{
		return null;
	}

	public LeaderBoardInfo GetWpLeaderBoardSelfInfo(Vector2Int WPLeaderBoardType)
	{
		return null;
	}

	public uint GetWpLeaderBoardSize(Vector2Int WPLeaderBoardType)
	{
		return 0u;
	}

	public WeaponPowerInfo GetTopWeaponPowerInfo(out bool isBR, out WeaponPowerInfo maxBrInfo, out WeaponPowerInfo maxCsInfo)
	{
		isBR = default(bool);
		maxBrInfo = null;
		maxCsInfo = null;
		return null;
	}

	public uint GetWeaponTypeById(uint weaponID)
	{
		return 0u;
	}

	public List<uint> GetWeaponTypeListByMatchMode(uint matchMode)
	{
		return null;
	}

	public uint GetEquipWeaponSkinIDByInfo(LeaderBoardInfo info, uint weaponID)
	{
		return 0u;
	}

	public uint[] GetWeaponPowerValueListTopNumArray(uint weaponID, bool isBR)
	{
		return null;
	}

	public LeaderBoardInfo GetCSRankSelfData(List<LeaderBoardInfo> list)
	{
		return null;
	}

	public LeaderBoardInfo GetCSPeakRankSelfData(List<LeaderBoardInfo> list)
	{
		return null;
	}

	public LeaderBoardInfo GetBRRankSelfData(List<LeaderBoardInfo> list)
	{
		return null;
	}

	public void ResetALLWPLeaderBoardRequestCD()
	{
	}

	public bool IsShowWeaponPowerLeaderBoardPrivacySetting()
	{
		return false;
	}

	public proto.WeaponPowerTitleInfo GetCurrentPlayerBestTitleByWeaponID(uint weaponID, bool isBR)
	{
		return null;
	}

	public LeaderBoardInfo GetWpLeaderBoardLastPlayerInfo(Vector2Int WPLeaderBoardType)
	{
		return null;
	}

	public ulong GetNextTargetLeaderBoardID(bool isBr, ELeaderBoardTitleRegionType regionType)
	{
		return 0uL;
	}

	public int GetMainTypeByLeaderBoardID(int leaderBoardID)
	{
		return 0;
	}

	public ELeaderBoardTitleRegionType GetRegionByTitleConfigID(uint titleConfigID)
	{
		return ELeaderBoardTitleRegionType.None;
	}

	public string GetRuleString()
	{
		return null;
	}

	public void SetWeaponPowerAfterMatch(WeaponPowerUpdateNtf wpUpdateNtf)
	{
	}

	public List<WeaponPowerUpdateInfo> GetWeaponPowerUpdateInfoList(bool isBR)
	{
		return null;
	}

	public void OnStartMatch()
	{
	}

	public void SetAutoSelectTitle(bool isAlone)
	{
	}

	public void RequestWeaponPowerAllMesage(bool requestDesc = true, bool requestInfo = true, bool requestValue = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestWeaponPowerDesc(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestWeaponPowerInfo(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void OnRespondWeaponPowerInfo(CSWeaponPowerLeaderboardInfoRes info, bool isAlone = true)
	{
	}

	public void RequestReceiveWeaponPowerTitle(List<uint> titleIdsList)
	{
	}

	public void RequestAccountWeaponPowerValueInfo(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestWeaponPowerLeaderBoard(int mainType = 0, int weaponID = 0, ulong mainKey = 0uL, ulong leaderBoardID = 0uL, string region = "", bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true, LoadingType loadingType = LoadingType.CircleLoading, uint notifyPropID = 32u)
	{
	}

	public void RequestInheritSeasonWeaponPower(uint[] titleIds, uint matchMode)
	{
	}

	public void RequestSetHidePlayerInfo(bool isHide)
	{
	}

	public bool IngameCheckCanShowLeaderboardTitle()
	{
		return false;
	}

	public void IngameRequestShowLeaderboardTitle(IngameLeaderboardTitleShowType showType, bool isLeaderBoardTitle = true)
	{
	}

	public void UpdateWeaponPowerValue(WeaponPowerUpdateNtf wpUpdateNtf)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
