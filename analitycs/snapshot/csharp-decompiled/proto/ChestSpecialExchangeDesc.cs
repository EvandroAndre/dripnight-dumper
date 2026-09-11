using System.Collections.Generic;

namespace proto;

public class ChestSpecialExchangeDesc
{
	public uint forge_tab_id;

	public string tab_name;

	public uint item_id;

	public uint item_num;

	public uint sort_id;

	public string added_time;

	public string expire_time;

	public uint limited_purchase_times;

	public string language;

	public string image_url;

	public List<AwardDesc> exchange_items;

	public uint reward_level;

	public string real_image_url;

	public uint purchase_times;

	public uint item_duration;

	public string effect_icon;

	public uint id;

	public uint type;

	public uint quick_show;

	public bool is_max_reward;
}
