using System.Collections.Generic;

namespace proto;

public class CSGetNewPlayerRewardsListRes
{
	public List<NewPlayerRewardItem> rewards;

	public ulong expire_time;
}
