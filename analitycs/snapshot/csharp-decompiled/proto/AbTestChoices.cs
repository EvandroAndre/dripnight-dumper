using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AbTestChoices : IMessage
{
	public List<AbTestChoice> choices;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
