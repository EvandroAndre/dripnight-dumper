using ProtoBuf;

namespace proto;

public class DrawShopCommonDesc : IMessage
{
	public uint draw_shop_id;

	public uint open_priority_switch;

	public uint priority;

	public bool is_tab_vfx;

	public uint independent_entrance_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
