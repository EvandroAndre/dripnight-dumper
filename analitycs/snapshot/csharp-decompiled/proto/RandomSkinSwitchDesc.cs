using ProtoBuf;

namespace proto;

public class RandomSkinSwitchDesc : IMessage
{
	public bool is_open;

	public uint type;

	public uint collection_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
