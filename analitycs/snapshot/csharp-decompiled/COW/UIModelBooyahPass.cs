using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelBooyahPass : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<EPDailyProcessRewardDesc> _003C_003E9__262_0;

		public static Comparison<BooyahPassBaseItemData> _003C_003E9__423_0;

		public static Comparison<BooyahPassBaseItemData> _003C_003E9__424_0;

		internal int _003CSetBPDailyProcessDescList_003Eb__262_0(EPDailyProcessRewardDesc a, EPDailyProcessRewardDesc b)
		{
			return 0;
		}

		internal int _003CSortPurchaseTipsRewardItemList_003Eb__423_0(BooyahPassBaseItemData x, BooyahPassBaseItemData y)
		{
			return 0;
		}

		internal int _003CSortPreviewRewardItemList_003Eb__424_0(BooyahPassBaseItemData x, BooyahPassBaseItemData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass190_0
	{
		public UIModelBooyahPass _003C_003E4__this;

		public bool isPremiumPlus;

		internal void _003CRequestPurchaseBP_003Eb__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public AccountBPBriefInfo item;

		internal bool _003CRequestGetInfoByAccountIDs_003Eb__1(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass203_0
	{
		public UIModelBooyahPass _003C_003E4__this;

		public uint nodeID;

		public bool claimChallengeReward;

		public ChallengeRewardParam challengeRewardParam;

		internal void _003CRequestClaimDailyProcessRewardByNodeID_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass204_0
	{
		public UIModelBooyahPass _003C_003E4__this;

		public uint week;

		public uint challengeID;

		public int curChallengeIDIndex;

		internal void _003CRequestRefreshWeeklyChallenge_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass206_0
	{
		public UIModelBooyahPass _003C_003E4__this;

		public List<unlock> claimList;

		public bool isCircleReward;

		internal void _003CRequestClaimReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public UIModelBooyahPass _003C_003E4__this;

		public uint maxClaimNum;

		public int friendCnt;

		public bool isclaimAll;

		internal void _003CRequestClaimShareExp_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass208_0
	{
		public ChallengeType challengeType;

		public AutoOpenIntegrationData nodeIntegrationData;

		public UIModelBooyahPass _003C_003E4__this;

		public List<uint> challengeIDs;

		public uint challengeGroup;

		internal void _003CRequestClaimChallengeReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass209_0
	{
		public bool isAutoSend;

		public UIModelBooyahPass _003C_003E4__this;

		public ulong[] idList;

		public uint canSendNum;

		public List<ulong> realSendIdList;

		public uint needSendNum;

		public bool isAllClaim;

		public bool isAllSend;

		internal void _003CRequestSendShareExp_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass209_1
	{
		public ulong item;

		internal bool _003CRequestSendShareExp_003Eb__1(ulong x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass211_0
	{
		public List<uint> challengeIDs;

		public UIModelBooyahPass _003C_003E4__this;

		internal void _003CRequestClaimChallengeRewardInMatchResult_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public BooyahPassBaseItemData baseItem;

		internal bool _003CRefreshRewardItemStatus_003Eb__0(unlock x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_0
	{
		public BooyahPassBaseItemData fpItemData;

		public BooyahPassBaseItemData ppItemData1;

		internal bool _003CInitRewardItemList_003Eb__0(RewardStatus x)
		{
			return false;
		}

		internal bool _003CInitRewardItemList_003Eb__1(RewardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_1
	{
		public BooyahPassBaseItemData ppItemData2;

		internal bool _003CInitRewardItemList_003Eb__2(RewardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_2
	{
		public BooyahPassBaseItemData ppItemData1;

		internal bool _003CInitRewardItemList_003Eb__3(RewardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_3
	{
		public BooyahPassBaseItemData ppItemData2;

		internal bool _003CInitRewardItemList_003Eb__4(RewardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass381_0
	{
		public uint grade;

		internal bool _003CGetRewardItemByGrade_003Eb__0(BooyahPassRewardItemData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass382_0
	{
		public uint baseItemIndex;

		public Predicate<BooyahPassBaseItemData> _003C_003E9__0;

		internal bool _003CGetBaseItemByIndex_003Eb__0(BooyahPassBaseItemData x)
		{
			return false;
		}
	}

	public const uint PropID_GetShareExpInfo = 1u;

	public const uint PropID_GetBpAllDesc = 2u;

	public const uint PropID_GetBpMainInfo = 4u;

	public const uint PropID_BooyahPassPurchased = 8u;

	public const uint PropID_IAP_BooyahPassPurchased = 32u;

	public const uint PropID_ClaimChallengeDailyReward = 64u;

	public const uint PropID_ClaimReward = 128u;

	public const uint PropID_GetBPFriendInfoByAccountIDs = 256u;

	public const uint PropID_GetBPExpShareList = 512u;

	public const uint PropID_ClaimShareExp = 1024u;

	public const uint PropID_SendShareExp = 2048u;

	public const uint PropID_ClaimChallengeReward = 4096u;

	public const uint PropID_IAP_ProductsUpdated = 8192u;

	public const uint PropID_LevelExpPurchased = 8192u;

	public const uint PropID_PremiumPassPresentSent = 16384u;

	public const uint PropID_PremiumPassPresentReceived = 32768u;

	public const uint PropID_MatchResultChallengeRewardClaimed = 65536u;

	public const uint PropID_SubscriptionBonusStatusUpdated = 131072u;

	public const uint PropID_RefreshTaskContent = 262144u;

	public const uint PropID_MatchResultNodeRewardClaimed = 524288u;

	private const uint SHOWPRIVILEGEGRADE = 1u;

	public const uint BP_EXP_ID = 2000000000u;

	public const uint BigSizeRewardCount = 2u;

	public const uint FIRST_BP_EVENTID = 56u;

	public const uint PRIVILEGE_BP_EVENTID = 69u;

	public const uint EACH_LEVEL_EXP = 100u;

	private const string IAP_PURCHASE_DUO_VERSION_BOOYAH_PASS_REASON = "PurchaseDuoVersionBooyahPass";

	private const string IAP_SUBSCRIBE_BOOYAH_PASS_REASON = "SubsribeBooyahPass";

	public static string BP_GRADE_KEY;

	public static string PP_EXPSHARE_GRADE_KEY;

	public static int CurGradeCdnType;

	public static int cycleRewardCdnType;

	public static ResourceID booyahPassLobbyIconResId;

	public static string BooyahPassLobbyIcon;

	public static ResourceID booyahPassLobbyVFXResId;

	private const string BP_SHOW_REWARD_TIPS_WND = "{0}_ShowBPRewardTipsWnd";

	private const string BP_ROYAL_BUBBLE_UNLCOK_TIPS = "{0}_ShowBpRoyalBubble";

	private const string BP_ROYAL_BUBBLE_EXIPRED_TIPS = "{0}_BpRoyalExipred";

	private const uint BP_CHALLENGE_TYPE = 3u;

	private const string BP_ICON_BG_FP = "UI_BooyahPass_BG_01";

	private const string BP_ICON_BG_PP = "UI_BooyahPass_BG_02";

	private const uint BP_PREMIUM_PLUS_CARD = 801039054u;

	private const uint BP_PREMIUM_CARD = 803000000u;

	private bool m_IsExpUpdateTcpGet;

	private bool m_IsTaskExpUpdateTcpGet;

	private bool m_IsFriendInfoReady;

	private uint m_CurBPEventID;

	private uint m_CurCiccleItemGrade;

	private int m_LastIndexClicked;

	private uint m_CycleBasicNum;

	private bool m_NeedGetBPInfoFromBPChallenge;

	private bool m_NeedInitPremiumPlusArray;

	private bool m_NeedInitPremiumArray;

	private bool m_IsDuoShareNeededInMainNaviShowedProcedure;

	private bool m_IsUnlockShareNeededInMainFirstEnterProcedure;

	private bool m_ShowBpPrivilegeReward;

	private bool m_IsUnlockPremiumPlusInMainFirstEnterProcedure;

	private bool m_HasRequestInfo;

	private bool? m_IsCompatibleCheckFailed;

	private CSGetBPAllDescsRes m_BPAllDesc;

	private CSGetEPInfoRes m_BPMainInfo;

	private CSGetEPSubscriptionBonusStatusRes m_SubscriptionBonusStatusRes;

	private BPReceivePremiumPassNtf m_ReceivePremiumPassInfo;

	private BooyahPassRewardItemData m_CycleRewardItemData;

	private EPProcess_Status m_DailyProcessStatus;

	private List<BaseItemInfo> m_SpecifiedPremiumBigRewardList;

	private BaseItemInfo[] m_SpecifiedPremiumPlusBigRewardArray;

	private List<BooyahPassRewardItemData> m_BooyahPassRewardItemList;

	private List<BooyahPassBaseItemData> m_BooyahPassBigRewardPreviewBpItemList;

	private List<BooyahPassBaseItemData> m_BooyahPassPurchaseTipsRewardItemList;

	private string[] m_FPPopoverLevel;

	private string[] m_FPPopoverDay;

	private List<EPWeeklyQuestInfo> m_BPWeeklyPoolList;

	private List<bool> m_BooyahPassMainItemCdnList;

	private readonly string[] m_NetworkTextureUrls;

	private readonly uint[] m_NetworkTextureEndTimes;

	private readonly Dictionary<ulong, BooyahPassShareExpData> m_BooyahPassShareExpDataDic;

	private readonly List<EPDailyProcessRewardDesc> m_BPDailyProcessDescList;

	private readonly Dictionary<uint, uint> m_BPDailyProcessInfoDict;

	private readonly Dictionary<uint, List<EPChallengeInfo>> m_ChallengeInfoDic;

	private List<ulong> m_TodayShareAccountList;

	private Dictionary<uint, ChallengeStatus> m_ChallengeStatus;

	public List<MatchResultTaskInfo> m_CurFinishChallengeInfoList;

	public List<MatchResultTaskInfo> m_CurGoingChallengeInfoList;

	private uint m_CachedClanActivenessDelta;

	private EPClaimBadgeFrom m_ClaimBPTaskAwardFrom;

	public string BPEmoteUnlockPlayerPrefs;

	public uint DailyProcessInvalidStatus;

	private bool m_NeedRefreshWeekTaskLock;

	private bool m_CanShowPurchaseTipsWnd;

	private uint m_CurBPEventBadgeItemID;

	private string m_LastSeasonBpThemeCdn;

	public uint DailyProcessNodeId => 0u;

	public bool IsTaskExpUpdateTcpGet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedRefreshWeekTaskLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanShowPurchaseTipsWnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowBpPrivilegeReward => false;

	public uint CurBPEventBadgeItemID => 0u;

	public bool IsDuoShareNeededInMainNaviShowed => false;

	public bool IsUnlockShareNeededInMainFirstEnter => false;

	public bool IsUnlockPremiumPlusInMainFirstEnter => false;

	public int lastIndexClickedInMain
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private uint playerCurGradeInternal => 0u;

	public uint playerCurGrade => 0u;

	public uint ExpValue => 0u;

	public string GetBpEventName => null;

	public uint GetPPInterval => 0u;

	public uint CurBPEventID => 0u;

	public Dictionary<uint, uint> BPDailyProcessInfoDict => null;

	public List<BooyahPassRewardItemData> MainRewardItemList => null;

	public List<EPDailyProcessRewardDesc> BPDailyProcessDescList => null;

	public List<BooyahPassBaseItemData> PreviewRewardItemList => null;

	public uint BPDailyProcessNumFininshed
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint BPGainedShareExp => 0u;

	public uint BPExpSendCnt => 0u;

	public uint BPExpClaimCnt => 0u;

	public long BPStartTime => 0L;

	public Dictionary<uint, List<EPChallengeInfo>> ChallengeInfoDic => null;

	public ulong EndTime => 0uL;

	public ulong BPDailyResetTime => 0uL;

	public EPProcess_Status DailyProcessStatus
	{
		get
		{
			return EPProcess_Status.PS_ONGOING;
		}
		set
		{
		}
	}

	public bool NeedGetBpInfoFromBpChallenge
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<MatchResultTaskInfo> CurFinishChallengeInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<MatchResultTaskInfo> CurGoingChallengeInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<uint, ChallengeStatus> ChallengeStatus => null;

	public string BpIconSpriteName => null;

	public uint InteractExp => 0u;

	public bool IsCompatibleCheckFailed => false;

	public uint CachedClanActivenessDelta
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string LastSeasonBpThemeCdn => null;

	public EPClaimBadgeFrom ClaimBPTaskAwardFrom
	{
		get
		{
			return EPClaimBadgeFrom.None;
		}
		set
		{
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

	public void InitAfterLogin()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestGetBPAllDesc(bool force = false, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void RequesetGetBPMainInfo(bool force = false, uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void RequestSubscriptionBonusStatus(bool sendImmediately = false)
	{
	}

	public void RequestPurchaseBP(bool isPremiumPlus)
	{
	}

	public void RequestSubscribeBP(bool isPremiumPlus)
	{
	}

	public uint GetItemListBpExp(List<BaseItemInfo> itemInfoList)
	{
		return 0u;
	}

	public bool CheckIsDoubleExpDay()
	{
		return false;
	}

	public bool CheckItemIsBpExp(uint itemId)
	{
		return false;
	}

	public List<BooyahPassBaseItemData> DeepCopy(List<BooyahPassBaseItemData> itemList)
	{
		return null;
	}

	public void OnPaymentDelegateProductPurchased(bool isDuoVersion, bool isSubscription, string productIdentifier, PayUtility.PaymentDelegate.ProductPurchasedResult result)
	{
	}

	public void OnPaymentDelegateProductsUpdated(string reason, bool result, string[] productIdentifiers)
	{
	}

	public void OnSubscriptionConfirmed(string subscriptionProductIdentifier)
	{
	}

	public void RequestGetInfoByAccountIDs()
	{
	}

	public void RequestGetBPExpShareList()
	{
	}

	public void RequestPurchaseLevelExp(uint levelCount)
	{
	}

	private void OnRequestPurchaseExpFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestClaimDailyProcessRewardByNodeID(uint nodeID, uint http_option, bool claimChallengeReward = false, ChallengeRewardParam challengeRewardParam = null)
	{
	}

	public void RequestRefreshWeeklyChallenge(uint week, uint challengeID, int curChallengeIDIndex)
	{
	}

	public void RequestClaimBigRewardInChallenge(uint grade, BooyahPassBaseItemType type, bool isCircleReward)
	{
	}

	public void RequestClaimReward(List<unlock> claimList, bool isCircleReward = false)
	{
	}

	public void RequestClaimShareExp(ulong[] ids, bool isclaimAll = false)
	{
	}

	public void RequestClaimChallengeReward(List<uint> challengeIDs, ChallengeType challengeType, uint challengeGroup, AutoOpenIntegrationData nodeIntegrationData = null)
	{
	}

	public void RequestSendShareExp(ulong[] idList, out bool sendSuccess, bool isAutoSend = false, bool isAllClaim = false, bool isAllSend = false)
	{
		sendSuccess = default(bool);
	}

	public uint GetDailyProcessDescStatusByNodeID(uint nodeID)
	{
		return 0u;
	}

	public void RequestClaimChallengeRewardInMatchResult(List<uint> challengeIDs)
	{
	}

	public void GetBpMatchItemByItemList(List<BooyahPassBaseItemData> baseItemList, out BooyahPassBaseItemData fpBaseItem, out BooyahPassBaseItemData PPBaseItem)
	{
		fpBaseItem = null;
		PPBaseItem = null;
	}

	public void UpdateExpInfo(BPAccountExpChangeNtf info)
	{
	}

	public void OnReceivePremiumPassNtf(BPReceivePremiumPassNtf info)
	{
	}

	public void OnReceiveUnlockSuccessNtf(BPUnlockSuccessNtf info)
	{
	}

	public void OnReceiveDailyChallengeNtf(EPDailyChallengeNtf infos)
	{
	}

	private static BooyahPassStatusType ConvertUnlockStatusToCurrentStatus(BooyahPass.BPUnlockStatus unlockStatus)
	{
		return BooyahPassStatusType.FreePass;
	}

	private bool IsPriceConfigReady()
	{
		return false;
	}

	private bool IsSubscribeConfigReady()
	{
		return false;
	}

	private bool IsSubscribeStatusReady()
	{
		return false;
	}

	private bool IsFreePassInternal()
	{
		return false;
	}

	private bool IsSubscriptionAvailableInternal()
	{
		return false;
	}

	private bool IsFirstSubscribeBonusAvailableInternal()
	{
		return false;
	}

	private BooyahPassStatusType GetCurrentPassStatusInternal()
	{
		return BooyahPassStatusType.FreePass;
	}

	private BooyahPass.BPUnlockStatus GetUnlockStatusInternal()
	{
		return BooyahPass.BPUnlockStatus.Status_FREE;
	}

	public uint GetCycleRewardStartGrade()
	{
		return 0u;
	}

	private uint GetCycleRewardIntervalGrade()
	{
		return 0u;
	}

	private List<BooyahPassRewardItemData> GetRewardItemListWithGradeRangeInternal(uint fromGrade, uint toGrade)
	{
		return null;
	}

	private List<BooyahPassBaseItemData> GetAllBaseItemListWithGradeRangeInternal(uint fromGrade, uint toGrade, List<BooyahPassBaseItemData> result = null)
	{
		return null;
	}

	private List<BooyahPassBaseItemData> GetBigRewardListSortByStatusGradeInternal(bool isSortByGrade)
	{
		return null;
	}

	private uint GetSubscribeBonusGemsCountInternal()
	{
		return 0u;
	}

	private PayItemData GetPremiumSubscriptionProductFromSDKInternal()
	{
		return null;
	}

	private PayItemData GetPremiumPlusSubscriptionProductFromSDKInternal()
	{
		return null;
	}

	private void RefreshRewardItemStatus(List<unlock> unlockDataList, bool hasCyleGood, ExchangeChangeData exchangeChangeData)
	{
	}

	private void ShowPurchasePPTipsWnd()
	{
	}

	private void ProcessBpDailyProcess()
	{
	}

	private void ProcessBpChallengeStatus()
	{
	}

	private List<EPDailyChallengeData> GetDailyChallengeDataByDateOfWeek(uint date)
	{
		return null;
	}

	private void ProcessDailyChallengeInfoDic()
	{
	}

	private void ProcessWeeklyChallengeIndoDic()
	{
	}

	private void InitFPLevelAndDay()
	{
	}

	private void InitRewardItemList()
	{
	}

	private void UpdateCycleRewardData()
	{
	}

	private void UpdateDuoVersionSendStatus(bool send)
	{
	}

	private void UpdatePlayerPurchasedPassCount()
	{
	}

	private void UpdatePlayerUnlockStatus(BooyahPass.BPUnlockStatus unlockStatus)
	{
	}

	private void UpdatePlayerCurrentPassStatus(BooyahPassStatusType currentStatus)
	{
	}

	public void SetRoyalTipsPrefs(bool isExipred)
	{
	}

	public void SetRewardTipsPlayerPrefsToday()
	{
	}

	public void SetBpMainGuideAllDone()
	{
	}

	public void SetBpPayGuideAllDone()
	{
	}

	public bool CheckHasDoneBpMainFirstGuide()
	{
		return false;
	}

	public bool CheckHasDoneBpPayFirstGuide()
	{
		return false;
	}

	public bool CheckIsInTaskGuide()
	{
		return false;
	}

	public bool CheckIsInBpGuide()
	{
		return false;
	}

	public bool CheckShowRewardTipsToday()
	{
		return false;
	}

	public bool CheckShowRoyalUnlockTips()
	{
		return false;
	}

	public bool CheckShowRoyalExipredTips()
	{
		return false;
	}

	public bool PrepareBigRewardListForPremium()
	{
		return false;
	}

	private void PreparePremiumListOldVersion(List<BooyahPassBaseItemData> itemDataList, uint[] levels)
	{
	}

	private void PreparePremiumListNewVersion(List<BooyahPassBaseItemData> itemDataList, uint[] levels)
	{
	}

	private void SetBPDailyProcessDescList()
	{
	}

	private void SetShowDuoShareInProcedureFlag(bool needeuid)
	{
	}

	private void SetShowUnlockPopupInProcedureFlag(bool show, bool isPremiumPlus)
	{
	}

	private void UpdatePaymentDelegateProductsInDemand()
	{
	}

	private void OnBooyahPassUnlockedByDuoVersion(BooyahPass.BPUnlockStatus unlockStatus)
	{
	}

	private void ShowFirstSubscriptionBonusRewardWnd()
	{
	}

	private void OnBooyahPassSubscriptionTransactionFinished()
	{
	}

	private void OnBooyahPassUnlockedByBpCard(BooyahPass.BPUnlockStatus unlockStatus)
	{
	}

	private void ClearNetworkTextureUrls()
	{
	}

	private bool IsGradeUpdateWithExpBeforeAndAfter(uint expBefore, uint expAfter)
	{
		return false;
	}

	private void LogBPMainInfoMessage()
	{
	}

	public uint GetNextMinDiscount()
	{
		return 0u;
	}

	public uint GetMinDiscount()
	{
		return 0u;
	}

	public float GetNextPremiumDiscount()
	{
		return 0f;
	}

	public float GetNextPremiumPlusDiscount()
	{
		return 0f;
	}

	public float GetPremiumDiscount()
	{
		return 0f;
	}

	public float GetPremiumPlusDiscount()
	{
		return 0f;
	}

	public bool CheckPrivilegeType(BooyahPassRewardType type)
	{
		return false;
	}

	public bool CheckPrivilegeType(ESpecialItemWithoutDataType type)
	{
		return false;
	}

	public bool CheckPrivilegeType(BooyahPassBaseItemType type)
	{
		return false;
	}

	public bool CheckHasRePurchasePrivilege()
	{
		return false;
	}

	public uint GetDiscountLevel()
	{
		return 0u;
	}

	public bool CheckHasDiscountLevel()
	{
		return false;
	}

	public bool CheckPrivilegeCanInit(EPrivilegeIndex index)
	{
		return false;
	}

	public bool CheckHasNextRepuchseValue()
	{
		return false;
	}

	public bool CheckHasNextBundleRepurchaseValue()
	{
		return false;
	}

	public bool CheckHasRepuchseValue()
	{
		return false;
	}

	public bool CheckHasBundleRepurchaseValue()
	{
		return false;
	}

	public bool CheckCanRefreshChallenge()
	{
		return false;
	}

	public uint GetTaskExtraExp()
	{
		return 0u;
	}

	public uint GetPurchaseExtraExp()
	{
		return 0u;
	}

	public uint GetTotalRefreshChallengeCnt()
	{
		return 0u;
	}

	public uint GetOwnRefreshChallengeCnt()
	{
		return 0u;
	}

	public EPChallengeInfo GetChallengeInfoByWeekQuest(EPWeeklyQuestInfo weekInfo)
	{
		return null;
	}

	public bool ShowBpBackFlowPrivilege()
	{
		return false;
	}

	public bool CheckPurchaseHasExtraExp()
	{
		return false;
	}

	public bool CheckTaskHasExtraExp()
	{
		return false;
	}

	public bool CheckShowPurchasePPTipsWnd()
	{
		return false;
	}

	public void GetUnlockPPCanGetItemList(uint unlockGrade, List<BooyahPassBaseItemData> unlcokCanGetItemInfoList)
	{
	}

	public void GetNowAndFutureRewardList(ref List<BaseItemInfo> imediateBaseItemInfoList, ref List<BaseItemInfo> futureBaseItemInfoList, uint grade)
	{
	}

	private int CompareBaseItemData(BooyahPassBaseItemData x, BooyahPassBaseItemData y)
	{
		return 0;
	}

	public void GetPurchaseTIPSPPRewardList(List<BaseItemInfo> imediateBaseItemInfoList, List<BaseItemInfo> futureBaseItemInfoList, uint itemCount, uint grade)
	{
	}

	public EEPTaskTab GetEPChallengeDefaultTab(ref bool needShowGuide)
	{
		return EEPTaskTab.Daily;
	}

	public void RefreshFriendListInfo()
	{
	}

	private bool NeedGetNewDesc()
	{
		return false;
	}

	public bool SetBpInfoFromBpChallenge()
	{
		return false;
	}

	public bool IsBPInfoReady()
	{
		return false;
	}

	public BooyahPassRewardItemData GetCycleRewardItemData()
	{
		return null;
	}

	public bool IsFreePass()
	{
		return false;
	}

	public bool IsPremiumPassReceived()
	{
		return false;
	}

	public BPEventExpression GetGoposInfo()
	{
		return null;
	}

	public string GetArticleExperience()
	{
		return null;
	}

	public float GetExperiencePercentByValue(uint value)
	{
		return 0f;
	}

	public void InitBpLobbyIcon()
	{
	}

	public void SetCdnDownload(int type)
	{
	}

	public bool GetCdnHasDownloadByType(int type)
	{
		return false;
	}

	public bool CheckDescIsInit()
	{
		return false;
	}

	public bool CanRefreshView()
	{
		return false;
	}

	public bool CanShowLobbyRedPoint()
	{
		return false;
	}

	public bool CanShowLobbyV2GiftIcon()
	{
		return false;
	}

	public bool CheckNeedShowV2BooyahPassBubble()
	{
		return false;
	}

	public bool CanShowLobbyGiftBubble()
	{
		return false;
	}

	public bool CanShowLoobyThemeBubble()
	{
		return false;
	}

	public void SetLobbyIconState()
	{
	}

	public bool IsBpOpen()
	{
		return false;
	}

	public bool CanShowSendPPBtn()
	{
		return false;
	}

	public uint GetCycleRewardGrade()
	{
		return 0u;
	}

	public bool IsSubscriptionEntranceShown()
	{
		return false;
	}

	public bool IsFirstSubscribeBonusAvailable()
	{
		return false;
	}

	public bool IsPremiumSubscribed()
	{
		return false;
	}

	public bool IsPremiumPlusSubscribed()
	{
		return false;
	}

	public bool IsNextPassPreorder()
	{
		return false;
	}

	public bool IsAnyPassSubscribedOrPreorder()
	{
		return false;
	}

	public void RefreshShareExpDataListAfterClaimExp(ulong accountID)
	{
	}

	public void RefreshShareExpDataListAfterSendExp(ulong accountID)
	{
	}

	public void RefreshAllShareDataStatus()
	{
	}

	public BooyahPass.BPUnlockStatus GetUnlockStatus()
	{
		return BooyahPass.BPUnlockStatus.Status_FREE;
	}

	public BooyahPassStatusType GetCurrentPassStatus()
	{
		return BooyahPassStatusType.FreePass;
	}

	public uint GetBooyahPassGradeByExp(uint exp)
	{
		return 0u;
	}

	public bool IsGradeUpdateWithExpIncre(uint expIncre)
	{
		return false;
	}

	public void ResetExpTcpFlag()
	{
	}

	public int GetNextBigRewardItemIndexByIndex(int curIndex)
	{
		return 0;
	}

	public int GetScrollToBigReewardIndex()
	{
		return 0;
	}

	public bool GetScrollToIndexByItemID(uint itemID, out int scrolltoIndex, out uint baseItemIndex, out BooyahPassBaseItemData booyahPassBaseItemData)
	{
		scrolltoIndex = default(int);
		baseItemIndex = default(uint);
		booyahPassBaseItemData = null;
		return false;
	}

	public bool GetScrollToIndexByLevelandID(uint level, uint itemID, out int scrolltoIndex, out uint baseItemIndex)
	{
		scrolltoIndex = default(int);
		baseItemIndex = default(uint);
		return false;
	}

	public int GetScrollToItemIndex()
	{
		return 0;
	}

	public uint GetPurchasedPassCount()
	{
		return 0u;
	}

	public uint GetPremiumRepuchasePrice()
	{
		return 0u;
	}

	public uint GetPremiumOriginalPrice()
	{
		return 0u;
	}

	public uint GetPremiumDiscountPrice()
	{
		return 0u;
	}

	public uint GetPremiumPlusRepurchasePrice()
	{
		return 0u;
	}

	public uint GetPremiumPlusOriginalPrice()
	{
		return 0u;
	}

	public GoPos GetRoyalGoPosData()
	{
		return null;
	}

	public uint GetMaxDiscountValue()
	{
		return 0u;
	}

	public uint GetPremiumPlusDiscountPrice()
	{
		return 0u;
	}

	public uint GetPremiumPlusBonusLevel()
	{
		return 0u;
	}

	public uint GetLevelPackageStoreID()
	{
		return 0u;
	}

	public uint GetLevelExpOriginalPrice()
	{
		return 0u;
	}

	public uint GetLevelExpDiscountPrice()
	{
		return 0u;
	}

	public List<ChallengeDesc> GetWeeklyDatas()
	{
		return null;
	}

	public List<ChallengeDesc> GetBpWeeklyTaskPool()
	{
		return null;
	}

	public bool HasDescReady()
	{
		return false;
	}

	public uint GetSubscribeBonusGemsCount()
	{
		return 0u;
	}

	public uint GetPremiumSubscriptionRewardLevel()
	{
		return 0u;
	}

	public int GetPremiumSubscriptionProductID()
	{
		return 0;
	}

	public int GetPremiumSubscriptionDiscountProductID()
	{
		return 0;
	}

	public string GetPremiumSubscriptionFakePrice()
	{
		return null;
	}

	public string GetPremiumSubscriptionFakeDiscountPrice()
	{
		return null;
	}

	public uint GetPremiumSubscriptionDiscountPercentage()
	{
		return 0u;
	}

	public PayItemData GetPremiumSubscriptionProductFromSDK()
	{
		return null;
	}

	public PayItemData GetPremiumSubscriptionProductFromCSV()
	{
		return null;
	}

	public uint GetPremiumPlusSubscriptionRewardLevel()
	{
		return 0u;
	}

	public int GetPremiumPlusSubscriptionProductID()
	{
		return 0;
	}

	public int GetPremiumPlusSubscriptionDiscountProductID()
	{
		return 0;
	}

	public string GetPremiumPlusSubscriptionFakePrice()
	{
		return null;
	}

	public string GetPremiumPlusSubscriptionFakeDiscountPrice()
	{
		return null;
	}

	public uint GetPremiumPlusSubscriptionDiscountPercentage()
	{
		return 0u;
	}

	public PayItemData GetPremiumPlusSubscriptionProductFromSDK()
	{
		return null;
	}

	public PayItemData GetPremiumPlusSubscriptionProductFromCSV()
	{
		return null;
	}

	public BooyahPassRewardItemData GetRewardItemByGrade(uint grade)
	{
		return null;
	}

	public BooyahPassBaseItemData GetBaseItemByIndex(uint baseItemIndex)
	{
		return null;
	}

	public uint GetAllBaseItemCountByCurGrade(uint curGrade)
	{
		return 0u;
	}

	public List<BooyahPassBaseItemData> GetAllBaseItemListWithGradeRangeOpt(uint fromGrade, uint toGrade, List<BooyahPassBaseItemData> result)
	{
		return null;
	}

	public List<BaseItemInfo> GetBigRewardListForPremium()
	{
		return null;
	}

	public long GetBooyahPassEndTime()
	{
		return 0L;
	}

	public List<BooyahPassShareExpData> GetShareExpOrderedList()
	{
		return null;
	}

	public uint GetShareExpMaxNumByType(BooyahPassShareExpMaxNumType type)
	{
		return 0u;
	}

	public bool CanCliamReward(BooyahPassBaseItemData itemData)
	{
		return false;
	}

	public bool CanShowClaimAllBtn()
	{
		return false;
	}

	public uint GetCycleRewardNum(int grade)
	{
		return 0u;
	}

	public void ReadyClaimAllReward()
	{
	}

	public BooyahPassBaseItemData GetBpPreviewBigRewardInfo()
	{
		return null;
	}

	public string GetBPIconCDNUrlAndEndTime(BooyahPassIconCDNType type, out uint urlEndTime)
	{
		urlEndTime = default(uint);
		return null;
	}

	public string GetNetworkTextureUrlWithSubType(BooyahPassAdSubType adSubType)
	{
		return null;
	}

	public uint GetNetworkTextureEndTimeWithSubType(BooyahPassAdSubType adSubType)
	{
		return 0u;
	}

	public List<ulong> GetCanSendExpFriendList()
	{
		return null;
	}

	public List<ulong> GetCanClaimFriendsList()
	{
		return null;
	}

	public bool BaseItemIsCircle(uint grade)
	{
		return false;
	}

	public void ClaimReward(List<unlock> unlcokList, bool circle)
	{
	}

	public bool HasExpCanClaimAndSend()
	{
		return false;
	}

	public bool HasExpCanClaim()
	{
		return false;
	}

	public bool HasExpCanSend()
	{
		return false;
	}

	public BooyahPassShareExpData GetExpShareById(ulong id)
	{
		return null;
	}

	public int GetFirstCanExpGuideIndex(BooyahPassShareExpStatus type, List<BooyahPassShareExpData> sortedPlayerList)
	{
		return 0;
	}

	public string BpIconBGSpriteName(uint BpGrade, bool isFP)
	{
		return null;
	}

	public bool IsBPIconShowMaxLevelVFX(uint bpGrade, uint maxlevel)
	{
		return false;
	}

	public void SetDuoShareInMainNaviShowedFinished()
	{
	}

	public void SetUnlockShareInMainFirstEnterFinished()
	{
	}

	public void GetExpChangeProgressValue(uint expIncre, out int levelUpdateNum, out uint newExpValue, out uint oldExpValue)
	{
		levelUpdateNum = default(int);
		newExpValue = default(uint);
		oldExpValue = default(uint);
	}

	public void ProcessNetworkTextureUrls(uint curBpId)
	{
	}

	private bool CdnSortIdInvariant(uint subtype)
	{
		return false;
	}

	public bool CheckRepurchaseCost()
	{
		return false;
	}

	public bool NeedShowBPEmoteUnlcokVFX()
	{
		return false;
	}

	public bool HasRepurchaseDiscount()
	{
		return false;
	}

	public void CheckAndShowClanActivenessTips()
	{
	}

	public static int BooyahPassRewardevelAndTypeAscend(BooyahPassRewardItemData itemA, BooyahPassRewardItemData itemB)
	{
		return 0;
	}

	public int BooyahPassItemStatusLevelAscend(BooyahPassBaseItemData itemA, BooyahPassBaseItemData itemB)
	{
		return 0;
	}

	public static int BooyahPassItemLevelDescend(BooyahPassBaseItemData itemA, BooyahPassBaseItemData itemB)
	{
		return 0;
	}

	public static int BooyahPassItemSpecialTypeLevelDescend(BooyahPassBaseItemData itemA, BooyahPassBaseItemData itemB)
	{
		return 0;
	}

	public static int BooyahPassItemLevelAndTypeAscend(BooyahPassBaseItemData itemA, BooyahPassBaseItemData itemB)
	{
		return 0;
	}

	public void SortMainRewardItemList()
	{
	}

	public void SortPurchaseTipsRewardItemList()
	{
	}

	public void SortPreviewRewardItemList()
	{
	}

	public void DebugLogError(string errorMsg)
	{
	}

	public void ClickLog(EventLogger.ClickType clickType, string logMsg)
	{
	}

	private bool CompatibleCheckBPDesc(CSGetBPAllDescsRes res)
	{
		return false;
	}

	private bool CompatibleCheckGoods(BPGoods goods)
	{
		return false;
	}

	private bool CompatibleCheckCycleGoods(BPCycleGoods cycleGoods)
	{
		return false;
	}

	public void DebugLogError(string errorMsg, bool isShowInFireBase = false)
	{
	}

	public void DebugLog(string msg)
	{
	}

	private void _003CRequestGetBPAllDesc_003Eb__187_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequesetGetBPMainInfo_003Eb__188_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSubscriptionBonusStatus_003Eb__189_0(HttpErrorCode errorCode, object result)
	{
	}

	private void _003CRequestGetInfoByAccountIDs_003Eb__199_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetBPExpShareList_003Eb__200_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
