using ProtoBuf;

namespace proto;

public class ChoosedEmote : IMessage
{
	public uint slot_id;

	public uint emote_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
