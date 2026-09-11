using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartMainPageView : UIBaseView
{
	public UISprite Title;

	public UINetworkTexture TitileCDN;

	public UIButton BtnHelp;

	public UILabel TitleDesc;

	public GameObject TimeContainer;

	public UIWidget PreviewBoard;

	public GameObject RewardPoolContainer;

	public GameObject DiscountCodeContainer;

	public UIButton BtnDiamondRebate;

	public UIButton BtnDiamondPurchase;

	public UIScrollView RewardPoolScrollView;

	public UITable2 RewardPoolTable2;

	public UIButton BtnMoreCoupons;

	public UIInput InputContainer;

	public UIButton BtnPaste;

	public UILabel CodeDiscountValueLabel;

	public UISprite CodeDiscountUnactive;

	public UISprite CodeDiscountActive;

	public UIButton BtnClearDiscountCode;

	public UILabel BtnMoreCouponsLabel;

	public GameObject CodeDiscountCheckingContainer;

	public UILabel CodeDiscountErrorLabel;

	public GameObject BtnMoreCouponsActiveBG;

	public GameObject BtnMoreCouponsUnactiveBG;

	public UILabel CodeDiscountCheckingLabel;

	public GameObject ListBoxContainer;

	public GameObject DiamondPurchaseActiveView;

	public GameObject DiamondPurchaseUnActiveView;

	public GameObject ActualDiamond;

	public UILabel ActualDiamondPriceLabel;

	public GameObject OriginalDiamond;

	public UILabel OriginalDiamondPriceLabel;

	public UILabel DiamondPurchaseDiscountLabel;

	public UIWidget AddItemGuideWidget;

	public UIWidget UseDiscountCodeGuideWidget;

	public UIWidget RebateEntranceGuideWidget;

	public Transform Tips;

	public GameObject DiamondRebateBubble;

	public UILabel BubbleLabel;

	public GameObject SplitContainer;

	public GameObject ProgressBarContainer;

	public UISprite ProgressBar;

	public UISprite ProgressBarBG;

	public GameObject ShoppedDiscount;

	public GameObject ShoppedDiscount3;

	public GameObject ShoppedDiscount2;

	public GameObject ShoppedDiscount1;

	public UITable ShoppingCartTable;

	public VFXCreateHelper VFXCreateHelper;

	public EffectMovement EffectMovement;

	public VFXCreateHelper BrustEffect;

	public Animation RebateClaimAnim;

	public UILabel DiscountBarCartLabel1;

	public UILabel DiscountBarCartLabel2;

	public UILabel DiscountBarCartLabel3;

	public GameObject UIFX_CodeDiscountContainer;

	public GameObject CodeDiscountError;

	public GameObject CodeDiscountUnactive_Black_Tween;

	public GameObject UIFX_ActiveDiscount;

	public GameObject BtnMoreCouponsVFX;

	public GameObject UIFX_BtnDiamondPurchase;

	public UILabel NoticeLabel;

	public VFXCreateHelper NoticeLabelVFXHelper;

	public GameObject Content;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
