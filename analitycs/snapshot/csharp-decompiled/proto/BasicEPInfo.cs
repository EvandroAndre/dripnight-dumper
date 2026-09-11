using ProtoBuf;

namespace proto;

public class BasicEPInfo : IMessage
{
	public uint ep_event_id;

	public bool owned_pass;

	public uint ep_badge;

	public uint badge_cnt;

	public string bp_icon;

	public uint max_level;

	public string event_name;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
