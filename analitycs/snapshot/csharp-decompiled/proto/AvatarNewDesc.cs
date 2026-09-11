using ProtoBuf;

namespace proto;

public class AvatarNewDesc : IMessage
{
	public uint avatar_id;

	public long start_timestamp;

	public long end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
