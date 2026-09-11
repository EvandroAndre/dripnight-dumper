using GCommon;

public class NewVaultTabData : CSVBaseData, IGetId
{
	public int TabID;

	public string TabName;

	public int Priority;

	public int IsHide;

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
