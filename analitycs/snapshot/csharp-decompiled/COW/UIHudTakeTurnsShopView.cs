using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTakeTurnsShopView : UIBaseView
{
	public TweenPosition ShowAnim;

	public UIButton BGBtn;

	public UIScrollView ScrollView;

	public UITable ShopTable;

	public UIButton CloseBtn;

	public UISprite CloseIcon;

	public UISprite SpriteCloseBtnLight;

	public GameObject LeftTimeShow;

	public UILabel LeftTime;

	public GameObject TotalCount;

	public UISprite CoinIcon;

	public UILabel CoinValue;

	public UIButton CoinBtn;

	public UISprite SpriteBtnCoin;

	public GameObject CoinTipAnchor;

	public UIButton BuySameBtn;

	public UIButton BuyBtn;

	public UISprite SpriteBuyBtn;

	public UILabel BuyBtnLabel;

	public UILabel BuyBtnLabelDisable;

	public GameObject Capacity;

	public UILabel CapacityValue;

	public UIButton CapacityBtn;

	public GameObject CapacityTipAnchor;

	public UILabel TipLabel;

	public UILabel title;

	public UIButton HelpBtn;

	public UIButton AskBtn;

	public GameObject RoundInfo;

	public UIScrollView RoundScrollView;

	public UIGrid RoundGrid;

	public UILabel ExtraTips;

	public UILabel CSShopTips;

	public GameObject CSShopWarning;

	public GameObject lonewolfbg;

	public GameObject lwlonewolfbg;

	public UISprite TitleBg;

	public Transform AdditionalContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
