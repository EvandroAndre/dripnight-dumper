using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIFPPSettingController : UISettingContentBase
{
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public FPPSettingSliderConfig config;

		public UIFPPSettingController _003C_003E4__this;

		internal void _003COnUIInit_003Eb__0()
		{
		}
	}

	private readonly float MIN_ACCURATE_FIRE_TIME;

	private readonly float MAX_ACCURATE_FIRE_TIME;

	private readonly float MAX_Y_CYCLE;

	private readonly float MAX_Z_CYCLE;

	private readonly float MAX_Y_FACTOR;

	private readonly float MAX_Z_FACTOR;

	private readonly float MAX_X_Rotation;

	private readonly float MAX_Z_Rotation;

	private readonly float MaxRotationSpeed;

	private readonly float MAX_X_RecoilBackward;

	private readonly float MAX_Z_RecoilBackward;

	private readonly float Max_RecoilBackwardSpeed;

	private readonly float MAX_MoveJoyStickAngle;

	private readonly float MAX_PreMoveJoyStickAngle;

	private readonly float MAX_TwoToOneScreenLength;

	private readonly float MAX_FourToThreeScreenLength;

	private readonly float MAX_SmallTwoToOneScreenLength;

	private readonly float MAX_SmallFourToThreeScreenLength;

	private readonly float MaxCameraMaxfireRotateAngle;

	private readonly float MaxCameraFireRotateTime;

	private readonly float MaxCameraMaxfireZoomOffset;

	private readonly float MaxCameraFireZoomTime;

	private readonly float MaxHeadKillEffectScale;

	private readonly float MaxChangeGunTraceLen;

	private readonly float MaxRunSpeed;

	private readonly float MAX_StandYOffset;

	private readonly float MAX_CrouchYOffset;

	private readonly float MAX_CreepYOffset;

	private readonly float MAX_StandZOffset;

	private readonly float MAX_CrouchZOffset;

	private readonly float MAX_CreepZOffset;

	private readonly float MAX_IceWallChangeDisLenRatio;

	private Dictionary<string, FPPSettingSliderConfig> m_SliderSetting;

	private UISlider m_InputSlider;

	private float m_MinValue;

	private float m_MaxValue;

	private UIFPPSettingView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private float GetSettingValue(FPPSettingSliderConfig config)
	{
		return 0f;
	}

	private void RefreshSliderValue(FPPSettingSliderConfig config, float finalValue)
	{
	}

	private void OnBtnRecoilClick()
	{
	}

	private void OnBtnSightClick()
	{
	}

	private void OnBtnCameraDamageEffectClick()
	{
	}

	private void OnBtnRotationClick()
	{
	}

	private void OnBtnFireSmokeClick()
	{
	}

	private void OnBtnHitEffectClick()
	{
	}

	private void OnBtnBulletClick()
	{
	}

	private void OnBtnElectricZoneClick()
	{
	}

	private void OnBtnSpeedUpClick()
	{
	}

	private void OnBtnFootStepClick()
	{
	}

	private void SetCurInputSlider(UISlider slider, float minValue, float maxValue)
	{
	}

	private void OnBtnInputOkClick()
	{
	}

	private void OnBtnChangeGunTraceClick()
	{
	}

	private void OnChangeWeaponBindBtnClick()
	{
	}

	private void RefreshBindTypeLabel()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
