using GCommon;

public class AroundGameQuickChatData : CSVBaseData, IGetId
{
	public uint Id;

	public string MessageKey;

	public string GameModeCategory;

	public uint Sort;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}
}
