using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIExchangeMallPopWndController : UIPopupWindowController, IEasyList
{
	private UIExchangeMallPopWndView m_View;

	private UIModelMall m_ModelMall;

	private uint m_CurrencyId;

	private uint m_CommodityId;

	private const uint CURRENCY_BTN_GREY = 2139062271u;

	private const uint CURRENCY_LABEL_GREY = 2139062271u;

	private List<ExchangeStoreItemDesc> m_CurrentDataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint currencyId, string titleKey)
	{
	}

	private void RefreshViewData(bool needResort = true)
	{
	}

	private void OnRewardWndClose(object[] data)
	{
	}

	private void RefreshExchangeNum()
	{
	}

	private void OnExchangeItemSelect(object[] data)
	{
	}

	private void RefreshItemView(uint commodityID)
	{
	}

	private void SetMoneyBtnData(ExchangeStoreItemDesc exchangeItemDesc)
	{
	}

	private void MoneyBtnColorGrey()
	{
	}

	private void MoneyBtnColorReset()
	{
	}

	private void OnBtnExchangeClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private bool _003COnRewardWndClose_003Eb__12_0(ExchangeStoreItemDesc x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
