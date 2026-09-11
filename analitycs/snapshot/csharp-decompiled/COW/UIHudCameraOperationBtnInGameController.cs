using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraOperationBtnInGameController : UIHudCameraOperationBtnController
{
	private const float VEDIO_REC_BTN_OFFEST_POS_Y = -0.29f;

	private uint _003CStartVedioDelayCallID_003Ek__BackingField;

	private bool m_IsForbidZoom;

	private UIHudCameraInGameController m_CameraInGameController;

	private bool m_IsStartRecordWithVideoTemplate;

	private bool m_IsSyncingZoom;

	private Camera m_UIRootMatchScreenshotCamera;

	private bool m_UIRootMatchScreenshotCameraEnabledState;

	private bool m_HasUIRootMatchScreenshotCameraState;

	public uint StartVedioDelayCallID
	{
		get
		{
			return _003CStartVedioDelayCallID_003Ek__BackingField;
		}
		private set
		{
			_003CStartVedioDelayCallID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnAdjustingStateChanged(bool isAdjusting)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void ResetWhenVerticalCameraModeChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void OnTakePhoto()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetUIRootMatchVisibleForScreenshot(bool visible)
	{
	}

	protected void OnVedioStart()
	{
	}

	protected void OnVedioEnd()
	{
	}

	private void CancelVedioStartDelayCall()
	{
	}

	private void RealVedioStart()
	{
	}

	protected override void OnZoomChanged(float newVal)
	{
	}

	private void OnZoomOffsetConstrained(float constrainedZoomCoefficient)
	{
	}

	private void OnCameraTypeChanged(int oldType, int newType)
	{
	}

	private void OnPhotoTemplateParamReset()
	{
	}

	private void OnTemplateTabChanged(bool isPhoto)
	{
	}

	private void OnChooseTemplate(bool isChoose)
	{
	}

	public void RefreshScrollContainerVisible(int newCameraCtrlType = -1)
	{
	}

	private void OnVideoTemplateFinished(float finishedTime)
	{
	}

	protected override void RefreshMainBtn(ECameraState state)
	{
	}

	protected override void OnMainBtnClick()
	{
	}

	protected override void OnSideBtnClick()
	{
	}

	public override void ResetAll()
	{
	}

	protected override void OnScrollContainerPress(GameObject go, bool isPressed)
	{
	}

	protected override bool IsRecordVideoAvailable()
	{
		return false;
	}

	protected override void OnSaveRecordCallback(bool result, string message)
	{
	}

	private void ShowCameraModePopupMessage(string message)
	{
	}

	public void SetPortraitView(bool isPortrait)
	{
	}

	private void RegisterHeightSliderEvents()
	{
	}

	private void OnHeightSliderDragStart()
	{
	}

	private void OnHeightSliderDragEnd()
	{
	}

	public void ShowCameraHeightGuide(Action onComplete = null)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAdjustingStateChanged(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_Show()
	{
	}

	public new void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnZoomChanged(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMainBtn(ECameraState P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnMainBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSideBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetAll()
	{
	}

	public void _003C_003EiFixBaseProxy_OnScrollContainerPress(GameObject P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsRecordVideoAvailable()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnSaveRecordCallback(bool P0, string P1)
	{
	}
}
