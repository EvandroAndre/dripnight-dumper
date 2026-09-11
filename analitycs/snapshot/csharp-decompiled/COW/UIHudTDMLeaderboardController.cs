using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTDMLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
{
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

	public override void UnRegisterUIEvent()
	{
	}

	protected override bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	protected override int SortPlayerData(Transform item2, Transform item1)
	{
		return 0;
	}

	private void Sort(BHGGAEEHJCO pId)
	{
	}

	protected override void OnKillCountChanged(object[] param)
	{
	}

	protected override void OnDeadCountChanged(object[] param)
	{
	}

	protected override void OnTotalDamageChanged(object[] param)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
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

	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTeamOnLeft(BHGGAEEHJCO P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(Transform P0, Transform P1)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnKillCountChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDeadCountChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTotalDamageChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
