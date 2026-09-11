using GCommon;

namespace COW;

public class ChatStickerPrice : CSVBaseData
{
	public uint ID;

	public string Name;

	public uint GemsPrice;

	public uint CoinsPrice;

	public uint Gopos;

	public uint GoposParam;

	public ResourceID Icon;

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
