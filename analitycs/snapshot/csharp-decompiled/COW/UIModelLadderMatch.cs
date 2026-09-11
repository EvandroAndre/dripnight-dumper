using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelLadderMatch : UIBaseModel
{
	public delegate void OnFinishedDelegate();

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RankMasterLevel> _003C_003E9__195_0;

		public static Comparison<RankMasterLevel> _003C_003E9__237_1;

		public static Comparison<BaseItemInfo> _003C_003E9__250_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__254_1;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__257_0;

		public static Action<HttpErrorCode, object> _003C_003E9__299_0;

		public static Predicate<LeaderBoardInfo> _003C_003E9__308_1;

		public static Predicate<MapOpeningInfo> _003C_003E9__315_0;

		internal int _003CGetRankMasterLevelBySeasonID_003Eb__195_0(RankMasterLevel a, RankMasterLevel b)
		{
			return 0;
		}

		internal int _003CResquestRankMasterLevelInfo_003Eb__237_1(RankMasterLevel a, RankMasterLevel b)
		{
			return 0;
		}

		internal int _003CGetBRUnlockRewardLevelData_003Eb__250_1(BaseItemInfo a, BaseItemInfo b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimBRWinPassReward_003Eb__254_1(BaseItemInfo item)
		{
			return null;
		}

		internal BaseItemInfo _003CGetBRWinPassMatchResultTaskInfosList_003Eb__257_0(AwardDesc ite)
		{
			return null;
		}

		internal void _003CSetSeasonChangeInfo_003Eb__299_0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CCheckIsNeedRankComparePop_003Eb__308_1(LeaderBoardInfo e)
		{
			return false;
		}

		internal bool _003CUpdateCurrentLadderMapOpeningInfo_003Eb__315_0(MapOpeningInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public MapModeData mapData;

		internal bool _003CCheckAndSetRankSeletedMap_003Eb__0(MapOpeningInfo x)
		{
			return false;
		}

		internal bool _003CCheckAndSetRankSeletedMap_003Eb__1(MapModeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public MapModeData mapData;

		internal bool _003CCalculateIfMultiMapBuff_003Eb__0(MapModeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public uint mapId;

		internal bool _003CisForceChooseMap_003Eb__0(MapOpeningInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public uint seasonID;

		internal void _003CResquestRankMasterLevelInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public OnFinishedDelegate onFinished;

		internal void _003CGetSeasonInfoConfigFromServer_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public uint rankStage;

		internal bool _003CGetLevelDataByRankStage_003Eb__0(LadderLevelData l)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public uint rankGroup;

		internal bool _003CGetLevelDataByRankGroup_003Eb__0(LadderLevelData l)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass261_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public uint httpOp;

		public HttpManager.EHttpChannel channel;

		public bool login;

		internal void _003CRefreshRankInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass264_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public bool login;

		internal void _003CGetRankInfoFromServer_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass276_0
	{
		public tcp.RankingTaskUpdateInfo info;

		internal bool _003CUpdateBRRankDailyTaskInfo_003Eb__0(RankingTaskInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass277_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public bool showRank;

		internal void _003CSetShowRank_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass308_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public ulong account_id;

		internal bool _003CCheckIsNeedRankComparePop_003Eb__0(LeaderBoardInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass315_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public int i;

		public Predicate<MapOpeningInfo> _003C_003E9__1;

		internal bool _003CUpdateCurrentLadderMapOpeningInfo_003Eb__1(MapOpeningInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass316_0
	{
		public UIModelLadderMatch _003C_003E4__this;

		public uint season_id;

		public uint rank_point;

		internal void _003CGetSeasonData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const string RANK_MAP_SELECT = "rank_map_select";

	public const string FIRST_TIME_ENTER_BR_RANK_KEY = "FirstTimeEnterBRRank";

	public const uint PropID_RankInfoRefreshed = 2u;

	public const uint PropID_SetShowRankSuccess = 8u;

	public const uint PropID_FirstWinRefreshed = 16u;

	public const uint PropID_SeasonStatsRefresh = 32u;

	public const uint PropID_SetChooseRankCardSuccess = 64u;

	public const uint PropID_RankActivityRefreshed = 128u;

	public const uint PropID_PeakRankPosRefresh = 128u;

	public const uint PropID_RankMapSelectConfirmed = 256u;

	public const uint PropID_RankingTaskInfoRefreshed = 512u;

	public const uint PropID_BRResetMatchRewardClaimSuccess = 1024u;

	public const uint PropID_SeasonInfoRefreshed = 4096u;

	public const uint PropID_BRWinPassRewardClaimSuccess = 8192u;

	public const uint PropID_BRGrandmasterPositionUpdate = 16384u;

	public const uint PropID_BRGrandmasterRequestReady = 32768u;

	public const uint PropID_ForceRefreshUIAfterRefreshBonus = 65536u;

	public Dictionary<int, string> ERankActivityTypeForLocKeyMap;

	public const string SHOW_BR_SEASON_TIPS = "BR_Season_Restart_tips";

	public const string SHOW_BR_SEASON_END_TIPS = "BR_Season_End_tips";

	private string BR_TAG_HOT_CNT_PlAYERPREFS;

	private string BR_TAG_NEW_CNT_PlAYERPREFS;

	private LadderRankInfo m_CurrentLadderRankInfo;

	private float m_NextReqRankInfoTime;

	private float m_NextReqRankTaskInfoTime;

	private float m_NextReqRankStatTime;

	private float m_NextReqGrandmasterPositionTime;

	private uint m_BRRankLeaderBoardMinRank;

	public bool HasFinishBRDailyFirstWinTask;

	private List<uint> m_AwardsExhibitIDList;

	private List<uint> m_ExchangeExhibitIDlist;

	private int m_ResetMatchTipsCount;

	public bool hasNewMapProtection;

	public uint newMapId;

	public uint newMapMaxCount;

	private float m_MultiMapBuff;

	private uint bonusAddPointMax;

	private bool m_HasMultiMapBuff;

	private bool m_HasMultiMapBuffGroup;

	private bool m_MultiMapBuffInit;

	private int m_BRHotTagCount;

	private int m_BRNewTagCount;

	private readonly Dictionary<uint, bool> m_BRNewTagDic;

	public uint MaxBRLadderRank;

	public uint MinBRLadderRank;

	public uint BRMinRankSort;

	public uint BRHistoryDataMaxDisplaySeasonNum;

	public const int KeyID_ShowRankRewardTipOnLobbySubSystem = 2;

	public const int KeyID_ShowRankRewardTipOnRankNavigation = 4;

	public const string KEYSHOWRANKREWARDTIP = "KeyShowRankRewardTipV2_";

	public const string RANK_EXCHANGE_MALL_CLICK = "RankExchangeMallClick_";

	public ELadderRankStages BRCrossModeBannerShowStage;

	private List<LadderLevelData> m_BRLadderLevelDataList;

	private List<int> m_BRRankListForGroupRecruit;

	private List<int> m_BRMaxRankListForGroupRecruit;

	private List<LadderLevelData> m_BRExhibitLevelDataList;

	private uint m_BRMinLeaderBoardScore;

	private uint m_BRRecentMaxRank;

	private Dictionary<int, int> m_BRRankMappingDic;

	private Dictionary<int, int> m_BRUpBoundRankMappingDic;

	private Dictionary<int, LeaderboardItemSimple> m_BRLeaderboardPosDic;

	private Dictionary<uint, LadderLevelData> m_BRLadderLevelDataDic;

	public List<RankingWinPassDesc> BRRankingWinPassDescs;

	public List<RankingWinPassDesc> NextSeasonBRRankingWinPassDescs;

	public List<BRRankBonusPointActivitiesDesc> BRRankBonusPointActivities;

	public List<RankingMultiModeBonusDesc> BRRankingCrossModeBonusList;

	public BRRatingRankUpgradeDesc BRRatingRankUpgradeDesc;

	private Dictionary<uint, uint> m_BRMapProtectionNum;

	private List<MapProtectionDesc> m_MapProtectionDescsList;

	private uint m_MaxRankSortwithFirstReward;

	public int CacheBRPeakRankPos;

	public int CurBRPeakRankPos;

	public float BRPeakRankPosDelayTime;

	public uint BRFirstHasRewardRank;

	public bool IsBRRankAnimationOpen;

	public uint BRMinRankSortIdShow;

	public uint CurShowBRSpecialMissionID;

	public const string KEYSHOWBRSPECIALMISSIONTIP = "Key_ShowBRSpecialMissionTip";

	public bool IsNeedBRRankMapping;

	public bool HasUnlockRewardClaimed;

	private List<RankingTaskInfo> m_LadderDailyMissionInfoList;

	private uint m_InitRank;

	private uint[] m_CurrentLadderUsedMapList;

	private uint[] m_CurrentLadderSelectedMapList;

	public int cachedMaxRank;

	public bool isMaxRankDirty;

	public int LastPeakRankPos;

	private RankingSeasonInfo m_CurrentSeasonInfo;

	private RankingInfo m_LastSeasonRankInfo;

	private RankingSeasonInfo m_LastSeasonInfo;

	private LadderSeasonStatsInfo m_LadderSeasonInfo;

	private LadderMatchDaily m_LadderDailyInfo;

	private RankCard m_RankCard;

	private List<int> ladderActivityTypes;

	private List<RankAwardsDesc> m_CurrentSeasonAwards;

	private Dictionary<uint, RankTopAwardsDesc> m_RankTopAward;

	private LadderLevelData m_CurrentLadderLevelData;

	private LadderLevelData m_MaxLadderLevelData;

	private Dictionary<uint, List<RankMasterLevel>> m_RankMasterLevelDic;

	public bool isLastReachPeakRank;

	public double PeakRankThreshold;

	public double LastPeakRankThreshold;

	public List<LadderLevelData> RankUpRewardList;

	private CSPlayerRankingInfoReq m_PendingInfoRequest;

	private proto.Empty m_PendingSeasonRequest;

	private CSSetShowRankReq m_PendingShowRankRequest;

	private CSChooseRankingCardsReq m_PendingSetChooseRankingCardRequest;

	private bool m_ShowCallsignRank;

	private LatestRankInfo m_LatestRankInfo;

	public List<LeaderBoardInfo> ExceededPlatformFriendList;

	public List<LeaderBoardInfo> ExceededFriendList;

	public bool NeedRankComparisonPop;

	public int SelfIndex;

	private List<MapOpeningInfo> m_CurrentLadderMapOpeningInfo;

	public uint BRRankLeaderBoardMinRank => 0u;

	public int ResetMatchTipsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int BRHotTagCount => 0;

	public int BRNewTagCount => 0;

	public float BRMultiMapBuff => 0f;

	public uint BonusAddPointMax => 0u;

	public bool HasMultiMapBuffSelf
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<LadderLevelData> BRLadderLevelDataList => null;

	public List<int> BRRankListForGroupRecruit => null;

	public List<int> BRMaxRankListForGroupRecruit => null;

	public List<LadderLevelData> BRExhibitLevelDataList => null;

	public uint BRMinLeaderBoardScore => 0u;

	public uint BRRecentMaxRank => 0u;

	public bool IsResetMatchRewardClaimable => false;

	public LadderRankInfo CurrentLadderRankInfo => null;

	public List<RankingTaskInfo> LadderDailyMissionInfoList => null;

	public uint[] CurrentLadderUsedMapList => null;

	public uint[] CurrentLadderSelectedMapList => null;

	public int CurrentRank => 0;

	public int CurrentLadderScore => 0;

	public int CurrentPeakRankPos => 0;

	public int LastSeasonPeakRankPos => 0;

	public RankingSeasonInfo CurrentSeasonInfo => null;

	public RankingInfo LastSeasonRankInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RankingSeasonInfo LastSeasonInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LadderSeasonStatsInfo LadderSeasonStatsInfo => null;

	public LadderMatchDaily LadderDailyInfo => null;

	public RankCard SelectedRankCardInfo => null;

	public Dictionary<uint, RankTopAwardsDesc> RankTopAward => null;

	public List<RankAwardsDesc> CurrentSeasonAwards => null;

	public LadderLevelData CurrentLadderLevelData => null;

	public LadderLevelData MaxLadderLevelData => null;

	public List<RankMasterLevel> RankMasterLevel => null;

	public bool HasDailyMissionUncomplete => false;

	public bool ShowRankUpReward => false;

	public bool ShowCallsignRank
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public LatestRankInfo RankInfo => default(LatestRankInfo);

	public bool HasBRDoubleBonusValid => false;

	public List<MapOpeningInfo> CurrentLadderMapOpeningInfo => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool HasMultiMapBuff()
	{
		return false;
	}

	public void ProcessRankingMatchParam(RankingMatchParam data)
	{
	}

	public void ForceRefreshMultiMapBuff()
	{
	}

	public void RestInitSign()
	{
	}

	public bool HasBRCrossModeBonusBuff()
	{
		return false;
	}

	public uint GetBRCrossModeBonusPercent()
	{
		return 0u;
	}

	public void CheckAndSetRankSeletedMap(bool notify = true)
	{
	}

	public void ReSetMapForRankLimit()
	{
	}

	private bool CalculateIfMultiMapBuff()
	{
		return false;
	}

	public bool CalculateIfMultiMapBuffInGroup()
	{
		return false;
	}

	public bool isForceChooseMap(uint mapId)
	{
		return false;
	}

	public void RefreshBRDailyFirstWinState()
	{
	}

	public ResourceID GetNextBRFirstRankRewardRankIcon()
	{
		return default(ResourceID);
	}

	public void MapProtectionCountSub(uint mapID)
	{
	}

	public List<uint> GetAwardsExhibitIDList()
	{
		return null;
	}

	public List<uint> GetExchangeExhibitIDList()
	{
		return null;
	}

	public bool IsResetMatchRewardVisible()
	{
		return false;
	}

	public void UpdateGamePlay(uint cnt)
	{
	}

	public int GetResetMatchTipsCnt()
	{
		return 0;
	}

	public uint GetNewSeasonInitRank()
	{
		return 0u;
	}

	public List<int> GetAvalibleRankingActivityTypes()
	{
		return null;
	}

	public bool isCurrentSeasonOpen()
	{
		return false;
	}

	public bool IsShowBRSeasonChangeWindow()
	{
		return false;
	}

	public bool isBonusRewardMode(uint mode)
	{
		return false;
	}

	public bool isBRMaxRankUponMinRank()
	{
		return false;
	}

	public bool IsBrRankUponMinRank()
	{
		return false;
	}

	public List<RankMasterLevel> GetRankMasterLevelBySeasonID(uint seasonID)
	{
		return null;
	}

	public void InitRankUpRewardData(uint rank_before, uint rank_after, bool hasFirstRankAward = false)
	{
	}

	public override void Init()
	{
	}

	public bool CheckShowBrNewSeasonTips()
	{
		return false;
	}

	public bool CheckShowBrNewSeasonItemTips()
	{
		return false;
	}

	public bool CheckShowBrSeasonEndTips()
	{
		return false;
	}

	public bool CheckDuringBrSeasonEnd()
	{
		return false;
	}

	public bool IsPeakRank(uint peakRankPos)
	{
		return false;
	}

	public uint GetCurrentBRRankSort()
	{
		return 0u;
	}

	public uint GetBRRankSortByRank(uint rank)
	{
		return 0u;
	}

	public int GetCurrentPeakRankPos()
	{
		return 0;
	}

	public bool IsCurrentPeakRank()
	{
		return false;
	}

	public int PeakRankScore(double brScore)
	{
		return 0;
	}

	public bool IsLastSeasonPeakRank(uint peakRankPos)
	{
		return false;
	}

	public bool IsCurrentUserPeakRank()
	{
		return false;
	}

	public ResourceID GetRankIcon(int rank, uint peakRankPos, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public ResourceID GetRankIcon(int rank, uint peakRankPos, ref float scale, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public void GetRankIconAndUIFX(int rank, uint peakRankPos, ref ResourceID iconRes, ref ResourceID effectRes, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
	}

	public bool IsShowBRRankNoDropDivisionCard()
	{
		return false;
	}

	public void RequestBRRankingMatchGrandmasterPositions(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool immediately = false)
	{
	}

	public bool IsBRRankCardProtect()
	{
		return false;
	}

	public string GetRankName(int rank, uint peakRankPos)
	{
		return null;
	}

	public LeaderboardItemSimple GetBRGrandMasterLeaderboardItemDisplayInfo()
	{
		return null;
	}

	public int GetBRGrandMasterThreshold()
	{
		return 0;
	}

	public void ResquestRankMasterLevelInfo(uint seasonID, LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public int GetCurrentRankMasterLevel()
	{
		return 0;
	}

	public int GetRankMasterLevel(int position)
	{
		return 0;
	}

	public RankMasterLevel GetBRMasterLevelDataByMasterLevel(uint masterLevel)
	{
		return null;
	}

	public void GetBRLadderMatchNextShowRankInfo(ref uint nextRank, ref uint nextMasterLevel)
	{
	}

	public int GetLastSeasonRankMasterLevel()
	{
		return 0;
	}

	public void GetSeasonInfoConfigFromServer(OnFinishedDelegate onFinished = null, uint httpOp = 0u, bool immediately = false)
	{
	}

	public void UpdateSeasonChangeAwardConfig(CSGetCurrentOrRecentRankingSeasonConfigRes season_info_res)
	{
	}

	private void ProcessBRRankMapping()
	{
	}

	public int GetBRMappingRank(int rank)
	{
		return 0;
	}

	public int GetBRUpBoundMappingRank(int rank)
	{
		return 0;
	}

	public List<LadderLevelData> GetLevelDataByRankStage(uint rankStage)
	{
		return null;
	}

	public List<LadderLevelData> GetLevelDataByRankGroup(uint rankGroup)
	{
		return null;
	}

	public List<BaseItemInfo> GetBRUnlockRewardLevelData()
	{
		return null;
	}

	public void ProcessSeasonInfoConfig(CSGetCurrentOrRecentRankingSeasonConfigRes season_info_res)
	{
	}

	public int GetBRRankBonusRadio()
	{
		return 0;
	}

	private void SetCurSeansonBRLevelData(uint SeasonId)
	{
	}

	public void RequestClaimBRWinPassReward(uint[] stages)
	{
	}

	public bool HasClaimableBRWinPassReward()
	{
		return false;
	}

	public ERanking.WinPassStatus GetWinPassRewardStatesByStage(uint stage)
	{
		return ERanking.WinPassStatus.WinPassStatus_NONE;
	}

	public List<MatchResultTaskInfo> GetBRWinPassMatchResultTaskInfosList()
	{
		return null;
	}

	private void SetBRFirstRankReward(List<BRFirstRankRewardsDesc> brFirstRankRewardDescs)
	{
	}

	public void ProcessRankFirstWin(RankingMatchParam _param)
	{
	}

	public void ProcessLadderActivityInfo(CSGetRankingActivityConfigRes _res)
	{
	}

	public void RefreshRankInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, bool forceFetch = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool login = false)
	{
	}

	public void RefreshRankTaskInfo(uint httpOp = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void InitBRRankInfo(bool silence = false)
	{
	}

	public void GetRankInfoFromServer(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool login = false)
	{
	}

	private void AfterGetBRRankInfo(CSPlayerRankingInfoRes ranking_info_res, bool initBrRankInfo = false, bool isFromBRRankingInfoRes = false)
	{
	}

	public void ProcessMapProtectionDescs(List<MapProtectionDesc> mapProtectionDescs)
	{
	}

	public List<MapProtectionDesc> GetCurEffectMapProtectionDesc(uint mapId, uint matchMode)
	{
		return null;
	}

	public List<MapProtectionDesc> GetEffectMapProtectionDesc(uint mapId, uint matchMode)
	{
		return null;
	}

	public void ProcessMapProtectionInfo(List<MapProtectionCnt> mapProtectionCnts)
	{
	}

	public uint GetBRProtectionCnt(uint mapId)
	{
		return 0u;
	}

	public string GetMapProtectionDescString(uint mapId, uint matchMode, bool isPickItemDesc = false)
	{
		return null;
	}

	public void GetRecentMaxRankInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Background)
	{
	}

	public void UpdateRecentMaxRank(uint brCurRank)
	{
	}

	public void GetDailyMissionFromServer(uint httpOp = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void ProcessBRRankDailyTaskInfo(List<RankingTaskInfo> tasks)
	{
	}

	public void UpdateBRRankDailyTaskInfo(List<tcp.RankingTaskUpdateInfo> updateInfo, ref bool hasFinishDailyBRTaskThisMatch)
	{
	}

	public void SetShowRank(bool showRank)
	{
	}

	public void OnBRSpecialMissionTipClick()
	{
	}

	public bool HasClaimAllBRWinPassReward()
	{
		return false;
	}

	public void RefreshBRWinPassRewardTipState()
	{
	}

	public void RefreshBRSpecialMissionTipState()
	{
	}

	public RankingTaskInfo GetCurBRSpecialMissionInfo()
	{
		return null;
	}

	public void AfterBRLadderMatch(MatchIncome incomeData, MatchStats statsData)
	{
	}

	public void SetBRCrossModeBannerShowStage(uint rankBefore, uint rankAfter, bool needRefreshQuickStart = false)
	{
	}

	public void ChooseRankCard(uint cardId)
	{
	}

	public bool GetPlayerRankingSeasonStats(LoadingType loadingType = LoadingType.CircleLoading)
	{
		return false;
	}

	public void GetSelfBRRankLeaderBoardPos()
	{
	}

	public bool HasPlayerEnterBRRankLobbyBefore()
	{
		return false;
	}

	public void SetHasPlayerEnterBRRankLobbyKey(bool value)
	{
	}

	public void ClaimRankingResetReward()
	{
	}

	public void UpdateRankCard(uint[] _cardInfo)
	{
	}

	public void RequestError()
	{
	}

	public override void Login(object[] data)
	{
	}

	public void RequestRankInfo()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ResetCrossModeBannerShowStage()
	{
	}

	public bool IsBefAndAfterMatchBothPeakRank()
	{
		return false;
	}

	public int GetCacheRankMasterLevel()
	{
		return 0;
	}

	public void SetSeasonChangeInfo(uint season_id)
	{
	}

	public void SetLatestRankInfo(bool isRank, uint rankBefore, uint rankAfter, int scoreBefore, int scoreAfter)
	{
	}

	private bool CheckIsNeedRankComparePop()
	{
		return false;
	}

	public void SetSelectedLadderMap()
	{
	}

	public void UpdateCurrentLadderMapOpeningInfo()
	{
	}

	public void GetSeasonData(uint season_id, uint rank_point, uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void CheckPeakChanged()
	{
	}

	public string GetSeasonRewardBGUrl()
	{
		return null;
	}

	public string GetCdnUrlSeasonAward()
	{
		return null;
	}

	public uint GetSeasonAwardId()
	{
		return 0u;
	}

	public bool IsReachRankThreshold()
	{
		return false;
	}

	public string GetCdnUrlSeasonBg()
	{
		return null;
	}

	public void SetSeasonChangeData(uint seasonID, uint lastSeasonRank, uint lastSeasonRankPoint, uint seasonRank, uint seasonRankPoint, int currentPos, int currentThreshod, int lastPos, int lastThreshold)
	{
	}

	public BRRankScoreDetailInfo HandleBRRankScoreDetailsAllScore(MatchIncome income, uint rank)
	{
		return null;
	}

	public bool IsEnterGroupRankEffectUnlocked(int rank)
	{
		return false;
	}

	public float CalcBRSeasonKD(uint gameCount, uint kills, uint wins)
	{
		return 0f;
	}

	public ResourceID GetLadderIconByLowestScore(uint score)
	{
		return default(ResourceID);
	}

	public void AddBRItemTagCount()
	{
	}

	public void ClearBRNewHotTagCountPlayerPrefs()
	{
	}

	public bool IsShowBRHotTag()
	{
		return false;
	}

	public bool IsShowBRNewTag()
	{
		return false;
	}

	private void _003CRequestBRRankingMatchGrandmasterPositions_003Eb__232_0(HttpErrorCode errodCode, object res)
	{
	}

	private bool _003CGetBRUnlockRewardLevelData_003Eb__250_0(LadderLevelData data)
	{
		return false;
	}

	private void _003CRequestClaimBRWinPassReward_003Eb__254_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CInitBRRankInfo_003Eb__263_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetRecentMaxRankInfo_003Eb__272_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetDailyMissionFromServer_003Eb__274_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CChooseRankCard_003Eb__285_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetPlayerRankingSeasonStats_003Eb__286_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CGetSelfBRRankLeaderBoardPos_003Eb__287_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CClaimRankingResetReward_003Eb__290_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
