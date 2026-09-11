using GCommon;

namespace COW;

public class UIFrontEndPreviewWeaponPropertyPanelController : UIFrontEndPreviewWeaponPropertyPanelBaseController
{
	private UIFrontEndPreviewWeaponPropertyPanelView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewWeaponPropertyPanelBaseView InitBaseView()
	{
		return null;
	}
}
