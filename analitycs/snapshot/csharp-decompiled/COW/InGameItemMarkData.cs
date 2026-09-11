using GCommon;

namespace COW;

public class InGameItemMarkData : CSVBaseData
{
	public string LevelObjectType;

	public string MarkNameKey;

	public ResourceID MarkIconRes;

	public string MarkIconResName;

	public bool IfReserve;

	public uint QucikChatId1;

	public uint QucikChatId2;

	public uint QucikChatId3;

	public uint QucikChatId4;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
