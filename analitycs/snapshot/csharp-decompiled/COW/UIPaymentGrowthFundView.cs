using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentGrowthFundView : UIBaseView
{
	public UIButton Hint;

	public GameObject HasGained;

	public UILabel HasGainedLevel;

	public UILabel HasGainedDesc;

	public GameObject HasNotGained;

	public UISprite PurchasableDiamondSprite;

	public UILabel BundlePriceDiamondLabel;

	public UILabel OriginalPriceDiamondLabel;

	public UILabel PendingDiamondLabel;

	public UISprite PurchasableSprite;

	public UIButton Purchase;

	public UILabel BundlePriceLabel;

	public UILabel OriginalPriceLabel;

	public UILabel PendingLabel;

	public UISprite UnpurchasableSprite;

	public UISprite PurchasableFreeSprite;

	public UISprite PercentageSprite;

	public UILabel PercentageLabel;

	public UILabel DiamondCountLabel;

	public UILabel HasNotGainedLevel;

	public UILabel HasNotGainedDesc;

	public UIScrollView BundlesScrollView;

	public UIEasyList BundlesScrollViewGrid;

	public UISprite ArrowRight;

	public UISprite ArrowLeft;

	public GameObject VFX_UI_Fund_01;

	public GameObject GrowthFundFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
