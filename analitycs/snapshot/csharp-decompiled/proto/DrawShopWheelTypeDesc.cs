using ProtoBuf;

namespace proto;

public class DrawShopWheelTypeDesc : IMessage
{
	public uint draw_shop_id;

	public bool lucky_inherit_switch;

	public uint lucky_inherit_share_id;

	public bool lucky_hide;

	public long prime_start_time;

	public long start_time;

	public long end_time;

	public string chest_name;

	public string chest_rule;

	public uint second_level_count;

	public uint third_level_count;

	public uint rare_item_min;

	public uint rare_item_max;

	public bool drop_probability_switch;

	public uint show_type;

	public uint[] chest_model_id;

	public uint once_price;

	public uint batch_price;

	public uint[] exchange_item_id;

	public uint exchange_ratio;

	public uint[] exchange_item_id_2;

	public uint exchange_ratio_2;

	public bool free_switch;

	public uint free_cd;

	public uint carousel_time;

	public uint coin_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
