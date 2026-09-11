using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelClanWarV2 : UIBaseModel
{
	public class ReqRecord
	{
		public uint StageID;

		public ulong TimeStamp;

		public ELeaderBoardTitleRegionType RegionType;

		public uint NotifyID;
	}

	public class ProgressState
	{
		public uint NotifyID;

		public bool OnBoard;

		public uint Rank;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GuildWarConditionConfigDesc> _003C_003E9__131_0;

		internal bool _003CInitGuildWarOpenInfo_003Eb__131_0(GuildWarConditionConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public ulong clanId;

		internal bool _003CGetClanWarInGameItemInfoByClanId_003Eb__0(ClanWarInGameItemInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public uint season;

		public uint round;

		internal bool _003CGetGuildWarOpenInfoDesc_003Eb__0(GuildWarOpenInfoDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public UIModelClanWarV2 _003C_003E4__this;

		public CSGetGuildWarInfoReq req;

		public string cmd;

		internal void _003CRequestGuildWarInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public proto.GuildWarPlayerTitleInfo title;

		internal bool _003CTryProcessTitleDict_003Eb__0(GuildWarLeaderboardTitleDesc x)
		{
			return false;
		}

		internal bool _003CTryProcessTitleDict_003Eb__1(proto.GuildWarTitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public UIModelClanWarV2 _003C_003E4__this;

		public uint titleId;

		public string cmd;

		internal void _003CRequestUpdateEquippedTitleInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public proto.GuildWarPlayerTitleInfo playerTitleInfo;

		internal bool _003CTryRefreshTitleSelectedState_003Eb__0(proto.GuildWarTitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass188_0
	{
		public ELeaderboard.LeaderboardMainType leaderBoardType;

		internal bool _003CGetSelfClanWarLeaderBoardId_003Eb__0(ClanAreaLeaderboardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass200_0
	{
		public UIModelClanWarV2 _003C_003E4__this;

		public CSGetGuildWarMemberStatsReq req;

		public string cmd;

		internal void _003CRequestMatchHistory_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass213_0
	{
		public UIModelClanWarV2 _003C_003E4__this;

		public string cmd;

		internal void _003CRequestBarrageData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass219_0
	{
		public UIModelClanWarV2 _003C_003E4__this;

		public CSGetGuildWarMemberStatsReq req;

		public string pending;

		internal void _003CRequestMatchHistory_OnlyForWarTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const string INPAGE_CLANWAR_CHANGE_SHOWED = "INPAGE_CLANWAR_CHANGE_SHOWED_{0}_{1}";

	public const string LOBBY_CLANWAR_AUTOTASK_SHOWED = "LOBBY_CLANWAR_AUTOTASK_SHOWED_{0}_{1}_{2}";

	public const string PREFS_ACCOUNT_CLANWAR_TOPHISTORY = "CLANWAR_TOPHISTORY_{0}";

	public const string PREFS_ACCOUNT_CLANWAR_TOPHISTORY_STAGE = "CLANWAR_TOPHISTORY_STAGE_{0}";

	public const string CHECK_TITLE_HISTORY = "CHECK_TITLE_HISTORY_{0}_{1}";

	public const uint PropID_WarStageChange = 1u;

	public const uint PropID_WarGameItemInfo = 2u;

	public const uint PropID_LeaderBoardClan = 4u;

	public const uint PropID_LeaderBoard_WarInfo = 8u;

	public const uint PropID_GetClanWarLeaderBoardDesc = 16u;

	public const uint PropID_GetSelfClanWarLeaderBoardInfo = 32u;

	public const uint PropID_ClanWarTitleReady = 64u;

	public const uint PropID_MatchHistoryReady = 256u;

	public const uint PropID_ReceiveNewClanTitleTcp = 512u;

	public const uint PropID_BarrageDataReady = 1024u;

	public const uint PropID_HistoryLastRound = 2048u;

	public const uint PropID_NoLastRound = 4096u;

	public const uint PropID_UpdateGuildWarTitleInfo = 8192u;

	public const uint ALL_CLANWAR_TITLE_READY = 48u;

	public const int INVALID_SCORE = -1;

	public const int REQ_CD_SECOND = 10;

	public const int HACK_TOP_POSITION = 99;

	private uint m_TopMatchPerRound;

	private uint m_TopPlayerCount;

	private ELeaderBoardTitleRegionType m_CurSearchRegionType;

	private ELeaderBoardTitleRegionType m_ResultMatchRegtionType;

	private bool m_NeedRequestLeaderBoardInOrder;

	private bool m_AlreadyRequestMatchResultLeaderInfo;

	public uint DebugOpeningNum;

	public uint CurEquipTitleId;

	private ClanWarV2Stage m_CurStage;

	private List<GuildWarPointParamDesc> m_GuideWarPointDescList;

	private List<GuildWarOpenInfoDesc> m_GuildWarOpenInfoList;

	private uint m_ClanWarTitleReadyFlag;

	private List<ulong> m_ClanWarBeAceTeamIdList;

	private List<ClanWarInGameItemInfo> m_ClanWarInGameInfoItemList;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private Dictionary<uint, proto.GuildWarPlayerTitleInfo> m_DictIdToClanTitles;

	private Dictionary<string, Dictionary<ulong, ClanAreaLeaderboardDesc>> m_DictRegionToDicIdToClanWarLeaderBoardDesc;

	private Dictionary<ulong, uint> m_DicIdToClanWarLeaderBoardStartScore;

	private Dictionary<ulong, uint> m_DicIdToClanWarLeaderBoardAwardID;

	private Dictionary<uint, GuildTitleLeaderboardInfo> m_DictRoundRankChange;

	private bool m_HasReceivedNewGuildTitleTcp;

	public const int INVALID_ROUND_RANK_CHANGE = int.MinValue;

	private List<GuildWarMemberInfo> m_ListIndividualTop3;

	private string m_PrefsHistoryRecord;

	private string[] m_PrefsHistoryRecordArray;

	private int m_CurHistoryScore;

	private string m_CurHistoryRecord;

	private bool m_ShouldReqMatchHistory;

	private List<GuildWarMemberStats> m_MatchHistoryList;

	private Dictionary<uint, uint> m_DictRoundMatchHistoryCnt;

	private ProgressState m_LastProgressState;

	private ReqRecord m_LastReq_LeaderBoard;

	private ReqRecord m_LastReq_GetGuildWarInfo;

	private uint m_ClanWarCachedScore;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private Dictionary<uint, int> m_DictGuildWarScore;

	private bool m_HasRequestedNewTitleInfo;

	private int m_BarrageIndex;

	private List<BarrageData> m_BarrageDataList;

	private bool m_ShouldReqBarrage;

	private ulong m_LastSuccessBarrageTimeStamp;

	private List<GuildWarRoundInfo> m_RoundingInfoList;

	private CSGuildWarPointParamDesc m_CSGuildWarPointParamDesc;

	public uint TopMatchPerRound => 0u;

	public uint TopPlayerCount => 0u;

	public ELeaderBoardTitleRegionType CurSearchRegionType
	{
		get
		{
			return ELeaderBoardTitleRegionType.None;
		}
		set
		{
		}
	}

	public ELeaderBoardTitleRegionType ResultMatchRegtionType
	{
		get
		{
			return ELeaderBoardTitleRegionType.None;
		}
		set
		{
		}
	}

	public bool AlreadyRequestMatchResultLeaderInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedRequestLeaderBoardInOrder
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ClanWarV2Stage CurStage => null;

	public bool ClanWarEnable => false;

	public bool ClanWarLeaderboardEnable => false;

	public List<GuildWarPointParamDesc> GuideWarPointDescList => null;

	private uint ClanWarTitleReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<ClanWarInGameItemInfo> ClanWarInGameInfoItemList => null;

	public List<ulong> ClanWarBeAceTeamIdList => null;

	private UIModelLeaderBoard ModelLeaderBoard => null;

	public bool HasReceivedNewTitleTcp => false;

	public bool ShouldReqMatchHistory => false;

	public ProgressState LastProgressState => null;

	public ReqRecord LastReq_LeaderBoard => null;

	public uint ClanWarCachedScore
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool HasRequestedNewTitleInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CSGuildWarPointParamDesc CSGuildWarPointParamDesc => null;

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void OnStartMatch()
	{
	}

	public void ClearIdList()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void OnClanChange(bool joinNew)
	{
	}

	public string GetRegionSpriteNameByType(ELeaderBoardTitleRegionType curBoardRegionType)
	{
		return null;
	}

	public ulong GetClanIdByAccoutnId(ulong accountId)
	{
		return 0uL;
	}

	public ulong GetClanIdByPlayerId(BHGGAEEHJCO playerId)
	{
		return 0uL;
	}

	public ClanWarInGameItemInfo GetClanWarInGameItemInfoByClanId(ulong clanId)
	{
		return null;
	}

	public bool CheckSelfClanWarEnablePlay()
	{
		return false;
	}

	public bool CheckMemberClanWarEnablePlay()
	{
		return false;
	}

	private bool CheckLevelSatisfy(uint level)
	{
		return false;
	}

	public int GetClanWarUnlockLevel()
	{
		return 0;
	}

	public void InitGuildWarOpenInfo(CSGuildWarBasicInfoRes res, bool notify = true)
	{
	}

	public void AddClanWarAceTeamIdByPlayer(ulong clanID)
	{
	}

	public bool IsClanWarDescOpen()
	{
		return false;
	}

	public void UpdateAllTeamRankInfo()
	{
	}

	public void SetClanWarAllTeamList(List<tcp.ClanInfo> clanInfoList)
	{
	}

	public static int SortInGameInfo(ClanWarInGameItemInfo itemA, ClanWarInGameItemInfo itemB)
	{
		return 0;
	}

	public void SetClanWarAceTeamIdList(List<ulong> clanBeAceIds)
	{
	}

	public void RefreshCurrentWarStage(bool force = false, bool notify = true)
	{
	}

	public void RecordRoundChangePageShowed()
	{
	}

	public bool NeedShowRoundChangePage()
	{
		return false;
	}

	public int GetSeasonForLeaderBoard()
	{
		return 0;
	}

	public int GetRoundFilterNumberForLeaderBoard()
	{
		return 0;
	}

	public ulong GetSeasonStartTimeStamp(uint season)
	{
		return 0uL;
	}

	public ulong GetSeasonEndTimeStamp(uint season)
	{
		return 0uL;
	}

	public uint GetMaxRoundOfSeason(uint season)
	{
		return 0u;
	}

	public bool GetBarrageIsOpen()
	{
		return false;
	}

	public GuildWarOpenInfoDesc GetGuildWarOpenInfoDesc(uint season, uint round)
	{
		return null;
	}

	public proto.EClan.GuildWarSeasonType GetGuildWarOpenInfoSeasonType(uint season)
	{
		return proto.EClan.GuildWarSeasonType.GuildWarSeasonType_NONE;
	}

	public GuildWarOpenInfoDesc GetGuildWarOpenInfoDescByTimeStamp(long time)
	{
		return null;
	}

	public void RecordLastProgressState(uint notifyID, bool onBoard, uint rank)
	{
	}

	public void RecordLastReq_LeaderBoard(ELeaderBoardTitleRegionType region, uint notifyID)
	{
	}

	public void CheckRequestNextRegionLeaderBoard(ELeaderBoardTitleRegionType type)
	{
	}

	public void CheckCurLeaderBoardIsValid(uint notifyID)
	{
	}

	public bool CheckNeedRequest_LeaderBoard()
	{
		return false;
	}

	private bool CheckNeedRequest_GetGuildWarInfo()
	{
		return false;
	}

	public void RequestClanWarV2ResultMatch()
	{
	}

	public void RequestGuildWarInfo(bool force = false)
	{
	}

	private void IndividualTop3_ProcessMemberInfo(List<GuildWarMemberInfo> infos)
	{
	}

	public GuildWarMemberInfo IndividualTop3_GetInfoByRank(int rank)
	{
		return null;
	}

	public void ResetInfoReadyFlag()
	{
	}

	private void UpdateClanWarAreaInfo(bool joinNew)
	{
	}

	private void ClearLeaderBoardDesc()
	{
	}

	public void ReqeustClanWarTitleAllMessage(bool requestDesc = true, bool requestInfo = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateClanWarTitlesIfNeeded(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void OnRespondClanAreaLeaderBoardDesc()
	{
	}

	public void OnRespondClanAreLeaderBoardInfo()
	{
	}

	public void OnReceiveNewGuildTitleTcp(ReceiveGuildWarTitleReq res)
	{
	}

	public bool IsClanWarTitleReady()
	{
		return false;
	}

	public bool IsClanWarTitleNotExpire(uint titleID)
	{
		return false;
	}

	private void TryProcessTitleDict(List<proto.GuildWarPlayerTitleInfo> titles)
	{
	}

	public void RequestUpdateEquippedTitleInfo(uint titleId, bool isAutoEquip)
	{
	}

	public bool TryRefreshTitleSelectedState()
	{
		return false;
	}

	private void ProcessClanWarLeaderBoardDesc(Dictionary<string, Dictionary<uint, ClanAreaLeaderboardDesc>> dic)
	{
	}

	public proto.GuildWarTitleInfo GetClanWarTitleInfoByTitleCfgID(uint titleCfgId)
	{
		return null;
	}

	public proto.GuildWarTitleInfo GetTopClanWarTitleInfo()
	{
		return null;
	}

	public proto.GuildWarPlayerTitleInfo GetTopClanWarPlayerTitleInfo()
	{
		return null;
	}

	public proto.GuildWarTitleInfo GetEquipClanWarTitleInfo()
	{
		return null;
	}

	public proto.GuildWarPlayerTitleInfo GetSelectedClanWarTitleInfo()
	{
		return null;
	}

	public List<tcp.GuildWarTitleInfo> GetTcpSelectedGuildTitleInfoList()
	{
		return null;
	}

	public List<proto.GuildWarPlayerTitleInfo> GetSortedClanTitleInfoList()
	{
		return null;
	}

	private int SortClanTitleInfo(proto.GuildWarPlayerTitleInfo x, proto.GuildWarPlayerTitleInfo y)
	{
		return 0;
	}

	public string GetClanWarLeaderBoardNameByLeaderBoardID(ulong leaderBoardID, string gameRegion)
	{
		return null;
	}

	public string GetRealTitleRegionName(uint areaID, string areaName)
	{
		return null;
	}

	public bool GetClanWarLeaderBoardStartScoreByNotifyID(uint nofityID, out uint score, ELeaderboard.LeaderboardMainType type = ELeaderboard.LeaderboardMainType.Leaderboard_AREA_GUILD_WAR)
	{
		score = default(uint);
		return false;
	}

	public bool GetClanWarLeaderBoardStartScoreByLeaderBoardID(ulong leadboardID, out uint score)
	{
		score = default(uint);
		return false;
	}

	public bool GetClanWarLeaderBoardAwardIDByNotifyID(uint nofityID, out uint score, ELeaderboard.LeaderboardMainType type = ELeaderboard.LeaderboardMainType.Leaderboard_AREA_GUILD_WAR)
	{
		score = default(uint);
		return false;
	}

	public bool GetClanWarLeaderBoardAwardIDByLeaderBoardID(ulong leaderboardID, out uint awardID)
	{
		awardID = default(uint);
		return false;
	}

	public ulong GetSelfClanWarLeaderBoardId(ELeaderboard.LeaderboardMainType leaderBoardType, ELeaderBoardTitleRegionType regionType)
	{
		return 0uL;
	}

	public uint GetClanWarLeaderBoardRegionType(ulong id, string lockRegion)
	{
		return 0u;
	}

	public bool CheckClanWarLeaderBoardIsDelete(ulong id, string lockRegion)
	{
		return false;
	}

	public int GetClanWarLeaderBoardMainType(ulong id, string lockRegion)
	{
		return 0;
	}

	public int GetSelfRoundRankChange(ELeaderBoardTitleRegionType regionType)
	{
		return 0;
	}

	private void SetRoundMatchHistoryCnt(uint season, uint round, uint cnt)
	{
	}

	public void ResetMatchHistoryReqCD()
	{
	}

	public string GetLastRoundResultPlayerPrefsKey()
	{
		return null;
	}

	public string GetLimitedEventStartPlayerPrefsKey()
	{
		return null;
	}

	public string GetInClanWarPagePopupPlayerPrefsKey()
	{
		return null;
	}

	public void RequestMatchHistoryForRoundResultPopup(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public List<GuildWarMemberStats> GetMatchHistoryList(int maxNumber)
	{
		return null;
	}

	public void RequestMatchHistory(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public int GetRoundSelfScore()
	{
		return 0;
	}

	private void UpdateCurHistoryRecord()
	{
	}

	private void UpdatePrefsHistoryRecord()
	{
	}

	public bool HasNewHistoryRecord()
	{
		return false;
	}

	public bool IsHistoryMatch(string matchTime)
	{
		return false;
	}

	public void RecordHistoryRecordPrefs()
	{
	}

	public bool HasMatchHistory()
	{
		return false;
	}

	private void UpdateClanWarScoreDict(uint season, uint maxRound, List<GuildWarRoundInfo> list)
	{
	}

	public int GetClanWarScore(uint season, uint round)
	{
		return 0;
	}

	private void SetClanWarScore(uint season, uint round, int score)
	{
	}

	public bool TryGetBarrageData(out BarrageData lobbyBarrageData)
	{
		lobbyBarrageData = null;
		return false;
	}

	public bool IsHasBarrageData()
	{
		return false;
	}

	public void RequestBarrageData()
	{
	}

	public void ResetBarrageReqCD()
	{
	}

	private void ProcessBarrageData(List<GuildWarAccountStats> list)
	{
	}

	public bool HasParticipatedInSpecialRound(uint round)
	{
		return false;
	}

	public bool CheckWarTitleValid_HasMatchHistory(long time)
	{
		return false;
	}

	public void RequestMatchHistory_LastRound()
	{
	}

	private void RequestMatchHistory_OnlyForWarTitle(uint season, uint round)
	{
	}

	public ClanWarInGameItemInfo GetMyTeamClanInfoInCSorLWMode(ulong accountID)
	{
		return null;
	}

	public ClanWarInGameItemInfo GetOpTeamClanInfoInCSorLWMode(ulong accountID)
	{
		return null;
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
