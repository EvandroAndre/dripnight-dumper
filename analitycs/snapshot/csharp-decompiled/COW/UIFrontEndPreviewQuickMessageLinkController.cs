using GCommon;

namespace COW;

public class UIFrontEndPreviewQuickMessageLinkController : UIFrontEndPreviewQuickMessageLinkBaseController
{
	private UIFrontEndPreviewQuickMessageLinkView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewQuickMessageLinkBaseView InitBaseView()
	{
		return null;
	}
}
