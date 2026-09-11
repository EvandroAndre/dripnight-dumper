namespace COW;

public class CSSharedItemDataHotFix : CSSharedItemData
{
	private byte configSubType;

	private string configEndTime;

	public new uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public new string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}
}
