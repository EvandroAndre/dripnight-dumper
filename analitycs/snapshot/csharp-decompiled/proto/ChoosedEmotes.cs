using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ChoosedEmotes : IMessage
{
	public List<ChoosedEmote> emotes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
