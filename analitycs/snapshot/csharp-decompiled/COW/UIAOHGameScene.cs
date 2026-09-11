using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UIAOHGameScene : UITeamModeBaseGameScene
{
	private sealed class _003COpenCommonHud_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAOHGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__4(int _003C_003E1__state)
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

	private UIHudAOHTeamScoreController m_UIHUDTeamScoreBoardController;

	private new UIHudGameShowInfoController m_ShowInfoCtrl;

	private UIHudAOHLevelUpHintController m_LevelUpHint;

	protected override void OnOpenHudBeginFight()
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override void ShowTeamScore(object[] data)
	{
	}

	private void OnShowEscortInfo(object[] param)
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

	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowTeamScore(object[] P0)
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
