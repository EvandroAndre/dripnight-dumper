using System;
using GCommon;

namespace COW;

public class UIDrawShopLimitedPurchaseController : UIPopupWindowController
{
	private UIDrawShopLimitedPurchaseView m_View;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelUser m_ModelUser;

	private UIStandardItemMAXBController m_StandItem;

	private Action m_OnConfirmCallback;

	private uint m_DrawShopId;

	private uint m_CurrencyType;

	private uint m_Price;

	private uint m_OriginalPrice;

	private bool m_HasDiscount;

	private BaseItemInfo m_ItemInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void ShowPurchaseConfirm(uint drawShopId, uint currencyType, uint price, uint originalPrice, bool hasDiscount, Action onConfirm, BaseItemInfo itemInfo = null)
	{
	}

	private void RefreshUI()
	{
	}

	private void OnNoShowToggleChange()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void ExecutePurchase()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
