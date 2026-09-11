using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVehicleJumpController : UIHudVehicleItemButtonController
{
	private UIHudVehicleJumpView m_View;

	private bool m_IsHighlight;

	private new Vehicle m_Vehicle;

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

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void Update()
	{
	}

	private void SetHightlight(bool highlight)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}
}
