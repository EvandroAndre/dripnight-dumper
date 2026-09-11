using GCommon;

namespace COW;

public class UIHudLobbySocialAreaTargetPlayerActionController : UIBaseController
{
	private UIHudLobbySocialAreaTargetPlayerView m_View;

	private UIHudLobbySocialAreaTargetPlayerInfoController m_TargetPlayerInfoCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUI()
	{
	}

	public void BindPlayer(uint playerID, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
