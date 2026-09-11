using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingSliderItemView : UIBaseView
{
	public UIWidget Widget;

	public UILabel LeftLabel;

	public UIButton TipBtn;

	public UISlider Slider;

	public UILabel Value;

	public UIWidget AsChildWidget;

	public UILabel LeftLabelChild;

	public UISprite Sprite;

	public TweenPosition TweenPosition;

	public TweenAlpha TweenAlpha;

	public TweenAlpha LabelTweenAlpha;

	public TweenPosition LabelTweenPosition;

	public UIButton MinusBtn;

	public UIButton PlusBtn;

	public GameObject SliderContent;

	public UIButton SelectedBtn;

	public GameObject SelectedSprite;

	public GameObject SelectedSpriteChild;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
