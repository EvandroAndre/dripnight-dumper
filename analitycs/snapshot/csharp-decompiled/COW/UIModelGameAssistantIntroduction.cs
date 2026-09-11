using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelGameAssistantIntroduction : UIBaseModel
{
	private class TodayBattleReportHighlightMomentAdapter
	{
		private const int MaxAssistItemCount = 10;

		private readonly MobileReplayManager m_ReplayManager;

		private readonly List<UIModelBRMatchReview.TodayReviewAssistInfo> m_TodayReviewAssistInfoList;

		private readonly ulong m_TodayStartTimeStamp;

		private readonly ulong m_TodayEndTimeStamp;

		private readonly ulong m_CurrentAccountId;

		public TodayBattleReportHighlightMomentAdapter(MobileReplayManager replayManager, List<UIModelBRMatchReview.TodayReviewAssistInfo> todayReviewAssistInfoList)
		{
		}

		public List<IGameAssistItemData> BuildAssistDataList()
		{
			return null;
		}

		private void CollectHighlightAssistInfo(Dictionary<ulong, AssistHighlightMomentInfo> assistInfoMap)
		{
		}

		private void CollectPostReviewAssistInfo(Dictionary<ulong, AssistHighlightMomentInfo> assistInfoMap)
		{
		}

		private bool TryGetTodayHighlightEndTimeStamp(MobileReplayInfo replayInfo, out ulong endMatchTimeStamp)
		{
			endMatchTimeStamp = default(ulong);
			return false;
		}

		private void LogSkippedHighlightAssistInfo(string reason, MobileReplayInfo replayInfo, string matchDateText = "")
		{
		}

		private int GetCollectionCount(ICollection collection)
		{
			return 0;
		}

		private AssistHighlightMomentInfo GetOrCreateAssistInfo(Dictionary<ulong, AssistHighlightMomentInfo> assistInfoMap, ulong matchId, ulong endMatchTimeStamp)
		{
			return null;
		}

		private List<IGameAssistItemData> BuildSortedAssistDataList(Dictionary<ulong, AssistHighlightMomentInfo> assistInfoMap)
		{
			return null;
		}

		private int CompareAssistInfo(AssistHighlightMomentInfo left, AssistHighlightMomentInfo right)
		{
			return 0;
		}
	}

	public class DailyReportRankChartAdapterResult
	{
		public static readonly DailyReportRankChartAdapterResult Empty;

		private List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> _003CBRRecords_003Ek__BackingField;

		private List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> _003CCSRecords_003Ek__BackingField;

		private bool _003CDefaultIsBR_003Ek__BackingField;

		private uint _003CBRMinCalibration_003Ek__BackingField;

		private uint _003CCSMinCalibration_003Ek__BackingField;

		public List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> BRRecords
		{
			get
			{
				return _003CBRRecords_003Ek__BackingField;
			}
			private set
			{
				_003CBRRecords_003Ek__BackingField = value;
			}
		}

		public List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> CSRecords
		{
			get
			{
				return _003CCSRecords_003Ek__BackingField;
			}
			private set
			{
				_003CCSRecords_003Ek__BackingField = value;
			}
		}

		public bool DefaultIsBR
		{
			get
			{
				return _003CDefaultIsBR_003Ek__BackingField;
			}
			private set
			{
				_003CDefaultIsBR_003Ek__BackingField = value;
			}
		}

		public uint BRMinCalibration
		{
			get
			{
				return _003CBRMinCalibration_003Ek__BackingField;
			}
			private set
			{
				_003CBRMinCalibration_003Ek__BackingField = value;
			}
		}

		public uint CSMinCalibration
		{
			get
			{
				return _003CCSMinCalibration_003Ek__BackingField;
			}
			private set
			{
				_003CCSMinCalibration_003Ek__BackingField = value;
			}
		}

		public DailyReportRankChartAdapterResult(List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> brRecords, List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> csRecords, bool defaultIsBR, uint brMinCalibration, uint csMinCalibration)
		{
		}

		public int GetMatchCount(bool isBR)
		{
			return 0;
		}

		public List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> GetRecords(bool isBR)
		{
			return null;
		}

		public uint GetMinCalibration(bool isBR)
		{
			return 0u;
		}
	}

	private class DailyReportRankChartAdapter
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<DailyRankingSummary.match> _003C_003E9__8_0;

			public static Comparison<DailyCSRankingSummary.match> _003C_003E9__9_0;

			internal int _003CConvertFrom_003Eb__8_0(DailyRankingSummary.match left, DailyRankingSummary.match right)
			{
				return 0;
			}

			internal int _003CConvertFrom_003Eb__9_0(DailyCSRankingSummary.match left, DailyCSRankingSummary.match right)
			{
				return 0;
			}
		}

		private const uint DefaultBRMinCalibration = 50u;

		private const uint DefaultCSMinCalibration = 1u;

		private readonly DailyRankingSummary m_DailyRankingSummary;

		private readonly DailyCSRankingSummary m_DailyCSRankingSummary;

		private readonly NewHelperParamDesc m_NewHelperParamDesc;

		private readonly MobileReplayManager m_ReplayManager;

		public DailyReportRankChartAdapter(DailyRankingSummary dailyRankingSummary, DailyCSRankingSummary dailyCSRankingSummary, NewHelperParamDesc newHelperParamDesc, MobileReplayManager replayManager)
		{
		}

		public DailyReportRankChartAdapterResult Build()
		{
			return null;
		}

		private List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> ConvertFrom(DailyRankingSummary summary)
		{
			return null;
		}

		private List<UILobbyV2GameAssistTodayBattleReportRankChartController.RankChartRecord> ConvertFrom(DailyCSRankingSummary summary)
		{
			return null;
		}

		private bool IsDefaultBR(DailyRankingSummary brSummary, DailyCSRankingSummary csSummary)
		{
			return false;
		}

		private long GetLatestEndAt(DailyRankingSummary summary)
		{
			return 0L;
		}

		private long GetLatestEndAt(DailyCSRankingSummary summary)
		{
			return 0L;
		}

		private uint GetBRMinCalibration()
		{
			return 0u;
		}

		private uint GetCSMinCalibration()
		{
			return 0u;
		}

		private int ConvertToInt(uint value)
		{
			return 0;
		}

		private EHighLightPlayType GetHighlightType(ulong matchId)
		{
			return EHighLightPlayType.None;
		}

		private string FormatTimeText(long endAt)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IGameAssistItemData> _003C_003E9__154_0;

		internal int _003CRequestExpiredTeamUpPresence_003Eb__154_0(IGameAssistItemData a, IGameAssistItemData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public uint Id;

		internal bool _003CGetAssistItemByTypeAndId_003Eb__0(IGameAssistItemData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public uint id;

		internal bool _003CHasAssistDataTriggered_003Eb__0(IGameAssistItemData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public UIModelGameAssistantIntroduction _003C_003E4__this;

		public string cmd;

		internal void _003CRequestDailyRankingSummary_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public UIModelGameAssistantIntroduction _003C_003E4__this;

		public string cmd;

		internal void _003CRequestDailyCSRankingSummary_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public UIModelGameAssistantIntroduction _003C_003E4__this;

		public string cmd;

		internal void _003CRequestSmartAssistantMessagesData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIModelGameAssistantIntroduction _003C_003E4__this;

		public string cmd;

		internal void _003CUpdateSmartAssistantReadMessagesData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_0
	{
		public AssistExpiredTeamUpInfo teamupInfo;

		internal bool _003CRequestExpiredTeamUpPresence_003Eb__1(ulong temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_1
	{
		public AssistExpiredTeamUpInfo teamupInfo;

		internal bool _003CRequestExpiredTeamUpPresence_003Eb__2(ulong temp)
		{
			return false;
		}
	}

	public const byte PropID_GetMessages = 1;

	public const byte PropID_UpdateMessages = 2;

	public const byte PropID_RefreshAssistWndView = 4;

	public const byte PropID_RefreshClanSearchView = 8;

	public const byte PropID_GetDailyRankingSummary = 16;

	public const byte PropID_GetDailyCSRankingSummary = 32;

	public const ulong EXPIRE_DAYS = 3uL;

	private const uint FRIEND_REQUEST_NUM_BORDER = 8u;

	private bool m_ReadyTriggerFlag;

	private bool m_IsRegionOpen;

	private bool m_MeetVeteranCondition;

	public const string ASSISTBUBBLEDEFAULTICON = "UI_Assistant_MessageBox";

	public const string MEMBERSHIP_CRAD_REWARD_KEY = "GAMEASSIST_MEMBERSHIP_REWARD_CARD_{0}_{1}";

	public const string MEMBERSHIP_CRAD_TIPS_KEY = "GAMEASSIST_MEMBERSHIP_TIPS_CARD_{0}_{1}";

	public const string EVO_PASS_CARD_TIPS_KEY = "GAMEASSIST_EVO_PASS_CARD_TIPS_CARD_{0}";

	public const string UGC_PREMIUM_CARD_TIPS_KEY = "GAMEASSIST_UGC_PREMIUM_TIPS_CARD_{0}";

	public const string ASSIST_TAB_RED_POINT = "GAMEASSIST_TAB_REDPOINT_{0}_{1}";

	private const ulong ALWAYS_ON_TODAY_BATTLE_REPORT_ASSIST_ID = ulong.MaxValue;

	private const long TODAY_BATTLE_REPORT_MATCH_REVIEW_MIN_DURATION_MS = 360000L;

	private const string TODAY_BATTLE_REPORT_TEXT_BUBBLE_KEY = "GAMEASSIST_TODAY_BATTLE_REPORT_TEXT_BUBBLE_{0}_{1}";

	private const int TODAY_BATTLE_REPORT_BUBBLE_STATE_NONE = 0;

	private const int TODAY_BATTLE_REPORT_BUBBLE_STATE_TEXT_SHOWN = 1;

	private const int TODAY_BATTLE_REPORT_BUBBLE_STATE_CLICKED = 2;

	private const int TODAY_BATTLE_REPORT_BUBBLE_STATE_TEXT_PENDING_COMMIT = 3;

	private readonly List<HelperMessageDesc> m_ListCurMatchUnReadMessageConfigData;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private int m_TestPlayerType;

	private EGameAssistantMessageType m_WishListMessageType;

	private Dictionary<uint, List<IGameAssistItemData>> m_DictStateIdToDataDic;

	private bool[] m_BubbleHasDataArray;

	private Dictionary<uint, uint> m_IDToFFAssistLogTypeDict;

	private Dictionary<uint, EventLogger.EventTypeAssistNoticeInfos> m_IDToFFAssistNoticeLogTypeDict;

	private List<ulong> m_AssistClanInviteIDList;

	public bool[] HasInitTitle;

	private ELobbyAssistDataType m_LastBubbleType;

	private readonly Dictionary<uint, HelperMessageDesc> m_DicIDToHelperMessageData;

	private NewHelperParamDesc m_NewHelperParamDesc;

	private DailyRankingSummary m_DailyRankingSummary;

	private DailyCSRankingSummary m_DailyCSRankingSummary;

	private TodayBattleReportBubbleSource m_CurrentTodayBattleReportBubbleSource;

	private readonly List<AssistHighlightMomentInfo> m_TodayBattleReportHighlightMomentItems;

	private DailyReportRankChartAdapterResult m_DailyReportRankChartAdapterResult;

	private bool m_DailyRankingSummaryArrived;

	private bool m_DailyCSRankingSummaryArrived;

	private bool m_GameAssistantDescReady;

	public static int PickWeaponType;

	private bool m_RequestExpiredTeamUpPresenceing;

	private List<IGameAssistItemData> m_AssistExpiredTeamUpAllInfos;

	private Dictionary<ulong, IGameAssistItemData> m_AssistExpiredTeamUpInfoDict;

	private List<IGameAssistItemData> m_AssistExpiredTeamUpInfos;

	private Dictionary<ulong, bool> m_AssistExpiredTeamUpRequestAddFriendDict;

	public EGameAssistantMessageType WishListMessageType
	{
		get
		{
			return EGameAssistantMessageType.None;
		}
		set
		{
		}
	}

	public bool MeetVeteranCondition => false;

	public Dictionary<uint, List<IGameAssistItemData>> DictStateIdToDataDic => null;

	public int TestPlayerType => 0;

	public Dictionary<ulong, bool> AssistExpiredTeamUpRequestAddFriendDict => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void ResetHasInitTitle()
	{
	}

	private bool CheckHasSameItemData(List<IGameAssistItemData> itemDataList, IGameAssistItemData itemData)
	{
		return false;
	}

	private List<uint> GetAssistContentPriorityNum()
	{
		return null;
	}

	private List<uint> GetAssistBubblePriorityNum()
	{
		return null;
	}

	private AssistTodayBattleReportInfo CreateAlwaysOnTodayBattleReportInfo()
	{
		return null;
	}

	public void RefreshTodayBattleReportHighlightMomentAssist(bool needRefreshAssistView)
	{
	}

	public void InvalidateTodayBattleReportSummary(bool invalidateBR, bool invalidateCS)
	{
	}

	public void PrepareTodayBattleReportData(bool needRefreshAssistView = true)
	{
	}

	private void FilterTodayBattleReportHighlightMomentItems(List<IGameAssistItemData> aggregateList)
	{
	}

	private void BuildDailyReportRankChartAdapterResult()
	{
	}

	private void NotifyTodayBattleReportBubbleRefresh()
	{
	}

	private bool HasTodayBattleReportBubbleData()
	{
		return false;
	}

	private bool HasHighlightMomentBubbleData()
	{
		return false;
	}

	private bool HasUnreadHighlightBubbleData()
	{
		return false;
	}

	private bool HasUnreadPostReviewBubbleData()
	{
		return false;
	}

	public int GetTodayBattleReportBubbleAggregateCount(bool includeHighlight)
	{
		return 0;
	}

	public bool NeedShowTodayBattleReportTextBubble(ELobbyAssistDataType bubbleType)
	{
		return false;
	}

	public void MarkTodayBattleReportTextBubbleShown()
	{
	}

	public void MarkTodayBattleReportBubbleClicked()
	{
	}

	public bool NeedShowTodayBattleReportBubbleReminder()
	{
		return false;
	}

	public TodayBattleReportBubbleSource GetCurrentTodayBattleReportBubbleSource()
	{
		return TodayBattleReportBubbleSource.None;
	}

	private string GetTodayBattleReportTextBubbleKey()
	{
		return null;
	}

	private int GetTodayBattleReportBubbleState()
	{
		return 0;
	}

	private bool HasDailyReportBubbleData()
	{
		return false;
	}

	private int GetPositiveConfigValue(uint value)
	{
		return 0;
	}

	public bool IsBattlereportOpen()
	{
		return false;
	}

	private bool IsTodayBattleReportConfigOpen()
	{
		return false;
	}

	private bool IsHighLightOpen()
	{
		return false;
	}

	private bool IsMatchReviewOpen()
	{
		return false;
	}

	private bool IsDailyReportOpen()
	{
		return false;
	}

	private bool IsTodayBattleReportABMatched()
	{
		return false;
	}

	public void SetAssistTypeLogToDict(uint id, uint type)
	{
	}

	public void SendAssistLog()
	{
	}

	public void SetAssistNoticeLogToDict(uint tabID, string itemID)
	{
	}

	public void SendAssistNoticeLog()
	{
	}

	public bool checkWndTabEqualDataType(ELobbyAssistWndTab wndTabType, IGameAssistItemData data)
	{
		return false;
	}

	public string GetTitleKeyByDataType(ELobbyAssistDataType type)
	{
		return null;
	}

	public string GetCardSpriteNameByVipCardType(proto.EVipCard.VipCardType vipCardType, bool isBig = false)
	{
		return null;
	}

	public IGameAssistItemData GetAssistItemByTypeAndId(ELobbyAssistDataType type, uint Id)
	{
		return null;
	}

	public int GetDataListNumByDataType(ELobbyAssistDataType type)
	{
		return 0;
	}

	public void RequestAssistClanInviteList()
	{
	}

	public void StoreClanInviteData(ulong clanId)
	{
	}

	public void GetGoPosByDataType(ELobbyAssistDataType type, out uint goPos, out string param)
	{
		goPos = default(uint);
		param = null;
	}

	public string GetTitleSpriteNameByDataType(ELobbyAssistDataType type)
	{
		return null;
	}

	public string GetBubbleSpriteNameByDataType(ELobbyAssistDataType type)
	{
		return null;
	}

	public string GetTabSpriteNameByTabType(ELobbyAssistWndTab type)
	{
		return null;
	}

	public bool[] GetBubbleDataArray()
	{
		return null;
	}

	public List<int> GetDataTypeListByWndType(ELobbyAssistWndTab type)
	{
		return null;
	}

	public ELobbyAssistWndTab GetWndTabByDataType(ELobbyAssistDataType bubbleType)
	{
		return ELobbyAssistWndTab.RewardTab;
	}

	public List<IGameAssistItemData> GetOneOfAssistDataListByType(uint type)
	{
		return null;
	}

	public List<IGameAssistItemData> GetAssistDataList(bool firstBuild)
	{
		return null;
	}

	public List<IGameAssistItemData> DataListSort(uint stateId, List<IGameAssistItemData> list)
	{
		return null;
	}

	public int DataListSortWishList(IGameAssistItemData x, IGameAssistItemData y)
	{
		return 0;
	}

	public void SetBubbleDicByType(int index, bool noData)
	{
	}

	public void OneOfAssistDataReady(int type)
	{
	}

	public bool CheckAllAssistDataReady()
	{
		return false;
	}

	public void HideAllCdnItemNextTime()
	{
	}

	public void RemoveDataListFromDataDic(ELobbyAssistDataType type, bool needRefreshAssistView)
	{
	}

	public void AddDataToDataDic(ELobbyAssistDataType type, IGameAssistItemData itemData)
	{
	}

	public void ReAddDataToDataDic(ELobbyAssistDataType type, List<IGameAssistItemData> assistItemDataList, bool needRefreshAssistView)
	{
	}

	public void ResetAssistDataAddByType(uint type)
	{
	}

	public bool CheckShowBigAssistWnd(ELobbyAssistDataType type)
	{
		return false;
	}

	public ELobbyAssistDataType GetCurBubbleType(bool checkNewMessage)
	{
		return ELobbyAssistDataType.None;
	}

	public bool ReadyCheck()
	{
		return false;
	}

	public bool HasAssistDataTriggered(uint type, uint id)
	{
		return false;
	}

	public void ClearLastMatchCacheData()
	{
	}

	public void UpdateEventMessageTypeByTrigger(HelperMessageDesc gameAssistantData)
	{
	}

	public void UpdateNotifyMessageQueue()
	{
	}

	public void SendTriggeredUnReadLog()
	{
	}

	public void ProcessGameAssistantDesc(List<HelperMessageDesc> helperMessageDescList, List<NewHelperParamDesc> newHelperParamDescList = null)
	{
	}

	public void RequestDailyRankingSummary(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestDailyCSRankingSummary(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestSmartAssistantMessagesData(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateSmartAssistantReadMessagesData()
	{
	}

	public void UpdateWishListStatusData(List<WishItemOutputInfoNtf> items)
	{
	}

	public Dictionary<uint, HelperMessageDesc> GetGameAssistantConfigDataDic()
	{
		return null;
	}

	public HelperMessageDesc GetGameAssistantConfigDataById(uint id)
	{
		return null;
	}

	public NewHelperParamDesc GetNewHelperParamDesc()
	{
		return null;
	}

	public DailyRankingSummary GetDailyRankingSummary()
	{
		return null;
	}

	public DailyCSRankingSummary GetDailyCSRankingSummary()
	{
		return null;
	}

	public DailyReportRankChartAdapterResult GetDailyReportRankChartAdapterResult()
	{
		return null;
	}

	public bool IsPlayerTypeCorrect(HelperMessageDesc configData)
	{
		return false;
	}

	public void SetTestPlayerType(int type)
	{
	}

	public void AddExpiredTeamUpToList(GroupInviteNtf inviteNtf)
	{
	}

	public void AddExpiredTournamentToList(RoomInviteNtf inviteNtf)
	{
	}

	public void RequestExpiredTeamUpPresence()
	{
	}

	public void RefreshExpiredTeamUpPresence()
	{
	}

	public void UpdateExpiredTeamUp()
	{
	}

	public GroupInviteNtf GetAssistExpiredTeamUpInfoByID(ulong accountId)
	{
		return null;
	}

	public void RemoveGetGiftDataFromDic(ulong mailID)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
