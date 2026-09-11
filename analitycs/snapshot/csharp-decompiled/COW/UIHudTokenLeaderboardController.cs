using GCommon;

namespace COW;

internal class UIHudTokenLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	public enum InfoType
	{
		TokenCount,
		TotalScore
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void RegisterUIEvent()
	{
	}

	public override void UnRegisterUIEvent()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetInfoType()
	{
	}

	private void OnTokenPlayerInfoChanged(object[] param)
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
