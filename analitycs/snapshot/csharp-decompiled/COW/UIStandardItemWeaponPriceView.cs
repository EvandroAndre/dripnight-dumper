using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardItemWeaponPriceView : UIBaseView
{
	public UIWidget GoldContainer;

	public UILabel GoldPriceLabel;

	public UILabel GoldOriginalPriceLabel;

	public UIWidget DiamondContainer;

	public UILabel DiamondPriceLabel;

	public UILabel DiamondOriginalPriceLabel;

	public Transform ExchangeContainer;

	public UILabel ExchangePriceLabel;

	public UISprite ExchangeIcon;

	public GameObject GemsAndGoldContainer;

	public UILabel DualCurrencyGoldPrice;

	public UILabel DualCurrencyGemsPrice;

	public UIGrid Content;

	public UILabel DiscountLabel;

	public GameObject DiscountVFX;

	public Animation WeaponPriceAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
