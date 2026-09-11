using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetFullscreenABTestRes : IMessage
{
	public List<FullscreenABTestDesc> fullscreen_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
