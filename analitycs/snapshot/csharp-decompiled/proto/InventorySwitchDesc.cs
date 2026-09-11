using ProtoBuf;

namespace proto;

public class InventorySwitchDesc : IMessage
{
	public bool new_load_out_open;

	public bool load_out_show;

	public long new_load_out_open_time;

	public long new_load_out_end_time;

	public bool match_room_open;

	public long load_out_show_end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
