using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UIControlGameScene : UITeamModeBaseGameScene
{
	private sealed class _003COpenCommonHud_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIControlGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__0(int _003C_003E1__state)
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

	private UIHUDControlModeBuffIconController m_BuffIcon;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void ChangeUIFromWaitingToBattleInternal()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	private void ShowBuffIcon(object[] data)
	{
	}

	private void ShowControlLeaderboard(object[] data)
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ChangeUIFromWaitingToBattleInternal()
	{
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
