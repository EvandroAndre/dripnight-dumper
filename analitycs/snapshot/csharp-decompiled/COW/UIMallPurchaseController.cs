using System;
using GCommon;
using proto;

namespace COW;

public class UIMallPurchaseController : UIMallPurchaseBaseController
{
	private bool m_IsOffer;

	private bool m_IsQuickPurchase;

	private StoreDesc m_StoreDesc;

	private Action<string> m_SuccessCallback;

	public int m_TargetPlanIndex;

	public uint m_TargetSlot;

	private bool m_IngnoreShowRewardPop;

	private EInventory.CurrencyType m_CurrencyType;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	public void RefreshData(StoreDesc storeDesc, bool showVoucherContainer = false, bool isOffer = false, bool enableInput = false, int maxCount = 0, int defaultValue = 1, Action<string> successCallback = null, bool inputExceedNotify = false, bool isQuickPurchase = false, bool forceShowMaxBtn = false, bool showSpecialConfirmCon = false, int targetPlanIndex = -1, uint targetSlot = 0u, bool canOverflow = false, bool ingnoreRewardWnd = false)
	{
	}

	public void SetUIData(BaseItemInfo baseItemInfo, uint coinsPrice, uint gemsprice, EventDelegate onPurchase = null, bool showVoucherContainer = false, int defaultCount = 1, bool showSpecialConfirmCon = false)
	{
	}

	public void SetUIData(string itemName, ResourceID image, uint quality, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint price = 0u, EventDelegate onPurchase = null, bool showVoucherContainer = false, bool showSpecialConfirmCon = false)
	{
	}

	private void SetPriceData(EventDelegate onPurchase, int defaultCount = 1)
	{
	}

	public void RefreshGoToDiscountView(bool isShowMysteryMall, bool isShowLuckyWheel)
	{
	}

	public void OnGoToDiscountBtnClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
