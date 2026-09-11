using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetLiveDescRes : IMessage
{
	public List<LiveDesc> descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
