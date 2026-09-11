using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRoomOBSinglePlayerItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIHudRoomOBSinglePlayerItemView m_View;

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

	public void BindPlayer(PlayerData data)
	{
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
