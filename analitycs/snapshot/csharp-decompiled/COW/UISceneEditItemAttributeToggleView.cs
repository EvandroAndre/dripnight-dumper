using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeToggleView : UIBaseView
{
	public UILabel AttrLabel;

	public UIToggleButtonGroup ToggleButton;

	public UIToggleButton Left;

	public UIToggleButton Right;

	public UILabel LeftLabelSelect;

	public UILabel RightLabelSelect;

	public UILabel LeftLabelUnSelect;

	public UILabel RightLabelUnSelect;

	public UIButton HintBtn;

	public UIColor bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
