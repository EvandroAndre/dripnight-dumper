using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UILoneWolfMultiGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILoneWolfMultiGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__13(int _003C_003E1__state)
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

	private UIHudLWFactionController m_FactionCtrl;

	private UIHudTakeTurnsShopController m_TakeTurnsShopCtrl;

	private UIHudLWMultiMatchInfoController m_MatchInfoInfoCtrl;

	private UIHudLWMultiRoundTransitionController m_RoundTransitionCtrl;

	private UIHudGameShowInfoController m_ShowInfoStyle;

	private UIHudBuffIntroController m_BuffIntroCtrl;

	private UIVFXBuffTrackController m_BuffCtrl;

	private LJDMEHFMAFK m_TakeTurnsShopState;

	private MHEGIGKNCJL m_ShopFlow;

	private uint m_HideCSShopDelayCallID;

	private bool m_WaitingForTakeTurnsShopState;

	private bool m_ShowTips;

	private UIHudLWMultiDestroyerController m_TeamDestroyCtrl;

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override Type BRScoreBoardType()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public void TryShowShop()
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

	private void OnShowInfoStyle()
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

	public override string GetDefeatEndShowKey()
	{
		return null;
	}

	public override void ShowTeamKill(float showTime)
	{
	}

	protected override void OpenObserverHud(object[] data)
	{
	}

	public override float GetMatchEndDelay()
	{
		return 0f;
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

	public Type _003C_003EiFixBaseProxy_BRScoreBoardType()
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

	public string _003C_003EiFixBaseProxy_GetDefeatEndShowKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ShowTeamKill(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OpenObserverHud(object[] P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetMatchEndDelay()
	{
		return 0f;
	}
}
