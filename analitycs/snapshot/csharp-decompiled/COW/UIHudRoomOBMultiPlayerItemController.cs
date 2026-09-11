using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRoomOBMultiPlayerItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIHudRoomOBMultiPlayerItemView m_View;

	private readonly List<UIHudRoomOBPlayerStateItem> m_RowPlayerItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SelectedPlayer(object[] data)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	private UIHudRoomOBPlayerStateItem GetOrCreatePlayerRow(int index)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
