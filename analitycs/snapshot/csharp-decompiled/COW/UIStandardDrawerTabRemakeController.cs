using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardDrawerTabRemakeController : UIStandardDrawerTabController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardTabItemController CreateTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	protected UIStandardTabItemController CreateImageTabItem(Transform container, StandardTabItemViewData mainTabData)
	{
		return null;
	}

	public void CreateImageTabByData(StandardTabItemViewData mainTabData, List<StandardSubTabItemViewData> subTabDataist, bool needupdateanim = false)
	{
	}

	public UIStandardTabItemController _003C_003EiFixBaseProxy_CreateTabItem(Transform P0, StandardTabItemViewData P1)
	{
		return null;
	}
}
