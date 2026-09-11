using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedPurchaseConfirmWndView : UIBaseView
{
	public UILabel ConfirmLabel;

	public UITable ItemTable;

	public UIButton PurchaseBtn;

	public GameObject Diamond;

	public GameObject Coin;

	public UILabel DiamondLabel;

	public UILabel CoinLabel;

	public GameObject Ticket;

	public UILabel TicketLabel;

	public UISprite TicketIcon;

	public GameObject Mixed;

	public UISprite ConsumeIcon;

	public UILabel ConsumeLabel;

	public UISprite CurrencyIcon;

	public UILabel CurrencyLabel;

	public UIToggle NoShowToggle;

	public Transform OneItemPos;

	public UIToggle NoShowAnimationToggle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
