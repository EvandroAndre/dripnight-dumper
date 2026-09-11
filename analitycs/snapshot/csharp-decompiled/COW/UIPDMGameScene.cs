using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIPDMGameScene : UITeamModeBaseGameScene
{
	private sealed class _003COpenCommonHud_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPDMGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__6(int _003C_003E1__state)
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

	private UIHudPDMTimeScoreInfoController m_TimeScoreInfoCtrl;

	private UIHudTrainingDeadSummaryController m_DeadSummaryCtrl;

	private UIHudPDMRankController m_RankController;

	protected override void OnOpenHudBeginFight()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override bool ShowTeammateInfo()
	{
		return false;
	}

	protected override bool ShowChatBtn()
	{
		return false;
	}

	protected override bool ShowItemMarkBtn()
	{
		return false;
	}

	protected override void OnLocalPlayerRevive()
	{
	}

	protected override bool CanAutoPopShop()
	{
		return false;
	}

	protected override void OnGameVoiceHudCreated()
	{
	}

	private void OnDeadSummaryShow(object[] data)
	{
	}

	private void OnDeadSummaryHide(object[] data)
	{
	}

	protected void OnKillCntChanged(object[] data)
	{
	}

	protected void OnLocalPlayerDead(object[] data)
	{
	}

	private void OnPDMGamePhaseChange(object[] data)
	{
	}

	private void OnShowShopEntry(bool data)
	{
	}

	private void OnPlayerHpChanged(GEvent data)
	{
	}

	private IEnumerator _003C_003En__0()
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

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShowTeammateInfo()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShowChatBtn()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShowItemMarkBtn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnLocalPlayerRevive()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanAutoPopShop()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnGameVoiceHudCreated()
	{
	}
}
