using GCommon;

namespace COW;

internal class UIHUDTeamArmsRaceScoreBoardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	private int m_SelfArmLevel;

	private int m_OpponentArmLevel;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
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

	private void OnGameArmsListCome(object[] param)
	{
	}

	private void OnSelfArmLevelCome(object[] param)
	{
	}

	private void OnOpponentArmLevelCome(object[] param)
	{
	}

	private void UpdateLeftWeaponIcon()
	{
	}

	private void UpdateRightWeaponIcon()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
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
}
