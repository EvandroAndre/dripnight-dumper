using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAskPurchaseItemView : UIBaseView
{
	public UILabel Name;

	public UILabel Index;

	public UISprite Icon;

	public GameObject Finish;

	public UIButton PurchaseBtn;

	public GameObject PriceGroup;

	public UILabel Price;

	public UISprite CoinIcon;

	public UILabel buyUserIndex;

	public GameObject ReplacerTip;

	public UISprite bg;

	public UISprite SpriteLeaderboardTitle;

	public GameObject GameObjectLeaderboardTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
