using GCommon;

namespace COW;

public class WeaponExpRankConfig : CSVBaseData
{
	public uint RankLevel;

	public uint Percentage;

	public string BaseColor;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override uint GetUIntKey()
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
