using GCommon;

public class NewVaultDefaultID : CSVBaseData, IGetId
{
	public uint ItemID;

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
