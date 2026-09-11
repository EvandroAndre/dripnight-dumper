using GCommon;

namespace COW;

internal class UIHudVehicleOverdriveSingleHandController : UIHudVehicleOverdriveController
{
	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public EControlMode _003C_003EiFixBaseProxy_ShowInControlMode()
	{
		return EControlMode.Default;
	}
}
