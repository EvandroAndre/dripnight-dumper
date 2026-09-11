using GCommon;

namespace COW;

public class UIFrontEndPreviewEvoAccessController : UIFrontEndPreviewEvoAccessBaseController
{
	private UIFrontEndPreviewEvoAccessLinkView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewEvoAccessBaseView InitBaseView()
	{
		return null;
	}
}
