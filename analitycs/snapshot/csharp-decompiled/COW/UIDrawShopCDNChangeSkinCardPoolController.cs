using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopCDNChangeSkinCardPoolController : UIDrawShopUnlimitedCardPoolController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIDrawShopUnlimitedCardPoolItemController OpenCardPoolItemController(Transform parentTransform)
	{
		return null;
	}

	public UIDrawShopUnlimitedCardPoolItemController _003C_003EiFixBaseProxy_OpenCardPoolItemController(Transform P0)
	{
		return null;
	}
}
