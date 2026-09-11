using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIRelayMartPurchaseController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIRelayMartPurchaseView m_View;

	private List<RelayMartShopDesc> m_ShopDescList;

	private UIModelRelayMart m_ModelRelayMart;

	private UIModelFriends m_ModelFriends;

	private bool m_IsSendFrinedAdd;

	private string m_DiscountCode;

	private bool m_HasDiscountCode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void RefreshData(List<RelayMartShopDesc> shopDescList, string discountCode)
	{
	}

	private void InitView()
	{
	}

	private void RefreshItemList()
	{
	}

	private void CheckDiscountCode()
	{
	}

	private void RefreshDiscountCodeView(bool hasDiscountCode)
	{
	}

	private void OnConfirmPurchaseClick()
	{
	}

	private void OnSendFrinedInviteCheckBoxClick()
	{
	}

	private void RefreshDiamondPrice()
	{
	}

	private void RefreshBGCDN()
	{
	}

	private void PreloadRelayMartDiscountCodeBGCDN()
	{
	}

	private void OnGetMoreCouponsClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
