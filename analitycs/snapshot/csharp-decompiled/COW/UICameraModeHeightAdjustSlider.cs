using System;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UICameraModeHeightAdjustSlider : UISlider
{
	private float m_MinHeight;

	private float m_MaxHeight;

	private bool m_IsSyncing;

	private bool m_IsDragging;

	private UILabel m_HeightLabel;

	private CameraControllerManager m_CameraManager;

	private float m_LastHeightOffset;

	private float m_LastUpdateTime;

	private const float MAX_HEIGHT_CHANGE_PER_SECOND = 15f;

	public Action OnDragStartCallback;

	public Action OnDragEndCallback;

	protected override void OnStart()
	{
	}

	private new void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private new void Update()
	{
	}

	protected override void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	protected new void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	private void OnDragStart()
	{
	}

	private void OnDragEnd()
	{
	}

	private void EndDragInternal()
	{
	}

	private void OnSliderValueChanged()
	{
	}

	public void SetHeightLabel(UILabel label)
	{
	}

	private void ApplySpeedLimit()
	{
	}

	private void RestoreRotateInput()
	{
	}

	private void SyncSliderFromCamera()
	{
	}

	private void ForceSyncSliderPositionFromCamera()
	{
	}

	private void UpdateLabelText(float heightOffset)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPressBackground(GameObject P0, bool P1)
	{
	}
}
