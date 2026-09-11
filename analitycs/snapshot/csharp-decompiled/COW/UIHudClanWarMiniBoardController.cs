using GCommon;

namespace COW;

internal class UIHudClanWarMiniBoardController : UIBaseController
{
	private UIHudClanWarMiniBoardView m_View;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelUser m_ModelUser;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
