using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AwardDescList : IMessage
{
	public List<AwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
