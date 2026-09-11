using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaELS_TT53PurchaseConfirmWndView : UIBaseView
{
	public UILabel ConfirmLabel;

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

	public UIButton CloseBUtton;

	public UINetworkTextureExt BG;

	public UINetworkTextureExt Icon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
