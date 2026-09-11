using System.Collections.Generic;

namespace COW;

public class AreaLeaderboardCacheInfo
{
	public List<LeaderBoardInfo> LeaderBoardInfoList;

	public LeaderBoardInfo SelfInfo;

	public uint Size;

	public float LastRequestTime;

	public int MainType;

	public void ClearLastRequestTime()
	{
	}
}
