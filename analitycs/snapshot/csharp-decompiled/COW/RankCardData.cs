using GCommon;

namespace COW;

public class RankCardData : CSVBaseData
{
	public int Id;

	public int RPTimes;

	public int TokenTimes;

	public ERankCardType type;

	public int LowerRank;

	public int UpperRank;

	public string CardDesc;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private ERankCardType GetCardType(int CardType)
	{
		return ERankCardType.NONE;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
