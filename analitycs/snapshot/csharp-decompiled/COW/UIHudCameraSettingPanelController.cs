using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraSettingPanelController : UIBaseController
{
	public const uint VISIBILITY_STATE_CAMERAZOOMING = 1073741824u;

	public const uint VISIBILITY_STATE_VEDIO_REC = 536870912u;

	private UIHudCameraSettingPanelView m_View;

	private bool m_CanSetEnemyVisibility;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	private void RefreshSettingState()
	{
	}

	public override void Hide()
	{
	}

	private void OnOwnShieldToggleChanged()
	{
	}

	private void OnTeammateShieldToggleChanged()
	{
	}

	private void OnEnemyShieldToggleChanged()
	{
	}

	private void OnOpacitySliderChanged()
	{
	}

	private void OnSliderPress(GameObject go, bool isPressed)
	{
	}

	private void OnCameraModeZooming(bool isZooming)
	{
	}

	private void OnVedioRecordBeforeStart(int sec)
	{
	}

	private void OnVedioRecordBeforeStartEnd(bool isSuccessStart)
	{
	}

	private void OnCameraStateChanged(int state)
	{
	}

	private void OnBtnCloseClick()
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
}
