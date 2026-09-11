using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisMarketPurchaseView : UIBaseView
{
	public UILabel ItemNameLabel;

	public Transform MoneyBuyItemContainer;

	public UIButton MoneyPurchaseBtn;

	public Transform exchangeItemTrans;

	public UIButton CancelBtn;

	public UIButton ExchangeBtn;

	public UITable MatTable;

	public GameObject InputModifyNumContainer;

	public UIButton InputPlusBtn;

	public UIInput CountInput;

	public UILabel InputCountLabel;

	public UIButton InputMinusBtn;

	public GameObject SlideModifyNumContainer;

	public Transform MoneyBuyItemTrans;

	public UILabel MaxCnt;

	public UILabel CurrentCnt;

	public UIButton SlidePlusBtn;

	public UIButton SlideMinusBtn;

	public UISlider Slider;

	public GameObject MoneyBuyContainer;

	public GameObject MatBuyContainer;

	public UILabel MoneyNumLabel;

	public UIButton NumPlusBtn;

	public UILabel NumPlusLabel;

	public GameObject PlusBtnBG;

	public GameObject MinusBtnBG;

	public UISprite InputMinBtnBG;

	public UISprite NumPlusBtnBG;

	public UISprite InputPlusBG;

	public GameObject ModifyNumContainer;

	public GameObject PlusBtnDisableBG;

	public GameObject MinusBtnDisableBG;

	public GameObject InputPlusBtnDisableBG;

	public GameObject InputMinusBtnDisableBG;

	public GameObject NumPlusBtnDisableBG;

	public UILabel NumPlusDisableLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
