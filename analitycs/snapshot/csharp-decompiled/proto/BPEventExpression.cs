using ProtoBuf;

namespace proto;

public class BPEventExpression : IMessage
{
	public uint ep_event_id;

	public uint token_id1;

	public uint go_pos1;

	public string sub_go_pos1;

	public uint token_id2;

	public uint go_pos2;

	public string sub_go_pos2;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
