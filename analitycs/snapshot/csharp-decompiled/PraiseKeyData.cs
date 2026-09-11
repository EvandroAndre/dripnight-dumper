using GCommon;

public class PraiseKeyData : CSVBaseData
{
	public int Index;

	public string Key;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
