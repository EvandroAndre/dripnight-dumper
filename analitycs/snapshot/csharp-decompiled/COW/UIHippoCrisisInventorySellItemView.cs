using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventorySellItemView : UIBaseView
{
	public UILabel NameLabel;

	public UILabel ValueLabel;

	public GameObject ItemContainer;

	public GameObject ModifyNumContainer;

	public UILabel CurrentCnt;

	public UILabel MaxCnt;

	public UIButton PlusBtn;

	public UIButton MinusBtn;

	public UISlider Slider;

	public GameObject Select;

	public UIButton SelectBtn;

	public GameObject Selected;

	public GameObject UnSelected;

	public Transform ItemPos;

	public GameObject MinusBtnDisableBG;

	public GameObject MinusBtnAbleBG;

	public GameObject PlusBtnDisableBG;

	public GameObject PlusBtnAbleBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
