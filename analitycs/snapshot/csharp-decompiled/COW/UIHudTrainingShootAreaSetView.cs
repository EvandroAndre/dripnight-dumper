using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTrainingShootAreaSetView : UIBaseView
{
	public UIButton SwitchBtn;

	public UIButton FoldBtn;

	public GameObject Setting;

	public UIButton ResetBtn;

	public GameObject Config;

	public UILabel Value;

	public UIButton plusBtn;

	public UIButton minusBtn;

	public UIButton SwitchToSetBtn;

	public UIButton ConfigResetBtn;

	public UILabel DummyInfo;

	public UISlider HPSlider;

	public UITrainingToggleSetting HelmetToggle;

	public UITrainingToggleSetting VestToggle;

	public GameObject TargetHpSlider;

	public UISprite ConfigBG;

	public UITable ConfigTable;

	public UIEventListener DetailBtn;

	public UIToggle GodToggleOpen;

	public UIToggle GodToggleClose;

	public UIToggle DamageInfoToggleOpen;

	public UIToggle DamageInfoToggleClose;

	public UIToggle MoveToggleStand;

	public UIToggle MoveToggleWalk;

	public UIToggle MoveToggleRun;

	public UISlider TargetCountSlider;

	public UILabel TargetCountSliderValue;

	public UISlider DistanceSlider;

	public UILabel DistanceSliderValue;

	public UIToggle HelmetNoneToggle;

	public UIToggle VestNoneToggle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
