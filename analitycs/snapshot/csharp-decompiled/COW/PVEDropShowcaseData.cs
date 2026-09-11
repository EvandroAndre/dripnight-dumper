using GCommon;

namespace COW;

public class PVEDropShowcaseData : CSVBaseData
{
	public uint ConfigId;

	public int Difficulty;

	public uint ItemId;

	public bool IsPVEToken;

	public bool IsMainDrop;

	public uint GoPos;

	public string SubGoPos;

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
