using GCommon;
using UnityEngine;

namespace COW;

public class UIShoppingMallItemNormalView : UIBaseView
{
	public GameObject Loading;

	public GameObject CDNBGGameObject;

	public UINetworkTexture CDNBG;

	public GameObject Tag;

	public GameObject WellSell;

	public UISprite WellSellSprite;

	public GameObject Limited;

	public UISprite LimitedSprite;

	public GameObject Discount;

	public UISprite DiscountSprite;

	public UILabel DiscountLabel;

	public GameObject Channel;

	public UISprite ChannelIcon;

	public GameObject RareDegree;

	public UISprite RareIcon;

	public GameObject OpenTime;

	public UILabel OpenTimeLabel;

	public UIButton ClickBtn;

	public GameObject New;

	public Animation ShoppingMallItemAnimator;

	public GameObject Remind;

	public GameObject VeteranDiscountGameObject;

	public UILabel VeteranDiscountLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
