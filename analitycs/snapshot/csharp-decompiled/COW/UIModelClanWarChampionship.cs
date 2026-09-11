using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelClanWarChampionship : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GuildWarTournamentDesc> _003C_003E9__72_0;

		public static Comparison<TournamentMemberInfo> _003C_003E9__102_0;

		internal int _003CInitGuildWarTournamentOpenInfo_003Eb__72_0(GuildWarTournamentDesc x, GuildWarTournamentDesc y)
		{
			return 0;
		}

		internal int _003CIndividualTop3_ProcessMemberInfo_003Eb__102_0(TournamentMemberInfo x, TournamentMemberInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UIModelClanWarChampionship _003C_003E4__this;

		public bool needPreviousHistory;

		internal void _003CCheckClanWarChampionshipSlapNeedProto_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public UIModelClanWarChampionship _003C_003E4__this;

		public string cmd;

		internal void _003CRequestClanWarChampionshipEliminatorInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public UIModelClanWarChampionship _003C_003E4__this;

		public string cmd;

		internal void _003CRequestMatchHistory_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public UIModelClanWarChampionship _003C_003E4__this;

		public string cmd;

		internal void _003CRequestPreviousRoundMatchHistory_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_ChampionshipInfo = 2u;

	public const uint PropID_MatchPoolInfo = 4u;

	public const uint PropID_Stage_Change = 8u;

	public const uint PropID_MatchHistoryReady = 16u;

	public const uint PropID_PreviousMatchHistoryReady = 32u;

	public const string INPAGE_CLANWARCHAMPIONSHIP_CHANGE_SHOWED = "INPAGE_CLANWARCAHMPIONSHIP_CHANGE_SHOWED_{0}_{1}";

	public const string LOBBY_CLANWARCHAMPIONSHIP_AUTOTASK_SHOWED = "LOBBY_CLANWARCAHMPIONSHIP_AUTOTASK_SHOWED_{0}_{1}_{2}";

	public const string CLAN_INTERNAL_CLANWARCHAMPIONSHIP_SHOWED = "CLAN_INTERNAL_CLANWARCHAMPIONSHIP_SHOWED_{0}_{1}_{2}";

	public const string PREFS_ACCOUNT_CLANWARCHAMPIONSHIP_TOPHISTORY = "CLANWARCAHMPIONSHIP_TOPHISTORY_{0}";

	public const string PREFS_ACCOUNT_CLANWARCAHMPIONSHIP_TOPHISTORY = "CLANWAR_TOPHISTORYCAHMPIONSHIP_{0}";

	private List<TournamentMemberInfo> m_ListIndividualTop3;

	private List<GuildWarTournamentDesc> m_GuildWarChampionshipDescs;

	private List<GuildWarMemberStats> m_MatchHistoryList;

	private Dictionary<uint, GuildWarPlayerTitleInfo> m_DictIdToClanTitles;

	private bool m_HasReceivedNewGuildTitleTcp;

	private int m_CurHistoryScore;

	private string m_CurHistoryRecord;

	private string m_PrefsHistoryRecord;

	private string[] m_PrefsHistoryRecordArray;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private bool m_HasRequestEliminatorInfo;

	private bool m_HasRequestMatchHistory;

	private ulong m_LastRequestInfoTime;

	private ulong m_LastRequestMatchHistory;

	private const uint m_RequestCd = 10u;

	public const int INVALID_SCORE = -1;

	public bool GetQualifierResult;

	public bool HasRequestLeaderBoard;

	public string TournamentOpeningTime;

	public uint TournamentAdvancedRoundId;

	public bool InUpdateTournamentAdvancedRoundId;

	private List<GuildWarMemberStats> m_PreviousMatchHistoryList;

	private bool m_HasRequestPreviousMatchHistory;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private ClanWarChampionshipStage m_CurrentStage;

	private List<GuildWarPointParamDesc> m_GuideWarTournamentPointDescList;

	private bool m_AlreadyRequestMatchResultLeaderInfo;

	public bool HasReceivedNewTitleTcp => false;

	public bool HasRequestPreviousMatchHistory => false;

	private UIModelLeaderBoard ModelLeaderBoard => null;

	public ClanWarChampionshipStage CurrentStage => null;

	public bool HasRequestEliminatorInfo => false;

	public bool ClanWarChampionshipEnable => false;

	public bool EliminatorOpen => false;

	public bool EliminatorMatchOpen => false;

	public List<GuildWarPointParamDesc> GuideWarTournamentPointDescList => null;

	public List<GuildWarTournamentDesc> GuildWarChampionshipDescs => null;

	public uint MaxRoundId => 0u;

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

	public override void Init()
	{
	}

	public void OnStartMatch()
	{
	}

	public void RequestClanWarChampionshipResultMatch()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsClanWarChampionshipEliminatorOpen()
	{
		return false;
	}

	public bool CheckSelfClanWarChampionshipEnablePlay()
	{
		return false;
	}

	public bool CheckMemberClanWarChampionshipEnablePlay()
	{
		return false;
	}

	private bool CheckLevelSatisfy(uint level)
	{
		return false;
	}

	public int GetUnlockLevel()
	{
		return 0;
	}

	public bool CheckIfOut()
	{
		return false;
	}

	public void InitGuildWarTournamentOpenInfo(CSGuildWarBasicInfoRes res)
	{
	}

	public void CheckClanWarChampionshipSlapNeedProto()
	{
	}

	public string GetTournamentAdvanceKey()
	{
		return null;
	}

	public GuildWarTournamentDesc GetChampionshipDescByRoundId(int roundId)
	{
		return null;
	}

	private void RefreshEliminatorRoundResult()
	{
	}

	public void RefreshQualifierResult()
	{
	}

	public void RequestClanWarChampionshipEliminatorInfo(bool force = false)
	{
	}

	public void ResetMatchHistoryCd()
	{
	}

	public void RequestMatchHistory(bool force = false)
	{
	}

	public void RequestPreviousRoundMatchHistory(bool force = false)
	{
	}

	public bool HasParticipatedInPreviousRound()
	{
		return false;
	}

	public List<GuildWarMemberStats> GetMatchHistoryList(int maxNumber)
	{
		return null;
	}

	public int GetRoundSelfScore()
	{
		return 0;
	}

	public string GetLastRoundResultPlayerPrefsKey()
	{
		return null;
	}

	public string GetLimitedEventStartPlayerPrefsKey()
	{
		return null;
	}

	public string GetInClanChampionshipPagePopupPlayerPrefsKey()
	{
		return null;
	}

	public string GetLobbyPopupKey()
	{
		return null;
	}

	public string GetClanInternalPopupKey()
	{
		return null;
	}

	public string GetClanInternalPrewarmupRedPointKey()
	{
		return null;
	}

	public bool IsPromotedToCurrentRound()
	{
		return false;
	}

	public bool CheckLobbyPopupTime()
	{
		return false;
	}

	public bool CheckClanInternalPopupTime()
	{
		return false;
	}

	public bool IsLobbyFirstRound()
	{
		return false;
	}

	public bool IsClanInternalFirstRound()
	{
		return false;
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

	private void IndividualTop3_ProcessMemberInfo(List<TournamentMemberInfo> infos)
	{
	}

	public TournamentMemberInfo IndividualTop3_GetInfoByRank(int rank)
	{
		return null;
	}

	public void RefreshTournamentPrewarmupRedPoint()
	{
	}

	public void RefreshTournamentAdvancedRedPoint()
	{
	}

	public void ResponseUpdateTournamentRedPointForQualifier()
	{
	}

	public void ResponseUpdateTournamentRedPointForEliminator(uint notifyId)
	{
	}

	public void RefreshStage(bool notifyStageChange = true)
	{
	}

	public void OnClanChange(bool joinNew = false)
	{
	}

	public GuildWarPlayerTitleInfo FindTitleByTitleId(uint titleId)
	{
		return null;
	}

	public void ProcessTitles(GuildWarPlayerTitleInfo title)
	{
	}

	public GuildWarTitleInfo GetTopClanWarTitleInfo()
	{
		return null;
	}

	public GuildWarPlayerTitleInfo GetTopClanWarPlayerTitleInfo()
	{
		return null;
	}

	public GuildWarTitleInfo GetEquipClanWarTitleInfo()
	{
		return null;
	}

	public GuildWarTitleInfo GetClanWarTitleInfoByTitleCfgID(uint titleCfgId)
	{
		return null;
	}

	public List<GuildWarPlayerTitleInfo> GetSortedClanTitleInfoList()
	{
		return null;
	}

	private int SortClanTitleInfo(GuildWarPlayerTitleInfo x, GuildWarPlayerTitleInfo y)
	{
		return 0;
	}

	public void RefreshTournamentOpeningTime()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
