using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSSquadTreasureDescsRes : IMessage
{
	public SquadTreasureSettingDesc squad_treasure_setting_desc;

	public List<SquadTreasureAwardDesc> squad_treasure_award_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
