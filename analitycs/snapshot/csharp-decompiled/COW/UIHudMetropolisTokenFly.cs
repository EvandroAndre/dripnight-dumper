using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIHudMetropolisTokenFly : MonoBehaviour
{
	private sealed class _003CPlayAndWaitingForAnimationOver_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisTokenFly _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAndWaitingForAnimationOver_003Ed__7(int _003C_003E1__state)
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

	public Animation Anim;

	public TweenPosition TWPosition;

	private Action<UIHudMetropolisTokenFly> m_EndCall;

	private Coroutine m_PlayCoroutine;

	public void Play(Vector3 startPos, Vector3 endPos)
	{
	}

	private void Stop()
	{
	}

	public void SetEndCallBack(Action<UIHudMetropolisTokenFly> endCall)
	{
	}

	private IEnumerator PlayAndWaitingForAnimationOver()
	{
		return null;
	}
}
