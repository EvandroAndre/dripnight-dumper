using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class AutoTagClassificationData : CSVBaseData
{
	public uint MainPriority;

	public CDEEDEPINKI Type;

	public int SubType;

	public AutoSearchItemDataIDNum[] ItemArray;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static int AutoSearchComparison(AutoTagClassificationData t1, AutoTagClassificationData t2)
	{
		return 0;
	}

	public static List<AutoTagClassificationData> GetAutoSearchSortedList()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
