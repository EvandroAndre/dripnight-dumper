using ProtoBuf;

namespace proto;

public class DrawShopLimitedPoolSettingDesc : IMessage
{
	public uint draw_shop_id;

	public long prime_start_time;

	public long start_time;

	public long end_time;

	public string limited_pool_name;

	public string limited_pool_rule;

	public uint[] show_type;

	public uint display_model_id;

	public uint currency_type;

	public uint[] every_turn_goods_price;

	public long discount_start_time;

	public long discount_end_time;

	public uint[] every_turn_discount;

	public bool if_probability_show;

	public bool allow_free_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
