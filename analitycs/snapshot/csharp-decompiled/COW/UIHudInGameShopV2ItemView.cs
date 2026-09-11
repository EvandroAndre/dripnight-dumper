using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopV2ItemView : UIBaseView
{
	public UISprite SpecialItemBG;

	public UISprite itemSprite;

	public UILabel LabelItemCount;

	public UILabel ItemName;

	public GameObject HighlightSelected;

	public UILabel Price;

	public GameObject TimeLimitRoot;

	public UILabel TimeLimit;

	public UIButton ItemBtn;

	public UISprite CoinIcon;

	public GameObject NewItemTag;

	public GameObject HotItemTag;

	public GameObject GrayMask;

	public GameObject BattleLevelLimitedGroup;

	public UILabel BattleLevelLimitedText;

	public GameObject PersonalPurchaseLimitGroup;

	public UILabel PersonalPurchasedCount;

	public UILabel PersonalPurchaseLimitCount;

	public GameObject GlobalPurchaseLimitGroup;

	public UILabel GlobalPurchaseAvailableCount;

	public UILabel GlobalPurchaseLimitPrefix;

	public UILabel PersonalPurchaseLimitSlash;

	public GameObject defaultTitleBg;

	public UISprite customTitleBg;

	public GameObject defaultBackBg;

	public UISprite customBackBg;

	public UILabel OriginalPrice;

	public GameObject OriginalPriceGroup;

	public UISprite GlobalPurchaseLimitBg;

	public GameObject HighlightTitleBg;

	public GameObject HighlightBackBg;

	public UIWidget UnderMaskGroupWidget;

	public UISprite ActivityIcon;

	public UISprite TechDeviceBG;

	public UISprite AcitityBg;

	public GameObject TeamPurchaseLimitGroup;

	public UILabel TeamPurchaseLimitPrefix;

	public UILabel TeamPurchaseAvailableCount;

	public GameObject WeaponMountgrenade;

	public GameObject StartSaleTimeLimitRoot;

	public UILabel StartSaleTimeLimit;

	public Transform POIMissionCardState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
