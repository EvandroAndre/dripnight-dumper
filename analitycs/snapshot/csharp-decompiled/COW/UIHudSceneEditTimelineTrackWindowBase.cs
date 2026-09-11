using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIHudSceneEditTimelineTrackWindowBase : UIPopupWindowController
{
	protected UIHudSceneEditTimelineSubTrackMgrPanelController m_SubTrackMgr;

	protected UIHudSceneEditTimelineLeftOptionController m_LeftOptionCtrl;

	protected UIHudSceneEditTimelineInspectorController m_InspecotrCtrl;

	protected UGCTimelineEditorTrackBaseWarp m_SelectTrack;

	protected UIPopMenuSmallControler m_TrackPopMenu;

	protected List<PopMenuData> mPopMenuDataList;

	protected UIHudSceneEditTimelineResMgrPanelController m_ResMgrPanelController;

	protected Coroutine m_ScrollToCoroutine;

	private bool _003CIsClipDragging_003Ek__BackingField;

	private ulong m_StartPauseTime;

	protected uint m_PauseTime;

	protected BJJBCNEJPEF m_LastCameraMode;

	protected UIHudSceneEditTimelineTrackController.KeyBase m_selectedKeyClip;

	public abstract UIButton Play { get; }

	public abstract UIButton Pause { get; }

	public abstract UILabel Time { get; }

	public abstract GameObject TrackMenu { get; }

	public abstract UIButton PrevFrame { get; }

	public abstract UGCTimelineTickHeader Header { get; }

	public abstract UGCTimelineScrollView TrackScrollView { get; }

	public abstract UIPanel Panel { get; }

	public abstract UILabel LeftPlayheadTime { get; }

	public abstract UILabel RightPlayheadTime { get; }

	public abstract Transform LeftPlayhead { get; }

	public abstract Transform RightPlayhead { get; }

	public abstract UILabel LeftDiffTime { get; }

	public abstract UILabel RightDiffTime { get; }

	public abstract UIWidget LeftAutoMoveArea { get; }

	public abstract UIWidget RightAutoMoveArea { get; }

	protected SceneEditAgent m_Agent => null;

	protected bool IsObjectEditing => false;

	protected bool IsClipDragging
	{
		get
		{
			return _003CIsClipDragging_003Ek__BackingField;
		}
		set
		{
			_003CIsClipDragging_003Ek__BackingField = value;
		}
	}

	private HNDHJGJILHC m_SceneEditGame => null;

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected void RefreshLeftFilterPopMenu()
	{
	}

	protected virtual void OnTrackPopMenuSelected(object value)
	{
	}

	protected void SetSelectedSceneEditObj(UGCTimelineEditorTrackBaseWarp track)
	{
	}

	private void OnExitTimelineModeHandler(object[] data)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void OnLateUpdate()
	{
	}

	protected void OnClickPlayButton()
	{
	}

	protected void RefreshPlayButton()
	{
	}

	protected void ForceGotoHeaderTime(float time, bool needGoto = true)
	{
	}

	protected void ForceRefreshHeaderTime(bool needGoto = true)
	{
	}

	public virtual void SetViewData()
	{
	}

	protected void OnTimelineShowItemMgrHandler(object[] data)
	{
	}

	protected virtual void OnSceneEditSelectedObjectHandler()
	{
	}

	protected void HideInspector()
	{
	}

	protected void ShowInspector()
	{
	}

	protected void RefreshInspectorState()
	{
	}

	protected void OnShowSubTrackMgrHandler(object[] data)
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	protected virtual void OnRefreshSubTrackHandler(object[] data)
	{
	}

	private void OnOpenMoreSettingAppear(object[] data)
	{
	}

	private void OnCloseMoreSettingAppear(object[] data)
	{
	}

	protected virtual void OnClickNextFrameHandler()
	{
	}

	protected virtual void OnClickPrevFrameHandler()
	{
	}

	protected virtual void OnClickRecordingHandler()
	{
	}

	protected void OnTimelineShowContentHandler(object[] data)
	{
	}

	protected void RefreshSceneEditSelected()
	{
	}

	protected void ShowMutexRightView(UIPopupWindowController controller)
	{
	}

	protected virtual void UpdateLeftPlayHead(float leftPos, float leftDiff)
	{
	}

	protected virtual void UpdateRightPlayHead(float rightPos, float rightDiff)
	{
	}

	protected virtual void OnRefreshOnPressSideBarandler(object[] data)
	{
	}

	protected virtual void OnRefreshOnPressKeyFrameHandler(object[] data)
	{
	}

	protected virtual void OnRefreshOnPressClipHandler(object[] data)
	{
	}

	protected virtual void OnRefreshDragSideBarHandler(object[] data)
	{
	}

	protected virtual void OnRefreshDragKeyFrameHandler(object[] data)
	{
	}

	protected virtual void OnRefreshDragClipHandler(object[] data)
	{
	}

	private void OnRefreshKeyFrameValueHandler(object[] data)
	{
	}

	protected virtual void RefreshTimelineFPVMode()
	{
	}

	protected bool IsPointInWidget(Vector2 screenPoint, UIWidget widget)
	{
		return false;
	}

	protected virtual void CheckInAutoMoveArea()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
