using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVehicleResetController : UIHudButtonBaseController
{
	private UIHudVehicleResetView m_View;

	private Vehicle m_Vehicle;

	private float m_ResetTime;

	private float m_ResetVal;

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

	private void Update()
	{
	}

	private void OnTryReset()
	{
	}

	private void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	private void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
