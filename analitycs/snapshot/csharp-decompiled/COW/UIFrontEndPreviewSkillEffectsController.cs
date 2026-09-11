using GCommon;

namespace COW;

public class UIFrontEndPreviewSkillEffectsController : UIFrontEndPreviewSkillEffectsBaseController
{
	private UIFrontEndPreviewSkillEffectsView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewSkillEffectsBaseView InitBaseView()
	{
		return null;
	}
}
