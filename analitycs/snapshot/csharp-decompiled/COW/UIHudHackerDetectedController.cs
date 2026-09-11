using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudHackerDetectedController : UIBaseController
{
	private sealed class _003CDelayedUpdate_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudHackerDetectedController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayedUpdate_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CProcessUpdateCloseTime_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudHackerDetectedController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CProcessUpdateCloseTime_003Ed__12(int _003C_003E1__state)
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

	private UIHudHackerDetectedView m_View;

	private Action m_CallBack;

	private int m_ShowTime;

	private float m_CountDownSetTimer;

	private float m_AnimationTime;

	private const string CountDownFormat = "{0}s";

	private const int m_CountDownSetInterval = 1;

	private const int CountDownTime = 5;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetDelayCloseAction(Action callback, bool isHackerTeam)
	{
	}

	private IEnumerator DelayedUpdate()
	{
		return null;
	}

	private IEnumerator ProcessUpdateCloseTime()
	{
		return null;
	}

	private void SendGameEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
