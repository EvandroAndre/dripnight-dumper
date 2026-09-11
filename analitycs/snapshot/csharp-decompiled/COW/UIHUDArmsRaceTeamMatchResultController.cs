using GCommon;
using proto;

namespace COW;

internal class UIHUDArmsRaceTeamMatchResultController : UIHudTeamBattleMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	private void ShowTeamInfo()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}
}
