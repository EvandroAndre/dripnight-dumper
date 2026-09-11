using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2CoinsView : UIBaseView
{
	public UIButton btnCoin;

	public UILabel coinCount;

	public UILabel diamondCount;

	public UIButton btnDiamond;

	public Transform PaymentRedDot;

	public UIButton BtnRebateCard;

	public GameObject RebateCardSprites;

	public GameObject Effect_Card_Glow;

	public Transform RebateRedDot;

	public UISprite WeekCardIcon;

	public GameObject flowLight_W;

	public UISprite MonthCardIcon;

	public GameObject flowLight_M;

	public UISprite NoCardIcon;

	public GameObject flowLight_Null;

	public GameObject Graphics128_Add_1;

	public UILabel addCoinCount;

	public GameObject AddGemSprite;

	public GameObject EvoPass;

	public UISprite MiniWeekCardIcon;

	public UIButton PrimeBtn;

	public UITable RightIconTable;

	public UISprite PrimeIcon;

	public PrimeSmallBadgeVfxUtil PrimeSmallBadgeVfxUtil;

	public UIWidget PrimeGuildWidget;

	public Transform PrimeRedTips;

	public GameObject PrimeLevelTips;

	public TweenPosition PrimeLevelTween;

	public UILabel PrimeTipsLabel;

	public GameObject PrimeActivityTips;

	public UILabel PrimeActivityTipsLabel;

	public GameObject UpArrow;

	public GameObject Bg2D;

	public GameObject Bg3D;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
