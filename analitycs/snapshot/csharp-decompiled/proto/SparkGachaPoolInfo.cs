using System.Collections.Generic;

namespace proto;

public class SparkGachaPoolInfo
{
	public bool unlocked;

	public List<SparkGachaPoolRewardInfo> rewards;

	public uint draw_count;

	public uint remaining_reward_count;

	public bool can_draw;
}
