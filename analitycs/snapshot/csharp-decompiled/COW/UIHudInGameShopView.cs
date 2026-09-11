using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopView : UIBaseView
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

	public UIButton BtnQuickBuy;

	public UILabel QuickBuyPrice;

	public UILabel LableQuickBuy;

	public UICenterTargetHelper TitleRoot;

	public UISprite GameMissionIcon;

	public GameObject MarkIcon;

	public UIEventListener titleHelpBtn;

	public UIEventListener WarningIcon;

	public UISprite bg;

	public GameObject PersonalShopBg;

	public GameObject TotalCountCS;

	public UISprite CoinIconCS;

	public UILabel CoinValueCS;

	public UIButton CoinBtnCS;

	public UIWidget CSBtnWidget;

	public GameObject CoinTipAnchorCS;

	public GameObject WithdrawBtnGroup;

	public UIButton WithdrawEnabledBtn;

	public UIButton WithdrawDisabledBtn;

	public UIWidget WithdrawGuideWidget;

	public UIWidget MistakeClickMask;

	public Transform AdditionalContainer;

	public UISprite SpriteQuickBuyBtn;

	public UISprite TitleBg;

	public UISprite AskSprite;

	public UISprite SpriteBuySameBtn;

	public UIWidget GuideWidget;

	public UITable DetailContainer;

	public UIButton DetailBtn;

	public GameObject LoadoutReinforceTip;

	public UILabel ReinforceLabel;

	public UIWidget CSAIECAGuideTrans;

	public GameObject TeamInfoContainer;

	public UILabel AskLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
