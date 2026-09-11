using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditColorSetterWndView : UIBaseView
{
	public UITexture HSVBoard;

	public GameObject BoardPoint;

	public UISprite CurrentColor;

	public UIButton Mask;

	public GameObject Content;

	public UIColor Bg;

	public UIToggleButtonGroup TabToggleGroup;

	public GameObject WheelsContainer;

	public GameObject PalettesContainer;

	public UISlider HSVSliderBar;

	public UITexture HSVSliderTexture;

	public UIInput ColorInput;

	public UILabel ColorInputLabel;

	public UILabel AlphaInputLabel;

	public UIInput AlphaInput;

	public UISlider AlphaSliderBar;

	public UITexture AlphaSliderTexture;

	public GameObject ColorItem;

	public GameObject WheelsDropList;

	public GameObject WheelsColorContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
