using GCommon;

namespace COW;

public class UIFrontEndPreviewCollectionCustomController : UIFrontendpreviewCollectionCustomBaseController
{
	private UIFrontEndPreviewCollectionCustomView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewCollectionCustomBaseView InitBaseView()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
