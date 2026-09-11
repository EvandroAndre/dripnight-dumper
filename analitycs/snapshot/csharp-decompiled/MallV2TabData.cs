using GCommon;

public class MallV2TabData : CSVBaseData, IGetId
{
	public uint TabID;

	public string TabName;

	public int Priority;

	public uint MallType;

	public uint DiscountIsOpen;

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
