using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GachaShowItemsWithJackpot : IMessage
{
	public List<GachaShowItem> items;

	public uint jackpot;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
