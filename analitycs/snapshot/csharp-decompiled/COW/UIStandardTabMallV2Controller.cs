using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabMallV2Controller : UIStandardTabRemakeController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	public new UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0)
	{
		return null;
	}
}
