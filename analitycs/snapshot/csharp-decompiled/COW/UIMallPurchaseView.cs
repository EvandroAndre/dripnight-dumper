using GCommon;
using UnityEngine;

namespace COW;

public class UIMallPurchaseView : UIBaseView
{
	public UILabel ItemNameLabel;

	public UILabel limitedPurchaseLabel;

	public UILabel purchaseDescLabel;

	public Transform ItemContainer;

	public UIButton GoldPurchaseBtn;

	public UILabel GoldPrice;

	public UILabel GoldBefore;

	public GameObject GoldVoucherEffect;

	public UIButton GemsPurchaseBtn;

	public UILabel GemsPrice;

	public UILabel GemsBefore;

	public GameObject DiamondVoucherEffect;

	public UIButton ExchangeBtn;

	public UISprite ExchangeIcon;

	public UILabel ExchagneLabel;

	public UIButton ClanExchangeBtn;

	public UISprite ClanExchangeIcon;

	public UILabel ClanExchagneLabel;

	public UILabel ClanDiamondLabel;

	public GameObject GoldAndGems;

	public UIButton DualCurrencyGoldPurchaseBtn;

	public UIWidget DualCurrencyGoldPurchaseWidget;

	public UILabel DualCurrencyGoldPrice;

	public GameObject DualCurrencyGoldVoucherEffect;

	public UILabel DualCurrencyGoldPriceBefore;

	public UIButton DualCurrencyGemsPurchaseBtn;

	public UILabel DualCurrencyGemsPrice;

	public GameObject DualCurrencyDiamondVoucherEffect;

	public UILabel DualCurrencyGemsPriceBefore;

	public UIButton ForgeExchangeBtn;

	public UISprite Material2Icon;

	public UISprite Material1Icon;

	public UILabel Material2Cnt;

	public UILabel Material1Cnt;

	public GameObject Add;

	public UIVoucher Voucher;

	public GameObject ModifyNumContainer;

	public UIButton PlusBtn;

	public UIInput CountInput;

	public UILabel CountLabel;

	public UIButton MinusBtn;

	public UIButton MaxBtn;

	public GameObject VoucherBound;

	public GameObject GoldWithDiscount;

	public GameObject GoldWithoutDiscount;

	public UILabel GoldDiscountPrice;

	public GameObject GemWithoutDiscount;

	public UILabel GemsDiscountPrice;

	public GameObject GemWithDiscount;

	public UILabel DualCurrencyGoldDiscountPrice;

	public GameObject DualCurrencyGoldWithoutDiscount;

	public GameObject DualCurrencyGoldWithDiscount;

	public GameObject DualCurrencyGemsWithDiscount;

	public GameObject DualCurrencyGemsWithoutDiscount;

	public UILabel DualCurrencyGemsDiscountPrice;

	public UIButton TailorUnlockBtn;

	public UISprite TailorUnlockIcon;

	public UILabel TailorUnlockLabel;

	public GameObject SpecialConfirm;

	public UILabel SpecialConfirmGemsLabel;

	public UILabel SpecialConfirmGoldLabel;

	public GameObject SpecialConfirmGems;

	public GameObject SpecialConfirmGold;

	public UIButton SpecialConfirmGemsBtn;

	public UIButton SpecialConfirmGoldBtn;

	public GameObject MultItemNode;

	public GameObject UnLockMixTokenContainer;

	public UIGrid UnLockMixTokenContainerGrid;

	public UISprite UnLockUniqueTokenIcon;

	public UISprite UnLockUniversalTokenIcon;

	public GameObject FakeVoucher;

	public UILabel GemTipsLabel;

	public GameObject DiscountContainer;

	public UIButton GoToDiscountBtn;

	public UILabel GoToDiscountLabel;

	public UILabel LabelDiscount;

	public UILabel LabelDiscountWithoutNum;

	public GameObject GemsAndIAPBtn;

	public UIButton DualIAPGemsPurchaseBtn;

	public GameObject DualIAPGemsWithDiscount;

	public UILabel DualIAPGemsDiscountPrice;

	public UILabel DualIAPGemsPriceBefore;

	public GameObject DualIAPGemsWithoutDiscount;

	public UILabel DualIAPGemsPrice;

	public UIButton DualIAPCurrencyPurchaseBtn;

	public GameObject DualIAPCurrencyWithDiscount;

	public GameObject DualIAPCurrencyWithoutDiscount;

	public UILabel DualIAPCurrencyDiscountPrice;

	public UILabel DualIAPCurrencyBefore;

	public UILabel DualIAPCurrencyPrice;

	public GameObject IAPBtn;

	public UIButton IAPPurchaseBtn;

	public GameObject IAPWithDiscount;

	public UILabel IAPDiscountPrice;

	public UILabel IAPBefore;

	public GameObject IAPWithoutDiscount;

	public UILabel IAPCurrencyPrice;

	public GameObject ExchangeWithGemsGameObject;

	public UIButton ExchangeWithGemsBtn;

	public UISprite TokenIcon;

	public UILabel TokenNumberLabel;

	public UISprite DiamondIcon;

	public UILabel DiamondNumberLabel;

	public UICenterTargetHelper ExchangeDiamondBtnCenterHelper;

	public UILabel DescLabel;

	public GameObject SpecialConfirmUGCToken;

	public UILabel SpecialConfirmUGCTokenLabel;

	public UIButton SpecialConfirmUGCTokenBtn;

	public GameObject MessageWindow;

	public GameObject Empty;

	public GameObject ConfirmEnableBg;

	public GameObject ConfirmDisableBg;

	public UILabel ConfirmLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
