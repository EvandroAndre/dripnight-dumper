using GCommon;

namespace COW;

internal class UITutorialWebviewController : UIWebViewWindowBaseController
{
	private UITutorialWebViewView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(string url, string title)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
