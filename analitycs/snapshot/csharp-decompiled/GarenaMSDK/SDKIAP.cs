using System;

namespace GarenaMSDK;

public static class SDKIAP
{
	public enum ConsumeResult
	{
		SUCCEED,
		FAILED,
		SKIPPED
	}

	public enum SkippedReason
	{
		DEFAULT = -1,
		DUPLICATE = 1,
		PENDING_INTERVAL = 2,
		NOT_LOGIN = 3,
		GENERATE_ACCOUNT_ID_FAILED = 4,
		PURCHASE_ACCOUNT_ID_NOT_FOUND = 5,
		OBFUSCATED_ACCOUNT_ID_NOT_FOUND = 6,
		OBFUSCATED_PROFILE_ID_NOT_FOUND = 7,
		NO_LATEST_USER_INFO_FOUND = 8,
		LATEST_USER_INFO_NOT_MATCH = 9,
		OBFUSCATED_ACCOUNT_ID_NOT_MATCH = 10
	}

	[Serializable]
	public class IAPItem
	{
		public string ItemIdentifier;

		public bool Promotion;

		public int VirtualCurrencyAmount;

		public int PromotionAmount;

		public string ActualCurrencyName;

		public double ActualCurrencyAmount;

		public string PriceString;

		public int RebateId;

		public Subscription Subscription;

		public static IAPItem _(SDKIAP_Android.Denomination denomination)
		{
			return null;
		}
	}

	[Serializable]
	public class Subscription
	{
		public SubscriptionPeriod Period;

		public SubscriptionStatus Status;

		public int LastPaymentTime;

		public long GracePeriodExpiryTime;

		public long OnHoldSince;

		public static Subscription _(SDKIAP_Android.Subscription subscription)
		{
			return null;
		}
	}

	[Serializable]
	public enum SubscriptionStatus
	{
		None = -1,
		Active,
		Expired,
		Cancelled,
		Revoked,
		Transferred,
		Scheduled
	}

	[Serializable]
	public enum SubscriptionPeriod
	{
		None,
		Week_1,
		Month_1,
		Month_3,
		Month_6,
		Year_1
	}

	[Serializable]
	public class RebateOption
	{
		public long RebateId;

		public int RebateAmount;

		public int RemainingDays;

		public int TotalDays;

		public bool CanPurchase;

		public bool CanRedeem;

		public bool Owned;

		public string Name;

		public string Description;
	}

	[Serializable]
	public class RebateRedeemResult
	{
		public long RebateId;

		public int RebateAmount;

		public int RemainingDays;
	}

	[Serializable]
	public abstract class TransactionBase
	{
		public string ItemIdentifier;

		public int VirtualCurrencyAmount;

		public bool IsPromotion;
	}

	[Serializable]
	public class ScanIAPInventoryResult : TransactionBase
	{
		public int ConsumeResult;

		public string Error;

		public bool Success => false;

		public SkippedReason GetSkippedReason()
		{
			return (SkippedReason)0;
		}
	}

	[Serializable]
	public class ScanIAPInventoryResultWithPending
	{
		public ScanIAPInventoryResult[] Results;

		public ScanIAPInventoryResult[] PendingResults;
	}

	[Serializable]
	public class PendingTransaction
	{
		public string Id;

		public string[] ProductIds;

		public int ServerId;

		public int RoleId;
	}

	[Serializable]
	public class ObtainPendingTransactionsResult
	{
		public int Result;

		public string ErrorMessage;

		public PendingTransaction[] Transactions;
	}

	[Serializable]
	public class EventConfig
	{
		public double Price;

		public long ItemId;

		public long RebateId;

		public string ExtraInfo;

		public static EventConfig _(SDKIAP_Android.EventConfigLessIsMore eventConfig)
		{
			return null;
		}
	}

	[Serializable]
	public class Event
	{
		public long EventId;

		public string Type;

		public long StartTime;

		public long EndTime;

		public string Region;

		public EventConfig[] Configs;

		public static Event _(SDKIAP_Android.EventLessIsMore e)
		{
			return null;
		}
	}

	[Serializable]
	public class LoadEventConfigsResult
	{
		public int Flag;

		public string Exception;

		public Event[] Events;

		public static LoadEventConfigsResult _(SDKIAP_Android.LoadEventConfigsResult result)
		{
			return null;
		}
	}

	[Serializable]
	public class EventDatum
	{
		public const int STATUS_ELIGIBLE = 0;

		public const int STATUS_PENDING = 1;

		public const int STATUS_ILLEGIBLE = 2;

		public long EventId;

		public string Type;

		public long StartTime;

		public long EndTime;

		public long AvailableTimes;

