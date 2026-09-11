using GCommon;
using proto;

namespace COW;

public class NewPlayerSevenDaysData : CSVBaseData
{
	public int achievementID;

	public string achievementIntro;

	public string ahievemtnDetailKey;

	public bool haveGoto;

	public int gotoGuideID;

	public int CdtValue;

	public AwardDesc award;

	public int PreCdtValue;

	public uint Gopos;

	public string SubGopos;

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
