using GCommon;

namespace COW;

internal class UIHudTokenMatchResultController : UIHudTeamBattleMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}
}
