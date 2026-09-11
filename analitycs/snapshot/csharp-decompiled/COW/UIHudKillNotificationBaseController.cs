using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal abstract class UIHudKillNotificationBaseController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003COnKill_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudKillNotificationBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnKill_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003COnKnockOtherDown_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudKillNotificationBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnKnockOtherDown_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003COnTargetPlayerKill_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudKillNotificationBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnTargetPlayerKill_003Ed__15(int _003C_003E1__state)
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

	protected UIModelMatch m_Model;

	protected uint m_DelayCallID;

	protected IEnumerator m_KillEnr;

	protected IEnumerator m_TargetPlayerKillEnr;

	protected IEnumerator m_KnockOtherDownEnr;

	protected Queue<MatchModelKillData> m_KillParams;

	protected Queue<MatchModelKillData> m_TargetPlayerParams;

	protected Queue<MatchModelKillData> m_KnockOtherDownParams;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param1)
	{
	}

	protected IEnumerator OnKill()
	{
		return null;
	}

	protected abstract void OnKill(Player killer, Player beKiller, MatchModelKillData data);

	protected IEnumerator OnTargetPlayerKill()
	{
		return null;
	}

	protected virtual void OnTargetPlayerKill(MatchModelKillData data)
	{
	}

	protected IEnumerator OnKnockOtherDown()
	{
		return null;
	}

	protected virtual void OnKnockOtherDown(MatchModelKillData param)
	{
	}

	protected void Show(float secs)
	{
	}

	protected void CancelHide()
	{
	}

	protected virtual void WaitAndHide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
