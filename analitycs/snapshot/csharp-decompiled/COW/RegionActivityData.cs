using GCommon;

namespace COW;

public class RegionActivityData : CSVBaseData
{
	public uint iID;

	public string StyleType;

	public int activityType;

	public int Priority;

	public string[] activityParams;

	public bool PreLoad;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
