using ProtoBuf;

namespace proto;

public class PString : IMessage
{
	public string val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
