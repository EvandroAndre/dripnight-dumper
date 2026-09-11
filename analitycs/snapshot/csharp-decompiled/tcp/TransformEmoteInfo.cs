using ProtoBuf;

namespace tcp;

public class TransformEmoteInfo : IMessage
{
	public uint transform_emote_id;

	public uint transform_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
