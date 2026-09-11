using ProtoBuf;

namespace proto;

public class ClanActiveShowDesc : IMessage
{
	public uint active_show_type;

	public uint range_down;

	public uint range_up;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
