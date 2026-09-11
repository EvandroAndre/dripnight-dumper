using GCommon;

namespace COW;

public class UIInsufficientDiamondsPopupWndSmallController : UIPopupWindowController
{
	private UIInsufficientDiamondsPopupWndSmallView m_View;

	private UINavigationUtil.UINavigationFrom m_From;

	private bool m_IsCloseByGoto;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UINavigationUtil.UINavigationFrom from, int needGems)
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnIAPBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
