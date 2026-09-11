using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIRoomDuoPlayerItemController : UIEasyListItemController
{
	private UIRoomDuoPlayerItemView m_View;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
