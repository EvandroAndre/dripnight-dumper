using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2SendGiftPopupWndView : UIBaseView
{
	public UIButton GoldPurchaseBtn;

	public UILabel GoldPrice;

	public UILabel GoldBefore;

	public GameObject GoldVoucherEffect;

	public UIButton GemsPurchaseBtn;

	public UILabel GemsPrice;

	public UILabel GemsBefore;

	public GameObject DiamondVoucherEffect;

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

	public UIVoucher Voucher;

	public GameObject ModifyNumContainer;

	public UIButton PlusBtn;

	public UIInput CountInput;

	public UILabel CountLabel;

	public UIButton MinusBtn;

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

	public UILabel GemTipsLabel;

	public Transform ItemContainer;

	public UILabel ItemNameLabel;

	public UILabel LimitedLabel;

	public UIInput MassageInput;

	public GameObject CallsignContainer;

	public UIButton CloseBtn;

	public UINetworkTexture PrimeCdnBg;

	public GameObject PrimeContainer;

	public UINetworkTexture NormalCdnBg;

	public GameObject NormalContainer;

	public UIInput MassageInput_Prime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
