using ProtoBuf;

namespace proto;

public class PrimePrivilegeDesc : IMessage
{
	public uint privilege_id;

	public string icon;

	public string privilege_name;

	public uint item_id1;

	public uint item_id2;

	public uint go_pos;

	public string sub_go_pos;

	public uint show_type;

	public bool can_close;

	public string go_pos_key;

	public uint guide_id;

	public bool is_client_show;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
