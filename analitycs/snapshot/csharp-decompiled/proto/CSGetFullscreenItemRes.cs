using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetFullscreenItemRes : IMessage
{
	public List<FullscreenItemDesc> fullscreen_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
