using GCommon;
using UnityEngine;

namespace COW;

public class UIFPPSettingView : UIBaseView
{
	public UIButton BtnSight;

	public UIButton BtnCameraDamageEffect;

	public UISlider AccurateFireSlider;

	public UILabel AccurateFireValue;

	public UIButton BtnRecoil;

	public UISlider RecoilYCycleSlider;

	public UILabel RecoilYCycleValue;

	public UISlider RecoilYFactorSlider;

	public UILabel RecoilYFactorValue;

	public UISlider RecoilZCycleSlider;

	public UILabel RecoilZCycleValue;

	public UISlider RecoilZFactorSlider;

	public UILabel RecoilZFactorValue;

	public UIButton BtnRotation;

	public UISlider RotationZSlider;

	public UILabel RotationZValue;

	public UISlider RotationXSlider;

	public UILabel RotationXValue;

	public UISlider MoveJoyStickAngleSlider;

	public UILabel MoveJoyStickAngleValue;

	public UISlider PreMoveJoyStickAngleSlider;

	public UILabel PreMoveJoyStickAngleValue;

	public UISlider TwoToOneScreenLengthSlider;

	public UILabel TwoToOneScreenLengthValue;

	public UISlider FourToThreeScreenLengthSlider;

	public UILabel FourToThreeScreenLengthValue;

	public UISlider SmallTwoToOneScreenLengthSlider;

	public UILabel SmallTwoToOneScreenLengthValue;

	public UISlider SmallFourToThreeScreenLengthSlider;

	public UILabel SmallFourToThreeScreenLengthValue;

	public UIButton FireSmokeBtn;

	public UIButton HitEffectBtn;

	public GameObject SightUISwitch;

	public GameObject CameraDamageEffectSwitch;

	public GameObject FireSmokeSwitch;

	public GameObject HitEffectSwitch;

	public GameObject RecoilSwitch;

	public GameObject RotationSwitch;

	public UIButton BtnBullet;

	public GameObject BulletSwitch;

	public UIButton BtnFootStep;

	public GameObject FootStepSwitch;

	public UIButton BtnElectricZone;

	public GameObject ElectricZoneSwitch;

	public UIButton SpeedUpBtn;

	public GameObject SpeedUpSwitch;

	public UIInput Input;

	public UIButton BtnInputOk;

	public UISlider CameraMaxfireRotateAngleSlider;

	public UILabel CameraMaxfireRotateAngleValue;

	public UISlider CameraFireRotateTimeSlider;

	public UILabel CameraFireRotateTimeValue;

	public UISlider CameraMaxfireZoomOffsetSlider;

	public UILabel CameraMaxfireZoomOffsetValue;

	public UISlider CameraFireZoomTimeSlider;

	public UILabel CameraFireZoomTimeValue;

	public UISlider HeadKillEffectScaleSlider;

	public UILabel HeadKillEffectScaleValue;

	public UIButton ChangeWeaponBindBtn;

	public UILabel WeaponBindType;

	public UISlider RotationSpeedSlider;

	public UILabel RotationSpeedValue;

	public UIButton BtnGunTrace;

	public GameObject ChangeGunTraceSwitch;

	public UISlider GunTraceChangeLenSlider;

	public UILabel GunTraceChangeLenValue;

	public UISlider RecoilBackwardXSlider;

	public UILabel RecoilBackwardXValue;

	public UISlider RecoilBackwardZSlider;

	public UILabel RecoilBackwardZValue;

	public UISlider RecoilBackwardSpeedSlider;

	public UILabel RecoilBackwardSpeedValue;

	public UISlider RunSpeedSlider;

	public UILabel RunSpeedValue;

	public UISlider StandYOffsetSlider;

	public UILabel StandYOffsetValue;

	public UISlider CrouchYOffsetSlider;

	public UILabel CrouchYOffsetValue;

	public UISlider CreepYOffsetSlider;

	public UILabel CreepYOffsetValue;

	public UISlider IceWallChangeLenSlider;

	public UILabel IceWallChangeLenValue;

	public UISlider PlayerFiringDampSlider;

	public UILabel PlayerFiringDampValue;

	public UISlider StandZOffsetSlider;

	public UILabel StandZOffsetValue;

	public UISlider CrouchZOffsetSlider;

	public UILabel CrouchZOffsetValue;

	public UISlider CreepZOffsetSlider;

	public UILabel CreepZOffsetValue;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
