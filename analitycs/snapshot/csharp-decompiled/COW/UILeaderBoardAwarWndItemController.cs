using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILeaderBoardAwarWndItemController : UIEasyListItemController
{
	private UILeaderBoardAwarWndItemView m_View;

	private List<UIStandardItemMiniController> m_StandardItems;

	private LeaderBoardAwarWndItemData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
