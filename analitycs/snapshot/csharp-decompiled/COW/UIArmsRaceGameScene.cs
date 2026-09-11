using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UIArmsRaceGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIArmsRaceGameScene _003C_003E4__this;

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

	private UIHudArmsListController m_ArmsListWndCtrl;

	private UIHUDArmsRaceMatchInfoController m_UIHUDArmsRaceMatchInfoController;

	private UIHUDArmsRaceKillPointsController m_UIHUDArmsRaceKillPointsController;

	private UIHUDArmsRaceTeamMatchInfoController m_UIHUDArmsRaceTeamMatchInfoController;

	private UIHUDTeamArmsRaceScoreBoardController m_UIHUDTeamArmsRaceScoreBoardController;

	private UIHUDArmsRaceBonusCardController m_BonusCardController;

	private bool m_IntroInfoDone;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override UIHudWeaponInfoController OpenCommonWeaponPanel()
	{
		return null;
	}

	protected override UIHudWeaponSwitchController OpenCommonWeaponSwitchPanel()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override void CloseAllUIs()
	{
	}

	public void OnArmsListDataReady(object[] data)
	{
	}

	public void OnIntroInfoDone(object[] data)
	{
	}

	private void TryShowArmsList()
	{
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override bool IsNeedQuickSwitchHUD()
	{
		return false;
	}

	protected override bool IsNeedMedkitController()
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

	protected override void OnOpenHudBeginFight()
	{
	}

	public void OpenScoreBoard()
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void OnBonusCardCome(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnOpenHudInPregame_003Eb__20_0()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public UIHudWeaponInfoController _003C_003EiFixBaseProxy_OpenCommonWeaponPanel()
	{
		return null;
	}

	public UIHudWeaponSwitchController _003C_003EiFixBaseProxy_OpenCommonWeaponSwitchPanel()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_CloseAllUIs()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedQuickSwitchHUD()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedMedkitController()
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

	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
