using GCommon;

namespace COW;

public class CSRoundPickBuffData : CSVBaseData
{
	public uint Id;

	public string Desc;

	public string DescParams;

	public string[] Params;

	public uint level;

	public uint maxLevel;

	public string name;

	public ResourceID icon;

	public ResourceID iconQuality;

	public uint showType;

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
