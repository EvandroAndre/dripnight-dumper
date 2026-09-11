using GCommon;
using UnityEngine;

namespace COW;

public class UILuckyWheelItemView : UIBaseView
{
	public UISprite UsedBg;

	public GameObject DrawedEffect;

	public GameObject SelectedBg;

	public UILabel DiscountLabel;

	public GameObject PriceLabelContainer;

	public UISprite CoinIconSprite;

	public UILabel PriceLabel;

	public GameObject Level1;

	public GameObject Level1BigPrizeVfx;

	public GameObject Level2;

	public GameObject Level3;

	public UIButton ItemBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
