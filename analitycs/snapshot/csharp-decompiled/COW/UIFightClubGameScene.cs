using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UIFightClubGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFightClubGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__11(int _003C_003E1__state)
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

	private uint m_HideCSShopDelayCallID;

	private UIHudTakeTurnsShopController m_TakeTurnsShopCtrl;

	private UIHudFightClubMatchInfoController m_MatchInfoInfoCtrl;

	private UIHudFightClubRoundTransitionController m_RoundTransitionCtrl;

	private UIHudCSChooseSkillConfirmController m_CSChooseSkillConfirmCtrl;

	private UIHudBuffIntroController m_BuffIntroCtrl;

	private UIVFXBuffTrackController m_BuffCtrl;

	private LJDMEHFMAFK m_TakeTurnsShopState;

	private MHEGIGKNCJL m_ShopFlow;

	private bool m_WaitingForTakeTurnsShopState;

	protected override Type GetMatchResultType()
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

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void ShowRoundResult(object[] data)
	{
	}

	private void ShowShop(object[] data)
	{
	}

	private void ShowDefaultShop()
	{
	}

	private void ShowTakeTurnsShop(LJDMEHFMAFK shopState, int curRound, int maxRound)
	{
	}

	public bool WaitingForTakeTurnsShopState()
	{
		return false;
	}

	public override void HideCSShop()
	{
	}

	public void OnShowBuffIntro(object[] data)
	{
	}

	public void OnShowBuffVFX(object[] data)
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

	public void _003C_003EiFixBaseProxy_HideCSShop()
	{
	}
}
