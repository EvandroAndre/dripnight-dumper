using System;
using System.Collections.Generic;
using UnityEngine;

namespace GarenaMSDK;

public static class SDKIAP_Android
{
	[Serializable]
	public enum TransactionStatus
	{
		Created = 6001,
		Opening,
		Opened,
		Processed,
		Closed,
		ClosedWithError
	}

	[Serializable]
	public enum ResultCode
	{
		Success,
		Cancel,
		Error
	}

	[Serializable]
	public class TransactionInfo
	{
		public int status;

		public int transactionStatus;

		public int resultCode;

		public int errorCode;

		public string transactionId;

		public string name;

		public string icon;

		public int appPoints;

		public long rebateId;

		public int remainingDays;

		public string transactionError;

		public string errorMessage;

		public int quantity;

		public Dictionary<string, string> extras;

		public static TransactionInfo FromJson(string json)
		{
			return null;
		}
	}

	[Serializable]
	public class RebateOptionItem
	{
		public long rebateId;

		public int rebateAmount;

		public int remainingDays;

		public int rebateDays;

		public bool validToPurchase;

		public bool validToRedeem;

		public bool owned;

		public string name;

		public string description;
	}

	[Serializable]
	public class GetRebateOptionsResult
	{
		public int result;

		public RebateOptionItem[] options;
	}

	[Serializable]
	public class RedeemResultItem
	{
		public long rebateId;

		public int appPoint;

		public int remainingDays;
	}

	[Serializable]
	public class RedeemResponse
	{
		public int result;

		public int totalRedeemed;

		public RedeemResultItem[] redeemList;
	}

	[Serializable]
	public class RedeemResult
	{
		public int result;

		public RedeemResponse response;
	}

	[Serializable]
	public class Denomination
	{
		public int appPoints;

		public string iconUrl;

		public bool isPromo;

		public string itemId;

		public string name;

		public string localizedPrice;

		public string price;

		public int promoPoints;

		public int rebateId;

		public string priceCode;

		public long priceAmountMicros;

		public Subscription subscription;

		public string Price => null;
	}

	[Serializable]
	public class Subscription
	{
		public int period;

		public int status;

		public int lastPaymentTime;

		public long gracePeriodExpiryTime;

		public long onHoldSince;
	}

	[Serializable]
	public class Channel
	{
		public int category;

		public string name;

		public string channelId;

		public float discount;

		public string description;

		public int flag;

		public string iconUrl;

		public Denomination[] items;
	}

	[Serializable]
	public class LoadPaymentOptionsResult
	{
		public Channel[] paymentChannels;

		public string exception;
	}

	[Serializable]
	public class ScanGoogleIAPInventoryResult
	{
		[Serializable]
		public class Result
		{
			[Serializable]
			public class ItemInfo
			{
				public bool isPromotion;

				public string itemName;

				public int amount;

				public string itemSku;
			}

			public string error;

			public int consumeResult;

			public ItemInfo item;
		}

		public Result[] results;

		public Result[] pendingResults;
	}

	[Serializable]
	public class ObtainPendingTransactionsResult_GooglePlay
	{
		public int result;

		public string errorMessage;

		public PendingTransaction_GooglePlay[] transactions;
	}

	[Serializable]
	public class PendingTransaction_GooglePlay
	{
		public string id;

		public string[] productIds;

		public int serverId;

		public int roleId;
	}

	[Serializable]
	public class EventConfigLessIsMore
	{
		public long rebate_id;

		public long item_id;

		public double price;

		public string extra_info;
	}

	[Serializable]
	public class EventLessIsMore
	{
		public long id;

		public long start_time;

		public long end_time;

		public string region;

		public string type;

		public EventConfigLessIsMore[] configs;
	}

	[Serializable]
	public class LoadEventConfigsResult
	{
		public int result;

		public string exception;

		public EventLessIsMore[] eventsLessIsMore;
	}

	[Serializable]
	public class PricingEvent
	{
		public int id;

		public string type;

		public long start_time;

		public long end_time;

		public int available_times;

		public int total_times;

		public int status;

		public int[] items;
	}

	[Serializable]
	public class GetEventsPricingResult
	{
		public int result;

		public string exception;

		public Denomination[] paymentOptions;

		public PricingEvent[] pricingEvents;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<long, string> _003C_003E9__22_0;

