namespace COW;

public class PeriodicRankData : CSRankData
{
	public uint GameMode;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static string GetDataKey(uint gameMode, int rank, uint seasonStart)
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public new string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
