using COW;

namespace proto;

public class GachaInfo
{
	public uint chest_id;

	public uint lottery_count_weekly;

	public uint[] exchanged_reward_list;

	public long next_free_time;

	public uint not_got_num;

	public uint limit_purchase_count_one;

	public uint limit_purchase_count_ten;

	public uint first_draw_reward_num;

	public uint total_lottery_count;

	public uint[] removed_rewards_id_list;

	public int first_max_reward_lottery_count;

	public uint limit_purchase_count_ten2;

	public uint limit_purchase_count_ten3;

	public uint[] limited_pool_item_ids;

	public UIModelGacha.LuckySpinState lucky_spin_state;
}
