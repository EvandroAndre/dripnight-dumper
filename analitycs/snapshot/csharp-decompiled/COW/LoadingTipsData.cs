using GCommon;

namespace COW;

public class LoadingTipsData : CSVBaseData
{
	public uint iID;

	public uint minLevel;

	public uint maxLevel;

	public uint modeId;

	public string tipsContent;

	public uint[] matchMode;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool FitMatchMode(uint iMatchMode)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
