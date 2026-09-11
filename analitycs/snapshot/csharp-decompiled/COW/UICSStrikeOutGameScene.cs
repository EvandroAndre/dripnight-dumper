using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UICSStrikeOutGameScene : UIInGameScene
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_0;

		internal void _003COnMiniGameNewPhaseStarted_003Eb__11_0()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICSStrikeOutGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__7(int _003C_003E1__state)
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

	private UIHudCSShopEntryController m_CSSOShopEntryCtrl;

	private UIHudCSSORoundResultController m_RoundResultController;

	private UIHudCSSORoundStartController m_RoundStartController;

	private UIHudCSSOLeaderboardController m_CSSOLeaderBoardCtrl;

	private UIHudCSSOHoldController m_CSSOHoldCtrl;

	private uint m_HideCSShopDelayCallID;

	private uint m_ShowRoundResultMaskDelayCall;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void ChangeUIFromWaitingToBattleInternal()
	{
	}

	public void OnNewPhaseStarted(NGKAAGHIFHA phase)
	{
	}

	private void OnMatchMakingPhaseStart()
	{
	}

	public void OnMiniGameNewPhaseStarted(MNHAIJHCGAB phase)
	{
	}

	public void OnMatchEnd()
	{
	}

	private void HideShopEntry()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	private void ShowLeaderBoard(object[] data)
	{
	}

	private void ShowRoundResult(bool show)
	{
	}

	private void ShowRoundStart(bool show)
	{
	}

	private void ShowHold(object[] data)
	{
	}

	public void OnSyncRoundResult(object[] data)
	{
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override bool IsNeedSafeZoneInfoController()
	{
		return false;
	}

	protected override void OnOpenHudInPregame()
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

	private void _003COnOpenHudInPregame_003Eb__23_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ChangeUIFromWaitingToBattleInternal()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
