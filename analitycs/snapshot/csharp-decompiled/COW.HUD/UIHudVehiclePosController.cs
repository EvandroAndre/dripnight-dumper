using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudVehiclePosController : UIHudVehiclePosControllerBase
{
	private UIHudVehiclePosView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnRegisterEvents()
	{
	}

	protected override void OnUnRegisterEvents()
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	protected override void CheckBindingForPlayerChange(Object player = null)
	{
	}

	private void CheckBindingForPlayerChange(Player changedPlayer = null, bool getOn = false)
	{
	}

	public override void RecycleUI()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRegisterEvents()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckBindingForPlayerChange(Object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleUI()
	{
	}
}
