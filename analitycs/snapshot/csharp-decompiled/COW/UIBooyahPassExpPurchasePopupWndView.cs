using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassExpPurchasePopupWndView : UIBaseView
{
	public Transform Center;

	public Transform SplitLeft;

	public GameObject BPLevelPurchaseGroup;

	public UILabel LevelPurchaseRewardCountLabel;

	public UIScrollView RewardListScrollView;

	public GameObject LevelStepperGroup;

	public UIButton LevelStepperPlusBtn;

	public UILabel LevelStepperLabel;

	public UIButton LevelStepperMinusBtn;

	public UIButton LevelStepperPlusTenBtn;

	public Transform LevelPurchaseBtnRoot;

	public Transform SplitRight;

	public GameObject BPLevelPackagePurchaseGroup;

	public UINetworkTexture LevelPackageCDN;

	public Transform LevelPackageCountdownRoot;

	public UILabel LevelPackageLimitLabel;

	public Transform LevelPackageCouponRoot;

	public Transform LevelPackagePurchaseBtnRoot;

	public UIEasyList RewardEasyList;

	public GameObject bgline;

	public GameObject LevelPackagePurchaseEnableGroup;

	public GameObject LevelPackagePurchaseDiscountVFXGroup;

	public UILabel LevelPackagePurchasePercentOffLabel;

	public GameObject LevelPackagePurchaseWithDiscountGroup;

	public UILabel LevelPackageWithDiscountPriceLabel;

	public UILabel LevelPackageWithDiscountOriginalPriceLabel;

	public GameObject LevelPackagePurchaseWithoutDiscountGroup;

	public GameObject LevelPackagePurchaseDisableGroup;

	public UIButton LevelPackagePurchaseBtn;

	public GameObject LevelPurchaseEnableGroup;

	public GameObject LevelPurchaseDiscountVFXGroup;

	public UILabel LevelPurchasePercentOffLabel;

	public GameObject LevelPurchaseWithDiscountGroup;

	public UILabel LevelWithDiscountPriceLabel;

	public UILabel LevelWithDiscountOriginalPriceLabel;

	public GameObject LevelPurchaseWithoutDiscountGroup;

	public UILabel LevelWithoutDiscountOriginalPriceLabel;

	public GameObject LevelPurchaseDisableGroup;

	public UIButton LevelPurchaseBtn;

	public UILabel LevelPackageWithoutDiscountOriginalPriceLabel;

	public UILabel LevelPackageTitle;

	public UILabel LevelPackageRewardCountLabel;

	public UIScrollView LevelPackageRewardListScrollView;

	public UIEasyList LevelPackageRewardEasyList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
