using GCommon;

namespace COW;

public class IntimacyPointsData : CSVBaseData
{
	public float ItemIntimacyDiamondRate;

	public float ItemIntimacyCoinRate;

	public int LikePoints;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
