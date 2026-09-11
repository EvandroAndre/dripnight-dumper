using GCommon;

namespace COW;

public class AutoPopupWindowCtrlData : CSVBaseData
{
	public int id;

	public int levelLimitA;

	public int regDayLimitA;

	public int levelLimitB;

	public int regDayLimitB;

	public int levelLimitC;

	public int regDayLimitC;

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
