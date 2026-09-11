using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AccountFriendRes : IMessage
{
	public List<AccountInfoWithPresence> friends;

	public ulong[] star_friends;

	public List<FriendAliasInfo> friends_alias_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
