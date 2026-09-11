using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelSmokeDrum : LevelBaseDrum
{
	public BoxCollider m_Trigger;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	public override ResourceID GetExplodeEffect()
	{
		return default(ResourceID);
	}

	public override ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	public override float GetEffectTime()
	{
		return 0f;
	}

	public override NLNIACDLBGF OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	protected override void HIMIPPBFODF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetModelResourceID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetExplodeEffect()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetExplodeSound()
	{
		return default(ResourceID);
	}

	public float _003C_003EiFixBaseProxy_GetEffectTime()
	{
		return 0f;
	}

	public NLNIACDLBGF _003C_003EiFixBaseProxy_OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	public void _003C_003EiFixBaseProxy_HIMIPPBFODF(byte P0, byte P1)
	{
	}
}
