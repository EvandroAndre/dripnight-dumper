using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPOIMissionTips2Controller : UIBaseController
{
	private sealed class _003CPlayAnim_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPOIMissionTips2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAnim_003Ed__15(int _003C_003E1__state)
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

	private UIHudPOIMissionTips2View m_View;

	private Coroutine m_AnimCor;

	private uint m_MissionType;

	private bool m_Success;

	private EILFEDGEAII m_Reason;

	public uint MissionType => 0u;

	public bool Success => false;

	public EILFEDGEAII Reason => EILFEDGEAII.Start;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowTip(string content, uint missionType, bool success, EILFEDGEAII reason)
	{
	}

	private string GetMissionIcon()
	{
		return null;
	}

	private IEnumerator PlayAnim()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
