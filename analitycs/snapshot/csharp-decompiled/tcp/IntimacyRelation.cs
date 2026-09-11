using ProtoBuf;

namespace tcp;

public class IntimacyRelation : IMessage
{
	public ulong related_friend_id;

	public uint relation_type;

	public uint intimacy;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
