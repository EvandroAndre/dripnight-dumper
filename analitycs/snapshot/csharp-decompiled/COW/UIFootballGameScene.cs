using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIFootballGameScene : UIInGameScene
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIFootballGameScene _003C_003E4__this;

		public EGameShowStyle style;

		public string key;

		internal void _003COnFootballGamePhaseChange_003Eb__0()
		{
		}
	}

	private sealed class _003COpenHud_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFootballGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__5(int _003C_003E1__state)
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

	private bool m_ShowSkillSelectWhenReady;

	private bool m_UILoadingReady;

	private bool m_IsReconnect;

	private UIHudGameIntroPopWindowController m_IntroController;

	private UIHudFootballGameTimeScoreInfoController m_FootballGameTimeScoreInfoCtrl;

	private UIHudArenaFootballLeaderboardController m_FootballGameLeaderBoardCtrl;

	private UIHudFootballGameMatchResultController m_FootballGameMatchResultCtrl;

	private UIHudArenaFootballGameGoalScoreBannerController m_FootballGameGoalScoreBannerCtrl;

	private UIHudFootballGameCountDownController m_FootballGameCountDownCtrl;

	private UIHudFootballGameInviteController m_FootballGameInviteCtrl;

	private UIHudFootballGameReceiveInviteController m_FootballGameReceiveInviteCtrl;

	private UIHudFootballMatchMiniMapController m_FootballMatchMiniMapCtrl;

	private UIFootballSceneScoreBoardController m_FootballGameSceneScoreBoardCtrl;

	private UIHudGameShowInfoController m_ShowInfoCtrl;

	private UIHudFootballGameRoundTransitionController m_FootballGameRoundTransitionCtrl;

	private UIFootballSkillSelectController m_FootballGameSkillSelectCtrl;

	private uint m_DelayID;

	private uint m_GameIntroDelayID;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	protected override bool IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	protected override bool IsNeedPlayerStats()
	{
		return false;
	}

	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	private void OpenFootballGameHud()
	{
	}

	private void ShowHideFootballGameHud(bool isShow)
	{
	}

	private void OnFootballGamePhaseChange(object[] data)
	{
	}

	protected override void OnGamePaused(object[] param)
	{
	}

	private void OnGameLoadingOver(object[] data)
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override Type GetMatchEndShowHUD()
	{
		return null;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnGameLoadingOver_003Eb__28_0()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedPlayerStats()
	{
		return false;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnGamePaused(object[] P0)
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchEndShowHUD()
	{
		return null;
	}
}
