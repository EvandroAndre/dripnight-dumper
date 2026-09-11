using ProtoBuf;

namespace proto;

public class EighthBApplyDecoration : IMessage
{
	public uint placement_id;

	public uint decoration_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
