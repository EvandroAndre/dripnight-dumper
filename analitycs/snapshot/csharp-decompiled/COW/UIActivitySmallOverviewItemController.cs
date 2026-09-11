using GCommon;
using proto;

namespace COW;

public class UIActivitySmallOverviewItemController : UIBaseController, IOverViewController
{
	private UIActivitySmallOverviewItemView m_View;

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

	public void SetViewData(ClientActivityDesc desc0, ClientActivityDesc desc1)
	{
	}

	public void Reload()
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
