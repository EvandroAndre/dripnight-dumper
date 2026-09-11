using GCommon;
using message;

namespace COW;

internal class UIHudMetropolisLeaderBoardController : UIHUDSingleFightLeaderBoardBaseController<UIHudMetropolisLeaderBoardItemController>
{
	private UIHudMetropolisLeaderBoardSwitchFactionController m_SwitchFactionCtrl;

	private AFBOKKIDEAB m_CurSelectedFaction;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void RegisterUIEvent()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void SetInfoTypeList()
	{
	}

	protected override void SetSortingTypes()
	{
	}

	public override void Show()
	{
	}

	public override void Sort()
	{
	}

	private void OnPlayerFactionChanged(object[] param)
	{
	}

	private void OnSwitchFactionRank(AFBOKKIDEAB factionId)
	{
	}

	public override void RefreshGrid()
	{
	}

	private void OnPlayerExit(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoTypeList()
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortingTypes()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Sort()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshGrid()
	{
	}
}
