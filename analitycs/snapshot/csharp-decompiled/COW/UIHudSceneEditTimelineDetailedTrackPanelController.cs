using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineDetailedTrackPanelController : UIHudSceneEditTimelineTrackWindowBase
{
	private class UITrackHandler
	{
		private UIHudSceneEditTimelineTrackTitleController trackTitle;

		private UIHudSceneEditTimelineTrackController track;

		private UGCTimelineEditorTrackBaseWarp _003CtrackBaseWarp_003Ek__BackingField;

		private bool _003CIsShow_003Ek__BackingField;

		public UGCTimelineEditorTrackBaseWarp trackBaseWarp
		{
			get
			{
				return _003CtrackBaseWarp_003Ek__BackingField;
			}
			private set
			{
				_003CtrackBaseWarp_003Ek__BackingField = value;
			}
		}

		public bool IsShow
		{
			get
			{
				return _003CIsShow_003Ek__BackingField;
			}
			private set
			{
				_003CIsShow_003Ek__BackingField = value;
			}
		}

		public UITrackHandler(UIHudSceneEditTimelineTrackTitleController title, UIHudSceneEditTimelineTrackController track)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetTrackData(UGCTimelineEditorTrackBaseWarp trackBaseWarp, float tickInterval)
		{
		}

		public void RefreshData()
		{
		}

		public void SetSelectTrack(UGCTimelineEditorTrackBaseWarp trackWarp)
		{
		}

		public void SetUICallback(Action<UGCTimelineEditorTrackBaseWarp, UGCTimelineEditorKeyBase> action)
		{
		}

		public void SetExpandSubTrack(bool expand)
		{
		}

		public void CheckSelectKeyFrame(float time)
		{
		}

		public bool TryGetScopeKeyFrame(float time, float scope, out UGCTimelineEditorKeyBase keyFrameData)
		{
			keyFrameData = null;
			return false;
		}

		public UIHudSceneEditTimelineTrackController GetController(UGCTimelineEditorTrackBaseWarp targetWarp)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool> _003C_003E9__69_0;

		internal void _003COnClickAddKeyClipHandler_003Eb__69_0(bool v)
		{
		}
	}

	private sealed class _003CScrollViewToTrack_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCTimelineEditorTrackBaseWarp trackWarp;

		public UIHudSceneEditTimelineDetailedTrackPanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollViewToTrack_003Ed__79(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected Dictionary<uint, UIButton> m_ButtonMaps;

	protected Dictionary<uint, UISprite> mButtonIconMaps;

	private UIHudSceneEditTimelineDetailedTrackPanelView m_View;

	private RenderTexture m_renderTexture;

	private Camera m_MainCamera;

	private new BJJBCNEJPEF m_LastCameraMode;

	private List<UITrackHandler> m_UITracks;

	public override UIButton Play => null;

	public override UIButton Pause => null;

	public override UILabel Time => null;

	public override GameObject TrackMenu => null;

	public override UIButton PrevFrame => null;

	public override UGCTimelineTickHeader Header => null;

	public override UGCTimelineScrollView TrackScrollView => null;

	public override UIPanel Panel => null;

	public override UILabel LeftPlayheadTime => null;

	public override UILabel RightPlayheadTime => null;

	public override Transform LeftPlayhead => null;

	public override Transform RightPlayhead => null;

	public override UILabel LeftDiffTime => null;

	public override UILabel RightDiffTime => null;

	public override UIWidget LeftAutoMoveArea => null;

	public override UIWidget RightAutoMoveArea => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnLateUpdate()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnExitTimelineModeHandler(object[] data)
	{
	}

	private void InitCameraRenderToTexture()
	{
	}

	public override void SetViewData()
	{
	}

	private void RefreshTrackView()
	{
	}

	private void OnRefreshTimelineEndTime(object[] data)
	{
	}

	private void OnToolbarStateChangedHandler(object[] data)
	{
	}

	private void RefreshToolBar()
	{
	}

	private void SetButtonState(SceneEditItemAdjust.ButtonState buttonIdx, SceneEditItemAdjust.State state)
	{
	}

	private void OnReposition()
	{
	}

	private void DisableToolBar()
	{
	}

	private void EnabelToolBar()
	{
	}

	private void OnSwitchCameraMuteHandler()
	{
	}

	protected override void OnClickRecordingHandler()
	{
	}

	private void Refresh()
	{
	}

	private void OnClickHintButton()
	{
	}

	private void OnClickBackHandler()
	{
	}

	private void OnClickPerformanceHandler()
	{
	}

	private void OnClickCloseHandler()
	{
	}

	private void OnClickFPVHandler()
	{
	}

	private void OnClickSettingHandler()
	{
	}

	private void OnClickAddSubTrackHandler()
	{
	}

	private void OnClickDelTrackHandler()
	{
	}

	public void OnClickKeyFrameHandler(UGCTimelineEditorTrackBaseWarp trackBaseWarp, UGCTimelineEditorKeyBase frameData)
	{
	}

	private void OnClickAddKeyClipHandler()
	{
	}

	private void OnClickDelKeyClipHandler()
	{
	}

	private void OnClickAddKeyFrameHandler()
	{
	}

	private void OnClickDelKeyFrameHandler()
	{
	}

	protected void OnTrackContainerDragStarted()
	{
	}

	protected void OnTrackContainerDragMoveing()
	{
	}

	private void RefreshTrackKeyFrame()
	{
	}

	protected void OnTrackContainerDragFinished()
	{
	}

	protected override void OnTrackPopMenuSelected(object value)
	{
	}

	protected void OnSelectTrackHandler(object[] data)
	{
	}

	private IEnumerator ScrollViewToTrack(UGCTimelineEditorTrackBaseWarp trackWarp)
	{
		return null;
	}

	private void SetSelectedTrack(UGCTimelineEditorTrackBaseWarp track)
	{
	}

	protected void OnTimelineDelTrackHandler(object[] data)
	{
	}

	private void OnTimelineExpandSubTrackHandler(object[] data)
	{
	}

	protected void OnTimelineAddTrackHandler(object[] data)
	{
	}

	protected void AddKeyFrameHandler(object[] data)
	{
	}

	protected void RemoveKeyFrameHandler(object[] data)
	{
	}

	protected override void OnClickNextFrameHandler()
	{
	}

	protected override void OnClickPrevFrameHandler()
	{
	}

	protected override void OnRefreshSubTrackHandler(object[] data)
	{
	}

	protected override void RefreshTimelineFPVMode()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickRecordingHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTrackPopMenuSelected(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickNextFrameHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickPrevFrameHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshSubTrackHandler(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTimelineFPVMode()
	{
	}
}
