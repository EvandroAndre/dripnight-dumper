using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallMutiGoodsPurchaseController : UIMallPurchaseBaseController
{
	private bool m_IsOffer;

	private bool m_ShowVoucherContainer;

	private StoreDesc m_StoreDesc;

	private Action<string> m_SuccessCallback;

	private List<StoreDesc> m_StoreList;

	private UIMallMultiGoodsContainerController m_ItemContainer;

	private EInventory.CurrencyType m_CurrencyType;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	private void PurchaseItem()
	{
	}

	private void Purchase()
	{
	}

	public void RefreshData(List<StoreDesc> toreDescs, bool showVoucherContainer = false, bool isOffer = false)
	{
	}

	public void RefreshData(StoreDesc storeDesc, bool showVoucherContainer = false, bool isOffer = false, bool enableInput = false, int maxCount = 0, int defaultValue = 1, Action<string> successCallback = null, bool inputExceedNotify = false, bool showSpecialConfirmCon = false)
	{
	}

	public void SetUIData(BaseItemInfo baseItemInfo, uint coinsPrice, uint gemsprice, EventDelegate onPurchase = null, bool showVoucherContainer = false, int defaultCount = 1, bool showSpecialConfirmCon = false)
	{
	}

	private void SetPriceData(EventDelegate onPurchase, int defaultCount = 1)
	{
	}

	private void RefreshGoToDiscountView()
	{
	}

	public void OnGoToDiscountBtnClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
