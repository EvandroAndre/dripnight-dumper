using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UIFateRandomGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFateRandomGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__5(int _003C_003E1__state)
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

	private UIFateRandomGameSubmode_Base m_subModeScene;

	private OADFHOGOKJF m_subMode;

	private bool m_isStartFight;

	private UIHudPopupController m_waitTip;

	public void OnConfirmSubMode(OADFHOGOKJF msgModeId, bool isStartFight)
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	private void OnGameLoadingOver(object[] data)
	{
	}

	private void ShowFateRandomTeamZone(object[] data)
	{
	}

	private void OnFateRandomStartFight(object[] data)
	{
	}

	private void CloseTip()
	{
	}

	protected override void OnDestory()
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

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
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
