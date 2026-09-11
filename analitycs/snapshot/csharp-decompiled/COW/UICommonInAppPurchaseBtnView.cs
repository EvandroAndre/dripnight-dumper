using GCommon;
using UnityEngine;

namespace COW;

public class UICommonInAppPurchaseBtnView : UIBaseView
{
	public UISprite PurchasableBG;

	public UISprite UnpurchasableBG;

	public GameObject WithDiscountGroup;

	public UILabel DiscountPriceLabel;

	public UILabel OriginalPriceLabel;

	public GameObject PendingGroup;

	public GameObject WithoutDiscountGroup;

	public UILabel WithoutDiscountPriceLabel;

	public GameObject DiscountVFXGroup;

	public UILabel PercentOffLabel;

	public UIButton ClickBtn;

	public UISprite OriginalPriceSlashIcon;

	public GameObject DisabledGroup;

	public UILabel DisabledLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
