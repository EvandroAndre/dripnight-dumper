using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSNewModeBubbleDescRes : IMessage
{
	public List<NewModeBubbleDesc> new_mode_bubble_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
