using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSkillShowPanelController : UIBaseController, NODKNGMKFIP
{
	private struct DetectiveScanReadBarState
	{
		public Vector3 SkillCenterPos;

		public uint CastPlayerID;

		public uint SkillID;

		public float StartTime;

		public float Duration;

		public bool IsActive;

		public float Elapsed => 0f;

		public float RemainingDuration => 0f;
	}

	private UIHudSkillShowPanelView m_View;

	private UIImmortalityCountdownTimerController m_immortalityTimerCtrl;

	private UIImmortalityCountdownTimerSF50Controller m_sfReaperTimerCtrl;

	private UIImmortalityCountdownTimerCarni25DanceController m_carni25DanceTimerCtrl;

	private uint m_nDelayCallHideImmortalitySuccessKilledEffect;

	private uint m_immortalitySuccessKilledEffectId;

	private uint m_nDelayCallHideCluBeScanTips;

	private UIHudBeMarkredTipsController m_UIHudBeMarkredTipsController;

	private uint m_nDelayCallHideDetectiveScanBeMarkedTips;

	private UIHudDetectiveScanBeMarkedTipsController m_UIHudDetectiveScanBeMarkedTipsController;

	private UIHudDetectiveScanTipsController m_UIHudDetectiveScanTipsController;

	private uint m_nDelayCallHideDetectiveScanReadBar;

	private DetectiveScanReadBarState m_DetectiveScanReadBarState;

	private Queue<DetectiveScanReadBarState> m_DetectiveScanReadBarQueue;

	private const byte DetectiveScanStageFirst = 1;

	private const byte DetectiveScanStageThird = 3;

	private const float DetectiveScanWarningPriority = float.MaxValue;

	private const float DetectiveScanCounterDefaultDuration = 3f;

	private static bool s_DetectiveScanWarningShowing;

	private Dictionary<BHGGAEEHJCO, float> m_dicLastMarkTime;

	private Transform CachedTransform;

	private VisualInstanceHolder m_HintIconHolder;

	private Dictionary<uint, float> m_dicLastHintTime;

	private uint m_DelayCallHideSimpleHintGo;

	private float m_AuroraBoyTipsTime;

	public static bool IsDetectiveScanWarningShowing()
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClear(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void HideAllOtherHintIcon(bool forceDetectiveScanWarning = false)
	{
	}

	private void HideImmortalitySuccessKilledEffect()
	{
	}

	private void OnPlayerSkillImmortalitySuccessKilled()
	{
	}

	private ResourceID GetSkillUIEffect(int effectIndex)
	{
		return default(ResourceID);
	}

	private void OnHideImmortalityTimer()
	{
	}

	private void OnShowImmortalityTimer(object[] data)
	{
	}

	private void OnShowBeCluScanTips(object[] data)
	{
	}

	private void ShowCluBeScanTips(byte scanType)
	{
	}

	private void HideCluBeScanTips()
	{
	}

	private void OnDetectiveScanTipsNotify(object[] data)
	{
	}

	private void ShowDetectiveScanTips(byte enemyCount)
	{
	}

	private void HideDetectiveScanTips()
	{
	}

	private void OnDetectiveScanReadBarNotify(object[] data)
	{
	}

	private void OnDetectiveScanCounterNotify(object[] data)
	{
	}

	private bool TryConsumeDetectiveScanWarningForCounter(uint castPlayerID)
	{
		return false;
	}

	private void ShowDetectiveScanReadBar()
	{
	}

	private void HideDetectiveScanReadBar()
	{
	}

	private void OnDetectiveScanReadBarFinished()
	{
	}

	private bool ShowNextDetectiveScanReadBar()
	{
		return false;
	}

	private bool IsDetectiveScanWarningActive()
	{
		return false;
	}

	private bool HasDetectiveScanWarning()
	{
		return false;
	}

	private void SetDetectiveScanWarningShowing(bool showing)
	{
	}

	private void ShowDetectiveScanNormalTip(DetectiveScanBeMarkedTipsState state, float duration)
	{
	}

	private void PlayDetectiveScanNormalTipSound(DetectiveScanBeMarkedTipsState state)
	{
	}

	private void ShowDetectiveScanBeMarkedTips(DetectiveScanBeMarkedTipsState state, float duration, float elapsed = 0f)
	{
	}

	private void HideDetectiveScanBeMarkedTips()
	{
	}

	private void CancelDelayHideDetectiveScanBeMarkedTips()
	{
	}

	private bool IsDetectiveScanSkill(uint skillID)
	{
		return false;
	}

	private void ShowSimpleHintWithCdEventWrapper(object[] data)
	{
	}

	private void ShowSimpleHintWithCd(ResourceID hintResId, ResourceID sfxId, float duration, float hintCd, bool setTopPivotPos = true)
	{
	}

	private void ShowSimpleHintGo(ResourceID resId, float duration, bool setTopPivotPos = true)
	{
	}

	private void HideSimpleHintGo()
	{
	}

	private void OnHinderFail()
	{
	}

	private void ShowGeekSpiderBombFindEnemyTips(float lastTime)
	{
	}

	private void Show2NBGPShadowFindEnemyTips(float lastTime)
	{
	}

	private void ShowIIVTempleBeMarkedTip(float lastTime)
	{
	}

	private void ShowAuroraBoyTips(uint durationMilliSec, uint cdMilliSec)
	{
	}

	private void OnEnergyDeviceAward(uint awardID)
	{
	}

	public void OnHintShow()
	{
	}

	public void OnHintHide()
	{
	}

	public uint GetHintType()
	{
		return 0u;
	}

	public float GetHintPriority()
	{
		return 0f;
	}

	public bool IsHintShowing()
	{
		return false;
	}

	private void SFRolePlayerLocalPlayerBeReaper(object[] data)
	{
	}

	private void OnCarni25GPDanceDebuff(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
