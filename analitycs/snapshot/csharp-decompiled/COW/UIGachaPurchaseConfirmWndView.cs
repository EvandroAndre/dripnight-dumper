using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaPurchaseConfirmWndView : UIBaseView
{
	public UISprite ItemIcon;

	public UILabel ConfirmLabel;

	public GameObject HackerStoreBox;

	public UIButton PurchaseBtn;

	public GameObject Diamond;

	public UILabel DiamondLabel;

	public GameObject Coin;

	public UILabel CoinLabel;

	public UIToggle NoShowToggle;

	public GameObject Mixed;

	public UISprite MixedConsumeIcon;

	public UILabel MixedConsumeLabel;

	public UISprite MixedCurrencyIcon;

	public UILabel MixedCurrencyLabel;

	public UINetworkTexture ItemIconCDN;

	public GameObject ItemIconDefault;

	public GameObject IchisItemIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
