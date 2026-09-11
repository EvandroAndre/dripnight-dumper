using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_MoreTeamLeaderboard_TeamItemController : UIHUDUGC_BaseLeaderboard_TeamItemController
{
	private UIHUDUGC_MoreTeamLeaderboard_TeamItemView m_View;

	private List<UIHUDUGC_MoreTeamLeaderboard_TeammateItemController> m_Teammates;

	private List<int> m_ScoreTypes;

	private Action<Vector3> m_ClickHelpBtnAction;

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

	public UIHUDUGC_MoreTeamLeaderboard_TeammateItemController CreateTeammateItemWithCustomScore(Player player, List<object> scoreTypes)
	{
		return null;
	}

	public void RefreshAllTeammateScores(List<object> players, List<object> scoreTypes, List<object> scoreContent)
	{
	}

	public override void DestroyAllTeammateItems(Action<BHGGAEEHJCO> action)
	{
	}

	public void SetTeamID(int teamIndex, bool isSelf)
	{
	}

	public void SetTeamRank(int rank)
	{
	}

	public void SetTeamScore(int score)
	{
	}

	public void SetTeamColor(Color color)
	{
	}

	public void SetHelpBtnAction(Action<Vector3> action)
	{
	}

	private void OnHelpBtnClick()
	{
	}

	public void Reposition()
	{
	}

	public void SetHelpBtnActive(bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
