using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentNewBieView : UIBaseView
{
	public UILabel Title;

	public GameObject CountDown;

	public UIButton BtnPurchase;

	public GameObject PurchaseDisabledBG;

	public GameObject PurchaseEnabledBG;

	public UILabel PriceLabel;

	public UILabel EarnLabel;

	public UILabel PricingLabel;

	public UILabel SubTitle;

	public UILabel EarnNum;

	public UINetworkTexture BG;

	public UILabel PriceLabelShadow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
