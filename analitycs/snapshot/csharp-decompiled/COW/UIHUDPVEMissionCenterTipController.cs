using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDPVEMissionCenterTipController : UIBaseController
{
	public delegate void OnAnimFinish(string content);

	private sealed class _003CStartShow_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDPVEMissionCenterTipController _003C_003E4__this;

		public string content;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartShow_003Ed__9(int _003C_003E1__state)
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

	public OnAnimFinish action_OnShowOver;

	private HUDPVEMissionCenterTipView m_View;

	private bool m_IsShowAnimFinished;

	public float ContentWidth => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnMissionCome(string content)
	{
	}

	private IEnumerator StartShow(string content)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
