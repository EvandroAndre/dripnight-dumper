using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIRoomPlayersItemController : UIEasyListItemController
{
	private UIRoomPlayersItemView m_View;

	private List<RoomPlayerInfo> m_Members;

	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	private new int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetWidgetWidth()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnSelectedChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
