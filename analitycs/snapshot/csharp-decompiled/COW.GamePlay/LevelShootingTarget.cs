using GCommon;

namespace COW.GamePlay;

public class LevelShootingTarget : LevelBaseDrum
{
	public enum HHPCKNPDKKO
	{
		typeA,
		typeB,
		typeC
	}

	public HHPCKNPDKKO ModelType;

	protected override void OnAwake()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public override NLNIACDLBGF OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnOnDestroy()
	{
	}

	public override ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	public override int GetMaxDurability()
	{
		return 0;
	}

	public override ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	protected override void HIMIPPBFODF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public NLNIACDLBGF _003C_003EiFixBaseProxy_OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetModelResourceID()
	{
		return default(ResourceID);
	}

	public int _003C_003EiFixBaseProxy_GetMaxDurability()
	{
		return 0;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetExplodeSound()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_HIMIPPBFODF(byte P0, byte P1)
	{
	}
}
