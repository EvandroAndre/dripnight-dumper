using System;
using System.Collections;
using System.Collections.Generic;
using COW;
using UnityEngine;

public class MobileReplayAgain : MonoBehaviour
{
	private sealed class _003CReplayAgain_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MobileReplayAgain _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReplayAgain_003Ed__5(int _003C_003E1__state)
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

	private int m_CurrentTimes;

	private int m_AllTimes;

	private MobileReplayInfo m_MobileReplayInfo;

	private Coroutine m_Coroutine;

	public bool TryStartCoroutineOrDestroy()
	{
		return false;
	}

	private IEnumerator ReplayAgain()
	{
		return null;
	}

	public void SetTimesAndInfo(int replayTimes, MobileReplayInfo info)
	{
	}
}
