using System.Collections.Generic;

namespace proto;

public class HippoStoreDesc
{
	public uint store_id;

	public uint sort_id;

	public uint item_id;

	public uint award_num;

	public long added_time;

	public long expire_time;

	public string name;

	public string desc;

	public List<HippoCostDesc> cost_price;

	public uint tag_type;

	public uint tag_value;

	public uint limited_purchase_times;

	public bool is_new;

	public string type_override;

	public bool is_original_type_remain;

	public bool is_recommended;

	public string image_url;

	public string language;

	public bool is_vfx;

	public string real_image_url;

	public List<HippoCostDesc> discount_price;

	public long discount_start_time;

	public long discount_end_time;

	public uint go_pos_type;

	public uint go_pos;

	public string sub_go_pos;

	public uint display_rare;

	public bool can_free_buy;

	public bool split_half;

	public uint split_amount;
}
