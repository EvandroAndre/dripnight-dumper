using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudItemMarkShowItemController : UIBaseController
{
	private UIHudItemMarkShowItemView m_View;

	private uint m_ItemId;

	private Vector3 ItemPosition;

	private bool m_IsLocalOnlyVisible;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshItemInfo(uint dataID, uint Count, Vector3 Position, bool isLocalOnlyVisible)
	{
	}

	private void OnClickItemMark()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
