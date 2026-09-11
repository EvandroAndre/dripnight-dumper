using ProtoBuf;

namespace proto;

public class MysteryShopExpressionDesc : IMessage
{
	public uint mystery_shop_id;

	public string discount_cdn;

	public string shop_enter_icon;

	public string web_link;

	public string web_link_cdn;

	public long start_timestamp;

	public long end_timestamp;

	public string language;

	public bool mab_switch;

	public uint sort_id;

	public string table_sprite;

	public string table_name;

	public string select_line;

	public uint theme_change;

	public bool evo_token_switch;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
