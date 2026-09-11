using GCommon;

namespace COW;

public class UIFrontEndPreviewSpecialBundleLinkController : UIFrontEndPreviewSpecialBundleLinkBaseController
{
	private UIFrontEndPreviewSpecialBundleLinkView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewSpecialBundleLinkBaseView InitBaseView()
	{
		return null;
	}
}
