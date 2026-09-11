using ProtoBuf;

namespace proto;

public class ActivityRowDesc : IMessage
{
	public uint row_id;

	public uint go_pos;

	public string sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
