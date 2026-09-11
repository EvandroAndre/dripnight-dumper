using GCommon;
using UnityEngine;

namespace COW;

public class UIFlashStorePurchasePopWndView : UIBaseView
{
	public UILabel ItemNameLabel;

	public UILabel limitedPurchaseLabel;

	public Transform ItemContainer;

	public UIButton PlusBtn;

	public UIInput CountInput;

	public UILabel CountLabel;

	public UIButton MinusBtn;

	public UIButton MaxBtn;

	public UILabel LabelMax;

	public UIButton AddTenBtn;

	public GameObject FlashGemsContentContainer;

	public GameObject FlashGemsOnlyContainer;

	public GameObject FlashGemsAndGemsNeedContainer;

	public UILabel FlashGemsOnlyConfirmLabel;

	public UIButton FlashGemsOnlyPurchaseBtn;

	public UILabel PeriodicGemsPrice;

	public GameObject ModifyNumContainer;

	public GameObject DualCurrencyCostContainer;

	public GameObject GemsCostContainer;

	public GameObject PeriodicGemsCostContainer;

	public UILabel PeriodicGemsCostLabel;

	public UILabel GemsCostLabel;

	public GameObject PlusObj;

	public UIButton FlashGemsAndGemsNeedPurchaseBtn;

	public UILabel FlashGemsAndGemsNeedConfirmLabel;

	public UILabel BuyBtnLabel;

	public GameObject OriginalPriceIllustrateContainer;

	public GameObject OriginalFlashGemsAngGemsContainer;

	public GameObject OriginalFlashGemsOnlyContainer;

	public UILabel OriginalFlashGemsLabel;

	public UILabel OriginalFlashGemsLabel2;

	public UILabel OriginalGemsCostLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
