using ProtoBuf;

namespace proto;

public class FriendAliasInfo : IMessage
{
	public ulong account_id;

	public string alias;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
