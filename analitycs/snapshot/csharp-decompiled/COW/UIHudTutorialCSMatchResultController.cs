using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudTutorialCSMatchResultController : UIHudCSMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}
}
