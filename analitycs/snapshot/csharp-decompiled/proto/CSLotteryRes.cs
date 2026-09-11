using System.Collections.Generic;

namespace proto;

public class CSLotteryRes
{
	public List<ExchangedAward> lottery_goods;

	public List<ExchangedAward> reward_goods;

	public uint lottery_count_weekly;

	public long next_free_time;

	public uint limit_purchase_count_one;

	public uint limit_purchase_count_ten;

	public uint not_got_num;

	public uint first_draw_reward_num;

	public List<ExchangeItemNum> exchange_item_num;

	public bool has_big_reward;

	public uint[] act_goods_ids;

	public uint act_progress;

	public uint energy_gacha_buff_display_one;

	public uint energy_gacha_buff_display_ten;

	public uint total_lottery_count;

	public bool is_lucky_spin;

	public uint[] new_removed_award_id_list;

	public List<ItemTagInfo> new_tag_items;

	public uint big_reward_sequence;

	public uint[] reward_goods_rare_ids;

	public int first_max_reward_lottery_count;

	public uint[] reward_lucky_points;

	public uint limit_purchase_count_ten2;

	public uint limit_purchase_count_ten3;

	public uint[] limited_pool_item_ids;
}
