using GCommon;
using UnityEngine;

namespace COW;

public class UICountDownView : UIBaseView
{
	public UIWidget UICountDown;

	public UICenterTargetHelper CenterHelper;

	public UICountDownLabel CountDownLabel;

	public UILabel LabelContent;

	public UISprite CountDownIcon;

	public UIButton CountDownIconBtn;

	public UISprite CountDownBg;

	public GameObject CountdownBar;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
