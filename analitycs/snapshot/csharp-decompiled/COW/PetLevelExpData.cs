using GCommon;

namespace COW;

internal class PetLevelExpData : CSVBaseData
{
	public int Lv;

	public int ExpNormal;

	public int ExpGood;

	public int ExpRare;

	public int ExpEpic;

	public int ExpLegend;

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
