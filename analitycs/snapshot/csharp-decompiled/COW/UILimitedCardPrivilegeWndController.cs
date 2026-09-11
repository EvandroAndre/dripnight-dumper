using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UILimitedCardPrivilegeWndController : UIBaseController
{
	private UILimitedCardPrivilegeWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<Item> playItemLimitedCardList, UIAnchor.Side pivot = UIAnchor.Side.Center)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
