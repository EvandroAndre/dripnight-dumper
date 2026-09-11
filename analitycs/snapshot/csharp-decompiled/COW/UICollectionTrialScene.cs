using System;
using System.Collections;
using System.Collections.Generic;
using COW.HUD;

namespace COW;

internal class UICollectionTrialScene : UIInGameScene
{
	private sealed class _003COpenHud_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICollectionTrialScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__5(int _003C_003E1__state)
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

	private UIHudResetBotController UIHudResetBotCtrl;

	private UIHudCollectionTrialPrivilegeShowController UIHudCollectionTrialPrivilegeShowCtrl;

	private UIHudToxicBehaviorWarningWndController UIHudToxicBehaviorWarningWndCtrl;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnInit()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	public void ShowTipsWnd(string title, string content)
	{
	}

	protected override void OnDestory()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
