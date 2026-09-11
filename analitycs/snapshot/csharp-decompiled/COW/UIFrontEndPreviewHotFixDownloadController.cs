using GCommon;

namespace COW;

public class UIFrontEndPreviewHotFixDownloadController : UIFrontEndPreviewHotFixDownloadBaseController
{
	private UIFrontEndPreviewHotFixDownloadView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewHotFixDownloadBaseView InitBaseView()
	{
		return null;
	}
}
