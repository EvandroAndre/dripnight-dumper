using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UGC_CommonHudSwitchController
{
	public enum EPlayerHudSwitchType
	{
		MovementHUD,
		SprintHUD,
		AttackHUD,
		JumpHUD,
		KillingTipsHUD,
		WeaponHUD,
		MinMapHUD,
		BagHUD,
		MedicalPropsHUD,
		CrouchHUD,
		CreepHUD,
		TeammatesInfoHUD,
		AttackGrenadeHUD,
		DefenceGrenadeHUD,
		EmotionHUD,
		QuickChatHUD,
		PickupListHUD,
		QuickChatShowHUD,
		HPItemHUD,
		EPItemHUD,
		ArmorHUD,
		ReloadBtnHUD,
		SweapWeaponQuickBtnHUD,
		SpeakerBtnHUD,
		MicroPhoneBtnHUD,
		MarkBtnHUD,
		SettingsBtnHUD,
		SignalIcoHUD,
		ActiveSkillBtnHUD,
		CrosshairsHUD,
		PassiveSkillHUD,
		FPPInspectionHUD,
		HelpUpHud,
		RescueHud,
		Attack2Hud,
		CombineWeaponHud,
		SwimmingSurfHud,
		ActionHud,
		TakePhotoHud,
		PullThePin
	}

	public enum ESwitchValue
	{
		Original = -1,
		Close,
		Show
	}

	private Dictionary<int, List<UIBaseController>> m_CommonHuds;

	private Dictionary<int, Action<ESwitchValue>> m_CommonHudsFun;

	private UGCCommonHudSwitchControllerRepItem m_LogicComponent;

	public void SetEntityID(string entityID)
	{
	}

	public void RenewSpeakerBtnHUD()
	{
	}

	public void RenewMicroPhoneBtnHUD()
	{
	}

	public void DestroyEntity()
	{
	}

	public void BindHud(EPlayerHudSwitchType hudType, UIBaseController hud)
	{
	}

	public void BindHudFun(EPlayerHudSwitchType hudType, Action<ESwitchValue> hudFun)
	{
	}

	public GameObject GetCommonHud(int target)
	{
		return null;
	}

	private void SetHudVisibility(EPlayerHudSwitchType hudType, int switchValue)
	{
	}

	private void OnCrouchSwitchChangeEvent(int switchValue)
	{
	}

	private void OnCreepSwitchChangeEvent(int switchValue)
	{
	}

	private void OnJumpSwitchChangeEvent(int switchValue)
	{
	}

	private void OnFireSwitchChangeEvent(int switchValue)
	{
	}

	private void OnMovingJoystickSwitchChangeEvent(int switchValue)
	{
	}

	private void OnTeammatesInfoSwitchChangeEvent(int switchValue)
	{
	}

	private void OnAttackGrenadeSwitchChangeEvent(int switchValue)
	{
	}

	private void OnDefenceGrenadeSwitchChangeEvent(int switchValue)
	{
	}

	private void OnSpeedupSwitchChangeEvent(int switchValue)
	{
	}

	private void OnKillingTipsSwitchChangeEvent(int switchValue)
	{
	}

	private void OnWeaponHUDSwitchChangeEvent(int switchValue)
	{
	}

	private void OnMinMapHUDSwitchChangeEvent(int switchValue)
	{
	}

	private void OnBagHUDSwitchChangeEvent(int switchValue)
	{
	}

	private void OnMedicalPropsHUDSwitchChangeEvent(int switchValue)
	{
	}

	private void OnEmotionHUDChangeEvent(int switchValue)
	{
	}

	private void OnQuickChatHUDChangeEvent(int switchValue)
	{
	}

	private void OnPickupListHUDChangeEvent(int switchValue)
	{
	}

	private void OnQuickChatShowHUDChangeEvent(int switchValue)
	{
	}

	private void OnHPItemHUDChangeEvent(int switchValue)
	{
	}

	private void OnEPItemHUDChangeEvent(int switchValue)
	{
	}

	private void OnArmorHUDChangeEvent(int switchValue)
	{
	}

	private void OnReloadBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnSweapWeaponQuickBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnSpeakerBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnMicroPhoneBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnMarkBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnSettingsBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnSignalIcoHUDChangeEvent(int switchValue)
	{
	}

	private void OnActiveSkillBtnHUDChangeEvent(int switchValue)
	{
	}

	private void OnCrosshairsHUDChangeEvent(int switchValue)
	{
	}

	private void OnPassiveSkillHUDChangeEvent(int switchValue)
	{
	}

	private void OnFPPInspectionHUDChangeEvent(int switchValue)
	{
	}

	private void OnHelpUpHudChangeEvent(int switchValue)
	{
	}

	private void OnRescureHudChangeEvent(int switchValue)
	{
	}

	private void OnAttack2HudChangeEvent(int switchValue)
	{
	}

	private void OnCombineWeaponHudChangeEvent(int switchValue)
	{
	}

	private void OnSwimmingSurfHudChangeEvent(int switchValue)
	{
	}

	private void OnActionHudChangeEvent(int switchValue)
	{
	}

	private void OnTakePhotoHudChangeEvent(int switchValue)
	{
	}

	private void OnPullThePinChangeEvent(int switchValue)
	{
	}
}
