using System;
using GCommon;
using proto;

namespace COW;

public class UIModelNewPlayerIAPBundle : UIBaseModel
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

	private class NewPlayerBundlesDelegate : PayUtility.PaymentDelegate
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string purchasableProductIdentifier;

			internal bool _003COnScannedAndCleared_003Eb__0(ScanAndClearResult r)
			{
				return false;
			}
		}

		private static NewPlayerBundlesDelegate _I;

		public static NewPlayerBundlesDelegate I => null;

		public override string Name => null;

		public override void OnScannedAndCleared(ScanAndClearResult[] results)
		{
		}

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnScannedAndCleared(ScanAndClearResult[] P0)
		{
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<IAPInfoItem> _003C_003E9__35_0;

		internal bool _003COnIAPBundleResponse_003Eb__35_0(IAPInfoItem temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIModelNewPlayerIAPBundle _003C_003E4__this;

		public string productIdentifier;

		public int rebateID;

		internal void _003CPurchase_003Eb__0(bool purchasing, string product, long rebateId)
		{
		}
	}

	public const uint PropID_Available = 2u;

	public const uint PropID_Unavailable = 4u;

	public const uint PropID_IAPResult = 8u;

	public const uint PropID_GotBundle = 16u;

	public const uint PropID_Pending = 32u;

	public const uint PropID_ProductUpdate = 64u;

	public const uint PropID_DiamondExchanging = 128u;

	public const uint PropID_DiamondPurchaseFail = 256u;

	public const uint PropID_DiamondGotBundle = 512u;

	private IAPBundleStoreData _PendingIAPBundle;

	private IAPInfoItem m_NewPlayerIAPInfo;

	private uint m_NewBieBundleStoreId;

	private State _003CCurrentNewPlayerBundlePurchaseState_003Ek__BackingField;

	public State CurrentNewPlayerBundlePurchaseState
	{
		get
		{
			return _003CCurrentNewPlayerBundlePurchaseState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentNewPlayerBundlePurchaseState_003Ek__BackingField = value;
		}
	}

	public uint NewBieBundleStoreId => 0u;

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

	public void InitAfterLogin()
	{
	}

	public ulong GetEndTime()
	{
		return 0uL;
	}

	public bool IsNewPlayerBundleVisible()
	{
		return false;
	}

	public bool IsNewPlayerBundlePurchasable()
	{
		return false;
	}

	public int CurNewPlayerBundleStoreID()
	{
		return 0;
	}

	public bool CanPurchaseNewPlayerBundle()
	{
		return false;
	}

	public IAPBundleStoreData CurNewPlayerBundleStore()
	{
		return null;
	}

	public void ChangeNewPlayerBundlePurchaseState(State next)
	{
	}

	public void ProcessNewbieBundleDesc(NewbieBundleDesc desc)
	{
	}

	public void Purchase(IAPBundleStoreData data = null)
	{
	}

	public void OnPurchased(bool success, string productIdentifier, int rebateId)
	{
	}

	public void RequestPurchase()
	{
	}

	public void OnIAPBundleResponse(HttpErrorCode errorCode, CSGetAccountIAPInfoRes response)
	{
	}

	private void OnPurchaseResponse(HttpErrorCode errorCode, object response)
	{
	}

	public void RequestDiamondPurchase(IAPBundleStoreData data)
	{
	}

	private void _003CRequestDiamondPurchase_003Eb__37_0(HttpErrorCode errorCode, object res)
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
