using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSClanLuckyBagInfoDescRes : IMessage
{
	public List<ClanLuckyBagInfoDesc> lucky_bag_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
