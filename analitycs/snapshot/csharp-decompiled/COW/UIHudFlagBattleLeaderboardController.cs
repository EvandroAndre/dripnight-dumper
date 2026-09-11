using GCommon;

namespace COW;

internal class UIHudFlagBattleLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	private UIModelMatch m_ModelMatch;

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

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	protected void OnScoreChanged(object[] param)
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
