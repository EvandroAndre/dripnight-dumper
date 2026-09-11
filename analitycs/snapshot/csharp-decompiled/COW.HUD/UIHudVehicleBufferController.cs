using GCommon;

namespace COW.HUD;

public class UIHudVehicleBufferController : UIBaseController
{
	private UIHudVehicleBufferView m_View;

	private float m_StartTime;

	private float m_CDTime;

	private uint vItemID;

	public uint VehicleItemID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ResetUIData(uint vehicleItemID)
	{
	}

	public float UpdateView()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
