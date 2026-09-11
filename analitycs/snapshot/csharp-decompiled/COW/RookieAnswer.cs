using GCommon;

namespace COW;

public class RookieAnswer : CSVBaseData
{
	public string Title;

	public string OtherChoice3;

	public string CorrectChoice;

	public string OtherChoice1;

	public string OtherChoice2;

	public int id;

	public int Rewardid;

	public int RewardCount;

	public int rewardtype;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
