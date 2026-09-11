using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetChatWebWhiteListRes : IMessage
{
	public List<ChatWebWhiteListDesc> descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
