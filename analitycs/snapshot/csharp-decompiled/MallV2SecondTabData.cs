using GCommon;

public class MallV2SecondTabData : CSVBaseData, IGetId
{
	public uint SecondTabID;

	public uint TabID;

	public string Icon;

	public int Priority;

	public uint StyleType;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public uint GetId()
	{
		return 0u;
	}
}
