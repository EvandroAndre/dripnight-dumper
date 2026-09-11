using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditModeSelectConfirmWndView : UIBaseView
{
	public UIToggleButtonGroup ToggleGroup;

	public UIToggleButton ModeCSBtn;

	public UIToggleButton ModePartyBtn;

	public UIButton BtnCancel;

	public UILabel BtnCancelTxt;

	public UIButton BtnApply;

	public UILabel BtnApplyTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
