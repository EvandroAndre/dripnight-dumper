using GCommon;

namespace COW;

public class UIFrontEndPreviewPrivilegeEffectController : UIFrontEndPreviewPrivilegeEffectBaseController
{
	private UIFrontEndPreviewPrivilegeEffectView m_UIview;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewPrivilegeEffectBaseView InitBaseView()
	{
		return null;
	}
}
