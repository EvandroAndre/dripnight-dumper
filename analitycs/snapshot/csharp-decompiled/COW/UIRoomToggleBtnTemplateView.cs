using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomToggleBtnTemplateView : UIBaseView
{
	public UIToggleButtonGroup ToggleBtnGo;

	public UILabel ToggleBtnLabel;

	public UIToggleButton EnabledToggle;

	public UISprite EnabledLabelCheckmark;

	public UILabel EnabledLabel;

	public UIToggleButton DisabledToggle;

	public UISprite DisabledLabelCheckmark;

	public UILabel DisabledLabel;

	public UIButton HelpeBtn;

	public GameObject TagGo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
