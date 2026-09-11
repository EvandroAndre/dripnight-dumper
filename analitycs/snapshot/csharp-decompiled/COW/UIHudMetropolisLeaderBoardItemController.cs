using GCommon;

namespace COW;

internal class UIHudMetropolisLeaderBoardItemController : UIHUDSingleFightLeaderBoardItemBaseController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool ShowTop3Icon()
	{
		return false;
	}

	protected override bool UseSelectBGReplaceSelfBG()
	{
		return false;
	}

	protected override void OnRefreshPlayerStats()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShowTop3Icon()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_UseSelectBGReplaceSelfBG()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnRefreshPlayerStats()
	{
	}
}
