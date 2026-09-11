using GCommon;

namespace COW;

public class UIFrontEndPreviewItemDescController : UIFrontEndPreviewItemDescBaseController
{
	private UIFrontEndPreviewItemDescView m_UIView;

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
