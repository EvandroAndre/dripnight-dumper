using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReplayBtnCtrlController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UIUtils.OnSavedScreenshot _003C_003E9__19_0;

		public static Action _003C_003E9__20_0;

		internal void _003CReloadWithPic_003Eb__19_0(bool saved, Texture2D screenshot)
		{
		}

		internal void _003COnClickResetBtn_003Eb__20_0()
		{
		}
	}

	private sealed class _003CReloadWithPic_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeRatio;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReloadWithPic_003Ed__19(int _003C_003E1__state)
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

	private UIHudReplayBtnCtrlView m_View;

	private bool m_Show;

	private bool m_play;

	private uint m_DelayCallID;

	private bool m_HighlightOver;

	private bool needShowPreview;

	private UIRecordStateController m_RecordCtrl;

	private UIHudSingleHighlightBtnCtrlController m_SingleHighlightBtnCtrl;

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

	private void StartHide()
	{
	}

	private void OnPlayClcik()
	{
	}

	private void OnPauseClcik()
	{
	}

	private void RefershBtn()
	{
	}

	private void CheckAndRestorePlayState()
	{
	}

	private void OnJumpClick()
	{
	}

	private void OnRewindClick()
	{
	}

	private void StartReloadCor(float timeRatio)
	{
	}

	private IEnumerator ReloadWithPic(float timeRatio)
	{
		return null;
	}

	private void OnClickResetBtn()
	{
	}

	private void OnClickReplayToggle(object[] args)
	{
	}

	private void OnHudReplayStartHide(object[] args)
	{
	}

	private void CancelHideDelayCall()
	{
	}

	private void ShowLoadingLabel()
	{
	}

	private void OnReplayPressStateChanged(bool isPressed)
	{
	}

	private void OnSingleHighlightClickExit()
	{
	}

	private void OnHighlightOverCallback(object[] args)
	{
	}

	private void StartRecord(bool delayRecordHighlight)
	{
	}

	private void StartAutoRecord()
	{
	}

	private void OnVideoRecordStopCallback(object[] args)
	{
	}

	private void OnStartRecordCallback(bool result, string message)
	{
	}

	private void OnStopRecordCallback(bool result, string message)
	{
	}

	private void _003CStartHide_003Eb__11_0()
	{
	}

	private void _003CStartAutoRecord_003Eb__29_0(bool permission)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