		public long TotalTimes;

		public int Status;

		public int[] ItemIds;

		public static EventDatum _(SDKIAP_Android.PricingEvent e)
		{
			return null;
		}
	}

	[Serializable]
	public class LoadEventIAPResult
	{
		public int Flag;

		public string Exception;

		public IAPItem[] Items;

		public EventDatum[] Data;

		public static LoadEventIAPResult _(SDKIAP_Android.GetEventsPricingResult result)
		{
			return null;
		}
	}

	public delegate void LogCallback(string log);

	public static string IAPItemIdentifierTemplate;

	public static string VirtualCurrencyName;

	private static bool _003CPaymentTestChannelEnabled_003Ek__BackingField;

	internal static Action<IAPItem[], ErrorCode, string> OnLoadedIAPItems;

	internal static Action<LoadEventConfigsResult> OnLoadEventConfigs;

	internal static Action<LoadEventIAPResult> OnLoadedEventIAPItems;

	internal static Action<SDKIAP_Android.TransactionInfo> OnPaymentProcessedOrException;

	internal static Action<SDKIAP_Android.TransactionInfo> OnEventPaymentProcessedOrException;

	internal static Action<ScanIAPInventoryResultWithPending> OnScanIAPInventoryResultWithPending;

	internal static Action<ObtainPendingTransactionsResult> OnObtainPendingTransactionsResult;

	internal static Action<RebateOption[], ErrorCode, string> OnLoadedRebateOptions;

	internal static Action<RebateRedeemResult[], ErrorCode, string> OnRedeemedRebateOptions;

	public static LogCallback OnLog;

	public static LogCallback OnLogError;

	public static bool ShouldLogVerbose;

	public static bool PaymentTestChannelEnabled
	{
		get
		{
			return _003CPaymentTestChannelEnabled_003Ek__BackingField;
		}
		private set
		{
			_003CPaymentTestChannelEnabled_003Ek__BackingField = value;
		}
	}

	public static bool IsOK(ErrorCode errorCode)
	{
		return false;
	}

	public static string FormatIAPItemIdentifier(string itemID)
	{
		return null;
	}

	internal static void RestoreIAP(int serverId = 0, int roleId = 0)
	{
	}

	internal static void Log(string log)
	{
	}

	internal static void LogError(string log)
	{
	}

	public static bool CanLoadIAPItemsOnDemand()
	{
		return false;
	}

	public static bool CanGetRebateOptionsOnDemand()
	{
		return false;
	}

	internal static void GetRebateOptions()
	{
	}

	internal static void GetRebateOptionsByRebateIds(long[] rebateIds)
	{
	}

	internal static void ClearIAPItems()
	{
	}

	internal static bool LoadIAPItems(int serverId, int roleId, bool localized, bool allItems = true, long rebateId = 0L)
	{
		return false;
	}

	internal static bool LoadIAPItems(int serverId, int roleId, bool localized, int[] itemIds, long[] rebateIds)
	{
		return false;
	}

	public static void SetLocale(string language, string region)
	{
	}

	public static void SetEligibilityRegion(string region)
	{
	}

	public static void SetTopupLimit(int limit)
	{
	}

	public static void SetPaymentTestChannel(bool enabled)
	{
	}

	public static bool IsPaymentTestChannelEnabled()
	{
		return false;
	}

	private static int ExtractItemIdFromProductIdentifier(string productIdentifier)
	{
		return 0;
	}

	public static bool IsSupportIAP()
	{
		return false;
	}

	internal static bool IAP(string productIdentifier = null, long rebateId = 0L, int quantity = 1, int serverId = 0, int roleId = 0, bool isOfferPersonalized = false)
	{
		return false;
	}

	internal static bool RedeemRebate(int rebateId = 0, int serverId = 0, int roleId = 0)
	{
		return false;
	}

	public static bool ShouldScanIAPInventory()
	{
		return false;
	}

	public static bool CanObtainPendingTransactions()
	{
		return false;
	}

	internal static string ScanIAPInventory(int serverId = 0, int roleId = 0, bool collectPendingPurchases = false)
	{
		return null;
	}

	internal static void ObtainPendingTransactions()
	{
	}

	public static bool IsSupportEventIAP()
	{
		return false;
	}

	internal static bool LoadEventConfigs(string region, bool activeOnly)
	{
		return false;
	}

	internal static bool LoadEventIAPItems(string region, int serverId, int roleId, bool localized)
	{
		return false;
	}

	internal static bool EventIAP(string region, long eventId, string productIdentifier = null, int quantity = 1, int serverId = 0, int roleId = 0, bool isOfferPersonalized = false)
	{
		return false;
	}
}
