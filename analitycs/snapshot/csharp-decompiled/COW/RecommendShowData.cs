using GCommon;

namespace COW;

public class RecommendShowData : CSVBaseData
{
	public float HighKD;

	public float HighStreak;

	public float HighHeadShot;

	public float HighWinRate;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
