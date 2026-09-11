using ProtoBuf;

namespace proto;

public class ShoppingMallScreenDesc : IMessage
{
	public uint index_id;

	public uint sort_id;

	public uint size_id;

	public string language;

	public string advertisement_url;

	public uint ad_start_time;

	public string ad_start_time_str;

	public uint ad_end_time;

	public string ad_end_time_str;

	public bool time_is_show;

	public uint go_pos;

	public string sub_go_pos;

	public uint go_pos_type;

	public uint item_id;

	public bool model_is_show;

	public uint tag;

	public uint discount;

	public bool class_is_open;

	public uint anim_id;

	public string preview_title;

	public uint preview_type;

	public bool is_effect;

	public string bg_cdn;

	public string sub_bg_cdn;

	public uint shopping_mall_type;

	public uint num_id;

	public string ad_count_down;

	public uint ad_count_down_timestamp;

	public bool is_prime;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
