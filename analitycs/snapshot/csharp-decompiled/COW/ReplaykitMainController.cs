using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using VoxelBusters.ReplayKit;

namespace COW;

public class ReplaykitMainController : UIBaseController
{
	private sealed class _003CUpdateRecordTime_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReplaykitMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateRecordTime_003Ed__38(int _003C_003E1__state)
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

	private ReplaykitMainView m_View;

	private const string REPLAYKIT_BUTTON_KEY = "ReplayKit_Button_Position";

	private const string ANIM_STAND = "UIFX_ReplayKitNormal";

	private const string ANIM_LEFT_OPEN = "UIFX_ReplayKitLeftOpen";

	private const string ANIM_RIGHT_OPEN = "UIFX_ReplayKitRightOpen";

	private const string ANIM_LEFT_OPEN_INGAME = "UIFX_ReplayKitLeftOpen_1";

	private const string ANIM_RIGHT_OPEN_INGAME = "UIFX_ReplayKitRightOpen_1";

	private const string FIRST_OPEN_CONTROLLER = "First_Open_ReplaykitMainController";

	private Vector2 minBound;

	private Vector2 maxBound;

	private Vector2 bound;

	private float ratio;

	private bool mbReplayKitInitialise;

	private Coroutine record_enumerator;

	private bool mbShowGuideView;

	private uint iDelayHideGuideKey;

	public bool isEmpty;

	private bool needNoticeHighlightRecord;

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

	private string VectorToString(Vector3 v3)
	{
		return null;
	}

	private Vector3 StringToVector3(string str)
	{
		return default(Vector3);
	}

	private Vector3 LimitBound(Vector3 position)
	{
		return default(Vector3);
	}

	private void InitReplayKit()
	{
	}

	private void OnClickArrowBtn()
	{
	}

	private void OnClickRecordBtn()
	{
	}

	private void OnClickVideoBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickReplayKit(GameObject gameObject)
	{
	}

	private void OnStartDragReplayKit(GameObject gameObject)
	{
	}

	private void OnDragReplayKit(GameObject gameObject, Vector2 delta)
	{
	}

	private void OnEndDragReplayKit(GameObject gameObject)
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void OnHudClickRecord(bool delayRecordHighlight)
	{
	}

	private void RefershContentLabel()
	{
	}

	protected override void OnVisibilityChanged()
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

	public void SetContainerVisable(bool isShow)
	{
	}

	private void _003CInitReplayKit_003Eb__25_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
