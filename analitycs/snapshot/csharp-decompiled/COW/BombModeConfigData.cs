using GCommon;

namespace COW;

public class BombModeConfigData : CSVBaseData
{
	public uint BombPlantCastingTime;

	public uint BombRemoveCastingTime;

	public uint PliersRemoveCastingTime;

	public uint PliersID;

	public uint BombAliveTimeAfterSettle;

	public int[] RoundCountConfig;

	public uint BombMatchMaxTime;

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
