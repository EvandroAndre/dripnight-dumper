using GCommon;

namespace COW;

public class UIFrontEndPreviewRelayMartItemDescController : UIFrontEndPreviewItemDescBaseController
{
	private UIFrontEndPreviewRelayMartItemDescView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewItemDescBaseView InitBaseView()
	{
		return null;
	}
}
