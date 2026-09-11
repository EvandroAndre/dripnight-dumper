using GCommon;
using UnityEngine;

namespace COW;

public class UIUGC_WardrobeModifyView : UIBaseView
{
	public UIToggleButtonGroup Style;

	public UIToggleButton Style1;

	public UIToggleButton Style2;

	public UIToggleButton Style3;

	public UIToggleButtonGroup PartSelect1;

	public UIToggleButtonGroup ColorSelect;

	public UIButton BtnRandom;

	public UIButton BtnConfirm;

	public UIButton BtnLastStyle;

	public UIToggleButtonGroup PartSelect2;

	public UIToggleButtonGroup PartSelect3;

	public GameObject StylePreview1;

	public GameObject StylePreview2;

	public GameObject StylePreview3;

	public UISprite PreviewJacket;

	public UISprite PreviewPants;

	public UISprite PreviewNumber;

	public UIButton Closure;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
