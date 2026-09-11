using GCommon;

namespace COW;

public class BRIngameLevelSource : CSVBaseData
{
	public string Icon;

	public uint[] RewardNum;

	public string Desc;

	public string DetailDesc;

	public string DetailTitle;

	public uint ID;

	public byte RewardType;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
