using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPreparationTimerController : UIBaseController
{
	private UIHudPreparationTimerView m_View;

	private float m_StartTime;

	private float m_TotalTime;

	private EPreparationTimerType m_ContextType;

	private float m_Stage1Time;

	private AudioResource m_medKitLoopAudio;

	private AudioResource m_shieldRecoverLoopAduio;

	private AudioResource m_personalShopLoopAudio;

	private AudioResource m_teamBuffSupporterLoopAudio;

	private AudioResource m_reinforcedAnvilLoopAudio;

	private AudioResource m_rmdEatFoodLoopAudio;

	private AudioResource m_hippoCrisisOpenBoxLoopAudio;

	private uint m_UsingInteractableLvObjID;

	private object m_ContextParam1;

	private object m_ContextParam2;

	private BHGGAEEHJCO m_CurrentObserverID;

	private bool m_IsPrepareFinished;

	private UInt128 m_PreUIGroup;

	private uint m_UpgradeWeaponUID;

	private int m_LastTimeLabelTenths;

	private float m_CurrentProgressSpeed;

	private float m_CurrentProgressRate;

	private GameObject m_PreparationSound;

	private GameObject m_EatSeafoodCookieSound;

	private AudioResource m_OpenTreasureHuntSound;

	private GameObject m_EatInfiniteCakeSound;

	private bool m_EatNoodleStartOnCabinPhase;

	public EPreparationTimerType ContextType => EPreparationTimerType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void ResetTimeLabelCache()
	{
	}

	private void RefreshTimeLabel(float remainingTime)
	{
	}

	private void Update()
	{
	}

	private void UpdateProgressType()
	{
	}

	private void OnProgressRateChanged(object[] param)
	{
	}

	private void OnProgressSpeedChanged(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnPreparationStart(object[] param)
	{
	}

	private bool UseInhalerLikeItem()
	{
		return false;
	}

	private void OnPreparationNewCancel(object[] param)
	{
	}

	private void OnPreparationCancel(GEvent param)
	{
	}

	private void OnCancel(object[] param)
	{
	}

	private void OnPreparationEnd(object[] param)
	{
	}

	private void RefreshActionHudForCurrentTriggerAfterMedkit()
	{
	}

	private void OnPlayerCancelUseItem(object[] param)
	{
	}

	private void OnPreparationRecordWeaponUID(uint uid)
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] param)
	{
	}

	private void OnPlayerRemoveBomb(object[] param)
	{
	}

	private void DoCancelUse(bool stopall = true, bool isCancelBtn = false)
	{
	}

	private void ClearData()
	{
	}

	private bool HasValidData()
	{
		return false;
	}

	private bool IsCustomProgressType()
	{
		return false;
	}

	private bool IsProgressType()
	{
		return false;
	}

	private bool CannotInterrupted()
	{
		return false;
	}

	private bool CannotRetry()
	{
		return false;
	}

	private bool CanSimulationFinish()
	{
		return false;
	}

	private void OnDecreaseInPreparation(GEvent evt)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnRoomOBIsCamTypeFree(bool isFree)
	{
	}

	private bool TryClearInRoomOBFreeCam()
	{
		return false;
	}

	private void StopPreparationSounds()
	{
	}

	private void OnDisable()
	{
	}

	private bool IsUsingMedkitLikeItem()
	{
		return false;
	}

	private void TryStopPlayShieldRecoverLoopSound()
	{
	}

	private void TryStopPlayRMDEatFoodLoopSound()
	{
	}

	private void TryStopUsePersonalShopSound()
	{
	}

	private void TryStopUseTeamBuffSupporterSound()
	{
	}

	private void TryStopUseReinforcedAnvilSound()
	{
	}

	private void TryStopHippCrisisOpenBoxSound()
	{
	}

	private void OnLittleGirlStateChange(object[] datas)
	{
	}

	private void HandleLittleGirlStateChange(LevelSeafoodLittleGirl littleGirl)
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void SetCancelBtnActive()
	{
	}

	public void SendHoldLevelObjectMessage(uint uid, OPICPDCLKAG lvType, bool isStart)
	{
	}

	private EJDJBFFBLLM GetLocalPacemakerStatus()
	{
		return null;
	}

	private float GetAssistedTimeForPacemaker()
	{
		return 0f;
	}

	private float GetRemainingTimeForPacemaker()
	{
		return 0f;
	}

	private void InitPacemakerAcceleratePanelDepth()
	{
	}

	private void ShowPacemakerWithAssistEffect(bool show, float progress)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
