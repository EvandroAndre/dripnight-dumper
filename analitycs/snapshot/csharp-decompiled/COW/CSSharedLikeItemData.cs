using GCommon;

namespace COW;

public class CSSharedLikeItemData : CSVBaseData, IGetId
{
	public uint id;

	public string name;

	public string desc;

	public ResourceID iconRes;

	public ResourceID bigIconRes;

	public byte rare;

	public string Name => null;

	public string Description => null;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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
