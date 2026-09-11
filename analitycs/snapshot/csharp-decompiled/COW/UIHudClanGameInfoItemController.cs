using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudClanGameInfoItemController : UIHudClanGameInfoBaseItemController, UITable2.IUITable2Item
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}
}
