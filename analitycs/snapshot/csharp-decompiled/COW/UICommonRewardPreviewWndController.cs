using System.Collections.Generic;
using GCommon;

namespace COW;

public class UICommonRewardPreviewWndController : UIPopupWindowController
{
	private UICommonRewardPreviewWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<BaseItemInfo> descs, bool claimed, bool forceFullScreen = false)
	{
	}

	public void SetLabel(string labelOne, string labelTwo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
