using GCommon;

namespace COW;

public class WeaponScopeSkinData : CSVBaseData, IGetId
{
	public uint ItemID;

	public ResourceID HudSightVFX_Eight;

	public ResourceID HudSightOpeningVFX_Eight;

	public ResourceID HudSightVFX_Four;

	public ResourceID HudSightOpeningVFX_Four;

	public ResourceID HudSightVFX;

	public ResourceID HudSightOpeningVFX;

	public ResourceID HudSightVFX_Reddot;

	public ResourceID HudSightOpeningVFX_Reddot;

	public ResourceID HudSightReskinSight;

	public ResourceID HudSightReskinOpening;

	public ResourceID HudSightReskin_Thermal;

	public ResourceID HudSightReskin_Eight;

	public ResourceID HudSightReskin_Four;

	public ResourceID HudSightReskin_Two;

	public ResourceID HudSightReskin_Reddot;

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
