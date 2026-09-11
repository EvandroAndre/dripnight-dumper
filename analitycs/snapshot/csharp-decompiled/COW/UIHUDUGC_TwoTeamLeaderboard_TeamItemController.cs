using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHUDUGC_TwoTeamLeaderboard_TeamItemController : UIHUDUGC_BaseLeaderboard_TeamItemController
{
	private UIHUDUGC_TwoTeamLeaderboard_TeamItemView m_View;

	private List<UIHUDUGC_TwoTeamLeaderboard_TeammateItemController> m_TeammateList;

	private List<int> m_ScoreTypes;

	private List<object> m_CustomScoreTypes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<int> scoreTypes)
	{
	}

	public void SetViewDataByCustomScore(List<object> scoreTypes)
	{
	}

	public override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	public UIHUDUGC_TwoTeamLeaderboard_TeammateItemController CreateTeammateItemWithCustomScore(Player player, List<object> scoreTypes)
	{
		return null;
	}

	public void RefreshAllTeammateScores(List<object> players, List<object> scoreTypes, List<object> scoreContent)
	{
	}

	public void CheckScrollView()
	{
	}

	public override void DestroyAllTeammateItems(Action<BHGGAEEHJCO> action)
	{
	}

	public void Reposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
