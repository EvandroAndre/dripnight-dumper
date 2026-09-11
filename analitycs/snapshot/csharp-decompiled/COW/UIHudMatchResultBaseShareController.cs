using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudMatchResultBaseShareController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__29_0;

		internal void _003CPrepareShareImage_003Eb__29_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public MatchResultHighlightWindowInfo highlightWindowInfo;

		public UIHudMatchResultBaseShareController _003C_003E4__this;

		internal void _003COnShareBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIHudMatchResultBaseShareController _003C_003E4__this;

		public Action closeAction;

		public UIUtils.ScreenshotType screenShotType;

		public EShareLadderIconType iconType;

		public EventLogger.EventShareMatchResultPosterExtraInfo extraInfo;

		internal void _003CPrepareShareImage_003Eb__1()
		{
		}
	}

	private sealed class _003CWaitAndReturnToLobby_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float secs;

		public UIHudMatchResultBaseShareController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitAndReturnToLobby_003Ed__40(int _003C_003E1__state)
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

	protected UIModelMatch m_ModelMatch;

	protected MatchStats m_MatchStats;

	protected MatchIncome m_MatchIncome;

	protected ulong m_MatchIdInHistoryRecord;

	private EMatchResultIsWin _003CIsWin_003Ek__BackingField;

	protected bool m_UseNewShare;

	protected bool m_ScreenshotShareInited;

	private string m_ScreenshotFilePath;

	private bool m_IsHaveShareFile;

	private UIMatchResultScreenshotController.MatchResultScreenshotData m_ScreenShotData;

	private Coroutine m_AutoReturnToLobbyCor;

	private Coroutine m_AutoReturnCommonMatchResultCor;

	private bool m_IsShowInFrontEndScene;

	private UIHudMatchResultPosterController m_PosterCtrl;

	protected EMatchResultIsWin IsWin
	{
		get
		{
			return _003CIsWin_003Ek__BackingField;
		}
		set
		{
			_003CIsWin_003Ek__BackingField = value;
		}
	}

	public bool IsShowInFrontEndScene => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected virtual void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	protected void InitScreenShotShare(UIButton btn)
	{
	}

	private void RegisterScreenShotShareEvetns()
	{
	}

	private void UnregisterScreenShotShareEvetns()
	{
	}

	protected void DisableCameraFlareLayer()
	{
	}

	protected virtual void OnShareBtnClick()
	{
	}

	public void PrepareShareImage(bool closeWindow, Action closeAction = null)
	{
	}

	private void MakeShareImage()
	{
	}

	protected virtual UIMatchResultScreenshotController.MatchResultScreenshotData CreateScreenShotData()
	{
		return null;
	}

	protected virtual bool HasDefeater(MatchStats stats)
	{
		return false;
	}

	private void OnScreenshotResponse(object[] param)
	{
	}

	private void ShowSharePanel()
	{
	}

	protected void InitReturnButton(UIButton btn)
	{
	}

	protected virtual void ReturnToLobby()
	{
	}

	protected void StartAutoReturnToLobby(float secs)
	{
	}

	protected void StopAutoReturnToLobby()
	{
	}

	protected void StopAutoReturnToCommonMatchResult()
	{
	}

	protected IEnumerator WaitAndReturnToLobby(float secs)
	{
		return null;
	}

	protected virtual EHighlightDisplayType GetHighlightTipsDisplayType()
	{
		return EHighlightDisplayType.None;
	}

	private void _003COnShareBtnClick_003Eb__28_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
