using GCommon;

namespace COW;

public class WorkshopMapExposureRankValue : CSVBaseData
{
	public string Region;

	public float MinExposurePotential;

	public float MaxExposusePotential;

	public int ExposureRank;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
