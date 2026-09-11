using GCommon;
using proto;

namespace COW;

public class NewPlayerSevenDaysAwardData : CSVBaseData
{
	public uint achievementId;

	public uint mustDoTask;

	public uint dayID;

	public string dayTitleKey;

	public int achievementCount;

	public uint[] achievementIDArray;

	public AwardDesc award;

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
