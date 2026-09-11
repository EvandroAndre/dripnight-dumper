using GCommon;

namespace COW;

public class TechAirDropSkin : CSVBaseData, IGetId
{
	public string TechPointInactiveIconName;

	public string actSys;

	public string LaserOffPos;

	public string TechPointActiveGlowColor;

	public string TechPointActiveIcon;

	public string CreateTipsKey;

	public string UnlockTipsKey;

	public string EnemyUnlockTipsKey;

	public string IconName;

	public string TechPointActiveIconName;

	public ResourceID TechPointActiveTrailVFX;

	public ResourceID LootLaserResID;

	public ResourceID EnemyUnlockTipsResID;

	public ResourceID VFXOccupyingResID;

	public ResourceID UnlockTipsResID;

	public ResourceID CreateSoundResID;

	public ResourceID LaserResID;

	public ResourceID CreateTipsResID;

	public ResourceID UnlockInstantSoundResID;

	public ResourceID DisappearEffectResID;

	public ResourceID AppetizerUnlockInstantEffectResID;

	public ResourceID UnlockInstantEffectResID;

	public ResourceID VFXInteractFence;

	public ResourceID OpenEffectResID;

	public ResourceID UnlockCountDownLabelResID;

	public ResourceID UnlockEffectResID;

	public uint SkinType;

	public ResourceID ModelResID;

	public ResourceID SFXOccupyingResID;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
