using GCommon;

namespace COW;

public class UIFrontEndPreviewWeaponProgressBarController : UIFrontEndPreviewWeaponProgressBarBaseController
{
	private UIFrontEndPreviewProgressBarView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewWeaponProgressBarBaseView InitBaseView()
	{
		return null;
	}
}
