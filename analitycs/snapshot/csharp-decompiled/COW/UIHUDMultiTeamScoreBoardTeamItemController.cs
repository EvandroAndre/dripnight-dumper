using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDMultiTeamScoreBoardTeamItemController : UIBaseController
{
	private UIHUDMultiTeamLeaderboard_TeamItemView m_View;

	private List<UIHUDMultiTeamScoreBoardPlayerItemController> m_Teammates;

	private List<int> m_ScoreTypes;

	private static float Height;

	private int m_Score;

	private int m_TeamIndex;

	private GameObject[] m_RankGB;

	private int m_Rank;

	public int Score => 0;

	public int TeamIndex => 0;

	public int GetRank()
	{
		return 0;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual int SortPlayerData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public void SetViewData(List<int> scoreTypes)
	{
	}

	public virtual UIHUDMultiTeamScoreBoardPlayerItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	public void SetTeamID(int teamIndex)
	{
	}

	public void SetTeamScore(int score)
	{
	}

	public void Sort()
	{
	}

	public void SetRank(int rank)
	{
	}

	public int GetKill()
	{
		return 0;
	}

	public int GetDamage()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
