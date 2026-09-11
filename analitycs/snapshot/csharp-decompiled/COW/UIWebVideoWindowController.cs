using GCommon;

namespace COW;

internal class UIWebVideoWindowController : UIWebViewWindowBaseController
{
	private UIWebVideoWindowView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(string url, bool forcePlay = false, string bgCdnUrl = null)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void EnableLobbyBGM(bool v)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
