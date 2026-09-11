using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVehicleBrakeController : UIHudVehicleButtonBaseController
{
	private UIHudVehicleBrakeView m_View;

	private Vehicle m_Vehicle;

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

	public void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	private void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	protected override void OnBtnClick()
	{
	}

	private void Update()
	{
	}

	private void SendVehicleBrake()
	{
	}

	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}
}
