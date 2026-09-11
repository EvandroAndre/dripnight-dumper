using COW.GamePlay;
using GCommon;

namespace COW.HUD;

internal class UIHudVehiclePassengerSkillController : UIHudVehicleItemButtonController
{
	private UIHudVehiclePassengerSkillView m_View;

	protected DKCOBGILPCO ItemTargetSlot;

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

	protected override void OnDestroy()
	{
	}

	protected override void UpdateCd(BDBKGOMDIME item)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateCd(BDBKGOMDIME P0)
	{
	}
}
