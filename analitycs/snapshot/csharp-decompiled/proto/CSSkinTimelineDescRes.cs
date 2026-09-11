using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSSkinTimelineDescRes : IMessage
{
	public List<SkinTimelineDesc> desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
