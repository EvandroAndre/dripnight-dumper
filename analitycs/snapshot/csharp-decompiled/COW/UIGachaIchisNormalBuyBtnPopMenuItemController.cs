using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisNormalBuyBtnPopMenuItemController : UIBaseController
{
	private UIGachaIchisNormalBuyBtnPopMenuItemView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelGacha m_ModelGacha;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private uint m_GachaId;

	private int m_Level;

	private Action<int> m_OnClick;

	private bool m_ClickRegistered;

	private static readonly Color SELECTED_PRICE_LABEL_COLOR;

	private static readonly Color UNSELECTED_PRICE_LABEL_COLOR;

	private static readonly Color DISCOUNT_ORIGINAL_LABEL_COLOR;

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

	public void BindLevel(uint chestId, uint chestSubId, int level, uint gachaId, UIGachaBuyBtnController.BuyBtnState state, Action<int> onClick)
	{
	}

	public void SetHighlight(bool isHighlight)
	{
	}

	private void ApplyLabelColors(UIGachaBuyBtnBaseView v, bool isHighlight)
	{
	}

	private static void SetLabelColor(UILabel label, Color color)
	{
	}

	public UISprite GetTenBuyBg()
	{
		return null;
	}

	public int GetLevel()
	{
		return 0;
	}

	private UIGachaBuyBtnBaseView GetInnerView()
	{
		return null;
	}

	private void RegisterClick(UIGachaBuyBtnBaseView v)
	{
	}

	private void UnregisterClick()
	{
	}

	private void OnTenBuyBtnClick()
	{
	}

	private void ResetVisuals(UIGachaBuyBtnBaseView v)
	{
	}

	private void RefreshTenBuyLabel(UIGachaBuyBtnBaseView v, uint drawCount)
	{
	}

	private void ShowCurrencyUI(UIGachaBuyBtnBaseView v, ChestMultiPrice entry)
	{
	}

	private void ShowFreeUI(UIGachaBuyBtnBaseView v)
	{
	}

	private void ShowCouponUI(UIGachaBuyBtnBaseView v, ChestMultiPrice entry)
	{
	}

	private void ShowMixedUI(UIGachaBuyBtnBaseView v, ChestMultiPrice entry)
	{
	}

	private void ShowDiscountCurrencyUI(UIGachaBuyBtnBaseView v, ChestMultiPrice entry, uint discountPrice)
	{
	}

	private void ShowDiscountMixedUI(UIGachaBuyBtnBaseView v, ChestMultiPrice entry, uint discountPrice)
	{
	}

	private string ResolveCurrencySpriteName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
