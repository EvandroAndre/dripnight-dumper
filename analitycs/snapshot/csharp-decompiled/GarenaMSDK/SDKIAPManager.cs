using System;
using System.Collections.Generic;

namespace GarenaMSDK;

public static class SDKIAPManager
{
	public class SDKIAPManagerConfiguration
	{
		public bool LocalizePrice;

		public int ServerID;

		public int RoleID;

		public string Region;

		public string ProductPrefix_iOS;
	}

	public class RebateOptionPurchaseResult
	{
		public string ProductIdentifier;

		public long RebateID;

		public int RemainingDays;

		public int Quantity;
	}

	private static readonly Dictionary<int, int> _TaskTypes;

	private static List<SDKIAPTaskInstance> _Tasks;

	private static SDKIAPTaskInstance _PendingTask;

	private static SDKIAPManagerConfiguration _Configuration;

	public static bool Pending => false;

	public static SDKIAPManagerConfiguration Configuration
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static void DestroyTask(SDKIAPTaskInstance taskInstance)
	{
	}

	private static bool ExecuteTask(SDKIAPTaskInstance taskInstance)
	{
		return false;
	}

	private static bool ProcessTask(SDKIAPTaskInstance taskInstance)
	{
		return false;
	}

	private static bool CanFinishWith<T>(T t, SDKIAPTaskInstance i) where T : SDKIAPTaskInstance
	{
		return false;
	}

	internal static void Finish<T>(T t, Action<T> callback) where T : SDKIAPTaskInstance
	{
	}

	internal static void TaskInstanceStateChanged(SDKIAPTaskInstance task, SDKIAPTaskState prev, SDKIAPTaskState next)
	{
	}

	public static bool ScanIAPInventory(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[], SDKIAP.ScanIAPInventoryResult[]> scanned, bool collectPendingPurchases = false)
	{
		return false;
	}

	public static bool ObtainPendingTransactions(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAP.ObtainPendingTransactionsResult> obtained)
	{
		return false;
	}

	public static bool LoadIAPItems(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done, int rebateID = 0, bool allItems = false)
	{
		return false;
	}

	public static bool LoadRebateOptions(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done, bool force = false)
	{
		return false;
	}

	public static bool LoadSomeIAPItems(SDKIAPTaskInfo info, int[] productIds, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done)
	{
		return false;
	}

	public static bool LoadSomeRebateOptions(SDKIAPTaskInfo info, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done)
	{
		return false;
	}

	public static bool PurchaseNormalProduct(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> failure, string productIdentifier = null, int quantity = 1, bool isOfferPersonalized = false)
	{
		return false;
	}

	public static bool PurchaseRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, RebateOptionPurchaseResult> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, RebateOptionPurchaseResult> failure, int rebateID, string productIdentifier, bool isOfferPersonalized = false)
	{
		return false;
	}

	public static bool RedeemRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> redeemed, int rebateID)
	{
		return false;
	}

	public static bool LoadEventConfigs(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventConfigsResult> done, bool activeOnly)
	{
		return false;
	}

	public static bool LoadEventIAPItems(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventIAPResult> done)
	{
		return false;
	}

	public static bool PurchaseEventProduct(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> failure, long eventId, string productIdentifier, int quantity = 1, bool isOfferPersonalized = false)
	{
		return false;
	}
}
