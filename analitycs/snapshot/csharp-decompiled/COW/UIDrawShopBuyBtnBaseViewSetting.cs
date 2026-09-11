using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopBuyBtnBaseViewSetting : MonoBehaviour
{
	public bool SupportSingleBuyButton;

	public bool SupportMultiBuyButton;

	public bool SupportMixedBuy;

	public bool SupportSingleBuyFree;

	public bool SupportDiscountBuy;

	public bool SupportCoupon;

	public bool SupportLimitBuy;

	public bool SupportChangeSkin;

	public UIButton SingleBuyBtn;

	public UILabel SingleBuyLabel;

	public UISprite SingleBuyBg;

	public UINetworkTexture SingleBuyBgCDN;

	public UILabel SingleBuyFree;

	public UISprite SingleConsumeTypeIcon;

	public UISprite SingleCurrencyIcon;

	public UILabel SinglePriceLabel;

	public GameObject SingleLimitContainer;

	public UILabel SingleLimitPercentLabel;

	public GameObject SingleDiscountContainer;

	public UILabel SinglePercentLabel;

	public UISprite SingleDiscountIcon;

	public UILabel SingleOriginalPriceLabel;

	public UILabel SingleDiscountPriceLabel;

	public UILabel SingleDiscountFreeLabel;

	public GameObject SingleDiscountTag;

	public Animation SingleDiscountTagAnimation;

	public UISprite SingleDiscountTagBg;

	public UINetworkTexture SingleDiscountTagBgCDN;

	public UICountDownLabel FreeCountdownLabel;

	public Transform StandardLabelPos;

	public Transform SingleDefaultVFX;

	public Transform SingleConfigVFX;

	public UIButton MultiBuyBtn;

	public UILabel MultiBuyLabel;

	public UISprite MultiBuyBg;

	public UINetworkTexture MultiBuyBgCDN;

	public GameObject MultiNormalSingle;

	public UILabel MultiPriceLabel;

	public UISprite MultiConsumeTypeIcon;

	public UISprite MultiCurrencyIcon;

	public GameObject MultiNormalMixed;

	public UISprite MultiNormalMixedConsumeTypeIcon;

	public UILabel MultiNormalMixedConsumeLabel;

	public UISprite MultiNormalMixedCurrencyIcon;

	public UILabel MultiNormalMixedCurrencyLabel;

	public GameObject MultiLimitContainer;

	public UILabel MultiLimitPercentLabel;

	public GameObject MultiDiscountContainer;

	public UILabel MultiPercentLabel;

	public GameObject MultiDiscountSingle;

	public UISprite MultiDiscountIcon;

	public UILabel MultiOriginalPriceLabel;

	public UILabel MultiDiscountPriceLabel;

	public UILabel MultiDiscountFreeLabel;

	public GameObject MultiDiscountMixed;

	public UISprite MultiDiscountMixedConsumeTypeIcon;

	public UILabel MultiDiscountMixedConsumeLabel;

	public UISprite MultiDiscountMixedCurrencyIcon;

	public UILabel MultiDiscountMixedOriginalCurrencyLabel;

	public UILabel MultiDiscountMixedDiscountCurrencyLabel;

	public GameObject MultiDiscountTag;

	public Animation MultiDiscountTagAnimation;

	public UISprite MultiDiscountTagBg;

	public UINetworkTexture MultiDiscountTagBgCDN;

	public Transform MultiDefaultVFX;

	public Transform MultiConfigVFX;
}
