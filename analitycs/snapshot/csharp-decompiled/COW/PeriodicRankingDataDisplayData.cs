using GCommon;

namespace COW;

public class PeriodicRankingDataDisplayData : CSVBaseData
{
	public int GameMode;

	public bool ShowDoubleKill;

	public bool ShowQuadraKill;

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
