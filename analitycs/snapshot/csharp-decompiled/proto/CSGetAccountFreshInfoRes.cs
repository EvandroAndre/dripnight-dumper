using System.Collections.Generic;

namespace proto;

public class CSGetAccountFreshInfoRes
{
	public uint day;

	public ulong expire_time;

	public List<FreshRewardItem> reward_items;

	public List<ActivityInfo> activitys;

	public bool[] guide_reward_claimed;

	public bool IsDefault()
	{
		return false;
	}
}
