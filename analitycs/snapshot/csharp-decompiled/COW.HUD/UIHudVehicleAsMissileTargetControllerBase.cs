using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.HUD;

internal class UIHudVehicleAsMissileTargetControllerBase : UIHudVehiclePosControllerBase
{
	protected List<LevelMissileBase> m_BindMissiles;

	protected bool m_AimTarget;

	protected override void CheckBindingForPlayerChange(Object player = null)
	{
	}

	internal void BindMissile(LevelMissileBase m)
	{
	}

	internal void UnBindMissile(LevelMissileBase m)
	{
	}

	public virtual void SetAsAimTarget(bool b, object[] data)
	{
	}

	public override void RecycleUI()
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleUI()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckBindingForPlayerChange(Object P0)
	{
	}
}
