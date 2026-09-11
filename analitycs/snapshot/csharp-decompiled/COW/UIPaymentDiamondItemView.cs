using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentDiamondItemView : UIBaseView
{
	public GameObject CurrentSprite;

	public Transform EffectRoot;

	public UISprite Background;

	public UISprite BackLine1;

	public UISprite BackLine2;

	public UISprite Triangle;

	public UISprite Point1;

	public UISprite Point2;

	public UISprite Point3;

	public UISprite Point4;

	public UIButton BuyButton;

	public GameObject CanBuy;

	public GameObject CantBuy;

	public UILabel OldPrice;

	public UILabel NewPrice;

	public UILabel DiscountLabel;

	public UILabel OffLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
