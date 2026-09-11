using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelCupMatch : UIBaseModel, OnlineMatch
{
	public enum MemberType
	{
		Normal = 1,
		Captain
	}

	public enum CupMatchCDNBgType
	{
		Cup01 = 1,
		Cup02,
		Cup03,
		Cup05,
		Cup06
	}

	public class NotifyArgs
	{
		public bool success;

		public int key;

		public bool needCheckKey;
	}

	public class NotifyArgsRemove : NotifyArgs
	{
		public bool removeSelf;
	}

	public class NotifyArgsJoin : NotifyArgs
	{
		public ulong friendID;

		public bool teamIsFull;

		public bool sameTeamRequest;
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

	public class NotifyArgsTeamInfo : NotifyArgs
	{
		public CupTeamInfo teamInfo;
	}

	public class NotifyArgsTeamMemberInfo : NotifyArgs
	{
		public List<AccountInfoBasicWithCupInfo> teamMemberInfo;

		public bool requestedPresence;
	}

	public class NotifyArgsAccountCupInfoBundle : NotifyArgs
	{
		public bool isSearch;
	}

	public class StateViewInfo
	{
		public string stateText;

		public string stateDescText;
	}

	public enum CupMatchOpenState
	{
		UnOpen,
		EntranceOpen,
		SeasonOpen,
		TodayOpen,
		TodayUnOpen,
		Result,
		MatchClose,
		SeasonClose
	}

	public enum CupMatchResult
	{
		Win,
		Lose,
		UnKnow
	}

	public enum CupMatchEntranceState
	{
		Closed,
		Paused,
		WarmUp,
		Opened
	}

	public class AccountInfoBasicWithCupInfo
	{
		public AccountInfoBasic AccountInfoBasic;

		public uint Tier;

		public ulong TeamID;

		public bool UseTicket;

		public uint MemberType;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AccountInfoBasicWithCupInfo, ulong> _003C_003E9__245_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__248_1;

		public static Predicate<AccountInfoBasicWithCupInfo> _003C_003E9__250_1;

		public static Converter<AccountInfoBasicWithCupInfo, ulong> _003C_003E9__251_0;

		internal ulong _003CRequestTeamMemberPresence_003Eb__245_0(AccountInfoBasicWithCupInfo e)
		{
			return 0uL;
		}

		internal CommonRewardItemInfo _003CRequestClaimCupReward_003Eb__248_1(BaseItemInfo item)
		{
			return null;
		}

		internal bool _003CRequestUseTicket_003Eb__250_1(AccountInfoBasicWithCupInfo a)
		{
			return false;
		}

		internal ulong _003CRequestVerifyAndLockCupTeam_003Eb__251_0(AccountInfoBasicWithCupInfo e)
		{
			return 0uL;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public uint tier;

		public bool isTicket;

		internal bool _003CGetCupChestList_003Eb__0(CupChestDesc c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public int wins;

		internal bool _003CGetCupMatchRewardDescByWins_003Eb__0(CupChestDesc r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass177_0
	{
		public ulong selfAccountID;

		internal bool _003CGetSelfTeamMembers_003Eb__0(AccountInfoBasicWithCupInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public CupTeamInfo teamInfo;

		public bool sortPresence;

		public UIModelCupMatch _003C_003E4__this;

		internal int _003CSortTeamMember_003Eb__0(AccountInfoBasicWithCupInfo e, AccountInfoBasicWithCupInfo o)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public GroupMemberInfo member;

		internal bool _003CHasNonTeamMemberPlayerInGroup_003Eb__0(AccountInfoBasicWithCupInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass227_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		internal void _003CRequestCreateTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass228_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public ulong friendID;

		public int key;

		public ulong teamID;

		internal void _003CRequestJoinTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass230_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		internal void _003CRequestModifyTeamInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass231_0
	{
		public ulong teamID;

		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public bool requestTeamApplication;

		internal void _003CRequestTeamInfoByTeamID_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass233_0
	{
		public ulong teamID;

		public CSCupTeamIDReq req;

		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public bool requestTeamMemberPresence;

		public bool forcePresence;

		internal void _003CRequestTeamMembers_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public bool toNewTeam;

		public bool requestApproveJoinTeamInvitation;

		public ulong inviter;

		public ulong inviterTeam;

		internal void _003CRequestQuitTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public bool toNewTeam;

		public bool requestApproveJoinTeamInvitation;

		public ulong inviter;

		public ulong inviterTeam;

		internal void _003CRequestDismissTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass236_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		internal void _003CRequestTeamApplicantList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass236_1
	{
		public AccountInfoBasicWithCupInfo info;

		internal bool _003CRequestTeamApplicantList_003Eb__1(CupTeamApplicantRes member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public uint type;

		public uint id;

		internal void _003CRequestInvitationList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_1
	{
		public AccountInfoBasicWithCupInfo info;

		internal bool _003CRequestInvitationList_003Eb__1(CupTeamInvitationRes member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass238_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		internal void _003CRequestInvitedIdList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public ulong teamID;

		public CSApproveJoinCupTeamApplicationReq req;

		internal void _003CRequestApproveApplication_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public CSApproveJoinCupTeamApplicationReq req;

		public AccountInfoBasicWithCupInfo basicInfoWithCupTier;

		internal void _003CRequestApproveApplication_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass241_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public ulong[] applicantIDs;

		public Predicate<AccountInfoBasicWithCupInfo> _003C_003E9__1;

		internal void _003CRequestDeclineApplication_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestDeclineApplication_003Eb__1(AccountInfoBasicWithCupInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public ulong inviteeID;

		public int key;

		internal void _003CRequestInvite_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public ulong inviterTeam;

		public ulong inviter;

		public Predicate<AccountInfoBasicWithCupInfo> _003C_003E9__1;

		public Predicate<AccountInfoBasicWithCupInfo> _003C_003E9__2;

		internal void _003CRequestApproveJoinTeamInvitation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestApproveJoinTeamInvitation_003Eb__1(AccountInfoBasicWithCupInfo e)
		{
			return false;
		}

		internal bool _003CRequestApproveJoinTeamInvitation_003Eb__2(AccountInfoBasicWithCupInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public ulong[] inviterIDs;

		public Predicate<AccountInfoBasicWithCupInfo> _003C_003E9__1;

		internal void _003CRequestDeclineJoinTeamInvitation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestDeclineJoinTeamInvitation_003Eb__1(AccountInfoBasicWithCupInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass246_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		public ulong removeeID;

		internal void _003CRequestRemoveTeamMember_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public uint type;

		public uint id;

		public UIModelCupMatch _003C_003E4__this;

		public bool isSearch;

		internal void _003CRequestAccountCupInfoBundleByAccountIDsOrderly_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public uint type;

		public uint id;

		public UIModelCupMatch _003C_003E4__this;

		internal void _003CRequestClaimCupReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public uint type;

		public uint id;

		public UIModelCupMatch _003C_003E4__this;

		internal void _003CRequestUseTicket_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass251_0
	{
		public UIModelCupMatch _003C_003E4__this;

		public int key;

		internal void _003CRequestVerifyAndLockCupTeam_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private const uint NameOverwriteType_TrialMatchName = 1u;

	private const uint NameOverwriteType_ModeName = 2u;

	private const uint NameOverwriteType_SeasonName = 3u;

	private const uint NameOverwriteType_TimeContent = 4u;

	private readonly Dictionary<int, StateViewInfo> m_StateViewInfoDict;

	private Dictionary<int, CupTeamInfo> m_SelfTeamInfoDict;

	private Dictionary<int, ulong> m_SelfTeamIDDict;

	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_SelfTeamMemberInfoDict;

	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_TeamApplicantDict;

	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_TeamInvitationDict;

	private Dictionary<int, CSAccountCupInfoRes> m_SelfCupInfoDict;

	private Dictionary<int, List<ulong>> m_TeamInvitedIdDict;

	private Dictionary<ulong, Dictionary<ulong, PresenceInfo>> m_MemberPresenceCache;

	private Dictionary<int, ulong> m_TeamInfoEditCoolDownTimeDict;

	private Dictionary<int, CSGetCupConfigRes> m_CupConfigDict;

	private Dictionary<uint, CupRuleDesc> m_CupRuleDict;

	private CupTeamDesc m_CupTeamDesc;

	private Dictionary<int, List<ulong>> m_RequestedJoinTeamIDDict;

	private Dictionary<int, List<CSAccountCupInfoRes>> m_CacheAccountCupInfo;

	private List<int> m_requestQueue;

	private const string m_PrefTeamInfoEditCD = "CupMatchTeamInfoEditCD";

	public const string NEWSEASONANOTICE = "CupMatchNewSeasonNotice";

	private bool _003CTeamMemberInitialized_003Ek__BackingField;

	private float m_LastRequestUseTicketTime;

	private bool m_IsMatchResultNotified;

	private const string CUPMATCHKEY = "CupMatchKey_{0}_{1}";

	private bool m_IsInvalidMatch;

	public bool MatchRecordUpdate;

	public uint OppoTeamIcon;

	public string OppoTeamName;

	private bool m_NeedRequestApplicationList;

	private bool m_NeedRequestInvitationList;

	private ulong _003CApplicationListRequestCDEndTime_003Ek__BackingField;

	private ulong _003CInvitationListRequestCDEndTime_003Ek__BackingField;

	private ulong _003CFriendCupTeamInfoRequestCDEndTime_003Ek__BackingField;

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

	public const uint PropID_MemberPresenceUpdate = 8192u;

	public const uint PropID_ConfirmAddNotify = 16384u;

	public const uint PropID_ModifyTeamInfo = 32768u;

	public const uint PropID_TeamIDChange = 65536u;

	public const uint PropID_GetInvitedIdListUpdate = 131072u;

	public const uint PropID_UseCupTicket = 262144u;

	public const uint PropID_AccountCupInfoBundleNotify = 524288u;

	public const uint PropID_ClaimReward = 1048576u;

	public const uint PropID_TeamTabRedTipsUpdate = 2097152u;

	public const uint PropID_TeamApplicationRedTipsUpdate = 4194304u;

	public const uint PropID_TeamInvitationRedTipsUpdate = 8388608u;

	public const uint PropID_NoTeamRedTipsUpdate = 16777216u;

	public const uint PropID_ClaimRewardTipsUpdate = 33554432u;

	public const uint PropID_TeamLockNotify = 67108864u;

	public const uint PropID_FirstTimeEnterCupUINotify = 134217728u;

	private CupMatchEntranceState m_HighestPriorityState;

	private int m_HighestPriorityKey;

	private bool m_EntranceStateChecked;

	public bool cupMatchInfoReady;

	public bool teamInfoReady;

	public bool mapInfoReady;

	private Dictionary<int, int> m_CupMatchEntranceTrailOpenTipsDict;

	private Dictionary<int, int> m_CupMatchTeamApplicationTipsDict;

	private Dictionary<int, int> m_CupMatchTeamInvitationTipsDict;

	private Dictionary<int, int> m_CupMatchTeamTabTipsDict;

	private Dictionary<int, int> m_CupMatchNoTeamTipsDict;

	private Dictionary<int, int> m_CupMatchTeamNotFullTipsDict;

	private Dictionary<int, int> m_CupMatchClaimRewardTipsDict;

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

	public bool IsMatchResultNotified
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsInvalidMatch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedRequestApplicationList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedRequestInvitationList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong ApplicationListRequestCDEndTime
	{
		get
		{
			return _003CApplicationListRequestCDEndTime_003Ek__BackingField;
		}
		set
		{
			_003CApplicationListRequestCDEndTime_003Ek__BackingField = value;
		}
	}

	public ulong InvitationListRequestCDEndTime
	{
		get
		{
			return _003CInvitationListRequestCDEndTime_003Ek__BackingField;
		}
		set
		{
			_003CInvitationListRequestCDEndTime_003Ek__BackingField = value;
		}
	}

	public ulong FriendCupTeamInfoRequestCDEndTime
	{
		get
		{
			return _003CFriendCupTeamInfoRequestCDEndTime_003Ek__BackingField;
		}
		set
		{
			_003CFriendCupTeamInfoRequestCDEndTime_003Ek__BackingField = value;
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

	public void OnStartMatch()
	{
	}

	public uint GetLevelLowerLimit(int key)
	{
		return 0u;
	}

	public uint GetLevelUpperLimit(int key)
	{
		return 0u;
	}

	public uint GetLadderScoreLowerLimit(int key)
	{
		return 0u;
	}

	public uint GetLadderScoreUpperLimit(int key)
	{
		return 0u;
	}

	public bool CheckJoinCreateTimeSatisfy(int key, out string error)
	{
		error = null;
		return false;
	}

	public bool CheckLevelSatisfy(int key)
	{
		return false;
	}

	public bool CheckLadderScoreSatisfy(int key)
	{
		return false;
	}

	public CupOpenInfoDesc GetCupMatchOpenInfo(int key)
	{
		return null;
	}

	public CupRuleDesc GetCupRuleInfo(int key)
	{
		return null;
	}

	public uint GetMaxTier(int key)
	{
		return 0u;
	}

	public bool HasBlockCupMatch()
	{
		return false;
	}

	public bool IsInBlackList(int key)
	{
		return false;
	}

	public CupSettingDesc GetCupMatchSetting(int key)
	{
		return null;
	}

	public CupCDNSettingDesc GetCupCDNSetting(int key)
	{
		return null;
	}

	public CupNameOverwriteDesc GetCupNameOverwriteDesc(int key, uint nameType)
	{
		return null;
	}

	public List<CupChestDesc> GetCupChestList(int key, uint tier, bool isTicket)
	{
		return null;
	}

	public CSGetCupConfigRes GetCupConfig(int key)
	{
		return null;
	}

	public CupChestDesc GetFirstCupMatchRewardDesc(int key, uint tier, bool ticket)
	{
		return null;
	}

	public CupChestDesc GetCupMatchRewardDescByWins(int key, uint tier, bool ticket, int wins)
	{
		return null;
	}

	public CupChestDesc GetCupMatchRewardDescByBattleRecord(int key, uint tier, bool ticket)
	{
		return null;
	}

	public uint GetTeamScale(int key)
	{
		return 0u;
	}

	public void SetPrefsCupKey(int key, bool value)
	{
	}

	public bool IsNotYetEnterredCupMatchExist()
	{
		return false;
	}

	public bool GetPrefsCupKey(int key)
	{
		return false;
	}

	public bool IsFirstReward(CupChestDesc cupChest)
	{
		return false;
	}

	public int GetCupMatchWinsBeforeLose(int key)
	{
		return 0;
	}

	public int GetCupMatchWins(int key)
	{
		return 0;
	}

	public uint GetMatchTotalNum()
	{
		return 0u;
	}

	public string GetCupMatchName(int key, string originNameKey = "")
	{
		return null;
	}

	public string GetCupMatchModeName(int key)
	{
		return null;
	}

	public string GetCupMatchSeasonNameWithIDOverwrite(int key)
	{
		return null;
	}

	public bool IsDisableWeaponSkin(int key)
	{
		return false;
	}

	public StateViewInfo GetStateViewInfo(CupMatchOpenState curState)
	{
		return null;
	}

	public uint PlayerNumberLimit(int key)
	{
		return 0u;
	}

	public bool CupMatchIsOpen(int key)
	{
		return false;
	}

	public CupMatchOpenState GetCupMatchOpenState(CupOpenInfoDesc cupOpenInfo)
	{
		return CupMatchOpenState.UnOpen;
	}

	public ulong GetMapCloseTime(int key)
	{
		return 0uL;
	}

	public ulong GetNextOpenTime(CupOpenInfoDesc cupOpenInfo, CupMatchOpenState cupMatchState)
	{
		return 0uL;
	}

	private void SetTipsIfDifferentOpenDay(int key, MapOpeningInfo mapInfo)
	{
	}

	public bool CupMatchCanUseTicket(int key)
	{
		return false;
	}

	public uint GetCupMatchIDByType(uint type)
	{
		return 0u;
	}

	public string GetSeasonStartEndTimeString(CupOpenInfoDesc cupOpenInfo, bool showYear = true)
	{
		return null;
	}

	public List<int> GetOpenCupMatchList()
	{
		return null;
	}

	public string GetCupMatchPhaseStringByWins(int key)
	{
		return null;
	}

	public string GetCupMatchPhaseString(int key)
	{
		return null;
	}

	public string GetCupMatchChallengePhaseString(int key)
	{
		return null;
	}

	public bool HasLoseMatch(int key)
	{
		return false;
	}

	public bool HasClaimedReward(int key)
	{
		return false;
	}

	public bool CanClaimReward(int key)
	{
		return false;
	}

	public bool IsInCanJoinTeamTime(int key)
	{
		return false;
	}

	public bool SelfHasTeam(int key)
	{
		return false;
	}

	public CupTeamInfo GetSelfTeamInfo(int key)
	{
		return null;
	}

	public ulong GetSelfTeamID(int key)
	{
		return 0uL;
	}

	public bool SelfIsCaptain(int key)
	{
		return false;
	}

	public List<ulong> GetRequestedTeamIDList(int key)
	{
		return null;
	}

	public void ClearRequestedTeamIDList(int key)
	{
	}

	public List<CSAccountCupInfoRes> GetCacheAccountCupInfoList(int key)
	{
		return null;
	}

	public List<AccountInfoBasicWithCupInfo> GetSelfTeamMembers(int key, bool includeSelf = true)
	{
		return null;
	}

	public bool IsFriendInTeam(int key, FriendAccountInfo friendInfo)
	{
		return false;
	}

	public proto.EPresence.AccountPresence TeamMemberPresence(ulong id, ulong teamID)
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	public proto.EPresence.SocialPresence TeamMemberSocialPresence(ulong id, ulong teamID)
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	public ulong TeamMemberGroupID(ulong id, ulong teamID)
	{
		return 0uL;
	}

	public string TeamMemberPresenceString(ulong id, ulong teamID)
	{
		return null;
	}

	public List<AccountInfoBasicWithCupInfo> GetTeamApplicants(int key)
	{
		return null;
	}

	public List<AccountInfoBasicWithCupInfo> GetTeamInvitations(int key)
	{
		return null;
	}

	public uint GetSelfMembersNum(int key)
	{
		return 0u;
	}

	public void UpdateTeamInfoEditCD(int key)
	{
	}

	public ulong GetTeamInfoEditCD(int key)
	{
		return 0uL;
	}

	private void UpdateTeamID(int key, ulong teamID)
	{
	}

	public void SortTeamMember(List<AccountInfoBasicWithCupInfo> members, bool sortPresence, CupTeamInfo teamInfo)
	{
	}

	public uint GetRemainMatchTimes(int key)
	{
		return 0u;
	}

	public bool IsFinishAllGame(int key)
	{
		return false;
	}

	public bool HasNonTeamMemberPlayerInGroup(int key, List<GroupMemberInfo> members)
	{
		return false;
	}

	public bool UsedTicket(int key)
	{
		return false;
	}

	public CSAccountCupInfoRes GetSelfCupInfo(int key)
	{
		return null;
	}

	public bool IsTeamLocked(int key)
	{
		return false;
	}

	public CupTeamInfo GetTeamInfoByTeamID(ulong teamID)
	{
		return null;
	}

	public List<int> GetHistoryResult(int key)
	{
		return null;
	}

	public bool IsCupMatchChampion(int key)
	{
		return false;
	}

	public bool IsFirstLoseMatch(int key)
	{
		return false;
	}

	public CupMatchResult GetLastMatchResult(int key)
	{
		return CupMatchResult.Win;
	}

	public int GetSelfMatchIndexByMatchCnt(int matchCnt)
	{
		return 0;
	}

	public bool IsSelfTeamBattleIndex(int index)
	{
		return false;
	}

	public uint GetSelfTeamTier(int key)
	{
		return 0u;
	}

	public bool HasPlayedOneGame(int key)
	{
		return false;
	}

	public bool IsInvitedAccount(int key, FriendAccountInfo accountInfo)
	{
		return false;
	}

	public List<ulong> GetInvitedIdList(int key)
	{
		return null;
	}

	public static int GenerateKey(uint type, uint id)
	{
		return 0;
	}

	public static uint GetCupMatchTypeByKey(int key)
	{
		return 0u;
	}

	public static uint GetCupMatchIDByKey(int key)
	{
		return 0u;
	}

	public bool AllProtocalReady()
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

	public int GetHightestPriorityMatchType()
	{
		return 0;
	}

	public void SetEntranceWarmUpState()
	{
	}

	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	public DateTime MatchStartTime()
	{
		return default(DateTime);
	}

	public static int GetLobbyEntrancePriority()
	{
		return 0;
	}

	public int LobbyEntrancePriority()
	{
		return 0;
	}

	public bool CanShowEntranceCountDown()
	{
		return false;
	}

	public ulong GetCountDownTime()
	{
		return 0uL;
	}

	public void SetTeamInfoFlag()
	{
	}

	public void SetCupMatchInfoFlag()
	{
	}

	public void SetMapInfoFlag()
	{
	}

	public void SoloConfirm(int key, bool isBlock = false)
	{
	}

	public void RequestAllCupConfigReq(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestCreateTeam(uint type, uint id, string name, string countryOrArea, uint clanAvatar, uint clanBanner, uint http_option = 0u)
	{
	}

	public void RequestJoinTeam(int key, ulong friendID, ulong teamID, bool byChat)
	{
	}

	private void CacheRequestedJoinTeamID(int key, ulong teamID)
	{
	}

	public void RequestModifyTeamInfo(int key, string teamName, string countryOrArea, uint clanAvatar, uint clanBanner)
	{
	}

	public void RequestTeamInfoByTeamID(int key, ulong teamID, bool requestTeamApplication = false)
	{
	}

	public void RequestSelfTeamMembers(uint type, uint id)
	{
	}

	public void RequestTeamMembers(int key, ulong teamID, bool requestTeamMemberPresence = false, bool forcePresence = false)
	{
	}

	public void RequestQuitTeam(int key, bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	public void RequestDismissTeam(int key, bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	public void RequestTeamApplicantList(int key, bool force = false)
	{
	}

	public void RequestInvitationList(uint type, uint id, bool force = false)
	{
	}

	public void RequestInvitedIdList(int key)
	{
	}

	public void RequestApproveApplication(int key, ulong applicantID)
	{
	}

	public void RequestApproveApplication(int key, AccountInfoBasicWithCupInfo basicInfoWithCupTier)
	{
	}

	public void RequestDeclineApplication(int key, ulong[] applicantIDs)
	{
	}

	public void RequestInvite(int key, ulong inviteeID)
	{
	}

	public void RequestApproveJoinTeamInvitation(int key, ulong inviter, ulong inviterTeam)
	{
	}

	public void RequestDeclineJoinTeamInvitation(int key, ulong[] inviterIDs)
	{
	}

	public void RequestTeamMemberPresence(int key, bool force = false)
	{
	}

	public void RequestRemoveTeamMember(int key, ulong removeeID)
	{
	}

	public void RequestAccountCupInfoBundleByAccountIDsOrderly(uint type, uint id, ulong[] accountIDs, bool needTeamInfo, bool isSearch = false)
	{
	}

	public void RequestClaimCupReward(uint type, uint id)
	{
	}

	public bool IsInRequestTicketCD()
	{
		return false;
	}

	public void RequestUseTicket(uint type, uint id)
	{
	}

	public void RequestVerifyAndLockCupTeam(uint type, uint id)
	{
	}

	public void InitAccountCupInfo(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void OnJoinApplicantNotify(uint type, uint id)
	{
	}

	public void OnConfrimAddNotify(ConfirmAddCupTeamReq ntf)
	{
	}

	public void OnDismissNotify(uint type, uint id, ulong teamID)
	{
	}

	public void OnRemoveNotify(uint type, uint id, ulong teamID, ulong removeeID)
	{
	}

	public void OnInviteNotify(uint type, uint id)
	{
	}

	public void OnApproveInviteNotify(uint type, uint id)
	{
	}

	public void OnTeamMemeberPresenceNotify(PresenceListRes presenceData, int cupKey)
	{
	}

	public int GetEntranceTrailOpenTipsCnt(int key)
	{
		return 0;
	}

	public void SetEntranceTrailOpenTipsCnt(int key, int cnt)
	{
	}

	public int GetCupMatchTeamApplicationTipsCnt(int key)
	{
		return 0;
	}

	public void SetCupMatchTeamApplicationTipsCnt(int key, int cnt)
	{
	}

	public int GetCupMatchTeamInvitationTipsCnt(int key)
	{
		return 0;
	}

	public void SetCupMatchTeamInvitationTipsCnt(int key, int cnt)
	{
	}

	public int GetTeamApplyTipsCnt(int key)
	{
		return 0;
	}

	public int GetAllLobbyTipsCnt()
	{
		return 0;
	}

	public int GetCupMatchTeamTabTipsCnt(int key)
	{
		return 0;
	}

	public void UpdateCupMatchTeamTabTipsCnt(int key)
	{
	}

	public void SetClaimRewardTipsCnt(int key, int cnt)
	{
	}

	public int GetClaimRewardTipsCnt(int key)
	{
		return 0;
	}

	public List<AdvertDesc> GetEntranceCdnDesc()
	{
		return null;
	}

	private bool _003CGetFirstCupMatchRewardDesc_003Eb__137_0(CupChestDesc r)
	{
		return false;
	}

	private void _003CRequestAllCupConfigReq_003Eb__226_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CInitAccountCupInfo_003Eb__252_0(HttpErrorCode errorcode, object res)
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
