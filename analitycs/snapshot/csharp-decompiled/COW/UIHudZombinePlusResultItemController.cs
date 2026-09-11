using GCommon;
using proto;

namespace COW;

public class UIHudZombinePlusResultItemController : UIHudNormalMatchResultItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}
}
