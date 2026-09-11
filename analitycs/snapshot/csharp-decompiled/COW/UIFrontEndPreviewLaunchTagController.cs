using GCommon;

namespace COW;

public class UIFrontEndPreviewLaunchTagController : UIFrontEndPreviewLaunchTagBaseController
{
	private UIFrontEndPreviewLaunchTagView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewLaunchTagBaseView InitBaseView()
	{
		return null;
	}
}
