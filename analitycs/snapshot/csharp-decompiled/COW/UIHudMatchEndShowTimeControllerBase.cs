using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudMatchEndShowTimeControllerBase : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_0;

		internal void _003CShowUI_003Eb__11_0()
		{
		}
	}

	private sealed class _003CProcessUpdateCloseTime_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchEndShowTimeControllerBase _003C_003E4__this;

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

	protected Action m_callBack;

	protected float m_timeShowing;

	protected int m_lastShowTime;

	protected const string showFormat = "({0}s)";

	protected UILabel m_TimeLabel;

	protected VisualInstanceHolder m_CSPeakBooyahVFX;

	private uint m_PlayCSPeakBooyahSoundDelayCallID;

	protected float DurationForEatingChicken => 0f;

	public void SetDelayCloseTimeAndShowUI(Action callback, bool showLoserAudio = false, int rank = 0)
	{
	}

	protected virtual bool NeedPlayGameEndSound()
	{
		return false;
	}

	protected virtual void ShowUI(bool showLoserAudio = false, int rank = 0)
	{
	}

	private IEnumerator ProcessUpdateCloseTime()
	{
		return null;
	}

	protected virtual void SendGameEnd()
	{
	}

	public void OnShowResultClick()
	{
	}

	public void HandleMatch()
	{
	}

	public virtual void OnHandleInvalidTimeMatch()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
