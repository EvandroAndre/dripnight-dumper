using GCommon;

namespace COW;

public class PlayerSocialTagsData : CSVBaseData
{
	public string ShowKey;

	public uint TypeID;

	public uint SortID;

	public string ShowIcon;

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
