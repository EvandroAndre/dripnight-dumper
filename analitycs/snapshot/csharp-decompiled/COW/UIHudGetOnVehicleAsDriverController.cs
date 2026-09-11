using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudGetOnVehicleAsDriverController : UIHudGetOnVehicleController
{
	private UIHudGetOnVehicleAsDriverView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override bool ShouldShow(bool driverEmpty, bool passengerEmpty)
	{
		return false;
	}

	public override void OnActionEnter(object[] param)
	{
	}

	public override void Show()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	public void SetButtonState(Player.AALGCBFJHJM status)
	{
	}

	private void OnHackBtnClick()
	{
	}

	private void OnHackBtnRelease()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShouldShow(bool P0, bool P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnActionEnter(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
