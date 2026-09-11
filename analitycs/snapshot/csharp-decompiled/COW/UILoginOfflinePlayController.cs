using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILoginOfflinePlayController : UIBaseController
{
	private sealed class _003CAutoHideTipsCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoginOfflinePlayController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoHideTipsCoroutine_003Ed__11(int _003C_003E1__state)
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

	private UILoginOfflinePlayView m_View;

	private Coroutine m_AutoHideTipsCoroutine;

	private bool m_HasClicked;

	private float m_TipsShownTime;

	private static readonly string OFFLINE_PLAY_CLICKED_KEY;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnButtonWithBgClick()
	{
	}

	private void SetViewData()
	{
	}

	private void ShowTipsWithAutoHide()
	{
	}

	private IEnumerator AutoHideTipsCoroutine()
	{
		return null;
	}

	private void SetBg()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
