using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2BoxCDNItemView : UIBaseView
{
	public UIButton UIMallV2BoxCDNItem;

	public UIWidget Widget;

	public TweenAlpha TweenAlpha;

	public GameObject Default;

	public UINetworkTexture NetworkTexture;

	public GameObject HighLightBG;

	public GameObject DiscountItemIcon;

	public GameObject OtherChannelContainer;

	public UILabel OtherChannelTitle;

	public UISprite OtherChannelIcon;

	public UILabel DiscountLabel;

	public GameObject DiscountVFX;

	public UITable PriceContainer;

	public UISprite DiamondIcon;

	public UILabel DiamondPrice;

	public UILabel Slash;

	public UISprite GoldIcon;

	public UILabel GoldPrice;

	public UILabel OriginalPrice;

	public UISprite PriceBG;

	public UISprite OriginalPriceLine;

	public GameObject UniquedTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
