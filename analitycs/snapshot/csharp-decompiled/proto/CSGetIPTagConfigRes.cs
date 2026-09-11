using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetIPTagConfigRes : IMessage
{
	public List<IPTagConfigDesc> ip_tag_config;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
