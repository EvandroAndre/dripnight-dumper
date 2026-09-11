using GCommon;

namespace COW;

public class WorkShopResourceTypeData : CSVBaseData
{
	public uint OptionID;

	public string OptionKey;

	public uint OptionSortID;

	public bool IsMustMode;

	public uint FatherOptionID;

	public string TabIcon;

	public bool IsHide;

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
