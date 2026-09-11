using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelFriends : UIBaseModel
{
	public enum ENearbyPlayerRefreshSource
	{
		Manual,
		Auto
	}

	public class NearbyPlayerInfo
	{
		public AccountInfoBasic BasicInfo;

		public double Distance;

		public proto.ELbs.HideDistance HideDistance;

		public proto.EPresence.AccountPresence Presence;

		public proto.EPresence.SocialPresence SocialPresence;

		public NIKKALKPIBO PresenceGameMode;

		public DLBMPCCFKKM PresenceMatchMode;

		public uint PresenceMapID;

		public long UpdateTime;

		public ulong GroupId;

		public uint GroupMemberCnt;

		public uint GroupMode;

		public static implicit operator BaseProfileInfo(NearbyPlayerInfo playerData)
		{
			return null;
		}
	}

	public enum ENearbyRankDataType
	{
		BRRank,
		CSRank,
		PersonalShowInfo
	}

	public class RequestCounter
	{
		public HashSet<ulong> RequestedIds;

		public HashSet<ulong> ReceivedIds;

		public void OnReceived(ulong accountId)
		{
		}

		public bool IsCompleted()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	public class NearbyDisplayDataRequest
	{
		public bool PresenceReceived;

		public List<ulong> RequestedAccountIds;

		public Dictionary<ENearbyRankDataType, RequestCounter> RankCounters;

		public void OnRankDataReceived(ENearbyRankDataType rankType, ulong accountId)
		{
		}

		public bool AllCompleted()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	public enum EFriendRequestOption
	{
		None = 0,
		OnlyID = 2,
		FriendInfo = 6,
		FriendPresence = 14,
		FriendStats = 30
	}

	private enum EMatchLevel
	{
		Exact,
		Fuzzy
	}

	private enum EOnlineStatus
	{
		Online,
		Offline
	}

	private enum EFieldType
	{
		Alias,
		Uid,
		Nickname
	}

	public class TeamMateSocialInfo
	{
		public ulong accountID;

		public proto.ESocial.Gender Gender;

		public int friendCount;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<FriendAccountInfo> _003C_003E9__230_1;

		public static Predicate<FriendAccountInfo> _003C_003E9__232_1;

		public static Action<HttpErrorCode, object> _003C_003E9__281_0;

		public static Predicate<TeammateStats> _003C_003E9__318_0;

		public static Comparison<TeammateStats> _003C_003E9__318_1;

		public static Predicate<uint> _003C_003E9__319_0;

		public static Predicate<uint> _003C_003E9__319_2;

		public static Comparison<KeyValuePair<FriendAccountInfo, int>> _003C_003E9__329_0;

		internal bool _003CRequestGameFriendIDList_003Eb__230_1(FriendAccountInfo i)
		{
			return false;
		}

		internal bool _003CRefreshGameFriendList_003Eb__232_1(FriendAccountInfo i)
		{
			return false;
		}

		internal void _003CRequestLeadinPlatformFriends_003Eb__281_0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRecommendFriendAfterMatch_003Eb__318_0(TeammateStats teammate)
		{
			return false;
		}

		internal int _003CRecommendFriendAfterMatch_003Eb__318_1(TeammateStats a, TeammateStats b)
		{
			return 0;
		}

		internal bool _003CRecommendMVPGroupAfterMatch_003Eb__319_0(uint type)
		{
			return false;
		}

		internal bool _003CRecommendMVPGroupAfterMatch_003Eb__319_2(uint type)
		{
			return false;
		}

		internal int _003CSearchFriendInClientData_003Eb__329_0(KeyValuePair<FriendAccountInfo, int> a, KeyValuePair<FriendAccountInfo, int> b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_0
	{
		public UIModelFriends _003C_003E4__this;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		internal bool _003Cget_RecentPlayerInfoList_003Eb__0(FriendAccountInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public UIModelFriends _003C_003E4__this;

		public string cmd;

		internal void _003CRequestNewBeeRecFriendList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass196_0
	{
		public UIModelFriends _003C_003E4__this;

		public ulong account_ID;

		public string alias;

		internal void _003CRequestSetFriendAlias_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass197_0
	{
		public UIModelFriends _003C_003E4__this;

		public ulong account_ID;

		internal void _003CRequestDelFriendAlias_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass206_0
	{
		public AccountInfoBasic info;

		internal bool _003CRequestCacheRecentPlayersInfo_003Eb__1(RecentPlayerInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public UIModelFriends _003C_003E4__this;

		public List<ulong> recommandPlayerIdList;

		public bool isAll;

		internal void _003CRequestRecommandPlayersInfo_003Eb__0(List<AccountInfoBasic> accountInfos)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_1
	{
		public AccountInfoBasic info;

		internal bool _003CRequestRecommandPlayersInfo_003Eb__1(FriendAccountInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass214_0
	{
		public FriendAccountInfo info;

		internal bool _003CAddRecentPlayersFrontEnd_003Eb__0(RecentPlayerInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass216_0
	{
		public UIModelFriends _003C_003E4__this;

		public List<AccountInfoBasic> accountInfoList;

		public Action<List<AccountInfoBasic>> onFinished;

		internal void _003CBatchGetAccountInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool isSilence;

		public bool firstLogin;

		public EFriendRequestOption requestOption;

		public bool forcePresence;

		internal void _003CRefreshAllFriendList_003Eb__0()
		{
		}

		internal void _003CRefreshAllFriendList_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass222_0
	{
		public PresenceListRes presenceRes;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		internal bool _003CRefreshRecommandAllPlayersPresence_003Eb__0(FriendAccountInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public PresenceListRes presenceRes;

		internal bool _003CRefreshRecommandSinglePlayersPresence_003Eb__0(FriendAccountInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass224_0
	{
		public PresenceListRes presenceRes;

		public int i;

		public Predicate<RecentPlayerInfo> _003C_003E9__0;

		internal bool _003CRefreshRecentPlayersPresence_003Eb__0(RecentPlayerInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass225_0
	{
		public PresenceListRes presenceRes;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		public Predicate<FriendAccountInfo> _003C_003E9__1;

		internal bool _003CRefreshFriendPresences_003Eb__0(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CRefreshFriendPresences_003Eb__1(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass226_0
	{
		public PresenceListRes presenceRes;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		public Predicate<FriendAccountInfo> _003C_003E9__1;

		internal bool _003CRefreshAddFriendPresence_003Eb__0(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CRefreshAddFriendPresence_003Eb__1(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass227_0
	{
		public PresenceListRes presenceRes;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		internal bool _003CRefreshSearchedPlayersPresences_003Eb__0(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass230_0
	{
		public UIModelFriends _003C_003E4__this;

		public CSGetFriendIDsReq req;

		public bool isFirstLogin;

		public Action afterRefreshAction;

		internal void _003CRequestGameFriendIDList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass231_0
	{
		public UIModelFriends _003C_003E4__this;

		public CSGetPlatformFriendListReq req;

		public bool isFirstLogin;

		public Action afterRefreshAction;

		internal void _003CRequestPlatformFriendIDList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass232_0
	{
		public UIModelFriends _003C_003E4__this;

		public CSGetFriendListReq req;

		public Action afterRefreshAction;

		public uint requestFlag;

		public bool forcePresence;

		internal void _003CRefreshGameFriendList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass233_0
	{
		public UIModelFriends _003C_003E4__this;

		public CSGetPlatformFriendListReq req;

		public uint requestFlag;

		public bool forcePresence;

		internal void _003CRefreshPlatformFriendList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelFriends _003C_003E4__this;

		public int i;

		public Predicate<FriendAccountInfo> _003C_003E9__0;

		internal bool _003CRefreshTotalFriendList_003Eb__0(FriendAccountInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool refreshAssistBubble;

		public bool needRefreshAssist;

		internal void _003CRefreshFriendRequestList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool needDispatch;

		internal void _003CRefreshBlackList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public UIModelFriends _003C_003E4__this;

		public uint propId;

		internal void _003CSearchAccount_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass251_0
	{
		public UIModelFriends _003C_003E4__this;

		public uint propId;

		public Action<AccountInfoBasic> processAccountInfo;

		internal void _003CSearchAccount_003Eb__0(AccountInfoBasic e)
		{
		}

		internal void _003CSearchAccount_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass254_0
	{
		public UIModelFriends _003C_003E4__this;

		public ulong accountId;

		internal void _003CRequestAccountInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_0
	{
		public UIModelFriends _003C_003E4__this;

		public Action callBack;

		internal void _003CGetRecommendedFriend_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_1
	{
		public FriendAccountInfo friendInfo;

		internal bool _003CGetRecommendedFriend_003Eb__1(FriendAccountInfo tmp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_2
	{
		public RecentPlayerInfo recentPlayer;

		internal bool _003CGetRecommendedFriend_003Eb__2(FriendAccountInfo tmp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_3
	{
		public FriendAccountInfo item;

		internal bool _003CGetRecommendedFriend_003Eb__3(FriendAccountInfo tmp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_4
	{
		public FriendAccountInfo recentTeammate;

		internal bool _003CGetRecommendedFriend_003Eb__4(FriendAccountInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_5
	{
		public FriendAccountInfo clanMember;

		internal bool _003CGetRecommendedFriend_003Eb__5(FriendAccountInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_6
	{
		public FriendAccountInfo commonFriend;

		internal bool _003CGetRecommendedFriend_003Eb__6(FriendAccountInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass259_7
	{
		public FriendAccountInfo item;

		internal bool _003CGetRecommendedFriend_003Eb__7(FriendAccountInfo tmp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass260_0
	{
		public UIModelLocalization locModel;

		public UIModelFriends _003C_003E4__this;

		public ENearbyPlayerRefreshSource source;

		internal void _003CRefreshNearbyPlayers_003Eb__0()
		{
		}

		internal void _003CRefreshNearbyPlayers_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass261_0
	{
		public UIModelFriends _003C_003E4__this;

		public ENearbyPlayerRefreshSource source;

		internal void _003CRequestNearbyPlayers_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass262_0
	{
		public UIModelFriends _003C_003E4__this;

		public ulong removee;

		internal void _003CRemoveFriendRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass272_0
	{
		public CSBatchRemoveFriendReq req;

		public UIModelFriends _003C_003E4__this;

		internal void _003CBatchRemoveFriends_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass273_0
	{
		public ulong addee;

		public EFriendAddFrom add_from;

		public UIModelFriends _003C_003E4__this;

		public uint booyah_times;

		public uint saving_times;

		public uint match_times;

		public bool need_slience;

		internal bool _003CAddFriendRequest_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}

		internal void _003CAddFriendRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass274_0
	{
		public UIModelFriends _003C_003E4__this;

		public ulong addee;

		internal void _003CRequestSetFavorFriendState_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestSetFavorFriendState_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass276_0
	{
		public UIModelFriends _003C_003E4__this;

		public CSFriendReq req;

		public bool need_slience;

		public bool needRefreshAssist;

		internal void _003CConfirmFriendRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass277_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool need_slience;

		public bool needRefreshAssist;

		internal void _003CDeclineFriendRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass278_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool need_slience;

		internal void _003CBlockPlayerRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass279_0
	{
		public UIModelFriends _003C_003E4__this;

		public bool need_slience;

		internal void _003CCancelBlockRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass282_0
	{
		public ulong read;

		internal bool _003CRequestReadFriendRequestList_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass283_0
	{
		public FriendRequestStats friendData;

		internal bool _003CSetAssistDataRead_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass300_0
	{
		public ulong account_id;

		internal bool _003CGetFriendInfo_003Eb__0(FriendAccountInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass301_0
	{
		public ulong accountID;

		internal bool _003CGetPlatformFriendInfo_003Eb__0(FriendAccountInfo friendInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass302_0
	{
		public ulong account_id;

		internal bool _003CBatchRemoveFriendsByAccountIDs_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CBatchRemoveFriendsByAccountIDs_003Eb__4(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CBatchRemoveFriendsByAccountIDs_003Eb__1(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CBatchRemoveFriendsByAccountIDs_003Eb__2(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CBatchRemoveFriendsByAccountIDs_003Eb__3(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass303_0
	{
		public ulong account_id;

		internal bool _003CRemoveFriendByAccountID_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRemoveFriendByAccountID_003Eb__4(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRemoveFriendByAccountID_003Eb__1(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CRemoveFriendByAccountID_003Eb__2(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CRemoveFriendByAccountID_003Eb__3(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass304_0
	{
		public FriendAccountInfo info;

		internal bool _003CAddFriendWithPresence_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CAddFriendWithPresence_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass314_0
	{
		public GroupMemberInfo member;

		internal bool _003CRefreshRecentTeamPlayers_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRefreshRecentTeamPlayers_003Eb__1(ClanMember x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass316_0
	{
		public GroupMemberInfo member;

		internal bool _003CRecommendFriendWhileInTeam_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}

		internal bool _003CRecommendFriendWhileInTeam_003Eb__1(ClanMember x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass316_1
	{
		public ulong id;

		internal bool _003CRecommendFriendWhileInTeam_003Eb__2(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass318_0
	{
		public ulong teamMate;

		internal bool _003CRecommendFriendAfterMatch_003Eb__2(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass319_0
	{
		public UIModelMatch modelMatch;

		internal bool _003CRecommendMVPGroupAfterMatch_003Eb__3(ulong item)
		{
			return false;
		}

		internal bool _003CRecommendMVPGroupAfterMatch_003Eb__1(TeammateStats item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass367_0
	{
		public ulong friendId;

		internal bool _003CGetCommonFriendsList_003Eb__0(FriendAccountInfo f)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass372_0
	{
		public FriendAccountInfo accountInfo;

		internal bool _003CSetFriendAccountInfoDetail_003Eb__0(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CSetFriendAccountInfoDetail_003Eb__1(FriendAccountInfo info)
		{
			return false;
		}

		internal bool _003CSetFriendAccountInfoDetail_003Eb__2(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public PresenceListRes presenceRes;
	}

	private sealed class _003C_003Ec__DisplayClass96_1
	{
		public int i;

		public _003C_003Ec__DisplayClass96_0 CS_0024_003C_003E8__locals1;

		internal bool _003CRefreshNearbyPlayersPresence_003Eb__0(NearbyPlayerInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_2
	{
		public int i;

		public _003C_003Ec__DisplayClass96_0 CS_0024_003C_003E8__locals2;

		internal bool _003CRefreshNearbyPlayersPresence_003Eb__1(NearbyPlayerInfo temp)
		{
			return false;
		}
	}

	public const string NEW_VERSION_AFTER_OB20 = "NEW_ACCOUNT_AFTER_OB20";

	private const string NewFriendTeamUpInviteDontShowTodayKey = "NewFriendTeamUpInviteDontShowToday";

	private InviteAbtestDesc m_InviteAbTestDesc;

	private NearbyFriendAddLog m_NearbyLog;

	private int m_CurRecentPlayersMatchTimes;

	private uint UnActiveFriendThresholdDays;

	private uint m_GameFriendCountLimit;

	private uint m_GameFriendVipCountLimit;

	private uint m_PrimeFrientCountAdditional;

	private List<FriendAccountInfo> m_FriendAccountInfoList;

	private List<FriendAccountInfo> m_GameFriendAccountInfoList;

	private List<FriendAccountInfo> m_PlatformFriendAccountInfoList;

	private List<FriendAccountInfo> m_FriendRequestAccountInfoList;

	private Dictionary<ulong, FriendRequestExtraInfo> m_DicFriendRequestExtraInfo;

	private List<ulong> m_AcceptedNewFriendList;

	private List<FriendAccountInfo> m_blackListAccountInfo;

	private List<FriendAccountInfo> m_OnlineFriendAccountInfoList;

	private List<FriendAccountInfo> m_SearchAccountResultList;

	private List<ulong> m_RequestedAndBlockedList;

	private List<FriendAccountInfo> m_FollowAccountInfoList;

	private List<ulong> m_FavorAccountIDs;

	private List<CSRecommendFriendsToFreshPlayerRes.Player> m_NewBeeRecFriendList;

	private ulong m_NewBeeRecFriendListRequestTime;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private const ulong NewBeeRecFriendListExpireTime = 900uL;

	private ulong m_NewBeeRecBtnCooldownStartTime;

	private List<FriendAccountInfo> m_UnActiveFriendsList;

	private HashSet<ulong> m_InGameNewFriendList;

	private HashSet<ulong> m_GameFriendExcludePlatform;

	private HashSet<ulong> m_InGameIgnoreAdder;

	private List<ulong> m_InGameFriendAdderList;

	private List<ulong> m_ReadFriendRequestList;

	private List<FriendAccountInfo> m_RecommendedFriendRecentTeammates;

	private List<FriendAccountInfo> m_RecommendedFriendClanMember;

	private List<FriendAccountInfo> m_RecommendedFriendCommon;

	private List<FriendAccountInfo> m_RecommendedFriendNoTag;

	private Dictionary<ulong, uint> m_DicRecommendCommonFriendNum;

	private ERecommendSource m_FriendRecommendSource;

	private List<NearbyPlayerInfo> m_NearbyPlayerInfoList;

	private float m_LastNearbyPlayerRefreshTime;

	private const int NEARBY_DISPLAY_COUNT = 5;

	private List<NearbyPlayerInfo> m_CurrentDisplayList;

	private NearbyDisplayDataRequest m_DisplayDataRequest;

	private Dictionary<ulong, float> dicFriendInviteTime;

	private Dictionary<ulong, float> dicFriendUgcShareTime;

	private Dictionary<ulong, float> dicFriendHudShareTime;

	private Dictionary<ulong, float> m_DictAccountIdToSquadTreasureShareTime;

	private Dictionary<ulong, float> dicFriendUGCInviteTime;

	private Dictionary<ulong, float> dicFriendUGCJoinTime;

	public Dictionary<ulong, string> m_FriendAliasDict;

	private bool m_HasRequestClanMemberList;

	private const int recommendedFriendAmount = 10;

	private const int recommendedFriendWithTagAmount = 5;

	private bool NeedRequestedRecommendedFriendInitData;

	public const uint MAXFAVORFRIENDSCNT = 20u;

	public const uint PropID_FriendListUpdate = 2u;

	public const uint PropID_FriendRequestListUpdate = 4u;

	public const uint PropID_SearchResultListUpdate = 8u;

	public const uint PropID_BlackListUpdate = 16u;

	public const uint PropID_RecentPlayers = 32u;

	public const uint PropID_SearchByConditionUpdate = 64u;

	public const uint PropID_FriendListUpdatePresence = 128u;

	public const uint PropID_AddFriendCachedUpdate = 256u;

	public const uint PropID_FriendAliasUpdate = 512u;

	public const uint PropID_FriendAliasSuccess = 1024u;

	public const uint PropID_RecommandPlayerAll = 4096u;

	public const uint PropID_RecommandPlayerSingle = 8192u;

	public const uint PropID_BatchGetAccountPlayerInfo = 16384u;

	public const uint PorpID_FriendsReachLimit = 32768u;

	public const uint PropID_NearbyPlayerListUpdate = 65536u;

	public const uint PropID_NearbyPlayerDisplayUpdate = 131072u;

	public const uint PropID_NewBeeRecFriendListUpdate = 262144u;

	private const uint FriendRequestFlag_ID = 2u;

	private const uint FriendRequestFlag_Info = 4u;

	private const uint FriendRequestFlag_Presence = 8u;

	private const uint FriendRequestFlag_Stats = 16u;

	public const uint FriendAddTag_Team = 2u;

	public const uint FriendAddTag_Clan = 4u;

	public const uint FriendAddTag_Friend = 8u;

	private const string RECOMMENDFRIENDMATCHCOUNT = "RECOMMENDFRIENDMATCHCOUNT_";

	private int m_MatchCount;

	private List<ulong> m_LastTeamMember;

	private bool m_EnterGame;

	private uint m_SearchPropID;

	private int m_blackListCount;

	private Dictionary<ulong, AccountInfoBasicCache> m_AccountInfoCache;

	public readonly Dictionary<int, List<ulong>> m_RecentPlayerIDDict;

	private readonly Dictionary<int, string> m_RecommandReasonDict;

	private Dictionary<ulong, uint> m_RecommandPlayerReasonDict;

	private List<RecentPlayerInfo> m_RecentPlayerInfoList;

	private List<FriendAccountInfo> m_RecommandPlayerInfoList;

	private List<FriendAccountInfo> m_TempRecentAccountInfoList;

	private readonly List<ulong> m_TempRecentPlayerIDs;

	private uint m_RequestedFriendFlags;

	private string m_SearchedStringCache;

	private ulong m_SearchedIDCache;

	private HashSet<object> m_PendingRequest;

	private HashSet<ulong> m_AddFriendCachedID;

	private Dictionary<ulong, RecentPlayerInfo> m_RecentPlayerNoAccountInfoDict;

	private Dictionary<ulong, ulong> m_AFKFriendNextInviteableTimestamp;

	private HashSet<ulong> m_RequestAccountInfoHashSet;

	private Dictionary<ulong, TeamMateSocialInfo> m_teamMateSocialInfo;

	private ulong m_showInvitePlayerID;

	public static string Friend_Request_Tips;

	public static string Friend_Lobby_Request_Tips;

	private List<MessageInviteChooseBoxData> m_FriendInviteDataList;

	private bool m_FriendInviteBlock;

	private ulong m_IgnorePlayerAddRequestId;

	private Dictionary<ulong, FriendAccountInfo> m_AssistExpiredTeamUpAccountInfos;

	private const string NEARBY_GUIDE_LOBBY_KEY = "NearbySearchGuide_Lobby_{0}";

	private const string NEARBY_GUIDE_ADDTAB_KEY = "NearbySearchGuide_AddTab_{0}";

	private const string NEARBY_GUIDE_BUTTON_KEY = "NearbySearchGuide_Button_{0}";

	public NearbyFriendAddLog NearbyLog => null;

	public int CurRecentPlayersMatchTimes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint PrimeFrientCountAdditional => 0u;

	public uint GameFriendCountLimit => 0u;

	public uint EvoPassLimitAddCount => 0u;

	public List<FriendAccountInfo> FriendAccountInfoList => null;

	public List<FriendAccountInfo> GameAccountInfoList => null;

	public List<FriendAccountInfo> FaceBookFriendAccoutInfoList => null;

	public List<FriendAccountInfo> FriendRequestAccountInfoList => null;

	public List<FriendAccountInfo> BlackListAccountInfo => null;

	public List<FriendAccountInfo> OnlineFriendAccountInfoList => null;

	public List<FriendAccountInfo> SearchAccountResultList => null;

	public List<ulong> RequestedAndBlockedList => null;

	public List<FriendAccountInfo> FollowAccoutInfoList => null;

	public List<ulong> FavorAccountIDs => null;

	public ulong NewBeeRecBtnCooldownStartTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public List<FriendAccountInfo> UnActiveFriendsList => null;

	public ERecommendSource FriendRecommendSource => ERecommendSource.None;

	public List<NearbyPlayerInfo> NearbyPlayerList => null;

	public NearbyDisplayDataRequest DisplayDataRequest => null;

	public int BlackListCount => 0;

	public Dictionary<int, string> RecommandReasonDict => null;

	public Dictionary<ulong, uint> RecommandPlayerReasonDict => null;

	public List<RecentPlayerInfo> RecentPlayerInfoList => null;

	public List<FriendAccountInfo> RecommandPlayerInfoList => null;

	public List<MessageInviteChooseBoxData> FriendInviteDataList => null;

	public bool FriendInviteBlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong IgnorePlayerAddRequestId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public Dictionary<ulong, FriendAccountInfo> AssistExpiredTeamUpAccountInfos => null;

	public bool IsFavorFriend(ulong accountID)
	{
		return false;
	}

	public List<NearbyPlayerInfo> TakeNearbyPlayersAndRequestDisplayInfo()
	{
		return null;
	}

	public List<NearbyPlayerInfo> GetNearbyPlayersDisplayList()
	{
		return null;
	}

	public string GetNearbyPlayerDistanceText(double distance)
	{
		return null;
	}

	private void RequestNearbyPlayersPresence()
	{
	}

	private void RequestNearbyPlayersPresenceForDisplay()
	{
	}

	public void RefreshNearbyPlayersPresence(PresenceListRes presenceRes)
	{
	}

	private void CheckAndNotifyDisplayDataComplete()
	{
	}

	private void LogEventTypeLBSNearbySearchRecommend()
	{
	}

	public void CheckNearbyDisplayDataComplete()
	{
	}

	public bool CheckFriendSetAliasCD(ulong friendId)
	{
		return false;
	}

	public ulong GetFriendSetAliasCDSeconds(ulong friendId)
	{
		return 0uL;
	}

	public void SetAFKFriendInviteCD(ulong friendId)
	{
	}

	public void SetAccountInviteTime(ulong accountID, float time)
	{
	}

	public void SetAccountUgcShareTime(ulong accountID, float time)
	{
	}

	public void SetAccountSquadTreasureShareTime(ulong accountID, float time)
	{
	}

	public void ClearAccountUgcShareTime()
	{
	}

	public void ClearAccountSquadTreasureShareTime()
	{
	}

	public void SetAccountHudShareTime(ulong accountID, float time)
	{
	}

	public void ClearAccountHudShareTime()
	{
	}

	public float GetAccountHudShareTime(ulong accountID)
	{
		return 0f;
	}

	public float GetAccountInviteTime(ulong accountID)
	{
		return 0f;
	}

	public float GetAccountUgcShareTime(ulong accountID)
	{
		return 0f;
	}

	public float GetAccountSquadTreasureShareTime(ulong accountID)
	{
		return 0f;
	}

	public void SetAccountUGCInviteTime(ulong accountID)
	{
	}

	public float GetAccountUGCInviteTime(ulong accountID)
	{
		return 0f;
	}

	public bool IsUGCInviteInCoolDown(ulong accountID)
	{
		return false;
	}

	public void SetAccountUGCJoinTime(ulong accountID)
	{
	}

	public float GetAccountUGCJoinTime(ulong accountID)
	{
		return 0f;
	}

	public bool IsUGCJoinInCoolDown(ulong accountID)
	{
		return false;
	}

	public bool CanShowUGCHalfwayJoin(FriendAccountInfo info)
	{
		return false;
	}

	public string GetFriendAlias(ulong accountID, bool forceUseFriendAlias = false)
	{
		return null;
	}

	public void GetFriendAlias(ulong accountID, ref string res)
	{
	}

	public string GetFriendAliasWithOutSymbol(ulong accountID)
	{
		return null;
	}

	private void RequestNewBeeRecFriendList()
	{
	}

	public List<CSRecommendFriendsToFreshPlayerRes.Player> GetNewBeeRecFriendList()
	{
		return null;
	}

	public int GetTotalFriendCount()
	{
		return 0;
	}

	public int GetRecentActiveFriendCount(uint withinDays)
	{
		return 0;
	}

	public void RequestSetFriendAlias(ulong account_ID, string alias)
	{
	}

	public void RequestDelFriendAlias(ulong account_ID)
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

	public static bool CheckIsFriendByRelationshipMask(uint mask)
	{
		return false;
	}

	public void SendInviteToGameLink(PlatformType platformType)
	{
	}

	public int LastInGameAddedRecentPlayersCount()
	{
		return 0;
	}

	public void AddRecentPlayersFrontEnd()
	{
	}

	public List<FriendAccountInfo> GetRecentAccoutInfoList()
	{
		return null;
	}

	public void RequestCacheRecentPlayersInfo(bool forceRefreshPresence)
	{
	}

	public void RequestRecommandPlayersInfo(List<ulong> recommandPlayerIdList, bool forceRefreshPresence, bool isAll = true, proto.EAccount.CallSignSrc callSignSrc = proto.EAccount.CallSignSrc.CallSignSrc_GAME_OVER)
	{
	}

	public void RefreshRecentPlayersPresence(bool forceUpdate = false, List<ulong> accounts = null)
	{
	}

	public bool IsShowResidentFriendList()
	{
		return false;
	}

	public void RefreshRecommandPlayersPresence(bool forceUpdate = false, List<ulong> accounts = null, bool isAll = true)
	{
	}

	public void AddRecentPlayers(ERecentPlayerType type, List<ulong> ids)
	{
	}

	public void AddRecentPlayers(ERecentPlayerType type, ulong[] ids)
	{
	}

	public void AddRecentPlayer(ERecentPlayerType type, ulong id)
	{
	}

	public void AddRecentPlayersFrontEnd(ERecentPlayerType type, ulong[] ids)
	{
	}

	public void BatchGetAccountInfo(ulong accountId, proto.EAccount.CallSignSrc callSignSrc)
	{
	}

	public void BatchGetAccountInfo(ulong[] accounts, proto.EAccount.CallSignSrc callSignSrc, Action<List<AccountInfoBasic>> onFinished = null)
	{
	}

	public AccountInfoBasic GetAccountInfoFromCache(ulong accountId)
	{
		return null;
	}

	public void RefreshAllFriendList(bool forceRefresh = false, bool isSilence = false, EFriendRequestOption requestOption = EFriendRequestOption.OnlyID, bool forcePresence = false, bool needPlatformFriend = true, HttpManager.Priority priority = HttpManager.Priority.Normal, bool firstLogin = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void ProcessServerData(CSGetAllFriendDescRes desc)
	{
	}

	public void RequestFriendInfosPresence(EPresenceListType type, ulong[] ids, bool forceUpdate = false)
	{
	}

	private void RequestRefreshFriendPresences(bool force = false)
	{
	}

	public void RefreshRecommandAllPlayersPresence(PresenceListRes presenceRes)
	{
	}

	public void RefreshRecommandSinglePlayersPresence(PresenceListRes presenceRes)
	{
	}

	public void RefreshRecentPlayersPresence(PresenceListRes presenceRes)
	{
	}

	public void RefreshFriendPresences(PresenceListRes presenceRes)
	{
	}

	public void RefreshAddFriendPresence(PresenceListRes presenceRes)
	{
	}

	public void RefreshSearchedPlayersPresences(PresenceListRes presenceRes)
	{
	}

	public void RefreshSearchedPlayersPresencesWithoutCondition(PresenceListRes presenceRes)
	{
	}

	public void RefreshSearchedPlayersPresencesWithCondition(PresenceListRes presenceRes)
	{
	}

	public void RequestGameFriendIDList(bool isSilence = false, Action afterRefreshAction = null, HttpManager.Priority priority = HttpManager.Priority.Normal, bool isFirstLogin = false, bool sendImmediately = false)
	{
	}

	public void RequestPlatformFriendIDList(bool isSilence = false, Action afterRefreshAction = null, HttpManager.Priority priority = HttpManager.Priority.Normal, bool isFirstLogin = false)
	{
	}

	public void RefreshGameFriendList(Action afterRefreshAction = null, bool isSilence = false, uint requestFlag = 8u, bool forcePresence = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool firstLogin = false, bool sendImmediately = false)
	{
	}

	public void RefreshPlatformFriendList(bool isSilence = false, uint requestFlag = 8u, bool forcePresence = false, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	private void RefreshTotalFriendList(uint requestFlag, bool forcePresence = false, bool FriendsHttpOk = false)
	{
	}

	public List<FriendAccountInfo> FriendsHasChampionshipTeam()
	{
		return null;
	}

	public static int SortFriendAccountInfo(FriendAccountInfo a, FriendAccountInfo b)
	{
		return 0;
	}

	public void RefreshFriendRequestList(bool forceRefresh = false, bool isSilence = false, bool needRefreshAssist = false, bool refreshAssistBubble = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void BatchRecordFriendRequestInfo(GetAccountFriendRequestListRes listRes)
	{
	}

	public void RecordFriendRequestInfo(ulong accountId, uint addFrom, uint commmonFriendsNum, uint booyahTimes = 0u, uint savingTimes = 0u, uint matchTimes = 0u, ulong[] commonFriendIds = null)
	{
	}

	public FriendRequestExtraInfo GetFriendRequestExtraInfoByAccountId(ulong accountId)
	{
		return null;
	}

	public string GetFriendRequestAddFromString(EFriendAddFrom addFrom, uint booyahTimes = 0u, uint savingTimes = 0u, uint matchTimes = 0u)
	{
		return null;
	}

	public void RecordAcceptedNewFriend(ulong accountid)
	{
	}

	public bool IsNewFriendTeamUpInviteDontShowToday()
	{
		return false;
	}

	public void SetNewFriendTeamUpInviteDontShowToday(bool dontShowToday)
	{
	}

	public void CheckAndRecommendNewFriend(FriendAccountInfo friend)
	{
	}

	public bool CanShowNewFriendTeamUpInvite(FriendAccountInfo friend)
	{
		return false;
	}

	public void RefreshBlackList(bool forceRefresh = false, bool isSilence = false, bool needDispatch = true)
	{
	}

	public void SearchAccount(string searchName, bool forceRefresh = false, uint propId = 8u)
	{
	}

	public void InitRequestFrienDataToAssist(bool needRefreshAssistView = false)
	{
	}

	private void RefreshSearchAccountInfoPresence(EPresenceListType type = EPresenceListType.SearchedPlayer)
	{
	}

	public void SearchAccount(ulong searchID, proto.EAccount.CallSignSrc callSignSrc, bool forceRefresh = false, uint propId = 8u)
	{
	}

	public void SearchByConditions(proto.ESocial.Language language = proto.ESocial.Language.Language_UNLIMITED, proto.ESocial.Gender gender = proto.ESocial.Gender.Gender_NONE, proto.ESocial.TimeActive activeTime = proto.ESocial.TimeActive.TimeActive_NONE, proto.ESocial.ModePrefer modePrefer = proto.ESocial.ModePrefer.ModePrefer_NONE, bool forceRefresh = false)
	{
	}

	public void RequestAccountInfo(ulong accountId, proto.EAccount.CallSignSrc callSignSrc, bool isRequestOnce = false)
	{
	}

	public void RequestedRecommendedFriendInitData()
	{
	}

	public GroupInviteMemberPority Rearrange(FriendAccountInfo info)
	{
		return GroupInviteMemberPority.Online;
	}

	private GroupInviteMemberPority FixGroupInviteMemberPorityForSocialLobbyHotfix(GroupInviteMemberPority result)
	{
		return GroupInviteMemberPority.Online;
	}

	public uint Rearrange(ClanMember info)
	{
		return 0u;
	}

	public void GetRecommendedFriend(bool forceRefresh = false, Action callBack = null)
	{
	}

	public void RefreshNearbyPlayers(ENearbyPlayerRefreshSource source = ENearbyPlayerRefreshSource.Manual)
	{
	}

	public void RequestNearbyPlayers(double latitude, double longitude, ENearbyPlayerRefreshSource source)
	{
	}

	public void RemoveFriendRequest(ulong remover, ulong removee)
	{
	}

	public static bool CanJoinFriendRoom(BaseProfileInfo info)
	{
		return false;
	}

	public static bool IsFriendRoomFull(BaseProfileInfo info)
	{
		return false;
	}

	public bool IsFriendInClanOrCasualRoom(uint roomType, proto.EPresence.AccountPresence pr)
	{
		return false;
	}

	public bool IsPlayingGame(FriendAccountInfo info)
	{
		return false;
	}

	public bool IsActuallyInGame(FriendAccountInfo friendInfo)
	{
		return false;
	}

	public bool IsActuallyInGame(BaseProfileInfo profileInfo)
	{
		return false;
	}

	public bool IsOpenReserver(FriendAccountInfo friendInfo)
	{
		return false;
	}

	public bool CanBeObserved(FriendAccountInfo info)
	{
		return false;
	}

	public bool CanShowFriendListRoomInfos(uint roomType, proto.EPresence.AccountPresence presence)
	{
		return false;
	}

	public void BatchRemoveFriends(ulong[] removee_list)
	{
	}

	public void AddFriendRequest(ulong adder, ulong addee, EFriendAddFrom add_from, string addeeRegion, uint friend_tag = 0u, bool need_slience = false, uint booyah_times = 0u, uint saving_times = 0u, uint match_times = 0u)
	{
	}

	public void RequestSetFavorFriendState(ulong adder, ulong addee, bool isMark)
	{
	}

	public bool CanDoFavorFriend()
	{
		return false;
	}

	public void ConfirmFriendRequest(ulong adder, ulong addee, bool need_slience = false, bool needRefreshAssist = false)
	{
	}

	public void DeclineFriendRequest(ulong adder, ulong addee, bool need_slience = false, bool needRefreshAssist = false)
	{
	}

	public void BlockPlayerRequest(ulong blockID, bool need_slience = false)
	{
	}

	public void CancelBlockRequest(ulong blockID, bool need_slience = false)
	{
	}

	public void RefuseAllFriendRequest(bool need_slience = false)
	{
	}

	public void RequestLeadinPlatformFriends(List<ulong> accountIds)
	{
	}

	public void RequestReadFriendRequestList()
	{
	}

	private void SetAssistDataRead(GetAccountFriendRequestListRes listRes)
	{
	}

	public static string GetFriendStatus(proto.EPresence.AccountPresence presence, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE, NIKKALKPIBO gameMode = NIKKALKPIBO.EGAMEMODE_NONE, uint mapID = 0u, uint groupMemberCnt = 0u, uint groupMode = 2147483647u, ulong groupId = 0uL, proto.EPresence.SocialPresence socialPresence = proto.EPresence.SocialPresence.AccountSocialPresence_NONE, BaseProfileInfo info = null, tcp.EGroup.PlayerDisplayState displayState = tcp.EGroup.PlayerDisplayState.PlayerDisplayState_NONE)
	{
		return null;
	}

	public static string GetFriendStatusWithSocialPresence(BaseProfileInfo profile)
	{
		return null;
	}

	public string GetLastLoginTime(long lastLoginAt)
	{
		return null;
	}

	public bool IsFriend(ulong accountID)
	{
		return false;
	}

	public bool IsPlatformFriend(ulong accountId)
	{
		return false;
	}

	public bool IsGameFriend(ulong accountID)
	{
		return false;
	}

	public bool IsGameFriendExcludePlatformFriend(ulong account_id)
	{
		return false;
	}

	public bool IsUnknowPlayer(ulong accountId)
	{
		return false;
	}

	public EFriendType GetFriendType(ulong accountId)
	{
		return EFriendType.Unknow;
	}

	public string GetFriendTypeString(ulong accountId)
	{
		return null;
	}

	public string GetFriendTypeStringAddFriend(ulong accountId)
	{
		return null;
	}

	public void SayHelloToNewFriend(ulong accountId)
	{
	}

	public Color GetFriendTypeColor(ulong accountId)
	{
		return default(Color);
	}

	public bool IsIDInCache(ulong accoutID)
	{
		return false;
	}

	public void ClearAddFriendCached()
	{
	}

	public void ResetRequestCooldown()
	{
	}

	public FriendAccountInfo GetFriendInfo(ulong account_id)
	{
		return null;
	}

	public FriendAccountInfo GetPlatformFriendInfo(ulong accountID)
	{
		return null;
	}

	private void BatchRemoveFriendsByAccountIDs(ulong[] account_ids)
	{
	}

	public void RemoveFriendByAccountID(ulong account_id)
	{
	}

	public void AddFriendWithPresence(AccountInfoWithPresence account_info)
	{
	}

	public bool CanInviteFriendToGroup(FriendAccountInfo info)
	{
		return false;
	}

	public bool CanJoinFriendGroup(FriendAccountInfo info)
	{
		return false;
	}

	private void SetListAmountLimit(List<FriendAccountInfo> friendList, int pickNum)
	{
	}

	private void SetListAmountLimit(List<RecentPlayerInfo> friendList, int pickNum)
	{
	}

	private void SetListAmountLimit(List<ClanMember> friendList, int pickNum)
	{
	}

	private List<RecentPlayerInfo> RandomPick(List<RecentPlayerInfo> friendList, int pickNum)
	{
		return null;
	}

	private List<ClanMember> RandomPick(List<ClanMember> friendList, int pickNum)
	{
		return null;
	}

	public void AddMatchCount()
	{
	}

	private bool CheckRecommendFriendCondition()
	{
		return false;
	}

	public void RefreshRecentTeamPlayers()
	{
	}

	public void RefreshTeamPlayersWhileClanMemberChange()
	{
	}

	public void RecommendFriendWhileInTeam()
	{
	}

	public bool CheckEnteredGame()
	{
		return false;
	}

	public void RecommendFriendAfterMatch()
	{
	}

	public void RecommendMVPGroupAfterMatch()
	{
	}

	public void RecommendCriticalGroupAfterMatch()
	{
	}

	public void ComputeFriendListPriority(List<FriendAccountInfo> friends)
	{
	}

	private void TryAgreeGroupJoin(UIModelMatch modelMatch, UIModelGroup modelGroup)
	{
	}

	private void TryAgreeGroupInvite(UIModelMatch modelMatch, UIModelGroup modelGroup)
	{
	}

	public static string SearchInfoRegexEscape(string original)
	{
		return null;
	}

	private int CalculateSearchScore(EMatchLevel matchLevel, EOnlineStatus onlineStatus, EFieldType fieldType)
	{
		return 0;
	}

	public List<FriendAccountInfo> SearchFriendInClientData(string info, List<FriendAccountInfo> tarFriendInfos = null)
	{
		return null;
	}

	public List<FriendInfo> SearchFriendByName(string info, List<FriendInfo> tarFriendInfos)
	{
		return null;
	}

	public List<BooyahPassShareExpData> SearchBooyahPassFriendInClientData(string info, List<BooyahPassShareExpData> friendInfos)
	{
		return null;
	}

	public void SetTeamMateSocialInfo(ulong accountID, byte gender, ushort friendCount)
	{
	}

	public void UpdataAccountInfoPin(ulong accountID, uint pinID)
	{
	}

	public void LeadInPlatformFriends(MatchStats stats)
	{
	}

	public void OnFriendIntimacyValueUpdate(IntimacyValueUpdateNtf updateValue)
	{
	}

	public bool TryGetFriendIntimacyValue(ulong accountId, out uint value)
	{
		value = default(uint);
		return false;
	}

	public bool IsFriendInGame(ulong account_id)
	{
		return false;
	}

	public void CheckFriendInGame(ulong account_id)
	{
	}

	public void ClearInGameFriendData()
	{
	}

	public void CacheAdderInGame(FriendReq resData)
	{
	}

	public void IgnorePlayerAddRequest()
	{
	}

	public void RemoveDataFromReadFriendRequestList(ulong accountID)
	{
	}

	public void AddDataToReadFriendRequestList(ulong accountID)
	{
	}

	public ulong GetFirstFriendAdder()
	{
		return 0uL;
	}

	public void CacheNewInviteID(FriendReq resData)
	{
	}

	public void OnInviteNtfInGame(GroupInviteNtf data)
	{
	}

	public void OnJoinRequestNtfInGame(GroupJoinRequestNtf data)
	{
	}

	public uint GetUnActiveFriendThresholdDays()
	{
		return 0u;
	}

	public bool IsShowBatchRemoveFriends()
	{
		return false;
	}

	public uint GetRecommendCommonFriendsNum(ulong accountId)
	{
		return 0u;
	}

	public List<FriendAccountInfo> GetCommonFriendsList(ulong accountId)
	{
		return null;
	}

	public void RefreshExpiredTeamUpPresence(PresenceListRes presenceRes)
	{
	}

	private void SetFriendAccountInfoDetail(FriendAccountInfo accountInfo)
	{
	}

	private int CompareFriendListInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	public FriendAccountInfo GetAssistExpiredTeamUpAccountInfo(ulong accountId)
	{
		return null;
	}

	public void OnMsgFriendIntimacyOnline(FriendOnlineNtf friendOnlineNtf)
	{
	}

	public ulong[] GetInTrainingModeFriendIds(uint gameMode)
	{
		return null;
	}

	public void CheckAndShowNearbySearchNewFeatureRedDot()
	{
	}

	public void SaveLobbyFriendButtonClicked()
	{
	}

	public void SaveFriendAddTabClicked()
	{
	}

	public void SaveNearbySearchButtonClicked()
	{
	}

	private void _003CRequestCacheRecentPlayersInfo_003Eb__206_0(List<AccountInfoBasic> accountInfos)
	{
	}

	private void _003CSearchByConditions_003Eb__252_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestedRecommendedFriendInitData_003Eb__255_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRefuseAllFriendRequest_003Eb__280_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestReadFriendRequestList_003Eb__282_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CIgnorePlayerAddRequest_003Eb__343_0(ulong a)
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
