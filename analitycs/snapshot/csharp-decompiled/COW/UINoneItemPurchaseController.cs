using System;
using GCommon;
using proto;

namespace COW;

public class UINoneItemPurchaseController : UIPopupWindowController
{
	private UINoneItemPurchaseView m_View;

	private Action m_SuccessCallback;

	private UIModelUser m_ModelUser;

	private UIModelMall m_ModelMall;

	private EInventory.CurrencyType m_CurrencyType;

	private uint m_Price;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	public void SetData(EInventory.CurrencyType costType, uint price, string desLabel, Action successCallback, string titleKey = "")
	{
	}

	private void PurchaseItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
