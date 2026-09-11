using ProtoBuf;

namespace proto;

public class NewModeBubbleDesc : IMessage
{
	public uint id;

	public string bubble_key;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
