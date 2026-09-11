using GCommon;

namespace COW;

public class LinkMvpScoreData : CSVBaseData
{
	public uint Id;

	public int MinScore;

	public int MaxScore;

	public string Evaluation;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static string GetEvaluation(int score)
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
