using ProtoBuf;

namespace proto;

public class InGameQuickChatItemDesc : IMessage
{
	public uint group_id;

	public string group_name;

	public uint group_sort_id;

	public uint item_id;

	public uint sort_id;

	public long show_time;

	public long stop_show_time;

	public long start_time;

	public long end_time;

	public string go_pos_icon;

	public uint go_pos;

	public string sub_go_pos;

	public string group_res_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
