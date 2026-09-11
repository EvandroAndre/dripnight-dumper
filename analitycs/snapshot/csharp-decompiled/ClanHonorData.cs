using GCommon;

public class ClanHonorData : CSVBaseData
{
	public int ID;

	public int Type;

	public int Upperlimit;

	public int Division;

	public float Honor;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
