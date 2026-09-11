using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelUGCCommerceIAP : UIBaseModel
{
	internal enum EUGCEnvironment
	{
		Release,
		Debug
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopProductInfo> _003C_003E9__37_1;

		internal int _003CSendRefreshStoreDataRequest_003Eb__37_1(WorkshopProductInfo a, WorkshopProductInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIModelUGCCommerceIAP _003C_003E4__this;

		public Action successCallback;

		public string itemCode;

		internal void _003CSendExchangeUGCTokensRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public WorkshopProductInfo info;

		public UIModelUGCCommerceIAP _003C_003E4__this;

		public uint count;

		internal void _003CSendPurchaseRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_RefreshStoreData = 2u;

	public const uint PropID_RefreshTokenCount = 4u;

	private IUGCCommerceIAPService m_ReleaseService;

	private IUGCCommerceIAPService m_DebugService;

	private IUGCCommerceIAPService m_CurrentService;

	private List<UGCTokenData> m_TokenDataList;

	private bool m_InGameHudCommerceIAPState;

	private bool m_IsRefreshStoreDataRequesting;

	private int m_UGCToken;

	private bool _003CEnableCraftlandBlock_003Ek__BackingField;

	public int UGCToken
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsDebugging => false;

	public bool EnableCraftlandBlock
	{
		get
		{
			return _003CEnableCraftlandBlock_003Ek__BackingField;
		}
		internal set
		{
			_003CEnableCraftlandBlock_003Ek__BackingField = value;
		}
	}

	public bool InGameHudCommerceIAPState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal IUGCCommerceIAPService CurrentService => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void Clearup()
	{
	}

	public List<WorkshopProductInfo> GetStoreData(bool needRefresh = false)
	{
		return null;
	}

	public List<UGCTokenData> GetTokenDataList()
	{
		return null;
	}

	public void RequestPurchase(WorkshopProductInfo data, uint count, uint price)
	{
	}

	public void RequestExchange(uint gems, uint itemTokens, WorkshopProductInfo data, uint count, uint price)
	{
	}

	public int GetUserGems()
	{
		return 0;
	}

	public int GetUserToken()
	{
		return 0;
	}

	public int GetItemTokenCount()
	{
		return 0;
	}

	public void DebugInit(int gemsCount, int ugcCurrencyCount)
	{
	}

	public void NotifyStoreDataChanged()
	{
	}

	public void SendRefreshStoreDataRequest()
	{
	}

	public void SendRefreshTokenCountRequest()
	{
	}

	public void SendExchangeUGCTokensRequest(uint gems, uint itemTokens, string itemCode, Action successCallback)
	{
	}

	public void SendPurchaseRequest(WorkshopProductInfo info, uint count, uint price)
	{
	}

	private void UpdateStoreItemPurchaseTimes(string productId, uint accountPurchaseTimes)
	{
	}

	public void SendPurchaseEventToGS(uint status, ulong transID, string itemCode, uint count = 0u)
	{
	}

	public void OpenPremiumStore()
	{
	}

	public void OpenPremiumPurchase(string itemCode, int count)
	{
	}

	public void ShowPurchaseRewardWindow(WorkshopProductInfo data, uint count = 1u)
	{
	}

	private void _003CSendRefreshStoreDataRequest_003Eb__37_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CSendRefreshTokenCountRequest_003Eb__38_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
