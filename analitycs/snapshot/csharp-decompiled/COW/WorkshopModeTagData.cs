using GCommon;

namespace COW;

public class WorkshopModeTagData : CSVBaseData
{
	public uint ID;

	public string Comment;

	public string TagKey;

	public bool IsObsolete;

	public int TagFilter;

	public int TagColor;

	public int Priority;

	public uint CraftlandTagType;

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
