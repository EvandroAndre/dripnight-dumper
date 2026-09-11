using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PrimeFestivalAwardDesc : IMessage
{
	public uint festival_id;

	public List<AwardDesc> Rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
