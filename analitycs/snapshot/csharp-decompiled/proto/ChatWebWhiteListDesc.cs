using ProtoBuf;

namespace proto;

public class ChatWebWhiteListDesc : IMessage
{
	public string white_list;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
