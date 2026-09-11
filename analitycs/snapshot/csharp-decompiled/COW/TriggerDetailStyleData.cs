using GCommon;

namespace COW;

public class TriggerDetailStyleData : CSVBaseData
{
	public uint ID;

	public string Title;

	public string Desc;

	public string TeamName;

	public ResourceID TextureResID;

	public ResourceID TeamIconRes;

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
