using COW;
using GCommon;

public class ClanTagData : CSVBaseData
{
	public uint ID;

	public EClanTagType Class;

	public string Tag;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
