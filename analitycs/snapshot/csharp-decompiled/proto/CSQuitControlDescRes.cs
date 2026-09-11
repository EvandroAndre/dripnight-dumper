using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSQuitControlDescRes : IMessage
{
	public List<QuitControlDesc> quit_control_settings;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
