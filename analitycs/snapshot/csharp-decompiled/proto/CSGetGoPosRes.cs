using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGoPosRes : IMessage
{
	public List<GoPos> go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
