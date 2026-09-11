using System.Collections.Generic;
using GCommon;

namespace COW;

public class RebateCardNotifyData : CSVBaseData
{
	public string Region;

	public string TimeOfDay;

	public int TimeOfDay_Seconds;

	private static Dictionary<string, RebateCardNotifyData> _Data;

	private const string REGION_DEFAULT = "default";

	public static RebateCardNotifyData Get(string region)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private static int ParseTimeOfDayToSeconds(string timeOfDay)
	{
		return 0;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
