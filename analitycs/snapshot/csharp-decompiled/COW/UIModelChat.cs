using System;
using System.Collections.Generic;
using COW.RemoteNotifications;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelChat : UIBaseModel
{
	private class RmtNtfObserver : RemoteNotificationManager.IRmtNtfObserver
	{
		private UIModelChat _Chat;

		public RmtNtfObserver(UIModelChat chat)
		{
		}

		public void OnTokenReceived(string token)
		{
		}
	}

	public class IntentRecruitInfo
	{
		public bool m_ToWorld;

		public bool m_ToClan;

		public bool m_ToNewbie;

		public uint m_RankLimit;

		public string m_GroupTag;

		public uint m_RankMaxLimit;

		public bool m_HasMapBonus;

		public IntentRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag, uint rankMaxLimit, bool hasMapBonus = false, bool newbie = false)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__302_0;

		public static Comparison<TextMsgReq> _003C_003E9__329_0;

		public static Comparison<TextMsgReq> _003C_003E9__334_0;

		public static Comparison<MessageInfo> _003C_003E9__334_1;

		internal void _003CReportRevokeEventPushToken_003Eb__302_0(HttpErrorCode errorCode, object obj)
		{
		}

		internal int _003COnRecvChatOfflineMsgNtf_003Eb__329_0(TextMsgReq a, TextMsgReq b)
		{
			return 0;
		}

		internal int _003COnRecvChatHistoryMsgNtf_003Eb__334_0(TextMsgReq a, TextMsgReq b)
		{
			return 0;
		}

		internal int _003COnRecvChatHistoryMsgNtf_003Eb__334_1(MessageInfo a, MessageInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public EChannel.ChannelType type;

		public ulong id;

		internal bool _003CGetChannelInfo_003Eb__0(ChatChannelInfo x)
		{
			return false;
		}

		internal bool _003CGetChannelInfo_003Eb__1(ChatChannelInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass279_0
	{
		public FastClanInvite clan;

		public UISecondConfirmContoller confirmWnd;

		internal void _003CJoinRecruit_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass281_0
	{
		public ulong senderId;

		public ulong id;

		public EChannel.ChannelType type;

		internal bool _003CRemoveQuickAddFriendMessageInfo_003Eb__0(MessageInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass289_0
	{
		public UIModelChat _003C_003E4__this;

		public uint itemID;

		internal void _003CBuySticker_003Eb__0(HttpErrorCode errorcode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass300_0
	{
		public UIModelChat _003C_003E4__this;

		public string token;

		internal void _003C_ReportEventPushInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass301_0
	{
		public EEventPush.EventPushType pushType;

		internal void _003CReportOTPChangeEventPushInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass342_0
	{
		public TextMsgReq req;

		internal bool _003CLogEventTypeWhisperChat_003Eb__0(EventLogger.EventTypeWhisperChatItem x)
		{
			return false;
		}
	}

	private Dictionary<ChatChannelInfo, List<MessageInfo>> m_ChatDictionary;

	private Dictionary<ChatChannelInfo, List<MessageInfo>> m_OldChatDictionary;

	private Dictionary<ChatChannelInfo, uint> m_RecvMessageNumCache;

	public List<ChatChannelInfo> m_ChannelInfoList;

	private List<MessageInfo> m_SendingMessages;

	private Dictionary<ulong, int> m_UnreadWhisperID;

	private Dictionary<ulong, int> m_UnreadSquadID;

	private EventLogger.EventChat m_ChatEvent;

	private EventLogger.EventTypeWhisperChat m_WhisperChatEvent;

	private MessageInfo m_LatestMessage;

	private Dictionary<string, MessageInfo> m_LastMessage;

	private Dictionary<string, float> m_NextShowProfileTime;

	public const float SHOW_MESSAGE_UI_CD = 60f;

	private ulong m_LastSendTimestamp;

	private ulong m_LastWorldSendTs;

	private ulong m_LastInGameMessageSendTs;

	public bool IsNewBiePlayer;

	private ulong m_LastNewbieSendTs;

	private ulong m_LastInGameTextChatSendTs;

	private ulong m_LastInGameUGCTextChatSendTs;

	private Dictionary<uint, LeaveChannelNtf> m_OldChannelDic;

	private int m_ChatRecruitGameMode;

	private int m_ChatRecruiMatchMode;

	private int m_ChatRecruitMapMode;

	private int m_ChatRecruitGroupMode;

	private const string EventPushInfoCachedTokenKey = "EventPushInfoCachedToken_{0}";

	private List<uint> m_DefaultMessageTips;

	private List<uint> m_RoomMessageTips;

	private List<uint> m_GroupMessageTips;

	private List<uint> m_OtherMessageTips;

	private LikeWorldChannelInfo m_WorldInfo;

	private LikeWorldChannelInfo m_NewbieInfo;

	private ulong _003CMutedTimeStamp_003Ek__BackingField;

	private const string ChatReportTimesKey = "ChatReportTimesKey";

	public bool m_HasRequestClanMemberList;

	private List<int> m_GroupInviteTimeOutMessages;

	private List<uint> m_GroupInviteCallIDs;

	public string QuickAddFriendNickName;

	public ulong QuickAddFriendId;

	private Dictionary<uint, uint> m_NumberOfContinuousChats;

	private Dictionary<uint, ulong> m_IdOfContinuousChats;

	private Dictionary<uint, bool> m_HasLocalPlayerTalked;

	private List<ulong> m_QuickAddFriendTipId;

	private List<ulong> m_ChatBlockList;

	private List<AccountInfoBasic> m_ChatBlackAccountInfoList;

	private Dictionary<uint, int> m_ChannelSortOrder;

	private MessageInfo m_LatestClanMessage;

	private const int MAX_HISTORY_RECRUIT_MESSAGE_LENGTH = 50;

	private const int STABLE_CHANNEL_COUNT = 3;

	public const int SEND_MESSAGE_CDTIME = 2;

	public const uint PropID_UpdateMessageList = 1u;

	public const uint PropID_UpdateProfileInfo = 2u;

	public const uint PropID_JoinOrLeaveRoom = 4u;

	public const uint PropID_RefreshWhisperList = 8u;

	public const uint PropID_UpdateStickerList = 16u;

	public const uint PropID_CheckMuteState = 32u;

	public const uint PropId_UpdateSlogan = 64u;

	public const uint PropId_RecvChatOfflineMsgNtf = 128u;

	public const uint PropId_RecvChatHistoryMsgNtf = 256u;

	public const uint PropID_BatchGetChatBlackPlayerInfo = 512u;

	public const uint PropId_RecvClanHistoryMsgNtf = 1024u;

	public const uint PropId_RecvLaunchTagMsgNtf = 2048u;

	public const uint PropID_ClaimRookieAnswerReward = 4096u;

	public const uint SPEAKER_ITEM_ID = 800000401u;

	public const string FAST_MSG_CLAN_TYPENAME = "clan";

	public const string FAST_MSG_CLANGROUP_TYPENAME = "clanGroup";

	public const string FAST_MSG_GROUP_TYPENAME = "group";

	public const string FAST_MSG_BIGEVENT_TYPENAME = "BigEventMsg";

	public const string FAST_MSG_CHAMPIONSHIPTEAM_TYPENAME = "championshipTeam";

	public const string FAST_MSG_CUPMATCHTEAM_TYPENAEM = "CupMatchTeam";

	public const string FAST_MSG_LUKCY_BUFF_TYPENAEM = "LuckyBuff";

	public const string FAST_MSG_EVO_GUN_SHARE_TYPENAEM = "EVOGunShare";

	public const string FAST_MSG_SQUAD_TREASURE_TEAM_SHARE_TYPENAEM = "SquadTreasureTeamShare";

	public const string FAST_MSG_ROOM_RECRUIT_TYPENAEM = "RoomRecruit";

	public const string FAST_MSG_PRIME_SETSHARE = "PrimeSetShare";

	public const string FAST_MSG_SPECIAL_COLOR = "SpecialColor";

	public const string FAST_MSG_UGC_MAP_SHARE_TYPENAME = "UGCMapShare";

	public const string FAST_MSG_HUD_SHARE_TYPENAME = "HUDShare";

	public const string FAST_MSG_RELAY_MART_DISCOUNT_CODE_SHARE_TYPENAME = "RelayMartDiscountCodeShare";

	public const string FAST_MSG_NEWBIE_DAILY_QUIZ_TYPENAME = "NewbieDailyQuiz";

	public const string FAST_MSG_NEWBIE_TOP_RANK_TYPENAME = "NewbieTopRank";

	public const string FAST_MSG_ROOM_WIN_RATE_TYPENAME = "RoomWinRate";

	public const string SPECIAL_MSG_TITLE = "Title";

	public const string SPECIAL_MSG_BUF = "Buf";

	public const string SPECIAL_MSG_STICKER = "Sticker";

	public const string SPECIAL_MSG_LAUNCH_TAG = "LaunchTag";

	private const string LOBBY_MESSAGE_PREFIX_CLAN = "TXT_LOBBY_MESSAGE_PREFIX_CLAN";

	private const string LOBBY_MESSAGE_PREFIX_GROUP = "TXT_LOBBY_MESSAGE_PREFIX_GROUP";

	private const string LOBBY_MESSAGE_PREFIX_WHISPER = "TXT_OB10_ZC_CHANNEL_WHISPER";

	private const string LOBBY_MESSAGE_PREFIX_ROOM = "T_12_Z_MESSAGE_PREFIX_ROOM";

	private const string LOBBY_MESSAGE_PREFIX_WORLD = "T_20_P_CHANNEL_W_E";

	private const string LOBBY_EMOJI_MESSAGE = "T_12_A_CHAT_LOBBY_EMOJI";

	private const string LOBBY_FAST_GROUP = "T_20_P_CHANNEL_ENTRANCE_I";

	private const string LOBBY_FAST_CLAN = "T_20_P_CHANNEL_ENTRANCE_R";

	private const string LOBBY_FAST_CLAN_GROUP = "T_20_P_PARTNER_REC";

	private const string LOBYY_TITLE_MESSAGE = "T_40_ZZ_TITLELOBBY";

	private const string LOBBY_MESSAGE_PREFIX_NEWBIE = "T_54_L_TXT_LOBBY_MESSAGE";

	private const ulong NEWBIE_DAILY_QUIZ_SENDER_ID = 0uL;

	private const uint NEWBIE_DAILY_QUIZ_HEADPIC_ID = 902000007u;

	private FastNewbieTopRankMessage m_NewbieTopRankBRMessage;

	private FastNewbieTopRankMessage m_NewbieTopRankCSMessage;

	private bool m_HasRequestedNewbieTopRankBR;

	private bool m_HasRequestedNewbieTopRankCS;

	public const string NEWBIE_DAILY_QUIZ_LAST_ANSWER_TS_KEY = "NewbieDailyQuizLastAnswerTs";

	private const string LATEST_MESSAGE_FORMAT = "{0} {1}: {2}";

	private const string STICKY_MESSAGE_COLOR_FORMAT = "[ffd451]{0}[-]";

	private const string LATEST_MESSAGE_FORMAT_NOTITLE = "{0}{1}";

	public const string SENDERNAME_WITHCOLOR = "[FFBA00]{0}:[-]";

	public const string DEFAULT_MESSAGE_WITH_KEY = "DefaultMessageWithKey";

	private HashSet<string> m_SloganSet;

	private bool m_IsShowSlogan;

	private string m_BigEventBannerName;

	private uint m_WorldChanActivityId;

	private List<string> m_BufContent;

	private List<TextMsgReq> m_WaitForSendMsgReq;

	private RmtNtfObserver _RmtNtfObserver;

	private Dictionary<string, MessageInfo> m_OldLastMessage;

	private Dictionary<string, ulong> m_OldNextShowProfileTime;

	private bool m_RequestWhisperOfflineMsg;

	private Dictionary<ulong, bool> m_RequestHistoryMsgDict;

	private Dictionary<ulong, bool> m_RequestClanHistoryMsgDict;

	private const string m_OldChatKey = "OldChatKey";

	private const string m_OldChatKeyNotFriend = "OldChatKeyNotFriend";

	private Dictionary<ulong, ulong> m_RequestHistoryMsgIdDict;

	private Dictionary<ulong, ulong> m_RequestClanHistoryMsgIdDict;

	private List<ulong> m_FriendIdList;

	private bool m_NeedShowLobbyChatRedTips;

	private Dictionary<ulong, MessageInfo> m_LatestMessageDictNoLimit;

	private string m_OfflineWhisperChatKey;

	private byte m_RequestWhisperOfflineMsgIsValid;

	private const byte Flag_ConnectToChatService = 1;

	private const byte Flag_GetFirendList = 2;

	private IntentRecruitInfo intentRecruitInfo;

	public ulong LastNewbieSendTs => 0uL;

	public List<uint> DefaultMessageTips => null;

	public List<uint> RoomMessageTips => null;

	public List<uint> GroupMessageTips => null;

	public List<uint> OtherMessageTips => null;

	public int chatGameMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int chatMatchMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int chatMapMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int chatGroupMode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ulong LastWorldSendTs => 0uL;

	public LikeWorldChannelInfo WorldInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LikeWorldChannelInfo NewbieInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EventPushInfoCachedToken
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public ulong MutedTimeStamp
	{
		get
		{
			return _003CMutedTimeStamp_003Ek__BackingField;
		}
		private set
		{
			_003CMutedTimeStamp_003Ek__BackingField = value;
		}
	}

	public uint ChatReportTimes
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public List<ulong> ChatBlockList => null;

	public List<AccountInfoBasic> ChatBlackAccountInfoList => null;

	public MessageInfo LatestMessage => null;

	public MessageInfo LatestClanMessage => null;

	public List<ChatChannelInfo> ChannelInfoList => null;

	public HashSet<string> SloganSet => null;

	public bool IsShowSlogan => false;

	public string BigEventBannerName => null;

	public uint WorldChanActivityId => 0u;

	public bool NeedShowLobbyChatRedTips => false;

	private LikeWorldChannelInfo GetLikeWorldChatInfo(EChannel.ChannelType type)
	{
		return null;
	}

	private bool IsUnboundAccount()
	{
		return false;
	}

	public bool IsLikeWorldNormalChatLimited(EChannel.ChannelType type)
	{
		return false;
	}

	private bool IsLikeWorldCustomTalkDisabled(EChannel.ChannelType type)
	{
		return false;
	}

	public bool IsLikeWorldNormalInputForbidden(EChannel.ChannelType type)
	{
		return false;
	}

	public void ClearLastClanMessage()
	{
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

	public void RequestChatBlockPlayersInfo()
	{
	}

	private void ResetContinousChats()
	{
	}

	private void ReadBlockList()
	{
	}

	public void JoinRoom(EChannel.ChannelType type, ulong roomid)
	{
	}

	public void AddRecruit()
	{
	}

	public void AddWhisper(ulong id)
	{
	}

	public ChatChannelInfo GetChannelInfo(EChannel.ChannelType type, ulong id = 0uL)
	{
		return null;
	}

	private int SortChannelList(ChatChannelInfo x, ChatChannelInfo y)
	{
		return 0;
	}

	public void AddChannelToOldChannelDic(EChannel.ChannelType type, ulong oldChannelID, ulong newChannelID)
	{
	}

	public void LeaveChannelToJoinNewChannel(LeaveChannelNtf leaveChannelNtf)
	{
	}

	private void UpdateMesGroupId(uint type, ulong oldChannelID)
	{
	}

	public bool LeaveRoom(EChannel.ChannelType type, ulong roomid, bool saveMes = false)
	{
		return false;
	}

	public ulong GetLikeWorldChannelID(EChannel.ChannelType type)
	{
		return 0uL;
	}

	public bool IsLikeWorldChannelOpen(EChannel.ChannelType type)
	{
		return false;
	}

	public void SetLikeWorldChannelID(ulong id, EChannel.ChannelType type)
	{
	}

	public ulong GetWorldChannelID()
	{
		return 0uL;
	}

	public ulong GetNewbieChannelID()
	{
		return 0uL;
	}

	public bool IsNewbieChannelOpen()
	{
		return false;
	}

	public void ProcessJoinNewbieChannel()
	{
	}

	public bool HasAnsweredNewbieDailyQuizToday()
	{
		return false;
	}

	public void MarkNewbieDailyQuizAnsweredToday()
	{
	}

	public bool CanLoadNewbieDailyQuizMessage()
	{
		return false;
	}

	private ulong GetNewbieDailyQuizRefreshTimeStamp(ulong timeStamp)
	{
		return 0uL;
	}

	public int GetCurrentNewbieDailyQuizDay()
	{
		return 0;
	}

	public RookieAnswer GetCurrentRookieAnswer()
	{
		return null;
	}

	public bool RequestClaimRookieAnswerReward(RookieAnswer quizData)
	{
		return false;
	}

	private MessageInfo BuildNewbieDailyQuizMessage(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	private void TryInsertNewbieDailyQuizMessage(EChannel.ChannelType type, ulong id, List<MessageInfo> list)
	{
	}

	private BaseProfileInfo BuildNewbieDailyQuizSenderProfile()
	{
		return null;
	}

	private MessageInfo BuildNewbieTopRankMessage(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	private void TryInsertNewbieTopRankMessage(EChannel.ChannelType type, ulong id, List<MessageInfo> list)
	{
	}

	public void ResetNewbieTopRankCache()
	{
	}

	public bool CanLoadNewbieTopRankMessage()
	{
		return false;
	}

	private ERankingPointsDeltaType GetCurrentNewbieTopRankRequestType()
	{
		return ERankingPointsDeltaType.RANKING_POINTS_DELTA_TYPE_UNKNOWN;
	}

	private FastNewbieTopRankMessage GetCachedNewbieTopRankMessage(ERankingPointsDeltaType requestType)
	{
		return null;
	}

	private void RequestTopNewbieRankingPointsDelta(ERankingPointsDeltaType requestType)
	{
	}

	public void OnRecvTopNewbieRankingPointsDeltaNtf(TopNewbieRankingPointsDeltaNtf ntf)
	{
	}

	private void TryRefreshNewbieTopRankMessage()
	{
	}

	private FastNewbieTopRankMessage ConvertTopNewbieRankingPointsDeltaMessage(TopNewbieRankingPointsDeltaNtf ntf)
	{
		return null;
	}

	public bool IsWorldChannelOpen()
	{
		return false;
	}

	public bool IsSocialChannelOpen()
	{
		return false;
	}

	public void ProcessJoinWorldChannel()
	{
	}

	public bool CorrectMessageContent(string msg, out string result)
	{
		result = null;
		return false;
	}

	public bool SendMessage(EChannel.ChannelType type, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT, ulong accountID = 0uL, float deltaCD = 0f)
	{
		return false;
	}

	public void CheckCanSendLuckyBuffChat()
	{
	}

	public bool DebugAutoSendLuckyBuffChat()
	{
		return false;
	}

	private bool AutoSendLuckyBuffChat()
	{
		return false;
	}

	public bool SendEVOGunShareChat(EChannel.ChannelType channelType, uint shareWeaponSkinId)
	{
		return false;
	}

	public bool SendSquadTreasureTeamShareChat(EChannel.ChannelType channelType, ulong accountId, ulong shareGroupId)
	{
		return false;
	}

	public bool SendRelayMartDiscountCodeShareChat(EChannel.ChannelType channelType, ulong accountId, string shareDiscountCode, float deltaCD = 0f)
	{
		return false;
	}

	public void SendRoomRecruitChat()
	{
	}

	public bool SendUGCMapShareChat(ulong accountID, string workshopCode, bool ignoreSendCD)
	{
		return false;
	}

	public bool SendHUDShareChat(EChannel.ChannelType channelType, ulong accountId, string shareCode, bool ignoreSendCD = false)
	{
		return false;
	}

	public bool SendGroupTitleMessage()
	{
		return false;
	}

	public bool SendGroupLaunchTagMessage()
	{
		return false;
	}

	public bool SendFastGroupInvite(EChannel.ChannelType channel)
	{
		return false;
	}

	public bool SendFastClanGroupInvite(ClanInfo clanInfo, string memberNum, uint BRRankLimit, uint CSRankLimit, string tag)
	{
		return false;
	}

	public bool SendFastClanInvite(ClanInfo clanInfo)
	{
		return false;
	}

	public bool DebugSendFastClanInvite(ClanInfo clanInfo)
	{
		return false;
	}

	public bool SendFastChampionshipTeamInvite(EChannel.ChannelType channel, uint championshipType, uint championshipID)
	{
		return false;
	}

	public bool SendFastCupMatchTeamInvite(EChannel.ChannelType channel, uint type, uint id)
	{
		return false;
	}

	public bool SendBigEventMsg(string msg, EChannel.ChannelType channel, ulong accountID = 0uL)
	{
		return false;
	}

	public bool SendMessage(EChannel.ChannelType type, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT)
	{
		return false;
	}

	public bool SendStickerMessage(EChannel.ChannelType type, ulong channelID, string stickerString, bool checkBuy = true)
	{
		return false;
	}

	public bool SendMessage(EChannel.ChannelType type, ulong channelID, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT, bool checkFriend = true, float deltaCD = 0f, bool showWhisperFailTips = true, bool ignoreCDTips = false, bool ignoreWorldLimit = false, bool ignoreSendCD = false, string extraInfo = "", ESpecialChatModeForm chatForm = ESpecialChatModeForm.None)
	{
		return false;
	}

	private bool SendMessageToChannel(EChannel.ChannelType type, bool isSticker, TextMsgReq req)
	{
		return false;
	}

	public bool SendPendingTitleMsgReq()
	{
		return false;
	}

	public void ClearBufContent()
	{
	}

	public List<MessageInfo> GetChannelMessageListContainOldChat(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	public List<MessageInfo> GetChannelMessageList(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	public MessageInfo GetLatestMessage(EChannel.ChannelType type, ulong id)
	{
		return null;
	}

	public void RecvNewMessageList(TextMsgReq info)
	{
	}

	public void InjectLocalRoomWinRateMessage(tcp.RoomInfo roomInfo, RoomWinRateModeData data)
	{
	}

	private BaseProfileInfo BuildRoomWinRateSenderProfile(ulong ownerId, string ownerName, RoomPlayerInfo ownerInfo)
	{
		return null;
	}

	private proto.BadgeInfo BuildProtoBadgeInfo(tcp.BadgeInfo badgeInfo)
	{
		return null;
	}

	private proto.PrimePrivilegeDetail BuildProtoPrimePrivilegeDetail(tcp.PrimePrivilegeDetail primeInfo)
	{
		return null;
	}

	private bool CheckMsgNeedBlocked(MessageInfo info)
	{
		return false;
	}

	private void ProcessMessageShowTips(MessageInfo info)
	{
	}

	private ulong ProcessRecveId(MessageInfo info)
	{
		return 0uL;
	}

	private bool ProcessWhisperInfoSuccess(MessageInfo info, ulong recvId = 0uL)
	{
		return false;
	}

	private void ProcessMessage(MessageInfo info)
	{
	}

	private void ProcessMessageIsNeedHide(MessageInfo info)
	{
	}

	private void ProcessBRAntiAddictionFilter(MessageInfo info)
	{
	}

	private void ProcessBRFilterWhisper(MessageInfo info, UIModelAntiAddiction antiAddictionModel)
	{
	}

	private void ProcessBRFilterGroup(MessageInfo info, UIModelAntiAddiction antiAddictionModel)
	{
	}

	private void ProcessBRFilterPublic(MessageInfo info, UIModelAntiAddiction antiAddictionModel)
	{
	}

	private bool AddNewMessageToList(ulong id, MessageInfo info)
	{
		return false;
	}

	public void SetWhisperUnread(ulong whisperID, bool hasUnreadTip)
	{
	}

	public int GetWhisperUnread(ulong whisperID)
	{
		return 0;
	}

	public void SetSquadUnread(ulong channelID, EChannel.ChannelType channelType, bool hasUnreadTip)
	{
	}

	public int GetSquadUnRead(ulong channelID, EChannel.ChannelType channelType)
	{
		return 0;
	}

	public void ResendMessage(MessageInfo resendInfo)
	{
	}

	private void SetMessageProfileState(MessageInfo info, ChatChannelInfo channelInfo, bool addPrivateWarning)
	{
	}

	public void UpdateLastMesGroupId(ulong oldChannelID, ulong newChannelID)
	{
	}

	public void RemoveLastMessage(ulong channelID, EChannel.ChannelType channelType)
	{
	}

	public void AddNewGroupRecuitMessage(MessageInfo info)
	{
	}

	private bool BlockGroupRecruitMsg(MessageInfo info)
	{
		return false;
	}

	public void JoinRecruit(MessageInfo recruitData, bool fromWorldChannel)
	{
	}

	private tcp.EGroup.InviteChannelType GetInviteChannel(EChannel.ChannelType type)
	{
		return tcp.EGroup.InviteChannelType.InviteChannelType_PLAYER;
	}

	public void RemoveQuickAddFriendMessageInfo(EChannel.ChannelType type, ulong id, ulong senderId)
	{
	}

	public void SendEventLog()
	{
	}

	public void SendWhisperEventLog()
	{
	}

	public string RemoveColorAttribute(string content)
	{
		return null;
	}

	public void AddToBlockList(ulong userid, string name)
	{
	}

	public void DeleteFromBlockList(ulong userid)
	{
	}

	private void SaveBlockList()
	{
	}

	public bool IsBlocked(ulong userid)
	{
		return false;
	}

	public void BuySticker(uint itemID)
	{
	}

	public bool IsRecruitOverSelfRank(uint gameMode, uint reqMinRank, uint reqMaxRank, uint matchMode)
	{
		return false;
	}

	public bool EnableReportChat()
	{
		return false;
	}

	public bool IsMuted()
	{
		return false;
	}

	public void SetMutedTime(long timeToLive)
	{
	}

	public void ReportChat(MessageInfo reportedMsg, List<string> reportedMsgList, uint reason)
	{
	}

	public void ReportEventPushInfo(bool force = false)
	{
	}

	protected override void OnCleanup()
	{
	}

	private void OnRmtNtfTokenRecved(string token)
	{
	}

	private void _ReportEventPushInfo(string token)
	{
	}

	public void ReportOTPChangeEventPushInfo(EEventPush.EventPushType pushType)
	{
	}

	public void ReportRevokeEventPushToken()
	{
	}

	public static ETipsType ChannelType2TipsType(EChannel.ChannelType cType)
	{
		return ETipsType.None;
	}

	public static EChannel.ChannelType TipsType2ChannelType(ETipsType eType)
	{
		return EChannel.ChannelType.ChannelType_GROUP;
	}

	public void RequestSloganAndBanner()
	{
	}

	private void SetOldMessageProfileState(MessageInfo info, ChatChannelInfo channelInfo)
	{
	}

	private void ClearOldMessageProfileState(ChatChannelInfo channelInfo)
	{
	}

	public void ConnectToChatService()
	{
	}

	public void GetGetFirendList()
	{
	}

	public void TryRequestWhisperOfflineMsg()
	{
	}

	public void OnRecvChatOfflineMsgNtf(OfflineMessageNtf offlineMsgNtf)
	{
	}

	public void OnWhisperItemClickToRequestWhisperHistoryMsg(EChannel.ChannelType channelType, ulong id)
	{
	}

	public void RequestClanHistoryMsg(ulong clanId)
	{
	}

	public bool CanRequestClanHistoryMsg(ulong clanId = 0uL)
	{
		return false;
	}

	public void TryRequestCurrentClanHistoryMsg()
	{
	}

	public void OnRecvChatHistoryMsgNtf(HistoryMessageNtf historyMsgNtf)
	{
	}

	private bool IsContainHistoryMessageType(EChannel.ChannelType channelType)
	{
		return false;
	}

	private bool IsContainOfflineMessageType(EChannel.ChannelType channelType)
	{
		return false;
	}

	private ulong GetClanMsgId(ulong clanId)
	{
		return 0uL;
	}

	private void UpdateLatestMessageDictNoLimit(MessageInfo info)
	{
	}

	public void UpdateFriendIdList()
	{
	}

	private void UpdateMessageId()
	{
	}

	public void OnPlayerPrefsUtilSave()
	{
	}

	private void LogEventTypeWhisperChat(TextMsgReq req)
	{
	}

	private void CachedMinorChatReport(MessageInfo info)
	{
	}

	public void SetIntenRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag, uint rankMaxLimit, bool hasMapBonus = false, bool newbie = false)
	{
	}

	public void ClearIntenRecruitInfo()
	{
	}

	public bool SendIntentRecruit()
	{
		return false;
	}

	public bool IsSquadChannel(EChannel.ChannelType type)
	{
		return false;
	}

	public string GetMessageText(MessageInfo showInfo, bool noTitle = false)
	{
		return null;
	}

	public uint GetCurrentPageByMessageTips(List<uint> tips, EChannel.ChannelType defaultChannel)
	{
		return 0u;
	}

	public void RecordInGameMessageTS()
	{
	}

	public void RecordInGameTextChatTS(APJMAOJFMCF chatType = APJMAOJFMCF.EIngameChatType_InGameTeamChat)
	{
	}

	public void ClearInGameMessageTS()
	{
	}

	public void ClearInGameTextChatTS()
	{
	}

	public bool IsInGameMsgInCD()
	{
		return false;
	}

	public bool IsInGameTextChatInCD(APJMAOJFMCF chatType = APJMAOJFMCF.EIngameChatType_InGameTeamChat)
	{
		return false;
	}

	public long GetInGameTextChatCD(APJMAOJFMCF chatType = APJMAOJFMCF.EIngameChatType_InGameTeamChat)
	{
		return 0L;
	}

	public bool SendInGameSticker(ChatStickerData stickerData)
	{
		return false;
	}

	private bool IsGiveMeFiveSticker(ChatStickerData stickerData)
	{
		return false;
	}

	public void SendInGameMsg(string msg)
	{
	}

	public void SendInGameTextChat(string msg, APJMAOJFMCF chatType = APJMAOJFMCF.EIngameChatType_InGameTeamChat, HDJKFKCKJGJ msgType = HDJKFKCKJGJ.EInGameChatMsgType_Text)
	{
	}

	private void _003CRequestChatBlockPlayersInfo_003Eb__180_0(List<AccountInfoBasic> accountInfos)
	{
	}

	private void _003CRequestClaimRookieAnswerReward_003Eb__205_0(HttpErrorCode errorCode, object res)
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

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
