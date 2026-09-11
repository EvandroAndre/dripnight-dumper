using GCommon;

namespace COW;

public class VehicleSkinPropertyScoreData : CSVBaseData
{
	public uint ID;

	public string Name;

	public string Region;

	public int Damage;

	public int Speed;

	public int Acceleration;

	public int ReduceDamage;

	public int HP;

	public int Controllabilty;

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
