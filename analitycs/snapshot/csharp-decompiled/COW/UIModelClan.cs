using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelClan : UIBaseModel
{
	public enum LuckyBagState
	{
		None,
		Expired,
		DrawOver,
		Drawed,
		CanDraw
	}

	public enum BoxStatus
	{
		None,
		Unavailable,
		Available,
		Claimed
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ClanMember> _003C_003E9__175_0;

		public static Comparison<ClanActiveShowDesc> _003C_003E9__199_0;

		public static Comparison<ClanBadgeItemInfo> _003C_003E9__219_0;

		public static Comparison<ClanActivenessRecord> _003C_003E9__262_0;

		public static Func<PresenceInfo, ulong> _003C_003E9__266_0;

		public static Func<ClanMember, bool> _003C_003E9__266_1;

		public static Action<HttpErrorCode, object> _003C_003E9__274_0;

		public static Action _003C_003E9__279_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__298_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__302_2;

		public static Predicate<ClanMember> _003C_003E9__336_0;

		public static Comparison<ClanActivenessRecord> _003C_003E9__343_1;

		public static Func<ClanMember, bool> _003C_003E9__344_0;

		public static Func<ClanMember, ulong> _003C_003E9__344_1;

		public static Func<ClanMember, uint> _003C_003E9__344_2;

		public static Comparison<ClanActiveShowDesc> _003C_003E9__389_0;

		public static Comparison<ClientClanActivenessAwardDesc> _003C_003E9__390_0;

		public static Comparison<ClientClanActivenessAwardDesc> _003C_003E9__391_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__395_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__398_1;

		public static Comparison<ClanInfo> _003C_003E9__421_0;

		internal bool _003Cget_SelfTopClanMemberList_003Eb__175_0(ClanMember temp)
		{
			return false;
		}

		internal int _003Cget_ClanActiveShowList_003Eb__199_0(ClanActiveShowDesc a, ClanActiveShowDesc b)
		{
			return 0;
		}

		internal int _003CSortTotalBagdeInfoList_003Eb__219_0(ClanBadgeItemInfo a, ClanBadgeItemInfo b)
		{
			return 0;
		}

		internal int _003CAddMyActiveness_003Eb__262_0(ClanActivenessRecord x, ClanActivenessRecord y)
		{
			return 0;
		}

		internal ulong _003CRefreshMemberPresences_003Eb__266_0(PresenceInfo e)
		{
			return 0uL;
		}

		internal bool _003CRefreshMemberPresences_003Eb__266_1(ClanMember a)
		{
			return false;
		}

		internal void _003CInviteToClan_003Eb__274_0(HttpErrorCode errorCode, object obj)
		{
		}

		internal void _003CRequestAcceptClanInvitation_003Eb__279_1()
		{
		}

		internal CommonRewardItemInfo _003CGetRewardWndCfg_ByBatchDrawLuckyBagResult_003Eb__298_0(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestDrawClanLuckyBag_003Eb__302_2(BaseItemInfo item)
		{
			return null;
		}

		internal bool _003CFindDeputyCaptain_003Eb__336_0(ClanMember m)
		{
			return false;
		}

		internal int _003CRequestClanMainPageInfo_003Eb__343_1(ClanActivenessRecord x, ClanActivenessRecord y)
		{
			return 0;
		}

		internal bool _003CGetBiggestPreweeklyActivenessMembers_003Eb__344_0(ClanMember x)
		{
			return false;
		}

		internal ulong _003CGetBiggestPreweeklyActivenessMembers_003Eb__344_1(ClanMember x)
		{
			return 0uL;
		}

		internal uint _003CGetBiggestPreweeklyActivenessMembers_003Eb__344_2(ClanMember member)
		{
			return 0u;
		}

		internal int _003CProcessClanActiveShowDesc_003Eb__389_0(ClanActiveShowDesc a, ClanActiveShowDesc b)
		{
			return 0;
		}

		internal int _003CGetClanActivenessAwardDescs_003Eb__390_0(ClientClanActivenessAwardDesc a, ClientClanActivenessAwardDesc b)
		{
			return 0;
		}

		internal int _003CGetClanPersonalActivenessAwardDescs_003Eb__391_0(ClientClanActivenessAwardDesc a, ClientClanActivenessAwardDesc b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimClanActivenessAward_003Eb__395_1(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimClanPersonalActivenessAward_003Eb__398_1(BaseItemInfo item)
		{
			return null;
		}

		internal int _003CSortClanRecList_003Eb__421_0(ClanInfo a, ClanInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public UnlockedClanBadgeInfo unlockBadge;

		internal bool _003CGetClanTotalBadgeInfoList_003Eb__0(ClanBadgeItemInfo a)
		{
			return false;
		}

		internal bool _003CGetClanTotalBadgeInfoList_003Eb__1(ClanBadgeItemInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelClan _003C_003E4__this;

		public int i;

		public Predicate<ClanApplicationAndInvitationInfo> _003C_003E9__0;

		internal bool _003CSetClanApplicationDataRead_003Eb__0(ClanApplicationAndInvitationInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass236_0
	{
		public ulong applicantID;

		internal bool _003CRemoveDataFromClanApplicationList_003Eb__0(ClanApplicationReadInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public CSExchangeClanBadgeRes data;

		internal bool _003CRequestExchangeClanBadge_003Eb__1(ClanBadgeItemInfo item)
		{
			return false;
		}

		internal bool _003CRequestExchangeClanBadge_003Eb__2(ClanBadgeItemInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass245_0
	{
		public Vector3 position;

		internal void _003CGetClanInfoByClanIdForQRScan_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass251_0
	{
		public UIModelClan _003C_003E4__this;

		public Action suc;

		internal void _003CRequestMyClanInfoInternal_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass256_0
	{
		public UIModelClan _003C_003E4__this;

		public bool sendRecruitToWorld;

		public string name;

		public string slogan;

		public uint entry_type;

		public uint entry_level;

		public uint entry_rank;

		public uint entry_csrank;

		public List<uint> tags;

		internal void _003CRequestCreateClan_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass257_0
	{
		public UIModelClan _003C_003E4__this;

		public ulong playerid;

		public EClanOperation operate;

		internal void _003COperateClan_003Eb__1(HttpErrorCode errorCode, object obj)
		{
		}

		internal void _003COperateClan_003Eb__2(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass257_1
	{
		public CSChangeMemberTypeReq req;

		public _003C_003Ec__DisplayClass257_0 CS_0024_003C_003E8__locals1;

		internal void _003COperateClan_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass263_0
	{
		public UIModelClan _003C_003E4__this;

		public bool refreshPresent;

		public bool forcePresence;

		public object[] inviteData;

		internal void _003CRequestMemberList_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass267_0
	{
		public UIModelClan _003C_003E4__this;

		public string announcement;

		public string slogan;

		public uint entryType;

		public uint areaId;

		public uint playStyle;

		public uint entry_level;

		public uint entry_rank;

		public uint entry_cs_rank;

		public uint[] tags;

		public bool use_custom_badge;

		internal void _003CModifyClanInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass269_0
	{
		public UIModelClan _003C_003E4__this;

		public ClanIconType type;

		public bool useCustomBadge;

		public uint badge_id;

		public bool CloseWindow;

		internal void _003CModifyClanBadge_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass270_0
	{
		public UIModelClan _003C_003E4__this;

		public string name;

		internal void _003CModifyClanName_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass272_0
	{
		public UIModelClan _003C_003E4__this;

		public UIModelGameAssistantIntroduction modelGameAssist;

		internal void _003CRequestClanApplication_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass275_0
	{
		public UIModelClan _003C_003E4__this;

		public ulong inviteeId;

		public bool needRefreshAssist;

		internal void _003CRequestApproveJoinClanApplication_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}

		internal void _003CRequestApproveJoinClanApplication_003Eb__1(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass279_0
	{
		public UIModelClan _003C_003E4__this;

		public ulong clanid;

		public MailInfo mailInfo;

		public bool needRefreshAssist;

		internal void _003CRequestAcceptClanInvitation_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass280_0
	{
		public uint entryType;

		public UIModelClan _003C_003E4__this;

		public ulong clanid;

		internal void _003CRequestApplyForJoinClan_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass286_0
	{
		public UIModelClan _003C_003E4__this;

		public Action suc;

		internal void _003CExitClan_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass295_0
	{
		public UIModelClan _003C_003E4__this;

		public bool isRefreshRequest;

		internal void _003CRequestClanLuckyBagsInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass297_0
	{
		public UIModelClan _003C_003E4__this;

		public bool needResend;

		public List<ulong> alreadyDisposeExistLuckyBag;

		public List<ulong> alreadyDisposeSuccessLuckyBag;

		public int originSuccessLuckyBag;

		public Action _003C_003E9__2;

		public Action _003C_003E9__3;

		internal void _003CRequestDrawAllClanLuckyBag_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestDrawAllClanLuckyBag_003Eb__2()
		{
		}

		internal void _003CRequestDrawAllClanLuckyBag_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass297_1
	{
		public List<DrawClanLuckyBagResultInfo> luckyBagResultInfoList;

		public int i;
	}

	private sealed class _003C_003Ec__DisplayClass297_2
	{
		public int j;

		public _003C_003Ec__DisplayClass297_1 CS_0024_003C_003E8__locals1;

		internal bool _003CRequestDrawAllClanLuckyBag_003Eb__1(ClanLuckyBag bag)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass300_0
	{
		public List<ulong> curDisposeSuccessLuckyBag;

		public int i;

		public Predicate<ClanLuckyBag> _003C_003E9__0;

		internal bool _003CShowBatchBrawLuckyBagTips_003Eb__0(ClanLuckyBag a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass302_0
	{
		public ulong bag_id;

		public UIModelClan _003C_003E4__this;

		public ClanLuckyBag luckyBag;

		internal bool _003CRequestDrawClanLuckyBag_003Eb__0(ClanLuckyBag item)
		{
			return false;
		}

		internal void _003CRequestDrawClanLuckyBag_003Eb__1(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass316_0
	{
		public ulong bag_id;

		internal bool _003CMarkLuckyBagAsClaimed_003Eb__0(ClanLuckyBag x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass318_0
	{
		public ulong accountId;

		internal bool _003CGetNewsStringFromNewsType_003Eb__0(ClanMember m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass326_0
	{
		public ulong accountID;

		internal bool _003CFindClanMemberByID_003Eb__0(ClanMember member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass337_0
	{
		public ulong id;

		internal bool _003CGetClanMemberById_003Eb__0(ClanMember m)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass343_0
	{
		public UIModelClan _003C_003E4__this;

		public CSGetClanMainPageInfoReq req;

		internal void _003CRequestClanMainPageInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass345_0
	{
		public GuildWarMemberInfo item;

		internal bool _003CSetClanMemberClanWarData_003Eb__0(ClanMember x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass354_0
	{
		public ulong clanId;

		internal bool _003CGetRegionLeaderBoardItem_003Eb__0(ClanLeaderboardItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass355_0
	{
		public ulong clanId;

		internal bool _003CGetGlobalLeaderBoardItem_003Eb__0(ClanLeaderboardItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass356_0
	{
		public UIModelClan _003C_003E4__this;

		public ulong clanId;

		internal void _003CRequestClanWarTitleRecord_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass395_0
	{
		public UIModelClan _003C_003E4__this;

		public List<ClientClanActivenessAwardDesc> needClaimAwardDescs;

		internal void _003CRequestClaimClanActivenessAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass398_0
	{
		public UIModelClan _003C_003E4__this;

		public List<ClientClanActivenessAwardDesc> needClaimAwardDescs;

		internal void _003CRequestClaimClanPersonalActivenessAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass413_0
	{
		public FriendAccountInfo info;

		internal bool _003CGetFriendClanList_003Eb__0(FriendAccountInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass415_0
	{
		public UIModelClan _003C_003E4__this;

		public bool needRefreshAssist;

		public bool needUpdateAssistData;

		internal void _003CBatchGetAssistClanInfoByClanIDs_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass424_0
	{
		public uint tagId;

		internal bool _003CCheckCanClanDisplay_003Eb__0(uint id)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass425_0
	{
		public ClanInfo clanInfo;

		internal bool _003CGetFilteredFriendClanInfo_003Eb__0(ClanInfo info)
		{
			return false;
		}
	}

	private ClanInfo m_MyClanInfo;

	private HashSet<ulong> m_ClanMemerSet;

	private List<ClanMember> m_ClanMemberList;

	private List<ClanMember> m_OnlineClanMemberList;

	private List<ClanInfo> m_ClanList;

	private List<ClanApplicationAndInvitationInfo> m_ClanApplicationList;

	private EClanRole m_MyClanRole;

	private Dictionary<ulong, bool> m_ClanApplyStatus;

	private List<ulong> m_PlayerIdsInvitedToClan;

	public List<ClanLuckyBag> m_ClanLuckyBagsList;

	public HashSet<ulong> m_LuckyBagDrawSet;

	public HashSet<ulong> m_LuckyBagExpireSet;

	public Dictionary<ulong, PresenceInfo> m_CachePresence;

	private List<ClanBadgeItemInfo> m_ClanTotalBadgeItemList;

	private Dictionary<uint, ClanBadgeItemInfo> m_ClanTotalBadgeItemDic;

	private Dictionary<uint, ClanBadgeItemInfo> m_ClanOldBadgeItemDic;

	private uint create_gold_cost;

	private uint create_diamond_cost;

	public EClanJoinState ClanJoinState;

	public const int MinClanLevel = 1;

	public QuitReason QuitReason;

	public bool ActivenessPopUpShowed;

	private bool m_HasRequestClanLuckyBagInfo;

	private float m_LastRequestRefreshLuckyBagInfoTime;

	private List<ClanNews> m_MyClanNews;

	private bool m_HasReadApplyDeputyCaptainRedDot;

	public string ClanChanelSecret;

	private List<ClanApplicationReadInfo> m_ReadClanApplicationList;

	private List<ClientClanActivenessAwardDesc> m_ClanActivenessAwardList;

	private List<ClientClanActivenessAwardDesc> m_ClanPersonalActivenessAwardList;

	private uint m_MyClanPersonalActiveness;

	private uint m_PersonalActivenessFromGemsCost;

	private List<ClanActiveShowDesc> m_ClanActiveShowList;

	private bool m_ClanActiveShowListSorted;

	private long m_NextClanRefreshTime;

	private bool m_HasPromotionRequest;

	public static int CLAN_TAG_MAX_SHOW;

	private CSClanPrivilegeRecordsRes m_ClanPrivilegeRecords;

	private List<ClanInfo> m_FriendClanList;

	private Dictionary<ulong, ClanInfo> m_DictClanIdToClanInfo;

	private Dictionary<ulong, ClanInfo> m_DictClanIdToAssistClanInfo;

	private HashSet<ulong> m_HashClanApplyID;

	private int m_FriendClanSelectIdx;

	private bool m_CanApplyDeputyCaptain;

	private Dictionary<uint, string> newsTypeDict;

	public const uint PropID_ClanListUpdate = 2u;

	public const uint PropID_GetClanInfo = 4u;

	public const uint PropID_MemberListUpdate = 8u;

	public const uint PropID_ClanApplicationUpdate = 16u;

	public const uint PropID_CreateClanSuccess = 32u;

	public const uint PropID_ClanJoinError = 64u;

	public const uint PropID_QuitClan = 128u;

	public const uint PropID_ClanWarHackerPunishmentUpdate = 256u;

	public const uint PropID_AcceptJoinClanSuccess = 512u;

	public const uint PropID_ClanInfoUpdate = 1024u;

	public const uint PropID_ApplyDeputyCaptainSuccess = 2048u;

	public const uint PropID_CanApplyDeputyCaptain = 4096u;

	public const uint PropID_DeputyCaptainFailed = 8192u;

	public const uint PropID_GetClanActivenessClaimedInfo = 16384u;

	public const uint PropID_GetClanPersonalActivenessClaimedInfo = 32768u;

	public const uint PropID_ClanAndPersonalActivenessAwardClaimed = 65536u;

	public const uint PropID_ClanBadgeUpdate = 262144u;

	public const uint PropID_ClanUnlockBadge = 524288u;

	public const uint PropID_NotifyErrorMessage = 1048576u;

	public const uint PropID_NotifyNormalMessage = 2097152u;

	public const uint PropID_ExtendScale = 8388608u;

	public const uint PropID_GetPrivilegeRecord = 16777216u;

	public const uint PropID_ClaimPrivilegeRecord = 33554432u;

	public const uint PropID_GetLuckyBagsInfo = 67108864u;

	public const uint PropID_DrawClanLuckyBag = 134217728u;

	public const uint PropID_GetClanNews = 268435456u;

	public const uint PropID_GetClanRecommendFriends = 536870912u;

	public const uint PropID_ClanInfoUpdated = 1073741824u;

	public static readonly uint INVALUED_CLANID;

	public static readonly uint DEFAULT_CLAN_BADGE_ID;

	public static readonly uint DEFAULT_CLAN_FRAME_ID;

	public static readonly int CLAN_ACTIVE_MEMBER_THRESHOLD;

	public static int MAX_CLAN_LEVEL;

	private bool m_HasGetMembers;

	private ulong _003CClanJoiningBoxAccountId_003Ek__BackingField;

	private ulong m_GetMembersTimestamp;

	private bool m_HasActivityTriggerSinceLogin;

	private bool m_DuringRequestMembers;

	private bool m_DuringDrawLuckyBag;

	public ulong m_FilterEndTimeStamp;

	public ulong m_RefreshEndTimeStamp;

	public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

	public const string CLAN_SETTING_NEW = "CLAN_SETTING_NEW";

	public string CLAN_MALL_GUIDE_KEY;

	private const string CLAN_EDIT_REGION_KEY = "CLAN_EDIT_REGION_KEY_{0}";

	private const string CLAN_EIDT_BADGE_KEY = "CLAN_EIDT_BADGE_KEY_{0}";

	private const string CLAN_EDIT_TAG_KEY = "CLAN_EDIT_TAG_KEY_{0}";

	public const string CLAN_MAIN_TAG_KEY = "CLAN_MAIN_TAG_KEY_{0}";

	public const string CLAN_PRIVILEGE_WEEKLY_REMAIN = "CLAN_PRIVILEGE_WEEKLY_REMAIN_{0}";

	public const string CLAN_PRIVILEGE_FIRST_SHOW = "CLAN_PRIVILEGE_FIRST_SHOW_{0}";

	public const string CLAN_PRIVILEGE_BUBBLE_SHOW = "CLAN_PRIVILEGE_BUBBLE_SHOW_{0}_{1}";

	public const uint MAX_HLCANTINAERCONTAIN = 2u;

	public const uint CLAN_EMOTESHOWID = 1200000001u;

	public bool AutoShowedLuckyBag;

	private int m_NewLuckyBagCnt;

	private List<ClanInfo> m_FilterList;

	private bool m_HasRequestCreateClan;

	private bool m_HasModifyClanBadge;

	private const ulong REQUEST_INFO_CD = 180uL;

	private ulong m_LastRequestFriendClanInfoTimeStamp;

	private ulong m_LastRequestRecommendFriendTimeStamp;

	private const ulong REQUST_RECOMMEND_INFO_CD = 5uL;

	private bool m_HasRequestFriendClanInfo;

	private bool m_IsAutoGetCountry;

	private bool m_IsAutoGetProvince;

	private bool m_IsAutoGetCity;

	private bool m_IsAutoLoacteOpen;

	private bool m_NeedSetClanLocationByPlayer;

	private BaseLeaderBoardAreaData m_ClanAreaData;

	private List<ClanMember> m_SelfTopClanMemberList;

	private bool m_HasGetClanMemberInfo;

	public uint CUSTOM_BADGE_ID;

	private ClanDiamondAwardSettingDesc m_ClanDiamondAwardSettingDesc;

	public bool IsGettingRandomClanList;

	private bool m_HasRequestApproveJoinClanInvitation;

	private uint m_BatchDrawLuckyBagMaxCounts;

	private bool m_ReachBatchDrawLuckyBagMaxCounts;

	private bool _003CReachSmallLuckBagDrewCountToday_003Ek__BackingField;

	private List<ClanActivenessRecord> m_WeeklyActivenessRecords;

	private Dictionary<ulong, List<GuildWarTitleRecordInfo>> m_ClanId2GuildWarTitleDict;

	private List<ClanLeaderboardItem> m_RegionLeaderBoard;

	private List<ClanLeaderboardItem> m_GlobalLeaderBoard;

	private bool HasRequestClanHonorLeaderBoard;

	private Dictionary<string, string> m_ErrorMsgDic;

	public static readonly uint MAX_CLAN_WAR_MEMBER_CNT;

	public static readonly ulong LEAVE_JOIN_CLAN_WAR_INTERVAL;

	public static readonly float CLAN_WAR_LOBBY_NOTICE_CD;

	public static readonly ulong CLAN_WAR_INVITE_INTERVAL;

	public static readonly ulong CLAN_WAR_TRANSFER_INTERVAL;

	public static readonly ulong CLAN_WAR_KICK_INTERVAL;

	public static readonly ulong CLAN_LUCKY_BAG_NOTICE_CD;

	private Dictionary<uint, ClanLuckyBagInfoDesc> m_DictClanBigLuckyBagInfo;

	private bool m_IsInClanNavigation;

	private bool m_IsDuringReadyStatus;

	private ulong m_NewMemberId;

	private bool m_ShouldSingleRewardTagVfxShow;

	private bool m_HasFriendClanInfoRequested;

	private Dictionary<ulong, List<FriendAccountInfo>> m_FriendClanIdToFriendInfo;

	private List<ulong> m_NeedRequestFriendClanId;

	private Dictionary<ulong, ulong> m_DictFriendIdToClanId;

	private List<FriendAccountInfo> m_ClanInviteRecommendInfoList;

	private List<ClanBadgeItemInfo> ClanTotalBadgeItemList => null;

	private Dictionary<uint, ClanBadgeItemInfo> ClanTotalBadgeItemDic => null;

	private Dictionary<uint, ClanBadgeItemInfo> ClanOldBadgeItemDic => null;

	public List<ClanNews> MyClanNews => null;

	public CSClanPrivilegeRecordsRes ClanPrivilegeRecords => null;

	public bool HasPromotionRequest => false;

	public Dictionary<ulong, ClanInfo> DictClanIdToClanInfo => null;

	public int FriendClanSelectIdx
	{
		set
		{
		}
	}

	public bool HasReadApplyDeputyCaptainRedDot
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanApplyDeputyCaptain
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasGetMembers
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool GetMembersIsColding => false;

	public ulong ClanJoiningBoxAccountId
	{
		get
		{
			return _003CClanJoiningBoxAccountId_003Ek__BackingField;
		}
		set
		{
			_003CClanJoiningBoxAccountId_003Ek__BackingField = value;
		}
	}

	public List<ClanInfo> FilterList => null;

	public int NewLuckyBagCnt
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public ulong MyClanID => 0uL;

	public EClanRole MyClanRole => EClanRole.None;

	public bool IsAutoGetCountry => false;

	public bool IsAutoGetProvince => false;

	public bool IsAutoGetCity => false;

	public bool IsAutoLoacteOpen => false;

	public bool NeedSetClanLocationByPlayer => false;

	public BaseLeaderBoardAreaData ClanAreaData => null;

	public string ClanName => null;

	public ClanInfo MyClanInfo => null;

	public List<ClanMember> ClanMemberList => null;

	public List<ClanMember> SelfTopClanMemberList => null;

	public List<ClanMember> OnlineClanMemberList => null;

	public int ClanMemberNum => 0;

	public List<ClanInfo> ClanList => null;

	public List<UnlockedClanBadgeInfo> UnLockClanBadgeInfo => null;

	public uint ClanBadgeID => 0u;

	public uint ClanFrameID => 0u;

	public List<ClientClanActivenessAwardDesc> ClanActivenessAwardList => null;

	public List<ClientClanActivenessAwardDesc> ClanPersonalActivenessAwardList => null;

	public uint MyClanPersonalActiveness
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint PersonalActivenessFromGemsCost
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<ClanActiveShowDesc> ClanActiveShowList => null;

	public long NextClanRefreshTime => 0L;

	public bool HasGetClanMemberInfo => false;

	public ClanDiamondAwardSettingDesc ClanDiamondAwardSettingDesc => null;

	public List<ClanApplicationAndInvitationInfo> ClanApplicationList => null;

	public Dictionary<ulong, bool> ClanApplyStatus => null;

	public uint GoldCost => 0u;

	public uint DiamondCost => 0u;

	public bool ReachSmallLuckBagDrewCountToday
	{
		get
		{
			return _003CReachSmallLuckBagDrewCountToday_003Ek__BackingField;
		}
		private set
		{
			_003CReachSmallLuckBagDrewCountToday_003Ek__BackingField = value;
		}
	}

	public List<ClanActivenessRecord> WeeklyActivenessRecords => null;

	public List<ClanLuckyBagInfoDesc> ClanLuckyBagInfoDescList => null;

	public bool ShouldSingleRewardTagVfxShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong NewMemberId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public bool IsInClanNavigation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDuringReadyStatus
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasFriendClanInfoRequested
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Dictionary<ulong, List<FriendAccountInfo>> FriendClanIdToFriendInfo => null;

	public Dictionary<ulong, ulong> DictFriendIdToClanId => null;

	public List<FriendAccountInfo> ClanInviteRecommendInfoList => null;

	public ClanInfo GetClanInfoByClanId(ulong clanId)
	{
		return null;
	}

	public ClanInfo GetAssistClanInfoByClanId(ulong clanId)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public ClanBadgeItemInfo GetBadgeItemInfoByID(uint id)
	{
		return null;
	}

	public ClanBadgeItemInfo GetOldBadgeItemInfoByID(uint id)
	{
		return null;
	}

	public string GetSpriteNameByBadgeID(uint badgeID, bool isSmall = false)
	{
		return null;
	}

	public string GetInGameSpriteNameByBadgeID(uint badgeID, bool isSmall = false)
	{
		return null;
	}

	public string GetSpriteNameByOldBadgeID(uint badgeID, bool isSmall = false)
	{
		return null;
	}

	public void ProcessClanBadgeItemDic(CSVAsyncDataMap<uint, ClanBadgeInfoData> dict)
	{
	}

	public void ProcessClanBadgeItemList(CSVAsyncDataMap<uint, ClanBadgeInfoData> dict)
	{
	}

	public Dictionary<uint, ClanBadgeItemInfo> GetClanTotalBadgeItemDic()
	{
		return null;
	}

	public List<ClanBadgeItemInfo> GetClanTotalBadgeInfoList()
	{
		return null;
	}

	private void SortTotalBagdeInfoList()
	{
	}

	public bool IsManager()
	{
		return false;
	}

	public bool IsMyClanMemberById(ulong accountId)
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

	public override void Logout(object[] data)
	{
	}

	public void ClearLuckyBagData()
	{
	}

	public void SetClanApplicationDataRead()
	{
	}

	public string GetKeyByDayOfWeek(DayOfWeek day)
	{
		return null;
	}

	public void RemoveDataFromClanApplicationList(ulong applicantID)
	{
	}

	public void AddDataToReadClanApplicationList(ulong applicantID)
	{
	}

	public void RequestReadClanApplicationList()
	{
	}

	public void RequestExchangeClanBadge(uint exchangeItemID)
	{
	}

	public void RequestApplyDeputyCaptain()
	{
	}

	public void RequestClanList(proto.EClan.ClanMainType mainType = proto.EClan.ClanMainType.ClanMainType_REGION, uint areaId = 0u, uint clanLevel = 1u, uint[] tags = null, EClanApproval entry_type = EClanApproval.All, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void SetClaimClanRaceAwardTime()
	{
	}

	public void SearchClanList(ulong clanid)
	{
	}

	public void GetClanInfoByClanIdForQRScan(ulong clanid, Vector3 position)
	{
	}

	public void ProcessClanInfoReq(CSClanInfoBundleRes res)
	{
	}

	public void ProcessClanListRankMapping()
	{
	}

	public void ProcessMyClanRankMapping()
	{
	}

	public void SearchClanList(string keyword)
	{
	}

	public void RequestMyClanInfo(uint httpOp = 0u, Action suc = null, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void RequestMyClanInfoInternal(ulong clanid, uint httpOp = 0u, Action suc = null, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void RefreshMyRoleOnGetClanInfo()
	{
	}

	private void OnGetMyClanInfoSuccess(ClanInfo res, Action suc = null)
	{
	}

	private void RefreshClanEditRedDot()
	{
	}

	private void RefreshPrivilegeRedDot()
	{
	}

	public void RequestCreateClan(string name, string slogan, proto.EInventory.CurrencyType currency_type, uint entry_type, uint areaId, bool sendRecruitToWorld = false, uint entry_level = 0u, uint entry_rank = 0u, uint entry_csrank = 0u, uint clan_badge_id = 1u, List<uint> tags = null)
	{
	}

	public void OperateClan(EClanOperation operate, ulong playerid)
	{
	}

	public void DismissClan()
	{
	}

	private void CheckSetProtoGetBackpackCacheDirty()
	{
	}

	public void ClanDismissNtf()
	{
	}

	public bool ReturnToLobby()
	{
		return false;
	}

	public void AddMyActiveness(uint activeness)
	{
	}

	public void RequestMemberList(bool forceUpdate = true, object[] inviteData = null, bool refreshPresent = true, bool forcePresence = false)
	{
	}

	public void RequestActivityTrigger()
	{
	}

	public void RequesetClanmemberPresence(bool force = false)
	{
	}

	internal void RefreshMemberPresences(PresenceListRes resData)
	{
	}

	public void ModifyClanInfo(string announcement, string slogan, uint entryType, uint areaId, uint playStyle, uint entry_level = 0u, uint entry_rank = 0u, uint entry_cs_rank = 0u, uint[] tags = null, bool use_custom_badge = false)
	{
	}

	public void SetClanArea(uint areaId)
	{
	}

	public void ModifyClanBadge(uint badge_id, ClanIconType type, bool CloseWindow)
	{
	}

	public void ModifyClanName(string name)
	{
	}

	public void ExtendClanScale()
	{
	}

	public void RequestClanApplication(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public bool IsPlayerRecruited(ulong playerid)
	{
		return false;
	}

	public void InviteToClan(ulong playerid, proto.EClan.InvitationType inviteType)
	{
	}

	public void RequestApproveJoinClanApplication(ulong inviterId, ulong inviteeId, bool needRefreshAssist = false)
	{
	}

	private void RemoveInvite(ulong inviteeId, bool needRequest = true, bool needRefreshAssist = false)
	{
	}

	public void RequestDeclineJoinClanInvitation(ulong inviterId, ulong inviteeId, bool needRefreshAssist = false)
	{
	}

	public void RequestAcceptClanInvitation(ulong inviterid, ulong clanid, MailInfo mailInfo = null, bool needRefreshAssist = false)
	{
	}

	public void RequestApplyForJoinClan(ulong clanid, proto.EClan.ApplicationType type, uint entryType = 0u)
	{
	}

	private void SetApplyRedDotCount()
	{
	}

	private bool HasNewApplyRequset()
	{
		return false;
	}

	public void UpdateClanApplyIDs()
	{
	}

	public void OnReceiveJoinClanTcp(ApproveInvitationReq ntf_ApproveInvitationReq)
	{
	}

	public void OnReceiveClanGuildWarHackerPunishmentNtf(GuildWarHackerPunishNtf ntf_ClanGuildWarHackerPunishment)
	{
	}

	public void ExitClan(Action suc = null, QuitReason reason = QuitReason.None)
	{
	}

	public bool PermitClaim()
	{
		return false;
	}

	public void RequestClanLuckyBagsInfo(ulong clan_id, bool isRefreshRequest = false)
	{
	}

	public bool CanRequestClanLuckyBagInfo(bool isRefreshRequest = false)
	{
		return false;
	}

	public void RequestDrawAllClanLuckyBag(List<ulong> alreadyDisposeSuccessLuckyBag, List<ulong> alreadyDisposeExistLuckyBag, bool needResend = false)
	{
	}

	private RewardWndCfg GetRewardWndCfg_ByBatchDrawLuckyBagResult(CSBatchDrawClanLuckyBagRes data)
	{
		return null;
	}

	private void InitClanDataToAssist(bool needRefreshAssistView)
	{
	}

	private void ShowBatchBrawLuckyBagTips(List<ulong> curDisposeSuccessLuckyBag)
	{
	}

	public bool NeedShowClaimAllBtn()
	{
		return false;
	}

	public void RequestDrawClanLuckyBag(ClanLuckyBag bag)
	{
	}

	private bool IsDrawedLuckyBag(ulong bag_id)
	{
		return false;
	}

	public LuckyBagState GetLuckyBagState(ClanLuckyBag bag)
	{
		return LuckyBagState.None;
	}

	public void SortLuckyBagList()
	{
	}

	private int SortLuckyBagList(ClanLuckyBag x, ClanLuckyBag y)
	{
		return 0;
	}

	public void FilterLuckyBagList()
	{
	}

	public bool HasUnClamiedLucykBag()
	{
		return false;
	}

	private void AddNewSmallLuckyBag(ClanLuckyBag luckyBag)
	{
	}

	public void AddNewLuckyBag(NewLuckyBagList luckyBagList)
	{
	}

	public void UpdateLuckyBagTipsNum()
	{
	}

	public bool IsFreezedTime()
	{
		return false;
	}

	public bool IsLuckyBagSwitchOn()
	{
		return false;
	}

	private bool IsExpiredLuckyBag(ClanLuckyBag luckyBag)
	{
		return false;
	}

	public ulong CalculateLucykBagExpirationTime(ClanLuckyBag lucykBag)
	{
		return 0uL;
	}

	private void MarkLuckyBagAsClaimed(ulong bag_id)
	{
	}

	public void RequestMyClanNews()
	{
	}

	public string GetNewsStringFromNewsType(proto.EClan.NewsType type, ulong accountId, EClanRole memberType, uint level)
	{
		return null;
	}

	public void UpdateClanMallTipsNum()
	{
	}

	public DayOfWeek IntegerToDayOfWeek(uint weekday)
	{
		return DayOfWeek.Sunday;
	}

	public uint DayOfWeekToInteger(DayOfWeek weekday)
	{
		return 0u;
	}

	public bool IsClanApplied(ulong clanID)
	{
		return false;
	}

	public int GetOnlineNum()
	{
		return 0;
	}

	public void TriggerVisitNewSetting()
	{
	}

	public bool CheckHasShowNewSetting()
	{
		return false;
	}

	public ClanMember FindClanMemberByID(ulong accountID)
	{
		return null;
	}

	public bool IsClanMember(ulong accountID)
	{
		return false;
	}

	public void ClearClanData()
	{
	}

	private void ResetBagdeDataInfo()
	{
	}

	public void ClearAll()
	{
	}

	public void RefreshClanInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void NotifyErrorMessage(object[] param)
	{
	}

	private void NotifyErrorMessageWithParam(object[] param)
	{
	}

	private string GetErrorMsgKey(string errormsgS)
	{
		return null;
	}

	public ClanMember GetMyClanMemeberInfo()
	{
		return null;
	}

	public ClanMember FindDeputyCaptain()
	{
		return null;
	}

	public ClanMember GetClanMemberById(ulong id)
	{
		return null;
	}

	public List<ClanMember> SearchClanMemberInClientData(string info, List<ClanMember> tarClanMembers = null)
	{
		return null;
	}

	public void SetDeputyCaptain(ulong deputyCaptainId)
	{
	}

	public void RequestClanMainPageInfo()
	{
	}

	public List<ClanMember> GetBiggestPreweeklyActivenessMembers(int rankNum = 3)
	{
		return null;
	}

	public void SetClanMemberClanWarData(List<GuildWarMemberInfo> data)
	{
	}

	public List<GuildWarTitleRecordInfo> GetClanWarHistoryTitleListByClanId(ulong clanId)
	{
		return null;
	}

	public void RequestClanActivenessLeaderBoard()
	{
	}

	private void RequestClanRegionHonorLeaderBoard(CSLeaderboardReq req)
	{
	}

	private void RequestClanGlobalHonorLeaderBoard(CSLeaderboardReq req)
	{
	}

	public ClanLeaderboardItem GetRegionLeaderBoardItem(ulong clanId)
	{
		return null;
	}

	public ClanLeaderboardItem GetGlobalLeaderBoardItem(ulong clanId)
	{
		return null;
	}

	public void RequestClanWarTitleRecord(ulong clanId)
	{
	}

	public void ProcessClanLuckyBagInfo(CSClanLuckyBagInfoDescRes res)
	{
	}

	private void CalcMyLuckyBagPoints()
	{
	}

	public ClanLuckyBagInfoDesc GetLuckyBagInfoDescByLevel(uint level)
	{
		return null;
	}

	public void ProcessClanActivenessAwardDesc(List<ClanActivenessAwardDesc> clanActivenessAwardDesc)
	{
	}

	public void ProcessClanActiveShowDesc(List<ClanActiveShowDesc> descs)
	{
	}

	public List<ClientClanActivenessAwardDesc> GetClanActivenessAwardDescs(uint curClanLevel)
	{
		return null;
	}

	public List<ClientClanActivenessAwardDesc> GetClanPersonalActivenessAwardDescs(uint curClanLevel)
	{
		return null;
	}

	public void UpdateClanActivenessAwardTipsNum()
	{
	}

	public void UpdateClanPersonalActivenessAwardTipsNum()
	{
	}

	public void RequestClanActivenessAwardClaimedInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestClaimClanActivenessAward(List<ClientClanActivenessAwardDesc> needClaimAwardDescs)
	{
	}

	private void OnClanActiveWndClosed()
	{
	}

	public void RequestClanPersonalActivenessAwardClaimedInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestClaimClanPersonalActivenessAward(List<ClientClanActivenessAwardDesc> needClaimAwardDescs)
	{
	}

	public List<ClientClanActivenessAwardDesc> GetCanClaimedClanActivenessAward()
	{
		return null;
	}

	public List<ClientClanActivenessAwardDesc> GetCanClaimedClanPersonalActivenessAward()
	{
		return null;
	}

	private void SetMyClanWeekId()
	{
	}

	public void GetFriendClanList(bool isShuffle = false, bool forceNotify = false)
	{
	}

	public void RequestGetClanInfoByClanId(ulong clanId)
	{
	}

	public void BatchGetAssistClanInfoByClanIDs(List<ulong> clanIds, bool needRefreshAssist = false, bool needUpdateAssistData = false)
	{
	}

	public void BatchGetClanInfoByClanIDs(List<ulong> clanIds, bool isShuffle, bool forceNotify)
	{
	}

	public void ProcessFriendAssistClanInfoReq(CSClanInfoBundleRes res)
	{
	}

	public void ProcessFriendClanInfoReq(CSClanInfoBundleRes res)
	{
	}

	public void DictClanIdToAssistClanInfoAddItem(ClanInfo clanInfo)
	{
	}

	public void DictClanIdToClanInfoAddItem(ClanInfo clanInfo)
	{
	}

	public void SortClanRecList(List<ClanInfo> clanList)
	{
	}

	private void ComputeClanListPriority(List<ClanInfo> clanList)
	{
	}

	public void ProcessClanInfoFilter(uint clanAreaId, uint clanLevel, List<uint> clanTags, EClanApproval approvalState, uint playerLevel, uint brRank, uint csRank)
	{
	}

	private bool CheckCanClanDisplay(ClanInfo info, uint clanAreaId, uint clanLevel, List<uint> clanTags, EClanApproval approvalState, uint playerLevel, uint brRank, uint csRank)
	{
		return false;
	}

	private List<ClanInfo> GetFilteredFriendClanInfo(List<ClanInfo> clanList, uint clanAreaId, uint clanLevel, List<uint> clanTags, EClanApproval approvalState, uint playerLevel, uint brRank, uint csRank)
	{
		return null;
	}

	private void Shuffle(List<ClanInfo> infoList)
	{
	}

	public void ShuffleFriendClanList()
	{
	}

	public void ClanPromotionPurchasing()
	{
	}

	public string GetClanLevelRuleDesc(string key)
	{
		return null;
	}

	public void ProcessClanDiamondAwardSettingDesc(ClanDiamondAwardSettingDesc diamondAwardSettingDesc)
	{
	}

	public bool CheckHasPlayRecord()
	{
		return false;
	}

	public bool CheckClanPrivilegeIsExpire()
	{
		return false;
	}

	public bool CheckIsClanPrivilegeItemID(uint itemID)
	{
		return false;
	}

	public bool CanBuyClanPrivilege()
	{
		return false;
	}

	public long GetClanPrivilegeRemainTimeStamp()
	{
		return 0L;
	}

	public long GetWaitClanPrivilegeTimeStamp()
	{
		return 0L;
	}

	public bool CheckClanPrivilegeBubbleNeedShow()
	{
		return false;
	}

	public void RequestClanPrivilegeRecords(bool isForce = false)
	{
	}

	public void RequestClanInviteRecommend(bool isForce = false)
	{
	}

	public void RequestClaimClanPrivilegeAward()
	{
	}

	private void AddEmojiToClanMessage()
	{
	}

	private bool CheckEmoteCanReply(ClanTrendMsgInfo trendInfo, uint emojiID)
	{
		return false;
	}

	private bool CheckClanPrivilegeRecordValid()
	{
		return false;
	}

	public void UpdateClanPrivilegeExpireTime(long expireTime)
	{
	}

	public bool CheckPrivilegeIsEquipped()
	{
		return false;
	}

	public void EquipClanPrivilege()
	{
	}

	public void UpdateClanMemberPrivilegeTime(ulong accountId, long expireTime)
	{
	}

	public string GetClanHackerRemindDetail(bool isMail = false)
	{
		return null;
	}

	private void _003CRequestReadClanApplicationList_003Eb__238_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestExchangeClanBadge_003Eb__239_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestApplyDeputyCaptain_003Eb__240_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestClanList_003Eb__242_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CSearchClanList_003Eb__244_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CSearchClanList_003Eb__249_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CDismissClan_003Eb__258_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestActivityTrigger_003Eb__264_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CExtendClanScale_003Eb__271_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestMyClanNews_003Eb__317_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestClanRegionHonorLeaderBoard_003Eb__352_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClanGlobalHonorLeaderBoard_003Eb__353_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClanActivenessAwardClaimedInfo_003Eb__394_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClanPersonalActivenessAwardClaimedInfo_003Eb__397_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CBatchGetClanInfoByClanIDs_003Eb__416_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CClanPromotionPurchasing_003Eb__428_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestClanPrivilegeRecords_003Eb__441_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClanInviteRecommend_003Eb__442_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClaimClanPrivilegeAward_003Eb__443_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
