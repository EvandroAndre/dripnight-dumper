using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAllSwitchsRes : IMessage
{
	public List<SwitchDesc> switchs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