		public static Converter<RebateOptionItem, SDKIAP.RebateOption> _003C_003E9__23_0;

		public static Converter<int, string> _003C_003E9__26_0;

		public static Converter<long, string> _003C_003E9__26_1;

		public static Converter<RedeemResultItem, SDKIAP.RebateRedeemResult> _003C_003E9__37_0;

		public static Converter<PendingTransaction_GooglePlay, SDKIAP.PendingTransaction> _003C_003E9__42_0;

		internal string _003CGetRebateOptions_003Eb__22_0(long id)
		{
			return null;
		}

		internal SDKIAP.RebateOption _003COnGetRebateOptions_003Eb__23_0(RebateOptionItem input)
		{
			return null;
		}

		internal string _003CLoadPaymentOptions_003Eb__26_0(int id)
		{
			return null;
		}

		internal string _003CLoadPaymentOptions_003Eb__26_1(long id)
		{
			return null;
		}

		internal SDKIAP.RebateRedeemResult _003COnRedeemed_003Eb__37_0(RedeemResultItem input)
		{
			return null;
		}

		internal SDKIAP.PendingTransaction _003COnObtainPendingTransactionsResult_003Eb__42_0(PendingTransaction_GooglePlay t)
		{
			return null;
		}
	}

	private static AndroidJavaClass _IAP;

	private const string PAYMENT_CHANNEL_ID_GOOGLE_PLAY = "201069";

	private const string PAYMENT_CHANNEL_ID_TEST = "999999";

	public static AndroidJavaClass IAP => null;

	private static string PaymentChannelID => null;

	public static bool IsGooglePlayServicesAvailable()
	{
		return false;
	}

	private static bool SupportPersonalizedOffer()
	{
		return false;
	}

	public static void SetLocale(string language, string region)
	{
	}

	public static void SetEligibilityRegion(string region)
	{
	}

	public static void SetTopupLimit(int topupLimit)
	{
	}

	public static void SetPaymentTestChannel(bool enabled)
	{
	}

	public static void GetRebateOptions(int serverId, int roleId)
	{
	}

	public static void GetRebateOptions(int serverId, int roleId, long[] rebateIds)
	{
	}

	public static void OnGetRebateOptions(string getRebateOptionsResult)
	{
	}

	public static void ClearIAPItems()
	{
	}

	public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool allItems, long rebateId, bool localizedPrice)
	{
		return false;
	}

	public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool localizedPrice, int[] itemIds, long[] rebateIds)
	{
		return false;
	}

	public static void OnPaymentOptionsLoaded(string result)
	{
	}

	public static bool ProcessPaymentWithChannelItem(int serverId, int roleId, string virtualCurrencyName, string itemIdentifier, bool isOfferPersonalized)
	{
		return false;
	}

	public static bool ProcessPayment(int serverId, int roleId, string virtualCurrencyName, long rebateId, bool isOfferPersonalized)
	{
		return false;
	}

	public static void OnPaymentProcessed_Exception(string transactionInfo)
	{
	}

	public static void OnPaymentProcessed(string transactionInfo)
	{
	}

	public static void Redeem(long rebateId = 0L, int serverId = 0, int roleId = 0)
	{
	}

	public static void OnRedeemed(string redeemResult)
	{
	}

	public static string ScanGoogleIAPInventory(int serverId, int roleId, bool collectPendingPurchases = false)
	{
		return null;
	}

	public static void OnScanGoogleIAPInventoryResult(string result)
	{
	}

	public static void ObtainPendingTransactions()
	{
	}

	public static void OnObtainPendingTransactionsResult(string result)
	{
	}

	public static bool LoadEventConfigs(string region, bool activeOnly)
	{
		return false;
	}

	internal static void OnLoadEventConfigsResult(string str)
	{
	}

	public static bool LoadEventPaymentOptions(string region, int serverId, int roleId, string virtualCurrencyName, bool localizedPrice)
	{
		return false;
	}

	internal static void OnEventPaymentOptionsLoaded(string str)
	{
	}

	public static bool ProcessEventPayment(string region, string itemId, string eventId, int serverId, int roleId, string virtualCurrencyName, bool isOfferPersonalized)
	{
		return false;
	}

	internal static void OnEventPaymentProcessed_Exception(string str)
	{
	}

	internal static void OnEventPaymentProcessed(string str)
	{
	}
}
