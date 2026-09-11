using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using proto;

namespace COW;

public class UIModelPayment : UIBaseModel
{
	public enum PaymentBundleState
	{
		NotLoaded,
		Loading,
		Loaded,
		Paying,
		Exchanging
	}

	public enum TopupEventType
	{
		DiamondEvent
	}

	public enum BundlePurchaseError
	{
		None,
		NotLoaded,
		Missing,
		SoldOut,
		Pending
	}

	private class PaymentBundlesDelegate : PayUtility.PaymentDelegate
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<PayBundleWindowDesc, string> _003C_003E9__10_0;

			internal string _003COnProductsUpdated_003Eb__10_0(PayBundleWindowDesc desc)
			{
				return null;
			}
		}

		private static PaymentBundlesDelegate _I;

		private bool growthFundFetched;

		private bool m_GrowthFundV2Fetched;

		public static PaymentBundlesDelegate I => null;

		public override string Name => null;

		public override bool NeedPendingPurchasesScanned => false;

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		public override void OnScannedAndCleared(ScanAndClearResult[] results)
		{
		}

		public override bool OnPendingPurchasesScanned(PendingPurchaseResult[] results)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_get_NeedPendingPurchasesScanned()
		{
			return false;
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public void _003C_003EiFixBaseProxy_OnScannedAndCleared(ScanAndClearResult[] P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_OnPendingPurchasesScanned(PendingPurchaseResult[] P0)
		{
			return false;
		}
	}

	public enum VersionType
	{
		IAPProducts,
		PaymentBundles,
		RebateCard
	}

	private class VersionInfo
	{
		public string PlayerPrefsKey;

		public Func<string> LocalOverride;

		public Func<string> Remote;
	}

	public enum PaymentButtonStyle
	{
		FirstTime = 1,
		SecondTime,
		LessIsMore,
		GrowthFundV2,
		Normal,
		SquadTreasure,
		Finished
	}

	public class PaymentButtonDisplayInfo
	{
		public string CdnUrl;

		public uint StartTime;

		public uint EndTime;

		public uint subtype;

		public uint gopos;

		public string subgopos;
	}

	private class DiamondProductsDelegate : PayUtility.PaymentDelegate
	{
		private static DiamondProductsDelegate _I;

		private string[] _003CProductsInDemand_003Ek__BackingField;

		public static DiamondProductsDelegate I => null;

		public override string Name => null;

		public override string[] ProductsInDemand
		{
			get
			{
				return _003CProductsInDemand_003Ek__BackingField;
			}
			set
			{
				_003CProductsInDemand_003Ek__BackingField = value;
			}
		}

		public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override string[] OnGetProductsInDemand(string reason, ProductPurchasedResult result)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public string[] _003C_003EiFixBaseProxy_OnGetProductsInDemand(string P0, ProductPurchasedResult P1)
		{
			return null;
		}
	}

	public class LessIsMoreEvent
	{
		public class Tier
		{
			public uint TierId;

			public uint MinDiamonds;

			public float Price;

			public long ItemId;

			public long RebateId;

			public uint GainDiamonds;
		}

		public Tier[] Tiers;

		public bool Eligible;

		public bool Pending;

		public ulong StartTime;

		public ulong EndTime;

		public long SDKEventId;
	}

	private class LessIsMoreDelegate : PayUtility.PaymentDelegate
	{
		[Serializable]
		public class LessIsMoreExtraInfo
		{
			public int price_tier;

			public int tier_diamond_min;

			public int diamond_num;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<DiamondSpendEventDesc> _003C_003E9__13_0;

			public static Comparison<LessIsMoreEvent.Tier> _003C_003E9__13_1;

			public static Comparison<LessIsMoreEvent.Tier> _003C_003E9__15_0;

			internal bool _003CSetEventFromGame_003Eb__13_0(DiamondSpendEventDesc desc)
			{
				return false;
			}

			internal int _003CSetEventFromGame_003Eb__13_1(LessIsMoreEvent.Tier a, LessIsMoreEvent.Tier b)
			{
				return 0;
			}

			internal int _003CSetEventFromSDK_003Eb__15_0(LessIsMoreEvent.Tier a, LessIsMoreEvent.Tier b)
			{
				return 0;
			}
		}

		private static LessIsMoreDelegate _I;

		private LessIsMoreEvent _003CEvent_003Ek__BackingField;

		private int _ReloadFailures;

		private ulong _LastLoadEventConfigsTimestamp;

		private bool _LastLoadEventConfigsResult;

		private ulong _LastLoadEventProductsTimestamp;

		private bool _LastLoadEventProductsResult;

		public static LessIsMoreDelegate I => null;

		public override string Name => null;

		public override string EventTypeInDemand => null;

		public LessIsMoreEvent Event
		{
			get
			{
				return _003CEvent_003Ek__BackingField;
			}
			private set
			{
				_003CEvent_003Ek__BackingField = value;
			}
		}

		private int MaxReloadFailures => 0;

		private ulong MinReloadInterval => 0uL;

		private ulong PendingReloadInterval => 0uL;

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public void ClearEvent()
		{
		}

		public void SetEventFromGame(DiamondSpendEventInfo info)
		{
		}

		private void SetEventFromSDK()
		{
		}

		private bool ShouldDisplayEvent(SDKIAP.Event e)
		{
			return false;
		}

		private bool ShouldDisplayEvent(SDKIAP.EventDatum d)
		{
			return false;
		}

		public void ReloadEvent()
		{
		}

		public override void OnEventConfigsUpdated(string reason, bool result)
		{
		}

		public override void OnEventProductsAndDataUpdate(string reason, bool result)
		{
		}

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override bool OnEventProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, int quantity)
		{
			return false;
		}

		public string _003C_003EiFixBaseProxy_get_EventTypeInDemand()
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public void _003C_003EiFixBaseProxy_OnEventConfigsUpdated(string P0, bool P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OnEventProductsAndDataUpdate(string P0, bool P1)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_OnEventProductPurchased(string P0, ProductPurchasedResult P1, string P2, int P3)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LevelUpPassDesc> _003C_003E9__108_0;

		public static Predicate<PayBundleWindowDesc> _003C_003E9__108_1;

		public static Converter<PayBundleWindowDesc, string> _003C_003E9__108_2;

		public static Predicate<PayBundleWindowDesc> _003C_003E9__108_3;

		public static Converter<PayBundleWindowDesc, string> _003C_003E9__108_4;

		public static Comparison<LevelUpPassDesc> _003C_003E9__109_0;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__123_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__123_1;

		public static Converter<PayItemData, string> _003C_003E9__145_0;

		public static Converter<PayItemData, string> _003C_003E9__145_1;

		public static Comparison<PayBundleWindowDesc> _003C_003E9__206_0;

		internal int _003COnUpdatedPaymentBundles_003Eb__108_0(LevelUpPassDesc a, LevelUpPassDesc b)
		{
			return 0;
		}

		internal bool _003COnUpdatedPaymentBundles_003Eb__108_1(PayBundleWindowDesc bundle)
		{
			return false;
		}

		internal string _003COnUpdatedPaymentBundles_003Eb__108_2(PayBundleWindowDesc bundle)
		{
			return null;
		}

		internal bool _003COnUpdatedPaymentBundles_003Eb__108_3(PayBundleWindowDesc bundle)
		{
			return false;
		}

		internal string _003COnUpdatedPaymentBundles_003Eb__108_4(PayBundleWindowDesc bundle)
		{
			return null;
		}

		internal int _003COnGetPaymentBundles_003Eb__109_0(LevelUpPassDesc a, LevelUpPassDesc b)
		{
			return 0;
		}

		internal BaseItemInfo _003COnPaymentBundleReceived_003Eb__123_0(AwardDesc reward)
		{
			return null;
		}

		internal CommonRewardItemInfo _003COnPaymentBundleReceived_003Eb__123_1(BaseItemInfo item)
		{
			return null;
		}

		internal string _003CLoadDiamondProductsInDemand_003Eb__145_0(PayItemData product)
		{
			return null;
		}

		internal string _003CLoadDiamondProductsInDemand_003Eb__145_1(PayItemData product)
		{
			return null;
		}

		internal int _003CGetGrowthFundV2PayBundleWindowDescList_003Eb__206_0(PayBundleWindowDesc a, PayBundleWindowDesc b)
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__220_0()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__220_1()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__220_2()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__220_3()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__220_4()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__220_5()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public CSTopupEventInfoReq req;

		public UIModelPayment _003C_003E4__this;

		public uint propID;

		internal void _003CRequestTopupEvent_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public UIModelPayment _003C_003E4__this;

		public uint id;

		public uint level;

		internal void _003CClaimPayLevelReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public PayLevelRewardDesc item;

		internal bool _003CExistUnawardedPayLevelReward_003Eb__0(PlayLevelInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public string param;

		internal void _003COnReceivedGrowthFundBundle_003Eb__0()
		{
		}
	}

	private WaitingResponseHandler m_WaitingHandler;

	private PaymentBundleState _003CBundleState_003Ek__BackingField;

	private List<PlayLevelInfo> m_PayLevelInfos;

	private List<PayLevelRewardDesc> m_PayLevelRewardDescs;

	private PayLevelPoolDesc _003CPayLevelPoolDesc_003Ek__BackingField;

	private PayBundleWindowDesc m_GrowthFundBundleDesc;

	public List<PlatformPromotionProductsData> PlatformPromotionProductDatas;

	public ulong LastScanIAPInventoryTimeOnApplicationPause;

	private Dictionary<uint, ResourceID> m_GrowthFundPics;

	private CSGetPayBundleWindowDescRes m_CSGetPayBundleWindowDescResInLogin;

	public const uint PropID_PaymentBundlesUpdated = 2u;

	public const uint PropID_DiamondProductPurchased = 4u;

	public const uint PropID_PaymentBundleExchanged = 8u;

	public const uint PropID_DiamondEvent = 64u;

	public const uint PropID_SubscriptionBundlesUpdated = 128u;

	public const uint PropID_SubscriptionBundleStatusUpdated = 256u;

	public const uint PropID_SubscriptionBundleClaimed = 512u;

	public const uint PropID_Subscribed = 1024u;

	public const uint PropID_DiamondProductsUpdated = 2048u;

	public const uint PropID_SubscriptionProductsUpdated = 4096u;

	public const uint PropID_DiamondEventProductsUpdated = 8192u;

	public const uint PropID_DiamondEventProductPurchased = 16384u;

	public const uint PropID_GetGrowthFundDescs = 32768u;

	public const uint PropID_PaymentBundlePurchased = 65536u;

	public const uint PropID_GetPayLevelInfo = 131072u;

	public const uint PropID_ClaimPayLevelReward = 262144u;

	public const uint PropID_GrowthFundBundlesUpdated = 1048576u;

	public const uint PropID_PaymentBundlesGOPUpdated = 2097152u;

	public const string PAYMENTBUNDLENEWBIE = "PaymentBundleNewbie_";

	public const string PAYMENTBUNDLEDISCOUNT = "PaymentBundleDiscount_";

	public const string GROWTHFUND_V2_WEEKLY_REMAIN = "GROWTHFUND_V2_WEEKLY_REMAIN_{0}";

	private bool _003CHasOpenedLessIsMore_003Ek__BackingField;

	private bool _003CHasClosedUI_003Ek__BackingField;

	public const uint MaxGrowthFundItemLv = uint.MaxValue;

	private static readonly char[] SWITCH_CONTENT_SEPARATOR;

	private const uint RELOAD_BUNDLES_INTERVAL_S = 1800u;

	private ulong m_LastReloadBundles;

	private Dictionary<uint, PayBundleWindowDesc> m_PaymentBundles;

	private List<PayBundleWindowDesc> m_PaymentBundleList;

	private HashSet<string> m_CachedPendingProductIds;

	private bool m_HasCachedPendingResults;

	private Dictionary<uint, List<PayBundleWindowDesc>> m_DictActivityTypeToPayBundleWindowDescList;

	private Dictionary<uint, LevelUpPassDesc> m_DictUniqueIDToLevelUpPassDesc;

	private List<LevelUpPassDesc> m_LevelUpPassDescList;

	private ulong m_BundlesNextResetTime;

	private uint m_PaymentBundleId_Paying;

	private uint m_currentBuyingBundleID;

	private static readonly Dictionary<int, VersionInfo> _Versions;

	private List<PayItemData> _DiamondProducts;

	private List<PayItemData> _FirstPayBonusDiamondProducts;

	public MysteryBonusInfo m_MysteryBonusData;

	private const string HAS_SEEN_GROWTH_FUND = "HasSeenPaymentGrowthFund";

	private const string HAS_SEEN_GROWTH_FUND_V2 = "HasSeenPaymentGrowthFundV2";

	public PaymentBundleState BundleState
	{
		get
		{
			return _003CBundleState_003Ek__BackingField;
		}
		private set
		{
			_003CBundleState_003Ek__BackingField = value;
		}
	}

	public List<PlayLevelInfo> PayLevelInfos => null;

	public List<PayLevelRewardDesc> PayLevelRewardDescs => null;

	public PayLevelPoolDesc PayLevelPoolDesc
	{
		get
		{
			return _003CPayLevelPoolDesc_003Ek__BackingField;
		}
		private set
		{
			_003CPayLevelPoolDesc_003Ek__BackingField = value;
		}
	}

	public PayBundleWindowDesc GrowthFundBundleDesc => null;

	public bool HasOpenedLessIsMore
	{
		private get
		{
			return _003CHasOpenedLessIsMore_003Ek__BackingField;
		}
		set
		{
			_003CHasOpenedLessIsMore_003Ek__BackingField = value;
		}
	}

	public bool HasClosedUI
	{
		private get
		{
			return _003CHasClosedUI_003Ek__BackingField;
		}
		set
		{
			_003CHasClosedUI_003Ek__BackingField = value;
		}
	}

	public static bool LessIsMoreUseGMSDK => false;

	public static bool LessIsMoreGMSDKTest => false;

	public bool PaymentEnabled => false;

	public string PaymentDisabledMessage => null;

	public bool PaymentIAPEnabled => false;

	public bool GrowthFundEnabled => false;

	public bool PaymentBundlesEnabled => false;

	public bool DiamondEventEnabled => false;

	public bool ShopEnabled => false;

	public bool ShopFirst => false;

	public bool IsEmbeddedMshop => false;

	public List<LevelUpPassDesc> LevelUpPassDescList => null;

	public ulong PaymentBundlesNextResetTime
	{
		get
		{
			return 0uL;
		}
		private set
		{
		}
	}

	public List<PayItemData> DiamondProducts => null;

	public List<PayItemData> FirstPayBonusDiamondProducts => null;

	public bool IsPaymentBonusOpen => false;

	public bool IsFirstPaymentBonusOpen => false;

	public bool HasSeenGrowthFund => false;

	public bool HasSeenGrowthFundV2 => false;

	private static bool LessIsMoreRightOnTime(ulong start, ulong end)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public void InitAfterLogin()
	{
	}

	public void InitDiamondProducts()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void GotoState(PaymentBundleState next)
	{
	}

	private bool IsSwitchOpen(ESwitch.SwitchFunc switchType)
	{
		return false;
	}

	public void UpdatePaymentBundles(bool force = false, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void GetPaymentBundles(bool force = false, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void CachePendingPurchaseResults(HashSet<string> pendingProductIds)
	{
	}

	public HashSet<string> GetCachedPendingProductIds()
	{
		return null;
	}

	public bool HasCachedPendingResults()
	{
		return false;
	}

	public void ClearCachedPendingResults()
	{
	}

	public bool ProcessCachedPendingPurchaseResults()
	{
		return false;
	}

	private void OnUpdatedPaymentBundles(HttpErrorCode error, object resObj)
	{
	}

	private void OnGetPaymentBundles(HttpErrorCode error, object resObj)
	{
	}

	public void OnDisplayPaymentBundles()
	{
	}

	public void PurchasePaymentBundle(uint id)
	{
	}

	public BundlePurchaseError CheckPaymentBundlePurchasable(uint id)
	{
		return BundlePurchaseError.None;
	}

	private void PayForPendingPaymentBundle()
	{
	}

	public void OnPaymentBundlePaid(bool success, string productIdentifier, long rebateId)
	{
	}

	private void ExchangePendingPaymentBundle(long rebateId)
	{
	}

	public bool BuyPaymentBundle(uint bundleID, EStore.PbwConsumeType type)
	{
		return false;
	}

	private void OnPaymentBundlePaid(HttpErrorCode error, object resObj)
	{
	}

	private void OnPaymentBundleExchanged(HttpErrorCode error, object resObj)
	{
	}

	public void OnPaymentBundleReceived(CSPayBundleWindowPurchaseRes resObj)
	{
	}

	public void CacheVersion(VersionType versionType)
	{
	}

	public bool SameVersion(VersionType versionType)
	{
		return false;
	}

	private string GetLocalVersion(VersionType versionType)
	{
		return null;
	}

	public Dictionary<uint, PaymentButtonDisplayInfo> GetPaymentButton()
	{
		return null;
	}

	private void LoadDiamondProductsFromCSV()
	{
	}

	public void LoadFirstPayBonusDiamondProductsFromCSV()
	{
	}

	public void LoadDiamondProductsInDemand()
	{
	}

	private void LoadLSMProductFromCsv()
	{
	}

	public List<uint> GetFirstPayedProductIds()
	{
		return null;
	}

	public bool CheckCanFirstPayBonusOpen()
	{
		return false;
	}

	public void ReloadDiamondProducts()
	{
	}

	public void PurchaseDiamondProduct(string productIdentifier)
	{
	}

	private void OnDiamondProductPurchased(string productIdentifier, int quantity)
	{
	}

	public LessIsMoreEvent GetLessIsMoreEvent()
	{
		return null;
	}

	public int GetLessIsMoreTier()
	{
		return 0;
	}

	public void RequestTopupEvent(uint eventType, bool force = false, uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateEventData()
	{
	}

	public void ReloadDiamondEventProducts()
	{
	}

	public uint GetBonusPercent()
	{
		return 0u;
	}

	public void BonusTopupTimesAdd(uint time)
	{
	}

	public bool IsValidMysteryBonusData()
	{
		return false;
	}

	public bool IsValidDiamondEvent()
	{
		return false;
	}

	public bool IsDiamondEventVisible()
	{
		return false;
	}

	public void SetDiamondEventTipsNum()
	{
	}

	public void PurchaseDiamondEventProduct(string productIdentifier)
	{
	}

	public void SeenGrowthFund()
	{
	}

	private void UpdateGrowthFundTips()
	{
	}

	public bool Subscribing(PayItemData csv, PayItemData sdk)
	{
		return false;
	}

	public bool InGracePeriod(PayItemData csv, PayItemData sdk)
	{
		return false;
	}

	public bool IsOnHold(PayItemData csv, PayItemData sdk)
	{
		return false;
	}

	public void GetGrowthFundDescs()
	{
	}

	public void OnGetPayLevelConfig(CSGetPayLevelConfigRes res, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public PlayLevelInfo GetPayLevelItemInfo(uint id, uint level)
	{
		return null;
	}

	public void GetPayLevelInfo(List<uint> ids, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void ClaimPayLevelReward(uint id, uint level)
	{
	}

	public ResourceID GetPayLevelRewardIcon(uint level)
	{
		return default(ResourceID);
	}

	public uint GetTotalPayLevelRewardDiamondCount()
	{
		return 0u;
	}

	public uint GetPayLevelMaxLevel()
	{
		return 0u;
	}

	public uint GetCurPayLevelInfoFinishedLevel()
	{
		return 0u;
	}

	public EStore.PayLevelRewardHintType GetCurPayLevelDescHint()
	{
		return EStore.PayLevelRewardHintType.PayLevelRewardHintType_NONE;
	}

	public bool HasBoughtGrowthFund()
	{
		return false;
	}

	private uint GetBundlePurchaseTimes(uint bundleId)
	{
		return 0u;
	}

	public bool ExistFinishedPayLevelReward()
	{
		return false;
	}

	public bool ExistUnawardedPayLevelReward()
	{
		return false;
	}

	public EStore.PayLevelInfoState CalcPayLevelInfoState(uint level)
	{
		return EStore.PayLevelInfoState.PayLevelInfoState_RECEIVED;
	}

	public void UpdateDiamondProducts(string[] productIdentifiers)
	{
	}

	public bool IsGrowthFundOpen()
	{
		return false;
	}

	public bool IsGrowthFundV2Open()
	{
		return false;
	}

	public bool CheckHasUnlockedButNotPurchasedGrowthFundV2Item()
	{
		return false;
	}

	public bool HasBoughtGrowthFundV2()
	{
		return false;
	}

	public bool HasExistedUnBuyGrowthFundV2()
	{
		return false;
	}

	public bool HasBoughtGrowthFundV2Item(uint uniqueId)
	{
		return false;
	}

	public uint GetGrowthFundV2ItemPurchaseTimeByUniqueId(uint uniqueId)
	{
		return 0u;
	}

	public bool HasUnclaimedGrowthFundV2Rewards()
	{
		return false;
	}

	public LevelUpPassDesc GetLevelUpPassDescByUniqueID(uint uniqueID)
	{
		return null;
	}

	public PayBundleWindowDesc GetPayBundleWindowDescByUniqueID(uint uniqueID)
	{
		return null;
	}

	public bool CheckCurrentLevelHasGrowthFundV2()
	{
		return false;
	}

	public PayBundleWindowDesc GetPayBundleWindowDescByLevel(uint level)
	{
		return null;
	}

	public uint GetGrowthFundV2MaxLevel()
	{
		return 0u;
	}

	public int GetGrowthFundV2PurchaseTimes()
	{
		return 0;
	}

	public List<PayBundleWindowDesc> GetGrowthFundV2PayBundleWindowDescList()
	{
		return null;
	}

	public uint GetNextGrowthFundLevel(uint level)
	{
		return 0u;
	}

	public uint GetFirstGrowthFundLevel()
	{
		return 0u;
	}

	public EStore.PayLevelInfoState CalcPayLevelInfoStateV2(uint level)
	{
		return EStore.PayLevelInfoState.PayLevelInfoState_RECEIVED;
	}

	public void SeenGrowthFundV2()
	{
	}

	private void UpdateGrowthFundV2Tips()
	{
	}

	public bool IsMemberShipOpen()
	{
		return false;
	}

	public EInsufficientDiamondsGotoType GetInsufficientDiamondsGotoType()
	{
		return (EInsufficientDiamondsGotoType)0;
	}

	public void OnPayLevelItemInfoNotification(PlayLevelInfoWrapper res)
	{
	}

	public void OnReceivedGrowthFundBundle(ExchangeChangeData awards, List<PlayLevelInfo> infos)
	{
	}

	private void _003CPayForPendingPaymentBundle_003Eb__115_0(bool purchasing, string product, long rebateId)
	{
	}

	private void _003CGetPayLevelInfo_003Eb__179_0(HttpErrorCode errorCode, object res)
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
