using GCommon;

public class ItemBigIconData : CSVBaseData, IGetId
{
	public uint ItemId;

	private ResourceID bigIconResId;

	private ResourceID bigIconResIdNoBlood;

	public string BigIconName;

	private string BigIconNameNoBlood;

	public ResourceID BigIconResId => default(ResourceID);

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void SetBigIconRes(ResourceID iconRes)
	{
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
