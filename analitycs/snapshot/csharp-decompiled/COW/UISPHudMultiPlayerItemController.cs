using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UISPHudMultiPlayerItemController : UIEasyListItemController
{
	private UISPHudMultiPlayerItemView m_View;

	private List<UISPHudSinglePlayerItemController> m_Ctrl;

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
