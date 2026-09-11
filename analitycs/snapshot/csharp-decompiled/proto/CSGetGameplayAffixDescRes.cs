using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGameplayAffixDescRes : IMessage
{
	public List<GameplayAffixDesc> gameplay_affix_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
