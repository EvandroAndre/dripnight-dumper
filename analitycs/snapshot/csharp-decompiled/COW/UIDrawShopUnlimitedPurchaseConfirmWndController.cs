using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedPurchaseConfirmWndController : UIPopupWindowController
{
	private UIDrawShopUnlimitedPurchaseConfirmWndView m_View;

	private UIModelDrawShop m_ModelDrawShop;

	private List<UIStandardItemMiniController> m_ItemCtrlList;

	private UIStandardItemMAXBController m_SingleItemCtrl;

	private uint m_ChestId;

	private UIModelDrawShop.EDrawShopDrawType m_DrawType;

	private UIModelDrawShop.EDrawShopBuyBtnState m_BuyBtnState;

	private bool m_IsSingleDraw;

	private Action<bool> m_PurchaseCallback;

	private uint m_MixedCouponCost;

	private uint m_MixedCurrencyCost;

	private uint m_SelectedItemIndex;

	private bool m_IsRefreshingToggleValue;

	private const string CLICK_LOG_NO_SHOW_CONFIRM_CHECK = "NoShowConfirmCheck";

	private const string CLICK_LOG_NO_SHOW_CONFIRM_UNCHECK = "NoShowConfirmUncheck";

	private const string CLICK_LOG_NO_SHOW_DRAW_ANIMATION_CHECK = "NoShowDrawAnimationCheck";

	private const string CLICK_LOG_NO_SHOW_DRAW_ANIMATION_UNCHECK = "NoShowDrawAnimationUncheck";

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

	public void RefreshUIData(uint chestId, UIModelDrawShop.EDrawShopDrawType drawType, uint selectedItemIndex = 0u, UIModelDrawShop.EDrawShopBuyBtnState buyBtnState = UIModelDrawShop.EDrawShopBuyBtnState.Normal, Action<bool> callback = null, uint mixedCouponCost = 0u, uint mixedCurrencyCost = 0u)
	{
	}

	private void RefreshItemList()
	{
	}

	private List<BaseItemInfo> GetDrawItemInfoList()
	{
		return null;
	}

	private BaseItemInfo GetItemInfoByGoodsId(UIModelDrawShop.DrawShopWheelContentData wheelData, uint goodsId)
	{
		return null;
	}

	private BaseItemInfo GetItemInfoByGoodsId(UIModelDrawShop.DrawShopTowerContentData towerData, uint goodsId)
	{
		return null;
	}

	private void ClearItemControllers()
	{
	}

	private bool IsCouponOnlyState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	private bool IsMixedState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	private int GetExchangeIndex(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return 0;
	}

	private void ShowCouponOnlyPayment(uint chestId, UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	private void ShowMixedPayment(uint chestId, UIModelDrawShop.EDrawShopBuyBtnState state, UIModelDrawShop.EDrawShopCoinType coinType)
	{
	}

	private void ShowCurrencyPayment(uint chestId, UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopCoinType coinType)
	{
	}

	private uint GetTicketCost(uint chestId, UIModelDrawShop.EDrawShopDrawType drawType, int exchangeIndex = 1)
	{
		return 0u;
	}

	private void SetTicketIcon(uint chestId, int exchangeIndex = 1)
	{
	}

	private void SetMixedTicketIcon(uint chestId, int exchangeIndex)
	{
	}

	private void SetMixedCurrencyIcon(UIModelDrawShop.EDrawShopCoinType coinType)
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private bool OnPurchaseBtnClickByEnter()
	{
		return false;
	}

	private void OnNoShowBtnClick()
	{
	}

	private void RefreshNoShowAnimationToggle()
	{
	}

	private void SetNoShowAnimationToggleVisible(bool visible)
	{
	}

	private GameObject GetNoShowAnimationToggleRoot()
	{
		return null;
	}

	private void OnNoShowAnimationToggleClick()
	{
	}

	private void OnCloseClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnPurchaseBtnClick_003Eb__36_0(bool success)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
