using GCommon;

namespace COW;

public class SocialHallArenaSetting : CSVBaseData
{
	public string StartTime;

	public string EndTime;

	public uint PeriodTime;

	public uint TitleWinStreak;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
