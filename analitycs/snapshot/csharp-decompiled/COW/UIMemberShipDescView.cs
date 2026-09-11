using GCommon;
using UnityEngine;

namespace COW;

public class UIMemberShipDescView : UIBaseView
{
	public UIWidget BuyInfoContainer;

	public UIWidget RebateInfo;

	public UIButton GracePeriodButton;

	public GameObject AccountHold;

	public UIButton FixOnHoldButton;

	public UIButton BtnPurchase;

	public UISprite PurchaseDisabledBG;

	public UILabel PriceLabel_Disabled;

	public UISprite PurchaseEnabledBG;

	public UILabel PriceLabel_Enabled;

	public UISprite PurchaseDiscountBG;

	public UILabel PriceLabel_Discount;

	public UILabel PriceLabel_Original;

	public GameObject CountDownContainer;

	public UICountDownLabel CountDownLabel;

	public UIWidget SubscriptionWidget;

	public UISprite SubscriptionBonus;

	public UILabel SubscriptionBonusAmountLabel;

	public UILabel SubscriptionToggleText;

	public UIButton SubscriptionHintButton;

	public UISprite SubscriptionTips;

	public UIButton SubscriptionToggleBox;

	public UISprite SubscriptionToggleTick;

	public UIButton BtnPurchaseThirdParty;

	public GameObject DiscountTags;

	public UILabel DiscountPropotionLabel;

	public UILabel DiscountPurchaseLimitTimes;

	public Animation AdContainer;

	public UILabel AdLabel;

	public GameObject TitleContainer;

	public UISprite VipCardIcon;

	public UILabel VipCardLabel;

	public UIButton HelpBtn;

	public GameObject ArrowContainer;

	public GameObject UpArrow;

	public GameObject MidArrow;

	public GameObject DownArrow;

	public GameObject Descs;

	public UILabel InstantValueLabel;

	public UILabel DailyValueLabel;

	public GameObject MiniCardBG;

	public GameObject WeeklyCardBG;

	public GameObject MonthlyCardBG;

	public UILabel NoticeLabel;

	public UINetworkTextureExt MinCardCdnBg;

	public UINetworkTextureExt WeeklyCdnBg;

	public UINetworkTextureExt MonthlyCdnBg;

	public GameObject Subscribed;

	public UILabel SubscriptionActivedLabel;

	public UILabel SubscriptionActivedNoticeLabel;

	public UISprite SubscribedTips;

	public UIButton SubscribedHintButton;

	public GameObject UIFX_W;

	public GameObject UIFX_M;

	public GameObject UIFX_Mini;

	public Animation main;

	public GameObject BtnPurchaseInbuild;

	public UIButton CancelBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
