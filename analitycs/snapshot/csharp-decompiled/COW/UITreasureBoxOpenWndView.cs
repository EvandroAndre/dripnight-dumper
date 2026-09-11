using GCommon;
using UnityEngine;

namespace COW;

public class UITreasureBoxOpenWndView : UIBaseView
{
	public BaseItemView BaseItemView;

	public Transform StandardItemContainer;

	public UILabel ItemNameLabel;

	public UIButton OpenOneBtn;

	public UILabel OpenOneLabel;

	public UILabel CurrentCnt;

	public UILabel MaxCnt;

	public UIButton PlusBtn;

	public UISprite PlusSprite1;

	public UISprite PlusSprite2;

	public UIButton MinusBtn;

	public UISprite MinusSprite;

	public UISlider Slider;

	public GameObject PlusBtnAbleBG;

	public GameObject PlusBtnDisableBG;

	public GameObject MinusBtnAbleBG;

	public GameObject MinusBtnDisableBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
