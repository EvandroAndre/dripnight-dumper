using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ClanLuckyBagInfoDesc : IMessage
{
	public uint level;

	public List<AwardWithExtra> award;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
