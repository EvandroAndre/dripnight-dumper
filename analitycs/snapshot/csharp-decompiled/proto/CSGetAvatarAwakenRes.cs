using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAvatarAwakenRes : IMessage
{
	public List<AvatarAwaken> infos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
