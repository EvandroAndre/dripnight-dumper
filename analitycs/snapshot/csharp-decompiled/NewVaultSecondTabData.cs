using GCommon;

public class NewVaultSecondTabData : CSVBaseData, IGetId
{
	public int SecondTabID;

	public int TabID;

	public string Icon;

	public ResourceID IconRes;

	public int Priority;

	public int IsHide;

	public int Modifier;

	public int IsNeedFilter;

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
