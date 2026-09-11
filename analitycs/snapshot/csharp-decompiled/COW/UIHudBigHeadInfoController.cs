using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCommon;

namespace COW;

public class UIHudBigHeadInfoController : UIBaseController
{
	private sealed class _003CWaitAndShowTutorial_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBigHeadInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitAndShowTutorial_003Ed__9(int _003C_003E1__state)
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

	private UIHudBigHeadInfoView m_View;

	private StringBuilder m_TimeString;

	private StringBuilder m_ScoreString;

	private int m_TotalScore;

	private int m_TotalTime;

	private int m_Secs;

	private int CurrentScore => 0;

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

	private IEnumerator WaitAndShowTutorial()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	private void OnScoreChange(object[] data)
	{
	}

	private void OnLeadingScoreChange(object[] data)
	{
	}

	private void Update()
	{
	}

	private void UpdateTime()
	{
	}

	private void UpdateScore(int score)
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
