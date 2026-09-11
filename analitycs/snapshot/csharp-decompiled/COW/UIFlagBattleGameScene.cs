using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

internal class UIFlagBattleGameScene : UITeamModeBaseGameScene
{
	private sealed class _003COpenCommonHud_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFlagBattleGameScene _003C_003E4__this;

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

	private Dictionary<uint, UIHudEnergyStoneBoxMarkController> m_EnergyStoneBoxMarks;

	private List<UIHudEnergyStoneBoxMarkController> m_CacheEnergyStoneBoxList;

	private Dictionary<BHGGAEEHJCO, UIHudEnergyStoneMarkController> m_EnergyStoneMarks;

	private UIHudChokePointBuffDurationController m_ChokePointBuffDurationCtrl;

	private UIHudGameShowInfoController m_ShowInfoStyle;

	private uint m_TutorialDelayCallID;

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

	private void OnShowInfoStyle(object[] param)
	{
	}

	private void ShowControlLeaderboard(object[] data)
	{
	}

	private void OnEnergyStoneBoxStateChange(object[] param)
	{
	}

	private void OnPlayerOwnEnergyStoneStateChange(object[] param)
	{
	}

	private new void OnLocalPlayerRevive(object[] args)
	{
	}

	private void OnPlayerDie(object[] param)
	{
	}

	private void OnChokePointBuffCreate(object[] param)
	{
	}

	private void OnChokePointBuffEnd(object[] param)
	{
	}

	private void OnIntroInfoDone(object[] param)
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

	private void _003COnIntroInfoDone_003Eb__18_0()
	{
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
