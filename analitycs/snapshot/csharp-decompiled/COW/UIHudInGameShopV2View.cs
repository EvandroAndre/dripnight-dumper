using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopV2View : UIBaseView
{
	public GameObject ContentRoot;

	public UIButton ExitShopClickMask;

	public UIScrollView ShopItemsScrollView;

	public UITable2 ShopItemsTable2;

	public Transform ShopItemsTrans;

	public UIPanel ShopItemsScrollViewPanel;

	public UILabel BuyBtnLabel;

	public UIButton BuyBtn;

	public UILabel DisabledBuyBtnLabel;

	public GameObject EnabledBuyBtnGroup;

	public GameObject DisabledBuyBtnGroup;

	public UIButton CloseBtn;

	public UISprite CloseBtnIcon;

	public UITable TabTable;

	public UIScrollView TabScrollView;

	public Transform BackpackStatsRoot;

	public Transform FundStatsRoot;

	public UITable ExpandedShopItemDescTable;

	public UILabel ShopItemName;

	public UILabel ShopItemDescription;

	public UILabel ShopItemTags;

	public UIButton CollapseShopItemDescBtn;

	public UIButton ExpandShopItemDescBtn;

	public GameObject ExpandedShopItemDesc;

	public GameObject CollapsedShopItemDesc;

	public Transform DropCandidateTipsRoot;

	public UISprite GameMissionIcon;

	public UILabel Title;

	public UIEventListener TitleHelpBtn;

	public UIEventListener WarningIcon;

	public UIWidget CloseBtnGuideWidget;

	public GameObject DefaultShopBg;

	public GameObject PocketShopBg;

	public GameObject GlobalPurchaseLimitationGroup;

	public GameObject PersonalPurchaseLimitationGroup;

	public UILabel GlobalPurchaseAvailableCount;

	public UILabel PersonalPurchasedCount;

	public UILabel PersonalPurchaseLimitCount;

	public UIWidget ShopItemLimitationPlaceholder;

	public UIColor DescGroupBg;

	public Animation ShopItemDescGroupAnim;

	public GameObject NormalTitleBg;

	public GameObject PersonalShopUpgradeTitleBg;

	public GameObject PersonalShopUpgradeVFXContainer;

	public Transform POIMissionDesc;

	public UISprite SkinTitleBg;

	public UISprite SpriteBuyBtn;

	public UISprite DisabledSpriteBuyBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
