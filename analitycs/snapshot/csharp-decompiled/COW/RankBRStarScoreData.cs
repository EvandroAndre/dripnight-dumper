using GCommon;

namespace COW;

public class RankBRStarScoreData : CSVBaseData
{
	public uint Rank;

	public uint StarCount;

	public bool IsFuncAlive;

	public uint LowerBound;

	public uint UpperBound;

	public ResourceID ColorResource;

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
