using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudChangeClothButtonController : UIBaseController
{
	private UIHudChangeClothButtonView m_View;

	private UIHudChangeClothListController ctrl;

	private List<InventoryClothInfo> allClothsId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnChangeClothClick()
	{
	}

	private void AutoChangeCloth()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
