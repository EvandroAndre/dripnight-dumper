using COW.GamePlay;
using GCommon;

namespace COW.HUD;

public class UIHudNameIdentityController : UIBaseController
{
	private UIHudNameIdentityView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private int m_Identity;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
