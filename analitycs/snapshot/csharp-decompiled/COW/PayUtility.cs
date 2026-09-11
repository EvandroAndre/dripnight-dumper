using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using UnityEngine;
using tcp;

namespace COW;

public static class PayUtility
{
	public abstract class PaymentDelegate
	{
		public class ProductPurchasedReaction
		{
			public bool UpdateRebateOption;

			public bool UpdateProduct;

			public bool UpdateProductsInDemand;
		}

		public class ProductPurchasedResult
		{
			public bool IsOK;

			public ErrorCode Code;

			public string Msg;
		}

		public class ScanAndClearResult
		{
			public string Product;

			public bool IsOK;
		}

		public class ObtainPendingTransactionsResult
		{
			public bool IsOK;

			public string ErrorMessage;

			public PendingTransactionInfo[] Transactions;
		}

		public class PendingTransactionInfo
		{
			public string TransactionId;

			public string[] ProductIds;

			public int ServerId;

			public int RoleId;
		}

		public class PendingPurchaseResult
		{
			public string Product;

			public bool Success;

			public int ConsumeResult;

			public string Error;

			public bool IsPromotion;

			public int VirtualCurrencyAmount;
		}

		private string[] _003CProductsInDemand_003Ek__BackingField;

		private long[] _003CRebateOptionsInDemand_003Ek__BackingField;

		private bool _003CEventProductsInDemand_003Ek__BackingField;

		protected Action<bool, string, bool, long> _OnPurchasingProduct;

		protected Action<bool, string, long> _OnPurchasingRebateOption;

		public abstract string Name { get; }

		public virtual string[] ProductsInDemand
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

		public virtual long[] RebateOptionsInDemand
		{
			get
			{
				return _003CRebateOptionsInDemand_003Ek__BackingField;
			}
			set
			{
				_003CRebateOptionsInDemand_003Ek__BackingField = value;
			}
		}

		public virtual string EventTypeInDemand => null;

		public virtual bool EventProductsInDemand
		{
			get
			{
				return _003CEventProductsInDemand_003Ek__BackingField;
			}
			protected set
			{
				_003CEventProductsInDemand_003Ek__BackingField = value;
			}
		}

		public virtual bool NeedPendingPurchasesScanned => false;

		public virtual void OnScannedAndCleared(ScanAndClearResult[] results)
		{
		}

		public virtual void OnObtainedPendingTransactions(ObtainPendingTransactionsResult result)
		{
		}

		public virtual bool OnPendingPurchasesScanned(PendingPurchaseResult[] results)
		{
			return false;
		}

		public virtual void OnEventConfigsUpdated(string reason, bool result)
		{
		}

		public virtual void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		public virtual void OnEventProductsAndDataUpdate(string reason, bool result)
		{
		}

		protected Dictionary<long, SDKIAP.Event> GetEventConfigs()
		{
			return null;
		}

		protected Dictionary<long, SDKIAP.EventDatum> GetEventData()
		{
			return null;
		}

		public virtual void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
		{
		}

		public virtual ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public virtual bool OnEventProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, int quantity)
		{
			return false;
		}

		public virtual string[] OnGetProductsInDemand(string reason, ProductPurchasedResult result)
		{
			return null;
		}

		public virtual void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
		{
		}

		public virtual bool PaymentAfterRecommitted(int pendingProduct, int[] recommittedProducts)
		{
			return false;
		}

		public virtual bool CheckContinuePaymentAfterPendingPurchase(int pendingProduct)
		{
			return false;
		}

		public virtual bool ShowCustomPaymentFailure(int pendingProductId, bool needRevokePendingPurchase, Action CancelPaymentAction)
		{
			return false;
		}

		public virtual bool CanContinuePaymentWhenPending(int productId)
		{
			return false;
		}

		public virtual bool OnRebateOptionRedeemed(string reason, bool result, RebateOptionRedeemResult redeemResult)
		{
			return false;
		}

		public bool LackProducts(bool logVerbose = false)
		{
			return false;
		}

		public bool LackRebateOptions()
		{
			return false;
		}

		public virtual bool UpdateProducts(string reason, string[] itemIdentifiers = null, long[] rebateIds = null)
		{
			return false;
		}

		public virtual bool UpdateRebateOptions(string reason)
		{
			return false;
		}

