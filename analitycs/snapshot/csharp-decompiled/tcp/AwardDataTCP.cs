using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class AwardDataTCP : IMessage
{
	public List<ItemTCP> items;

	public uint coins;

	public uint gems;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
