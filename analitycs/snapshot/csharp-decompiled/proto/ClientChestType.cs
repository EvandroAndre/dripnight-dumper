using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ClientChestType : IMessage
{
	public uint chest_id;

	public uint priority;

	public uint coin_type;

	public string start_time;

	public string end_time;

	public string chest_name;

	public uint[] exchange_itemid;

	public uint free_type;

	public uint chest_activity;

	public uint chest_model_id;

	public long start_time_stamp;

	public long end_time_stamp;

	public uint once_price;

	public uint ten_price;

	public uint exchange_once_num;

	public uint exchange_ten_num;

	public uint once_num;

	public uint ten_num;

	public long limit_start_time;

	public long limit_end_time;

	public uint limit_num_one;

	public uint[] limit_price_one;

	public uint limit_num_ten;

	public uint[] limit_price_ten;

	public long discount_start_time;

	public long discount_end_time;

	public uint discount_price_one;

	public uint discount_price_ten;

	public uint show_model_male;

	public uint show_model_female;

	public uint rare_item_max;

	public uint second_level_count;

	public uint third_level_count;

	public uint[] extra_reward_reset_day;

	public uint chest_sub_id;

	public uint chest_model_id2;

	public bool drop_probability_switch;

	public uint open_priority_switch;

	public ELottery.Type type;

	public uint forge_tab_id;

	public uint extra_reward_icon;

	public uint chest_hint_color;

	public long drop_up_start_time;

	public long drop_up_end_time;

	public uint limit_type;

	public uint drop_up_price;

	public uint[] show_type;

	public uint[] multi_once_price;

	public uint[] price_one_type;

	public uint energy_gacha_buff_price;

	public uint energy_gacha_buff_reset_price;

	public uint legend_cloth_id;

	public uint independent_entrance_type;

	public bool is_tab_vfx;

	public List<ChestLayoutDesc> layouts;

	public uint animation_type;

	public bool is_cdn_quality;

	public bool lucky_hide;

	public uint is_token_tower_vfx;

	public uint[] token_max;

	public string entrance_bubble;

	public uint change_skin_type;

	public bool is_fresher;

	public uint number_of_rounds;

	public uint is_multiple_jackpot;

	public bool is_custom;

	public uint[] multi_model_id;

	public List<ClientDoubleWheelPrice> double_wheel_prices;

	public uint max_reward_id;

	public uint max_reward_expected_times;

	public long prime_start_time;

	public string chest_rule;

	public uint lucky_remind_switch;

	public uint custom_type;

	public uint[] exchange_item_id2;

	public uint exchange_once_num2;

	public uint exchange_ten_num2;

	public uint[] extra_reward_cnts;

	public List<ChestMultiPrice> multi_price_list;

	public uint[] discount_price_one_list;

	public List<DiscountMultiPrice> discount_multi_price_list;

	public uint discount_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
