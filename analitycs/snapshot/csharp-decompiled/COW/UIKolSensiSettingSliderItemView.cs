using GCommon;
using UnityEngine;

namespace COW;

public class UIKolSensiSettingSliderItemView : UIBaseView
{
	public UIWidget Widget;

	public UILabel LeftLabel;

	public UIButton TipBtn;

	public UISprite Sprite;

	public UIButton MinusBtn;

	public UILabel Value;

	public UIButton PlusBtn;

	public TweenPosition TweenPosition;

	public TweenAlpha TweenAlpha;

	public GameObject SliderContent;

	public UISlider Slider;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
