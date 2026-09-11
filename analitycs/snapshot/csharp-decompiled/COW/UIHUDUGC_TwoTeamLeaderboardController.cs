using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_TwoTeamLeaderboardController : UIHUDUGC_BaseLeaderboardController
{
	private UIHUDUGC_TwoTeamLeaderboardView m_View;

	private UGCTwoTeamLeaderboardHudRepItem m_ViewData;

	private List<UIHUDUGC_TwoTeamLeaderboard_TeamItemController> m_Teams;

	private Dictionary<BHGGAEEHJCO, UIHUDUGC_BaseLeaderboard_TeammateItemController> m_TeammateDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override void OnVisibilityChanged()
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

	protected override void UpdateAllTeammateItemInfo()
	{
	}

	private void OnSpaceBtnClick()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnTeamIndexChanged(int cur)
	{
	}

	private void RefreshUIForTeamIndexChanged(int teamIndex, List<object> playerArray, Transform teamItemParent)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void OnPlayerScoreTypesChanged(List<object> cur)
	{
	}

	private void OnLeftPlayerArrayChanged(List<object> cur)
	{
	}

	private void OnRightPlayerArrayChanged(List<object> cur)
	{
	}

	private void _003COnLeftPlayerArrayChanged_003Eb__20_0(BHGGAEEHJCO playerID)
	{
	}

	private void _003COnRightPlayerArrayChanged_003Eb__21_0(BHGGAEEHJCO playerID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAllTeammateItemInfo()
	{
	}
}
