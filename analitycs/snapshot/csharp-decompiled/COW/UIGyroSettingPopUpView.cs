using GCommon;
using UnityEngine;

namespace COW;

public class UIGyroSettingPopUpView : UIBaseView
{
	public UIInput VertRotateRateScaleInput;

	public UIInput HoriRotateRateScaleInput;

	public UIInput CameraRestoreRateInput;

	public UIInput MaxRotateAngelYSwingPlusInput;

	public UIInput MaterialSpeedInput;

	public UIToggleButton SmoothButton;

	public UIToggleButton AbruptButton;

	public UIInput WidthInput;

	public UIInput HeightInput;

	public UICheckboxButton CameraRestoreCheckBox;

	public UICheckboxButton SwingPivotRestoreCheckBox;

	public UICheckboxButton TextureRestoreCheckBox;

	public UIInput SwingPivotRestoreRateInput;

	public UIInput TextureRestoreRateInput;

	public UIGrid BgSwitchGrid;

	public UIGyroSettingPopUpBgSwitchItem BgSwitchItem;

	public UIInput MaxRotateAngelXSwingPlusInput;

	public GameObject GyroCamController;

	public GameObject GyroStandard;

	public GameObject BgSwitch;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
