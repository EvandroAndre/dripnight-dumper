using GCommon;

namespace COW;

internal class UIHudVehicleBoostController : UIHudVehicleItemButtonController
{
	private UIHudVehicleBoostView m_View;

	private bool m_DriverAiming;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnDriverAiming(object[] param)
	{
	}

	protected override void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	protected override bool ShouldHide()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerGetOnVehicle(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_ShouldHide()
	{
		return false;
	}
}
