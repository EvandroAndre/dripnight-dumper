using GCommon;

namespace COW;

public class NewbieWeaponRecommendData : CSVBaseData
{
	public uint ShowType;

	public uint NewbieType;

	public uint WeaponType;

	public string Title;

	public string Intro;

	public ResourceID Icon;

	public uint SortID;

	public uint[] WeaponId;

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
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

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
