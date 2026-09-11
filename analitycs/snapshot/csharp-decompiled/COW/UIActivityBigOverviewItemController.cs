using GCommon;
using proto;

namespace COW;

public class UIActivityBigOverviewItemController : UIBaseController, IOverViewController
{
	private UIActivityBigOverviewItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetCategoryTitle(string title)
	{
	}

	public void SetViewData(ClientActivityDesc desc)
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	public void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
