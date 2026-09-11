using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaDoubleWheelBuyBtnView : UIBaseView
{
	public UIGachaBuyBtnBaseView UIGachaDoubleWheelBuyBtn;

	public UIButton GuaranteedBuyBtn;

	public UILabel PriceLabel;

	public UISprite CurrencyIcon;

	public GameObject NormalBuyBtn;

	public GameObject LimitContainer;

	public UILabel OneLimitPercentLabel;

	public GameObject DiscountContainer;

	public GameObject DiscountTag;

	public UILabel OnePercentLabel;

	public UISprite OneDiscountIcon;

	public UILabel OneOriginalPriceLabel;

	public UILabel OneDiscountPriceLabel;

	public UILabel GuaranteedDiscountFreeLabel;

	public GameObject FreeTip;

	public GameObject GuaranteedFreeTip;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
