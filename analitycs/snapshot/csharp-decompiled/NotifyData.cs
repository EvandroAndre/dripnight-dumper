using GCommon;

public class NotifyData : CSVBaseData
{
	public string ID;

	public string NotifyType;

	public string NotifyContentString;

	public string NotifyTypePic;

	public uint Duration;

	public uint CD;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
