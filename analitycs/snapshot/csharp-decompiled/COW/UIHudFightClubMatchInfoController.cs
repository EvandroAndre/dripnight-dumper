using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudFightClubMatchInfoController : UIBaseController
{
	private UIHudFightClubMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private KOFCHBDBMFD mGame;

	private uint m_TutorialLeadboardDelayCall;

	private UIModelMatch m_ModelMatch;

	private int m_TeamCount;

	private bool m_IsLobbyLWObserveMode;

	private BHGGAEEHJCO m_LobbyLWObserveLeftPlayerID;

	private BHGGAEEHJCO m_LobbyLWObserveRightPlayerID;

	private int m_LobbyLWObservePhaseEndTime;

	private int m_LobbyLWObserveWinGoal;

	private List<int> m_states;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetLobbyLWObservePlayers(uint leftPlayerID, uint rightPlayerID, uint currentPhase, byte maxRound)
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void SetUIData()
	{
	}

	private void RefreshTeamStatesUI(BHGGAEEHJCO pId)
	{
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
	{
	}

	private void Update()
	{
	}

	private void UpdateTime(int seconds)
	{
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void OnTeamCountChanged(int count)
	{
	}

	private void SetRoundInfoUI()
	{
	}

	private void HideLobbySocialAreaTeamStates()
	{
	}

	private void HideTeamStates(List<UIHudCSPlayerStateInfoView> views)
	{
	}

	private void RefreshLobbyLWObserveScoreUI()
	{
	}

	private void ApplyLobbyLWObserveScore(BHGGAEEHJCO playerID, int score)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
