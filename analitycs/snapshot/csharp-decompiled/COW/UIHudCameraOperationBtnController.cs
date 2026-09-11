using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using VoxelBusters.ReplayKit;

namespace COW;

public class UIHudCameraOperationBtnController : UIBaseController
{
	protected enum EAdjustingControl
	{
		None,
		ZoomWheel,
		RotationWheel,
		HeightSlider
	}

	public enum ECameraState
	{
		None,
		Photo,
		Vedio,
		VedioREC
	}

	private const int MAX_ZOOM_LABLE_NUM = 9;

	private const float ZOOM_LABLE_VAL_STEP = 0.5f;

	private const float DELTA_ZOOM_2_ROTATE_ANGLE_RATIO = 60f;

	private const float DELTA_ROTATION_2_ROTATE_ANGLE_RATIO = 1f;

	private const float ALPHA_ACTIVE = 1f;

	private const float ALPHA_INACTIVE = 0.5f;

	private const float ALPHA_Hide = 0.01f;

	private const float DEFAULT_FREEVIEW_CLOSE_MAX = 0.5f;

	private const float DEFAULT_FREEVIEW_FAR_MAX = 2f;

	protected EAdjustingControl m_CurrentAdjustingControl;

	protected bool IsReplayKitInitialise;

	private float m_CurScrollDragInvalidDelta;

	private GameObject m_ZoomAudioGo;

	protected float m_CurZoomVal;

	private List<float> m_NeedVibrationScaleVals;

	private List<GameObject> m_ZoomLabelGos;

	private GameObject m_AdjustAudioGo;

	protected UIHudCameraOperationBtnView m_View;

	protected float m_StartRecordTime;

	protected int m_RecordDuringSec;

	private StringBuilder m_Timer;

	private ECameraState _003CCameraState_003Ek__BackingField;

	private bool IsReplayKitInit;

	private float m_LastHeightOffset;

	public ECameraState CameraState
	{
		get
		{
			return _003CCameraState_003Ek__BackingField;
		}
		set
		{
			_003CCameraState_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected void InitReplayKit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public virtual void ResetAdjustingControl()
	{
	}

	public virtual void ResetAll()
	{
	}

	protected virtual void OnMainBtnClick()
	{
	}

	protected virtual int GetVedioRecordSec()
	{
		return 0;
	}

	protected virtual void OnScrollContainerPress(GameObject go, bool isPressed)
	{
	}

	private void OnBigScrollTweenOutFinished()
	{
	}

	private void Update()
	{
	}

	protected virtual void RefreshMainBtn(ECameraState state)
	{
	}

	protected void UpdateRecordTimeLable(int seconds)
	{
	}

	protected virtual void OnSideBtnClick()
	{
	}

	protected void RefreshSideBtn()
	{
	}

	protected virtual void RefreshVedioBtnState()
	{
	}

	private void OnInitialiseCallback(ReplayKitInitialisationState state, string message)
	{
	}

	private void OnStartRecordCallback(bool result, string message)
	{
	}

	private void OnStopRecordCallback(bool result, string message)
	{
	}

	private void OnRecordAvailableCallback(bool result, string message)
	{
	}

	protected virtual void OnSaveRecordCallback(bool result, string message)
	{
	}

	protected virtual bool IsRecordVideoAvailable()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	protected virtual void OnScrollContainerDrag(GameObject go, Vector2 delta)
	{
	}

	private int GetMiddleVibrationScaleIndex(float oldzoomVal, float newZoomVal)
	{
		return 0;
	}

	public void InitZoomLables()
	{
	}

	protected virtual void InitZoom()
	{
	}

	public virtual void RefreshZoom(float newValue)
	{
	}

	protected virtual void OnZoomChanged(float newVal)
	{
	}

	protected virtual float GetZoomBase()
	{
		return 0f;
	}

	protected virtual float GetZoomMin()
	{
		return 0f;
	}

	protected virtual float GetZoomMax()
	{
		return 0f;
	}

	protected virtual void InitHeightSlider()
	{
	}

	private void OnHeightSliderChanged()
	{
	}

	protected virtual void RefreshHeightLabel()
	{
	}

	public void SetHeightSliderVisible(bool isVisible)
	{
	}

	protected void SetAdjustingControl(EAdjustingControl adjustingControl)
	{
	}

	protected virtual void OnAdjustingStateChanged(bool isAdjusting)
	{
	}

	public void SetOperationPanelAlpha(float alpha)
	{
	}

	private void UpdateWheelControlsVisualState()
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

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
