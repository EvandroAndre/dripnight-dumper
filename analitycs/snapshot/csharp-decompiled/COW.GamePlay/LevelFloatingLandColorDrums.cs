using GCommon;

namespace COW.GamePlay;

public class LevelFloatingLandColorDrums : LevelBaseDrum
{
	private ResourceID LNLDNIIDJAF;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	public override ResourceID GetDamagedEffect()
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

	public override NLNIACDLBGF OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public override void OnDrumBroken(uint DLNJGACCOCL, uint KIJMNGPDLCO = 0u)
	{
	}

	protected override void HIMIPPBFODF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public override float GetEffectTime()
	{
		return 0f;
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetModelResourceID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetDamagedEffect()
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

	public NLNIACDLBGF _003C_003EiFixBaseProxy_OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDrumBroken(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_HIMIPPBFODF(byte P0, byte P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public float _003C_003EiFixBaseProxy_GetEffectTime()
	{
		return 0f;
	}
}
