using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_MoreTeamLeaderboardController : UIHUDUGC_BaseLeaderboardController
{
	private UIHUDUGC_MoreTeamLeaderboardView m_View;

	private UGCMoreTeamLeaderboardHudRepItem m_ViewData;

	private Dictionary<int, UIHUDUGC_MoreTeamLeaderboard_TeamItemController> m_TeamDict;

	private Dictionary<BHGGAEEHJCO, UIHUDUGC_BaseLeaderboard_TeammateItemController> m_TeammateDict;

	private UIDetailTipsInUGCMatchResultController m_HelpTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex)
	{
		return null;
	}

	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(BHGGAEEHJCO playerId)
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void UpdateAllTeammateItemInfo()
	{
	}

	private void PostTeamTableReposition()
	{
	}

	private void OnSpaceBtnClick()
	{
	}

	private void OnHelpBtnClick(Vector3 position)
	{
	}

	private int GetTeamIndex(int index)
	{
		return 0;
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnTeamIndexsChanged(List<object> cur)
	{
	}

	private void OnTeamRanksChanged(List<object> cur)
	{
	}

	private void OnTeamScoresChanged(List<object> cur)
	{
	}

	private void OnTeamColorsChanged(List<object> cur)
	{
	}

	private void OnPlayerScoreTypesChanged(List<object> cur)
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAllTeammateItemInfo()
	{
	}
}
