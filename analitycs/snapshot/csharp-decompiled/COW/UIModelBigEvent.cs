using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelBigEvent : UIBaseModel, IUIModelDataChangeObserver
{
	public class TokenTipsData
	{
		public uint id;

		public uint go_pos;

		public string sub_go_pos;

		public string way;

		public uint takenId;

		public uint dataSource;

		public TokenGoposTipWayType waytype;

		public string icon;

		public TokenTipsData(uint id, uint takenId, uint go_pos, string sub_go_pos, string way, TokenGoposTipWayType waytype, uint dataSource = 0u, string icon = "")
		{
		}
	}

	public class BigEventModeToken
	{
		public uint tokenTodayGetNum;

		public uint tokenTodayLimitNum;

		public uint gameMode;
	}

	public class BigEventTokenInfo
	{
		public uint tokenID;

		public int tokenCount;

		public Dictionary<uint, BigEventModeToken> modeTokenList;
	}

	public enum TokenGoposTipWayType
	{
		None,
		Obtain,
		Use
	}

	public enum EBigEventEntranceState
	{
		Hide = 1,
		GrayPre,
		GrayOnGoing,
		GrayOverDue,
		Open
	}

	public enum EBigEventStatus
	{
		EBigEventStatus_NotStart,
		EBigEventStatus_Progress,
		EBigEventStatus_End
	}

	public enum EBigEventEntranceID
	{
		Main = 0,
		Puzzle = 101,
		DailyMission = 102,
		Gacha = 103,
		Album = 104,
		Revenue = 105,
		WebActivity = 106,
		Revenue2 = 107,
		InGameGoPos = 108,
		SubBigEvent = 109,
		SignIn = 110,
		DiceGame = 111,
		ExchangeStore = 112,
		GameFFManager = 113,
		GameLive = 114,
		TeamShow = 115,
		GameGuess = 116,
		InviteFriend = 117,
		HelpFriend = 118,
		WebActivity2 = 119,
		WebActivity3 = 120,
		LeaderBoard = 121,
		ElitePass = 122,
		TeamPlay = 123,
		LudoGame = 124,
		MiniGame = 125,
		ExchangeCloth = 126,
		UseSupport = 127,
		TokenGain1 = 128,
		TokenGain2 = 129,
		TokenGain3 = 130,
		TokenGain4 = 131,
		TokenGain5 = 132,
		TokenGain6 = 133,
		ExchangeCard = 134,
		Revenue3 = 135,
		Revenue4 = 136,
		RoleDoor = 137,
		RolrDoorDialog = 138,
		ClothesDoor = 139,
		GunDoor = 140,
		MapDoor = 141,
		ActivityDoor = 142,
		Revenue5 = 143,
		Revenue6 = 144,
		StarMap = 145,
		BPWarmUp = 146,
		BPReady = 147,
		DressSelection = 148,
		UGC = 149,
		Gameplay = 150,
		Transfer = 151,
		SignBoard = 152,
		CG = 153,
		Signet = 154,
		Linkage = 155,
		DecorationEdit = 156,
		Keepsake = 157,
		RangoliEdit = 158,
		UGC2 = 159,
		CommonStartEntranceID = 1001
	}

	public enum ESignInDay
	{
		NONE,
		DAY1,
		DAY2,
		DAY3,
		DAY4,
		DAY5,
		DAY6,
		DAY7,
		DAILY
	}

	public enum EPeakDayState
	{
		Invalid,
		UnClaimable,
		Claimable,
		Claimed,
		Expired,
		ClaimedAndExpired
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BigEventBadgeDesc, uint> _003C_003E9__94_1;

		public static Func<BigEventBadgeDesc, BigEventBadgeDesc> _003C_003E9__94_2;

		public static Comparison<BigEventEntryDesc> _003C_003E9__99_0;

		public static Predicate<BigEventOpenInfoDesc> _003C_003E9__132_0;

		public static Predicate<BigEventOpenInfoDesc> _003C_003E9__133_0;

		public static Func<string> _003C_003E9__135_1;

		public static Func<int> _003C_003E9__135_3;

		public static Func<string> _003C_003E9__135_4;

		public static Comparison<TokenTipsData> _003C_003E9__155_0;

		public static Comparison<LimitedEventStore> _003C_003E9__159_1;

		public static Comparison<BigEventStoreCommodityDesc> _003C_003E9__161_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__177_1;

		internal uint _003CRequestEventInventorySetting_003Eb__94_1(BigEventBadgeDesc item)
		{
			return 0u;
		}

		internal BigEventBadgeDesc _003CRequestEventInventorySetting_003Eb__94_2(BigEventBadgeDesc Item)
		{
			return null;
		}

		internal int _003CProcessAllEventOpenInfo_003Eb__99_0(BigEventEntryDesc a, BigEventEntryDesc b)
		{
			return 0;
		}

		internal bool _003CGetBigEventOpenPeriod_003Eb__132_0(BigEventOpenInfoDesc item)
		{
			return false;
		}

		internal bool _003CGetOpenInfoEndTime_003Eb__133_0(BigEventOpenInfoDesc item)
		{
			return false;
		}

		internal string _003CGetNotifyInfo_003Eb__135_1()
		{
			return null;
		}

		internal int _003CGetNotifyInfo_003Eb__135_3()
		{
			return 0;
		}

		internal string _003CGetNotifyInfo_003Eb__135_4()
		{
			return null;
		}

		internal int _003CGetTokenTipsDataList_003Eb__155_0(TokenTipsData a, TokenTipsData b)
		{
			return 0;
		}

		internal int _003CRequestExchangeStoreData_003Eb__159_1(LimitedEventStore a, LimitedEventStore b)
		{
			return 0;
		}

		internal int _003CSortExchangeStoreItemList_003Eb__161_0(BigEventStoreCommodityDesc x, BigEventStoreCommodityDesc y)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CClaimAFKGroupAwards_003Eb__177_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public string key;

		internal void _003CRequestClaimLimitedEventSettleReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public EBigEventEntranceID entrance_id;

		internal bool _003CGetBigEventEntranceStateByTwoType_003Eb__0(BigEventEntranceSettingDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public EBigEventEntranceID entrance_id;

		internal bool _003CGetBigEventEntranceStateByTwoType_003Eb__0(BigEventEntranceSettingDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public EBigEventEntranceID entrance_id;

		internal bool _003CGetBigEventEntranceDescByTwoType_003Eb__0(BigEventEntranceSettingDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public int type;

		internal bool _003CGetEventCDNUrlByEventIDAndType_003Eb__0(BigEventCDNDesc info)
		{
			return false;
		}

		internal bool _003CGetEventCDNUrlByEventIDAndType_003Eb__1(BigEventCDNDesc info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public ELimitedEvent.EventState state;

		internal bool _003CGetEventOpenInfoByIdAndState_003Eb__0(BigEventOpenInfoDesc info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public BigEventEntryDesc entryDesc;

		public uint GoPos;

		public string content;

		internal string _003CGetNotifyInfo_003Eb__0(object[] parameters)
		{
			return null;
		}

		internal string _003CGetNotifyInfo_003Eb__2()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public ELimitedEvent.EventID eventID;

		internal void _003CRequestTokenInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public ELimitedEvent.EventID eventID;

		internal void _003CRequestTokenTipsDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public uint tokenId;

		internal void _003CRequestTokenLimitedInGame_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public uint gameMode;

		internal bool _003CGetTokenTipsDesc_003Eb__0(BigEventTokenTipsDesc desc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public ELimitedEvent.EventID eventID;

		public ELimitedEvent.StoreType storeType;

		internal void _003CRequestExchangeStoreData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public uint storeId;

		internal bool _003CGetExchangeStoreDataById_003Eb__0(LimitedEventStore item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public BigEventStoreCommodityDesc desc;

		public uint cnt;

		public UIModelBigEvent _003C_003E4__this;

		public ELimitedEvent.EventID eventID;

		public bool useCommonReward;

		public ELimitedEvent.StoreType storeType;

		public Action _003C_003E9__1;

		internal void _003CRequestExchangeStorePurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestExchangeStorePurchase_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public bool filter;

		public UIModelBigEvent _003C_003E4__this;

		internal void _003CRequestAFKGroupInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public bool isInvitedByShare;

		public ulong groupID;

		internal void _003CRequestJoinAFKGroup_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass177_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public ulong groupID;

		internal void _003CClaimAFKGroupAwards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public uint bigEventID;

		internal void _003CRequestEventInventorySetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIModelBigEvent _003C_003E4__this;

		public uint eventId;

		internal void _003CRequestEventWarmUpShowAwardSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private Dictionary<int, List<BigEventEntryDesc>> m_EventAutoEntryDesc;

	private Dictionary<int, IBigEventModel> m_BigEventModelDict;

	private Dictionary<int, List<BigEventOpenInfoDesc>> m_BigEventOpenInfoDict;

	private BigEventOpenInfoDesc lobbyIconOpenInfo;

	private Dictionary<int, List<BigEventCDNDesc>> m_BigEventCDNSettingDict;

	private Dictionary<int, List<LimitedEventStore>> m_BigEventExchangeStoreDict;

	private Dictionary<int, BigEventMovieDesc> m_BigEventMovieDict;

	private Dictionary<uint, List<BigEventEntranceSettingDesc>> m_BigEventEntrancesSettingDict;

	private Dictionary<uint, Dictionary<uint, BigEventBadgeDesc>> m_BigEventBadgeDescDic;

	private Dictionary<uint, List<LimitedEventBadge>> m_BigEventBadgeInfoDic;

	private Dictionary<uint, BigEventLocalMailDesc> m_BigEventLocalMailDic;

	private Dictionary<uint, List<BigEventShowAwardDesc>> m_BigEventWarmUpShowAwardSettingDic;

	private Dictionary<uint, List<BigEventTokenTipsDesc>> m_BigEventTokenTipsDescDict;

	private Dictionary<uint, HashSet<ExchangeCurrencyLocalDesc>> m_ExchangeCurrencyLocalEdscDict;

	private Dictionary<uint, ExchangeCurrencyLocalUseDesc> m_ExchangeCurrencyLocalDescUseDict;

	private HashSet<uint> m_BigEventTokenTipsRequestedEventId;

	private Dictionary<uint, BigEventTokenInfo> m_BigEventTokenInfoDict;

	private Dictionary<uint, uint> m_BigEventEventIDToTokenDict;

	public const string NOTIFY_ANNIVERSARY_ACTIVITY_START = "NOTIFY_ANNIVERSARY_ACTIVITY_START_";

	public const string PREF_BIGEVENT_LOCAL_MAIL = "BigEvent_LocalMail_{0}";

	public const string DEFAULT = "default";

	private ELimitedEvent.EventID m_EventAutoEntryId;

	public Queue<LocalNotificationManager.NotifyType> m_CanUseNotifyTypes;

	public Dictionary<uint, uint> m_UsingNotifyTypes;

	private Dictionary<ulong, GoliathAFKGroupInfo> m_AFKGroupInfoDict;

	private Dictionary<ulong, uint> m_GroupMemberCnt;

	private Dictionary<ulong, ulong> m_FuzzyStartTimeInAdvance;

	private Dictionary<ulong, ulong> m_AFKFriendNextInviteableTimestamp;

	private const ulong AFK_INVITE_FRIEND_CD = 4uL;

	public const int AFK_MAX_GROUP_NUM = 3;

	public const uint AFK_GROUP_MAX_MEMBER_NUM = 4u;

	public bool IsAFKGroupInfoChanged;

	private uint m_CaptaionActivityID;

	private CSGetLimitedEventOpenInfoRes m_EventOpenInfo;

	private Dictionary<uint, List<BigEventDailyCheckInSettingDesc>> m_BigEventSignInSettingDict;

	private Dictionary<uint, uint> m_BigEventSignInDayCntDict;

	private Dictionary<uint, bool> m_BigEventIsTodaySignedDict;

	private Dictionary<uint, uint> m_BigEventCurrentSignInDict;

	private Dictionary<uint, uint> m_BigEventClaimableSignInDict;

	private List<BigEventMatchResultTaskDesc> m_MatchResultTaskInfoList;

	public const int PropID_RefreshAllBigEventEntrance = 2;

	public const int PropID_ExchangeStoreDataUpdate = 4;

	public const int PropID_AFKGroupInfoUpdate = 16;

	public const int PropID_AFKGroupActivityUpdate = 32;

	public const int PropID_SearchAFKGroupInfoReceived = 64;

	public const int PropID_AFKGroupStateChanged = 128;

	public const int PropID_AFKJoinGroupSucceed = 256;

	public const int PropID_AFKJoinGroupFailed = 512;

	public const int PropID_AFKCreateGroupSucceed = 1024;

	public const int PropID_RefreshAllLimitedEventEntrances = 2048;

	public const int PropID_SignInSettingReady = 4096;

	public const int PropID_SignInInfoUpdate = 8192;

	public const int PropID_SignInSuccess = 16384;

	public const int PropID_TokenDescReady = 32768;

	public const int PropID_WarmUpShowAwardSetting = 65536;

	public const int PropID_TokenInfoChanged = 131072;

	public const int PropID_TokenInfoInGame = 262144;

	public const uint TipType_PeakDay = 2u;

	public const uint TipType_DailyTask = 4u;

	public const uint TipType_SignIn = 8u;

	public const uint TipType_ExchangeStoreOpen = 16u;

	public const uint TipType_ExchangeStoreCanPurchase = 32u;

	public const uint TipType_MainEntrances = 64u;

	private Dictionary<uint, uint> m_StoreRedPointThresholdDict;

	private const string ExchangeStoreRedPointSwitchKey = "ExchangeStoreRedPointSwitch";

	public bool HasShowedForcedRedDot;

	public const string FORCED_REDDOT_DAY = "FORCEDREDDOT_DAY_{0}";

	public const string FORCED_REDDOT_TIMES = "FORCEDREDDOT_TIMES_{0}";

	public const uint GMAEMODE_BR = 1u;

	public const uint GMAEMODE_CS = 15u;

	public const uint GMAEMODE_LW = 43u;

	public const string BRDROPNUM = "T_46_LXW_GLOOWORLDSYS_BRDROPNUM";

	public const string CSDROPNUM = "T_46_LXW_GLOOWORLDSYS_CSDROPNUM";

	public const string LWDROPNUM = "T_46_LXW_GLOOWORLDSYS_LWDROPNUM";

	public const string DEFAULT_LAN = "default";

	public bool m_HasRequestTokenInGame;

	private bool m_IsNeedProcessDeepLinkBigEvent;

	public const string HasBigEventReunionOpened = "HasBigEventReunionOpened_";

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<BigEventEntryDesc> GetEventAutoEntryDesc()
	{
		return null;
	}

	public void ProcessExchangeTipsDesc(CSGetExchangeCurrencyLocalRes res)
	{
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void SceneChange(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessDeepLinkBigEvent()
	{
	}

	public void RequestEventInventorySetting(uint bigEventID)
	{
	}

	public void RequestEventWarmUpShowAwardSetting(uint eventId)
	{
	}

	public void RequestGetBigEventOpenInfo(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void ProcessEventOpenInfo()
	{
	}

	public List<int> GetAllValidBigEventId()
	{
		return null;
	}

	private void ProcessAllEventOpenInfo()
	{
	}

	public void PrecessAllEventCDNSetting()
	{
	}

	private void ProcessPreLoadCDNImageInfo()
	{
	}

	private void ProcessMatchResultTaskInfo()
	{
	}

	private void ProcessAllEventMovies()
	{
	}

	private void ProcessAllEventEntrances(List<BigEventEntranceSettingDesc> eventEntrances)
	{
	}

	private void ProcessAllLocalMailEntrances(List<BigEventLocalMailDesc> eventLocalMails)
	{
	}

	public BigEventLocalMailDesc GetLocalMailDesc(uint emailId)
	{
		return null;
	}

	private MailInfo CreateBigEventLocalMailInfo(BigEventLocalMailDesc mailDesc, EMail.Status state)
	{
		return null;
	}

	public IBigEventModel GetBigEventModelById(int eventId)
	{
		return null;
	}

	public void TraveseOpenInfoDic()
	{
	}

	public void RequestClaimLimitedEventSettleReward(uint eventID, string key)
	{
	}

	public EBigEventEntranceState GetBigEventEntranceStateByTwoType(ELimitedEvent.EventID event_id, EBigEventEntranceID entrance_id)
	{
		return (EBigEventEntranceState)0;
	}

	public EBigEventEntranceState GetBigEventEntranceStateByTwoType(ELimitedEvent.EventID event_id, EBigEventEntranceID entrance_id, out BigEventEntranceSettingDesc desc)
	{
		desc = null;
		return (EBigEventEntranceState)0;
	}

	public BigEventEntranceSettingDesc GetBigEventEntranceDescByTwoType(ELimitedEvent.EventID event_id, EBigEventEntranceID entrance_id)
	{
		return null;
	}

	public List<ELimitedEvent.EventID> GetCurrentProcessEventId()
	{
		return null;
	}

	public List<uint> GetBigEventEntranceIDs(ELimitedEvent.EventID event_id)
	{
		return null;
	}

	public List<BigEventMatchResultTaskDesc> GetBigEventDailyActivitySubType(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public List<BigEventOpenInfoDesc> GetEventOpenInfoListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public List<BigEventCDNDesc> GetCDNSettingListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public List<BigEventEntryDesc> GetBigEventEntryDescsById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public BigEventMovieDesc GetBigEventMovieUrlById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public string GetEventCDNUrlByEventIDAndType(ELimitedEvent.EventID id, int type)
	{
		return null;
	}

	public ELimitedEvent.EventState GetBigEventStateById(ELimitedEvent.EventID eventID)
	{
		return ELimitedEvent.EventState.EventState_NONE;
	}

	public BigEventOpenInfoDesc GetEventOpenInfoByIdAndState(ELimitedEvent.EventID eventID, ELimitedEvent.EventState state)
	{
		return null;
	}

	public EBigEventStatus GetEventStatusByIdAndState(ELimitedEvent.EventID eventID, ELimitedEvent.EventState state)
	{
		return EBigEventStatus.EBigEventStatus_NotStart;
	}

	public string GetBigEventEntryDataTitle(BigEventEntryDesc DescData)
	{
		return null;
	}

	public string GetBigEventLocalMailTitle(string localMailTitles)
	{
		return null;
	}

	public BigEventOpenInfoDesc GetEventAutoEntryOpenInfo()
	{
		return null;
	}

	public BigEventOpenInfoDesc GetEventProcessOpenInfo()
	{
		return null;
	}

	public ELimitedEvent.EventID GetEntryIdByEventState(ELimitedEvent.EventState eventState)
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public ELimitedEvent.EventID GetEventAutoEntryId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public string GetBigEventEntrancePeriod(ELimitedEvent.EventID eventID, EBigEventEntranceID entranceID)
	{
		return null;
	}

	public string GetBigEventOpenPeriod(ELimitedEvent.EventID eventID, DateFormatByDiffRegionDataManager.DateFormataType dateFormat = DateFormatByDiffRegionDataManager.DateFormataType.MD)
	{
		return null;
	}

	public uint GetOpenInfoEndTime(ELimitedEvent.EventID eventID)
	{
		return 0u;
	}

	public void ChangeNotify(BigEventEntryDesc entryDesc, bool state)
	{
	}

	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, BigEventEntryDesc entryDesc)
	{
		return null;
	}

	public BigEventTokenInfo GetTokenInfo(uint tokenId, bool needCreate = false)
	{
		return null;
	}

	public BigEventModeToken GetModeTokenInfo(uint tokenId, uint gameMode)
	{
		return null;
	}

	public void SetTokenInfo(uint tokenId, uint gameMode, uint dailyNum, uint dailyTotal)
	{
	}

	protected BigEventTokenInfo AddTokenInfo(uint tokenId)
	{
		return null;
	}

	protected BigEventModeToken AddModeTokenInfo(BigEventTokenInfo tokenInfo, uint gameMode)
	{
		return null;
	}

	public void OnTcpTokenChangeCallback(uint tokenId, int count)
	{
	}

	public uint GetTokenCount(uint tokenId)
	{
		return 0u;
	}

	public bool TryGetTokenID(ELimitedEvent.EventID eventID, ref uint tokenID)
	{
		return false;
	}

	public ResourceID GetTokenIconRes(uint tokenId)
	{
		return default(ResourceID);
	}

	public void RequestTokenInfo(ELimitedEvent.EventID eventID, uint http_option = 0u)
	{
	}

	public void RequestTokenTipsDesc(ELimitedEvent.EventID eventID, uint http_option = 0u)
	{
	}

	public void RequestTokenLimitedInGame()
	{
	}

	public void RequestTokenLimitedByTokenInfo()
	{
	}

	public void RequestTokenLimitedInGame(uint tokenId)
	{
	}

	public List<BigEventTokenTipsDesc> GetTokenTipsDescs(uint tokenId)
	{
		return null;
	}

	public List<TokenTipsData> GetTokenUseChannel(uint tokenId, bool needItemConsumeSummary = true)
	{
		return null;
	}

	public List<TokenTipsData> GetTokenUseChannels(uint tokenId, bool needItemConsumeSummary = true)
	{
		return null;
	}

	public List<TokenTipsData> GetTokenSourceChannel(uint tokenId, bool needItemChannelInfo = false)
	{
		return null;
	}

	public List<TokenTipsData> GetTokenSourceChannel(List<uint> tokenIdList, ref bool requested, bool needItemChannelInfo = false)
	{
		return null;
	}

	public List<TokenTipsData> GetTokenTipsDataList(uint tokenId)
	{
		return null;
	}

	public BigEventTokenTipsDesc GetTokenTipsDesc(uint tokenId, uint gameMode)
	{
		return null;
	}

	public ExchangeCurrencyLocalUseDesc GetTokenTipsUseData(uint Id)
	{
		return null;
	}

	public uint GetTokenIdByEventId(ELimitedEvent.EventID event_id)
	{
		return 0u;
	}

	public void RequestExchangeStoreData(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType)
	{
	}

	public void SetExchangeStoreMinPrince(LimitedEventStore storeDesc)
	{
	}

	public void SortExchangeStoreItemList(List<BigEventStoreCommodityDesc> storeItemList)
	{
	}

	public bool IsExchangeStoreHasRedPoint(ELimitedEvent.EventID eventID)
	{
		return false;
	}

	public bool IsExchangeStoreHasRedPoint(ELimitedEvent.EventID eventID, uint storeId)
	{
		return false;
	}

	public bool IsNeedShowEntrancesRedPoint(ELimitedEvent.EventID eventID, Func<uint, bool> isCaredEntranceID = null)
	{
		return false;
	}

	private bool IsCaredEntranceID_Default(uint entrance_id)
	{
		return false;
	}

	public void SetExchangeStoreRedPointSwitch(ELimitedEvent.EventID eventID, int value)
	{
	}

	public bool IsExchangeStoreRedPointSwitchOpen(ELimitedEvent.EventID eventID)
	{
		return false;
	}

	public bool IsExchangeStoreNewOpen(ELimitedEvent.EventID eventID)
	{
		return false;
	}

	public List<LimitedEventStore> GetExchangeStoreDataListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	public LimitedEventStore GetExchangeStoreDataById(ELimitedEvent.EventID eventID, uint storeId)
	{
		return null;
	}

	public void RequestExchangeStorePurchase(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType, BigEventStoreCommodityDesc desc, bool useCommonReward = true, uint cnt = 1u)
	{
	}

	public void RequestAccountAFKGroupInfo(bool force = false)
	{
	}

	public void RequestAFKGroupInfo(ulong groupID, bool filter = true)
	{
	}

	public void RequestCreateAFKGroup()
	{
	}

	public void RequestJoinAFKGroup(ulong groupID, ELimitedEvent.GoliathGroupJoinSource source, bool isInvitedByShare = false)
	{
	}

	public void RequestCaptainActivity()
	{
	}

	public void ClaimAFKGroupAwards(ulong groupID, ulong captainID)
	{
	}

	public Dictionary<ulong, GoliathAFKGroupInfo> GetAllAFKGroupInfo()
	{
		return null;
	}

	public ulong GetAFKGroupInAdvanceStartTime(ulong groupID)
	{
		return 0uL;
	}

	public void NotifyAFKGroupInfoUpdate(ulong groupID)
	{
	}

	public uint GetCaptainActivityID()
	{
		return 0u;
	}

	public void SetAFKFriendInviteCD(ulong friendId)
	{
	}

	public string GetBigEventPeakDayPeriod(EActivity.SubType subType)
	{
		return null;
	}

	public string GetPeakDayMonthString(int month)
	{
		return null;
	}

	public EPeakDayState GetBigEventPeakDayState(EActivity.SubType subType)
	{
		return EPeakDayState.Invalid;
	}

	public EPeakDayState GetBigEventPeakDayState(ClientActivityDesc desc)
	{
		return EPeakDayState.Invalid;
	}

	public bool IsBigEventActivityFinished(EEventType activityType, EActivity.SubType subType)
	{
		return false;
	}

	public string GetBigEventMailIcon(ELimitedEvent.EventID eventId)
	{
		return null;
	}

	public bool HasBigEventReunionOpenedThisVersion()
	{
		return false;
	}

	public void OpenBigEventReunionThisVersion()
	{
	}

	public BigEventBadgeDesc GetEventInventorySettingByID(uint bigEventID, uint itemID)
	{
		return null;
	}

	private void LogoutSignInData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public string GetBigEventParamStrByLangeFormat(string paramStr)
	{
		return null;
	}

	private void _003CRequestGetBigEventOpenInfo_003Eb__96_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAccountAFKGroupInfo_003Eb__172_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCreateAFKGroup_003Eb__174_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCaptainActivity_003Eb__176_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SceneChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
