using GCommon;

namespace COW;

public class RegionLock : CSVBaseData
{
	public string RegionServer;

	public string[] IpRegions;

	public string[] Languages;

	public string ActiveTime;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
