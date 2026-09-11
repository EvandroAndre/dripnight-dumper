using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudBigHeadScoreInfoController : UIBaseController
{
	public class TeamScore
	{
		public uint TeamID;

		public int Score;
	}

	private const int BIHHEADMODETEAMCOUNT = 6;

	private Dictionary<uint, TeamScore> m_DicTeamIDToScore;

	private List<TeamScore> m_TeamScores;

	private int m_CurrentLeadingScore;

	private int m_WinScore;

	private UIHudBigHeadScoreInfoView m_View;

	private int CurrentScore => 0;

	private int CurrentRank => 0;

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

	private void OnSelfScoreChange(object[] data)
	{
	}

	private void OnOtherScoreChange(object[] data)
	{
	}

	private void OnLeadingScoreChange(object[] data)
	{
	}

	private void RefreshScoreText()
	{
	}

	private void OnQuitRevive(object[] data)
	{
	}

	private void RefreshRankText()
	{
	}

	private bool GetSelfTeamScore(TeamScore teamScore)
	{
		return false;
	}

	public void OnAddPlayer(Player p)
	{
	}

	private int SortTeam(TeamScore a, TeamScore b)
	{
		return 0;
	}

	public uint GetLeadingTeamID()
	{
		return 0u;
	}

	public void OnWinScoreChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
