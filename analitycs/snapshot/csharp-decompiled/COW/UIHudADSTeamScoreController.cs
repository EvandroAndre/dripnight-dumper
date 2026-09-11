using GCommon;

namespace COW;

internal class UIHudADSTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHudADSTeamScoreItemController>
{
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

	protected override ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetInfoType()
	{
	}

	protected void OnScoreChanged(object[] param)
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	private void Refresh1v1PlayerWin(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetTitileResourceID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
