using GCommon;

namespace COW.HUD;

internal class UIHudLockedTargetController : UIHudVehicleAsMissileTargetControllerBase
{
	private UIHudLockedTargetView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
