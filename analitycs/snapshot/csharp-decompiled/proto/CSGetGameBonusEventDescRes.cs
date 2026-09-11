using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGameBonusEventDescRes : IMessage
{
	public List<GameBonusEventDesc> game_bonus_events;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
