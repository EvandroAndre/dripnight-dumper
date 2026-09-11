using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using VoxelBusters.ReplayKit;

namespace COW;

public class UIRecordStateController : UIBaseController
{
	private sealed class _003CUpdateRecordTime_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRecordStateController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateRecordTime_003Ed__12(int _003C_003E1__state)
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

	private UIRecordStateView m_View;

	private bool mbReplayKitInitialise;

	private Coroutine m_RecordEnumerator;

	private EventLogger.ReplayVideoInfo m_CurReplayVideoInfo;

	private ReplayKitVideoInfo m_RecordVideoInfo;

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

	public void StartRecord(ERecordReplayVideoType videoType, int curTotalTime)
	{
	}

	private void ClickStopRecord()
	{
	}

	public void StopRecord(ERecordVideoStopReson stopReson = ERecordVideoStopReson.Other)
	{
	}

	private void RefershContentLabel()
	{
	}

	private IEnumerator UpdateRecordTime()
	{
		return null;
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

	private void OnSaveRecordCallback(bool result, string message)
	{
	}

	private void OnVideoMuxerActionCallback(int result, int progress)
	{
	}

	private void OnAudioEncodeProgressCallback(int progress)
	{
	}

	private void ControlTween(bool play)
	{
	}

	private void OnVideoRecordSuccessCallback(object[] args)
	{
	}

	private void OnGetVideoInfoCallback(object[] args)
	{
	}

	private void OnVideoRecordStopCallback(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
