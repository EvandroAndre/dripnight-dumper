using GCommon;

namespace COW;

internal class UIHudVehicleChangeSpeedZoneController : UIHudVehicleItemButtonController
{
	private UIHudVehicleChangeSpeedZoneView m_View;

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

	protected override void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerGetOnVehicle(object[] P0)
	{
	}
}
