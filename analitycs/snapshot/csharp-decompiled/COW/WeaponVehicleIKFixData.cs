using GCommon;

namespace COW;

public class WeaponVehicleIKFixData : CSVBaseData, IGetId
{
	public float FemaleMoveAngleZ;

	public float FemaleMoveAngleX;

	public float FemaleIdleAngleZ;

	public float FemaleIdleAngleX;

	public float MaleMoveAngleZ;

	public float MaleMoveAngleX;

	public float MaleIdleAngleZ;

	public float MaleIdleAngleX;

	public uint MountableWeaponType;

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
