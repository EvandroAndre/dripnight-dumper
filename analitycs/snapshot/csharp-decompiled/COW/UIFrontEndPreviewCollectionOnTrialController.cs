using GCommon;

namespace COW;

public class UIFrontEndPreviewCollectionOnTrialController : UIFrontEndPreviewCollectionOnTrialBaseController
{
	private UIFrontEndPreviewCollectionOnTrialView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewCollectionOnTrialBaseView InitBaseView()
	{
		return null;
	}
}
