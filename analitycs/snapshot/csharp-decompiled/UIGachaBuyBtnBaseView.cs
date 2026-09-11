using COW;
using GCommon;
using UnityEngine;

public class UIGachaBuyBtnBaseView : MonoBehaviour
{
	public bool SupportOneBuyButton;

	public bool SupportLuckySpin;

	public bool SupportMultiBuyButton;

	public bool SupportMixedBuy;

	public bool SupportOneBuyFree;

	public bool SupportDiscountBuy;

	public bool SupportCoupon;

	public bool SupportLimitBuy;

	public bool SupportChangeSkin;

	public bool SupportMultiTenBuy;

	public bool SupportPlusOrMinus;

	public UIButton OneBuyBtn;

	public UILabel OneBuyLabel;

	public UISprite OneBuyBg;

	public UINetworkTexture OneBuyBgCDN;

	public UISprite LuckySpinBg;

	public UILabel OneBuyFree;

	public UISprite OneConsumeTypeIcon;

	public UISprite OneCurrencyIcon;

	public UILabel OnePriceLabel;

	public GameObject OneLimitContainer;

	public UILabel OneLimitPercentLabel;

	public GameObject OneDiscountContainer;

	public UILabel OnePercentLabel;

	public UISprite OneDiscountIcon;

	public UILabel OneOriginalPriceLabel;

	public UILabel OneDiscountPriceLabel;

	public UILabel OneDiscountFreeLabel;

	public GameObject OneDiscountTag;

	public Animation OneDiscountTagAnimation;

	public UISprite OneDiscountTagBg;

	public UINetworkTexture OneDiscountTagBgCDN;

	public UICountDownLabel FreeCountdownLabel;

	public Transform StandardLabelPos;

	public Transform OneDefaultVFX;

	public Transform OneConfigVFX;

	public UIButton TenBuyBtn;

	public UILabel TenBuyLabel;

	public UISprite TenBuyBg;

	public UINetworkTexture TenBuyBgCDN;

	public GameObject TenNormalSingle;

	public UILabel TenPriceLabel;

	public UISprite TenConsumeTypeIcon;

	public UISprite TenCurrencyIcon;

	public GameObject TenNormalMixed;

	public UISprite TenNormalMixedConsumeTypeIcon;

	public UILabel TenNormalMixedConsumeLabel;

	public UISprite TenNormalMixedCurrencyIcon;

	public UILabel TenNormalMixedCurrencyLabel;

	public GameObject TenLimitContainer;

	public UILabel TenLimitPercentLabel;

	public GameObject TenDiscountContainer;

	public UILabel TenPercentLabel;

	public GameObject TenDiscountSingle;

	public UISprite TenDiscountIcon;

	public UILabel TenOriginalPriceLabel;

	public UILabel TenDiscountPriceLabel;

	public UILabel TenDiscountFreeLabel;

	public GameObject TenDiscountMixed;

	public UISprite TenDiscountMixedConsumeTypeIcon;

	public UILabel TenDiscountMixedConsumeLabel;

	public UISprite TenDiscountMixedCurrencyIcon;

	public UILabel TenDiscountMixedOriginalCurrencyLabel;

	public UILabel TenDiscountMixedDiscountCurrencyLabel;

	public GameObject TenDiscountTag;

	public Animation TenDiscountTagAnimation;

	public UISprite TenDiscountTagBg;

	public UINetworkTexture TenDiscountTagBgCDN;

	public Transform TenDefaultVFX;

	public Transform TenConfigVFX;

	public UIButton SwitchBtn;

	public UISprite SwitchBg;

	public UINetworkTexture SwitchBgCDN;

	public Transform SwitchVFX;

	public UIButton PopMenuBtn;

	public UISprite ArrowUpSprite;

	public UISprite ArrowDownSprite;

	public UISprite PopMenuBg;

	public UINetworkTexture PopMenuBgCDN;

	public GameObject PopMenuListContainer;

	public Transform PopMenuItemRoot;

	public UIGrid PopMenuItemGrid;

	public UIButton PopListClickMask;

	public UISprite PopMenuItemGridBG;
}
