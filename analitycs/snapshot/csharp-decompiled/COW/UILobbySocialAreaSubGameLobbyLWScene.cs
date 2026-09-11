using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UILobbySocialAreaSubGameLobbyLWScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbySocialAreaSubGameLobbyLWScene _003C_003E4__this;

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

	private UIHudFightClubMatchInfoController m_MatchInfoInfoCtrl;

	private UIHudFightClubRoundTransitionController m_RoundTransitionCtrl;

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override Type GetMatchEndShowHUD()
	{
		return null;
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

	protected override bool ShowItemMarkBtn()
	{
		return false;
	}

	protected override bool ShowChatBtn()
	{
		return false;
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void ShowRoundResult(object[] data)
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchEndShowHUD()
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

	public bool _003C_003EiFixBaseProxy_ShowItemMarkBtn()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShowChatBtn()
	{
		return false;
	}
}
