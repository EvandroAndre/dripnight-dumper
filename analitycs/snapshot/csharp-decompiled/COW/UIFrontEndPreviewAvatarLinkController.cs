using GCommon;

namespace COW;

public class UIFrontEndPreviewAvatarLinkController : UIFrontEndPreviewAvatarProfileLinkBaseController
{
	private UIFrontEndPreviewAvatarLinkView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewAvatarProfileLinkBaseView InitBaseView()
	{
		return null;
	}
}
