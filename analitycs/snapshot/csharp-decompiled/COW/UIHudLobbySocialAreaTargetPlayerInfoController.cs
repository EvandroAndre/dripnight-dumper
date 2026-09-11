using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudLobbySocialAreaTargetPlayerInfoController : UIBaseController
{
	private BHGGAEEHJCO m_PlayerID;

	private UIHudTargetPlayerInfoBtnView m_View;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_Source;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPlayerData(uint playerID, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	private void OnClickActionBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
