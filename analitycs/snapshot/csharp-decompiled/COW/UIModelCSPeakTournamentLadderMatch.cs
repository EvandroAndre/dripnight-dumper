using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelCSPeakTournamentLadderMatch : UIBaseModel
{
	public enum ClosedSeasonStats
	{
		NotInClosedSeason = -1,
		Normal,
		ShortSeason,
		NoNextSeason
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FriendAccountInfo> _003C_003E9__132_1;

		public static Comparison<LeaderBoardInfo> _003C_003E9__132_2;

		public static Predicate<LeaderBoardInfo> _003C_003E9__134_1;

		public static Predicate<LeaderBoardInfo> _003C_003E9__135_1;

		public static Comparison<CSPeakTournamentAwardDesc> _003C_003E9__160_0;

		public static Comparison<CSPeakTournamentAwardDesc> _003C_003E9__161_0;

		public static Predicate<MapOpeningInfo> _003C_003E9__209_0;

		public static Predicate<MapOpeningInfo> _003C_003E9__209_1;

		internal int _003CRequestCSPeakLeaderBoardFriend_003Eb__132_1(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}

		internal int _003CRequestCSPeakLeaderBoardFriend_003Eb__132_2(LeaderBoardInfo x, LeaderBoardInfo y)
		{
			return 0;
		}

		internal bool _003CRequestCSPeakLeaderBoardRegion_003Eb__134_1(LeaderBoardInfo x)
		{
			return false;
		}

		internal bool _003CRequestCSPeakLeaderBoardWeek_003Eb__135_1(LeaderBoardInfo x)
		{
			return false;
		}

		internal int _003CGetCurrentSeasonAwardList_003Eb__160_0(CSPeakTournamentAwardDesc a, CSPeakTournamentAwardDesc b)
		{
			return 0;
		}

		internal int _003CGetFirstSeasonAwardList_003Eb__161_0(CSPeakTournamentAwardDesc a, CSPeakTournamentAwardDesc b)
		{
			return 0;
		}

		internal bool _003CGetCurrentCSPeakOpeningInfos_003Eb__209_0(MapOpeningInfo x)
		{
			return false;
		}

		internal bool _003CGetCurrentCSPeakOpeningInfos_003Eb__209_1(MapOpeningInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public uint seasonId;

		public bool inRecord;

		internal void _003CRequestCSPeakSeasonInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public bool needLastSeasonInfo;

		public bool inRecord;

		internal void _003CRequestPlayerCSPeakInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public ulong accountId;

		internal void _003CRequestPlayerCSPeakSeasonStats_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public ulong accountId;

		internal void _003CRequestPlayerCSPeakSeasonStatsByAccountId_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public bool displayPoint;

		internal void _003CRequestSetCSPeakDisplayPoint_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public uint seasonId;

		internal void _003CRequestCSPeakLeaderBoardRegionRecord_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public bool notify;

		internal void _003CRequestCSPeakLeaderBoardRegion_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public UIModelCSPeakTournamentLadderMatch _003C_003E4__this;

		public bool force;

		internal void _003CRequestPeakLeaderBoardTime_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public static string CSPEAK_PLAYER_NAME;

	public static string CSPEAK_ENEMY_PLAYER_NAME;

	public static string CSPEAK_MODE_NAME;

	public static string CSPEAK_POINT_NAME;

	public static string CSPEAK_BASICPOINT_CHANGE_NAME;

	public static string CSPEAK_BASICPOINT_CHANGE_TIP;

	public static string CSPEAK_ENERGY_CONVERT;

	public static string CSPEAK_POINT_CHANGE;

	public static string CSPEAK_ENERGY_TIPS;

	public static string CSPEAK_ENERGY_FREEZE;

	public static string CSPEAK_MVPBONUS;

	public static string CSPEAK_DAILYTASKBONUS;

	public static string CSPEAK_SEASONEND;

	public static string CSPEAK_STAYTUNED;

	public static string CSPEAK_NEXTSEASON;

	public static string CSPEAK_COUNTDOWN;

	private List<LeaderBoardInfo> m_CSPeakLadderBoardFriendList;

	private List<LeaderBoardInfo> m_CSPeakLeaderBoardRegionList;

	private Dictionary<uint, List<LeaderBoardInfo>> m_CSPeakLeaderBoardRegionRecordDict;

	private List<LeaderBoardInfo> m_CSPeakLeaderBoardWeekList;

	private uint m_LeaderBoardSize;

	private LeaderBoardInfo m_PlayerLeaderBoardFriend;

	private LeaderBoardInfo m_PlayerLeaderBoardRegion;

	private LeaderBoardInfo m_PlayerLeaderBoardWeek;

	private float m_NextReqFriendBoardTime;

	private float m_NextReqLeadderBoardTime;

	private bool m_HasRequestCSPeakLeaderBoardWeek;

	private int m_CurrentWeekRank;

	public const int PEAK_SCORE_MAX_LIMIT_NUM = 2500;

	public const string PEAK_SCORE_MAX_LIMIT_CONTENT = "2500+";

	private List<int> m_PeakScoreListForGroupRecruit;

	private List<int> m_PeakMaxScoreListForGroupRecruit;

	public uint CacheCSPeakTournamentRankPos;

	public uint CurCSPeakTournamentRankPos;

	private CSGetCurrentOrRecentCSPeakSeasonConfigRes m_CurrentOrRecentCsPeakSeasonConfig;

	private bool m_HasRequestPeakLeaderBoardTime;

	private string m_WeekPeakLeaderBoardStartTime;

	private string m_WeekPeakLeaderBoardEndTime;

	private long m_NextWeekPeakLeaderBoardStartTime;

	private ulong m_WeekPeakSubKey;

	private bool m_HasGetWeekPeakSubKey;

	private ELeaderBoardType m_BestLeaderBoardType;

	private Dictionary<uint, string> m_CSPeakTournamentCDNDict;

	public static uint CSPeakTournamentBundleId;

	private bool m_SelfInTop10;

	private List<ulong> m_Top3AccountIds;

	private List<int> m_PendingRequest;

	public const string SELF_IN_TOP10_KEY = "SelfInTop10";

	private bool m_IsShowCSPeakShopSound;

	public const uint PropID_CSPeakSeasonInfoRefreshed = 2u;

	public const uint PropID_PlayerCSPeakInfoRefreshed = 4u;

	public const uint PropID_PlayerCSPeakSeasonStatsRefreshed = 8u;

	public const uint PropID_PlayerCSPeakSeasonStatsHistoryRefreshed = 16u;

	public const uint PropID_CSPeakDisplayPointRefreshed = 32u;

	public const uint PropID_CSPeakLeaderBoardFriend = 64u;

	public const uint PropID_CSPeakLeaderBoardScore = 128u;

	public const uint PropID_CSPeakLeaderBoardWeek = 256u;

	public const uint PropID_CSPeakLeaderBoardWeekTime = 512u;

	public const uint PropID_CSPeakLeaderBoardRegionRecord = 1024u;

	public const uint PropID_CSPeakLeaderBoardSelfInfoRecord = 2048u;

	public const uint PropID_CSPeakLeaderBoardSeasonInfoRecord = 4096u;

	private CSGetCurrentOrRecentCSPeakSeasonConfigRes m_CurrentOrRecentCSPeakSeasonConfig;

	private Dictionary<uint, CSGetCSPeakSeasonInfoRes> m_CSPeakSeasonInfoDict;

	private Dictionary<uint, CSPlayerCSPeakInfoRes> m_PlayerCSPeakInfoDict;

	private CSPeakInfo m_LastSeasonInfo;

	public bool IsFirstInit;

	public bool IsFirstSeasonInit;

	private CSPeakInfo m_AutoTaskNeedShowCSPeakInfo;

	private Dictionary<ulong, CSGetPlayerCSPeakSeasonStatsRes> m_DicAccountIdToSeasonStats;

	private Dictionary<uint, PlayerCSPeakStatsHistory> m_PlayerCSPeakSeasonStatsHistory;

	private List<CSPeakTournamentAwardDesc> m_SeasonAwardList;

	public bool IsDisplayCSPeakPoints;

	public bool IsDisplayCSPeakPointsUI;

	private const int m_CSPeakPlayerRankingSeasonStatsDelta = 360;

	private const int m_CSPeakPlayerInfoDelta = 60;

	private Dictionary<ulong, CDTimeData> m_CSPeakSeasonStatsClickDic;

	private CDTimeData m_CSPeakPlayerInfoClick;

	private CSPeakTournamentPointCalParamDesc m_CSPeakTournamentPointCalParamDesc;

	private bool m_HasGetPlayerCSPeakSeasonStatsHistory;

	private bool m_NeedShowCSPeakInvitation;

	private const string CSPEAK_TUTORIAL_VIEWED_KEY = "CSPeakTutorialViewed_";

	private const string CSPEAK_WEBVIEW_TUTORIAL_BEFORE_FIRST_SEASON_KEY = "CSPeakTutorialBeforeFirstSeason_";

	public CSPeakTournamentAwardDesc CSPeakRankUpRewardDesc;

	public int EnergyWinExtra => 0;

	public int EnergyFreeze => 0;

	public int EnergyHide => 0;

	public bool EnergyOpen => false;

	public List<int> PeakScoreListForGroupRecruit => null;

	public List<int> PeakMaxScoreListForGroupRecruit => null;

	public int CurrentWeekRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string WeekPeakLeaderBoardStartTime => null;

	public string WeekPeakLeaderBoardEndTime => null;

	public long NextWeekPeakLeaderBoardStartTime => 0L;

	public bool HasGetWeekPeakSubKey => false;

	public bool SelfInTop10 => false;

	public List<ulong> Top3AccountIds => null;

	public CSGetCurrentOrRecentCSPeakSeasonConfigRes CurrentOrRecentCSPeakSeasonConfig => null;

	public CSPeakInfo LastSeasonInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CSPeakInfo AutoTaskNeedShowCSPeakInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<uint, PlayerCSPeakStatsHistory> PlayerCSPeakSeasonStatsHistory => null;

	public bool NeedShowCSPeakInvitation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowCSPeakRankUpReward => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessCurrentOrRecentCSPeakSeasonConfig(CSGetCurrentOrRecentCSPeakSeasonConfigRes res)
	{
	}

	private void InitPeakScoreListForGroupRecruit()
	{
	}

	public int GetPeakScoreRangeIndex(uint playerScore)
	{
		return 0;
	}

	public void RequestCSPeakSeasonInfo(uint seasonId, bool inRecord = false)
	{
	}

	public void RequestCurrentOrRecentCSPeakSeasonConfig()
	{
	}

	public void RequestPlayerCSPeakInfo(uint seasonId = 0u, bool needLastSeasonInfo = false, bool inRecord = false)
	{
	}

	public void CheckAndInitPlayerCSPeakInfo(bool force = false)
	{
	}

	public void RequestPlayerCSPeakSeasonStats(uint seasonId = 0u)
	{
	}

	public void RequestPlayerCSPeakSeasonStatsByAccountId(uint seasonId = 0u, ulong accountId = 0uL)
	{
	}

	public void RequestPlayerCSPeakSeasonStatsHistory(uint currentSeasonId)
	{
	}

	public void RequestSetCSPeakDisplayPoint(uint seasonId, bool displayPoint)
	{
	}

	public void ReSetLeaderBoardRequestCD()
	{
	}

	public void RequestCSPeakLeaderBoardFriend()
	{
	}

	public void RequestCSPeakLeaderBoardRegionRecord(uint seasonId)
	{
	}

	public void RequestCSPeakLeaderBoardRegion(bool force = false, bool notify = true)
	{
	}

	public void RequestCSPeakLeaderBoardWeek(bool force = false)
	{
	}

	private void RefreshWeekLeaderBoardRelatedData()
	{
	}

	public void RequestPeakLeaderBoardTime(bool force = false)
	{
	}

	public void CheckAndRequestNextSeasonInfo()
	{
	}

	public bool CheckCSPeakTournamentOpen()
	{
		return false;
	}

	public bool IsPeakTournamentSquadAvailable()
	{
		return false;
	}

	public bool IsNextSeasonPeakTournamentSquadAvailable()
	{
		return false;
	}

	public bool CheckCSPeakTournamentGroupInviteIconShowOpen()
	{
		return false;
	}

	public bool CheckLeaderBoardOpen()
	{
		return false;
	}

	public bool CheckTopTenLeaderBoardOpen()
	{
		return false;
	}

	public CSPeakTournamentSeasonInfoDesc GetCurrentOrRecentSeasonInfo()
	{
		return null;
	}

	public CSPeakTournamentSeasonInfoDesc GetCurrentOrNextSeasonInfo()
	{
		return null;
	}

	public uint GetCurrentOrRecentSeasonId()
	{
		return 0u;
	}

	public string GetCurrentOrRecentSeasonNameId()
	{
		return null;
	}

	public bool CheckIsBeforeFirstSeason()
	{
		return false;
	}

	public string GetCSPeakTournamentCDN(CSPeakTournamentCDNKey cdnKey)
	{
		return null;
	}

	public CSPlayerCSPeakInfoRes GetPlayerCSPeakInfoBySeasonId(uint seasonId)
	{
		return null;
	}

	public CSPlayerCSPeakInfoRes GetCurrentPlayerCSPeakInfo()
	{
		return null;
	}

	public uint GetCurrentPlayerCSPeakPoints()
	{
		return 0u;
	}

	public uint GetCurrentPlayerCSPeakMaxPoints()
	{
		return 0u;
	}

	public CSPeakTournamentSeasonInfoDesc GetCSPeakSeasonInfo(uint seasonId)
	{
		return null;
	}

	public CSPeakTournamentSeasonInfoDesc GetNextSeasonInfo()
	{
		return null;
	}

	public LeaderBoardInfo GetCSPeakPlayerInfoResBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<LeaderBoardInfo> GetCSPeakLeaderBoardRegionRecordBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<CSPeakTournamentAwardDesc> GetSeasonAwardList()
	{
		return null;
	}

	private List<CSPeakTournamentAwardDesc> GetCurrentSeasonAwardList()
	{
		return null;
	}

	private List<CSPeakTournamentAwardDesc> GetFirstSeasonAwardList()
	{
		return null;
	}

	public PlayerCSPeakStatsHistory GetPlayerCSPeakStatsHistoryBySeasonId(uint seasonId)
	{
		return null;
	}

	public bool IsInSeasonOpenTime()
	{
		return false;
	}

	public ClosedSeasonStats GetClosedSeasonType()
	{
		return ClosedSeasonStats.Normal;
	}

	public bool IsBeforeSeasonFinalSettlementTime()
	{
		return false;
	}

	public bool IsInSeasonFinalSettlementTime()
	{
		return false;
	}

	public bool IsInDailyOpenTime()
	{
		return false;
	}

	public bool HasReachedPreRankRequirement(bool ignoreNextSeaonInfo = false)
	{
		return false;
	}

	public bool HasReachedRankRequirement(bool ignoreDirectAccess = false, bool ignoreNextSeaonInfo = false)
	{
		return false;
	}

	public bool HasReachedRankRequirementBeforeFirstSeason()
	{
		return false;
	}

	public bool HasDirectAccessToCSPeakTournament()
	{
		return false;
	}

	public uint GetDirectAccessToCSPeakTournamentRank()
	{
		return 0u;
	}

	public bool CanShowCSPeakOccupation(uint csPeakPoints)
	{
		return false;
	}

	public bool CanShowCSPeakRanking(AccountInfoBasic data)
	{
		return false;
	}

	public bool CanShowCSPeakRanking(BaseProfileInfo data)
	{
		return false;
	}

	public bool CanShowCSPeakRanking(GroupRecruitTeamMemberInfo data)
	{
		return false;
	}

	public bool CanShowCSPeakRankGroupInviteIcon(BaseProfileInfo data)
	{
		return false;
	}

	public bool CanPlayCSPeakRankGroup(BaseProfileInfo data)
	{
		return false;
	}

	public bool CanPlayCSPeakRankGroup(uint point)
	{
		return false;
	}

	public bool CheckCSPeakTournamentMinPoint(uint cs_peak_points)
	{
		return false;
	}

	public bool CanShowCSPeakRanking(uint points)
	{
		return false;
	}

	public uint GetCSPeakTournamentMinPoint()
	{
		return 0u;
	}

	public uint GetCSPeakTournamentMaxPoint()
	{
		return 0u;
	}

	public long GetTodayCSPeakOpenTimestamp()
	{
		return 0L;
	}

	public long GetTodayCSPeakEndTimestamp()
	{
		return 0L;
	}

	public bool CheckNeedPopCSPeakMatchResultWindow(int beforeRank, int currentRank)
	{
		return false;
	}

	public bool IsShowCSPeakSeasonChangeWindow()
	{
		return false;
	}

	public void AfterCSPeakLadderMatch(MatchIncome incomeData)
	{
	}

	public void UpdateCurrentOrRecentCSPeakConfigWhenNewSeasonEnter()
	{
	}

	public uint GetCurrentSeasonLeftDays()
	{
		return 0u;
	}

	public uint GetDaysToNextSeasonStart()
	{
		return 0u;
	}

	public uint GetPointsNeededForCSPeakUnlock(uint currentRankScore = 0u)
	{
		return 0u;
	}

	public bool NeedShowTutorial()
	{
		return false;
	}

	public void SetTutorialViewed()
	{
	}

	public bool NeedShowWebviewTutorialBeforeFirstSeason()
	{
		return false;
	}

	public void SetWebviewTutorialBeforeFirstSeasonViewed()
	{
	}

	public bool CurrentOrRecentSeasonHasCSPeakPoints()
	{
		return false;
	}

	public void InitCSPeakRankUpRewardData(int ranking_points, int ranking_points_after)
	{
	}

	public MapOpeningInfo GetCurrentCSPeakOpeningInfo()
	{
		return null;
	}

	public List<MapOpeningInfo> GetCurrentCSPeakOpeningInfos()
	{
		return null;
	}

	public CSGetPlayerCSPeakSeasonStatsRes GetSeasonStatsByAccountId(ulong accountId)
	{
		return null;
	}

	public void SetBestLeaderBoardType(ELeaderBoardType type)
	{
	}

	public ELeaderBoardType GetBestLeaderBoardType()
	{
		return ELeaderBoardType.None;
	}

	public ELeaderBoardType GetLeaderBoardTypeByTitleRegion(ELeaderBoardTitleRegionType regionType)
	{
		return ELeaderBoardType.None;
	}

	public void RefreshBestLeaderBoard()
	{
	}

	public LeaderBoardInfo GetLocalPlayerBoardFriend()
	{
		return null;
	}

	public List<LeaderBoardInfo> GetFriendLeaderboardBoardScoreList()
	{
		return null;
	}

	public LeaderBoardInfo GetLocalPlayerBoardRegion()
	{
		return null;
	}

	public List<LeaderBoardInfo> GetRegionLeaderboardBoardScoreList()
	{
		return null;
	}

	public uint GetRegionLeaderboardSize()
	{
		return 0u;
	}

	public List<LeaderBoardInfo> GetCSPeakTopWeekLeaderBoard()
	{
		return null;
	}

	public LeaderBoardInfo GetCSPeakSelfWeekInfo()
	{
		return null;
	}

	public List<uint> GetCurrentAvailableSelectedMapIDList()
	{
		return null;
	}

	private bool CheckInDailyOpenTime(DateTime startTime, DateTime endTime)
	{
		return false;
	}

	private void SetDisplayCSPeakPoints(bool displayPoint)
	{
	}

	public static bool IsMatchModeCSPeak()
	{
		return false;
	}

	public static string GetCSPeakPlayerName(int teamIndex, bool isEnemy = false, string realName = null)
	{
		return null;
	}

	public static string GetModeName()
	{
		return null;
	}

	public void GetSelfCSPeakLeaderBoardPos()
	{
	}

	public string GetOpenTimeText()
	{
		return null;
	}

	public void GenerateUnlockText(UILabel label)
	{
	}

	public bool IsFirstShowCSPeakShopSound()
	{
		return false;
	}

	public void SetCSPeakShopSoundIsShow(bool isShow)
	{
	}

	public bool CheckItemOwned(uint itemID)
	{
		return false;
	}

	public int GetLeftDaysToSeasonEnd()
	{
		return 0;
	}

	public int GetPassedDaysToSeasonOpen()
	{
		return 0;
	}

	private void _003CRequestCurrentOrRecentCSPeakSeasonConfig_003Eb__123_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CCheckAndInitPlayerCSPeakInfo_003Eb__125_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPlayerCSPeakSeasonStatsHistory_003Eb__129_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCSPeakLeaderBoardFriend_003Eb__132_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCSPeakLeaderBoardWeek_003Eb__135_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetSelfCSPeakLeaderBoardPos_003Eb__228_0(HttpErrorCode errodCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
