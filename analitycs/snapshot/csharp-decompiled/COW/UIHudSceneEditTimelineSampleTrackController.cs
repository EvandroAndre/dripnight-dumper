using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineSampleTrackController : UIHudSceneEditTimelineTrackWindowBase
{
	private sealed class _003CRepositionTrackTableNextFrame_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditTimelineSampleTrackController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepositionTrackTableNextFrame_003Ed__65(int _003C_003E1__state)
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

	private sealed class _003CScrollViewToTrack_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCTimelineEditorTrackBaseWarp trackWarp;

		public UIHudSceneEditTimelineSampleTrackController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollViewToTrack_003Ed__72(int _003C_003E1__state)
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

	private UIHudSceneEditTimelineSampleTrackView m_View;

	private UIHudSceneEditTimelineTrackTitleController m_TitleController;

	private UIHudSceneEditTimelineTrackController m_TrackController;

	protected UIHudSceneEditTimelineRecordingController m_RecordCtrl;

	private ulong m_offRecordTipTime;

	private EAdjustType m_LastItemAdjustType;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void SetViewData()
	{
	}

	protected void OnTrackContainerDragStarted()
	{
	}

	protected void OnTrackContainerDragMoveing()
	{
	}

	protected void OnTrackContainerDragFinished()
	{
	}

	private void OnClickDetialEditHandler()
	{
	}

	protected override void OnRefreshOnPressSideBarandler(object[] data)
	{
	}

	protected override void OnTrackPopMenuSelected(object value)
	{
	}

	protected void SetSelectedTrack(IUGCTimelineEditorTrackBaseWarp trackWarp)
	{
	}

	private void OnTimelineOffRecordTipHandler(object[] data)
	{
	}

	protected override void OnSceneEditSelectedObjectHandler()
	{
	}

	private void RefreshTrackData(IUGCTimelineEditorTrackBaseWarp currTrack)
	{
	}

	private void FixHeaderTime()
	{
	}

	private void DisableToolBar()
	{
	}

	private void EnabelToolBar()
	{
	}

	public void OnClickKeyFrameHandler(UGCTimelineEditorTrackBaseWarp trackBaseWarp, UGCTimelineEditorKeyBase frameData)
	{
	}

	protected void OnSelectTrackHandler(object[] data)
	{
	}

	protected void OnTimelineDelTrackHandler(object[] data)
	{
	}

	protected override void RefreshTimelineFPVMode()
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

	private void OnTimelineExpandSubTrackHandler(object[] data)
	{
	}

	protected override void OnRefreshSubTrackHandler(object[] data)
	{
	}

	private IEnumerator RepositionTrackTableNextFrame()
	{
		return null;
	}

	protected override void OnClickRecordingHandler()
	{
	}

	protected override void OnClickNextFrameHandler()
	{
	}

	protected override void OnClickPrevFrameHandler()
	{
	}

	private void OnClickTutorialHandler()
	{
	}

	private void OnSwitchCameraMuteHandler()
	{
	}

	private void RefreshRecordButtonState()
	{
	}

	private IEnumerator ScrollViewToTrack(UGCTimelineEditorTrackBaseWarp trackWarp)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
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

	public void _003C_003EiFixBaseProxy_OnRefreshOnPressSideBarandler(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTrackPopMenuSelected(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneEditSelectedObjectHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTimelineFPVMode()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshSubTrackHandler(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickRecordingHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickNextFrameHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickPrevFrameHandler()
	{
	}
}
