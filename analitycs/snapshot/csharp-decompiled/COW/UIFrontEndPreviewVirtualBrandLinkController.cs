using GCommon;

namespace COW;

public class UIFrontEndPreviewVirtualBrandLinkController : UIFrontEndPreviewVirtualBrandLinkBaseController
{
	private UIFrontEndPreviewVirtualBrandLinkView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewVirtualBrandLinkBaseView InitBaseView()
	{
		return null;
	}
}
