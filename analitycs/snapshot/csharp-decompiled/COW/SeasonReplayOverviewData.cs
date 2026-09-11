using GCommon;

namespace COW;

public class SeasonReplayOverviewData : CSVBaseData
{
	public uint SeasonId;

	public uint MatchMode;

	public uint Rank;

	public float TopRanking;

	public string RankName;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static string GetPrimaryKey(bool isBR, uint rank)
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