		private bool IsOfferPersonalized(string paymentType = "")
		{
			return false;
		}

		public void PurchaseProduct(string reason, string productIdentifier, bool isEvent = false, long eventId = 0L, Action<bool, string, bool, long> onPurchasing = null)
		{
		}

		public void PurchaseRebateOption(string reason, string productIdentifier, long rebateId, Action<bool, string, long> onPurchasing = null)
		{
		}

		protected bool _DemandUpdateEventConfigs(string reason)
		{
			return false;
		}

		protected bool _DemandUpdateProducts(string reason, string[] itemIdentifiers, long[] rebateIds)
		{
			return false;
		}

		protected bool _DemandUpdateEventProducts(string reason)
		{
			return false;
		}

		protected bool _DemandUpdateRebateOptions(string reason)
		{
			return false;
		}
	}

	public class SubscriptionSwitch
	{
		public const int Off = 0;

		public const int On = 1;

		public const int Subscribed = 2;

		public static int GetSubscriptionSwitch(string gameVarDefRegions)
		{
			return 0;
		}
	}

	public class SubscriptionGracePeriodReminderInfo
	{
		public Action<SubscriptionGracePeriodReminderInfo> OnConfirm;

		public Action<SubscriptionGracePeriodReminderInfo> OnCancel;
	}

	public struct SubscriptionHintOption
	{
		public Subscription Subscription;

		public Vector3 Position;

		public string LocKey_Title;

		public string LocKey_LastPaymentTime;

		public string LocKey_NextPaymentTime;

		public string LocKey_Cancel;

		public string Effect_Time;

		public string Reset_Time;
	}

	public class RebateOptionRedeemResult
	{
		public long RebateID;

		public int RemainingDays;

		public int RedeemAmount;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, PlatformPromotionProductsData> _003C_003E9__34_1;

		public static Converter<SDKIAP.ScanIAPInventoryResult, PaymentDelegate.ScanAndClearResult> _003C_003E9__34_2;

		public static Converter<long, string> _003C_003E9__76_0;

		public static Converter<string, int> _003C_003E9__87_0;

		public static Converter<int, string> _003C_003E9__87_1;

		public static Converter<long, string> _003C_003E9__87_2;

		public static Converter<SDKIAP.IAPItem, string> _003C_003E9__90_0;

		public static Converter<SDKIAP.IAPItem, string> _003C_003E9__90_1;

		public static Converter<SDKIAP.IAPItem, string> _003C_003E9__96_0;

		public static Converter<int, string> _003C_003E9__96_2;

		public static Converter<SDKIAP.EventDatum, string> _003C_003E9__96_1;

		public static Converter<SDKIAP.RebateOption, string> _003C_003E9__100_0;

		public static Converter<SDKIAP.RebateOption, long> _003C_003E9__100_1;

		public static Action _003C_003E9__110_1;

		public static Func<SDKIAP.ScanIAPInventoryResult, bool> _003C_003E9__111_1;

		public static Func<SDKIAP.ScanIAPInventoryResult, bool> _003C_003E9__111_2;

		public static Converter<SDKIAP.ScanIAPInventoryResult, string> _003C_003E9__111_3;

		public static Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[], SDKIAP.ScanIAPInventoryResult[]> _003C_003E9__111_0;

		public static Action _003C_003E9__116_0;

		public static Action _003C_003E9__117_0;

		public static Action _003C_003E9__119_0;

		public static Converter<SDKIAP.ScanIAPInventoryResult, PaymentDelegate.PendingPurchaseResult> _003C_003E9__124_0;

		public static Converter<string, int> _003C_003E9__125_0;

		internal PlatformPromotionProductsData _003CScanIAPInventory_003Eb__34_1(CSVBaseData temp)
		{
			return null;
		}

		internal PaymentDelegate.ScanAndClearResult _003CScanIAPInventory_003Eb__34_2(SDKIAP.ScanIAPInventoryResult r)
		{
			return null;
		}

		internal string _003CPreload_003Eb__76_0(long id)
		{
			return null;
		}

		internal int _003CUpdateIAPItems_003Eb__87_0(string idStr)
		{
			return 0;
		}

		internal string _003CUpdateIAPItems_003Eb__87_1(int itemId)
		{
			return null;
		}

		internal string _003CUpdateIAPItems_003Eb__87_2(long rebateId)
		{
			return null;
		}

		internal string _003CApplyUpdatedIAPItems_003Eb__90_0(SDKIAP.IAPItem item)
		{
			return null;
		}

		internal string _003CApplyUpdatedIAPItems_003Eb__90_1(SDKIAP.IAPItem item)
		{
			return null;
		}

		internal string _003COnEventIAPItemsLoaded_003Eb__96_0(SDKIAP.IAPItem item)
		{
			return null;
		}

		internal string _003COnEventIAPItemsLoaded_003Eb__96_1(SDKIAP.EventDatum datum)
		{
			return null;
		}

		internal string _003COnEventIAPItemsLoaded_003Eb__96_2(int id)
		{
			return null;
		}

		internal string _003CApplyUpdatedRebateItems_003Eb__100_0(SDKIAP.RebateOption rebateOption)
		{
			return null;
		}

		internal long _003CApplyUpdatedRebateItems_003Eb__100_1(SDKIAP.RebateOption rebateOption)
		{
			return 0L;
		}

		internal void _003CShowPaymentFailureMessageBox_003Eb__110_1()
		{
		}

		internal void _003CRecommitBeforePayment_003Eb__111_0(SDKIAPTaskInfo info, SDKIAP.ScanIAPInventoryResult[] results, SDKIAP.ScanIAPInventoryResult[] pendingResults)
		{
		}

		internal bool _003CRecommitBeforePayment_003Eb__111_1(SDKIAP.ScanIAPInventoryResult r)
		{
			return false;
		}

		internal bool _003CRecommitBeforePayment_003Eb__111_2(SDKIAP.ScanIAPInventoryResult r)
		{
			return false;
		}

		internal string _003CRecommitBeforePayment_003Eb__111_3(SDKIAP.ScanIAPInventoryResult r)
		{
			return null;
		}

		internal void _003C_CheckPurchaseProductInPendingState_003Eb__116_0()
		{
		}

		internal void _003C_OnAfterProcessPendingPurchaseResults_003Eb__117_0()
		{
		}

		internal void _003CTryPendingPaymentAction_003Eb__119_0()
		{
		}

		internal PaymentDelegate.PendingPurchaseResult _003CNotifyDelegates_CheckNeedCancelPendingPurchase_003Eb__124_0(SDKIAP.ScanIAPInventoryResult r)
		{
			return null;
		}

		internal int _003CNotifyDelegates_PaymentAfterRecommitted_003Eb__125_0(string str)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public Action onCancel;

		internal void _003CShowPaymentFailureMessageBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public KeyValuePair<string, PaymentDelegate> pair;

		internal bool _003CNotifyDelegates_OnScannedAndCleared_003Eb__0(PaymentDelegate.ScanAndClearResult r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public SDKIAPTaskInfo info;

		public SDKIAPTaskResult result;

		public bool isEvent;

		public string item_identifier;

		public int quantity;

		internal void _003COnPurchasedProduct_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public SDKIAPTaskInfo info;

		public SDKIAPTaskResult result;

		public string display_item_identifier;

		public long display_rebate_id;

		public SDKIAPManager.RebateOptionPurchaseResult purchaseResult;

		internal void _003COnPurchaseRebateItemFailure_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public bool notify;

		internal void _003CObtainPendingTransactions_003Eb__0(SDKIAPTaskInfo info, SDKIAP.ObtainPendingTransactionsResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public bool notify;

		internal void _003CScanIAPInventory_003Eb__0(SDKIAPTaskInfo info, SDKIAP.ScanIAPInventoryResult[] results, SDKIAP.ScanIAPInventoryResult[] pendingResults)
		{
		}
	}

	internal static readonly DateTime APOCH_UTC;

	private static bool _Inited;

	private const string IAP_ITEM_IDENTIFIER_TEMPLATE_GOOGLE_PLAY = "freefire.diamond.{0}";

	private static string _003CPaymentLimitResetTimeString_003Ek__BackingField;

	private static Dictionary<string, PaymentDelegate> _PaymentDelegates;

	private static bool _003CScanningIAPInventory_003Ek__BackingField;

	private static bool _003CObtainingPendingTransactions_003Ek__BackingField;

	private static Dictionary<string, PayItemData> _FetchedProductsByIdentifier;

	private static Dictionary<string, PayItemData> _FetchedEventProductsByIdentifier;

	private static Dictionary<string, Dictionary<long, SDKIAP.Event>> _FetchedEventConfigs;

	private static Dictionary<string, Dictionary<long, SDKIAP.EventDatum>> _FetchedEventData;

	private static Dictionary<long, RebateItemData> _RebateItems;

	private static PaymentAction _003C_LastPaymentAction_003Ek__BackingField;

	private static PaymentAction _003C_LastPaymentAttempt_003Ek__BackingField;

	private static string _003CLastPaymentProductIdentifier_003Ek__BackingField;

	private static bool _003CIsLoggedIn_003Ek__BackingField;

	private static SDKType LastSDKType;

	private static string LastSDKID;

	private static bool SDKAccountChanged;

	private static Dictionary<int, string> _PaymentErrorCodeToMsgLocKey;

	private const int SecondsInDay = 86400;

	private const int RebateRedeemResetSecondsInDay_UTC = 68400;

	public static bool TestPaymentChannelEnabled => false;

	private static string IAPItemIdentifierTemplate => null;

	public static string PaymentLimitResetTimeString
	{
		get
		{
			return _003CPaymentLimitResetTimeString_003Ek__BackingField;
		}
		set
		{
			_003CPaymentLimitResetTimeString_003Ek__BackingField = value;
		}
	}

	public static bool ShouldRecommitBeforePayment => false;

	public static bool ScanningIAPInventory
	{
		get
		{
			return _003CScanningIAPInventory_003Ek__BackingField;
		}
		private set
		{
			_003CScanningIAPInventory_003Ek__BackingField = value;
		}
	}

	public static bool ObtainingPendingTransactions
	{
		get
		{
			return _003CObtainingPendingTransactions_003Ek__BackingField;
		}
		private set
		{
			_003CObtainingPendingTransactions_003Ek__BackingField = value;
		}
	}

	public static Dictionary<long, RebateItemData> RebateItems => null;

	private static PaymentAction _LastPaymentAction
	{
		get
		{
			return _003C_LastPaymentAction_003Ek__BackingField;
		}
		set
		{
			_003C_LastPaymentAction_003Ek__BackingField = value;
		}
	}

	private static PaymentAction _LastPaymentAttempt
	{
		get
		{
			return _003C_LastPaymentAttempt_003Ek__BackingField;
		}
		set
		{
			_003C_LastPaymentAttempt_003Ek__BackingField = value;
		}
	}

	public static string LastPaymentProductIdentifier
	{
		get
		{
			return _003CLastPaymentProductIdentifier_003Ek__BackingField;
		}
		private set
		{
			_003CLastPaymentProductIdentifier_003Ek__BackingField = value;
		}
	}

	public static bool IsLoggedIn
	{
		get
		{
			return _003CIsLoggedIn_003Ek__BackingField;
		}
		private set
		{
			_003CIsLoggedIn_003Ek__BackingField = value;
		}
	}

	public static bool Pending => false;

	private static bool ShowIAPFailureSignature => false;

	internal static DateTime SecondsAfterApoch(long seconds)
	{
		return default(DateTime);
	}

	public static string USD(float price)
	{
		return null;
	}

	public static string USD(string price)
	{
		return null;
	}

	private static void Uninit()
	{
	}

	private static void Init(int serverID = 0)
	{
	}

	public static void Register(PaymentDelegate del)
	{
	}

	public static void Unregister(PaymentDelegate del)
	{
	}

	private static PaymentDelegate.ProductPurchasedResult Convert(SDKIAPTaskResult result)
	{
		return null;
	}

	private static void NotifyDelegates_ProductPurchased(SDKIAPTaskInfo info, SDKIAPTaskResult result, bool isEvent, string productIdentifier, long rebateId, int quantity)
	{
	}

	private static void ClearTransactions(bool notify = false)
	{
	}

	private static void ObtainPendingTransactions(bool notify = false)
	{
	}

	private static void ScanIAPInventory(bool notify = false, bool collectPendingPurchases = false)
	{
	}

	private static void ProcessScanInventoryResults(SDKIAP.ScanIAPInventoryResult[] results)
	{
	}

	private static void ProcessPendingPurchaseResults(SDKIAP.ScanIAPInventoryResult[] pendingResults)
	{
	}

	private static void ProcessObtainPendingTransactionsResults(SDKIAP.ObtainPendingTransactionsResult result)
	{
	}

	private static void NotifyDelegates_OnObtainedPendingTransactions(SDKIAP.ObtainPendingTransactionsResult result)
	{
	}

	private static void ShowPlatformPromotionProductMessageBox()
	{
	}

	public static void OnApplicationPause(bool paused)
	{
	}

	public static uint ExtractProductId(string productIdentifier)
	{
		return 0u;
	}

	public static string FormatProductIdentifier(int productId)
	{
		return null;
	}

	public static PayItemData GetFetchedProduct(int productId)
	{
		return null;
	}

	public static PayItemData GetFetchedProduct(string productIdentifier)
	{
		return null;
	}

	public static PayItemData GetFetchedEventProduct(int productId)
	{
		return null;
	}

	public static PayItemData GetFetchedEventProduct(string productIdentifier)
	{
		return null;
	}

	public static void AfterLogoutSDK()
	{
	}

	public static void AfterLoginSDK()
	{
	}

	public static void AfterLoginServer(int serverID = 0)
	{
	}

	public static void Preload()
	{
	}

	public static void AfterLogoutServer()
	{
	}

	private static void UpdateTips()
	{
	}

	public static bool IsSupportIAP()
	{
		return false;
	}

	public static bool IsSupportEventIAP()
	{
		return false;
	}

	private static string GetMessageForNotSupportingIAP()
	{
		return null;
	}

	public static void ShowNotSupportingIAPMessageBox(uint gopos, bool standard = false, string param = "")
	{
	}

	public static bool SupportSubscription()
	{
		return false;
	}

	private static bool UpdateIAPItems(SDKIAPTaskInfo info, string[] itemIdentifiers, long[] rebateIds)
	{
		return false;
	}

	private static void OnAllIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
	{
	}

	private static void OnSomeIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
	{
	}

	private static void ApplyUpdatedIAPItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items, bool replace)
	{
	}

	private static PayItemData ParsePayItemData(SDKIAP.IAPItem iapItem)
	{
		return null;
	}

	private static void UpdateIAPProductTips()
	{
	}

	private static bool LoadEventConfigs(SDKIAPTaskInfo info, bool activeOnly)
	{
		return false;
	}

	private static void OnEventConfigsLoaded(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.LoadEventConfigsResult ret)
	{
	}

	private static bool LoadEventIAPItems(SDKIAPTaskInfo info)
	{
		return false;
	}

	private static void OnEventIAPItemsLoaded(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.LoadEventIAPResult ret)
	{
	}

	private static bool UpdateRebateItems(SDKIAPTaskInfo info, long[] rebateIds)
	{
		return false;
	}

	private static void OnAllRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
	{
	}

	private static void OnSomeRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
	{
	}

	private static void ApplyUpdatedRebateItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions, bool replace)
	{
	}

	private static RebateItemData ParseRebateItemData(SDKIAP.RebateOption rebateOption)
	{
		return null;
	}

	private static bool ClearLastIAPAction()
	{
		return false;
	}

	private static void RetryLastIAPAction()
	{
	}

	public static bool CanTryFixingGracePeriod()
	{
		return false;
	}

	public static void TryFixingGracePeriod()
	{
	}

	public static bool CanTryFixingOnHold()
	{
		return false;
	}

	public static void TryFixingOnHold()
	{
	}

	private static string IAPFailureSignature(string item_identifier, int rebate_id, ErrorCode errorCode)
	{
		return null;
	}

	private static void ShowPaymentFailureMessageBox(SDKIAPTaskResult result, string item_identifier, int rebate_id, Action onCancel = null)
	{
	}

	private static void RecommitBeforePayment(bool collectPendingPurchases = false)
	{
	}

	private static void _OnAfterRecommitBeforePaymentSuccess(bool continuePayment)
	{
	}

	private static void _RecommitBeforePaymentFailure()
	{
	}

	private static bool _RecommitBeforePaymentSuccess(string[] recommittedProducts)
	{
		return false;
	}

	private static bool _ProcessPendingPurchaseResultsOnRecommit(SDKIAP.ScanIAPInventoryResult[] pendingResults)
	{
		return false;
	}

	private static bool _CheckPurchaseProductInPendingState()
	{
		return false;
	}

	private static bool _OnAfterProcessPendingPurchaseResults()
	{
		return false;
	}

	private static bool NotifyDelegates_ShowCustomPaymentFailure(Action CancelPaymentAction)
	{
		return false;
	}

	private static void TryPendingPaymentAction()
	{
	}

	private static bool CheckNeedUpdateOfflineProducts(SDKIAP.ScanIAPInventoryResult[] results)
	{
		return false;
	}

	private static bool NotifyDelegates_UpdateProductsAfterRecommit(string[] updateOfflineProducts)
	{
		return false;
	}

	private static void NotifyDelegates_OnWillHandlePaymentAttempt(bool willPurchase)
	{
	}

	private static void NotifyDelegates_OnScannedAndCleared(PaymentDelegate.ScanAndClearResult[] results)
	{
	}

	private static bool NotifyDelegates_CheckNeedCancelPendingPurchase(SDKIAP.ScanIAPInventoryResult[] pendingResults, bool checkNeedPreloadScanned = false)
	{
		return false;
	}

	private static bool NotifyDelegates_PaymentAfterRecommitted(string[] recommittedProducts)
	{
		return false;
	}

	private static bool NotifyDelegates_CheckContinuePaymentAfterPendingPurchase()
	{
		return false;
	}

	private static void PurchaseProduct(SDKIAPTaskInfo info, string productIdentifier, int quantity, bool isEvent, long eventId, bool isOfferPersonalized)
	{
	}

	private static void _PurchaseProduct(SDKIAPTaskInfo info, string productIdentifier, int quantity, bool isEvent, long eventId, bool isOfferPersonalized)
	{
	}

	private static void OnPurchaseProductSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, int quantity)
	{
	}

	private static void OnPurchaseProductFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
	{
	}

	private static void OnPurchaseEventProductSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, int quantity)
	{
	}

	private static void OnPurchaseEventProductFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
	{
	}

	private static void OnPurchasedProduct(SDKIAPTaskInfo info, SDKIAPTaskResult result, bool isEvent, bool success)
	{
	}

	public static bool ShouldOverrideLocalPaymentItem(ErrorCode errorCode)
	{
		return false;
	}

	public static bool ShouldPromptRetry(ErrorCode errorCode)
	{
		return false;
	}

	private static string GetPaymentFailureMessage(SDKIAPTaskResult result)
	{
		return null;
	}

	public static string ErrorCodeToString_IAP(int errorCode, string errorMessage = "")
	{
		return null;
	}

	public static string GetPaymentNotificationString(InventoryTopupNtf topupNotification)
	{
		return null;
	}

	public static string SubscriptionPeriodLocalizationKey(SubscriptionPeriod sp)
	{
		return null;
	}

	public static void ShowSubscriptionHint(SubscriptionHintOption option)
	{
	}

	public static void PromptOnInsufficientDiamonds(UINavigationUtil.UINavigationFrom from, int gems, string msg = "", string title = "", string okText = "")
	{
	}

	public static void ShowPaymentMessageBox(string message, string title = "", string okText = "", Action onOK = null, Action onCancel = null, string note = "", UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.None, Action onClose = null)
	{
	}

	public static void ShowPaymentMessageBoxNotUseSpecialDepth(string message, string title = "", string okText = "", Action onOK = null, Action onCancel = null, string note = "", UIPopupMessageBox2Controller.EButtonStyle buttonStyle = UIPopupMessageBox2Controller.EButtonStyle.None)
	{
	}

	private static void OnPurchaseRebateItemSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
	{
	}

	private static void OnPurchaseRebateItemFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
	{
	}

	private static void PurchaseRebateOption(SDKIAPTaskInfo info, string productIdentifier, long rebateId, bool isOfferPersonalized)
	{
	}

	private static void _PurchaseRebateOption(SDKIAPTaskInfo info, string productIdentifier, long rebateId, bool isOfferPersonalized)
	{
	}

	public static void RedeemRebateOption(int rebateId)
	{
	}

	private static void OnRebateOptionRedeemed(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateRedeemResult[] results)
	{
	}

	public static int GetRebateNextResetTime()
	{
		return 0;
	}
}
