using GCommon;

namespace COW;

public class SocialHallDanceSetting : CSVBaseData
{
	public string StartTime;

	public string EndTime;

	public uint TitleMinTime;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
