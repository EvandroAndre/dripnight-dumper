using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudArenaFootballLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudArenaFootballLeaderboardItemController>
{
	private bool m_InitTeamInfo;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetInfoType()
	{
	}

	public override void RegisterUIEvent()
	{
	}

	protected override int SortPlayerData(Transform item2, Transform item1)
	{
		return 0;
	}

	private void Sort(BHGGAEEHJCO pId)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitTeamInfo()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void ShowLeaderBoard(object[] param)
	{
	}

	protected void OnStatsChanged(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(Transform P0, Transform P1)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
