using ProtoBuf;

namespace proto;

public class DrawShopTowerTypeDesc : IMessage
{
	public uint draw_shop_id;

	public bool lucky_hide;

	public long prime_start_time;

	public long start_time;

	public long end_time;

	public string chest_name;

	public string chest_rule;

	public bool drop_probability_switch;

	public uint[] token_max;

	public uint[] token_min;

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

	public uint[] token_diamonds;

	public uint coin_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
