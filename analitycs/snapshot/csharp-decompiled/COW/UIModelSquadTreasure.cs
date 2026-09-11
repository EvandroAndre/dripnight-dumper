using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelSquadTreasure : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<proto.TopUpMember> _003C_003E9__171_1;

		public static Comparison<RecommendTopUpTeam> _003C_003E9__174_1;

		public static Converter<uint, string> _003C_003E9__183_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__183_2;

		public static Comparison<SquadTreasureAwardDesc> _003C_003E9__184_0;

		public static Comparison<proto.TopUpMember> _003C_003E9__209_0;

		public static Comparison<proto.TopUpMember> _003C_003E9__214_0;

		internal int _003CRequestGetAccountTeamTopUpInfo_003Eb__171_1(proto.TopUpMember a, proto.TopUpMember b)
		{
			return 0;
		}

		internal int _003CRequestRecommendTopUpTeams_003Eb__174_1(RecommendTopUpTeam a, RecommendTopUpTeam b)
		{
			return 0;
		}

		internal string _003CRequestClaimTopUpTeamAward_003Eb__183_0(uint x)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimTopUpTeamAward_003Eb__183_2(BaseItemInfo item)
		{
			return null;
		}

		internal int _003CProcessSquadTreasureDesc_003Eb__184_0(SquadTreasureAwardDesc a, SquadTreasureAwardDesc b)
		{
			return 0;
		}

		internal int _003CProcessTopUpTeamProgressNtf_003Eb__209_0(proto.TopUpMember a, proto.TopUpMember b)
		{
			return 0;
		}

		internal int _003CConvertTopUpTeam_003Eb__214_0(proto.TopUpMember a, proto.TopUpMember b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public ulong curTimeStamp;

		public bool isNotify;

		internal void _003CRequestRecommendTopUpTeams_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public ulong friendAccountId;

		public ulong teamId;

		internal void _003CRequestJoinTopUpTeam_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public proto.TopUpTeam team;

		internal bool _003CHandleJoinTeamSuccess_003Eb__0(proto.TopUpMember x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass183_0
	{
		public List<uint> awardTierIds;

		public UIModelSquadTreasure _003C_003E4__this;

		internal void _003CRequestClaimTopUpTeamAward_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public ulong teamId;

		public uint teamState;

		public ESquadTreasureTeamState originalTeamState;

		public uint seconds;

		internal void _003CRequestChangeTopUpTeamSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public ulong friendAccountId;

		internal void _003CRequestSendTopUpTeamInvitations_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public ulong teamId;

		internal void _003CRequestRejectTopUpTeamInvitation_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public UIModelSquadTreasure _003C_003E4__this;

		public uint pageIndex;

		internal void _003CRequestGetAccountCompletedTopUpTeams_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private static readonly Dictionary<int, string> MonthLocKeyDict;

	private Dictionary<uint, SquadTreasureSettingDesc> m_DictIdToSquadTreasureSetting;

	private Dictionary<uint, List<SquadTreasureAwardDesc>> m_DictIdToSquadTreasureAward;

	private Dictionary<uint, List<RecommendTopUpTeam>> m_DictRecommendTypeToInfo;

	private Dictionary<ulong, TopUpTeamInvitation> m_DictAccountIdToInvitation;

	private List<TopUpTeamInvitation> m_CachedValidInvitationList;

	private bool m_IsValidInvitationDirty;

	private Dictionary<ulong, RecommendTopUpTeam> m_DictGroupIdToTeam;

	private Dictionary<ulong, proto.TopUpMember> m_DictAccountIdToMember;

	private HashSet<ulong> m_ReadInvitationAccountIds;

	private HashSet<ulong> m_InTeamAccountIds;

	private HashSet<ulong> m_AddFriendRequestedAccountIds;

	private CSGetAccountTeamTopUpInfoRes m_AccountTeamTopUpInfoRes;

	public const uint PropID_CreateTopUpTeam = 1u;

	public const uint PropID_GetAccountTeamTopUpInfo = 2u;

	public const uint PropID_InviteFriends = 4u;

	public const uint PropID_JoinTopUpTeam = 8u;

	public const uint PropID_LeaveTopUpTeam = 16u;

	public const uint PropID_ClaimTopUpTeamAward = 32u;

	public const uint PropID_RecommendTopUpTeams = 64u;

	public const uint PropID_ChangeTopUpTeamSetting = 128u;

	public const uint PropID_GetTopUpTeamInfo = 256u;

	public const uint PropID_UpdateTopUpTeamProgress = 512u;

	public const uint PropID_RejectTopUpTeamInvitation = 1024u;

	public const uint PropID_UpdateTopUpTeamInvitation = 2048u;

	public const uint PropID_UpdateMyTopupAmount = 4096u;

	public const uint PropID_UpdateInTeamAccountIds = 8192u;

	public const uint PropID_AutoFindTopUpTeam = 16384u;

	public const uint PropID_GetAccountCompletedTopUpTeams = 32768u;

	private const ulong REQUEST_GET_TOPUP_TEAM_INFO_INTERVAL = 300uL;

	private const ulong REQUEST_RECOMMEND_TOPUP_TEAMS_INTERVAL = 300uL;

	private const ulong REQUEST_IN_TEAM_ACCOUNT_IDS_INTERVAL = 900uL;

	public const ulong TOPUP_TEAM_INVITATION_VALID_TIME = 86400uL;

	private const ulong REQUEST_JOIN_TOPUP_TEAM_INTERVAL = 3uL;

	private const ulong REQUEST_JOIN_TOPUP_TEAM_CD = 1uL;

	public const string TEAM_CODE_PREFIX = "T_50_LC_SQUARDTREASURE_13";

	public const int TEAM_CODE_LENGTH = 12;

	public const string FIRST_TOPUP_TEAM_KEY = "FIRST_TOPUP_TEAM_KEY_{0}";

	public const string BE_KICKED_OFF_KEY = "BE_KICKED_OFF_KEY_{0}_{1}";

	private const uint INITIAL_PROGRESS_COUNT = 0u;

	public const string SECERT_TEAM = "SECRETTEAM";

	public const string FRIENDONLY_TEAM_PREFIX = "FTEAM";

	public const string TAKE_PHOTO_HIGHTLIGHT_KEY = "TAKE_PHOTO_HIGHTLIGHT_KEY_{0}_{1}";

	private const string LAST_LEADER_KEY = "SquadTreasure_LastLeader_{0}_{1}";

	private const string NEED_LEADER_POPUP_KEY = "SquadTreasure_NeedLeaderPopup_{0}";

	private bool m_IsRequestingGetAccountTeamTopUpInfo;

	private bool m_IsRequestingRecommendTopUpTeams;

	private bool m_IsRequestingAutoFindTopUpTeam;

	private bool m_IsRequestingGetAccountCompletedTopUpTeams;

	private ulong m_LastRequestInfoTimeStamp;

	private ulong m_LastRequestRecommendTopUpTeamsTimeStamp;

	private ulong m_LastRequestJoinTopUpTeamTimeStamp;

	private ulong m_LastRequestInTeamAccountIdsTimeStamp;

	private Dictionary<uint, List<proto.TopUpTeam>> m_CompletedTopUpTeamsDict;

	private uint m_CompletedTeamsCount;

	private proto.TopUpTeam m_MySquadTreasureTeam;

	private bool m_IsFirstRequestRecommendTopUpTeams;

	private bool m_IsJoinTeamSuccess;

	private bool m_HasNewRecommendData;

	private bool m_HasCreatedTeam;

	private uint m_CurRewardProgress;

	private List<uint> m_ClaimedAwardIds;

	private ulong m_LastTeamListRefreshTimeStamp;

	private ulong m_LastQuickJoinTimeStamp;

	private uint m_MyTopupAmount;

	private uint? m_CurActiveSquadTreasureId;

	private bool m_IsPrivateTeamReminderCanShow;

	public bool IsJoinTeamSuccess
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasNewRecommendData => false;

	public proto.TopUpTeam MySquadTreasureTeam => null;

	public bool HasCreatedTeam
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint CurRewardProgress => 0u;

	public List<uint> ClaimedAwardIds => null;

	public ulong LastTeamListRefreshTimeStamp
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public ulong LastQuickJoinTimeStamp
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public bool IsMyTopupCompleted => false;

	public uint CurActiveSquadTreasureId => 0u;

	public List<TopUpTeamInvitation> TopUpTeamInvitationList => null;

	public List<TopUpTeamInvitation> ValidTopUpTeamInvitationList => null;

	public proto.TopUpMember MyTopUpMemberInfo => null;

	public bool IsPrivateTeamReminderCanShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void MarkValidInvitationDirty()
	{
	}

	private void RebuildValidInvitationCache()
	{
	}

	public bool IsInvitationRead(ulong accountId)
	{
		return false;
	}

	public void MarkInvitationAsRead(ulong accountId)
	{
	}

	public bool HasUnreadValidInvitation()
	{
		return false;
	}

	public bool ShouldShowLobbyV2PaymentRedDot()
	{
		return false;
	}

	private void RefreshLobbyV2PaymentRedDot()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public bool IsSquadTreasureOpen()
	{
		return false;
	}

	public SquadTreasureSettingDesc GetSquadTreasureSettingBySquadTreasureId(uint squadTreasureId)
	{
		return null;
	}

	public List<SquadTreasureAwardDesc> GetSquadTreasureAwardListBySquadTreasureId(uint squadTreasureId)
	{
		return null;
	}

	public List<RecommendTopUpTeam> GetSquadTreasureRecommendInfoListByRecommendType(uint recommendType)
	{
		return null;
	}

	public RecommendTopUpTeam GetSquadTreasureRecommendInfoByGroupId(ulong groupId)
	{
		return null;
	}

	public TopUpTeamInvitation GetTopUpTeamInvitationInfoByAccountId(ulong accountId)
	{
		return null;
	}

	public proto.TopUpMember GetTopUpMemberByAccountId(ulong accountId)
	{
		return null;
	}

	public bool IsTopUpCompleted(ulong accountId)
	{
		return false;
	}

	public bool HasSquadTreasureTeam()
	{
		return false;
	}

	public bool HasRecommendTeam()
	{
		return false;
	}

	public bool HasInvitationTeam()
	{
		return false;
	}

	public uint GetProgressCntByTopUpTeam(proto.TopUpTeam topUpTeam)
	{
		return 0u;
	}

	public List<uint> GetCanClaimRewardIdList()
	{
		return null;
	}

	public bool CheckIsAllRewardClaimed()
	{
		return false;
	}

	public bool IsLeaderInCurrentTeam(ulong accountId)
	{
		return false;
	}

	public bool CheckNeedBeKickedOff()
	{
		return false;
	}

	public void RemoveTopUpTeamInvitation(ulong friendAccountId)
	{
	}

	public void OnFriendRemoved(ulong friendAccountId)
	{
	}

	public void RemoveAllInvitationByTeamId(ulong teamId)
	{
	}

	public bool CheckSelfIsFirstTopUpFinish()
	{
		return false;
	}

	public string GetCurrentSquadTreasureTitleCDN()
	{
		return null;
	}

	public string GetCurrentSquadTreasureTeamCDN()
	{
		return null;
	}

	public string GetCurrentSquadTreasureBGCDN()
	{
		return null;
	}

	public string GetCurrentSquadTreasureShareCDN()
	{
		return null;
	}

	public string GetCurrentSquadTreasureBigAwardCDN()
	{
		return null;
	}

	public bool IsAllTeamMembersFinishedTopUp()
	{
		return false;
	}

	public bool AreAllAccountsInMyTeam(List<ulong> accountIds)
	{
		return false;
	}

	public uint GetSquadTreasurePhotoTemplateId()
	{
		return 0u;
	}

	public bool ShouldShowSquadTreasureSticker(uint templateId, List<ulong> participantAccountIds)
	{
		return false;
	}

	public string GetLocalizedMonthString(int month)
	{
		return null;
	}

	public string GetSquadTreasureStickerTime()
	{
		return null;
	}

	public ulong GetSquadTreasureEndTime()
	{
		return 0uL;
	}

	public bool IsTeamListBoxRefreshCountDown()
	{
		return false;
	}

	public void ResetNewRecommendDataFlag()
	{
	}

	public string GetTopUpTeamName(proto.TopUpTeam team)
	{
		return null;
	}

	public bool CheckTopupTeamIsFull(proto.TopUpTeam team)
	{
		return false;
	}

	public bool CheckMyTopupTeamIsFull()
	{
		return false;
	}

	public bool CheckMyTopupTeamIsPrivate()
	{
		return false;
	}

	public bool IsFriendInTopUpTeam(ulong accountId)
	{
		return false;
	}

	public string ConvertSecondsToSquadTreasureTimeString(int seconds)
	{
		return null;
	}

	public bool CheckNeedSpecialVFX()
	{
		return false;
	}

	private void SetBeKickedOffInfo(ulong endTimestamp)
	{
	}

	public void ClearBeKickedOffInfo()
	{
	}

	public void RecordBeKickedOffInfo()
	{
	}

	public bool CheckIsInvitationByFriendId(ulong friendAccountId)
	{
		return false;
	}

	public bool HasSentAddFriendRequest(ulong accountId)
	{
		return false;
	}

	public void MarkAddFriendRequestSent(ulong accountId)
	{
	}

	public bool RemoveMemberFromTeam(ulong accountId, bool notifyChange = true)
	{
		return false;
	}

	public uint GetCreatedTeamCount()
	{
		return 0u;
	}

	public ulong GetLastCreatedTeamTimestamp()
	{
		return 0uL;
	}

	public bool CanFreeCreateTeam()
	{
		return false;
	}

	public uint GetTeamCreateCD()
	{
		return 0u;
	}

	public bool HasTeamCreateCDFinished()
	{
		return false;
	}

	public bool IsDataInitialized()
	{
		return false;
	}

	private bool RemoveMemberFromTeamInternal(ulong accountId)
	{
		return false;
	}

	private void ProcessTeamRewardProgress()
	{
	}

	private void ProcessAlreadyTopUpTeammate()
	{
	}

	private void ProcessAssistData()
	{
	}

	private void RefreshClaimRedDot()
	{
	}

	private void UpdateAccountTeamTopUpInfo(uint createdTeamCount, ulong lastCreatedTeamTimestamp)
	{
	}

	public void RequestCreateTopUpTeam(uint teamState = 0u, uint seconds = 0u)
	{
	}

	public void RequestRecreateTopUpTeam()
	{
	}

	public void RequestGetAccountTeamTopUpInfo(bool isForce = false)
	{
	}

	private void ProcessCSGetAccountTeamTopUpInfoRes(CSGetAccountTeamTopUpInfoRes accountTeamTopUpInfoRes)
	{
	}

	public void RequestGetTopUpTeamInfo(ulong teamId)
	{
	}

	public void RequestRecommendTopUpTeams(bool isForce = false, bool isNotify = true)
	{
	}

	public void RequestJoinTopUpTeam(ulong teamId, ulong friendAccountId = 0uL, ESquadTreasureJoinTopUpTeamType type = ESquadTreasureJoinTopUpTeamType.None)
	{
	}

	private void HandleJoinTeamSuccess(proto.TopUpTeam team, ulong friendAccountId)
	{
	}

	private void UpdateMyTeamData(proto.TopUpTeam team)
	{
	}

	private void HandleJoinTeamError(ulong teamId, string errorMsg)
	{
	}

	private void RemoveFullTeamFromAllLists(ulong teamId)
	{
	}

	private void RemoveTeamFromRecommendList(ulong teamId, ESquadTreasureRecommendType recommendType)
	{
	}

	private void RemoveTeamFromDictAndInvitations(ulong teamId)
	{
	}

	public void RequestLeaveTopUpTeam()
	{
	}

	public void RequestClaimTopUpTeamAward(List<uint> awardTierIds)
	{
	}

	public void ProcessSquadTreasureDesc(CSSquadTreasureDescsRes res)
	{
	}

	public void RequestChangeTopUpTeamSetting(ulong teamId, uint teamState, uint seconds)
	{
	}

	public void RequestSendTopUpTeamInvitations(ulong friendAccountId)
	{
	}

	public void RequestRejectTopUpTeamInvitation(ulong teamId, ulong friendAccountId, ESquadTreasureRejectTopUpTeamInvitationType type)
	{
	}

	public void RequestBatchGetTopUPTeamIDsByAccountIDs(ulong[] accountIDs)
	{
	}

	public bool CanRequestInTeamAccountIds()
	{
		return false;
	}

	public void RequestAutoFindTopUpTeam()
	{
	}

	public void RequestGetAccountCompletedTopUpTeams(uint pageIndex, uint pageSize = 0u)
	{
	}

	public List<proto.TopUpTeam> GetAllCachedCompletedTopUpTeams()
	{
		return null;
	}

	public uint GetAllCachedCompletedTopUpTeamsCount()
	{
		return 0u;
	}

	public void InitCompletedTeamsHistory()
	{
	}

	public bool HasMoreCompletedTeamsPages()
	{
		return false;
	}

	public string GetPaddedTeamCode(ulong teamId, bool withPrefix = true)
	{
		return null;
	}

	public static string EncodeTeamShareCode(proto.TopUpTeam teamInfo)
	{
		return null;
	}

	private void AddTeamToCompletedHistory(proto.TopUpTeam team)
	{
	}

	private void RemoveDuplicateTeamFromCompletedCache(ulong teamId)
	{
	}

	public void UpdateTopUpTeamInvitation(TopUpTeamInvitationNtf ntf)
	{
	}

	private TopUpTeamInvitation ProcessTopUpTeamInvitationNtf(TopUpTeamInvitationNtf ntf)
	{
		return null;
	}

	public void UpdateTopUpTeamProgress(TopUpTeamProgressNtf ntf)
	{
	}

	private void CheckClearBeKickedOffInfo()
	{
	}

	private void CheckAndUpdateLeaderTransfer()
	{
	}

	public void RecordLastLeader()
	{
	}

	public void ClearLastLeader()
	{
	}

	public bool NeedShowLeaderTransferPopup()
	{
		return false;
	}

	public void ClearLeaderTransferPopupFlag()
	{
	}

	private proto.TopUpTeam ProcessTopUpTeamProgressNtf(TopUpTeamProgressNtf ntf)
	{
		return null;
	}

	private void ProcessProgressData()
	{
	}

	public void UpdateTopUpTeamLeave(TopUpTeamLeaveNtf ntf)
	{
	}

	public void UpdateMyTopupAmount(uint topupAmount)
	{
	}

	public void UpdateTopUpTeamUpdate(TopUpTeamUpdateTeamNtf ntf)
	{
	}

	private proto.TopUpTeam ConvertTopUpTeam(tcp.TopUpTeam topUpTeam)
	{
		return null;
	}

	private bool _003CGetCurrentSquadTreasureTitleCDN_003Eb__129_0(AdvertDesc x)
	{
		return false;
	}

	private bool _003CGetCurrentSquadTreasureTeamCDN_003Eb__130_0(AdvertDesc x)
	{
		return false;
	}

	private bool _003CGetCurrentSquadTreasureBGCDN_003Eb__131_0(AdvertDesc x)
	{
		return false;
	}

	private bool _003CGetCurrentSquadTreasureShareCDN_003Eb__132_0(AdvertDesc x)
	{
		return false;
	}

	private bool _003CGetCurrentSquadTreasureBigAwardCDN_003Eb__133_0(AdvertDesc x)
	{
		return false;
	}

	private void _003CRequestCreateTopUpTeam_003Eb__169_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetAccountTeamTopUpInfo_003Eb__171_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetTopUpTeamInfo_003Eb__173_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLeaveTopUpTeam_003Eb__182_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestBatchGetTopUPTeamIDsByAccountIDs_003Eb__188_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAutoFindTopUpTeam_003Eb__190_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
