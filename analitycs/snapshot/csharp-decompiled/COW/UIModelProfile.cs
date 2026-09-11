using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelProfile : UIBaseModel
{
	private class SortWeaponPowerTitleRecordInfo : IComparer<WeaponPowerTitleRecordInfo>
	{
		public int Compare(WeaponPowerTitleRecordInfo x, WeaponPowerTitleRecordInfo y)
		{
			return 0;
		}
	}

	public enum OccupationType
	{
		None,
		RifleMan,
		Sniper,
		Rusher,
		Supporter,
		Bomber,
		UpperLimit
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CSGetInteractionRecordRes.InteractionRecord> _003C_003E9__112_1;

		public static Comparison<CSGetVisitorsRes.VisitorRecord> _003C_003E9__143_0;

		public static Func<uint, uint> _003C_003E9__144_1;

		public static Comparison<OccupationProficiencyLevelDesc> _003C_003E9__254_0;

		internal int _003CRequestVisitorInteractionRecord_003Eb__112_1(CSGetInteractionRecordRes.InteractionRecord x, CSGetInteractionRecordRes.InteractionRecord y)
		{
			return 0;
		}

		internal int _003CGetRecentVisitorList_003Eb__143_0(CSGetVisitorsRes.VisitorRecord x, CSGetVisitorsRes.VisitorRecord y)
		{
			return 0;
		}

		internal uint _003CRequestLoadingPlayerInfoSetting_003Eb__144_1(uint e)
		{
			return 0u;
		}

		internal int _003CProcessOccupationConfig_003Eb__254_0(OccupationProficiencyLevelDesc a, OccupationProficiencyLevelDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong account_id;

		public ulong selfAccountID;

		public CSGetPlayerPersonalShowReq req;

		public bool refreshavatar;

		public bool forceRefreshAvatar;

		public string waitingID;

		internal void _003CRequestShowBoardData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong account_id;

		public CSGetPlayerBriefInfoReq req;

		public bool isFriendRequestAdder;

		public Action callBackAfterBriefInfoRequestSuccess;

		internal void _003CRequestPlayerBriefInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong account_id;

		public ulong selfAccountID;

		public Action<ulong> callback;

		internal void _003CRequestPersonalInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong account_id;

		public uint cdTime;

		internal void _003CRequestPlayerHeroicMarkInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong accid;

		internal void _003CRequestAllRelationshipStateInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public UIModelProfile _003C_003E4__this;

		public uint matchMode;

		internal void _003CRequestPersonalData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public UIModelProfile _003C_003E4__this;

		public List<uint> battleType;

		public CSSetPregameShowChoicesReq req;

		internal void _003CRequestLoadingPlayerInfoSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong accountID;

		internal void _003CRequestProfileWeaponData_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public bool needSendEvent;

		public uint likes;

		public ulong id;

		internal void _003CRequestGiveLike_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public UIModelProfile _003C_003E4__this;

		public ulong accountId;

		internal void _003CRequestOthersOccupationData_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass253_0
	{
		public UIModelProfile _003C_003E4__this;

		public uint matchMode;

		public uint occupationId;

		public uint externVal;

		internal void _003CRequestSetOccupationSelect_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass258_0
	{
		public UIModelProfile _003C_003E4__this;

		public bool show;

		internal void _003CRequestShowProfileOccupation_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_0
	{
		public UIModelProfile _003C_003E4__this;

		public uint matchMode;

		internal void _003CRequestSetShowProfileOccupation_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass267_0
	{
		public UIModelProfile _003C_003E4__this;

		public uint mode;

		public MapModeData mapModeData;

		internal void _003CRequestPlayerGameModeStatsByMode_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private List<MatchRecordPersonal> m_HistoryRecordList;

	private Dictionary<uint, Dictionary<uint, PersonalRecordData>> m_MatchModeDict;

	private Dictionary<ulong, PersonalLiveTvData> m_ShowLiveTvInfoDic;

	private Dictionary<ulong, CDTimeData> m_RequestLiveInfoCDDict;

	private Dictionary<int, ulong> m_CDDic;

	private Dictionary<ulong, ulong> m_PlayerBriefInfoCDDict;

	private Dictionary<ulong, AccountBriefInfo> m_PlayerBriefInfoDict;

	private Dictionary<ulong, ulong> m_AccoutDic;

	private Dictionary<ulong, AccountPersonalShowInfo> m_PersonShowinfoDic;

	private Dictionary<ulong, BlacklistInfo> m_PlayerBlacklistInfoDict;

	private Dictionary<ulong, List<IntimacyState>> m_PersonalIntimacyDic;

	private Dictionary<ulong, ulong> m_RequestIntimcyCDDict;

	private Dictionary<ulong, ulong> m_PlayerHeroicMarkInfoCDDict;

	private Dictionary<ulong, CSGetHeroicInfoRes> m_PlayerHeroicMarkInfoDict;

	private Dictionary<uint, List<uint>> m_DicBattleTypeToLoadingPregameInfo;

	private Dictionary<ulong, List<WeaponPowerTitleRecordInfo>> m_DictWeaponPowerTitleRecordInfo;

	private Dictionary<ulong, List<WeaponExpInfo>> m_DictWeaponExpInfo;

	private Dictionary<ulong, SelectedItems> m_DictWeaponSelectedItems;

	private Dictionary<ulong, List<WeaponAwardInfo>> m_DictWeaponAwardInfo;

	private Dictionary<ulong, Dictionary<uint, uint>> m_DictSelectedWeaponSkinIDFromWeaponID;

	private Dictionary<ulong, ulong> m_DictWeaponTitleRecordRequestColdTime;

	private SortWeaponPowerTitleRecordInfo m_SortWeaponPowerTitleRecordInfo;

	private Dictionary<ulong, CSGetVisitorsRes.VisitorRecord> m_RecentVisitorInfoDict;

	private Dictionary<uint, LevelRewardsDisplaysDesc> m_DictLevelToRewardDisplayDesc;

	private Dictionary<uint, List<uint>> m_DicCSPeakPregameInfoSubRelation;

	private Dictionary<uint, uint> m_DicCSPeakPregameInfoParentRelation;

	private uint m_RecentVisitorTotalNum;

	private uint m_RecentVisitorTadayNum;

	private uint m_NewAddRecentVisitorNum;

	private int m_LastRecentVistorNum;

	private uint m_RequestShowBoardDataOrder;

	private bool m_IsBanStateDisabledForCurrentRegion;

	private bool m_IsBanStateDisabledInitialized;

	private bool m_DisableCreatorNameColor;

	private const int MAX_RECENTVISITORSHOW = 10;

	private ulong m_LastVisitorRequestStamp;

	private const uint VisitorReuqestDetal = 3600u;

	private uint m_ProfileBriefBoxIndex;

	public const int MaxCountOfLoadingPlayerInfo = 3;

	private const int m_CDSecond = 300;

	private const int m_PersonSecond = 4;

	private const int m_BriefInfoSecond = 1800;

	private const uint PROFILE_WEAPON_REQUEST_CLOD_TIME = 180u;

	private uint m_diamond;

	public const int PropID_GetProfileSuccess = 1;

	public const int PropID_GetProfileFail = 2;

	public const int PropID_GetHistorystats = 4;

	public const int PropID_GetShowBoardDataSuccess = 8;

	public const int PropID_GetLiveTvDataSuccess = 16;

	public const int PropID_GetShowBoardAvatarDataSuccess = 32;

	public const int PropID_GetPersonalSettingSuccess = 64;

	public const int PropID_GetPlayerBriefInfoSuccess = 256;

	public const int PropID_GetPlayerRelationShipSuccess = 512;

	public const int PropID_GetPlayerHeroicMarkInfoSuccess = 2048;

	public const int PropID_SetLoadingShowPlayerInfoChoice = 4096;

	public const int PropID_GetProfileWeaponTitle = 8192;

	public const int PropID_RecentVisitorInfoRefresh = 16384;

	public const int PropID_PlayerModeStatsGet = 32768;

	public const int PropID_OccputationInfoGet = 65536;

	public const int PropID_OccputationInfoSet = 131072;

	public const int PropID_GetLevelRewardsDisplayDesc = 262144;

	public const int PropID_GetVisitorInteractionRecord = 524288;

	public const int PropID_GetLikedRecord = 1048576;

	public const int PropID_UpdateMMR = 1048576;

	public const int PropID_CreatorPrivilegeSwitchChanged = 2097152;

	public string DefaultSex;

	public string DefaultShow;

	public string DefaultOnLineTime;

	public string DefaultActiveTime;

	public string DefaultModePrefer;

	public string DefaultSignature;

	private bool m_IsUserSelf;

	private CSGetInteractionRecordRes m_VisitorInteractionInfo;

	private ulong m_LastGetVisitorInteractionInfoStamp;

	private List<ulong> m_LikedAccountList;

	private bool m_IsFirstGetLikeList;

	private string IS_LIKE_UPDATE;

	private const string PROFILERECENTVISITORUPDATE = "ProfileRecentVisitorUpdate_";

	private bool m_HasRequestLevelRewardsDisplayConfig;

	private WaitingResponseHandler m_WaitingResponseHandle;

	private const string KEY_ENTERED_PROFILE_SETTING_TAB_LOADINGINFO = "ENTERED_PROFILE_SETTING_TAB_LOADINGINFO";

	private Dictionary<ulong, OccpuationData> m_OccupationAccountDict;

	private Dictionary<uint, List<OccupationProficiencyLevelDesc>> m_OccupationProficiencyDict;

	private Dictionary<uint, OccupationDesc> m_OccupationDescDict;

	private List<OccupationUpdateInfo> m_OccupationProficientUpdateInfoList;

	private List<OccupationUpdateInfo> m_OccupationScoreUpdateInfoList;

	private OccupationSettingDesc m_OccupationSettingDesc;

	private const uint OCCUPATION_DETAILINFO_CD = 900u;

	public const uint OCCUPATION_MAX_BOUND = uint.MaxValue;

	private bool m_IsOccupationRequesting;

	private bool m_IsOccupationSelectRequesting;

	private bool _003CIsJumpFromOccupationLobbyGuide_003Ek__BackingField;

	private uint m_CSSelectedOccputationId;

	private uint m_BRSelectedOccputationId;

	private uint m_CSPeakSelectedOccputationId;

	private bool m_BRShowNewOccupation;

	private bool m_CSShowNewOccupation;

	private bool m_CSPeakShowNewOccupation;

	private Dictionary<uint, CSGetPlayerModeStatsRes> m_PlayerModeStatsDic;

	public ModeStatsScoreUpdateNtf CurModeStatsScoreUpdateNtf;

	public const string LimitedTimeRankSeasonKey = "LimitedTimeRankSeasonKey_";

	public uint RecentVisitorTotalNum => 0u;

	public uint RecentVisitorTodayNum => 0u;

	public uint NewAddRecentVisitorNum => 0u;

	public uint ProfileBriefBoxIndex => 0u;

	public bool IsUserSelf
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CSGetInteractionRecordRes VisitorInteractionInfo
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public List<ulong> LikedAccountList => null;

	public bool IsFirstGetLikeList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<MatchRecordPersonal> HistoryRecordList => null;

	private WaitingResponseHandler WaitingResponseHandle => null;

	public bool IsOccupationSelectRequesting => false;

	public bool IsJumpFromOccupationLobbyGuide
	{
		get
		{
			return _003CIsJumpFromOccupationLobbyGuide_003Ek__BackingField;
		}
		set
		{
			_003CIsJumpFromOccupationLobbyGuide_003Ek__BackingField = value;
		}
	}

	public bool OccupationShowEnable => false;

	public bool EliteOccupationShowEnable => false;

	public uint OccupationGameLimit => 0u;

	public uint OccupationShowPercentLimit => 0u;

	public uint CSSelectedOccputationId => 0u;

	public uint BRSelectedOccputationId => 0u;

	public uint CSPeakSelectedOccputationId => 0u;

	public bool BRShowOccupationNew => false;

	public bool CSShowOccupationNew => false;

	public bool CSPeakShowOccupationNew => false;

	public List<uint> GetListLoadingPregameInfo(ELoadingBattleType loadingBattleType)
	{
		return null;
	}

	public bool IsProfileDataPunished(ulong accountId)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void OnStartMatch()
	{
	}

	public void ProcessDiamondCost(DiamondCostRes res)
	{
	}

	public ECupTypeForHistoryRecord GetCupTypeForBR(uint rank, CMDBIPLGLGA groupMode)
	{
		return ECupTypeForHistoryRecord.None;
	}

	public uint GetDiamondCost()
	{
		return 0u;
	}

	public Dictionary<uint, PersonalRecordData> GetPersonalRecordDict(uint matchMode)
	{
		return null;
	}

	public void ForeRefreshAvatar()
	{
	}

	public void RequestVisitorInteractionRecord(bool force = false, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void RequestShowBoardData(proto.EAccount.CallSignSrc callSignSrc, out uint requestShowBoardDataOrder, ulong account_id = 0uL, bool refreshavatar = false, bool forceRefreshAvatar = false, bool forceRequest = false, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false)
	{
		requestShowBoardDataOrder = default(uint);
	}

	public void RequestPlayerBriefInfo(ulong account_id, Action callBackAfterBriefInfoRequestSuccess = null, bool isFriendRequestAdder = false)
	{
	}

	public AccountBriefInfo GetPlayerBriefInfo(ulong id)
	{
		return null;
	}

	public void RequestPersonalInfo(ulong account_id = 0uL, Action<ulong> callback = null, proto.EAccount.CallSignSrc callSignSrc = proto.EAccount.CallSignSrc.CallSignSrc_PERSONAL_SHOW_OWNER)
	{
	}

	public void RequestPlayerHeroicMarkInfo(ulong account_id)
	{
	}

	public CSGetHeroicInfoRes GetPlayerHeroicMarkInfo(ulong account_id)
	{
		return null;
	}

	public void RequestAllRelationshipStateInfo(ulong accid, bool force = false)
	{
	}

	public List<IntimacyState> GetRelationShipInfo(ulong accid)
	{
		return null;
	}

	public AccountPersonalShowInfo GetPersonalShowData(ulong id)
	{
		return null;
	}

	public bool IsCreatorNameColorDisabled()
	{
		return false;
	}

	public bool TrySyncCreatorPrivilegeSwitchesFromSummaryInfo(ulong accountId = 0uL)
	{
		return false;
	}

	public void UpdateCreatorPrivilegeSwitches(bool disableNameColor)
	{
	}

	private void TrySyncSelfCreatorPrivilegeSwitches(ulong accountId, ulong selfAccountId)
	{
	}

	private void ApplyCreatorPrivilegeSwitches(bool disableNameColor)
	{
	}

	private bool IsBanStateDisabledForCurrentRegion()
	{
		return false;
	}

	public bool IsAccountBannedState(ulong accountId)
	{
		return false;
	}

	public BlacklistInfo GetBlacklistInfo(ulong accountId)
	{
		return null;
	}

	private void UpdateBlacklistInfo(ulong accountId, BlacklistRes blacklistRes)
	{
	}

	public void OnPlayerClanChanged(ulong accountId)
	{
	}

	public AccountPrefers GetPersonalAccountPrefers(ulong id)
	{
		return null;
	}

	public PersonalLiveTvData GetPersonalLiveTvData(ulong id)
	{
		return null;
	}

	public void RequestPersonalData(uint type, ulong account_id = 0uL)
	{
	}

	public void RequestSetPesonalSetting(CSUpdateSocialBasicInfoReq req, bool refreshbattle = false)
	{
	}

	public void RequestRecentVisitorInfo(bool forceRequest = false, bool sendImmediately = false)
	{
	}

	private void InitRecentVisitorDict(List<CSGetVisitorsRes.VisitorRecord> visitorRecords)
	{
	}

	public void SetRecentVisitorVisitorNum()
	{
	}

	public void ClearNewAddVisitorNum()
	{
	}

	public List<CSGetVisitorsRes.VisitorRecord> GetRecentVisitorList()
	{
		return null;
	}

	public void RequestLoadingPlayerInfoSetting(List<uint> battleType)
	{
	}

	public void RequestHistoryRecord(ulong account_id = 0uL)
	{
	}

	public void ClearMatchModeCache()
	{
	}

	private PersonalRecordData AccountInfo2PersonalRecord(AccountInfoWithStatsToClient acInfo, uint type)
	{
		return null;
	}

	public void RefreshSelfShows(uint[] shows)
	{
	}

	public void RefreshPlayerTitleEqiuppedInfo(uint titleId)
	{
	}

	public void SetPlayerInfoTypeOnLoading(ELoadingBattleType loadingBattleType, uint[] listDataType)
	{
	}

	public List<uint> GetDefaultChoices(ELoadingBattleType loadingBattleType)
	{
		return null;
	}

	public bool IsShowPlayerInfoTypeOnLoading(ELoadingBattleType loadingBattleType, proto.EAccount.Choices eDataType)
	{
		return false;
	}

	public bool SetShowPlayerInfoTypeOnLoading(ELoadingBattleType loadingBattleType, proto.EAccount.Choices eDataType, bool show)
	{
		return false;
	}

	public bool SetCSPeakShowPlayerInfoTypeOnLoading(proto.EAccount.Choices eDataType, bool show, List<uint> list)
	{
		return false;
	}

	public void SetDicPregameInfoRelationDesc()
	{
	}

	public Dictionary<uint, List<uint>> GetDicCSPeakPregameInfoSubRelation()
	{
		return null;
	}

	public void GetRankLoadingPlayerInfoByType(ELoadingBattleType loadingBattleType, uint choiceType, BattleStatsInfo statsInfo, out string strTitle, out string strVal)
	{
		strTitle = null;
		strVal = null;
	}

	public void GetRankLoadingPlayerInfoByType(ELoadingBattleType loadingBattleType, uint choiceType, BattleStatsInfo statsInfo, ProfileDataPunishSwitchConfig punishConfig, out string strTitle, out string strVal)
	{
		strTitle = null;
		strVal = null;
	}

	private string ModifyThousandData(uint data)
	{
		return null;
	}

	public bool HaveEnteredProfileSettingTabLoadingInfo()
	{
		return false;
	}

	public void EnterProfileSettingTabLoadingInfo()
	{
	}

	public bool HasHistoryRecord(ulong matchId)
	{
		return false;
	}

	public MatchRecordPersonal GetHistoryRecord(ulong matchId)
	{
		return null;
	}

	public void ShowHistoryDetail(ulong matchId)
	{
	}

	public void ShowHistoryDetail(MatchRecordPersonal matchRecord)
	{
	}

	public bool HasGameBuff(ulong accountID)
	{
		return false;
	}

	public uint GetMMr(ulong accoutnID, uint gameModeID)
	{
		return 0u;
	}

	public void UpdateMMrInfo(UpdateMMRRes updateMmrRes)
	{
	}

	public string GetDefaultPersonalSignature()
	{
		return null;
	}

	public int GetDictWeaponPowerTitleRecordInfoCount(ulong accountID)
	{
		return 0;
	}

	public void ResetRequestLockAfterMatch()
	{
	}

	public void RequestProfileWeaponData(bool isForce, ulong accountID)
	{
	}

	public void RequestGiveLike(ulong id, string region, uint likes = 0u, bool needSendEvent = true)
	{
	}

	public void GetLikedRecord()
	{
	}

	public void RequestLevelRewardsDisplayDesc()
	{
	}

	public LevelRewardsDisplaysDesc GetNextStageLevelUpRewardInfo()
	{
		return null;
	}

	public uint GetCurrentRewardStageLevel()
	{
		return 0u;
	}

	public List<LevelRewardsDisplaysDesc> GetLevelRewardsDisplaysDescList()
	{
		return null;
	}

	public Dictionary<uint, LevelRewardsDisplaysDesc> GetLevelRewardsDisplaysDescDict()
	{
		return null;
	}

	public bool HasDictLevelToRewardDisplayDescProcessed()
	{
		return false;
	}

	public void RefreshLikeButtonDaily()
	{
	}

	public void UpdateLikeInfoNtf()
	{
	}

	private bool CheckInProfileWeaponDataColdTime(ulong accountID)
	{
		return false;
	}

	private void SetProfileWeaponDataColdTime(ulong accountID)
	{
	}

	private void ProcessWeaponPowerTitleRecordInfo(ulong accountID, List<WeaponPowerTitleRecordInfo> listTitleInfo)
	{
	}

	public List<WeaponPowerTitleRecordInfo> GetProfileWeaponTitleDataFromFilter(uint leaderboardMainType, uint season, uint weaponType, ulong accountID)
	{
		return null;
	}

	public uint GetFirstInProfileWeaponNodeMatchMode(ulong accountID, bool limitedCurrentSeason = true)
	{
		return 0u;
	}

	public static uint GetWeaponTitleRarityNum(uint titleCfgID)
	{
		return 0u;
	}

	public uint GetSelectWeaponSkinIDFromAccoundIDAndWeaponID(ulong accountID, uint weaponID)
	{
		return 0u;
	}

	private void ProcessSelectedWeaponSkinID(ulong accountID)
	{
	}

	public WeaponExpInfo GetWeaponProficiencyDataList(ulong accoundID, uint weaponID)
	{
		return null;
	}

	public bool IsWeaponProficiencyV2ByAccoundID(ulong accoundID, uint weaponID)
	{
		return false;
	}

	public List<OccupationUpdateInfo> GetOccupationProficientUpdateInfoList()
	{
		return null;
	}

	public void SetOccupationUpdateInfoList(List<OccupationUpdateInfo> data, List<OccupationUpdateInfo> data2, uint gameMode)
	{
	}

	private void SetOccupationUpgradePrefs(uint gameMode)
	{
	}

	public uint GetCSPeakOccupationShow(ulong accountID)
	{
		return 0u;
	}

	private void ResetOccpuationData()
	{
	}

	public OccpuationData GetOccpationDetailInfo(ulong accountId)
	{
		return null;
	}

	public bool IsOccupationAccountInCache(ulong accountID)
	{
		return false;
	}

	public void ResetOccupationAccountCacheTime(ulong accountID)
	{
	}

	public void RequestOccupationDataByID(ulong accountId)
	{
	}

	public void RequestOthersOccupationData(ulong accountId)
	{
	}

	public void RequestLocalUserOccupationData(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void ProcessLocalUserOccuaptionInfo(CSGetOccupationInfoRes res)
	{
	}

	private void UpdateOccupationTips()
	{
	}

	private void UpdateOccputationInfo(ulong accountId, OccupationDetailInfo info)
	{
	}

	private void TryProcessOccupationInitData(OccupationDetailInfo detailInfo)
	{
	}

	public void RequestSetOccupationSelect(uint occupationId, uint matchMode, uint gameMode, uint externVal = 0u)
	{
	}

	public void ProcessOccupationConfig(CSGetOccupationDescRes res)
	{
	}

	public uint GetProficientLevelPoint(uint id, uint level)
	{
		return 0u;
	}

	public OccupationProficiencyLevelDesc GetOccupationLevelDesc(uint id, ulong proficients)
	{
		return null;
	}

	public OccupationDesc GetOccupationDescByID(uint occupationId)
	{
		return null;
	}

	public void RequestShowProfileOccupation(bool show)
	{
	}

	public void RequestSetShowProfileOccupation(uint matchMode, uint gameMode)
	{
	}

	public string GetOccupationSprite(uint id, uint level)
	{
		return null;
	}

	public bool IsEliteOccupation(uint id, uint level)
	{
		return false;
	}

	public ResourceID GetOccupationEliteVFXRes(uint id)
	{
		return default(ResourceID);
	}

	public uint[] GetRecuritAvalibleOccupationID(uint gameMode)
	{
		return null;
	}

	public void RequestPlayerGameModeStatsByMode(MapModeData mapModeData, bool forceRequest = false)
	{
	}

	public void OnModeStatsScoreUpdateNtf(ModeStatsScoreUpdateNtf ntfData)
	{
	}

	private void _003CRequestVisitorInteractionRecord_003Eb__112_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSetPesonalSetting_003Eb__138_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestRecentVisitorInfo_003Eb__139_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHistoryRecord_003Eb__145_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CGetLikedRecord_003Eb__175_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestLevelRewardsDisplayDesc_003Eb__176_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestLocalUserOccupationData_003Eb__248_0(HttpErrorCode errorCode, object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
