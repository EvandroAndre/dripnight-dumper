using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraSettingPanelView : UIBaseView
{
	public UIButton CloseBtn;

	public UISlider Slider;

	public UIToggle OwnShieldToggle;

	public UIToggle TeammateShieldToggle;

	public UIToggle EnemyShieldToggle;

	public UILabel AlphaLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
