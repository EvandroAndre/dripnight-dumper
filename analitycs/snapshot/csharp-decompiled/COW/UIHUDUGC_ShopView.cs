using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ShopView : UIBaseView
{
	public TweenPosition ShowAnim;

	public UIButton BGBtn;

	public UIScrollView ScrollView;

	public UITable ShopTable;

	public UIButton CloseBtn;

	public UISprite SpriteCloseBtnLight;

	public GameObject LeftTimeShow;

	public UILabel LeftTime;

	public GameObject TotalCount;

	public UISprite CoinIcon;

	public UILabel CoinValue;

	public UIButton CoinBtn;

	public UISprite SpriteBtnCoin;

	public GameObject CoinTipAnchor;

	public UIButton BuyBtn;

	public UISprite SpriteBuyBtn;

	public UILabel BuyBtnLabel;

	public GameObject Capacity;

	public UILabel CapacityValue;

	public UIButton CapacityBtn;

	public GameObject CapacityTipAnchor;

	public UILabel TipLabel;

	public UILabel Title;

	public UIButton HelpBtn;

	public UIGrid MoneyList;

	public UIButton AskBtn;

	public GameObject EnableGO;

	public GameObject DisableGO;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
