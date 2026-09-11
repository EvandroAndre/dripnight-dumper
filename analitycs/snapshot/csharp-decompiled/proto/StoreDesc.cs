using ProtoBuf;

namespace proto;

public class StoreDesc : IMessage
{
	public uint store_id;

	public uint sort_id;

	public uint item_id;

	public string added_time;

	public string expire_time;

	public string name;

	public uint coins_price;

	public uint gems_price;

	public EInventory.StoreTag tag_type;

	public uint tag_value;

	public uint limited_purchase_times;

	public uint purchase_times;

	public string type_override;

	public bool is_original_type_remain;

	public bool is_recommended;

	public string image_url;

	public string language;

	public bool is_vfx;

	public string real_image_url;

	public uint discount_price;

	public long discount_start_time;

	public long discount_end_time;

	public uint award_time;

	public long expire_timestamp;

	public uint go_pos_type;

	public uint go_pos;

	public uint award_num;

	public uint display_rare;

	public bool is_shadow;

	public uint pre_item;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
