using GCommon;

namespace COW;

public class ImpactPerformaceData : CSVBaseData
{
	public string MaterialType;

	public ResourceID EffectRes;

	public ResourceID SoundRes;

	public ResourceID DecalRes;

	public ResourceID DecalRes_1;

	public ResourceID DecalRes_2;

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
