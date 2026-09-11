using GCommon;

namespace COW;

public class ClothEffectData : CSVBaseData, IGetId
{
	public uint quality;

	public uint effectMyCloth;

	public uint effectTeammateCloth;

	public uint effectEnemyCloth;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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
