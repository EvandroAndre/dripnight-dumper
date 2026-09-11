using GCommon;

namespace COW;

internal class UIHudAvatarTransformerEntryController : UIBaseController
{
	private UIHudAvatarTransformerEntryView m_View;

	private UIHudAvatarTransformer m_HudAvatarTransformerCtrl;

	private UIHudAvatarTransformerFreeMultiController[] m_HudAvatarTransformerFreeMultiCtrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Init(uint transformerId)
	{
	}

	public void InitForSocialLobby(uint transformerId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
