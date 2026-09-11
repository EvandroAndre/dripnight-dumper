using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class UIModelGroup : UIBaseModel
{
	public enum GroupMemberInviteType
	{
		Normal,
		NeedUpgradeToInvite,
		GroupModeIsMax
	}

	public enum IntentToDo
	{
		None,
		Invite,
		Recruit,
		SendReserveMessage
	}

	public enum GroupAcceptSource
	{
		None,
		NewbieRecruitRecommendation
	}

	public enum ELeaveGroupType
	{
		None,
		OnlyCloseUI,
		CloseUIAndClearData,
		SceneEditLEAVE1,
		SceneEditLEAVE2,
		SceneEditLEAVE3,
		HudMatchResult,
		FriendSpectate,
		ForHalfwayJoin
	}

	public enum ETeamRankLimitState
	{
		NoPreLimit_BeyondRange,
		PreLimit_FullTeam,
		PreLimit_InRange,
		Limited
	}

	public enum ETrioRankBanState
	{
		NoBan_Allow,
		NotYetBan,
		NoBan_Trio_But_NotAutoMatch,
		NoBan_FullTeam,
		Banned
	}

	public enum ERematchEndSource
	{
		OnRematchTeamInfo,
		CheckRematchResultOnCountdownEnd,
		UpdateGroupInfo_GroupJoin,
		CannotQuickStart
	}

	public enum ERematchLogResult
	{
		None,
		Success,
		QuickStart,
		Failed
	}

	private class AcceptInviteCache
	{
		private ulong _003CGroupId_003Ek__BackingField;

		private string _003CRegion_003Ek__BackingField;

		private ulong _003CInviterId_003Ek__BackingField;

		private string _003CGroupCode_003Ek__BackingField;

		private tcp.EGroup.InviteChannelType _003CChannel_003Ek__BackingField;

		private string _003CSecretCode_003Ek__BackingField;

		private bool _003CAutoAccept_003Ek__BackingField;

		private string _003CRecruitCode_003Ek__BackingField;

		private bool _003CAutoAcceptByStatus_003Ek__BackingField;

		private string _003CQrSecretCode_003Ek__BackingField;

		private EUISource _003CUISource_003Ek__BackingField;

		private bool _003CSetUnready_003Ek__BackingField;

		private tcp.EGroup.PlayerDisplayState _003CDisplayState_003Ek__BackingField;

		private GroupAcceptSource _003CAcceptSource_003Ek__BackingField;

		public ulong GroupId
		{
			get
			{
				return _003CGroupId_003Ek__BackingField;
			}
			set
			{
				_003CGroupId_003Ek__BackingField = value;
			}
		}

		public string Region
		{
			get
			{
				return _003CRegion_003Ek__BackingField;
			}
			set
			{
				_003CRegion_003Ek__BackingField = value;
			}
		}

		public ulong InviterId
		{
			get
			{
				return _003CInviterId_003Ek__BackingField;
			}
			set
			{
				_003CInviterId_003Ek__BackingField = value;
			}
		}

		public string GroupCode
		{
			get
			{
				return _003CGroupCode_003Ek__BackingField;
			}
			set
			{
				_003CGroupCode_003Ek__BackingField = value;
			}
		}

		public tcp.EGroup.InviteChannelType Channel
		{
			get
			{
				return _003CChannel_003Ek__BackingField;
			}
			set
			{
				_003CChannel_003Ek__BackingField = value;
			}
		}

		public string SecretCode
		{
			get
			{
				return _003CSecretCode_003Ek__BackingField;
			}
			set
			{
				_003CSecretCode_003Ek__BackingField = value;
			}
		}

		public bool AutoAccept
		{
			get
			{
				return _003CAutoAccept_003Ek__BackingField;
			}
			set
			{
				_003CAutoAccept_003Ek__BackingField = value;
			}
		}

		public string RecruitCode
		{
			get
			{
				return _003CRecruitCode_003Ek__BackingField;
			}
			set
			{
				_003CRecruitCode_003Ek__BackingField = value;
			}
		}

		public bool AutoAcceptByStatus
		{
			get
			{
				return _003CAutoAcceptByStatus_003Ek__BackingField;
			}
			set
			{
				_003CAutoAcceptByStatus_003Ek__BackingField = value;
			}
		}

		public string QrSecretCode
		{
			get
			{
				return _003CQrSecretCode_003Ek__BackingField;
			}
			set
			{
				_003CQrSecretCode_003Ek__BackingField = value;
			}
		}

		public EUISource UISource
		{
			get
			{
				return _003CUISource_003Ek__BackingField;
			}
			set
			{
				_003CUISource_003Ek__BackingField = value;
			}
		}

		public bool SetUnready
		{
			get
			{
				return _003CSetUnready_003Ek__BackingField;
			}
			set
			{
				_003CSetUnready_003Ek__BackingField = value;
			}
		}

		public tcp.EGroup.PlayerDisplayState DisplayState
		{
			get
			{
				return _003CDisplayState_003Ek__BackingField;
			}
			set
			{
				_003CDisplayState_003Ek__BackingField = value;
			}
		}

		public GroupAcceptSource AcceptSource
		{
			get
			{
				return _003CAcceptSource_003Ek__BackingField;
			}
			set
			{
				_003CAcceptSource_003Ek__BackingField = value;
			}
		}

		public void Clear()
		{
		}
	}

	private class AcceptJoinCache
	{
		private ulong _003CGroupId_003Ek__BackingField;

		private GroupJoinRequestNtf _003CGroupJoinRequestNtf_003Ek__BackingField;

		private bool _003CAutoAcceptByStatus_003Ek__BackingField;

		private EUISource _003CUISource_003Ek__BackingField;

		public ulong GroupId
		{
			get
			{
				return _003CGroupId_003Ek__BackingField;
			}
			set
			{
				_003CGroupId_003Ek__BackingField = value;
			}
		}

		public GroupJoinRequestNtf GroupJoinRequestNtf
		{
			get
			{
				return _003CGroupJoinRequestNtf_003Ek__BackingField;
			}
			set
			{
				_003CGroupJoinRequestNtf_003Ek__BackingField = value;
			}
		}

		public bool AutoAcceptByStatus
		{
			get
			{
				return _003CAutoAcceptByStatus_003Ek__BackingField;
			}
			set
			{
				_003CAutoAcceptByStatus_003Ek__BackingField = value;
			}
		}

		public EUISource UISource
		{
			get
			{
				return _003CUISource_003Ek__BackingField;
			}
			set
			{
				_003CUISource_003Ek__BackingField = value;
			}
		}

		public void Clear()
		{
		}
	}

	public class GroupUpgradeToJoinCacheData
	{
		public GroupMemberInviteType groupInviteType;

		public GroupJoinRequestNtf inviteNtfData;

		public ulong groupInfoId;

		public void Clear()
		{
		}
	}

	private class NewbieRecruitQuickJoinAfterLeaveIntentInfo
	{
		public ulong SourceGroupId;

		public bool OpenMapBonus;

		public EMatch.GameMode GameMode;

		public EMatch.MatchMode MatchMode;

		public EMatch.GroupMode GroupMode;

		public uint BrRank;

		public uint CsRank;

		public uint CsPeakRank;

		public uint[] TeamTags;

		public uint SpecialModeEventId;
	}

	public class IntentInviteInfo
	{
		public ulong m_AccountID;

		public string m_Region;

		public tcp.EGroup.InviteChannelType m_Channel;

		public tcp.EGroup.InviteeType m_InviteeType;

		public IntentInviteInfo(ulong account_id, string region, tcp.EGroup.InviteChannelType channel, tcp.EGroup.InviteeType inviteeType = tcp.EGroup.InviteeType.InviteeType_NONE)
		{
		}
	}

	public class IntentRequestJoinInfo
	{
		public GroupInviteNtf GroupInviteInfo;

		public TeammateStats GroupJoinInfo;

		public tcp.EGroup.InviteeType InviteeType;
	}

	private struct NewbieRecruitCalcResult
	{
		public uint MaxRank;

		public bool MapPoolBonus;

		public uint SpecialModeEventId;
	}

	private class RematchCoPlayData
	{
		public int MatchTogether;

		public int BooyahTogether;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<uint, string> _003C_003E9__324_0;

		public static Func<string, string, string> _003C_003E9__324_1;

		public static Func<uint, string> _003C_003E9__324_2;

		public static Func<string, string, string> _003C_003E9__324_3;

		public static Converter<MapModeData, uint> _003C_003E9__440_0;

		public static Predicate<MapOpeningInfo> _003C_003E9__481_0;

		public static Predicate<tcp.RematchPlayer> _003C_003E9__550_0;

		internal string _003CRequestAcceptInternal_003Eb__324_0(uint i)
		{
			return null;
		}

		internal string _003CRequestAcceptInternal_003Eb__324_1(string s1, string s2)
		{
			return null;
		}

		internal string _003CRequestAcceptInternal_003Eb__324_2(uint i)
		{
			return null;
		}

		internal string _003CRequestAcceptInternal_003Eb__324_3(string s1, string s2)
		{
			return null;
		}

		internal uint _003CRequestGroupChange_003Eb__440_0(MapModeData x)
		{
			return 0u;
		}

		internal bool _003CGroupMemberLackMapV2_003Eb__481_0(MapOpeningInfo x)
		{
			return false;
		}

		internal bool _003CCheckAndQuitRematchIfNeeded_003Eb__550_0(tcp.RematchPlayer p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass312_0
	{
		public UIModelGroup _003C_003E4__this;

		public List<uint> map_ids;

		public bool isRanking;

		public uint game_mode;

		public CMDBIPLGLGA group_mode;

		public uint difficulty;

		public uint match_mode;

		public tcp.EGroup.CreateFromType fromType;

		public bool isRandomMap;

		public uint requireRank;

		public string groupTag;

		public uint requireMaxRank;

		public bool intraTeamDuel;

		public ulong rematch_team_id;

		public long rematch_end_timestamp;

		public Action onSendSuccess;

		internal void _003CRequestCreateGroup_003Eb__0(ResErrorCode error, ResDownloadType download_type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass314_0
	{
		public UIModelGroup _003C_003E4__this;

		public ulong account_id;

		public ulong groupId;

		public tcp.EGroup.InviteeType inviteType;

		public bool needShowTweenTips;

		public Action onSendSuccess;

		internal void _003CRequestJoinGroup_003Eb__0(ResErrorCode error, ResDownloadType download_type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass321_0
	{
		public UIModelGroup _003C_003E4__this;

		public ulong group_id;

		public string region;

		public ulong inviterid;

		public string group_code;

		public tcp.EGroup.InviteChannelType channel;

		public string secretCode;

		public bool autoAccept;

		public string recruitCode;

		public bool autoAcceptByStatus;

		public string qr_secretcode;

		public bool setUnready;

		public tcp.EGroup.PlayerDisplayState displayState;

		public GroupAcceptSource acceptSource;

		internal void _003CRequestAccept_003Eb__0(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass332_0
	{
		public ulong kickout_id;

		internal bool _003CRequestKickout_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass339_0
	{
		public UIModelGroup _003C_003E4__this;

		public EMatchReasonTextKey matchmakingReason;

		internal void _003CRequestStart_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass340_0
	{
		public UIModelGroup _003C_003E4__this;

		public EMatchReasonTextKey matchmakingReason;

		internal void _003CRequestStartInternal_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass342_0
	{
		public UISecondConfirmContoller confirmCtrl;

		public UIModelGroup _003C_003E4__this;

		public Action onConfirm;

		internal void _003CShowSoftIsolationConfirmDialog_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass354_0
	{
		public GroupInfo resData;

		public UIModelGroup _003C_003E4__this;

		public ulong myId;

		internal bool _003CUpdateGroupInfo_003Eb__1(GroupMemberInfo mem)
		{
			return false;
		}

		internal bool _003CUpdateGroupInfo_003Eb__2(GroupMemberInfo mem)
		{
			return false;
		}

		internal bool _003CUpdateGroupInfo_003Eb__3(GroupMemberInfo member)
		{
			return false;
		}

		internal bool _003CUpdateGroupInfo_003Eb__4(GroupMemberInfo member)
		{
			return false;
		}

		internal bool _003CUpdateGroupInfo_003Eb__0(GroupMemberInfo m)
		{
			return false;
		}

		internal bool _003CUpdateGroupInfo_003Eb__5(GroupMemberInfo mem)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass410_0
	{
		public UIModelGroup _003C_003E4__this;

		public UIModelMapOpeningInfo modelOpeningInfo;

		internal void _003CFakeUGCMapInfoAndRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass441_0
	{
		public UIModelGroup _003C_003E4__this;

		public bool quickStartState;

		public bool showTips;

		public bool byClickBtn;

		public EMatchReasonTextKey matchmakingReason;

		public EGroupReadyReason readyReason;

		internal void _003CRequestReady_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass451_0
	{
		public uint mapId;

		public Predicate<uint> _003C_003E9__0;

		internal bool _003CCheckMemberLackOfMaps_003Eb__0(uint a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass458_0
	{
		public ulong memberAccountId;

		internal bool _003CCheckAndShowEmulatorWarningTip_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass459_0
	{
		public ulong memberAccountId;

		internal bool _003CCheckNewMemberCreditScorePunishTip_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass460_0
	{
		public ulong memberAccountId;

		internal bool _003CCheckNewMemberGameBufSendMessage_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass461_0
	{
		public ulong memberAccountId;

		internal bool _003CCheckNewMemberHGDifficultyTip_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass496_0
	{
		public UIModelGroup _003C_003E4__this;

		public uint requestGameMode;

		public uint requestGroupMode;

		internal void _003CRequestTeamUpRecommendList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass497_0
	{
		public TeamUpRecommendAccountInfo info;

		internal bool _003CGetTeamUpRecommendStats_003Eb__0(proto.RankingStatsSummary a)
		{
			return false;
		}

		internal bool _003CGetTeamUpRecommendStats_003Eb__1(proto.RankingStatsSummary a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass500_0
	{
		public uint gameMode;

		public uint groupMode;

		internal bool _003CGetTeamUpRecommendConfig_003Eb__0(TeamUpRecommendConfigDesc a)
		{
			return false;
		}

		internal bool _003CGetTeamUpRecommendConfig_003Eb__1(TeamUpRecommendConfigDesc a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass507_0
	{
		public ulong accountId;

		internal bool _003CGetMemberGroupAnim_003Eb__0(GroupMemberInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass541_0
	{
		public ulong currentPlayerId;

		internal bool _003CSimulatePlayerRematchResponse_003Eb__0(tcp.RematchPlayer p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass549_0
	{
		public ulong uid;

		internal bool _003CIsMemberRematchStateReady_003Eb__0(tcp.RematchPlayer p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass573_0
	{
		public KeyValuePair<ulong, RematchCoPlayData> kv;

		internal bool _003CReconcileRematchRecommendTracking_003Eb__0(GroupMemberInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass576_0
	{
		public ulong teammateId;

		internal bool _003CTryEnqueueRematchFriendRecommend_003Eb__0(GroupMemberInfo m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass578_0
	{
		public ulong accountId;

		internal bool _003CDebugRecommendFriend_003Eb__0(GroupMemberInfo m)
		{
			return false;
		}
	}

	private AcceptInviteCache m_acceptInviteCache;

	private AcceptJoinCache m_acceptJoinCache;

	public List<GroupUpgradeToJoinCacheData> groupUpgradeToJoinCacheList;

	public GroupInfo GroupInfo;

	public GroupMemberInfo MyInfo;

	public GroupMemberInfo LeaderInfo;

	public GroupInviteNtf InviterGroupInfo;

	public GroupInviteNtf InGameGroupInviteNtf;

	private List<ulong> m_GroupMemberIds;

	public CMDBIPLGLGA GroupMode;

	public bool IntraTeamDuel;

	public bool IsAutoMatch;

	public bool AllReady;

	public int ReadyCnt;

	public int QuickMatchReadtCnt;

	public ulong LastGetRemindTimeStamp;

	private int m_SpecialReason;

	public static int GROUP_DUO_MEMBER_COUNT;

	public static int GROUP_QUARD_MEMBER_COUNT;

	public const uint PropID_GroupInfo_Update = 2u;

	public const uint PropID_GroupInfo_Clear = 4u;

	public const uint PropID_AvailableMap_Change = 8u;

	public const uint PropID_NotAvailableMode_Change = 16u;

	public const uint PropID_GroupMemberInfoSetShare_Change = 16u;

	public const uint PropID_RematchTeamInfo_Change = 32u;

	public const uint PropID_NewbieTeamUpRecommendList_Change = 64u;

	public const string PREF_KEY_MANUAL_SOLO = "BR_Team_Mode_Manual_Solo_";

	private IntentToDo m_IntentAfterCreate;

	public MapModeData PendingPeakMapMode;

	public bool NeedSwitchToPeakAfterQuit;

	private bool m_WasInMixedInGameState;

	private bool m_CacheInvite;

	private float m_NextTransferLeaderTime;

	private ulong InviteId;

	private string InviteRegion;

	private uint m_GroupMinLadder;

	private uint m_GroupMaxLadder;

	private bool m_CanClickMatchBtn;

	private bool m_AutoGrowModeByStatus;

	private List<TeamingRankRuleDesc> m_TeamingRankRuleDescList;

	private const uint Bronze_Grade = 1u;

	private const int TeamingRankRuleModeBase = 1000;

	public List<string> m_MemberLackMap;

	private uint m_InviteLadderLimitMin;

	private uint m_InviteLadderLimitMax;

	private bool m_SendRecruitToFriend;

	private bool m_ShowTeamCodeUpdateTips;

	private bool m_GroupCodeHasChange;

	private Dictionary<string, SceneEditSlotInfo> m_GroupUGCInfoDict;

	private Dictionary<uint, List<TeamingRankRuleDesc>> m_TeamingRankRuleDescDict;

	private List<TeamingScoreRuleDesc> m_TeamingScoreRuleDescList;

	private Dictionary<uint, List<TeamingScoreRuleDesc>> m_TeamingScoreRuleDescDict;

	private bool m_SoftIsolationConfirmDismissed;

	public Dictionary<ulong, int> MemberId2GroupIndex;

	private RematchTeamInfo m_RematchTeamInfo;

	private readonly List<UIPostMatchTeamUpCountDownController.PlayerData> m_SortedRematchPlayers;

	private readonly List<UIPostMatchTeamUpCountDownController.PlayerData> m_PostMatchTeamUpTeammates;

	private bool m_IsRematchAccepted;

	private bool m_IsRematchRefused;

	private bool m_IsRematchTeammateAccepted;

	private bool m_IsRematchPassiveAcceptCompleted;

	private bool m_RematchQuitSend;

	private bool m_RematchHasSentLog;

	private ulong m_RematchEndTimestamp;

	private ulong m_RematchStartTimestamp;

	private ulong m_RematchTeamId;

	private uint m_RematchReason;

	private ulong m_RematchMvpUserId;

	private uint m_RematchTotalKills;

	private uint m_RematchTotalRevives;

	private float m_RematchAvgRating;

	private ERematchLogResult m_RematchLogResult;

	private ulong m_RematchFightOnGroupId;

	private tcp.ERematch.QuitReason m_LastLocalQuitReason;

	private ulong m_PendingRematchMatchId;

	public bool NeedProcessAcceptInvite;

	public bool NeedProcessAcceptJoin;

	public bool NeedProcessGroupUpgradeToJoin;

	public List<GameObject> GroupAnimBgGameObject;

	private bool _003CIsAutoAcceptingRequest_003Ek__BackingField;

	private GroupAcceptSource _003CLastGroupAcceptSource_003Ek__BackingField;

	public bool IsNewbieTeamUpRecommendUser;

	public TeamUpRecommendAccountInfo NewbieTeamUpRecommendInfo;

	private ulong m_LastShowNewbieTeamUpRecommendTs;

	private bool m_NeedChangeGroupUIState;

	public CMDBIPLGLGA UITestGroupMode;

	private bool m_CanShowTestGtoupUI;

	private bool m_NeedRequestPlayAfterCreateGroup;

	private bool m_IsAffectedByDefaultTeamMode;

	public bool HDEnterTeam;

	private bool m_IsInGroup;

	public bool RepairIdleReturnInGroup;

	private string m_GroupCaptainNickName;

	private bool _003CIsGroupLeader_003Ek__BackingField;

	private bool _003CIsNeedSendMessage_003Ek__BackingField;

	private bool _003CIsMixGroupInGame_003Ek__BackingField;

	private bool m_IsGroupPublic;

	private ETeamRankLimitState _003CTeamRankLimitState_003Ek__BackingField;

	private ETrioRankBanState _003CTrioRankBanState_003Ek__BackingField;

	private bool _003CIsTrioRankBanned_003Ek__BackingField;

	private bool _003CIsBannedTrioRank_003Ek__BackingField;

	private bool _003CIsTeamRankInPreLimit_003Ek__BackingField;

	private bool _003CIsTeamRankLimited_003Ek__BackingField;

	private uint _003CTeamRankMinLimit_003Ek__BackingField;

	private uint _003CTeamRankMaxLimit_003Ek__BackingField;

	private uint _003CTeamRankUnlimitedCount_003Ek__BackingField;

	private List<GroupMemberInfo> m_TeamRankLimitedMembers;

	private bool _003CIsSoftIsolated_003Ek__BackingField;

	private bool _003CIsSoftIsolatedForSelf_003Ek__BackingField;

	private ELeaveGroupType m_LeaveGroupType;

	private NewbieRecruitQuickJoinAfterLeaveIntentInfo m_NewbieRecruitQuickJoinAfterLeaveIntent;

	private bool m_IsNewbieRecruitQuickJoinFlow;

	private List<GroupAcceptJoinReq> m_JoinFriendDataList;

	private List<InviteFriendData> m_InviteFriendDataList;

	private List<InviteFriendData> m_InviteFriendAfterCreateGroupDataList;

	private bool m_HasTeamInvite;

	private ulong m_ClanRecommenderAccountId;

	private string m_LastRecommendClanTime;

	private Dictionary<ulong, ulong> m_IgnoreGroupMemberInviteDict;

	private List<TeamUpRecommendAccountInfo> m_TeamUpRecommendList_BR_Quad;

	private List<TeamUpRecommendAccountInfo> m_TeamUpRecommendList_BR_Dual;

	private List<TeamUpRecommendAccountInfo> m_TeamUpRecommendList_CS;

	private List<ulong> m_TeamUpRecommendedList_BR_Quad;

	private List<ulong> m_TeamUpRecommendedList_BR_Dual;

	private List<ulong> m_TeamUpRecommendedList_CS;

	private Dictionary<ulong, uint> m_DicTeamUpRecommendCommonFriends;

	private List<proto.RankingStatsSummary> m_TeamUpRecommendStats;

	private List<TeamUpRecommendConfigDesc> m_TeamUpRecommendConfigDesc;

	private RecommendShowData m_HighTeamUpRecommendStats;

	public TeamUpRecommendAccountInfo InviteGroupBoxLastShowRecommendPlayer;

	public bool IsIrgoreTeamUpRecommend;

	public ulong LastShowTeamUpRecommendLobbyNotificationTs;

	public ulong LastFloatingWindowTs;

	private ulong LastRequestTeamUpRecommendTs;

	private ERecommendSource m_RecommendSource;

	private Dictionary<ulong, ulong> m_IgnorePlayerDict;

	public tcp.EGroup.InviteeType LastInviteeType;

	public ulong LastParticipantId;

	private List<IntentInviteInfo> m_IntentInviteInfoList;

	private List<IntentRequestJoinInfo> m_IntentRequestJoinInfoList;

	public bool EnableEmulatorWarning;

	private bool m_HasPopedEmulatorWarningTip;

	public Action AutoRoomMatchMaking;

	private const string REMATCH_FRIEND_REC_PUSHED_PREFIX = "RematchFriendRecPushed_";

	private ulong m_RematchTrackedGroupId;

	private readonly Dictionary<ulong, RematchCoPlayData> m_RematchCoPlayDict;

	private readonly List<RecommendFriendInfo> m_PendingRematchFriendRecInfos;

	public bool RematchHasSentLog
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAutoAcceptingRequest
	{
		get
		{
			return _003CIsAutoAcceptingRequest_003Ek__BackingField;
		}
		set
		{
			_003CIsAutoAcceptingRequest_003Ek__BackingField = value;
		}
	}

	public GroupAcceptSource LastGroupAcceptSource
	{
		get
		{
			return _003CLastGroupAcceptSource_003Ek__BackingField;
		}
		private set
		{
			_003CLastGroupAcceptSource_003Ek__BackingField = value;
		}
	}

	public bool IsInGroup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string GroupCapatainNickName
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool IsGroupLeader
	{
		get
		{
			return _003CIsGroupLeader_003Ek__BackingField;
		}
		private set
		{
			_003CIsGroupLeader_003Ek__BackingField = value;
		}
	}

	public bool IsNeedSendMessage
	{
		get
		{
			return _003CIsNeedSendMessage_003Ek__BackingField;
		}
		set
		{
			_003CIsNeedSendMessage_003Ek__BackingField = value;
		}
	}

	public bool IsMixGroupInGame
	{
		get
		{
			return _003CIsMixGroupInGame_003Ek__BackingField;
		}
		set
		{
			_003CIsMixGroupInGame_003Ek__BackingField = value;
		}
	}

	public bool IsGroupPublic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLimitedTimeRankMatch => false;

	public bool IsRankingMatch => false;

	public bool IsClanWarMatch => false;

	public bool IsClanWarChampionshipMatch => false;

	public bool GroupCodeHasChange
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowTeamCodeUpdateTips
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool canClickMatchBtn => false;

	public uint groupMinLadder => 0u;

	public uint groupMaxLadder => 0u;

	public ETeamRankLimitState TeamRankLimitState
	{
		get
		{
			return _003CTeamRankLimitState_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankLimitState_003Ek__BackingField = value;
		}
	}

	public ETrioRankBanState TrioRankBanState
	{
		get
		{
			return _003CTrioRankBanState_003Ek__BackingField;
		}
		private set
		{
			_003CTrioRankBanState_003Ek__BackingField = value;
		}
	}

	public bool IsTrioRankBanned
	{
		get
		{
			return _003CIsTrioRankBanned_003Ek__BackingField;
		}
		private set
		{
			_003CIsTrioRankBanned_003Ek__BackingField = value;
		}
	}

	public bool IsBannedTrioRank
	{
		get
		{
			return _003CIsBannedTrioRank_003Ek__BackingField;
		}
		private set
		{
			_003CIsBannedTrioRank_003Ek__BackingField = value;
		}
	}

	public bool IsTeamRankInPreLimit
	{
		get
		{
			return _003CIsTeamRankInPreLimit_003Ek__BackingField;
		}
		private set
		{
			_003CIsTeamRankInPreLimit_003Ek__BackingField = value;
		}
	}

	public bool IsTeamRankLimited
	{
		get
		{
			return _003CIsTeamRankLimited_003Ek__BackingField;
		}
		private set
		{
			_003CIsTeamRankLimited_003Ek__BackingField = value;
		}
	}

	public uint TeamRankMinLimit
	{
		get
		{
			return _003CTeamRankMinLimit_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankMinLimit_003Ek__BackingField = value;
		}
	}

	public uint TeamRankMaxLimit
	{
		get
		{
			return _003CTeamRankMaxLimit_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankMaxLimit_003Ek__BackingField = value;
		}
	}

	public uint TeamRankUnlimitedCount
	{
		get
		{
			return _003CTeamRankUnlimitedCount_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankUnlimitedCount_003Ek__BackingField = value;
		}
	}

	public List<GroupMemberInfo> TeamRankLimitedMembers => null;

	public bool IsSoftIsolated
	{
		get
		{
			return _003CIsSoftIsolated_003Ek__BackingField;
		}
		private set
		{
			_003CIsSoftIsolated_003Ek__BackingField = value;
		}
	}

	public bool IsSoftIsolatedForSelf
	{
		get
		{
			return _003CIsSoftIsolatedForSelf_003Ek__BackingField;
		}
		private set
		{
			_003CIsSoftIsolatedForSelf_003Ek__BackingField = value;
		}
	}

	public ELeaveGroupType leaveGroupType
	{
		get
		{
			return ELeaveGroupType.None;
		}
		set
		{
		}
	}

	public bool IsNewbieRecruitQuickJoinFlow => false;

	public bool IsCSRankingMatch => false;

	public bool IsCSPeakMatch => false;

	public bool ISHCRankingMatch => false;

	public uint GameMode => 0u;

	public uint MatchMode => 0u;

	public bool HasTeamInvite
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong ClanRecommenderAccountId => 0uL;

	public List<TeamUpRecommendAccountInfo> TeamUpRecommendList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ulong> TeamUpRecommendedList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RecommendShowData HighTeamUpRecommendStats => null;

	public ERecommendSource RecommendSource => ERecommendSource.None;

	private tcp.EGroup.InviteChannelType GetChangedInviteChannelType(tcp.EGroup.InviteeType inviteeType)
	{
		return tcp.EGroup.InviteChannelType.InviteChannelType_PLAYER;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ClearLastGroupAcceptSource()
	{
	}

	public bool CanTriggerNewbieTeamUpRecommend()
	{
		return false;
	}

	public void RecordNewbieTeamUpRecommendShowTime()
	{
	}

	public bool IsNewBieRecruitOpen()
	{
		return false;
	}

	public void CacheInviteData(ulong id, string region)
	{
	}

	public void ClearCacheInviteData()
	{
	}

	public void SendCacheData()
	{
	}

	public void SendSocialBufAutoMessage()
	{
	}

	public void SendSwitchModeToClanWarMessage()
	{
	}

	public void SendSwitchModeToTournamentMessage()
	{
	}

	public void OnInGameItemCountChange(Item item, Item originItem)
	{
	}

	public void TryRecordManualSoloPreference()
	{
	}

	public void ClearManualSoloPreferenceIfExists()
	{
	}

	public bool IsAffectedByDefaultTeamMode()
	{
		return false;
	}

	public void ClearDefaultTeamModeAffectedFlag()
	{
	}

	public void SetShowTestGroupUIState(bool state)
	{
	}

	private string GetManualSoloPreferenceKey()
	{
		return null;
	}

	private bool HasManualSoloPreference(string logPrefix = "")
	{
		return false;
	}

	public void RequestPlayAfterCreateGroup()
	{
	}

	public void SetNeedRequestPlayAfterCreateGroupState(bool state)
	{
	}

	private bool CheckAndSetGroupMode(ESwitch.SwitchFunc switchFunc, CMDBIPLGLGA groupMode, uint[] playerLimits, ulong endNum)
	{
		return false;
	}

	public void SetTestGroupMode()
	{
	}

	public void TestFakeGroupMode()
	{
	}

	public bool CheckChangeGroupUIState(bool force = false)
	{
		return false;
	}

	public bool CheckShowSoloUI()
	{
		return false;
	}

	public bool CheckShowInGroupAndSolo()
	{
		return false;
	}

	private void OnPveInGameItemCountChange()
	{
	}

	public void AddIgnoreGroupMemberInvite(ulong accountId)
	{
	}

	public void RemoveIgnoreGroupMemberInvite(ulong accountId)
	{
	}

	public bool CheckIsInIgnoreGroupMemberInviteList(ulong accountId)
	{
		return false;
	}

	private List<TeamUpRecommendAccountInfo> GetTeamUpRecommendListByGroupInfo(uint gameMode, uint groupMode)
	{
		return null;
	}

	private List<ulong> GetTeamUpRecommendedListByGroupInfo(uint gameMode, uint groupMode)
	{
		return null;
	}

	public void AddIgnorePlayer(ulong accountId)
	{
	}

	public void RemoveIgnorePlayer(ulong accountId)
	{
	}

	public bool HasRelationshipPlayerInGroup(ulong friendID)
	{
		return false;
	}

	public bool HasSocialBufPlayerInGroup()
	{
		return false;
	}

	public bool HasCallbackBufPlayerInGroup()
	{
		return false;
	}

	public bool IsPlayerHasCallbackBuf(GroupMemberInfo member)
	{
		return false;
	}

	public bool IsPlayerHasSocialBuf(GroupMemberInfo member)
	{
		return false;
	}

	public FastGroupInvite.EGameBuffIconType GetGameBuffIconType()
	{
		return FastGroupInvite.EGameBuffIconType.None;
	}

	public bool IsCurGameModeTeamUpGameBufValid()
	{
		return false;
	}

	public bool IsCurMatchModeCallbackBufValid()
	{
		return false;
	}

	public List<string> GetHasSocialBufPlayerNames()
	{
		return null;
	}

	public List<string> GetHasCallBackBufPlayerNames()
	{
		return null;
	}

	public void clearNextTransferLeaderTime()
	{
	}

	public bool CheckIsInIgnoreList(ulong accountId)
	{
		return false;
	}

	public bool ReachMaxGroupCount()
	{
		return false;
	}

	public bool IsShowMatchResultInviteBtn()
	{
		return false;
	}

	public bool CheckIsMatchMaking(bool showTips = true)
	{
		return false;
	}

	public void CancelMatchMaking()
	{
	}

	public void RequestCreateGroup(List<uint> map_ids, bool isRanking = false, uint game_mode = 1u, CMDBIPLGLGA group_mode = CMDBIPLGLGA.EGROUPMODE_DUAL, uint difficulty = 0u, uint match_mode = 1u, tcp.EGroup.CreateFromType fromType = tcp.EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0u, string groupTag = "", uint requireMaxRank = 0u, bool intraTeamDuel = false, ulong rematch_team_id = 0uL, long rematch_end_timestamp = 0L, Action onSendSuccess = null)
	{
	}

	private void RequestCreateGroupInternal(List<uint> map_ids, bool isRanking = false, uint game_mode = 1u, CMDBIPLGLGA group_mode = CMDBIPLGLGA.EGROUPMODE_DUAL, uint difficulty = 0u, uint match_mode = 1u, tcp.EGroup.CreateFromType fromType = tcp.EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0u, string groupTag = "", uint requireMaxRank = 0u, bool intraTeamDuel = false, ulong rematch_team_id = 0uL, long rematch_end_timestamp = 0L, Action onSendSuccess = null)
	{
	}

	public void RequestJoinGroup(ulong account_id, ulong groupId, tcp.EGroup.InviteeType inviteType, bool needShowTweenTips = true, Action onSendSuccess = null)
	{
	}

	private void RequestJoinGroupInternal(ulong account_id, ulong groupId, tcp.EGroup.InviteeType inviteType, bool needShowTweenTips = true, Action onSendSuccess = null)
	{
	}

	private void SocialhighlightProto2Tcp(List<tcp.SocialHighLight> dataList, List<proto.SocialHighLight> socialHighlights)
	{
	}

	private tcp.LeaderboardTitleInfo LeaderboardTitleProto2Tcp(proto.LeaderboardTitleInfo titleInfo)
	{
		return null;
	}

	public void RequestInvite(ulong account_id, string region, tcp.EGroup.InviteChannelType channel, tcp.EGroup.InviteeType inviteeType = tcp.EGroup.InviteeType.InviteeType_NONE, bool isOfflineInvite = false, EInvitePushType pushType = EInvitePushType.None, Action onSendSuccess = null)
	{
	}

	public void RequestAccept(ulong group_id, string region, ulong inviterid = 0uL, string group_code = "", tcp.EGroup.InviteChannelType channel = tcp.EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "", bool autoAccept = false, string recruitCode = null, bool autoAcceptByStatus = false, string qr_secretcode = "", EUISource uiSource = EUISource.None, bool setUnready = false, tcp.EGroup.PlayerDisplayState displayState = tcp.EGroup.PlayerDisplayState.PlayerDisplayState_NONE, GroupAcceptSource acceptSource = GroupAcceptSource.None)
	{
	}

	public void RequestAcceptWithCachedParams()
	{
	}

	public void RequestAcceptGroupJoinRequestWithCachedParams()
	{
	}

	private void RequestAcceptInternal(ulong group_id, string region, ulong inviterid = 0uL, string group_code = "", tcp.EGroup.InviteChannelType channel = tcp.EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "", bool autoAccept = false, string recruitCode = null, bool autoAcceptByStatus = false, string qr_secretcode = "", bool setUnready = false, tcp.EGroup.PlayerDisplayState displayState = tcp.EGroup.PlayerDisplayState.PlayerDisplayState_NONE, GroupAcceptSource acceptSource = GroupAcceptSource.None)
	{
	}

	public void RequestRefuse(ulong group_id, string region, GroupInviteNtf inviteNtfData, uint resaon = 0u)
	{
	}

	public void RequestAcceptGroupJoinRequest(GroupAcceptJoinReq req)
	{
	}

	public void RequestAcceptGroupJoinRequest(ulong group_id, GroupJoinRequestNtf ntf, bool autoAcceptByStatus = false, EUISource uiSource = EUISource.None)
	{
	}

	public void RequestRefuseGroupJoinRequest(ulong group_id, GroupJoinRequestNtf inviteNtfData)
	{
	}

	public bool RequestLeave(ELeaveGroupType leaveGroup = ELeaveGroupType.None, bool fromHippoCrisisLobby = false)
	{
		return false;
	}

	public void MigrateGroup()
	{
	}

	public void RequestTransferLeader(ulong targetID)
	{
	}

	public void RequestKickout(ulong kickout_id)
	{
	}

	public void RequestChangePubPvt(bool isPublic)
	{
	}

	public void RequestSyncOptionalMapResStatus(tcp.EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	public void RefreshOptionalMapResStatus(SyncPatchOptionalResStatusNtf resData)
	{
	}

	public void NoticeMember()
	{
	}

	public void RequestGroupRemind(ulong remindeeId)
	{
	}

	public List<ulong> GetFriendsInGroup()
	{
		return null;
	}

	public void RequestStart(EMatchReasonTextKey matchmakingReason = EMatchReasonTextKey.None)
	{
	}

	private void RequestStartInternal(EMatchReasonTextKey matchmakingReason)
	{
	}

	public void RequestStop()
	{
	}

	private void ShowSoftIsolationConfirmDialog(string confirmButtonText, Action onConfirm)
	{
	}

	public void RequestGroupInfo()
	{
	}

	public void RequestUpdateMaps(List<uint> maps, List<uint> unAvaliableModes)
	{
	}

	public void UpdatePlayerAvailableMaps(GroupChangeAvailableMapsNtf info)
	{
	}

	private void GetDifferentElements(uint[] preArray, uint[] curArray, out List<uint> added, out List<uint> removed)
	{
		added = null;
		removed = null;
	}

	public static bool IsForceAutoMatchGameMode(uint gamemode)
	{
		return false;
	}

	public static bool IsForceNotAutoMatchGameMode(uint gamemode)
	{
		return false;
	}

	public bool CheckSameClanInGroup()
	{
		return false;
	}

	public void CheckShowClanRecommendInGroup()
	{
	}

	public bool IsCantSoloMatchMakingGame(uint gamemode)
	{
		return false;
	}

	public bool CheckCrashMap(uint[] mapMode, uint matchMode)
	{
		return false;
	}

	private bool CheckMapsEqual(uint[] oldMaps, uint[] newMaps)
	{
		return false;
	}

	public void UpdateGroupInfo(GroupInfo resData, bool isNew = false, bool forcerefreshavatar = true, bool fromRematchMerge = false)
	{
	}

	public void UpdateGroupMemberInfoSharedSet(GroupMemberInfo resData)
	{
	}

	public void TryRestoreLocalSocialLobbySetShareProfile()
	{
	}

	private bool TryGetLocalSetShareProfile(out uint avatarId, out uint skinColor, out List<uint> clothes, out List<proto.AccountCollectionCustomItemInfo> customData)
	{
		avatarId = default(uint);
		skinColor = default(uint);
		clothes = null;
		customData = null;
		return false;
	}

	private uint GetLocalSetShareSkinColor()
	{
		return 0u;
	}

	private List<proto.AccountCollectionCustomItemInfo> GetLocalSetShareCustomData()
	{
		return null;
	}

	public void SetAfterCreateIntent(IntentToDo todo)
	{
	}

	public void DoAfterCreateGroup()
	{
	}

	public void SetIntentInviteInfo(ulong account_id, string region, tcp.EGroup.InviteChannelType channel, tcp.EGroup.InviteeType inviteeType = tcp.EGroup.InviteeType.InviteeType_NONE)
	{
	}

	public void DoIntentInvite()
	{
	}

	public void ClearIntentInviteInfo()
	{
	}

	public void ClearIntentRequestInfo()
	{
	}

	public void DoIntentRequest()
	{
	}

	public void SetIntentRequestInfo(TeammateStats teammateStats, tcp.EGroup.InviteeType inviteeType = tcp.EGroup.InviteeType.InviteeType_NONE)
	{
	}

	public void SetIntentRequestInfo(GroupInviteNtf groupInviteInfo)
	{
	}

	public bool HasPendingNewbieRecruitQuickJoinAfterLeaveForGroup(ulong sourceGroupId)
	{
		return false;
	}

	public void RequestNewbieRecruitQuickJoinAfterLeave(GroupRecruitTeamInfo teamInfo)
	{
	}

	public bool TryDoNewbieRecruitQuickJoinAfterLeave(ulong sourceGroupId = 0uL)
	{
		return false;
	}

	private void SetNewbieRecruitQuickJoinAfterLeaveIntent(GroupRecruitTeamInfo teamInfo)
	{
	}

	private void ClearNewbieRecruitQuickJoinAfterLeaveIntent()
	{
	}

	private void RequestNewbieRecruitQuickJoin(NewbieRecruitQuickJoinAfterLeaveIntentInfo intent)
	{
	}

	public void ClearNewbieRecruitQuickJoinFlow()
	{
	}

	private void RefreshTeamIsolationState()
	{
	}

	private void SetDefaultTeamRankingLimitState()
	{
	}

	private void SetDefaultSoftIsolationState()
	{
	}

	private void RefreshTeamRankingLimitState()
	{
	}

	public bool WouldTriggerHardIsolationIfInvited(uint candidateRangeMinRank, uint candidateRangeMaxRank)
	{
		return false;
	}

	public bool WouldTriggerHardIsolationWithNewFriend(FriendAccountInfo friendInfo)
	{
		return false;
	}

	private bool TryGetNewFriendTeamUpRuleMode(FriendAccountInfo friendInfo, out uint matchMode, out uint gameMode, out uint groupMode)
	{
		matchMode = default(uint);
		gameMode = default(uint);
		groupMode = default(uint);
		return false;
	}

	private uint GetCurrentPlayerRankByMatchMode(uint matchMode)
	{
		return 0u;
	}

	private uint GetFriendRankByMatchMode(FriendAccountInfo friendInfo, uint matchMode)
	{
		return 0u;
	}

	private bool WouldTriggerHardIsolationBetweenTwoPlayers(uint matchMode, uint gameMode, uint groupMode, uint selfRank, uint friendRank, bool selfVeteranExempt, bool friendVeteranExempt)
	{
		return false;
	}

	private bool IsTeamingRankRuleDescInCurrentSeason(TeamingRankRuleDesc rule)
	{
		return false;
	}

	public bool GetHardIsolationRuleRange(out uint lowRank, out uint minRank)
	{
		lowRank = default(uint);
		minRank = default(uint);
		return false;
	}

	public bool GetSoftIsolationRuleRange(out uint lowRank, out uint minRank)
	{
		lowRank = default(uint);
		minRank = default(uint);
		return false;
	}

	private uint GetCurrentTeamHighestRank()
	{
		return 0u;
	}

	private bool IsRankInRuleRange(uint rank, uint lowRank, uint highRank)
	{
		return false;
	}

	private bool IsRuleRangeHigherPriority(uint lowRank, uint highRank, uint currentLowRank, uint currentHighRank)
	{
		return false;
	}

	public string GetTeamRankDisplayName(uint rank)
	{
		return null;
	}

	public void ProcessCSGetTeamingScoreRuleDescRes(CSGetTeamingScoreRuleDescRes res)
	{
	}

	private bool IsTeamingScoreRuleDescInCurrentSeason(TeamingScoreRuleDesc rule)
	{
		return false;
	}

	private void RefreshTeamSoftIsolationState()
	{
	}

	private uint GetMemberRankByMatchMode(GroupMemberInfo member, uint matchMode)
	{
		return 0u;
	}

	private bool IsCurrentPlayerSoftIsolationAffected(TeamingScoreRuleDesc rule)
	{
		return false;
	}

	private bool IsVeteranExemptionEnabled()
	{
		return false;
	}

	private uint GetVeteranExemptMinLevel()
	{
		return 0u;
	}

	private bool IsVeteranExemptFromTeamIsolation(GroupMemberInfo member)
	{
		return false;
	}

	private bool IsVeteranExemptFromTeamIsolation(FriendAccountInfo friendInfo)
	{
		return false;
	}

	private bool HasVeteranExemptMemberInTeam()
	{
		return false;
	}

	private bool IsCurrentPlayerVeteranExemptFromTeamIsolation()
	{
		return false;
	}

	private bool HasVeteranReturnTagForTeamIsolation(EAttendance.VeteranLeaveDays leaveDaysTag)
	{
		return false;
	}

	public bool IsTeamRankLimitedMember(ulong accountid)
	{
		return false;
	}

	private void FakeUGCMapInfoAndRequest()
	{
	}

	public void UpdateInviterGroupInfo(GroupInviteNtf resData)
	{
	}

	public string GetGroupModeNameByCnt(uint groupMemberCnt)
	{
		return null;
	}

	public List<ulong> GetMemberIds()
	{
		return null;
	}

	public void ClearData(bool isByDisconnected = false)
	{
	}

	public void ClearDelayAcceptInviteAndJoinData()
	{
	}

	public bool IsTeamFull()
	{
		return false;
	}

	public int GetGroupMembersCount()
	{
		return 0;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessTeamingRankRuleRankMapping()
	{
	}

	private uint ProcessModesKey(uint matchMode, uint gameMode, uint groupMode)
	{
		return 0u;
	}

	public void InviteFriendAfterCreateGroup()
	{
	}

	public void InviteFriendAfterGroupUpgrade(uint preGroupMode)
	{
	}

	public void AddInviteFriendCreateGroupData(InviteFriendData data)
	{
	}

	public void AddInviteFriendDataList(InviteFriendData data)
	{
	}

	public void FriendJoinGroupAfterGroupUpgrade(uint preGroupMode)
	{
	}

	public void AddJoinFriendDataList(ulong group_id, GroupJoinRequestNtf ntf)
	{
	}

	public void InitExpansionGroupModeData(ulong receiverID, bool isInvite, uint preGroupMode)
	{
	}

	public void HandleByGroupMemberInviteType(GroupMemberInviteType type, bool autoAcceptByStatus = false)
	{
	}

	public GroupMemberInviteType GetMyGroupInviteType()
	{
		return GroupMemberInviteType.Normal;
	}

	public GroupMemberInviteType GetMyFriendGroupInviteType(uint groupMemberCnt, uint groupMode, uint gameMode, uint matchMode)
	{
		return GroupMemberInviteType.Normal;
	}

	public GroupMemberInviteType GetInviteType(uint groupMemberCnt, uint groupMode, CMDBIPLGLGA maxGroupMode)
	{
		return GroupMemberInviteType.Normal;
	}

	public void ProcessCSGetTeamingRankRuleDescRes(CSGetTeamingRankRuleDescRes res)
	{
	}

	public uint GetRankSortByMemberInfo(GroupMemberInfo member, MapModeData item)
	{
		return 0u;
	}

	public ResourceID GetResIdByRank(uint limitRank)
	{
		return default(ResourceID);
	}

	public ResourceID GetResIdByMember(GroupMemberInfo member)
	{
		return default(ResourceID);
	}

	public void SetGroupMode(CMDBIPLGLGA mode, bool intraTeamDuel = false, bool request = true)
	{
	}

	public void SetAutoMatch(bool v)
	{
	}

	public void RequestGroupChange(MapModeData mapData, uint difficutly = 0u, uint rankLimit = 0u, string groupTags = "", uint rankMaxLimit = 0u, int groupMode = -1, bool setNotRdy = true, bool intraTeamDuel = false)
	{
	}

	public void RequestGroupChange(List<MapModeData> mapsData, uint difficutly = 0u, uint rankLimit = 0u, string groupTags = "", uint rankMaxLimit = 0u, int groupMode = -1, bool setNotRdy = true, bool intraTeamDuel = false)
	{
	}

	public void RequestReady(bool readyState, bool quickStartState = false, bool showTips = true, bool byClickBtn = false, EMatchReasonTextKey matchmakingReason = EMatchReasonTextKey.None, EGroupReadyReason readyReason = EGroupReadyReason.None)
	{
	}

	private void RequestReadyInternal(bool readyState, bool quickStartState, bool showTips, bool byClickBtn, EMatchReasonTextKey matchmakingReason, EGroupReadyReason readyReason)
	{
	}

	public void RequestReadyForUgcMap(bool state)
	{
	}

	public void RequestGroupCode()
	{
	}

	public void SetEndReason(int reason)
	{
	}

	public void SetGroupReady()
	{
	}

	private bool IsGroupMapInvalidForLocal()
	{
		return false;
	}

	public uint GetPlayersLimitsByMode(CMDBIPLGLGA mode)
	{
		return 0u;
	}

	public CMDBIPLGLGA GetGroupModeByMaxPlayerCount(uint playerCount)
	{
		return CMDBIPLGLGA.EGROUPMODE_SOLO;
	}

	public void CheckAvailableMaps(uint[] maps, uint gameMode)
	{
	}

	public bool CheckMemberLackOfMaps(uint mapId, bool showTips = true, bool isNewTips = false)
	{
		return false;
	}

	public void UpdateGroupCode(string groupCode)
	{
	}

	public void OnGroupLeave(ulong id)
	{
	}

	public void OnGroupJoin(List<ulong> newJoinMemberAccountIds)
	{
	}

	private bool CheckEmulatorWarningEnable()
	{
		return false;
	}

	private void CheckAndShowEmulatorWarningTip(List<ulong> newJoinMemberAccountIds)
	{
	}

	private void CheckNewMemberCreditScorePunishTip(List<ulong> newJoinMemberAccountIds)
	{
	}

	private void CheckNewMemberGameBufSendMessage(List<ulong> newJoinMemberAccountIds)
	{
	}

	private void CheckNewMemberHGDifficultyTip(List<ulong> newJoinMemberAccountIds)
	{
	}

	private void CheckLeaveMemberHGDifficultyTip()
	{
	}

	private bool CheckFriendIsClosedFriend(ulong friendid)
	{
		return false;
	}

	public string GenerateInviteNotifyDeepLink(EDeepLinkType type)
	{
		return null;
	}

	private string MakeInviteUrl(string urlTemplate, EDeepLinkType type)
	{
		return null;
	}

	public List<JBJKLGIDAGI> GetRelationshipInGroup()
	{
		return null;
	}

	public void GroupHDLeaveCaptainLobby()
	{
	}

	public bool CheckShowCaptainLobby(GroupMemberInfo capatinInfo)
	{
		return false;
	}

	public void GroupHDEnterCaptainLobby()
	{
	}

	public void RequestStartRoomMatchMakingGame()
	{
	}

	public void RequestStopRoomMatchMakingGame()
	{
	}

	private bool RequestLeaveGroupInCtrl(ELeaveGroupType leaveGroupType)
	{
		return false;
	}

	public void OnLocalPlayerLeaveTeamRefreshUI(ELeaveGroupType leaveGroupType)
	{
	}

	public void OnLocalPlayerLeaveTeam(tcp.EGroup.LeaveReason resDataReason)
	{
	}

	private void DoAfterLeaveGroup()
	{
	}

	public void SendJoinRecommendPlayer(TeammateStats stats)
	{
	}

	public void SendInviteRecommendPlayer(TeammateStats stats)
	{
	}

	public void AgreeGroupJoinImmediately(GroupJoinRequestNtf inviteNtfData)
	{
	}

	public void AgreeGroupInviteImmediately(GroupInviteNtf inviteNtfData, bool isAutoAcceptByStatus = false, bool isSetUnReady = false)
	{
	}

	public bool GroupMemberLackMapV2(GroupMemberInfo member)
	{
		return false;
	}

	public void SetInviteRankLimit(uint m_LadderLimitID, uint m_LadderLimitMaxID)
	{
	}

	public void ClearInviteRankLimit(uint matchId)
	{
	}

	public bool IfSendRecruitToFriend()
	{
		return false;
	}

	public void SendRecruitToFriend()
	{
	}

	public GroupMemberInfo GetGroupMemberInfo(ulong id)
	{
		return null;
	}

	public bool IsGroupMember(ulong id)
	{
		return false;
	}

	public string GetGroupMemberName(ulong account)
	{
		return null;
	}

	public bool HasReadyQuickMatch()
	{
		return false;
	}

	public void OnLeaderTransfer()
	{
	}

	public TeamUpRecommendAccountInfo GetNowTeamUpRecommendPlayer()
	{
		return null;
	}

	public void SetTeamUpRecommended(TeamUpRecommendAccountInfo info)
	{
	}

	public void CheckAndShowTeamUpRecommend()
	{
	}

	public uint GetTeamUpRecommendCommonFriendNum(ulong accountId)
	{
		return 0u;
	}

	public bool CanShowTeamUpRecommend()
	{
		return false;
	}

	public void RequestTeamUpRecommendList()
	{
	}

	public proto.RankingStatsSummary GetTeamUpRecommendStats(TeamUpRecommendAccountInfo info)
	{
		return null;
	}

	public void LoadRecommendShowData()
	{
	}

	public void ProcessTeamUpRecommendConfigDesc(List<TeamUpRecommendConfigDesc> desc)
	{
	}

	public TeamUpRecommendConfigDesc GetTeamUpRecommendConfig(uint gameMode, uint groupMode)
	{
		return null;
	}

	private void ClearTeamUpRecommendDatas()
	{
	}

	public bool CheckIntraTeamDuelPlayerCountFull()
	{
		return false;
	}

	public bool CheckGroupMemberIsBeSilenceAndGetEndTime(List<tcp.CreditPunishOtherInfo> punishInfos, ref long punishUntil)
	{
		return false;
	}

	public bool CheckGroupMemberIsBeBanMatchModeAndGetEndTime(List<tcp.CreditPunishOtherInfo> punishInfos, uint gameMode, ref long punishUntil, uint curMatchMode)
	{
		return false;
	}

	public bool CheckAndShowGroupMemberBeBanMatchState(bool showPop, bool checkSelf = true)
	{
		return false;
	}

	public uint GetSelfGroupAnim()
	{
		return 0u;
	}

	public uint GetMemberGroupAnim(ulong accountId)
	{
		return 0u;
	}

	public bool IsTeammate(ulong userID)
	{
		return false;
	}

	public List<UIPostMatchTeamUpCountDownController.PlayerData> GetPostMatchTeamUpTeammates()
	{
		return null;
	}

	public ulong GetRematchEndTimestamp()
	{
		return 0uL;
	}

	public ulong GetRematchStartTimestamp()
	{
		return 0uL;
	}

	public uint GetRematchReason()
	{
		return 0u;
	}

	public ulong GetRematchMvpUserId()
	{
		return 0uL;
	}

	public uint GetRematchTotalKills()
	{
		return 0u;
	}

	public uint GetRematchTotalRevives()
	{
		return 0u;
	}

	public float GetRematchAvgRating()
	{
		return 0f;
	}

	public void SetRematchStartTimestamp(ulong timestamp)
	{
	}

	public void SetRematchEndTimestamp(ulong timestamp)
	{
	}

	public bool IsRematchAccepted()
	{
		return false;
	}

	public bool NeedRematchPopupButtonUI()
	{
		return false;
	}

	public bool IsTeamAccepted()
	{
		return false;
	}

	public RematchTeamInfo GetRematchTeamInfo()
	{
		return null;
	}

	public void SetRematchAccepted(bool accepted)
	{
	}

	public bool IsRematchRefused()
	{
		return false;
	}

	public void SetRematchRefused(bool refused)
	{
	}

	public bool IsRematchTeammateAccepted()
	{
		return false;
	}

	public void SetRematchTeammateAccepted(bool accepted)
	{
	}

	public bool IsRematchPassiveAcceptCompleted()
	{
		return false;
	}

	public void SetRematchPassiveAcceptCompleted(bool completed)
	{
	}

	public void ResetRematchState()
	{
	}

	public void SetRematchLogResult(ERematchLogResult result)
	{
	}

	public void SetRematchFightOnGroupId(ulong groupId)
	{
	}

	public ulong GetRematchFightOnGroupId()
	{
		return 0uL;
	}

	public ERematchLogResult GetRematchLogResult()
	{
		return ERematchLogResult.None;
	}

	public tcp.ERematch.QuitReason GetLastLocalQuitReason()
	{
		return tcp.ERematch.QuitReason.QuitReason_NONE;
	}

	public bool IsRematchInProgress()
	{
		return false;
	}

	public void CloseRematchUIAndSwitchToQuickMatchMode(ERematchEndSource source, bool hasQuitPlayer = false, bool hasOtherPlayerQuit = false, bool needAutoReady = true)
	{
	}

	public void RequestReadyForRematchAcceptedPlayer(EMatchReasonTextKey matchmakingReason = EMatchReasonTextKey.None)
	{
	}

	public void CheckRematchResultOnCountdownEnd()
	{
	}

	public void SimulateRematchTeamInfo(int scenario = 0)
	{
	}

	public void SimulatePlayerRematchResponse(ulong playerId = 0uL, bool accept = true, int baseScenario = 0)
	{
	}

	public void ForceSetRematchTeamInfo(RematchTeamInfo teamInfo)
	{
	}

	public void OnRematchTeamInfo(RematchTeamInfo teamInfo, bool isSetTeamNtf)
	{
	}

	public void RefreshSortedRematchPlayers(Dictionary<ulong, List<tcp.RematchPlayer>> groups, ulong currentPlayerGroupId)
	{
	}

	public List<UIPostMatchTeamUpCountDownController.PlayerData> GetSortedRematchPlayers()
	{
		return null;
	}

	public void RequestAcceptRematch(ulong matchId)
	{
	}

	public void RequestQuitRematch(ulong matchId, ulong teamId = 0uL, tcp.ERematch.QuitReason reason = tcp.ERematch.QuitReason.QuitReason_NONE)
	{
	}

	public void OnStopPostMatchMaking()
	{
	}

	public bool IsMemberRematchStateReady(ulong uid)
	{
		return false;
	}

	public void CheckAndQuitRematchIfNeeded()
	{
	}

	public void ReturnToLobbyChangeDisplayState()
	{
	}

	public bool GotoFriendSpectatorReq(ulong spectateAccountID)
	{
		return false;
	}

	public void UpdateTeammateDisplayState(ChangePlayerDisplayStateNtf displayData)
	{
	}

	public bool IsGroupInMixedInGameState()
	{
		return false;
	}

	public void ResetMixedInGameState()
	{
	}

	public bool IsNeedShowNoInLobbyTip(ulong accountID)
	{
		return false;
	}

	public bool IsMixedGroupMemberInGameOrResult(ulong accountID)
	{
		return false;
	}

	public bool IsGroupMemberHasDisplayState(ulong accountID)
	{
		return false;
	}

	public bool IsGroupMemberInGame(ulong accountID)
	{
		return false;
	}

	public bool IsGroupMemberInResultOrSpectator(ulong accountID)
	{
		return false;
	}

	public bool IsPlayerInCurrentGroup(ulong accountID)
	{
		return false;
	}

	public void RequestNewbieTeamUpRecommendList()
	{
	}

	public void ProcessNewbieRecruitTeamNtf(GroupNewbieRecruitTeamNtf ntf)
	{
	}

	private NewbieRecruitCalcResult CalcNewbieRecruitParams(uint gameMode, uint matchMode)
	{
		return default(NewbieRecruitCalcResult);
	}

	public bool IsRematchInvitePopupEnabled()
	{
		return false;
	}

	public void OnRematchGroupFormedForRecommend(ulong groupId)
	{
	}

	public void ReconcileRematchRecommendTracking()
	{
	}

	public void OnMatchResultReadyForRematchRecommend()
	{
	}

	private void ClearRematchRecommendTracking()
	{
	}

	private void TryEnqueueRematchFriendRecommend(ulong teammateId, RematchCoPlayData data)
	{
	}

	public void FlushPendingRematchFriendRecommend()
	{
	}

	public void DebugRecommendFriend(ulong accountId)
	{
	}

	private bool _003CGroupHDEnterCaptainLobby_003Eb__469_0(GroupMemberInfo x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
