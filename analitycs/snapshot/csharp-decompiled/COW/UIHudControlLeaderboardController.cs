using GCommon;

namespace COW;

internal class UIHudControlLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
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

	private void OnSyncLeaderBoard(object[] data)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
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
}
