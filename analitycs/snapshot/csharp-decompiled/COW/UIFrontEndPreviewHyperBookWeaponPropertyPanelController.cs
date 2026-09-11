using GCommon;

namespace COW;

public class UIFrontEndPreviewHyperBookWeaponPropertyPanelController : UIFrontEndPreviewWeaponPropertyPanelBaseController
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
