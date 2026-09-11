using GCommon;

namespace COW;

public class UIFrontEndPreviewPrivilegeCarouselController : UIFrontEndPreviewPrivilegeCarouselBaseController
{
	private UIFrontEndPreviewPrivilegeCarouselView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewPrivilegeCarouselBaseView InitBaseView()
	{
		return null;
	}
}
