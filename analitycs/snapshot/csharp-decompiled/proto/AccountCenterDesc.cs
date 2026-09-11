using ProtoBuf;

namespace proto;

public class AccountCenterDesc : IMessage
{
	public string link;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
