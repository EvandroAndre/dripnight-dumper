using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCDNSourceUpdateRes : IMessage
{
	public List<CDNSourceUpdateDesc> cdn_source_update_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
