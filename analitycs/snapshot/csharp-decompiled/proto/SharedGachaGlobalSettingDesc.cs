using System.Collections.Generic;

namespace proto;

public class SharedGachaGlobalSettingDesc
{
	public string region;

	public string recommend_pool_type;

	public uint recommend_amount;

	public uint recommend_sharding_count;

	public uint recommend_sharding_capacity;

	public uint recommend_pool_refresh;

	public uint recommend_max_failed_count;

	public uint min_pool_count_per_sharding;

	public uint pool_create_wait_time;

	public List<ESharedGacha.RareType> history_tiers;

	public uint notify_account_count_max;

	public uint notify_account_count_interval;

	public double account_change_recommend_prob;

	public double drawn_item_recommend_prob;

	public uint online_total_seconds;

	public uint online_total_min_interval;

	public uint recommend_hysteresis;

	public uint expired_account_retention_seconds;
}
