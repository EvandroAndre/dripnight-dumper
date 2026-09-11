using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2WeaponCDNItemView : UIBaseView
{
	public UIButton UIMallV2WeaponCDNItem;

	public GameObject HighLightBG;

	public SetRelativeDepth WeaponVFX;

	public GameObject Default;

	public UINetworkTexture NetworkTexture;

	public GameObject DiscountItemIcon;

	public GameObject OtherChannelContainer;

	public UILabel OtherChannelTitle;

	public UISprite OtherChannelIcon;

	public UILabel DiscountLabel;

	public GameObject DiscountVFX;

	public UITable PriceContainer;

	public UILabel DiamondPrice;

	public UILabel Slash;

	public UISprite GoldIcon;

	public UILabel GoldPrice;

	public UILabel OriginalPrice;

	public UISprite PriceBG;

	public UITexture LocalImg;

	public GameObject OwnedTitle;

	public UISprite DiamondIcon;

	public UISprite OriginalPriceLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
