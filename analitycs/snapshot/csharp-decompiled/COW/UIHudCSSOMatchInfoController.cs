using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudCSSOMatchInfoController : UIBaseController
{
	private UIHudCSSOMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private UIHudCSSOTeamInfoView m_MyTeam;

	private UIHudCSSOTeamInfoView m_OppoTeam;

	private GIOBEJEFOGC mGame;

	private UIModelMatch m_ModelMatch;

	private int m_TeamCount;

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

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnNewMiniPhaseEnter(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void SetRoundInfoUI()
	{
	}

	private void SetUIColor()
	{
	}

	private int CalTeamCount()
	{
		return 0;
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
