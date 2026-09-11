using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDBotAgentChatController : UIBaseController
{
	private sealed class _003CCheckAndHideUI_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDBotAgentChatController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckAndHideUI_003Ed__10(int _003C_003E1__state)
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

	private UIHUDBotAgentChatView m_View;

	private const int LABEL_MARGIN = 24;

	private float m_StartTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] args)
	{
	}

	private void OnSettingChanged()
	{
	}

	private void OnShowText(object[] args)
	{
	}

	protected IEnumerator CheckAndHideUI()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
