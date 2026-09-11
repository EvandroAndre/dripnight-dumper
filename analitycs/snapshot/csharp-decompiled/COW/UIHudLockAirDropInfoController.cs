using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLockAirDropInfoController : UIBaseController
{
	private const uint VISIBILITY_STATE_DETECTIVE_SCAN_WARNING = 67108864u;

	private UIHudLockAirDropInfoView m_View;

	private bool m_PlayerIn;

	private float m_AppetizerUnlockProgress;

	private uint m_AppetizerMainRewardID;

	private uint m_MainRewardID;

	private float m_FillAmount;

	private uint m_BindId;

	private InteractiveState m_CurrentState;

	private DFMAGBNLCHD m_Type;

	private InteractiveStep m_CurrentStep;

	private int m_Step1Value;

	private int m_Step2Value;

	private int m_Step3Value;

	private bool m_HasShowGameplayAffixNotify;

	private static Color NORMALFILLBGCOLOR;

	private static Color LOTUSLAMPFILLBGCOLOR;

	private static Color FIGHTINGCOLOR;

	private static Color NORMALCOLOR;

	private int SpeedUpMaxWidth;

	private ulong m_InTriggerPlayerBit;

	private bool m_AppetizerUnlockShown;

	private bool m_IsFighting;

	private int m_Time;

	private VisualInstanceHolder m_AppetizerUnlockUIFXHolder;

	private VisualInstanceHolder m_BTBubbleVFXHolder;

	private VisualInstanceHolder m_EnergyDeviceVFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDetectiveScanWarningStateChanged(bool showing)
	{
	}

	private void UpdateBasicStep()
	{
	}

	private void UpdateView()
	{
	}

	private void InitLotusLampSprite()
	{
	}

	private void InitUpgradeGemSprite()
	{
	}

	protected virtual float GetStep1Value()
	{
		return 0f;
	}

	protected virtual float GetStep2Value()
	{
		return 0f;
	}

	protected virtual float GetStep3Value()
	{
		return 0f;
	}

	private void OnStepChanged(object[] param)
	{
	}

	private void ChangeStep(InteractiveStep step)
	{
	}

	private void OnTimeChanged(object[] param)
	{
	}

	private void SetTime(int time)
	{
	}

	private void UpdateTeamInfo(int time)
	{
	}

	private float GetProgressPosX(int time)
	{
		return 0f;
	}

	private void OnPlayerActiveChanged(object[] param)
	{
	}

	private bool CanShowTeamInfo()
	{
		return false;
	}

	private void OnPlayerCountChanged(object[] param)
	{
	}

	private void PlayerCountChange(int value)
	{
	}

	private void OnStateChanged(object[] param)
	{
	}

	private void SetEnergyDeviceIcon()
	{
	}

	private void SetBTBubbleIcon()
	{
	}

	private void SetTechAirDropIcon()
	{
	}

	private void OnVisibleChanged(GEvent param)
	{
	}

	private void SetAppetizerView()
	{
	}

	private void RetsetProcess()
	{
	}

	private void UpdateSpeedUpVFX(int time)
	{
	}

	private void OnBTBubbleAccelerate(uint levelID)
	{
	}

	private void UpdateEnergyDeviceVFX(int time)
	{
	}

	private void OnEnergyDeviceCrystalBroken(object[] param)
	{
	}

	private void OnPlayerBitChanged(ulong data)
	{
	}

	private bool HasTeammateWithSpeedUpBuffInTrigger(ulong inTriggerPlayerBit)
	{
		return false;
	}

	private bool HasEnemyInTrigger()
	{
		return false;
	}

	private void UpdateTechFightingState()
	{
	}

	private void UpdateLockFightingState()
	{
	}

	private void UpdateEnergyDeviceFightingState()
	{
	}

	private void _003CSetTime_003Eb__37_0(GameObject instance)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
