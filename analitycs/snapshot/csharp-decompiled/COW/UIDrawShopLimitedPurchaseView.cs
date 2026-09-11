using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopLimitedPurchaseView : UIBaseView
{
	public UILabel ItemNameLabel;

	public UILabel limitedPurchaseLabel;

	public Transform ItemContainer;

	public UIButton GoldPurchaseBtn;

	public UILabel GoldPrice;

	public UILabel GoldBefore;

	public GameObject GoldVoucherEffect;

	public UIButton GemsPurchaseBtn;

	public UILabel GemsPrice;

	public UILabel GemsBefore;

	public GameObject DiamondVoucherEffect;

	public GameObject GoldWithDiscount;

	public GameObject GoldWithoutDiscount;

	public UILabel GoldDiscountPrice;

	public GameObject GemWithoutDiscount;

	public UILabel GemsDiscountPrice;

	public GameObject GemWithDiscount;

	public UILabel GemTipsLabel;

	public UIToggle NoShowToggle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
