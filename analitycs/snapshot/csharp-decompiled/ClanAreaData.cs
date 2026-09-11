using GCommon;

public class ClanAreaData : CSVBaseData
{
	public uint ID;

	public string FirstGrade;

	public string SecondGrade;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
