using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraInGameController : UIBaseController
{
	public enum ECameraInGamePortraitPanelType
	{
		None,
		Emote,
		Template,
		Setting,
		Filter
	}

	private bool m_HasFreeViewInteraction;

	private bool m_IsHudHidden;

	private const float HUD_HIDDEN_ALPHA = 0.01f;

	private const float HUD_VISIBLE_ALPHA = 1f;

	private const float PARENT_ALPHA_NORMAL = 1f;

	private const float PARENT_GRID_ALPHA_ADJUSTING = 0.01f;

	private const float PARENT_FIXED_ALPHA_ADJUSTING = 0.5f;

	private UIHudCameraInGameView m_View;

	private UIHudFireView m_FireView;

	private UIHudCameraOperationBtnInGameController m_OperateBtnController;

	private UIHudCameraEmotePanelController m_EmotePanelController;

	private UIHudCameraTemplatePanelController m_TemplatePanelController;

	private UIHudCameraTemplatePortraitPanelController m_TemplatePortraitPanelController;

	private UIHudCameraSettingPanelController m_SettingPanelController;

	private UIHudCameraVedioCountDownController m_VedioCountDownController;

	private UITakePhotoFilterController m_FilterCtrl;

	private TutorialEventEnum m_WaitingForInputGuideType;

	private bool m_IsCheckingJoystickInput;

	public IBMJOHLIAFO CurrentFixedMode => IBMJOHLIAFO.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public int GetCurFilterId()
	{
		return 0;
	}

	public int GetCurFilterPrimaryId()
	{
		return 0;
	}

	public static uint GetCurLevelCameraZoneId()
	{
		return 0u;
	}

	private void OnFilterBtnClick()
	{
	}

	public override void Show()
	{
	}

	private void HandleFreeViewCameraExit()
	{
	}

	private void ChangeToFreeViewCamera(bool enable)
	{
	}

	private void MarkFollowEmoteCameraResetOnFreeViewExit(CameraControllerManager cameraManager)
	{
	}

	public override void Hide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshBtnsVisible(bool isStartREC = false)
	{
	}

	private bool ShouldForceHideVerticalBtn()
	{
		return false;
	}

	private void ForceHideVerticalBtnIfNeeded()
	{
	}

	private void RepositionButtonLayout()
	{
	}

	public void SetUIButtonsAlphaWhenAdjusting(bool isAdjusting)
	{
	}

	private void SetUIButtonsAlpha(float alpha)
	{
	}

	private void SetCameraModeBtnsInteractable(bool interactable)
	{
	}

	private void SwitchUIGroupByFixedMode()
	{
	}

	private void SetMovingJoystickMainPhotoVisible(bool isVisible)
	{
	}

	private bool IsPlayerInSkyDiving()
	{
		return false;
	}

	private bool IsPlayerInSitting()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void StopAllCameraTutorials()
	{
	}

	private void OnBtnEmoteClick()
	{
	}

	private void DoShowEmotePanel()
	{
	}

	private void DoShowFilterPanel()
	{
	}

	private void OnBtnTemplateClick()
	{
	}

	private void DoShowTemplatePanel()
	{
	}

	private void OnBtnSettingClick()
	{
	}

	private void DoShowSettingPanel()
	{
	}

	private void OnBtnQuitClick()
	{
	}

	private void OnBtnFixedCameraClick()
	{
	}

	private void OnBtnFixedCharacterClick()
	{
	}

	private void OnBtnDefaultCameraClick()
	{
	}

	private void OnBtnHideHudClick()
	{
	}

	private void SetHudHidden(bool isHidden)
	{
	}

	private void UpdateHideHudBtnIcon()
	{
	}

	private void SetUIButtonsInteractable(bool interactable)
	{
	}

	private void SetFixedModeView(IBMJOHLIAFO mode)
	{
	}

	private void OnFreeViewModeChanged(bool isInFreeViewMode)
	{
	}

	private void SetFreeCameraView(bool isInFreeViewMode)
	{
	}

	public void SetVisibleEmotePanel(bool isShow)
	{
	}

	public void SetVisibleTemplatePanel(bool isShow)
	{
	}

	public void SetVisibleSettingPanel(bool isShow)
	{
	}

	private void OnCameraModeZooming(bool isZooming)
	{
	}

	private void OnVedioRecordBeforeStart(int sec)
	{
	}

	private void OnVedioRecordBeforeStartEnd(bool isStartSuccess)
	{
	}

	private void OnCameraStateChanged(int state)
	{
	}

	private void OnPlayerPhysXStateChange(uint playerId)
	{
	}

	private void OnVideoTemplateStart(float duration)
	{
	}

	public UIHudCameraOperationBtnController.ECameraState GetCurCameraState()
	{
		return UIHudCameraOperationBtnController.ECameraState.None;
	}

	public List<int> GetCurPlaylistIDs()
	{
		return null;
	}

	public Vector3 GetQuitBtnPos()
	{
		return default(Vector3);
	}

	private void OnQuitBtnVerticalClick()
	{
	}

	private void OnBtnVerticalClick(bool showVertical)
	{
	}

	public void OnVerticalCameraModeChanged(bool showVertical)
	{
	}

	public void ChangeToVerticalDefaultTemplate()
	{
	}

	private void ClearCurrentAxisData()
	{
	}

	private bool CheckCurCanEnterVerticalCameraMode()
	{
		return false;
	}

	private void SetPortraitView(bool showVertical)
	{
	}

	private void OnBtnEmotePortraitClick()
	{
	}

	private void OnBtnFilterPortraitClick()
	{
	}

	public void SetVisibleFilterPanelPortrait(bool isShow)
	{
	}

	public void SetVisibleFilterPanel(bool isShow)
	{
	}

	public void SetVisibleEmotePanelPortrait(bool isShow)
	{
	}

	private void OnBtnSettingPortraitClick()
	{
	}

	private void SetVisibleSettingPanelPortrait(bool isShow)
	{
	}

	private void OnBtnTemplatePortraitClick()
	{
	}

	public void SetVisibleTemplatePanelPortrait(bool isShow)
	{
	}

	private void DoShowPortraitPanel(ECameraInGamePortraitPanelType panelType)
	{
	}

	private void OnFixedModeDistanceWarning(bool show)
	{
	}

	private void OnFixedModeExceedLimit(bool exceed)
	{
	}

	private void ShowCameraWarningTips(string message, float duration, Color color)
	{
	}

	private void HideCameraWarningTips()
	{
	}

	private void ShowFixedCameraModeGuide()
	{
	}

	private void ShowFixedCharacterModeGuide()
	{
	}

	private void ShowFixedCharacterJoystickGuide()
	{
	}

	private void StartWaitingForJoystickInput(TutorialEventEnum guideType)
	{
	}

	private void StopWaitingForJoystickInput()
	{
	}

	private void Update()
	{
	}

	private void CheckJoystickInputForGuide()
	{
	}

	private void ShowFilterGuide()
	{
	}

	private void OnFreeModeLeftJoystickTouched()
	{
	}

	public void MarkFreeViewInteraction()
	{
	}

	public bool HasUsedFreeViewCamera()
	{
		return false;
	}

	private void ResetFreeViewInteraction()
	{
	}

	private void _003COnUIInit_003Eb__20_0()
	{
	}

	private void _003COnUIInit_003Eb__20_1()
	{
	}

	private void _003CShowFixedCharacterModeGuide_003Eb__97_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
