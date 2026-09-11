using GCommon;

namespace COW;

internal class UIHudVehicleActiveBombController : UIHudVehicleItemButtonController
{
	private UIHudVehicleActiveBombView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
