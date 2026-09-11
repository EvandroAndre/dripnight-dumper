using GCommon;

namespace COW;

internal class UIHudVehicleAutoDriveController : UIHudVehicleButtonBaseController
{
	private UIHudVehicleAutoDriveView m_View;

	protected override void OnUIInit()
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override bool CanLockInput()
	{
		return false;
	}

	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanLockInput()
	{
		return false;
	}
}
