using GCommon;
using UnityEngine;

namespace COW.HUD;

public abstract class UIHudVehiclePosControllerBase : UIHudEntityPosControllerBase
{
	protected override void OnRegisterEvents()
	{
	}

	protected override void OnUnRegisterEvents()
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnTargetPlayerChanged(object[] data)
	{
	}

	private void OnVehicleDead(object[] data)
	{
	}

	protected virtual void CheckBindingForPlayerChange(Object player = null)
	{
	}

	public override void BindTarget(Entity e)
	{
	}

	public void _003C_003EiFixBaseProxy_BindTarget(Entity P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnRegisterEvents()
	{
	}
}
