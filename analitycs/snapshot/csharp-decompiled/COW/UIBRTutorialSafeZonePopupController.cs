using COW.GamePlay;
using GCommon;

namespace COW;

public class UIBRTutorialSafeZonePopupController : UIInGameBasePopupController
{
	private UIBRTutorialSafeZonePopupView m_View;

	private SafeZone m_CurrentSafeZone;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitPhases()
	{
	}

	private void OnJumpActionEnter(int data, int data2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
