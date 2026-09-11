using GCommon;

namespace COW;

public class UIFrontEndPreviewHackerStoreBundlePreviewController : UIFrontEndPreviewBundlePreviewBaseController
{
	private UIFrontEndPreviewHackerStoreBundlePreviewView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewBundlePreviewBaseView InitBaseView()
	{
		return null;
	}
}
