using GCommon;
using UnityEngine;

namespace COW;

public class UIPopWndStandardDrawerTabRemakeController : UIStandardDrawerTabController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0, StandardTabItemViewData P1)
	{
		return null;
	}
}
