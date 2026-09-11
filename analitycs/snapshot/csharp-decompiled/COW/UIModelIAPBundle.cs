using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelIAPBundle : UIBaseModel
{
	public enum State
	{
		NotLoaded,
		Loading,
		Purchasable,
		NotPurchasable,
		Paying,
		Exchanging,
		Pending,
		DiamondExchanging
	}

	private class NormalItemInfo
	{
		public BundleShowData Item;

		public int Index;

		public int Rare;
	}

	private class IAPBundlesDelegate : PayUtility.PaymentDelegate
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string purchasableProductIdentifier;

			internal bool _003COnScannedAndCleared_003Eb__0(ScanAndClearResult r)
			{
				return false;
			}
		}

		private static IAPBundlesDelegate _I;

		public static IAPBundlesDelegate I => null;

		public override string Name => null;

		public override void OnScannedAndCleared(ScanAndClearResult[] results)
		{
		}

		public override bool OnPendingPurchasesScanned(PendingPurchaseResult[] results)
		{
			return false;
		}

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public override bool PaymentAfterRecommitted(int pendingProduct, int[] recommittedProducts)
		{
			return false;
		}

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override bool CheckContinuePaymentAfterPendingPurchase(int pendingProduct)
		{
			return false;
		}

		public override bool CanContinuePaymentWhenPending(int productId)
		{
			return false;
		}

		public override bool ShowCustomPaymentFailure(int pendingProductId, bool needRevokePendingPurchase, Action CancelPaymentAction)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_OnScannedAndCleared(ScanAndClearResult[] P0)
		{
		}

		public bool _003C_003EiFixBaseProxy_OnPendingPurchasesScanned(PendingPurchaseResult[] P0)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public bool _003C_003EiFixBaseProxy_PaymentAfterRecommitted(int P0, int[] P1)
		{
			return false;
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_CheckContinuePaymentAfterPendingPurchase(int P0)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_CanContinuePaymentWhenPending(int P0)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_ShowCustomPaymentFailure(int P0, bool P1, Action P2)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<IAPInfoItem> _003C_003E9__67_0;

		public static Action<HttpErrorCode, object> _003C_003E9__71_1;

		public static Comparison<IAPInfoItem> _003C_003E9__79_0;

		public static Comparison<NormalItemInfo> _003C_003E9__93_0;

		internal bool _003CProcessIAPInfoList_003Eb__67_0(IAPInfoItem temp)
		{
			return false;
		}

		internal void _003CRequestPurchaseForRecommitted_003Eb__71_1(HttpErrorCode errorCode, object response)
		{
		}

		internal int _003CGetCurrentIAPBundleStoreIDList_003Eb__79_0(IAPInfoItem a, IAPInfoItem b)
		{
			return 0;
		}

		internal int _003CGetNormalItemPriority_003Eb__93_0(NormalItemInfo a, NormalItemInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public uint bundelStoreId;

		internal bool _003CGetIAPBundleStoreData_003Eb__0(IAPBundleStoreData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public UIModelIAPBundle _003C_003E4__this;

		public string productIdentifier;

		public int rebateID;

		internal void _003CPurchase_003Eb__0(bool purchasing, string product, long rebateId)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public int[] recommittedProductIDs;

		internal bool _003CRequestPurchaseForRecommitted_003Eb__0(IAPBundleStoreData datum)
		{
			return false;
		}
	}

	public const uint PropID_Available = 2u;

	public const uint PropID_Unavailable = 4u;

	public const uint PropID_IAPResult = 8u;

	public const uint PropID_GotBundle = 16u;

	public const uint PropID_Pending = 32u;

	public const uint PropID_DiamondExchanging = 64u;

	public const uint PropID_DiamondPurchaseFail = 128u;

	public const uint PropID_ProductUpdate = 256u;

	public const uint PropID_DiamondGotBundle = 512u;

	private int m_CurrentStoreID;

	private ulong m_EndTime_S;

	private string m_Slogan;

	private Dictionary<int, IAPInfoItem> m_DictStoreIdToIAPInfoItem;

	private List<int> m_CurrentStoreIDList;

	private bool m_NeedRequestIAPBundleInGame;

	private State _003CCurrentState_003Ek__BackingField;

	private string m_PendingRevokeProductId;

	private List<IAPBundleStoreData> m_IAPBundleStoreDatas;

	private ClientStoreDesc m_IAPBundleClientStoreDesc;

	private bool m_DeepLink;

	private IAPBundleStoreData _PendingIAPBundle;

	private const string PLAYER_PREFS_KEY_IAP_BUNDLE = "IAPBundleEndTime";

	private const string HAS_AUTODOWNLOAD_ITEM = "HAS_AUTODOWNLOAD_ITEM";

	public State CurrentState
	{
		get
		{
			return _003CCurrentState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentState_003Ek__BackingField = value;
		}
	}

	public string PendingRevokeProductId => null;

	public bool NeedRequestIAPBundleInGame
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ClientStoreDesc IAPBundleClientStoreDesc => null;

	public string Slogan => null;

	public void InitAfterLogin()
	{
	}

	public List<IAPBundleStoreData> GetIAPBundleStoreDataLists()
	{
		return null;
	}

	public IAPBundleStoreData GetIAPBundleStoreData(uint bundelStoreId)
	{
		return null;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool ReviewMode()
	{
		return false;
	}

	public bool AllPurchasable()
	{
		return false;
	}

	public EStoreType GetCurBundleStoreType()
	{
		return EStoreType.None;
	}

	public bool ExistStoreType(EStoreType storeType)
	{
		return false;
	}

	public EStoreType GetStoreTypeByStoreId(uint storeId)
	{
		return EStoreType.None;
	}

	public bool IsVisible()
	{
		return false;
	}

	public bool IsExistVisible()
	{
		return false;
	}

	public bool IsVisible(uint storeId)
	{
		return false;
	}

	public bool IsPurchasable()
	{
		return false;
	}

	public bool IsExistPurchasable()
	{
		return false;
	}

	public bool IsExistVisibleWithRevokeSwitch()
	{
		return false;
	}

	public bool IsAllNotPurchasable()
	{
		return false;
	}

	public bool IsPurchasable(uint storeId)
	{
		return false;
	}

	public int CurrentIAPBundleStoreID()
	{
		return 0;
	}

	public IAPBundleStoreData CurrentIAPBundleStore()
	{
		return null;
	}

	public ulong PurchaseEnd_S()
	{
		return 0uL;
	}

	public ulong EndTime_S()
	{
		return 0uL;
	}

	public int PurchaseCountdown_S()
	{
		return 0;
	}

	public void OnDeepLinked()
	{
	}

	public void GotoState(State next)
	{
	}

	private bool CheckPurchaseValid(uint storeId)
	{
		return false;
	}

	public void Purchase(IAPBundleStoreData data)
	{
	}

	private void OnPurchased(bool success, string productIdentifier, int rebateId)
	{
	}

	public void RequestIAPBundle(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestRevokeIAPStatus(uint storeId)
	{
	}

	private void OnRevokeIAPStatusResponse(HttpErrorCode errorCode, object response)
	{
	}

	private void OnIAPBundleResponse(HttpErrorCode errorCode, object response)
	{
	}

	private void ProcessIAPInfoList(List<IAPInfoItem> iapInfoList)
	{
	}

	private void RefreshIAPBundleStateProductState(out bool shouldNotify)
	{
		shouldNotify = default(bool);
	}

	private void UpdateProductsInDemand()
	{
	}

	private void RequestPurchase()
	{
	}

	private bool RequestPurchaseForRecommitted(int[] recommittedProductIDs, int pendingProductID)
	{
		return false;
	}

	public void RequestDiamondPurchase(IAPBundleStoreData data)
	{
	}

	public void OnReceivedPurchasedBundle(CSIAPPurchaseRes response)
	{
	}

	public string GetNotifyText()
	{
		return null;
	}

	public bool GetIsFirstTime()
	{
		return false;
	}

	public void SetIsFirstTime(bool isFirstTime)
	{
	}

	public void ProcessIAPBundleStoreDesc(CSGetIAPStoreDescRes res)
	{
	}

	public List<int> GetCurrentIAPBundleStoreIDList()
	{
		return null;
	}

	private bool CheckHasStoreData(uint storeID)
	{
		return false;
	}

	public bool IsExistValidStoreData()
	{
		return false;
	}

	private bool CheckAndCachePendingIAPBundle()
	{
		return false;
	}

	public bool ProcessCachedPendingPurchaseResults()
	{
		return false;
	}

	public void ExecutePendingPurchaseClearAndRevoke(string pendingProductId)
	{
	}

	private bool CheckHasNotPurchasableIAPBundle()
	{
		return false;
	}

	private bool CheckStoreIdValid(uint storeID)
	{
		return false;
	}

	private bool CheckNoValidStoreId()
	{
		return false;
	}

	public IAPInfoItem GetIAPInfoItemByStoreId(uint storeId)
	{
		return null;
	}

	public BaseItemInfo GetPriorityItemInfoInBundle(List<BundleShowData> bundleShowDataList)
	{
		return null;
	}

	private BaseItemInfo GetPreviewItemPriority(List<BundleShowData> bundleShowDataList)
	{
		return null;
	}

	private BaseItemInfo GetGemsPriority(List<BundleShowData> bundleShowDataList)
	{
		return null;
	}

	private BaseItemInfo GetNormalItemPriority(List<BundleShowData> bundleShowDataList)
	{
		return null;
	}

	public bool CanAutoDownload()
	{
		return false;
	}

	public void GetItemNeedDownLoad(List<uint> itemIds, uint storeId)
	{
	}

	private void _003CRequestPurchase_003Eb__70_0(HttpErrorCode errorCode, object response)
	{
	}

	private void _003CRequestDiamondPurchase_003Eb__72_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
