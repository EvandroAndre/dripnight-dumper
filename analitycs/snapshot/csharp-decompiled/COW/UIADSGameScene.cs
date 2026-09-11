using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

internal class UIADSGameScene : UITeamModeBaseGameScene
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Player localPlayer;

		public UIADSGameScene _003C_003E4__this;

		internal void _003COnSyncBlackMask_003Eb__0()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIADSGameScene _003C_003E4__this;

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

	private UIHudADSpaceHintController m_HintController;

	private UIHudADSBonusCountdownController m_BonusCountdownController;

	private UIHudADSTeamScoreController m_UIHUDTeamScoreBoardController;

	private uint showBlackMaskDelayCall;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OnOpenHudBeginFight()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void OnADSShowHint(object[] param)
	{
	}

	private void OnADSBonusCountdown(object[] param)
	{
	}

	private void OnSyncBlackMask(object[] param)
	{
	}

	protected override void ShowTeamScore(object[] data)
	{
	}

	public void OnMatchEnd()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
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

	public void _003C_003EiFixBaseProxy_ShowTeamScore(object[] P0)
	{
	}
}
