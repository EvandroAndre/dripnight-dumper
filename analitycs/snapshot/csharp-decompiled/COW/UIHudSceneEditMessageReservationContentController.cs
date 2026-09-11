using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudSceneEditMessageReservationContentController : UIBaseController
{
	private UIHudSceneEditMessageReservationContentView m_View;

	private List<UIHudSceneEditMessageReservationItemController> m_ItemList;

	private UIModelTeamReserve m_ModelReserve;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshReservateItems()
	{
	}

	private void OnReservationBlockClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
