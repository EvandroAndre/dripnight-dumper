using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelChampionship : UIBaseModel, OnlineMatch
{
	public enum MemberType
	{
		Normal = 1,
		Captain
	}

	public enum ChampionshipCDNBgType
	{
		Main = 1,
		WarmUp
	}

	public class NotifyArgs
	{
		public bool success;
	}

	public class NotifyArgsRemove : NotifyArgs
	{
		public bool removeSelf;
	}

	public class NotifyArgsJoin : NotifyArgs
	{
		public ulong friendID;

		public bool teamIsFull;
	}

	public class NotifyArgsInvite : NotifyArgs
	{
		public ulong invitee;

		public bool sameRequest;
	}

	public class NotifyArgsQuit : NotifyArgs
	{
		public bool toNewTeam;
	}

	public class NotifyArgsDismiss : NotifyArgs
	{
		public bool toNewTeam;
	}

	public class NotifyArgsStats : NotifyArgs
	{
		public CSTeamChampionshipSeasonStatsRes stats;
	}

	public class NotifyArgsAccountLifeSeasonStats : NotifyArgs
	{
		public List<AccountSeasonStats> statsList;
	}

	public class NotifyArgsTeamMatchStatsHistory : NotifyArgs
	{
		public CSTeamMatchStatsHistoryRes matchStatsHistory;
	}

	public class NotifyArgsTeamInfo : NotifyArgs
	{
		public TeamInfo teamInfo;
	}

	public class NotifyArgsTeamMemberInfo : NotifyArgs
	{
		public TeamMemberListWithAccountInfo teamMemberInfo;

		public bool requestedPresence;
	}

	public class StateViewInfo
	{
		public string stateText;

		public string stateDescText;
	}

	public enum ChampionshipEntranceState
	{
		Closed,
		Paused,
		WarmUp,
		Opened
	}

	public enum ChampionshipOpenState
	{
		UnOpen,
		EntranceOpen,
		SeasonOpen,
		TodayOpen,
		TodayUnOpen,
		Result,
		TrialClose,
		SeasonClose
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ChampionshipScoreRewardDesc> _003C_003E9__118_0;

		public static Predicate<ChampionshipScoreRewardDesc> _003C_003E9__119_0;

		public static Converter<TeamMemberWithAccountInfo, ulong> _003C_003E9__153_0;

		internal bool _003CGetLowestChampionshipRewardDesc_003Eb__118_0(ChampionshipScoreRewardDesc r)
		{
			return false;
		}

		internal bool _003CGetFirstChampionshipRewardDesc_003Eb__119_0(ChampionshipScoreRewardDesc r)
		{
			return false;
		}

		internal ulong _003CRequestTeamMemberPresence_003Eb__153_0(TeamMemberWithAccountInfo e)
		{
			return 0uL;
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public uint type;

		public uint championshipID;

		internal bool _003CGetChampionshipOpenInfo_003Eb__0(ChampionshipOpenInfoDesc basicInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public uint type;

		public uint cpID;

		internal bool _003CGetChampionshipSetting_003Eb__0(ChampionshipSettingDesc basicInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public uint type;

		internal bool _003CGetChampionshipScoreBaseInfoByType_003Eb__0(ChampionshipScoreBaseDesc basicInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public uint realPos;

		internal bool _003CGetChampionshipRewardListByPos_003Eb__0(ChampionshipScoreRewardDesc r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public uint realPos;

		internal bool _003CGetChampionshipRewardIndexByPos_003Eb__0(ChampionshipScoreRewardDesc r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public uint realPos;

		internal bool _003CGetRankPosRange_003Eb__0(ChampionshipScoreRewardDesc desc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong friendID;

		internal void _003CRequestJoinTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public ulong teamID;

		public UIModelChampionship _003C_003E4__this;

		public bool requestTeamApplication;

		internal void _003CRequestTeamInfoByTeamID_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass140_0
	{
		public TeamIDReq req;

		public UIModelChampionship _003C_003E4__this;

		public bool requestTeamMemberPresence;

		public bool forcePresence;

		internal void _003CRequestTeamMembers_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass141_0
	{
		public ulong teamID;

		public UIModelChampionship _003C_003E4__this;

		internal void _003CRequestTeamMatchStatsHistory_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public UIModelChampionship _003C_003E4__this;

		public bool toNewTeam;

		public bool requestApproveJoinTeamInvitation;

		public ulong inviter;

		public ulong inviterTeam;

		internal void _003CRequestQuitTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass143_0
	{
		public UIModelChampionship _003C_003E4__this;

		public bool toNewTeam;

		public bool requestApproveJoinTeamInvitation;

		public ulong inviter;

		public ulong inviterTeam;

		internal void _003CRequestDismissTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public UIModelChampionship _003C_003E4__this;

		public CSApproveJoinApplicationReq req;

		public AccountInfoBasic basicInfo;

		internal void _003CRequestApproveApplication_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong[] applicantIDs;

		public Predicate<AccountInfoBasic> _003C_003E9__1;

		internal void _003CRequestDeclineApplication_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestDeclineApplication_003Eb__1(AccountInfoBasic e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong inviteeID;

		internal void _003CRequestInvite_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong inviterTeam;

		public ulong inviter;

		public Predicate<AccountInfoBasic> _003C_003E9__1;

		public Predicate<AccountInfoBasic> _003C_003E9__2;

		internal void _003CRequestApproveJoinTeamInvitation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestApproveJoinTeamInvitation_003Eb__1(AccountInfoBasic e)
		{
			return false;
		}

		internal bool _003CRequestApproveJoinTeamInvitation_003Eb__2(AccountInfoBasic e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass152_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong[] inviterIDs;

		public Predicate<AccountInfoBasic> _003C_003E9__1;

		internal void _003CRequestDeclineJoinTeamInvitation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestDeclineJoinTeamInvitation_003Eb__1(AccountInfoBasic e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_0
	{
		public UIModelChampionship _003C_003E4__this;

		public ulong removeeID;

		internal void _003CRequestRemoveTeamMember_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass155_0
	{
		public UIModelChampionship _003C_003E4__this;

		public uint championshipType;

		internal void _003CRequestGetTeamChampionshipInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public UIModelChampionship _003C_003E4__this;

		public uint championshipType;

		public uint championshipID;

		internal void _003CRequestChampionshipConfig_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public bool sortPresence;

		public UIModelChampionship _003C_003E4__this;

		public TeamInfo teamInfo;

		internal int _003CSortTeamMember_003Eb__0(TeamMemberWithAccountInfo e, TeamMemberWithAccountInfo o)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public uint championshipType;

		public uint championshipID;

		public uint nameType;

		public string language;

		internal bool _003CGetChampionshipNameoverwriteDesc_003Eb__0(ChampionshipNameOverwriteDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass183_0
	{
		public uint championshipType;

		public uint championshipID;

		public string language;

		internal bool _003CGetChampionshipTrialMatchName_003Eb__0(ChampionshipNameOverwriteDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass184_0
	{
		public uint championshipType;

		public uint championshipID;

		public string language;

		internal bool _003CGetChampionshipModeName_003Eb__0(ChampionshipNameOverwriteDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public uint championshipType;

		public uint championshipID;

		public string language;

		internal bool _003CGetChampionshipSeasonNameWithIDOverwrite_003Eb__0(ChampionshipNameOverwriteDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public GroupMemberInfo member;

		internal bool _003CHasUnTeamMemberPlayerInGroup_003Eb__0(TeamMemberWithAccountInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public ChampionshipSettingDesc cpSetting;

		internal bool _003CTeamSetting_003Eb__0(ChampionshipTeamDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public ulong selfAccountID;

		internal bool _003CSelfTeamMembers_003Eb__0(TeamMemberWithAccountInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public ulong teamID;

		internal bool _003CGetTeamRank_003Eb__0(LeaderBoardInfo e)
		{
			return false;
		}
	}

	private TeamInfo m_SelfTeamInfo;

	private TeamMemberListWithAccountInfo m_SelfTeamMemberInfo;

	private ulong m_SelfTeamMatchStatsHistoryRequestTime;

	private CSTeamMatchStatsHistoryRes m_SelfTeamMatchStatsHistoryRes;

	private Dictionary<ulong, PresenceInfo> m_MemberPresenceCache;

	private Dictionary<uint, proto.ChampionshipInfo> m_ChampionshipInfoCache;

	private Dictionary<uint, List<ChampionshipScoreRewardDesc>> m_ChampionshipRewardInfoCache;

	private List<AccountInfoBasic> m_TeamApplicantList;

	private List<AccountInfoBasic> m_TeamInvitationList;

	private List<ulong> m_TeamInvitedIdList;

	private CSChampionshipBasicInfoRes m_ChampionshipBasicInfoRes;

	private ulong m_SelfTeamID;

	private const string m_PrefTeamInfoEditCD = "CSTeamInfoEditCD";

	private ulong m_TeamInfoEditCoolDownTime;

	private Dictionary<uint, uint> m_CurrentChampionshipID;

	private Dictionary<uint, uint> m_TicketCntDict;

	private Dictionary<uint, uint> m_GamesPlayedDict;

	private List<int> m_requestQueue;

	public const uint PropID_CreateTeam = 2u;

	public const uint PropID_TeamInfoUpdate = 4u;

	public const uint PropID_TeamMembersUpdate = 8u;

	public const uint PropID_QuitTeam = 16u;

	public const uint PropID_TeamApplicantsUpdate = 32u;

	public const uint PropID_DismissTeam = 64u;

	public const uint PropID_DismissTeamNotify = 128u;

	public const uint PropID_RemoveNotify = 256u;

	public const uint PropID_Invite = 512u;

	public const uint PropID_TeamInvitationUpdate = 1024u;

	public const uint PropID_ApproveTeamInvitation = 2048u;

	public const uint PropID_JoinTeam = 4096u;

	public const uint PropID_EditContact = 8192u;

	public const uint PropID_MemberPresenceUpdate = 16384u;

	public const uint PropID_ConfirmAddNotify = 32768u;

	public const uint PropID_ChampionshipInfoUpdate = 65536u;

	public const uint PropID_ChampionshipConfigInfoUpdate = 131072u;

	public const uint PropID_ModifyTeamInfo = 262144u;

	public const uint PropID_ChampionshipGameStatsUpdate = 524288u;

	public const uint PropID_AccountListSeasonStats = 1048576u;

	public const uint PropID_TeamMatchStatsHistoryNotify = 2097152u;

	public const uint PropID_TeamIDChange = 4194304u;

	public const uint PropID_GetInvitedIdListUpdate = 8388608u;

	public const uint PARTICIPATIONFLAG = 100000000u;

	public const string NEWSEASONANIM = "CSNewSeasonAnim,Type{0},Season{1}";

	public const string TEAMCLICKLOG = "TeamClickLog,Type{0},Season{1}";

	public const string ENTRANCECLICKLOG = "EntranceClickLog,Type{0},Season{1}";

	public const string NEWSEASONANOTICE = "CSNewSeasonNotice,Type{0},Season{1}";

	public Dictionary<uint, bool> m_ChampionshipMatchEnd;

	private ChampionshipEntranceState m_HighestPriorityState;

	private uint m_HighestPriorityType;

	private bool m_EntranceStateChecked;

	public bool championshipInfoReady;

	public bool teamInfoReady;

	public bool mapInfoReady;

	private bool _003CTeamMemberInitialized_003Ek__BackingField;

	private readonly Dictionary<int, StateViewInfo> m_StateViewInfoDict;

	private bool m_IsInBlackList;

	private const uint NameOverwriteType_TrialMatchName = 1u;

	private const uint NameOverwriteType_ModeName = 2u;

	private const uint NameOverwriteType_SeasonName = 3u;

	private const uint NameOverwriteType_TimeContent = 4u;

	public bool TeamMemberInitialized
	{
		get
		{
			return _003CTeamMemberInitialized_003Ek__BackingField;
		}
		set
		{
			_003CTeamMemberInitialized_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool SelfHasTeam()
	{
		return false;
	}

	public TeamInfo SelfTeamInfo()
	{
		return null;
	}

	public ulong SelfTeamID()
	{
		return 0uL;
	}

	public bool SelfIsCaptain()
	{
		return false;
	}

	public uint PlayerNumberLimit(uint cptype)
	{
		return 0u;
	}

	public uint PlayerNumberLowerLimit(uint cptype)
	{
		return 0u;
	}

	private uint PlayerNumberLimit(uint cptype, uint cpid)
	{
		return 0u;
	}

	private uint PlayerNumberLowerLimit(uint cptype, uint cpid)
	{
		return 0u;
	}

	public ChampionshipTeamDesc TeamSetting(uint cptype)
	{
		return null;
	}

	public ChampionshipTeamDesc TeamSetting(uint cptype, uint cpid)
	{
		return null;
	}

	public uint GetLevelLowerLimit()
	{
		return 0u;
	}

	public uint GetLevelUpperLimit()
	{
		return 0u;
	}

	public uint GetLadderScoreLowerLimit()
	{
		return 0u;
	}

	public uint GetLadderScoreUpperLimit()
	{
		return 0u;
	}

	public List<TeamMemberWithAccountInfo> SelfTeamMembers(bool includeSelf = true)
	{
		return null;
	}

	public bool IsFriendInTeam(FriendAccountInfo friendInfo)
	{
		return false;
	}

	public List<TeamMemberWithAccountInfo> SelfTeamOnlineMembers(bool includeSelf = true)
	{
		return null;
	}

	public proto.EPresence.AccountPresence TeamMemberPresence(ulong id)
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	public proto.EPresence.SocialPresence TeamMemberSocialPresence(ulong id)
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	public ulong TeamMemberGroupID(ulong id)
	{
		return 0uL;
	}

	public string TeamMemberPresenceString(ulong id)
	{
		return null;
	}

	public List<AccountInfoBasic> TeamApplicants()
	{
		return null;
	}

	public List<AccountInfoBasic> TeamInvitations()
	{
		return null;
	}

	public uint GetTeamRank(uint cpType, ulong teamID, out string formatRank)
	{
		formatRank = null;
		return 0u;
	}

	public bool CheckJoinCreateTimeSatisfy(out string error)
	{
		error = null;
		return false;
	}

	public bool CheckLevelSatisfy()
	{
		return false;
	}

	public bool CheckLadderScoreSatisfy()
	{
		return false;
	}

	public proto.ChampionshipInfo GetChampionshipInfoByType(uint type)
	{
		return null;
	}

	public ChampionshipOpenInfoDesc GetChampionshipOpenInfo(uint type, uint championshipID)
	{
		return null;
	}

	public uint[] GetChampionshipMaps(uint type)
	{
		return null;
	}

	public bool IsInBlackList()
	{
		return false;
	}

	public void SetIsInBlackList(bool isInBlackList)
	{
	}

	public uint GetCurMembersNum()
	{
		return 0u;
	}

	public uint GetTeamScale(uint cpType)
	{
		return 0u;
	}

	public proto.EChampionship.TeamScaleType GetTeamScaleType(uint cpType)
	{
		return proto.EChampionship.TeamScaleType.TeamScaleType_NONE;
	}

	public ChampionshipSettingDesc GetChampionshipSetting(uint type, uint championshipID = 0u)
	{
		return null;
	}

	public ChampionshipScoreBaseDesc GetChampionshipScoreBaseInfoByType(uint type)
	{
		return null;
	}

	public uint GetCurrentChampionshipIDByType(uint type)
	{
		return 0u;
	}

	public float GetChampionshipExtraBonusByType(uint type, uint bonusType)
	{
		return 0f;
	}

	public List<AwardDesc> GetChampionshipRewardListByPos(uint championshipType, uint championshipId, int pos)
	{
		return null;
	}

	public int GetChampionshipRewardIndexByPos(uint championshipType, uint championshipId, int pos)
	{
		return 0;
	}

	public ChampionshipScoreRewardDesc GetLowestChampionshipRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	public ChampionshipScoreRewardDesc GetFirstChampionshipRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	public List<ChampionshipScoreRewardDesc> GetChampionshipAllRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	private uint GenerateAwardsListKey(uint championshipType, uint championshipID)
	{
		return 0u;
	}

	public string GetRankPosRange(uint championshipType, uint championshipId, int pos)
	{
		return null;
	}

	public StateViewInfo GetStateViewInfo(ChampionshipOpenState curState)
	{
		return null;
	}

	public uint FixRankPos(uint championshipType, uint championshipID, int rank)
	{
		return 0u;
	}

	public void UpdateTeamInfoEditCD()
	{
	}

	public ulong TeamInfoEditCD()
	{
		return 0uL;
	}

	public bool ChampionshipIsOpen(uint type, uint championshipID)
	{
		return false;
	}

	public bool ChampionshipIsSeniorTeamOnly(uint type, uint championshipID)
	{
		return false;
	}

	public void SoloConfirm(bool isBlock = false)
	{
	}

	public void ProcessChampionshipInfo(CSChampionshipBasicInfoRes championshipInfoRes)
	{
	}

	private void PreDownload()
	{
	}

	private void InitCurrentChampionshipID(List<ChampionshipOpenInfoDesc> openInfoList)
	{
	}

	private void ProcessChampionshipRewardInfo(List<ChampionshipScoreRewardDesc> rewardsDescList)
	{
	}

	public void RequestCreateTeam(string name, string contactInfo, string countryOrArea, uint clanAvatar, uint clanBanner, proto.EChampionship.TeamScaleType scaleType, uint http_option = 0u)
	{
	}

	public void RequestJoinTeam(ulong friendID, ulong teamID)
	{
	}

	public void RequestModifyTeamInfo(string teamName, string countryOrArea, uint clanAvatar, uint clanBanner)
	{
	}

	public void RequestEditTeamContactInfo(string contact)
	{
	}

	public void RequestTeamInfoByTeamID(ulong teamID, bool requestTeamApplication = false)
	{
	}

	public void RequestSelfTeamMembers()
	{
	}

	public void RequestTeamMembers(ulong teamID, bool requestTeamMemberPresence = false, bool forcePresence = false)
	{
	}

	public void RequestTeamMatchStatsHistory(ulong teamID)
	{
	}

	public void RequestQuitTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	public void RequestDismissTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	public void RequestTeamApplicantList()
	{
	}

	public void RequestInvitationList()
	{
	}

	public void RequestInvitedIdList()
	{
	}

	public bool IsInvitedAccount(FriendAccountInfo accountInfo)
	{
		return false;
	}

	public void RequestApproveApplication(AccountInfoBasic basicInfo)
	{
	}

	public void RequestDeclineApplication(ulong[] applicantIDs)
	{
	}

	public void RequestInvite(ulong inviteeID)
	{
	}

	public void RequestApproveJoinTeamInvitation(ulong inviter, ulong inviterTeam)
	{
	}

	public void RequestDeclineJoinTeamInvitation(ulong[] inviterIDs)
	{
	}

	public void RequestTeamMemberPresence(bool force = false)
	{
	}

	public void RequestRemoveTeamMember(ulong removeeID)
	{
	}

	public void RequestGetTeamChampionshipInfo(uint championshipID, uint championshipType)
	{
	}

	public void RequestInitTeamChampionshipInfo(uint championshipType, uint httpOption = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestChampionshipConfig(uint championshipID, uint championshipType = 1u, uint httpOption = 0u)
	{
	}

	public void RequestChampionshipStatsInfo(ulong teamID, uint championshipType, uint championshipID, bool needTeamMembersInfo = false)
	{
	}

	public void RequestAccountLifeSeasonStats(ulong accountID, uint championshipType)
	{
	}

	public void OnJoinApplicantNotify()
	{
	}

	public void OnConfrimAddNotify(ConfirmAddChampionshipTeamReq ntf)
	{
	}

	public void OnDismissNotify(ulong teamID)
	{
	}

	public void OnRemoveNotify(ulong teamID, ulong removeeID)
	{
	}

	public void OnInviteNotify()
	{
	}

	public void OnApproveInviteNotify()
	{
	}

	public void OnTeamMemeberPresenceNotify(PresenceListRes presenceData)
	{
	}

	private void UpdateTeamID(ulong teamID)
	{
	}

	public void UpdateTicketsNum()
	{
	}

	public void SortTeamMember(List<TeamMemberWithAccountInfo> members, bool sortPresence, TeamInfo teamInfo)
	{
	}

	public ChampionshipNameOverwriteDesc GetChampionshipNameoverwriteDesc(uint championshipType, uint championshipID = 0u, uint nameType = 0u)
	{
		return null;
	}

	public string GetSeasonStartEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo, bool showYear = true)
	{
		return null;
	}

	public string GetSeasonEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return null;
	}

	public uint GetChampionshipID(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return 0u;
	}

	public int GetRankPos(uint championshipType)
	{
		return 0;
	}

	public int GetPropIDByChampionshipType(uint championshipType)
	{
		return 0;
	}

	public uint GetValidScore(proto.ChampionshipInfo championshipInfo)
	{
		return 0u;
	}

	public uint GetTotalScore(proto.ChampionshipInfo championshipInfo)
	{
		return 0u;
	}

	public uint GetMatchTotalNum(ChampionshipSettingDesc championshipSettingInfo)
	{
		return 0u;
	}

	public string GetChampionshipTrialMatchName(uint championshipType, uint championshipID = 0u, string originNameKey = "")
	{
		return null;
	}

	public string GetChampionshipModeName(uint championshipType, uint championshipID)
	{
		return null;
	}

	public string GetChampionshipSeasonNameWithIDOverwrite(uint championshipType, uint championshipID)
	{
		return null;
	}

	private void SetTicketsNum(uint type, uint ticketInfoCnt)
	{
	}

	private void SetPlayedTimes(uint type, uint playedNum)
	{
	}

	public uint GetTicketsNum(uint type)
	{
		return 0u;
	}

	public uint GetPlayedTimes(uint type)
	{
		return 0u;
	}

	public void AddPlayedTimes(uint type, uint num = 1u)
	{
	}

	public void DeductTicket(uint type, uint cnt = 1u)
	{
	}

	public bool HasUnTeamMemberPlayerInGroup(List<GroupMemberInfo> members)
	{
		return false;
	}

	public List<uint> GetOpenChampionshipTypeList()
	{
		return null;
	}

	public ChampionshipOpenState GetChampionshipOpenState(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return ChampionshipOpenState.UnOpen;
	}

	public ulong GetMapCloseTime(uint championshipType)
	{
		return 0uL;
	}

	public ulong GetNextOpenTime(ChampionshipOpenInfoDesc championshipOpenInfo, ChampionshipOpenState championshipState)
	{
		return 0uL;
	}

	private void SetTipsIfDifferentOpenDay(MapOpeningInfo mapInfo)
	{
	}

	public bool IsTrialStart(ChampionshipOpenState state)
	{
		return false;
	}

	public bool IsFFCCUP(uint cptype)
	{
		return false;
	}

	public uint GetCurrentOpenChampionshipType()
	{
		return 0u;
	}

	public uint GetLastChampionshipType()
	{
		return 0u;
	}

	public uint GetLastThirdPartyChampionshipType()
	{
		return 0u;
	}

	public uint GetLastFFCCupChampionshipType()
	{
		return 0u;
	}

	public bool AllProtocalReady()
	{
		return false;
	}

	public bool CanShowEntranceCountDown()
	{
		return false;
	}

	public DateTime MatchStartTime()
	{
		return default(DateTime);
	}

	public ulong GetCountDownTime()
	{
		return 0uL;
	}

	public int LobbyEntrancePriority()
	{
		return 0;
	}

	public bool IsLeaderBoardOpen(uint cpType, uint cpID)
	{
		return false;
	}

	private bool IsLeaderBoardOpenPublic(uint cpType, uint cpID)
	{
		return false;
	}

	public bool HasPlayedOneGame()
	{
		return false;
	}

	public bool IsReplayEnabled()
	{
		return false;
	}

	public bool IsDisableWeaponSkin()
	{
		return false;
	}

	public bool SetEntranceBtnState()
	{
		return false;
	}

	public OnlineMatchEntranceState GetEntranceBtnState()
	{
		return OnlineMatchEntranceState.Closed;
	}

	public void SetEntranceWarmUpState()
	{
	}

	public uint GetHightestPriorityMatchType()
	{
		return 0u;
	}

	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	public void SetTeamInfoFlag()
	{
	}

	public void SetChampionshipInfoFlag()
	{
	}

	public void SetMapInfoFlag()
	{
	}

	public uint GetRewardPercent(uint bound)
	{
		return 0u;
	}

	public List<AdvertDesc> GetEntranceCdnDesc()
	{
		return null;
	}

	private bool _003CSelfTeamOnlineMembers_003Eb__92_0(TeamMemberWithAccountInfo member)
	{
		return false;
	}

	private void _003CRequestCreateTeam_003Eb__134_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestModifyTeamInfo_003Eb__136_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestEditTeamContactInfo_003Eb__137_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestTeamApplicantList_003Eb__144_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestInvitationList_003Eb__145_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestInvitedIdList_003Eb__146_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestInitTeamChampionshipInfo_003Eb__156_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestChampionshipStatsInfo_003Eb__158_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAccountLifeSeasonStats_003Eb__159_0(HttpErrorCode errorCode, object res)
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
