using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudLWMultiMatchInfoController : UIBaseController
{
	private UIHudLWMultiMatchInfoView m_View;

	private AMEEGELHGFG mGame;

	private UIModelMatch m_ModelMatch;

	private StringBuilder m_Timer;

	private int mSeconds;

	private uint min;

	private uint sec;

	private uint m_TutorialLeadboardDelayCall;

	private int m_TeamPlayerCount;

	private List<UIHudCSPlayerStateInfoView>[] m_TeamViews;

	private Dictionary<byte, UILabel> m_TeamId2ScoreLabel;

	private Dictionary<byte, List<UIHudCSPlayerStateInfoView>> m_TeamId2Views;

	private UILabel[] m_TeamLable;

	private int m_SelfTeamId;

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

	private void Update()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void InitUIView()
	{
	}

	private List<UIHudCSPlayerStateInfoView> GetPlayerViewList(int index, bool isSingle)
	{
		return null;
	}

	private void SetTeamStateView(List<UIHudCSPlayerStateInfoView> views)
	{
	}

	private void SetUIData()
	{
	}

	private void SetRoundInfoUI()
	{
	}

	private void InitTeamStateOnStart()
	{
	}

	private void RefreshTeamStatesUI(BHGGAEEHJCO pId)
	{
	}

	private void SetTeamViewForId(byte teamId)
	{
	}

	private int GetFactionIdByTeamId(byte teamId)
	{
		return 0;
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views)
	{
	}

	private void ShowTutorial()
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void OnShowMatchStartVFX()
	{
	}

	private void ShowSelfView(int selfTeamId)
	{
	}

	public void ShowMatchStart()
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
