using GCommon;
using UnityEngine;

namespace COW;

public class UICommonDiamondPurchaseBtnView : UIBaseView
{
	public UISprite Background;

	public GameObject DiscountVFXGroup;

	public GameObject CustomizedIconShineVFX;

	public UISprite CustomizedIcon;

	public GameObject WithDiscountGroup;

	public UILabel WithDiscountPriceLabel;

	public UILabel WithDiscountOriginalPriceLabel;

	public GameObject WithoutDiscountGroup;

	public UILabel WithoutDiscountOriginalPriceLabel;

	public UIButton ClickBtn;

	public UILabel PercentOffLabel;

	public GameObject EnableGroup;

	public GameObject DisableGroup;

	public UISprite DisableBackground;

	public UILabel DisableMsgLabel;

	public UISprite SpecialIcon;

	public UISprite DiscountBg;

	public GameObject Plane_loop;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
