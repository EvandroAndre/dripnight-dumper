using GCommon;
using proto;

namespace COW;

public class UIGachaExtraPreviewWndController : UIPopupWindowController
{
	private UICommonRewardPreviewWndView m_View;

	private bool m_ClaimState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ExtraRewardDesc desc, bool needPeriod = true)
	{
	}

	private void ShowLeftTimeLabel(ExtraRewardDesc desc)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
