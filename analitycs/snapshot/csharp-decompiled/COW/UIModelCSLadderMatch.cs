using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class UIModelCSLadderMatch : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RankMasterLevel> _003C_003E9__192_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__217_1;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__220_0;

		public static Comparison<BaseItemInfo> _003C_003E9__226_1;

		public static Predicate<MapOpeningInfo> _003C_003E9__257_0;

		public static Predicate<MapOpeningInfo> _003C_003E9__257_1;

		public static Comparison<FriendAccountInfo> _003C_003E9__258_2;

		public static Comparison<LeaderBoardInfo> _003C_003E9__258_0;

		public static Predicate<LeaderBoardInfo> _003C_003E9__260_1;

		internal int _003CResquestCSRankMasterLevelInfo_003Eb__192_1(RankMasterLevel a, RankMasterLevel b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimCSWinPassReward_003Eb__217_1(BaseItemInfo item)
		{
			return null;
		}

		internal BaseItemInfo _003CGetCSWinPassMatchResultTaskInfosList_003Eb__220_0(AwardDesc ite)
		{
			return null;
		}

		internal int _003CGetCSUnlockRewardLevelData_003Eb__226_1(BaseItemInfo a, BaseItemInfo b)
		{
			return 0;
		}

		internal bool _003CGetCurrentCsLadderOpeningInfo_003Eb__257_0(MapOpeningInfo x)
		{
			return false;
		}

		internal bool _003CGetCurrentCsLadderOpeningInfo_003Eb__257_1(MapOpeningInfo x)
		{
			return false;
		}

		internal int _003CRequestCSLeaderBoardFriend_003Eb__258_2(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}

		internal int _003CRequestCSLeaderBoardFriend_003Eb__258_0(LeaderBoardInfo x, LeaderBoardInfo y)
		{
			return 0;
		}

		internal bool _003CRequestCSLeaderBoardRegion_003Eb__260_1(LeaderBoardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public tcp.RankingTaskUpdateInfo info;

		internal bool _003CUpdateCSRankDailyTaskInfo_003Eb__0(CSRankingTaskInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public UIModelCSLadderMatch _003C_003E4__this;

		public uint seasonID;

		internal void _003CResquestCSRankMasterLevelInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public uint rankGroup;

		internal bool _003CGetCSRankDataByRankGroup_003Eb__0(LadderLevelData l)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass200_0
	{
		public uint rankStage;

		internal bool _003CGetCSRankDataByRankStage_003Eb__0(LadderLevelData l)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public ulong accoutid;

		public UIModelCSLadderMatch _003C_003E4__this;

		internal void _003CRequestCsRankingInfoById_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public UIModelCSLadderMatch _003C_003E4__this;

		public ulong accoutid;

		internal void _003CRequestCSRankingStatsById_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public UIModelCSLadderMatch _003C_003E4__this;

		public uint matchmode;

		public ulong accoutid;

		public Action<uint, ulong> action;

		internal void _003CGetCSPlayerStats_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass264_0
	{
		public ulong accountID;

		internal bool _003CGetCSRank_003Eb__0(LeaderBoardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public MapModeData mapData;

		internal bool _003CCheckAndSetCsRankSeletedMap_003Eb__0(MapOpeningInfo x)
		{
			return false;
		}

		internal bool _003CCheckAndSetCsRankSeletedMap_003Eb__1(MapModeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public MapModeData mapData;

		internal bool _003CCalculateIfMultiMapBuff_003Eb__0(MapModeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public uint mapId;

		internal bool _003CisForceChooseMap_003Eb__0(MapOpeningInfo x)
		{
			return false;
		}
	}

	public const string FIRST_TIME_ENTER_CS_RANK_KEY = "FirstTimeEnterCSRank";

	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLadderSeasonInfo;

	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLifeSeasonInfo;

	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSCommonSeasonInfo;

	private Dictionary<ulong, CDTimeData> m_CSLadderInfoClickDic;

	private Dictionary<ulong, CDTimeData> m_CSLadderCommonInfoClickDic;

	private Dictionary<ulong, CDTimeData> m_CSLadderLifeInfoClickDic;

	private Dictionary<ulong, CDTimeData> m_CSLadderRankingProfileClickDic;

	private Dictionary<ulong, CSLadderRankInfo> m_CsLadderRankInfo;

	private Dictionary<uint, CSRankTopAwardsDesc> m_CSRankTopAwardDic;

	private Dictionary<uint, List<RankMasterLevel>> m_CSRankMasterLevelDic;

	public List<RankingWinPassDesc> CSRankingWinPassDescs;

	public List<RankingWinPassDesc> NextSeasonCSRankingWinPassDescs;

	public List<CSRankingMultiModeBonusDesc> CSRankingCrossModeBonusList;

	private CDTimeData rankinfoclick;

	private int m_CSPlayerRankingSeasonStatsDelta;

	private int m_CSPlayerRankInfoDelat;

	private CSLadderSeasonStatsInfo m_CSLadderSeasonInfo;

	private List<uint> m_AwardsExhibitIDList;

	private List<uint> m_ExchangeExhibitIDlist;

	private uint m_InitRank;

	private uint m_LeaderBoardSize;

	public uint MaxCSLadderRank;

	public uint MinCSLadderRank;

	public bool IsNeedCSRankMapping;

	private List<LadderLevelData> m_CSLadderLevelDataList;

	private List<int> m_CSRankListForGroupRecruit;

	private List<int> m_CSMaxRankListForGroupRecruit;

	private List<LadderLevelData> m_CSExhibitLevelDataList;

	private Dictionary<int, int> m_CSRankMappingDic;

	private Dictionary<int, int> m_CSUpBoundRankMappingDic;

	private Dictionary<int, LeaderboardItemSimple> m_CSLeaderboardPosDic;

	public uint CSFirstHasRewardRank;

	public uint CSMinHeriocRank;

	public uint CSMinMasterRank;

	public bool IsCSRankAnimationOpen;

	public uint CSMinRankSort;

	private bool m_IsPendingCSRankingConfigRequest;

	public uint CurShowCSSpecialMissionID;

	public const string KEYSHOWCSSPECIALMISSIONTIP = "Key_ShowCSSpecialMissionTip";

	public ELadderRankStages CSCrossModeBannerShowStage;

	public uint CacheCSPeakRankPos;

	public uint CurCSPeakRankPos;

	private const string CSFIGHTCOUNT = "CSFIGHTCOUNT_";

	private const string CSNEWTAGCOUNT = "CSNEWTAGCOUNT_";

	private int m_CSFightCount;

	private int m_CSNewTagCount;

	private uint m_MultiMapBuff;

	private bool m_HasMultiMapBuff;

	private bool m_HasMultiMapBuffGroup;

	private bool m_MultiMapBuffInit;

	private List<MapOpeningInfo> m_CurCsrankOpeningInfo;

	private Dictionary<uint, CSProtectionDesc> m_CSProtectionConfig;

	private Dictionary<uint, uint> m_CSMapProtectionNum;

	public const string SHOW_CS_SEASON_TIPS = "Cs_Season_Restart_tips";

	public const string SHOW_CS_SEASON_END_TIPS = "Cs_Season_End_tips";

	public bool HasUnlockRewardClaimed;

	private Dictionary<uint, LadderLevelData> m_CSLadderLevelDataDic;

	private uint m_MaxRankSortwithFirstReward;

	private CSLadderRankInfo m_CurrentCSRankInfo;

	public CSRankingInfo LastSeasonRankInfo;

	public List<LadderLevelData> CSRankUpRewardList;

	public int LastPeakRankPos;

	private CSGetCurrentOrRecentCSRankingSeasonConfigRes m_CurrentOrRecentCsRankingSeasonConfig;

	private List<LeaderBoardInfo> m_LeaderBoardRegionList;

	private List<LeaderBoardInfo> m_LadderBoardFriendList;

	private LeaderBoardInfo m_PlayerLeaderBoardRegion;

	private LeaderBoardInfo m_PlayerLeaderBoardFriend;

	private float m_NextReqLeadderBoardTime;

	private float m_NextReqFriendBoardTime;

	private float m_NextReqCSRankTaskInfoTime;

	private double m_CSPeakRankThreshold;

	private double LastPeakRankThreshold;

	public bool isLastReachPeakRank;

	public const uint PropID_CSSeasonStatsRefresh = 2u;

	public const uint PropID_CSRankInfoRefreshed = 4u;

	public const uint PropID_CSRankSeasonInfoRefreshed = 8u;

	public const uint PropID_CSLifeSeasonStatsRefresh = 16u;

	public const uint PropID_CSCommonSeasonStatsRefresh = 32u;

	public const uint PropID_CSRankingStatsRefresh = 64u;

	public const uint PropID_CSLeaderBoardFriend = 128u;

	public const uint PropID_CSLeaderBoardScore = 256u;

	public const uint PropID_CSPeakRankPosRefresh = 512u;

	public const uint PropID_CSResetMatchRewardClaimSuccess = 1024u;

	public const uint PropID_CSRankingTaskInfoRefreshed = 2048u;

	public const uint PropID_CSWinPassRewardClaimSuccess = 4096u;

	public const uint PropID_CSGrandmasterPositionUpdate = 8192u;

	public const uint PropID_CSGrandmasterRequestReady = 16384u;

	public const uint PropID_ForceRefreshUIAfterRefreshBonus = 32768u;

	public const uint PropID_CSRankMasterLevelReady = 65536u;

	private List<CSRankingTaskInfo> m_CSRankingDailyTaskInfoList;

	private bool m_CSHasNewMapProtection;

	private uint m_CSNewMapId;

	private uint m_CSNewMapMaxCount;

	public bool HasFinishCSDailyFirstWinTask;

	private float m_NextReqGrandmasterPositionTime;

	public List<LadderLevelData> CSLadderLevelDataList => null;

	public List<int> CSRankListForGroupRecruit => null;

	public List<int> CSMaxRankListForGroupRecruit => null;

	public List<LadderLevelData> CSExhibitLevelDataList => null;

	public uint CSHistoryDataMaxDisplaySeasonNum => 0u;

	public float CSPeakRankPosDelayTime => 0f;

	public int CSFightCount => 0;

	public int CSNewTagCount => 0;

	public uint CSMultiMapBuff => 0u;

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

	public List<MapOpeningInfo> CurCsrankOpeningInfo => null;

	public bool IsResetMatchRewardClaimable => false;

	public CSLadderRankInfo CurrentCsRankInfo => null;

	public List<RankMasterLevel> CSRankMasterLevel => null;

	public Dictionary<uint, CSRankTopAwardsDesc> RankTopAwardDic => null;

	public int CurrentPeakRankPos => 0;

	public bool ShowCSRankUpReward => false;

	public List<CSRankingTaskInfo> CSRankingDailyTaskInfoList => null;

	public bool CSHasNewMapProtection => false;

	public uint CSNewMapId => 0u;

	public uint CSNewMapMaxCount => 0u;

	public bool HasCSDoubleBonusVaild => false;

	public bool HasMultiMapBuff()
	{
		return false;
	}

	public void SetMultiMapBuff(List<CSProtectionDesc> data)
	{
	}

	public void ForceRefreshMultiMapBuff()
	{
	}

	public void RestInitSign()
	{
	}

	public void CheckAndSetCsRankSeletedMap(bool notify = true)
	{
	}

	public void ReSetMapForRankLimit()
	{
	}

	public bool CalculateIfMultiMapBuff()
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

	public void ResetCrossModeBannerShowStage()
	{
	}

	public bool IsResetMatchRewardVisible()
	{
		return false;
	}

	public bool IsShowCSSeasonChangeWindow()
	{
		return false;
	}

	public void SetRankTopAwardDic(List<CSRankTopAwardsDesc> desc)
	{
	}

	public ResourceID GetNextCSFirstRankRewardRankIcon()
	{
		return default(ResourceID);
	}

	public void SetHasPlayerEnterCSRankLobbyKey(bool value)
	{
	}

	public bool HasPlayerEnterCSRankLobbyBefore()
	{
		return false;
	}

	public bool IsCurrentSeasonOpen()
	{
		return false;
	}

	public CSRankingSeasonInfoDesc GetCurrentSeasonInfo()
	{
		return null;
	}

	public bool CheckShowCSNewSeasonItemTips()
	{
		return false;
	}

	public bool CheckShowCSSeasonEndTips()
	{
		return false;
	}

	public bool CheckDuringCSSeasonEnd()
	{
		return false;
	}

	public bool HasCSCrossModeBonusBuff()
	{
		return false;
	}

	public uint GetCSCrossModeBonusPoint()
	{
		return 0u;
	}

	public int GetCSRankByRankPoint(int rankpoint)
	{
		return 0;
	}

	public uint GetCSRankLeaderBoardMinRank()
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

	public void UpdateSeasonInfoConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes season_info_res)
	{
	}

	private void ProcessSeasonInfoAwards(CSGetCurrentOrRecentCSRankingSeasonConfigRes season_info_res)
	{
	}

	public void InitCSRankUpRewardData(uint rank_before, uint rank_after, bool hasFirstRankAward = false)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool IsLastSeasonPeakRank(uint peakRankPos)
	{
		return false;
	}

	public bool IsPeakRank(uint peakRankPos)
	{
		return false;
	}

	public bool IsBefAndAfterMatchBothPeakRank()
	{
		return false;
	}

	public int GetCSMappingRank(int rank)
	{
		return 0;
	}

	public int GetCSUpBoundMappingRank(int rank)
	{
		return 0;
	}

	public bool isCSMaxRankUponMinRank()
	{
		return false;
	}

	public bool IsCSRankUponMinRank()
	{
		return false;
	}

	public void CSMapProtectionCountSub(uint mapID)
	{
	}

	public void RefreshDailyFirstWinState()
	{
	}

	public void OnCSSpecialMissionTipClick()
	{
	}

	public bool HasClaimAllCSWinPassReward()
	{
		return false;
	}

	public void RefreshCSWinPassRewardTipState()
	{
	}

	public void RefreshCSSpecialMissionTipState()
	{
	}

	public void RequestCSRankDailyTaskInfo(uint httpOption = 0u, bool needRealTime = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void ProcessCSRankDailyTaskInfo(List<CSRankingTaskInfo> tasks)
	{
	}

	public void UpdateCSRankDailyTaskInfo(List<tcp.RankingTaskUpdateInfo> updateInfo, ref bool hasFinishDailyCSTaskThisMatch)
	{
	}

	public bool IsCurrentPeakRank()
	{
		return false;
	}

	public int PeakRankScore(double CSscore)
	{
		return 0;
	}

	public int GetCSMinLeaderBoardUponHeroicScore()
	{
		return 0;
	}

	public void GetCurOrRecentCSRankingConfig()
	{
	}

	private void ProcessCSRankMapping()
	{
	}

	public void ResquestCSRankMasterLevelInfo(uint seasonID, LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public int GetCurrentRankMasterLevel()
	{
		return 0;
	}

	public int GetCacheRankMasterLevel()
	{
		return 0;
	}

	public int GetLastRankMasterLevel()
	{
		return 0;
	}

	public int GetMasterLevelByPeakRankPos(int peakRankPos)
	{
		return 0;
	}

	public int GetCSGrandMasterThreshold()
	{
		return 0;
	}

	public RankMasterLevel GetCSMasterLevelDataByMasterLevel(uint masterLevel)
	{
		return null;
	}

	public List<LadderLevelData> GetCSRankDataByRankGroup(uint rankGroup)
	{
		return null;
	}

	public List<LadderLevelData> GetCSRankDataByRankStage(uint rankStage)
	{
		return null;
	}

	public void GetCSLadderMatchNextShowRankInfo(ref uint nextRank, ref uint nextMasterLevel)
	{
	}

	public int GetRankMasterLevel(int position)
	{
		return 0;
	}

	public void RequestCSRankingMatchGrandmasterPositions(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool immediately = false)
	{
	}

	public void RequestCsRankingInfoById(ulong accoutid)
	{
	}

	public CSLadderRankInfo GetCsRankingInfoById(ulong accoutid)
	{
		return null;
	}

	public bool CsNotToDropPoints()
	{
		return false;
	}

	public uint GetNotToDropPointsProtectTimes()
	{
		return 0u;
	}

	public bool IsShowProtectShieldVFX()
	{
		return false;
	}

	public bool IsCSRankCardProtect()
	{
		return false;
	}

	public CSGetCurrentOrRecentCSRankingSeasonConfigRes GetFromCurOrRecentCSRankingConfig()
	{
		return null;
	}

	public void SetCurOrRecentCSRankingConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes res)
	{
	}

	private void SetCSProtectionConfig(List<CSProtectionDesc> cSProtectionsDescs)
	{
	}

	private void SetCurSeasonCSLevelData(uint SeasonId)
	{
	}

	public void RequestClaimCSWinPassReward(uint[] stages)
	{
	}

	public bool HasClaimableCSWinPassReward()
	{
		return false;
	}

	public ERanking.WinPassStatus GetCSWinPassRewardStatesByStage(uint stage)
	{
		return ERanking.WinPassStatus.WinPassStatus_NONE;
	}

	public List<MatchResultTaskInfo> GetCSWinPassMatchResultTaskInfosList()
	{
		return null;
	}

	private void SetCSFirstRankReward(List<CSFirstRankRewardsDesc> csFirstRankRewardDescs)
	{
	}

	public CSProtectionDesc GetCSProtectionConfigByRank(uint rank)
	{
		return null;
	}

	public void RequestRankMasterLevelInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestRankMatchGrandmasterPositions(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void InitPlayerCSRankingInfo(bool silence = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public List<BaseItemInfo> GetCSUnlockRewardLevelData()
	{
		return null;
	}

	private void AfterGetLastSeasonRankInfo(CSRankingInfo lastSeasonRankInfo)
	{
	}

	public void ReRequestCsRankingsInfo()
	{
	}

	public void GetPlayerCSRankingInfo(bool inmiditely = false)
	{
	}

	public uint GetCurrentCSRank()
	{
		return 0u;
	}

	public bool IsProtectedCSRank()
	{
		return false;
	}

	public uint GetCurrentCSRankSort()
	{
		return 0u;
	}

	public uint GetCSRankSortByRank(uint rank)
	{
		return 0u;
	}

	public bool IsShowCSRankNoDropDivisionCard()
	{
		return false;
	}

	public void UpdateGamePlay(uint cnt)
	{
	}

	public void ClaimRankingResetReward()
	{
	}

	private CSRankData GetCurrentCSRankData()
	{
		return null;
	}

	public CSRankingTaskInfo GetCurCSSpecialMissionInfo()
	{
		return null;
	}

	public void AfterCSLadderMatch(MatchIncome incomeData, MatchStats statsData)
	{
	}

	public void SetCSCrossModeBannerShowStage(uint rankBefore, uint rankAfter, bool needRefreshQuickStart = false)
	{
	}

	public string GetCurrentLevelRankName()
	{
		return null;
	}

	public ResourceID GetCSRankIcon(int rank, int peakRankPos, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public ResourceID GetCSRankIcon(int rank, int peakRankPos, ref float RankScale, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public void GetCSRankIconAndUIFX(int rank, uint peakRankPos, ref ResourceID iconRes, ref ResourceID effectRes, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
	}

	public CSLadderSeasonStatsInfo GetPlayerLadderSeasonStats()
	{
		return null;
	}

	public void RequestPlayerCSRankingSeasonStats()
	{
	}

	public void RequestPlayerCSRankInfo()
	{
	}

	public CSLadderSeasonStatsInfo GetCSLadderSeasonInfoData(ulong accoutid, uint matchmode)
	{
		return null;
	}

	public void RequestCSRankingStatsById(ulong accoutid)
	{
	}

	public void GetCSPlayerStats(ulong accoutid, uint matchmode, bool inmiditely = false, Action<uint, ulong> action = null)
	{
	}

	public bool IsLeaderBoardClosed()
	{
		return false;
	}

	public List<LeaderBoardInfo> GetFriendBoardScoreList()
	{
		return null;
	}

	public LeaderBoardInfo GetLocalPlayerBoardRegion()
	{
		return null;
	}

	public List<LeaderBoardInfo> GetRegionBoardScoreList()
	{
		return null;
	}

	public LeaderBoardInfo GetLocalPlayerBoardFriend()
	{
		return null;
	}

	public uint GetLeaderBoardSize()
	{
		return 0u;
	}

	public List<MapOpeningInfo> GetCurrentCsLadderOpeningInfo()
	{
		return null;
	}

	public void RequestCSLeaderBoardFriend()
	{
	}

	public void GetSelfCSRankLeaderBoardPos()
	{
	}

	public void RequestCSLeaderBoardRegion()
	{
	}

	public float GetKDANum()
	{
		return 0f;
	}

	public uint GetRealSeasonID()
	{
		return 0u;
	}

	public LeaderboardItemSimple GetCSGrandMasterLeaderboardItemDisplayInfo()
	{
		return null;
	}

	public int GetCSRank(ulong accountID)
	{
		return 0;
	}

	public void SetSeasonChangeData(uint seasonID, uint lastSeasonRank, uint lastSeasonRankPoint, uint seasonRank, uint seasonRankPoint, int currentPos, int currentThreshod, int lastPos, int lastThreshold)
	{
	}

	public void CheckPeakChanged()
	{
	}

	public void AddCSFightCount()
	{
	}

	public void ClearCSNewTagCountPlayerPrefs()
	{
	}

	public bool IsCSEnterGroupRankEffectUnlocked(uint rank)
	{
		return false;
	}

	public bool IsShowCSNewTag()
	{
		return false;
	}

	public ResourceID GetLadderIconByLowestScore(uint score)
	{
		return default(ResourceID);
	}

	public int GetRankStartCountByLowestScore(uint score)
	{
		return 0;
	}

	public uint GetRankByRankPoint(uint rankpoint)
	{
		return 0u;
	}

	public uint GetSpecialModeProtectTimes()
	{
		return 0u;
	}

	public bool IsAllPlayerRankRatingZero(List<TeammateStats> players, List<TeammateStats> opponents)
	{
		return false;
	}

	public void ProcessMapProtectionInfo(List<MapProtectionCnt> mapProtectionCnts)
	{
	}

	public uint GetCSProtectionCnt(uint mapId)
	{
		return 0u;
	}

	private void _003CRequestCSRankDailyTaskInfo_003Eb__184_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetCurOrRecentCSRankingConfig_003Eb__190_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CRequestCSRankingMatchGrandmasterPositions_003Eb__206_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003C_003En__0(uint propID, object[] param)
	{
	}

	private void _003CRequestClaimCSWinPassReward_003Eb__217_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CInitPlayerCSRankingInfo_003Eb__225_0(HttpErrorCode errodCode, object res)
	{
	}

	private bool _003CGetCSUnlockRewardLevelData_003Eb__226_0(LadderLevelData data)
	{
		return false;
	}

	private void _003CGetPlayerCSRankingInfo_003Eb__229_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CClaimRankingResetReward_003Eb__236_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCSLeaderBoardFriend_003Eb__258_1(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetSelfCSRankLeaderBoardPos_003Eb__259_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CRequestCSLeaderBoardRegion_003Eb__260_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
