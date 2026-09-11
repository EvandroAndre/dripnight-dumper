using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCQuitFeedbackController : UIPopupWindowController
{
	private sealed class _003CShowOKBtnDelay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCQuitFeedbackController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowOKBtnDelay_003Ed__7(int _003C_003E1__state)
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

	private UIUGCQuitFeedbackView m_View;

	private const int MaxItemCount = 4;

	private int m_CountDownSecond;

	private List<uint> m_SelectedIdList;

	private UGCMidGameExitConfigRepItem m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator ShowOKBtnDelay()
	{
		return null;
	}

	private void OnCancelClick()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void SendSelectedToGS()
	{
	}

	private void RefreshUI()
	{
	}

	private void OnItemClick(uint id, bool selected)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
