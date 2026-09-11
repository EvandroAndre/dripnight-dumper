using GCommon;
using UnityEngine;

namespace COW;

public class UIPopWndStandardTabItemRemakeController : UIStandardTabItemRemakeController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	protected override void UpdateExtraSubTabView(bool value)
	{
	}

	public new UIStandardSubTabItemController _003C_003EiFixBaseProxy_CreateSubTabItem(Transform P0, bool P1)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_UpdateExtraSubTabView(bool P0)
	{
	}
}
