using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraTemplatePanelController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public int curLevelCameraZoneId;

		public Predicate<int> _003C_003E9__0;

		internal bool _003CInitTemplateItems_003Eb__0(int x)
		{
			return false;
		}
	}

	public const uint VISIBILITY_STATE_CAMERAZOOMING = 1073741824u;

	public const uint VISIBILITY_STATE_VEDIO_REC = 536870912u;

	protected UIHudCameraTemplatePanelView m_View;

	protected UIHudCameraInGameController m_CameraInGameController;

	protected List<UIHudCameraTemplateItemController> m_AllTemplateItemControllerList;

	protected List<UIHudCameraTemplateItemController> m_CameraTemplateItemControllerList;

	protected List<UIHudCameraTemplateItemController> m_VedioTemplateItemControllerList;

	private UIHudCameraTemplateItemController m_CurSelectTemplateItem;

	private bool m_IsSelectPhotoTab;

	protected bool m_isPlayingVideoTemplate;

	private float m_VideoTemplateAlreadyPastTime;

	private float m_VideoTemplateStartTime;

	private float m_VideoTemplateDuration;

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

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public virtual void ResetAll()
	{
	}

	private void Update()
	{
	}

	public virtual void SetDefaultTab()
	{
	}

	protected virtual void InitTemplateItems()
	{
	}

	protected virtual UIHudCameraTemplateItemController GetItemCtrl(Transform transform)
	{
		return null;
	}

	private int SortTemplateItemGrid(Transform trA, Transform trB)
	{
		return 0;
	}

	public void SetCurSelectTemplateItem(UIHudCameraTemplateItemController chooseItem)
	{
	}

	public void OnChooseItem(UIHudCameraTemplateItemController chooseItem)
	{
	}

	private void OnTabSelectCallback(UIToggleButton btn)
	{
	}

	private void OnCameraStateChanged(int eCameraState)
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

	private void OnVideoTemplateStartPlay(float duration)
	{
	}

	private void OnVideoTemplatePaused(float pausedTime)
	{
	}

	private void OnVideoTemplateContinuePlay(float continueTime)
	{
	}

	private void OnVideoTemplateFinished(float finishedTime)
	{
	}

	private void OnChoosePhotoTemplate(uint templateID)
	{
	}

	private void RefreshVideoTemplateProgress()
	{
	}

	private void SetVideoTemplateProgress(float pastTime)
	{
	}

	protected virtual void SwitchTab(bool isPhoto)
	{
	}

	protected virtual void OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
