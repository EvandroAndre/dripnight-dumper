using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetFullscreenCgRes : IMessage
{
	public List<FullscreenCgDesc> fullscreen_cgs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
