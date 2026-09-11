using GCommon;

namespace COW;

public class WorkshopCommentConfigData : CSVBaseData
{
	public uint ID;

	public uint Type;

	public string Key;

	public uint Group;

	public uint Rank;

	public uint[] IncludeTag;

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
