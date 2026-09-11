using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabRemakeController : UIStandardTabController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container)
	{
		return null;
	}

	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0)
	{
		return null;
	}
}
