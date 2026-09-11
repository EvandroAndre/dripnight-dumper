using GCommon;

namespace COW;

public class UIRateGamePopupWindowController : UIPopupWindowController
{
	private UIRateGamePopupWindowView m_View;

	private static bool UseInAppReview => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickSuggestBtn()
	{
	}

	private void OnClickPraiseBtn()
	{
	}

	private void InAppReviewCallback(bool success)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
