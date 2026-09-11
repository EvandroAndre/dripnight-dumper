using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisSplitWndView : UIBaseView
{
	public Transform ItemContainer;

	public UILabel ItemName;

	public UILabel ValueLabel;

	public UILabel WeightLabel;

	public UIButton ConfirmBtn;

	public UISprite ConfirmWidget;

	public UILabel CurrentCnt;

	public UILabel MaxCnt;

	public UIButton SlidePlusBtn;

	public UISlider Slider;

	public UIPanel GuideMask;

	public GameObject PlusBtnBG;

	public GameObject PlusBtnDisableBG;

	public UIButton NumPlusBtn;

	public UILabel NumPlusLabel;

	public UILabel NumPlusDisableLabel;

	public GameObject NumPlusBtnDisableBG;

	public GameObject NumPlusBtnBG;

	public GameObject MinusBtnBG;

	public GameObject MinusBtnDisableBG;

	public UIButton SlideMinusBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
