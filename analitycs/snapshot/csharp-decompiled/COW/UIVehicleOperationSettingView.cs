using GCommon;
using UnityEngine;

namespace COW;

public class UIVehicleOperationSettingView : UIBaseView
{
	public UIButton BtnBothHand;

	public UIButton BtnSingleHand;

	public Transform SingleHandSettingPos;

	public Transform BothHandSettingPos;

	public UIButton BtnSetting;

	public UIWidget AnchorWidget;

	public GameObject Content;

	public UISprite Bg;

	public UIButton BtnSetting2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
